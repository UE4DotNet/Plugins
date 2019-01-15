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

using UE4.Engine;

namespace UE4.BlueprintNativeCodeGen{
        ///<summary>FBlueprintNativeCodeGenManifest</summary>
        [StructLayout( LayoutKind.Explicit, Size=344 )]
        public unsafe struct BlueprintNativeCodeGenManifest {
            [FieldOffset(0)] public int ManifestChunkId;

            [FieldOffset(8)] byte PluginName; //TODO: string FString PluginName

            [FieldOffset(24)] byte OutputDir; //TODO: string FString OutputDir

            [FieldOffset(40)] byte ModuleDependencies; //TODO: array TArray ModuleDependencies

            [FieldOffset(56)] byte ConvertedAssets; //TODO: map TMap ConvertedAssets

            [FieldOffset(136)] byte UnconvertedDependencies; //TODO: map TMap UnconvertedDependencies

            ///<summary>Nativization Options</summary>
            [FieldOffset(216)] CompilerNativizationOptions NativizationOptions;

        }
}
