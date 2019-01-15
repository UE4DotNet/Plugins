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
using UE4.ViewportInteraction.Native;

namespace UE4.ViewportInteraction {
    ///<summary>Viewport Transformer</summary>
    public unsafe partial class ViewportTransformer : UObject  {
        ///<summary>The viewport world interaction object we're registered with</summary>
        public unsafe ViewportWorldInteraction ViewportWorldInteraction {
            get {return ViewportTransformer_ptr->ViewportWorldInteraction;}
            set {ViewportTransformer_ptr->ViewportWorldInteraction = value;}
        }
        static ViewportTransformer() {
            StaticClass = Main.GetClass("ViewportTransformer");
        }
        internal unsafe ViewportTransformer_fields* ViewportTransformer_ptr => (ViewportTransformer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ViewportTransformer(IntPtr p) => UObject.Make<ViewportTransformer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ViewportTransformer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ViewportTransformer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
