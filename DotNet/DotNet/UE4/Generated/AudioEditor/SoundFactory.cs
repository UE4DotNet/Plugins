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
    ///<summary>Sound Factory</summary>
    public unsafe partial class SoundFactory : Factory  {
        public bool bAutoCreateCue {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoCreateCue"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoCreateCue", value); }
        }
        public bool bIncludeAttenuationNode {
            get {return Main.GetGetBoolPropertyByName(this, "bIncludeAttenuationNode"); }
            set {Main.SetGetBoolPropertyByName(this, "bIncludeAttenuationNode", value); }
        }
        public bool bIncludeLoopingNode {
            get {return Main.GetGetBoolPropertyByName(this, "bIncludeLoopingNode"); }
            set {Main.SetGetBoolPropertyByName(this, "bIncludeLoopingNode", value); }
        }
        public bool bIncludeModulatorNode {
            get {return Main.GetGetBoolPropertyByName(this, "bIncludeModulatorNode"); }
            set {Main.SetGetBoolPropertyByName(this, "bIncludeModulatorNode", value); }
        }
        ///<summary>The volume of the created sound cue</summary>
        public unsafe float CueVolume {
            get {return SoundFactory_ptr->CueVolume;}
            set {SoundFactory_ptr->CueVolume = value;}
        }
         //TODO: string FString CuePackageSuffix
        static SoundFactory() {
            StaticClass = Main.GetClass("SoundFactory");
        }
        internal unsafe SoundFactory_fields* SoundFactory_ptr => (SoundFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundFactory(IntPtr p) => UObject.Make<SoundFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
