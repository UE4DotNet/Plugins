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
    ///<summary>Anim Sequence Base</summary>
    public unsafe partial class AnimSequenceBase : AnimationAsset  {

        ///<summary>Returns the total play length of the montage, if played back with a speed of 1.0.</summary>
        public float GetPlayLength()  => 
            AnimSequenceBase_methods.GetPlayLength_method.Invoke(ObjPointer);
         //TODO: array not UObject TArray Notifies
        ///<summary>Length (in seconds) of this AnimSequence if played back with a speed of 1.0.</summary>
        public unsafe float SequenceLength {
            get {return AnimSequenceBase_ptr->SequenceLength;}
        }
        ///<summary>Number for tweaking playback rate of this animation globally.</summary>
        public unsafe float RateScale {
            get {return AnimSequenceBase_ptr->RateScale;}
            set {AnimSequenceBase_ptr->RateScale = value;}
        }
        ///<summary>Raw uncompressed float curve data</summary>
        public unsafe RawCurveTracks RawCurveData {
            get {return AnimSequenceBase_ptr->RawCurveData;}
            set {AnimSequenceBase_ptr->RawCurveData = value;}
        }
         //TODO: array not UObject TArray AnimNotifyTracks
        static AnimSequenceBase() {
            StaticClass = Main.GetClass("AnimSequenceBase");
        }
        internal unsafe AnimSequenceBase_fields* AnimSequenceBase_ptr => (AnimSequenceBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimSequenceBase(IntPtr p) => UObject.Make<AnimSequenceBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimSequenceBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimSequenceBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
