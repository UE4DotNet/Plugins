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
using UE4.Paper2D.Native;
using UE4.SlateCore;
using UE4.Engine;

namespace UE4.Paper2D {
    ///<summary>Paper Sprite Blueprint Library</summary>
    public unsafe partial class PaperSpriteBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>Make Brush from Sprite</summary>
        public static SlateBrush MakeBrushFromSprite(PaperSprite Sprite, int Width, int Height)  => 
            PaperSpriteBlueprintLibrary_methods.MakeBrushFromSprite_method.Invoke(Sprite, Width, Height);
        static PaperSpriteBlueprintLibrary() {
            StaticClass = Main.GetClass("PaperSpriteBlueprintLibrary");
        }
        internal unsafe PaperSpriteBlueprintLibrary_fields* PaperSpriteBlueprintLibrary_ptr => (PaperSpriteBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperSpriteBlueprintLibrary(IntPtr p) => UObject.Make<PaperSpriteBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperSpriteBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperSpriteBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
