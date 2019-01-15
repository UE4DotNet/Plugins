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
        ///<summary>Legacy struct for handling back compat serialization</summary>
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        public unsafe struct ClothingAssetData_Legacy {
            [FieldOffset(0)] public Name AssetName;

            [FieldOffset(16)] byte ApexFileName; //TODO: string FString ApexFileName

            [FieldOffset(32)] public bool bClothPropertiesChanged;

            ///<summary>Physics Properties</summary>
            [FieldOffset(36)] ClothPhysicsProperties_Legacy PhysicsProperties;

        }
}
