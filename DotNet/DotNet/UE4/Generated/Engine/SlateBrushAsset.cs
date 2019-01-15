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
using UE4.SlateCore;

namespace UE4.Engine {
    ///<summary>
    ///An asset describing how a texture can exist in slate's DPI-aware environment
    ///and how this texture responds to resizing.
    ///</summary>
    ///<remarks>e.g. Scale9-stretching? Tiling?</remarks>
    public unsafe partial class SlateBrushAsset : UObject  {
        ///<summary>The slate brush resource describing the texture's behavior.</summary>
        public unsafe SlateBrush Brush {
            get {return SlateBrushAsset_ptr->Brush;}
            set {SlateBrushAsset_ptr->Brush = value;}
        }
        static SlateBrushAsset() {
            StaticClass = Main.GetClass("SlateBrushAsset");
        }
        internal unsafe SlateBrushAsset_fields* SlateBrushAsset_ptr => (SlateBrushAsset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SlateBrushAsset(IntPtr p) => UObject.Make<SlateBrushAsset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SlateBrushAsset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SlateBrushAsset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
