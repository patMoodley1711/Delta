﻿using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("PemPlugin")]
[assembly: AssemblyDescription(ThisAssembly.Description)]
[assembly: AssemblyVersion(ThisAssembly.PluginVersion)]
[assembly: AssemblyFileVersion(ThisAssembly.PluginVersion)]
[assembly: ComVisible(false)]

partial class ThisAssembly
{
    public const string PluginVersion = "1.0.0.0";
    public const string Description = "PEM Format Document handler";
}