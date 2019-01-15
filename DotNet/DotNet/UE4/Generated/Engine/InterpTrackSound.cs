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
    ///<summary>Interp Track Sound</summary>
    public unsafe partial class InterpTrackSound : InterpTrackVectorBase  {
         //TODO: array not UObject TArray Sounds
        public bool bPlayOnReverse {
            get {return Main.GetGetBoolPropertyByName(this, "bPlayOnReverse"); }
            set {Main.SetGetBoolPropertyByName(this, "bPlayOnReverse", value); }
        }
        public bool bContinueSoundOnMatineeEnd {
            get {return Main.GetGetBoolPropertyByName(this, "bContinueSoundOnMatineeEnd"); }
            set {Main.SetGetBoolPropertyByName(this, "bContinueSoundOnMatineeEnd", value); }
        }
        public bool bSuppressSubtitles {
            get {return Main.GetGetBoolPropertyByName(this, "bSuppressSubtitles"); }
            set {Main.SetGetBoolPropertyByName(this, "bSuppressSubtitles", value); }
        }
        public bool bTreatAsDialogue {
            get {return Main.GetGetBoolPropertyByName(this, "bTreatAsDialogue"); }
            set {Main.SetGetBoolPropertyByName(this, "bTreatAsDialogue", value); }
        }
        public bool bAttach {
            get {return Main.GetGetBoolPropertyByName(this, "bAttach"); }
            set {Main.SetGetBoolPropertyByName(this, "bAttach", value); }
        }
        static InterpTrackSound() {
            StaticClass = Main.GetClass("InterpTrackSound");
        }
        internal unsafe InterpTrackSound_fields* InterpTrackSound_ptr => (InterpTrackSound_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackSound(IntPtr p) => UObject.Make<InterpTrackSound>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackSound DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackSound New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
