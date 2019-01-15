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
    ///<summary>A sound actor that can be placed in a level</summary>
    public unsafe partial class AmbientSound : Actor  {

        ///<summary>Adjust Volume</summary>
        public void AdjustVolume(float AdjustVolumeDuration, float AdjustVolumeLevel)  => 
            AmbientSound_methods.AdjustVolume_method.Invoke(ObjPointer, AdjustVolumeDuration, AdjustVolumeLevel);

        ///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
        public void FadeIn(float FadeInDuration, float FadeVolumeLevel)  => 
            AmbientSound_methods.FadeIn_method.Invoke(ObjPointer, FadeInDuration, FadeVolumeLevel);

        ///<summary>Fade Out</summary>
        public void FadeOut(float FadeOutDuration, float FadeVolumeLevel)  => 
            AmbientSound_methods.FadeOut_method.Invoke(ObjPointer, FadeOutDuration, FadeVolumeLevel);

        ///<summary>Play</summary>
        public void Play(float StartTime)  => 
            AmbientSound_methods.Play_method.Invoke(ObjPointer, StartTime);

        ///<summary>Stop</summary>
        public void Stop()  => 
            AmbientSound_methods.Stop_method.Invoke(ObjPointer);
        ///<summary>Audio component that handles sound playing</summary>
        public unsafe AudioComponent AudioComponent {
            get {return AmbientSound_ptr->AudioComponent;}
        }
        static AmbientSound() {
            StaticClass = Main.GetClass("AmbientSound");
        }
        internal unsafe AmbientSound_fields* AmbientSound_ptr => (AmbientSound_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AmbientSound(IntPtr p) => UObject.Make<AmbientSound>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AmbientSound DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AmbientSound New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
