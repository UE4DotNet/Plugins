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
    ///<summary>Anim Notify Play Sound</summary>
    public unsafe partial class AnimNotify_PlaySound : AnimNotify  {
        ///<summary>Sound to Play</summary>
        public unsafe SoundBase Sound {
            get {return AnimNotify_PlaySound_ptr->Sound;}
        }
        ///<summary>Volume Multiplier</summary>
        public unsafe float VolumeMultiplier {
            get {return AnimNotify_PlaySound_ptr->VolumeMultiplier;}
        }
        ///<summary>Pitch Multiplier</summary>
        public unsafe float PitchMultiplier {
            get {return AnimNotify_PlaySound_ptr->PitchMultiplier;}
        }
        public bool bFollow {
            get {return Main.GetGetBoolPropertyByName(this, "bFollow"); }
        }
        ///<summary>Socket or bone name to attach sound to</summary>
        public unsafe Name AttachName {
            get {return AnimNotify_PlaySound_ptr->AttachName;}
        }
        static AnimNotify_PlaySound() {
            StaticClass = Main.GetClass("AnimNotify_PlaySound");
        }
        internal unsafe AnimNotify_PlaySound_fields* AnimNotify_PlaySound_ptr => (AnimNotify_PlaySound_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimNotify_PlaySound(IntPtr p) => UObject.Make<AnimNotify_PlaySound>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimNotify_PlaySound DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimNotify_PlaySound New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
