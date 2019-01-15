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
    ///<summary>Paper Tile Set Factory</summary>
    public unsafe partial class PaperTileSetFactory : Factory  {
        static PaperTileSetFactory() {
            StaticClass = Main.GetClass("PaperTileSetFactory");
        }
        internal unsafe PaperTileSetFactory_fields* PaperTileSetFactory_ptr => (PaperTileSetFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTileSetFactory(IntPtr p) => UObject.Make<PaperTileSetFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTileSetFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTileSetFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
