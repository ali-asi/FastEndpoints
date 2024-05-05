﻿using Xunit.Extensions.AssemblyFixture;
using Xunit.Sdk;

namespace FastEndpoints.Testing;

[AttributeUsage(AttributeTargets.Assembly), TestFrameworkDiscoverer("Xunit.Sdk.TestFrameworkTypeDiscoverer", "xunit.execution.{Platform}")]
public sealed class EnableAssemblyFixturesAttribute : Attribute, ITestFrameworkAttribute
{
    public EnableAssemblyFixturesAttribute(string _ = AssemblyFixtureFramework.TypeName, string __ = AssemblyFixtureFramework.AssemblyName) { }
}