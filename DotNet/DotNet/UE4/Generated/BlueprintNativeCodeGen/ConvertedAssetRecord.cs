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


namespace UE4.BlueprintNativeCodeGen{
        ///<summary>FCodeGenAssetRecord</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct ConvertedAssetRecord {
            ///<summary>Asset Type</summary>
            public SubclassOf<UObject> AssetType {
                get {return AssetType_class; }
                set {AssetType_class = value; }
            }
            [FieldOffset(0)] private IntPtr AssetType_class;

            [FieldOffset(8)] byte TargetObjPath; //TODO: string FString TargetObjPath

            [FieldOffset(24)] byte GeneratedHeaderPath; //TODO: string FString GeneratedHeaderPath

            [FieldOffset(40)] byte GeneratedCppPath; //TODO: string FString GeneratedCppPath

        }
}
