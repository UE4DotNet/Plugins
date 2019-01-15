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
    ///<summary>Defines a delay</summary>
    public unsafe partial class SoundNodeDelay : SoundNode  {
        ///<summary>The lower bound of delay time in seconds.</summary>
        public unsafe float DelayMin {
            get {return SoundNodeDelay_ptr->DelayMin;}
            set {SoundNodeDelay_ptr->DelayMin = value;}
        }
        ///<summary>The upper bound of delay time in seconds.</summary>
        public unsafe float DelayMax {
            get {return SoundNodeDelay_ptr->DelayMax;}
            set {SoundNodeDelay_ptr->DelayMax = value;}
        }
        static SoundNodeDelay() {
            StaticClass = Main.GetClass("SoundNodeDelay");
        }
        internal unsafe SoundNodeDelay_fields* SoundNodeDelay_ptr => (SoundNodeDelay_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeDelay(IntPtr p) => UObject.Make<SoundNodeDelay>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeDelay DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeDelay New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
