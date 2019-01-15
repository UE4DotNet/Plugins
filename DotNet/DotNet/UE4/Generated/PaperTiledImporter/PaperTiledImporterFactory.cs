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
using UE4.PaperTiledImporter.Native;
using UE4.UnrealEd;

namespace UE4.PaperTiledImporter {
    ///<summary>Imports a tile map (and associated textures & tile sets) exported from Tiled (http:www.mapeditor.org/)</summary>
    public unsafe partial class PaperTiledImporterFactory : Factory  {
        static PaperTiledImporterFactory() {
            StaticClass = Main.GetClass("PaperTiledImporterFactory");
        }
        internal unsafe PaperTiledImporterFactory_fields* PaperTiledImporterFactory_ptr => (PaperTiledImporterFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTiledImporterFactory(IntPtr p) => UObject.Make<PaperTiledImporterFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTiledImporterFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTiledImporterFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
