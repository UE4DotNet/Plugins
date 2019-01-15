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
    ///<summary>A font face asset contains the raw payload data for a source TTF/OTF file as used by FreeType.</summary>
    ///<remarks>During cook this asset type generates a ".ufont" file containing the raw payload data (unless loaded "Inline").</remarks>
    public unsafe partial class FontFace : UObject  {
         //TODO: string FString SourceFilename
         //TODO: enum EFontHinting Hinting
         //TODO: enum EFontLoadingPolicy LoadingPolicy
         //TODO: enum EFontLayoutMethod LayoutMethod
         //TODO: array not UObject TArray SubFaces
        static FontFace() {
            StaticClass = Main.GetClass("FontFace");
        }
        internal unsafe FontFace_fields* FontFace_ptr => (FontFace_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FontFace(IntPtr p) => UObject.Make<FontFace>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FontFace DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FontFace New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
