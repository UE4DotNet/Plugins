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
    ///<summary>
    ///This SoundNode uses UEngine::bAllowMatureLanguage to determine whether child nodes
    ///that have USoundWave::bMature=true should be played.
    ///</summary>
    public unsafe partial class SoundNodeMature : SoundNode  {
        static SoundNodeMature() {
            StaticClass = Main.GetClass("SoundNodeMature");
        }
        internal unsafe SoundNodeMature_fields* SoundNodeMature_ptr => (SoundNodeMature_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeMature(IntPtr p) => UObject.Make<SoundNodeMature>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeMature DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeMature New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
