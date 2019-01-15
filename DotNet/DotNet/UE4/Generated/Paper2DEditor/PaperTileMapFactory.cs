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
using UE4.UnrealEd;

namespace UE4.Paper2DEditor {
    ///<summary>Paper Tile Map Factory</summary>
    public unsafe partial class PaperTileMapFactory : Factory  {
        static PaperTileMapFactory() {
            StaticClass = Main.GetClass("PaperTileMapFactory");
        }
        internal unsafe PaperTileMapFactory_fields* PaperTileMapFactory_ptr => (PaperTileMapFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTileMapFactory(IntPtr p) => UObject.Make<PaperTileMapFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTileMapFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTileMapFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
