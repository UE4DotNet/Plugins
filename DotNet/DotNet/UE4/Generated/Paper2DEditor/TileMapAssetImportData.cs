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
using UE4.Paper2DEditor.Native;
using UE4.Engine;

namespace UE4.Paper2DEditor {
    ///<summary>Base class for import data and options used when importing a tile map</summary>
    public unsafe partial class TileMapAssetImportData : AssetImportData  {
         //TODO: array not UObject TArray TileSetMap
        static TileMapAssetImportData() {
            StaticClass = Main.GetClass("TileMapAssetImportData");
        }
        internal unsafe TileMapAssetImportData_fields* TileMapAssetImportData_ptr => (TileMapAssetImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TileMapAssetImportData(IntPtr p) => UObject.Make<TileMapAssetImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TileMapAssetImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TileMapAssetImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
