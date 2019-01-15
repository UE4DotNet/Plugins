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
        ///<summary>Contains all the information needed to identify a single permutation of static parameters.</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct StaticParameterSet {
            [FieldOffset(0)] byte StaticSwitchParameters; //TODO: array TArray StaticSwitchParameters

            [FieldOffset(16)] byte StaticComponentMaskParameters; //TODO: array TArray StaticComponentMaskParameters

            [FieldOffset(32)] byte TerrainLayerWeightParameters; //TODO: array TArray TerrainLayerWeightParameters

            [FieldOffset(48)] byte MaterialLayersParameters; //TODO: array TArray MaterialLayersParameters

        }
}
