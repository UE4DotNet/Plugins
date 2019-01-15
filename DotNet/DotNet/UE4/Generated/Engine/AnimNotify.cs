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
    ///<summary>Anim Notify</summary>
    public unsafe partial class AnimNotify : UObject  {

        ///<summary>Received Notify</summary>
        public event Received_Notify_delegate Received_Notify;
        public delegate bool Received_Notify_delegate(SkeletalMeshComponent MeshComp, AnimSequenceBase Animation, bool ReturnValue);
        internal bool on_Received_Notify(SkeletalMeshComponent MeshComp, AnimSequenceBase Animation, bool ReturnValue) =>
            Received_Notify != null ? Received_Notify(MeshComp, Animation, ReturnValue) : ReturnValue;


        ///<summary>Implementable event to get a custom name for the notify</summary>
        public event GetNotifyName_delegate GetNotifyName;
        public delegate string GetNotifyName_delegate(string ReturnValue);
        internal string on_GetNotifyName(string ReturnValue) =>
            GetNotifyName != null ? GetNotifyName(ReturnValue) : ReturnValue;

        ///<summary>Color of Notify in editor</summary>
        public unsafe Color NotifyColor {
            get {return AnimNotify_ptr->NotifyColor;}
        }
        static AnimNotify() {
            StaticClass = Main.GetClass("AnimNotify");
            AnimNotify_events.Received_Notify_event.Setup();
            AnimNotify_events.GetNotifyName_event.Setup();
        }
        internal unsafe AnimNotify_fields* AnimNotify_ptr => (AnimNotify_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimNotify(IntPtr p) => UObject.Make<AnimNotify>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimNotify DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimNotify New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
