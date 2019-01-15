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
using UE4.MaterialBaking.Native;

namespace UE4.MaterialBaking {
    ///<summary>Material merge options object</summary>
    public unsafe partial class MaterialMergeOptions : UObject  {
         //TODO: enum EMaterialBakeMethod Method
        ///<summary>Blend mode for the final proxy material(s)</summary>
        public unsafe byte BlendMode {
            get {return MaterialMergeOptions_ptr->BlendMode;}
            set {MaterialMergeOptions_ptr->BlendMode = value;}
        }
        static MaterialMergeOptions() {
            StaticClass = Main.GetClass("MaterialMergeOptions");
        }
        internal unsafe MaterialMergeOptions_fields* MaterialMergeOptions_ptr => (MaterialMergeOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialMergeOptions(IntPtr p) => UObject.Make<MaterialMergeOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialMergeOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialMergeOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
