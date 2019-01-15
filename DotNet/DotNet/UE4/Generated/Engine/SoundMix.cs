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
    ///<summary>Sound Mix</summary>
    public unsafe partial class SoundMix : UObject  {
        public bool bApplyEQ {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyEQ"); }
            set {Main.SetGetBoolPropertyByName(this, "bApplyEQ", value); }
        }
        ///<summary>EQPriority</summary>
        public unsafe float EQPriority {
            get {return SoundMix_ptr->EQPriority;}
            set {SoundMix_ptr->EQPriority = value;}
        }
        ///<summary>EQSettings</summary>
        public unsafe AudioEQEffect EQSettings {
            get {return SoundMix_ptr->EQSettings;}
            set {SoundMix_ptr->EQSettings = value;}
        }
         //TODO: array not UObject TArray SoundClassEffects
        ///<summary>Initial delay in seconds before the the mix is applied.</summary>
        public unsafe float InitialDelay {
            get {return SoundMix_ptr->InitialDelay;}
            set {SoundMix_ptr->InitialDelay = value;}
        }
        ///<summary>Time taken in seconds for the mix to fade in.</summary>
        public unsafe float FadeInTime {
            get {return SoundMix_ptr->FadeInTime;}
            set {SoundMix_ptr->FadeInTime = value;}
        }
        ///<summary>Duration of mix, negative means it will be applied until another mix is set.</summary>
        public unsafe float Duration {
            get {return SoundMix_ptr->Duration;}
            set {SoundMix_ptr->Duration = value;}
        }
        ///<summary>Time taken in seconds for the mix to fade out.</summary>
        public unsafe float FadeOutTime {
            get {return SoundMix_ptr->FadeOutTime;}
            set {SoundMix_ptr->FadeOutTime = value;}
        }
        public bool bChanged {
            get {return Main.GetGetBoolPropertyByName(this, "bChanged"); }
            set {Main.SetGetBoolPropertyByName(this, "bChanged", value); }
        }
        static SoundMix() {
            StaticClass = Main.GetClass("SoundMix");
        }
        internal unsafe SoundMix_fields* SoundMix_ptr => (SoundMix_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundMix(IntPtr p) => UObject.Make<SoundMix>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundMix DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundMix New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
