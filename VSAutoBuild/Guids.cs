// Guids.cs
// MUST match guids.h
using System;

namespace ko2ic.VSAutoBuild
{
    static class GuidList
    {
        public const string guidVSAutoBuildPkgString = "93886bd2-b6b3-4110-8e4a-9c2d89bae3b5";
        public const string guidVSAutoBuildCmdSetString = "b431b6b2-a0dd-44d4-9c21-e719c5bfc722";

        public static readonly Guid guidVSAutoBuildCmdSet = new Guid(guidVSAutoBuildCmdSetString);
    };
}