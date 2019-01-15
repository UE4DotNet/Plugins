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
        ///<summary>A struct representing a single AssetBundle</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct AssetBundleEntry {
            ///<summary>Asset this bundle is saved within. This is empty for global bundles, or in the saved bundle info</summary>
            [FieldOffset(0)] PrimaryAssetId BundleScope;

            [FieldOffset(24)] public Name BundleName;

            [FieldOffset(40)] byte BundleAssets; //TODO: array TArray BundleAssets

        }
}
