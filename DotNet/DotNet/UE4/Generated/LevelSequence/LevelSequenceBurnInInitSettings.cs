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
using UE4.LevelSequence.Native;

namespace UE4.LevelSequence {
    ///<summary>Level Sequence Burn in Init Settings</summary>
    public unsafe partial class LevelSequenceBurnInInitSettings : UObject  {
        static LevelSequenceBurnInInitSettings() {
            StaticClass = Main.GetClass("LevelSequenceBurnInInitSettings");
        }
        internal unsafe LevelSequenceBurnInInitSettings_fields* LevelSequenceBurnInInitSettings_ptr => (LevelSequenceBurnInInitSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelSequenceBurnInInitSettings(IntPtr p) => UObject.Make<LevelSequenceBurnInInitSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelSequenceBurnInInitSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelSequenceBurnInInitSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
