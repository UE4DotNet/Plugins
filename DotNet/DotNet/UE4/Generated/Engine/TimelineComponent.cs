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
    ///<summary>TimelineComponent holds a series of events, floats, vectors or colors with associated keyframes.</summary>
    ///<remarks>
    ///Events can be triggered at keyframes along the timeline.
    ///Floats, vectors, and colors are interpolated between keyframes along the timeline.
    ///</remarks>
    public unsafe partial class TimelineComponent : ActorComponent  {

        ///<summary>Get whether to ignore time dilation.</summary>
        public bool GetIgnoreTimeDilation()  => 
            TimelineComponent_methods.GetIgnoreTimeDilation_method.Invoke(ObjPointer);

        ///<summary>Get the current playback position of the Timeline</summary>
        public float GetPlaybackPosition()  => 
            TimelineComponent_methods.GetPlaybackPosition_method.Invoke(ObjPointer);

        ///<summary>Get the current play rate for this timeline</summary>
        public float GetPlayRate()  => 
            TimelineComponent_methods.GetPlayRate_method.Invoke(ObjPointer);

        ///<summary>Get length of the timeline</summary>
        public float GetTimelineLength()  => 
            TimelineComponent_methods.GetTimelineLength_method.Invoke(ObjPointer);

        ///<summary>Get whether we are looping or not</summary>
        public bool IsLooping()  => 
            TimelineComponent_methods.IsLooping_method.Invoke(ObjPointer);

        ///<summary>Get whether this timeline is playing or not.</summary>
        public bool IsPlaying()  => 
            TimelineComponent_methods.IsPlaying_method.Invoke(ObjPointer);

        ///<summary>Get whether we are reversing or not</summary>
        public bool IsReversing()  => 
            TimelineComponent_methods.IsReversing_method.Invoke(ObjPointer);

        ///<summary>Start playback of timeline</summary>
        public void Play()  => 
            TimelineComponent_methods.Play_method.Invoke(ObjPointer);

        ///<summary>Start playback of timeline from the start</summary>
        public void PlayFromStart()  => 
            TimelineComponent_methods.PlayFromStart_method.Invoke(ObjPointer);

        ///<summary>Start playback of timeline in reverse</summary>
        public void Reverse()  => 
            TimelineComponent_methods.Reverse_method.Invoke(ObjPointer);

        ///<summary>Start playback of timeline in reverse from the end</summary>
        public void ReverseFromEnd()  => 
            TimelineComponent_methods.ReverseFromEnd_method.Invoke(ObjPointer);

        ///<summary>Update a certain float track's curve</summary>
        public void SetFloatCurve(CurveFloat NewFloatCurve, Name FloatTrackName)  => 
            TimelineComponent_methods.SetFloatCurve_method.Invoke(ObjPointer, NewFloatCurve, FloatTrackName);

        ///<summary>Set whether to ignore time dilation.</summary>
        public void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation)  => 
            TimelineComponent_methods.SetIgnoreTimeDilation_method.Invoke(ObjPointer, bNewIgnoreTimeDilation);

        ///<summary>Update a certain linear color track's curve</summary>
        public void SetLinearColorCurve(CurveLinearColor NewLinearColorCurve, Name LinearColorTrackName)  => 
            TimelineComponent_methods.SetLinearColorCurve_method.Invoke(ObjPointer, NewLinearColorCurve, LinearColorTrackName);

        ///<summary>true means we would loop, false means we should not.</summary>
        public void SetLooping(bool bNewLooping)  => 
            TimelineComponent_methods.SetLooping_method.Invoke(ObjPointer, bNewLooping);

        ///<summary>Set the new playback position time to use</summary>
        public void SetNewTime(float NewTime)  => 
            TimelineComponent_methods.SetNewTime_method.Invoke(ObjPointer, NewTime);

        ///<summary>Jump to a position in the timeline.</summary>
        ///<remarks>
        ///@param bFireEvents If true, event functions that are between current position and new playback position will fire.
        ///@param bFireUpdate If true, the update output exec will fire after setting the new playback position.
        ///</remarks>
        public void SetPlaybackPosition(float NewPosition, bool bFireEvents, bool bFireUpdate)  => 
            TimelineComponent_methods.SetPlaybackPosition_method.Invoke(ObjPointer, NewPosition, bFireEvents, bFireUpdate);

        ///<summary>Sets the new play rate for this timeline</summary>
        public void SetPlayRate(float NewRate)  => 
            TimelineComponent_methods.SetPlayRate_method.Invoke(ObjPointer, NewRate);

        ///<summary>Set length of the timeline</summary>
        public void SetTimelineLength(float NewLength)  => 
            TimelineComponent_methods.SetTimelineLength_method.Invoke(ObjPointer, NewLength);

        ///<summary>Sets the length mode of the timeline</summary>
        public void SetTimelineLengthMode(byte NewLengthMode)  => 
            TimelineComponent_methods.SetTimelineLengthMode_method.Invoke(ObjPointer, NewLengthMode);

        ///<summary>Update a certain vector track's curve</summary>
        public void SetVectorCurve(CurveVector NewVectorCurve, Name VectorTrackName)  => 
            TimelineComponent_methods.SetVectorCurve_method.Invoke(ObjPointer, NewVectorCurve, VectorTrackName);

        ///<summary>Stop playback of timeline</summary>
        public void Stop()  => 
            TimelineComponent_methods.Stop_method.Invoke(ObjPointer);
        ///<summary>The actual timeline structure</summary>
        public unsafe Timeline TheTimeline {
            get {return TimelineComponent_ptr->TheTimeline;}
            set {TimelineComponent_ptr->TheTimeline = value;}
        }
        public bool bIgnoreTimeDilation {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreTimeDilation"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreTimeDilation", value); }
        }
        static TimelineComponent() {
            StaticClass = Main.GetClass("TimelineComponent");
        }
        internal unsafe TimelineComponent_fields* TimelineComponent_ptr => (TimelineComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TimelineComponent(IntPtr p) => UObject.Make<TimelineComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TimelineComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TimelineComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
