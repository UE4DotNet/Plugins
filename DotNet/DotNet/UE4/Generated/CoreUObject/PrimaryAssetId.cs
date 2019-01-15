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


namespace UE4.CoreUObject{
        ///<summary>This identifies an object as a "primary" asset that can be searched for by the AssetManager and used in various tools</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct PrimaryAssetId {
            ///<summary>The Type of this object, by default it's base class's name</summary>
            [FieldOffset(0)] PrimaryAssetType PrimaryAssetType;

            [FieldOffset(12)] public Name PrimaryAssetName;

        }
}
