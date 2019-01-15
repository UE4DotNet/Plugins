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
    ///<summary>Anim Composite</summary>
    public unsafe partial class AnimComposite : AnimCompositeBase  {
        ///<summary>Serializable data that stores section/anim pairing *</summary>
        public unsafe AnimTrack AnimationTrack {
            get {return AnimComposite_ptr->AnimationTrack;}
            set {AnimComposite_ptr->AnimationTrack = value;}
        }
        ///<summary>Preview Base pose for additive BlendSpace *</summary>
        public unsafe AnimSequence PreviewBasePose {
            get {return AnimComposite_ptr->PreviewBasePose;}
            set {AnimComposite_ptr->PreviewBasePose = value;}
        }
        static AnimComposite() {
            StaticClass = Main.GetClass("AnimComposite");
        }
        internal unsafe AnimComposite_fields* AnimComposite_ptr => (AnimComposite_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimComposite(IntPtr p) => UObject.Make<AnimComposite>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimComposite DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimComposite New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
