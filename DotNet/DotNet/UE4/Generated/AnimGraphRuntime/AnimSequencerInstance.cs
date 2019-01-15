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

namespace UE4.AnimGraphRuntime {
    ///<summary>Anim Sequencer Instance</summary>
    public unsafe partial class AnimSequencerInstance : AnimCustomInstance  {
        static AnimSequencerInstance() {
            StaticClass = Main.GetClass("AnimSequencerInstance");
        }
        internal unsafe AnimSequencerInstance_fields* AnimSequencerInstance_ptr => (AnimSequencerInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimSequencerInstance(IntPtr p) => UObject.Make<AnimSequencerInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimSequencerInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimSequencerInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
