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
        ///<summary>A struct to hold important information about an assets found by the Asset Registry</summary>
        ///<remarks>This struct is transient and should never be serialized</remarks>
        [StructLayout( LayoutKind.Explicit, Size=104 )]
        public unsafe struct AssetData {
            [FieldOffset(0)] public Name ObjectPath;

            [FieldOffset(12)] public Name PackageName;

            [FieldOffset(24)] public Name PackagePath;

            [FieldOffset(36)] public Name AssetName;

            [FieldOffset(48)] public Name AssetClass;

        }
}
