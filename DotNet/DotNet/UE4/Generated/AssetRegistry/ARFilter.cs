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


namespace UE4.AssetRegistry{
        ///<summary>A struct to serve as a filter for Asset Registry queries. Each component element is processed as an 'OR' operation while all the components are processed together as an 'AND' operation.</summary>
        [StructLayout( LayoutKind.Explicit, Size=232 )]
        public unsafe struct ARFilter {
            [FieldOffset(0)] byte PackageNames; //TODO: array TArray PackageNames

            [FieldOffset(16)] byte PackagePaths; //TODO: array TArray PackagePaths

            [FieldOffset(32)] byte ObjectPaths; //TODO: array TArray ObjectPaths

            [FieldOffset(48)] byte ClassNames; //TODO: array TArray ClassNames

            [FieldOffset(144)] byte RecursiveClassesExclusionSet; //TODO: set TSet RecursiveClassesExclusionSet

            [FieldOffset(224)] public bool bRecursivePaths;

            [FieldOffset(225)] public bool bRecursiveClasses;

            [FieldOffset(226)] public bool bIncludeOnlyOnDiskAssets;

        }
}
