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
    ///<summary>UAnimNotify_PlayMontageNotifyWindow</summary>
    public unsafe partial class AnimNotify_PlayMontageNotifyWindow : AnimNotifyState  {
        ///<summary>Name of notify that is passed to ability.</summary>
        public unsafe Name NotifyName {
            get {return AnimNotify_PlayMontageNotifyWindow_ptr->NotifyName;}
        }
        static AnimNotify_PlayMontageNotifyWindow() {
            StaticClass = Main.GetClass("AnimNotify_PlayMontageNotifyWindow");
        }
        internal unsafe AnimNotify_PlayMontageNotifyWindow_fields* AnimNotify_PlayMontageNotifyWindow_ptr => (AnimNotify_PlayMontageNotifyWindow_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimNotify_PlayMontageNotifyWindow(IntPtr p) => UObject.Make<AnimNotify_PlayMontageNotifyWindow>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimNotify_PlayMontageNotifyWindow DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimNotify_PlayMontageNotifyWindow New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
