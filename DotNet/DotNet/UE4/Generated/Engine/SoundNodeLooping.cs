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
    ///<summary>Defines how a sound loops; either indefinitely, or for a set number of times.</summary>
    ///<remarks>
    ///Note: The Looping node should only be used for logical or procedural looping such as introducing a delay.
    ///These sounds will not be played seamlessly. If you want a sound to loop seamlessly and indefinitely,
    ///use the Looping flag on the Wave Player node for that sound.
    ///</remarks>
    public unsafe partial class SoundNodeLooping : SoundNode  {
        ///<summary>The amount of times to loop</summary>
        public unsafe int LoopCount {
            get {return SoundNodeLooping_ptr->LoopCount;}
            set {SoundNodeLooping_ptr->LoopCount = value;}
        }
        public bool bLoopIndefinitely {
            get {return Main.GetGetBoolPropertyByName(this, "bLoopIndefinitely"); }
            set {Main.SetGetBoolPropertyByName(this, "bLoopIndefinitely", value); }
        }
        static SoundNodeLooping() {
            StaticClass = Main.GetClass("SoundNodeLooping");
        }
        internal unsafe SoundNodeLooping_fields* SoundNodeLooping_ptr => (SoundNodeLooping_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeLooping(IntPtr p) => UObject.Make<SoundNodeLooping>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeLooping DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeLooping New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
