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
        ///<summary>Struct to help hold information about packages needing to be fully-loaded for DLC, etc.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct FullyLoadedPackagesInfo {
            [FieldOffset(0)] public byte FullyLoadType;

            [FieldOffset(8)] byte Tag; //TODO: string FString Tag

            [FieldOffset(24)] byte PackagesToLoad; //TODO: array TArray PackagesToLoad

            [FieldOffset(40)] byte LoadedObjects; //TODO: array TArray LoadedObjects

        }
}
