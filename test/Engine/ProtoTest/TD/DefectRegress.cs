using System;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using ProtoFFI;
using ProtoTestFx.TD;
namespace ProtoTest.TD
{
    class DefectRegress
    {
        public ProtoCore.Core core;
        public TestFrameWork thisTest = new TestFrameWork();
        string importPath = "..\\..\\..\\Tests\\ProtoTest\\ImportFiles\\";
        [SetUp]
        public void Setup()
        {
            core = new ProtoCore.Core(new ProtoCore.Options());
            core.Executives.Add(ProtoCore.Language.kAssociative, new ProtoAssociative.Executive(core));
            core.Executives.Add(ProtoCore.Language.kImperative, new ProtoImperative.Executive(core));
            DLLFFIHandler.Register(FFILanguage.CSharp, new CSModuleHelper());
            DLLFFIHandler.Register(FFILanguage.CPlusPlus, new PInvokeModuleHelper());
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1455643()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("areEqual1", true);
            thisTest.Verify("areEqual2", false);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1455621()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1455158()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("x3", 3);
            thisTest.Verify("y3", 4);
        }

        [Test]
        public void Regress_1455618()
        {
            //Assert.Fail("1467188 - Sprint24 : rev 3170: REGRESSION : instantiating a class more than once with same argument is causing DS to go into infinite loop!");
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("x", 1.0);
            thisTest.Verify("y", 1.0);
            thisTest.Verify("z", 1.0);
            thisTest.Verify("h", 0.0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1455584()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("multiply1", 40.0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1455729()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a", 2);//Compilation test.
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1455738()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("b", 8);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1455276()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("dist", 100.0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454980()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code, "", importPath);
            thisTest.Verify("result", 9);
        }

        [Test]
        public void Regress_1455568()
        {
            //Assert.Fail("1467188 - Sprint24 : rev 3170: REGRESSION : instantiating a class more than once with same argument is causing DS to go into infinite loop!");
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("RX", 1.0);
            thisTest.Verify("RY", 1.0);
            thisTest.Verify("RZ", 1.0);
            thisTest.Verify("RH", 1.0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1455291()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a", 5);
            //This is more of a test for compilation. 
        }

        [Test]
        public void Regress_1454075()
        {
            string dscode = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(dscode);
            //Compilation test. 
        }

        [Test]
        public void Regress_1454723()
        {
            string dscode = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(dscode);
            thisTest.Verify("ten", 100.0);
        }

        [Test]
        public void Regress_1457064()
        {
            string dscode = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(dscode);
            object[] expectedResult = { 0.0, 180.0, 360.0 };
            thisTest.Verify("result", expectedResult, 0);
        }

        [Test]
        public void Regress_1456921()
        {
            string dscode = @"
            // Assert.Fail("1456921 - Sprint 20: Rev 2088: (negative), null expected when using an undefined variable ranged expression"); 
            string errmsg = "DNL-1467454 Rev 4596 : Regression : CompilerInternalException coming from undefined variable used in range expression";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(dscode, errmsg);
            object expectedResultc = null;
            thisTest.Verify("d", expectedResultc);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454697()
        {
            String code =
            @"    def foo : double (array : double[])
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            //Verification
            object arr2 = 1.0;
            thisTest.Verify("arr2", arr2, 0);
        }

        [Test]
        public void Regress_1457179()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code, "", importPath);
            //Verification
            object result1 = 180.0;
            object result2 = 180.0;
            thisTest.Verify("result1", result1, 0);
            thisTest.Verify("result2", result2, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458561()
        {
            Object[] t1 = new Object[] { 10, 20 };
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("t1", t1, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458785()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a3", 2, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458785_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object[] expectedResult = new Object[] { 1 };
            thisTest.Verify("a1", expectedResult, 0);
            thisTest.Verify("a2", 3, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458785_3()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object expectedResult = null;
            thisTest.Verify("y1", expectedResult, 0);
            thisTest.Verify("z1", 2, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458785_4()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454692()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("x", 6, 0);
            thisTest.Verify("y", 3, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454692_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] expectedresult = new Object[] { 0.0, 1.0, 2.0, 3.0 };
            thisTest.Verify("num", 4, 0);
            thisTest.Verify("arr", expectedresult, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1455935()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("b", 1, 0);
            thisTest.Verify("c", 1, 0);
            thisTest.Verify("d", 3, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1457862()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] x1 = new Object[] { 1.0, 2.0, 3.0, 4.0 };
            Object[] a = new Object[] { 1.0, 2.0, 3.0, 4.0 };
            Object[] a1 = new Object[] { 1, 2, 3, 4 };
            Object[] a2 = new Object[] { 1, 2, 3, 4 };
            thisTest.Verify("a3", 1, 0);
            thisTest.Verify("a4", 3, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1457885()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] c1 = new Object[] { 5 };
            // Object[] c2 = new Object[] {0.2,0.3};
            thisTest.Verify("c", c1, 0);
            //               thisTest.Verify("a",c2, 0);
        }

        [Test]
        public void Regress_1454966()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            //Assert.Fail("1460965 - Sprint 18 : Rev 1700 : Design Issue : Accessing properties from collection of class instances using the dot operator should yield a collection of the class properties");
            //thisTest.Verify("a1", new Object[] { new Object[] { 1, 1, 1 }, new Object[] { 2, 2, 2 }, new Object[] { 3, 3, 3 } });
            thisTest.Verify("a1", 1);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454966_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("x", 3, 0);
        }

        [Test]
        [Category("Dot Op")]
        public void Regress_1454966_3()
        {
            //    Assert.Fail("1454966 - Sprint15: Rev 720 : [Geometry Porting] Assignment operation where the right had side is Class.Constructor.Property is not working"); 
            string errmsg = "DNL-1467177 sprint24: rev 3152 : REGRESSION : Replication should not be supported in Imperative scope";
            string src = @"class A
{    
	a : var[];    
	constructor A ( b : int )    
	{        
		a = { b, b, b };    
	}		
	
}
[Imperative]
{
	x = { 1, 2, 3 };
	a1 = A.A( x ).a;
	a2 = A.A( x );
	t1 = a2[0].a[0];
	t2 = a2[1].a[1];
	t3 = a2[2].a[2];
	a3 = a2[0].a[0] + a2[1].a[1] +a2[2].a[2];
	
}";
            ExecutionMirror mirror = thisTest.VerifyRunScriptSource(src, errmsg);
            Object[] x = new Object[] { 1, 2, 3 };
            //Object[] a1 = new Object[] { 1, 1, 1 };
            Object[][] a1 = new Object[][] { new object[] { 1, 1, 1 }, new object[] { 2, 2, 2 }, new object[] { 3, 3, 3 } };
            thisTest.Verify("x", x);
            thisTest.Verify("a1", a1);
            //thisTest.Verify("a2", a2);
            thisTest.Verify("t1", 1);
            thisTest.Verify("t2", 2);
            thisTest.Verify("t3", 3);
            thisTest.Verify("a3", 6);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454966_4()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] x = new Object[] { 1.3, 3.0, 5.0 };
            object c = null;
            thisTest.Verify("getval", x, 0);
        }

        [Test]
        public void Regress_1454966_5()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] x = new Object[] { 1.3, 3.0, 5.0 };
            //Assert.Fail("1454966 - Sprint15: Rev 720 : [Geometry Porting] Assignment operation where the right had side is Class.Constructor.Property is not working");
            thisTest.Verify("getval", x, 0);
            thisTest.Verify("getval2", 1.3, 0);
            thisTest.Verify("getval3", 5.0, 0);
            thisTest.Verify("getval4", 5.0, 0);
            thisTest.Verify("getval5", 5.0, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454966_6()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("c", 1.3, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454966_7()
        {
            Object[] x = new Object[] { 1.0, 2.0, 3.0 };
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a1", x, 0);
        }

        [Test]
        public void Regress_1454966_8()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("t1", 2, 0);
        }

        [Test]
        public void Regress_1454966_9()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("b2", 0, 0);
        }

        [Test]
        public void Regress_1454966_10()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("t1", 1, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456895()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] x = new Object[] { 3, 3 };
            thisTest.Verify("d", x, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456895_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] x = new Object[] { 3, 3 };
            thisTest.Verify("c", x, 0);
            thisTest.Verify("d", 3, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456895_3()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] arr = new Object[] { 0.0, 1.0, 2.0, 3.0 };
            thisTest.Verify("arr", arr, 0);
            thisTest.Verify("num", 4, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456713()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a", 2.3, 0);
            thisTest.Verify("b", 6.9, 0);
            thisTest.Verify("c", 2.32, 0);
            thisTest.Verify("d", 6.96, 0);
            thisTest.Verify("e1", 0.31, 0);
            thisTest.Verify("f", 0.93, 0);
            thisTest.Verify("g", 1.1, 0);
            thisTest.Verify("h", 2.53, 0);
            thisTest.Verify("i", 0.99999, 0);
            thisTest.Verify("j", 1.99998, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454511()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("x", 0, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456758()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a", -1, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459175()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object expectedResultc = null;
            thisTest.Verify("a1", expectedResultc, 0);
            thisTest.Verify("a2", expectedResultc, 0);
            thisTest.Verify("a3", expectedResultc, 0);
        }
        [Test, Ignore]
        [Category("Type System")]
        public void Regress_1459175_2()
        {
            Assert.Inconclusive();
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("test", 1, 0);
            thisTest.Verify("test2", 10, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1457903()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object expectedResultc = null;
            thisTest.Verify("a", expectedResultc, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458918_1()
        {
            // Assert.Fail("1467247 - Sprint25: rev 3448 : REGRESSION : Runtime exception thrown when setting a private property of a class instance");
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a1", 3, 0);
            thisTest.Verify("a2", null, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458918_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("test3", 5, 0);
            thisTest.Verify("test5", 4, 0);
        }

        [Test]
        [Category("Type System")]
        public void Regress_1454918_1()
        {
            //Assert.Fail("1467156 - Sprint 25 - Rev 3026 type checking of return types at run time ");
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("d", 2.5);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454918_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("d", 6, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454918_3()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("d", 5.0, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454918_4()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object c = null;
            thisTest.Verify("d", c, 0);
        }

        [Test]
        [Category("Type System")]
        public void Regress_1454918_5()
        {
            //Assert.Fail("1467156 - Sprint 25 - Rev 3026 type checking of return types at run time ");
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object c = null;
            thisTest.Verify("d", c, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454918_6()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("d", 5.0, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456611()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("y", 3, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456611_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("numpts", 2, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456611_3()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456611_4()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("numpts", 5, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456611_5()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("numpts", 1, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456611_6()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object c = null;
            thisTest.Verify("numpts", c, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1456611_7()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object c = null;
            thisTest.Verify("numpts", c, 0);
        }

        [Test]
        public void Regress_1456611_8()
        {
            //Assert.Fail("Sub-recursion calls with auto promotion on jagged arrays is not working");
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("t1", 0, 0);
            thisTest.Verify("t2", 10, 0);
            thisTest.Verify("t3", 5, 0);
        }

        [Test]
        [Category("Type System")]
        public void Regress_1456611_9()
        {
            //Assert.Fail("DNL-1467208 Auto-upcasting of int -> int[] is not happening on function return");
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("numpts", 0, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459372()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] x = new Object[] { 2, 3, 2 };
            thisTest.Verify("collection", x, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459512()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459171_1()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459171_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object[] e1 = {  new object[] {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12},
            thisTest.Verify("e1", e1);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458916()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458915()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("c1", 1, 0);
            thisTest.Verify("c2", 2, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458915_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("t", 1, 0);
        }


        [Test]
        [Category("SmokeTest")]
        public void Regress_1458915_3()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("x1", 5, 0);
            thisTest.Verify("y1", 5, 0);
            thisTest.Verify("y2", 5, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459584()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] numpts = new object[] { 0, 10 };
            thisTest.Verify("test", 0, 0);
            thisTest.Verify("test2", 10, 0);
        }

        [Test]
        [Category("Type System")]
        public void Regress_1459584_1()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a", 0, 0);
            thisTest.Verify("b", 10, 0);
            thisTest.Verify("c1", 2, 0);
        }

        [Test]
        [Category("Type System")]
        public void Regress_1459584_2()
        {
            //Assert.Fail("1467196 Sprint 25 - Rev 3216 - [Design Issue] when rank of return type does not match the value returned what is the expected result ");
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a", 0, 0);
            thisTest.Verify("b", null, 0);
        }

        [Test]
        [Category("Type System")]
        public void Regress_1459584_3()
        {
            //Assert.Fail("1467196 Sprint 25 - Rev 3216 - [Design Issue] when rank of return type does not match the value returned what is the expected result ");
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            //   thisTest.Verify("a", 0, 0);
            //  thisTest.Verify("b", 10, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459584_4()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("numpts", 1, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459584_5()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("numpts", 1.0, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459584_6()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] numpts = new object[] { 0, 10 };
            thisTest.Verify("test", 0, 0);
            thisTest.Verify("test2", 10, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459584_7()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object c = null;
            thisTest.Verify("numpts", c, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459584_8()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object c = null;
            thisTest.Verify("numpts", c, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458475()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("b1", 2, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458475_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("b1", 2, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458187()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a", 6.0, 0);
            thisTest.Verify("b", 6, 0);
            thisTest.Verify("c", 0, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458187_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1458187_3()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object c = null;
            thisTest.Verify("a", c, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1454926()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object result = null;
            thisTest.Verify("result", result, 0);
            thisTest.Verify("result2", result, 0);
        }

        [Test]
        [Category("Escalate")]
        [Category("SmokeTest")]
        public void Regress_1455283()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("x", 10.0, 0);
            thisTest.Verify("y", 20.0, 0);
            thisTest.Verify("z", 30.0, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1455283_1()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("b1", 1, 0);
            thisTest.Verify("b2", 1.5, 0);
            thisTest.Verify("b3", 2, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459900()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459900_1()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1459762()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            object r2 = null;
            thisTest.Verify("r2", r2, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1452951()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("x", 9, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1457023()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] arr = new object[] { 0.0, 1.0, 2.0, 3.0 };
            thisTest.Verify("arr", arr, 0);
            thisTest.Verify("num", 4, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1457023_1()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] arr = new object[] { 0.0, 1.0, 2.0, 3.0 };
            thisTest.Verify("arr", arr, 0);
            thisTest.Verify("num", 4, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1457023_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Object[] b2 = new object[] { 2.0, 3.0, 4.0 };
            thisTest.Verify("b2", b2, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1457023_3()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code, "", importPath);
            thisTest.Verify("vec_len", 12.5, 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void Regress_1457023_4()
        {
            //Assert.Fail("1463372 - Sprint 20 : Rev 2088 : Imperative code is not allowed in class constructor "); 
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a1", 1);
        }

        [Test]
        [Category("SmokeTest")]
        public void myTest()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("Type System")]
        public void Regress_1462308()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            // Assert.Fail("1467119 Sprint24 : rev 2807 : Type conversion issue with char");
            thisTest.Verify("f", 102);
            thisTest.Verify("F", 70);
        }

        [Test]
        public void Regress_1467091()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            TestFrameWork.VerifyBuildWarning(ProtoCore.BuildData.WarningID.kIdUnboundIdentifier);
            if (!core.Options.SuppressFunctionResolutionWarning)
            {
                TestFrameWork.VerifyBuildWarning(ProtoCore.BuildData.WarningID.kFunctionNotFound);
            }
            thisTest.Verify("y1", null);
            thisTest.Verify("y2", null);
        }

        [Test]
        public void Regress_1467094_1()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("x", null);
            thisTest.Verify("y", null);
            thisTest.Verify("z", 1);
        }

        [Test]
        public void Regress_1467094_2()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("t4", null);
        }

        [Test]
        public void Regress_1467104()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aa", null);
        }

        [Test]
        public void Regress_1467107()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("y", null);
            TestFrameWork.VerifyRuntimeWarning(ProtoCore.RuntimeData.WarningID.kDereferencingNonPointer);
        }

        [Test]
        public void Regress_1467117()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("a", 1);
            thisTest.VerifyBuildWarningCount(0);
        }

        [Test]
        public void Regress_1467273()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("d", 1);
            thisTest.VerifyBuildWarningCount(0);
        }

        [Test]
        public void Regress_1467318()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("t", new object[] { 2, 3 });
            thisTest.VerifyBuildWarningCount(0);
        }

        [Test]
        public void Regress_1467505_gc_issue()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            //thisTest.Verify("t", new object[] { 2, 3 });
            thisTest.VerifyBuildWarningCount(0);
        }
    }
}