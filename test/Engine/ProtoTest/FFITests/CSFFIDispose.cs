using System;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using ProtoTest.TD;
using ProtoTestFx.TD;
namespace ProtoFFITests
{
    class CSFFIDispose : FFITestSetup
    {
        readonly TestFrameWork thisTest = new TestFrameWork();

        [Test]
        public void Dispose01_NoFunctionCall()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            //thisTest.VerifyFFIObjectOutOfScope("vec1");
            //thisTest.VerifyFFIObjectOutOfScope("vec2");
            //thisTest.VerifyFFIObjectOutOfScope("vec3");
            //thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            //thisTest.VerifyFFIObjectOutOfScope("pt2");
            //thisTest.VerifyFFIObjectOutOfScope("pt3");
            //thisTest.VerifyReferenceCount("ptarr", 0);
        }

        [Test]
        public void Dispose02_FunctionNonArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose03_FunctionReplication()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose04_FunctionArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose05_StaticFunctionNonArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose06_StaticFunctionReplication()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose07_StaticFunctionNonArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose08_MemFunctionNonArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose09_MemFunctionReplication()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose10_MemFunctionArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose11_ReplicationNonArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose12_ReplicationReplication()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose13_ReplicationArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose14_GlobalFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose15_GlobalFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose16_GlobalFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose17_StaticFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose18_StaticFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose19_StaticFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose20_MemberFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectStillInScope("pt1", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose21_MemberFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose22_MemberFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose23_MemberFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose24_MemberFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose25_MemberFunctionTwoArguments()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose26_GlobalFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose27_GlobalFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose28_GlobalFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose29_MemberFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose30_MemberFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("arc1");
            thisTest.VerifyFFIObjectOutOfScope("arc2");
            thisTest.VerifyFFIObjectOutOfScope("arc3");
            thisTest.VerifyReferenceCount("arcarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose31_MemberFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose32_StaticFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose33_StaticFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose34_StaticFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose35_StaticFunctionReturnObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose36_StaticFunctionReturnObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose37_MemberFunctionReturnObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose38_MemberFunctionReturnObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose39_GlobalFunctionReturnObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose40_GlobalFunctionReturnObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectStillInScope("pt2", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt3");
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose41_MemberFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose42_MemberFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("arc1");
            thisTest.VerifyFFIObjectOutOfScope("arc2");
            thisTest.VerifyFFIObjectOutOfScope("arc3");
            thisTest.VerifyReferenceCount("arcarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose43_MemberFunctionReturnArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose44_MemberFunctionReturnObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose45_MemberFunctionReturnObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose46_GlobalFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose47_GlobalFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose48_GlobalFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
        }

        [Test]
        public void Dispose49_MemberFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose50_MemberFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("arc1");
            thisTest.VerifyFFIObjectOutOfScope("arc2");
            thisTest.VerifyFFIObjectOutOfScope("arc3");
            thisTest.VerifyReferenceCount("arcarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose51_MemberFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose52_StaticFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose53_StaticFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose54_StaticFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose55_StaticFunctionReturnNewObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose56_StaticFunctionReturnNewObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose57_MemberFunctionReturnNewObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose58_MemberFunctionReturnNewObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose59_GlobalFunctionReturnNewObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose60_GlobalFunctionReturnNewObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose61_MemberFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose62_MemberFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("arc1");
            thisTest.VerifyFFIObjectOutOfScope("arc2");
            thisTest.VerifyFFIObjectOutOfScope("arc3");
            thisTest.VerifyReferenceCount("arcarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose63_MemberFunctionReturnNewArray()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose64_MemberFunctionReturnNewObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }

        [Test]
        public void Dispose65_MemberFunctionReturnNewObject()
        {
            String code =
            @"              
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectOutOfScope("pt1");
            thisTest.VerifyFFIObjectOutOfScope("pt2");
            thisTest.VerifyFFIObjectStillInScope("pt3", 0);
            thisTest.VerifyReferenceCount("ptarr", 0);
            thisTest.VerifyFFIObjectOutOfScope("vec1");
            thisTest.VerifyFFIObjectOutOfScope("vec2");
            thisTest.VerifyFFIObjectOutOfScope("vec3");
            thisTest.VerifyReferenceCount("vecarr", 0);
            thisTest.VerifyReferenceCount("test", 0);
            thisTest.VerifyReferenceCount("a1", 0);
            thisTest.VerifyReferenceCount("a2", 0);
            thisTest.VerifyReferenceCount("a3", 0);
            thisTest.VerifyReferenceCount("as", 0);
        }


        [Test]
        public void Dispose66_CircleCenterPointInScope()
        {
            String code =
            @"   
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.VerifyFFIObjectStillInScope("pointsArrayGP", 0, 0);
        }

        [Test]
        public void Dispose67_PointInScope()
        {
            String code =
            @"   
            object[] a = new object[] { 0.0, 0.0, 0.0 };
            ValidationData[] data = { new ValidationData { ValueName = "carr", ExpectedValue = a, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }
    }
}