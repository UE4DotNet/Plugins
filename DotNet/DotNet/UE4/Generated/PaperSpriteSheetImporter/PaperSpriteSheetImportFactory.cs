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
using UE4.PaperSpriteSheetImporter.Native;
using UE4.UnrealEd;

namespace UE4.PaperSpriteSheetImporter {
    ///<summary>Imports a sprite sheet (and associated paper sprites and textures) from a JSON file exported from Adobe Flash CS6, Texture Packer, or other compatible tool</summary>
    public unsafe partial class PaperSpriteSheetImportFactory : Factory  {
        static PaperSpriteSheetImportFactory() {
            StaticClass = Main.GetClass("PaperSpriteSheetImportFactory");
        }
        internal unsafe PaperSpriteSheetImportFactory_fields* PaperSpriteSheetImportFactory_ptr => (PaperSpriteSheetImportFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperSpriteSheetImportFactory(IntPtr p) => UObject.Make<PaperSpriteSheetImportFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperSpriteSheetImportFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperSpriteSheetImportFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
