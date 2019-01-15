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
using UE4.AudioEditor.Native;
using UE4.UnrealEd;

namespace UE4.AudioEditor {
    ///<summary>Sound Surround Factory</summary>
    public unsafe partial class SoundSurroundFactory : Factory  {
        ///<summary>Cue Volume</summary>
        public unsafe float CueVolume {
            get {return SoundSurroundFactory_ptr->CueVolume;}
            set {SoundSurroundFactory_ptr->CueVolume = value;}
        }
        static SoundSurroundFactory() {
            StaticClass = Main.GetClass("SoundSurroundFactory");
        }
        internal unsafe SoundSurroundFactory_fields* SoundSurroundFactory_ptr => (SoundSurroundFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundSurroundFactory(IntPtr p) => UObject.Make<SoundSurroundFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundSurroundFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundSurroundFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
