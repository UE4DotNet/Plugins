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
        ///<summary>Structure with publicly exposed information about an asset type. These can be loaded out of a config file.</summary>
        [StructLayout( LayoutKind.Explicit, Size=152 )]
        public unsafe struct PrimaryAssetTypeInfo {
            [FieldOffset(0)] public Name PrimaryAssetType;

            [FieldOffset(16)] byte AssetBaseClass; //TODO: soft class TSoftClassPtr<UObject>  AssetBaseClass

            ///<summary>Base Class of all assets of this type</summary>
            public SubclassOf<UObject> AssetBaseClassLoaded {
                get {return AssetBaseClassLoaded_class; }
                set {AssetBaseClassLoaded_class = value; }
            }
            [FieldOffset(64)] private IntPtr AssetBaseClassLoaded_class;

            [FieldOffset(72)] public bool bHasBlueprintClasses;

            [FieldOffset(73)] public bool bIsEditorOnly;

            [FieldOffset(80)] byte Directories; //TODO: array TArray Directories

            [FieldOffset(96)] byte SpecificAssets; //TODO: array TArray SpecificAssets

            ///<summary>Default management rules for this type, individual assets can be overridden</summary>
            [FieldOffset(112)] PrimaryAssetRules Rules;

            [FieldOffset(128)] byte AssetScanPaths; //TODO: array TArray AssetScanPaths

            [FieldOffset(144)] public bool bIsDynamicAsset;

            [FieldOffset(148)] public int NumberOfAssets;

        }
}
