// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;


namespace UE4.Engine{
        ///<summary>Compiler Nativization Options</summary>
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        public unsafe struct CompilerNativizationOptions {
            [FieldOffset(0)] public Name PlatformName;

            [FieldOffset(12)] public bool ServerOnlyPlatform;

            [FieldOffset(13)] public bool ClientOnlyPlatform;

            [FieldOffset(14)] public bool bExcludeMonolithicHeaders;

            [FieldOffset(16)] byte ExcludedModules; //TODO: array TArray ExcludedModules

            [FieldOffset(32)] byte ExcludedAssets; //TODO: set TSet ExcludedAssets

            [FieldOffset(112)] byte ExcludedFolderPaths; //TODO: array TArray ExcludedFolderPaths

        }
}
