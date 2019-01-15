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
        ///<summary>Material Layers Functions</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct MaterialLayersFunctions {
            [FieldOffset(0)] byte Layers; //TODO: array TArray Layers

            [FieldOffset(16)] byte Blends; //TODO: array TArray Blends

            [FieldOffset(32)] byte LayerNames; //TODO: array TArray LayerNames

            [FieldOffset(48)] byte RestrictToLayerRelatives; //TODO: array TArray RestrictToLayerRelatives

            [FieldOffset(64)] byte RestrictToBlendRelatives; //TODO: array TArray RestrictToBlendRelatives

            [FieldOffset(80)] byte LayerStates; //TODO: array TArray LayerStates

            [FieldOffset(96)] byte KeyString; //TODO: string FString KeyString

        }
}
