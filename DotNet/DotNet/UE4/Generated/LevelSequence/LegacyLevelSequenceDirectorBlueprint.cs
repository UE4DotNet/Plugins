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
using UE4.Engine;

namespace UE4.LevelSequence {
    ///<summary>Legacy Level Sequence Director Blueprint</summary>
    public unsafe partial class LegacyLevelSequenceDirectorBlueprint : Blueprint  {
        static LegacyLevelSequenceDirectorBlueprint() {
            StaticClass = Main.GetClass("LegacyLevelSequenceDirectorBlueprint");
        }
        internal unsafe LegacyLevelSequenceDirectorBlueprint_fields* LegacyLevelSequenceDirectorBlueprint_ptr => (LegacyLevelSequenceDirectorBlueprint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LegacyLevelSequenceDirectorBlueprint(IntPtr p) => UObject.Make<LegacyLevelSequenceDirectorBlueprint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LegacyLevelSequenceDirectorBlueprint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LegacyLevelSequenceDirectorBlueprint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
