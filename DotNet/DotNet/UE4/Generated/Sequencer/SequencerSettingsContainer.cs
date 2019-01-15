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
using UE4.Sequencer.Native;

namespace UE4.Sequencer {
    ///<summary>Empty class used to house multiple named USequencerSettings</summary>
    public unsafe partial class SequencerSettingsContainer : UObject  {
        static SequencerSettingsContainer() {
            StaticClass = Main.GetClass("SequencerSettingsContainer");
        }
        internal unsafe SequencerSettingsContainer_fields* SequencerSettingsContainer_ptr => (SequencerSettingsContainer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SequencerSettingsContainer(IntPtr p) => UObject.Make<SequencerSettingsContainer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SequencerSettingsContainer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SequencerSettingsContainer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
