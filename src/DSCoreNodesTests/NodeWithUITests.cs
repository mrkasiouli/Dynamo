﻿using DSCoreNodes;
using Dynamo.Nodes;
using NUnit.Framework;
// NOTE: The following namespace has been updated. This test use to fail in unit 
// test, the reason is that LibGNet.dll could not be loaded. That was because the
// right "AppDomain.CurrentDomain.AssemblyResolve" callback has not been set to 
// resolve the library path when this test is run.
// 
// Where is "AppDomain.CurrentDomain.AssemblyResolve" set? It is the "Setup" 
// class this project which is marked as "SetUpFixture". The "Setup" class is 
// responsible in setting "AssemblyResolve" callback that will eventually help 
// resolving the path to LibGNet.dll. But the set-up fixture wasn't called due 
// to the fact that it was residing in a different namespace (Dynamo.Tests) 
// while "NodeSampleTests" resides in "Dynamo.Nodes". So by relocating the 
// "NodeSampleTests" to "Dynamo.Tests" helps NUnit locating the "Setup" class. 
// 
using ProtoCore.AST.AssociativeAST;

namespace NodeWithUITests
{
    [TestFixture]
    class NodeWithUITests
    {
        [Test]
        public void SliderASTGeneration()
        {
            var sliderNode = new NumberSlider { Value = 10 };
            var buildOutput = sliderNode.BuildAst();

            Assert.IsInstanceOf<DoubleNode>(buildOutput);
            Assert.AreEqual(new DoubleNode("10").value, (buildOutput as DoubleNode).value);
        }
    }
}