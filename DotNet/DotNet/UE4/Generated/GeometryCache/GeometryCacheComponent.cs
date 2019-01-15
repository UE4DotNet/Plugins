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
using UE4.GeometryCache.Native;
using UE4.Engine;

namespace UE4.GeometryCache {
    ///<summary>GeometryCacheComponent, encapsulates a GeometryCache asset instance and implements functionality for rendering/and playback of GeometryCaches</summary>
    public unsafe partial class GeometryCacheComponent : MeshComponent  {

        ///<summary>Set the current animation time for GeometryCache. Includes the influence of elapsed time and SetStartTimeOffset</summary>
        public float GetAnimationTime()  => 
            GeometryCacheComponent_methods.GetAnimationTime_method.Invoke(ObjPointer);

        ///<summary>Get the duration of the playback</summary>
        public float GetDuration()  => 
            GeometryCacheComponent_methods.GetDuration_method.Invoke(ObjPointer);

        ///<summary>Get the number of frames</summary>
        public int GetNumberOfFrames()  => 
            GeometryCacheComponent_methods.GetNumberOfFrames_method.Invoke(ObjPointer);

        ///<summary>Set the current animation time for GeometryCache. Includes the influence of elapsed time and SetStartTimeOffset</summary>
        public float GetPlaybackDirection()  => 
            GeometryCacheComponent_methods.GetPlaybackDirection_method.Invoke(ObjPointer);

        ///<summary>Get current playback speed for GeometryCache.</summary>
        public float GetPlaybackSpeed()  => 
            GeometryCacheComponent_methods.GetPlaybackSpeed_method.Invoke(ObjPointer);

        ///<summary>Get current start time offset for GeometryCache.</summary>
        public float GetStartTimeOffset()  => 
            GeometryCacheComponent_methods.GetStartTimeOffset_method.Invoke(ObjPointer);

        ///<summary>Get whether this GeometryCache is looping or not.</summary>
        public bool IsLooping()  => 
            GeometryCacheComponent_methods.IsLooping_method.Invoke(ObjPointer);

        ///<summary>Get whether this GeometryCache is playing or not.</summary>
        public bool IsPlaying()  => 
            GeometryCacheComponent_methods.IsPlaying_method.Invoke(ObjPointer);

        ///<summary>Get whether this GeometryCache is playing in reverse or not.</summary>
        public bool IsPlayingReversed()  => 
            GeometryCacheComponent_methods.IsPlayingReversed_method.Invoke(ObjPointer);

        ///<summary>Pause playback of GeometryCache</summary>
        public void Pause()  => 
            GeometryCacheComponent_methods.Pause_method.Invoke(ObjPointer);

        ///<summary>Start playback of GeometryCache</summary>
        public void Play()  => 
            GeometryCacheComponent_methods.Play_method.Invoke(ObjPointer);

        ///<summary>Start playback of GeometryCache from the start</summary>
        public void PlayFromStart()  => 
            GeometryCacheComponent_methods.PlayFromStart_method.Invoke(ObjPointer);

        ///<summary>Start playback of GeometryCache in reverse</summary>
        public void PlayReversed()  => 
            GeometryCacheComponent_methods.PlayReversed_method.Invoke(ObjPointer);

        ///<summary>Start playback of GeometryCache from the end and play in reverse</summary>
        public void PlayReversedFromEnd()  => 
            GeometryCacheComponent_methods.PlayReversedFromEnd_method.Invoke(ObjPointer);

        ///<summary>Change the Geometry Cache used by this instance.</summary>
        public bool SetGeometryCache(GeometryCache NewGeomCache)  => 
            GeometryCacheComponent_methods.SetGeometryCache_method.Invoke(ObjPointer, NewGeomCache);

        ///<summary>Set whether this GeometryCache is looping or not.</summary>
        public void SetLooping(bool bNewLooping)  => 
            GeometryCacheComponent_methods.SetLooping_method.Invoke(ObjPointer, bNewLooping);

        ///<summary>Set new playback speed for GeometryCache.</summary>
        public void SetPlaybackSpeed(float NewPlaybackSpeed)  => 
            GeometryCacheComponent_methods.SetPlaybackSpeed_method.Invoke(ObjPointer, NewPlaybackSpeed);

        ///<summary>Set current start time offset for GeometryCache.</summary>
        public void SetStartTimeOffset(float NewStartTimeOffset)  => 
            GeometryCacheComponent_methods.SetStartTimeOffset_method.Invoke(ObjPointer, NewStartTimeOffset);

        ///<summary>Stop playback of GeometryCache</summary>
        public void Stop()  => 
            GeometryCacheComponent_methods.Stop_method.Invoke(ObjPointer);

        ///<summary>Tick at This Time</summary>
        public void TickAtThisTime(float Time, bool bInIsRunning, bool bInBackwards, bool bInIsLooping)  => 
            GeometryCacheComponent_methods.TickAtThisTime_method.Invoke(ObjPointer, Time, bInIsRunning, bInBackwards, bInIsLooping);
        ///<summary>Geometry Cache instance referenced by the component</summary>
        public unsafe GeometryCache GeometryCache {
            get {return GeometryCacheComponent_ptr->GeometryCache;}
        }
        public bool bRunning {
            get {return Main.GetGetBoolPropertyByName(this, "bRunning"); }
            set {Main.SetGetBoolPropertyByName(this, "bRunning", value); }
        }
        public bool bLooping {
            get {return Main.GetGetBoolPropertyByName(this, "bLooping"); }
            set {Main.SetGetBoolPropertyByName(this, "bLooping", value); }
        }
        ///<summary>Start Time Offset</summary>
        public unsafe float StartTimeOffset {
            get {return GeometryCacheComponent_ptr->StartTimeOffset;}
            set {GeometryCacheComponent_ptr->StartTimeOffset = value;}
        }
        ///<summary>Playback Speed</summary>
        public unsafe float PlaybackSpeed {
            get {return GeometryCacheComponent_ptr->PlaybackSpeed;}
            set {GeometryCacheComponent_ptr->PlaybackSpeed = value;}
        }
        ///<summary>Num Tracks</summary>
        public unsafe int NumTracks {
            get {return GeometryCacheComponent_ptr->NumTracks;}
            set {GeometryCacheComponent_ptr->NumTracks = value;}
        }
        ///<summary>Elapsed Time</summary>
        public unsafe float ElapsedTime {
            get {return GeometryCacheComponent_ptr->ElapsedTime;}
            set {GeometryCacheComponent_ptr->ElapsedTime = value;}
        }
        ///<summary>Duration of the animation (maximum time)</summary>
        public unsafe float Duration {
            get {return GeometryCacheComponent_ptr->Duration;}
        }
        public bool bManualTick {
            get {return Main.GetGetBoolPropertyByName(this, "bManualTick"); }
            set {Main.SetGetBoolPropertyByName(this, "bManualTick", value); }
        }
        static GeometryCacheComponent() {
            StaticClass = Main.GetClass("GeometryCacheComponent");
        }
        internal unsafe GeometryCacheComponent_fields* GeometryCacheComponent_ptr => (GeometryCacheComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeometryCacheComponent(IntPtr p) => UObject.Make<GeometryCacheComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeometryCacheComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeometryCacheComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
