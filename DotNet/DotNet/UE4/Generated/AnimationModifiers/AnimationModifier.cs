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
using UE4.AnimationModifiers.Native;
using UE4.Engine;

namespace UE4.AnimationModifiers {
    ///<summary>Animation Modifier</summary>
    public unsafe partial class AnimationModifier : UObject  {

        ///<summary>Executed when the Animation is initialized (native event for debugging / testing purposes)</summary>
        public event OnApply_delegate OnApply;
        public delegate void OnApply_delegate(AnimSequence AnimationSequence);
        internal void on_OnApply(AnimSequence AnimationSequence) =>
            OnApply?.Invoke(AnimationSequence);


        ///<summary>On Revert</summary>
        public event OnRevert_delegate OnRevert;
        public delegate void OnRevert_delegate(AnimSequence AnimationSequence);
        internal void on_OnRevert(AnimSequence AnimationSequence) =>
            OnRevert?.Invoke(AnimationSequence);

        ///<summary>VisibleAnywhere for testing, Category = Revision</summary>
        public unsafe FGuid RevisionGuid {
            get {return AnimationModifier_ptr->RevisionGuid;}
            set {AnimationModifier_ptr->RevisionGuid = value;}
        }
        ///<summary>VisibleAnywhere for testing, Category = Revision</summary>
        public unsafe FGuid AppliedGuid {
            get {return AnimationModifier_ptr->AppliedGuid;}
            set {AnimationModifier_ptr->AppliedGuid = value;}
        }
        ///<summary>This holds the latest value returned by UpdateNativeRevisionGuid during the last PostLoad (changing this value will invalidate the GUIDs for all instances)</summary>
        public unsafe int StoredNativeRevision {
            get {return AnimationModifier_ptr->StoredNativeRevision;}
            set {AnimationModifier_ptr->StoredNativeRevision = value;}
        }
        static AnimationModifier() {
            StaticClass = Main.GetClass("AnimationModifier");
            AnimationModifier_events.OnApply_event.Setup();
            AnimationModifier_events.OnRevert_event.Setup();
        }
        internal unsafe AnimationModifier_fields* AnimationModifier_ptr => (AnimationModifier_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationModifier(IntPtr p) => UObject.Make<AnimationModifier>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationModifier DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationModifier New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
