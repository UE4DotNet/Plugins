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

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>
    ///UAssetMappingTable : that has AssetMappingTableging data
    ///        - used for retargeting
    ///</summary>
    ///<remarks>- support to share different animations</remarks>
    public unsafe partial class AssetMappingTable : UObject  {
         //TODO: array not UObject TArray MappedAssets
        static AssetMappingTable() {
            StaticClass = Main.GetClass("AssetMappingTable");
        }
        internal unsafe AssetMappingTable_fields* AssetMappingTable_ptr => (AssetMappingTable_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AssetMappingTable(IntPtr p) => UObject.Make<AssetMappingTable>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AssetMappingTable DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AssetMappingTable New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
