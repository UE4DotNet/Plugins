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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Tex Aligner</summary>
    public unsafe partial class TexAligner : UObject  {
        ///<summary>The default alignment this aligner represents.</summary>
        public unsafe byte DefTexAlign {
            get {return TexAligner_ptr->DefTexAlign;}
            set {TexAligner_ptr->DefTexAlign = value;}
        }
        ///<summary>TAxis</summary>
        public unsafe byte TAxis {
            get {return TexAligner_ptr->TAxis;}
            set {TexAligner_ptr->TAxis = value;}
        }
        ///<summary>UTile</summary>
        public unsafe float UTile {
            get {return TexAligner_ptr->UTile;}
            set {TexAligner_ptr->UTile = value;}
        }
        ///<summary>VTile</summary>
        public unsafe float VTile {
            get {return TexAligner_ptr->VTile;}
            set {TexAligner_ptr->VTile = value;}
        }
         //TODO: string FString Desc
        static TexAligner() {
            StaticClass = Main.GetClass("TexAligner");
        }
        internal unsafe TexAligner_fields* TexAligner_ptr => (TexAligner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TexAligner(IntPtr p) => UObject.Make<TexAligner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TexAligner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TexAligner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
