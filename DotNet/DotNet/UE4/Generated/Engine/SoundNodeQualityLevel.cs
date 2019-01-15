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
    ///<summary>This SoundNode uses GameUserSettings AudioQualityLevel (or the editor override) to choose which branch to play</summary>
    ///<remarks>and at runtime will only load in to memory sound waves connected to the branch that will be selected</remarks>
    public unsafe partial class SoundNodeQualityLevel : SoundNode  {
        static SoundNodeQualityLevel() {
            StaticClass = Main.GetClass("SoundNodeQualityLevel");
        }
        internal unsafe SoundNodeQualityLevel_fields* SoundNodeQualityLevel_ptr => (SoundNodeQualityLevel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeQualityLevel(IntPtr p) => UObject.Make<SoundNodeQualityLevel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeQualityLevel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeQualityLevel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
