using System;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using ProtoTest.TD;
using ProtoTestFx.TD;
namespace ProtoTest.Associative
{
    class MethodResolution
    {
        public ProtoCore.Core core;
        public TestFrameWork thisTest = new TestFrameWork();
        [SetUp]
        public void Setup()
        {
            core = new ProtoCore.Core(new ProtoCore.Options());
            core.Executives.Add(ProtoCore.Language.kAssociative, new ProtoAssociative.Executive(core));
            core.Executives.Add(ProtoCore.Language.kImperative, new ProtoImperative.Executive(core));
        }

        [Test]
        public void SimpleCtorResolution01()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("x").Payload == 123);
            Assert.IsTrue((Int64)mirror.GetValue("y").Payload == 345);
        }

        [Test]
        public void SimpleCtorResolution02()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("x").Payload == 123);
            Assert.IsTrue((Int64)mirror.GetValue("y").Payload == 345);
            Assert.IsTrue((Int64)mirror.GetValue("x2").Payload == 1);
            Assert.IsTrue((Int64)mirror.GetValue("y2").Payload == 2);
        }

        [Test]
        public void SimpleCtorResolution03()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("x").Payload == 200);
            Assert.IsTrue((Int64)mirror.GetValue("y").Payload == 800);
        }

        [Test]
        public void SimpleCtorResolution04()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((double)mirror.GetValue("d").Payload == 1);
        }

        [Test]
        public void TestMethodOverload1()
        {
            string code =
                @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 1);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        public void TestMethodOverload2()
        {
            string code =
                @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 1);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        public void TestMethodOverload3()
        {
            string code =
                @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 1);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        public void TestMethodOverload4()
        {
            string code =
                @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 2);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        public void TestMethodResolutionOverInheritance()
        {
            string code =
                @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 1);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        public void TestMethodOverlaodAndArrayInput1()
        {
            string code =
                @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 2);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        public void TestMethodOverlaodAndArrayInput2()
        {
            string code =
                @"

            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("val", 2);
            thisTest.VerifyBuildWarningCount(0);
        }

        [Test]
        public void TestMethodOverlaodAndArrayInput3()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("val", 2);
            thisTest.VerifyBuildWarningCount(0);
        }

        [Test]
        public void TestMethodOverlaodAndArrayInput4()
        {
            string code =
                @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val1").Payload == -1);
            Assert.IsTrue((Int64)mirror.GetValue("val2").Payload == -1);
            Assert.IsTrue((Int64)mirror.GetValue("val3").Payload == -1);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        public void TestMethodOverlaodAndArrayInput4Min()
        {
            string code =
                @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val1").Payload == -1);
            Assert.IsTrue((Int64)mirror.GetValue("val2").Payload == -1);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        [Category("Method Resolution")]
        public void TestStaticDispatchOnArray()
        {
            //Recorded as defect: DNL-1467146
            string code =
                @"class A
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 100);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        [Category("Method Resolution")]
        [Category("Escalate")]
        public void TestStaticDispatchOnEmptyArray()
        {
            string code =
                @"class A
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            //Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 100);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        public void TestMethodOverlaodAndArrayInput5()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("val", 2);
            thisTest.VerifyBuildWarningCount(0);
        }

        [Test]
        public void TestMethodOverlaodAndArrayInput6()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("val", 2);
            thisTest.VerifyBuildWarningCount(0);
        }

        [Test]
        public void TestMethodWithArrayInput1()
        {
            string code = @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 123);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        public void TestMethodWithArrayInput2()
        {
            string code = @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 123);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        [Category("Method Resolution")]
        public void TestMethodWithArrayInputOverload()
        {
            string code = @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 2);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        [Category("Method Resolution")]
        public void TestMethodWithArrayInputOverloadDirectType()
        {
            string code = @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val").Payload == 2);
            Assert.IsTrue(core.BuildStatus.WarningCount == 0);
        }

        [Test]
        public void TestMethodWithOverrides()
        {
            string code = @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("val1").Payload == 1);
            //Assert.IsTrue((Int64)mirror.GetValue("val2").Payload == 2);
        }

        [Test]
        public void TestOverridenMethod()
        {
            string code = @"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            //Assert.IsTrue((Int64)mirror.GetValue("val1").Payload == 1);
            Assert.IsTrue((Int64)mirror.GetValue("val2").Payload == 2);
        }

        [Test]
        public void TestMethodResolutionForSingleton()
        {
            string code = @"
            string error = "";
            thisTest.VerifyRunScriptSource(code, error);
            thisTest.Verify("d", 2);
        }

        [Test]
        public void TestMethodResolutionForArray()
        {
            string code = @"
            string error = "";
            thisTest.VerifyRunScriptSource(code, error);
            // r1 and r2 are not necessary to be {1, 1, 1}, they can be {2, 2, 2}, 
            // but it'd better that they are same.
            thisTest.Verify("r1", new object[] { 1, 1, 1 });
            thisTest.Verify("r2", new object[] { 1, 1, 1 });
        }

        [Test]
        public void TestMethodResolutionForInforLoss()
        {
            string code = @"
            string error = "";
            thisTest.VerifyRunScriptSource(code, error);
            thisTest.Verify("r", 282);

        }

        [Test]
        public void TestMethodResultionForNonExistType()
        {
            string code = @"
            string error = "";
            thisTest.VerifyRunScriptSource(code, error);
            thisTest.Verify("z", null);
        }
    }
}