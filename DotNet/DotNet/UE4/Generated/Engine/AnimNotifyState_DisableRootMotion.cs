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
    ///<summary>Anim Notify State Disable Root Motion</summary>
    public unsafe partial class AnimNotifyState_DisableRootMotion : AnimNotifyState  {
        static AnimNotifyState_DisableRootMotion() {
            StaticClass = Main.GetClass("AnimNotifyState_DisableRootMotion");
        }
        internal unsafe AnimNotifyState_DisableRootMotion_fields* AnimNotifyState_DisableRootMotion_ptr => (AnimNotifyState_DisableRootMotion_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimNotifyState_DisableRootMotion(IntPtr p) => UObject.Make<AnimNotifyState_DisableRootMotion>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimNotifyState_DisableRootMotion DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimNotifyState_DisableRootMotion New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
