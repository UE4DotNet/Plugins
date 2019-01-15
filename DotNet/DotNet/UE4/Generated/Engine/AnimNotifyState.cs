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
    ///<summary>Anim Notify State</summary>
    public unsafe partial class AnimNotifyState : UObject  {

        ///<summary>Received Notify Begin</summary>
        public event Received_NotifyBegin_delegate Received_NotifyBegin;
        public delegate bool Received_NotifyBegin_delegate(SkeletalMeshComponent MeshComp, AnimSequenceBase Animation, float TotalDuration, bool ReturnValue);
        internal bool on_Received_NotifyBegin(SkeletalMeshComponent MeshComp, AnimSequenceBase Animation, float TotalDuration, bool ReturnValue) =>
            Received_NotifyBegin != null ? Received_NotifyBegin(MeshComp, Animation, TotalDuration, ReturnValue) : ReturnValue;


        ///<summary>Received Notify End</summary>
        public event Received_NotifyEnd_delegate Received_NotifyEnd;
        public delegate bool Received_NotifyEnd_delegate(SkeletalMeshComponent MeshComp, AnimSequenceBase Animation, bool ReturnValue);
        internal bool on_Received_NotifyEnd(SkeletalMeshComponent MeshComp, AnimSequenceBase Animation, bool ReturnValue) =>
            Received_NotifyEnd != null ? Received_NotifyEnd(MeshComp, Animation, ReturnValue) : ReturnValue;


        ///<summary>Received Notify Tick</summary>
        public event Received_NotifyTick_delegate Received_NotifyTick;
        public delegate bool Received_NotifyTick_delegate(SkeletalMeshComponent MeshComp, AnimSequenceBase Animation, float FrameDeltaTime, bool ReturnValue);
        internal bool on_Received_NotifyTick(SkeletalMeshComponent MeshComp, AnimSequenceBase Animation, float FrameDeltaTime, bool ReturnValue) =>
            Received_NotifyTick != null ? Received_NotifyTick(MeshComp, Animation, FrameDeltaTime, ReturnValue) : ReturnValue;


        ///<summary>Implementable event to get a custom name for the notify</summary>
        public event GetNotifyName_delegate GetNotifyName;
        public delegate string GetNotifyName_delegate(string ReturnValue);
        internal string on_GetNotifyName(string ReturnValue) =>
            GetNotifyName != null ? GetNotifyName(ReturnValue) : ReturnValue;

        ///<summary>Color of Notify in editor</summary>
        public unsafe Color NotifyColor {
            get {return AnimNotifyState_ptr->NotifyColor;}
        }
        static AnimNotifyState() {
            StaticClass = Main.GetClass("AnimNotifyState");
            AnimNotifyState_events.Received_NotifyBegin_event.Setup();
            AnimNotifyState_events.Received_NotifyEnd_event.Setup();
            AnimNotifyState_events.Received_NotifyTick_event.Setup();
            AnimNotifyState_events.GetNotifyName_event.Setup();
        }
        internal unsafe AnimNotifyState_fields* AnimNotifyState_ptr => (AnimNotifyState_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimNotifyState(IntPtr p) => UObject.Make<AnimNotifyState>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimNotifyState DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimNotifyState New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
