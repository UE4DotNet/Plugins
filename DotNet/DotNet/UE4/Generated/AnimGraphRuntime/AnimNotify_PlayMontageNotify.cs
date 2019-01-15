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
using UE4.AnimGraphRuntime.Native;
using UE4.Engine;

namespace UE4.AnimGraphRuntime {
    ///<summary>UAnimNotify_PlayMontageNotify</summary>
    public unsafe partial class AnimNotify_PlayMontageNotify : AnimNotify  {
        ///<summary>Name of notify that is passed to the PlayMontage K2Node.</summary>
        public unsafe Name NotifyName {
            get {return AnimNotify_PlayMontageNotify_ptr->NotifyName;}
        }
        static AnimNotify_PlayMontageNotify() {
            StaticClass = Main.GetClass("AnimNotify_PlayMontageNotify");
        }
        internal unsafe AnimNotify_PlayMontageNotify_fields* AnimNotify_PlayMontageNotify_ptr => (AnimNotify_PlayMontageNotify_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimNotify_PlayMontageNotify(IntPtr p) => UObject.Make<AnimNotify_PlayMontageNotify>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimNotify_PlayMontageNotify DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimNotify_PlayMontageNotify New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
