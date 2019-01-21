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
using UE4.MovieScene.Native;

namespace UE4.MovieScene {
    ///<summary>Abstract class that provides consistent player behaviour for various animation players</summary>
    public unsafe partial class MovieSceneSequencePlayer : UObject  {

        ///<summary>Changes the direction of playback (go in reverse if it was going forward, or vice versa)</summary>
        public void ChangePlaybackDirection()  => 
            MovieSceneSequencePlayer_methods.ChangePlaybackDirection_method.Invoke(ObjPointer);

        ///<summary>Retrieve all objects currently bound to the specified binding identifier</summary>
        public IReadOnlyCollection<UObject> GetBoundObjects(MovieSceneObjectBindingID ObjectBinding)  => 
            MovieSceneSequencePlayer_methods.GetBoundObjects_method.Invoke(ObjPointer, ObjectBinding);

        ///<summary>
        ///Get the current playback position
        ///@
        ///</summary>
        ///<remarks>return The current playback position</remarks>
        public QualifiedFrameTime GetCurrentTime()  => 
            MovieSceneSequencePlayer_methods.GetCurrentTime_method.Invoke(ObjPointer);

        ///<summary>Set whether to disable camera cuts</summary>
        public bool GetDisableCameraCuts()  => 
            MovieSceneSequencePlayer_methods.GetDisableCameraCuts_method.Invoke(ObjPointer);

        ///<summary>Get the total duration of the sequence</summary>
        public QualifiedFrameTime GetDuration()  => 
            MovieSceneSequencePlayer_methods.GetDuration_method.Invoke(ObjPointer);

        ///<summary>Get the offset within the level sequence to finish playing</summary>
        public QualifiedFrameTime GetEndTime()  => 
            MovieSceneSequencePlayer_methods.GetEndTime_method.Invoke(ObjPointer);

        ///<summary>Get this sequence's duration in frames</summary>
        public int GetFrameDuration()  => 
            MovieSceneSequencePlayer_methods.GetFrameDuration_method.Invoke(ObjPointer);

        ///<summary>Get this sequence's display rate.</summary>
        public FrameRate GetFrameRate()  => 
            MovieSceneSequencePlayer_methods.GetFrameRate_method.Invoke(ObjPointer);

        ///<summary>Get Length</summary>
        public float GetLength()  => 
            MovieSceneSequencePlayer_methods.GetLength_method.Invoke(ObjPointer);

        ///<summary>Get the object bindings for the requested object</summary>
        public IReadOnlyCollection<MovieSceneObjectBindingID> GetObjectBindings(UObject InObject)  => 
            MovieSceneSequencePlayer_methods.GetObjectBindings_method.Invoke(ObjPointer, InObject);

        ///<summary>Get Playback End</summary>
        public float GetPlaybackEnd()  => 
            MovieSceneSequencePlayer_methods.GetPlaybackEnd_method.Invoke(ObjPointer);

        ///<summary>Get Playback Position</summary>
        public float GetPlaybackPosition()  => 
            MovieSceneSequencePlayer_methods.GetPlaybackPosition_method.Invoke(ObjPointer);

        ///<summary>Get Playback Start</summary>
        public float GetPlaybackStart()  => 
            MovieSceneSequencePlayer_methods.GetPlaybackStart_method.Invoke(ObjPointer);

        ///<summary>Get the playback rate of this player.</summary>
        public float GetPlayRate()  => 
            MovieSceneSequencePlayer_methods.GetPlayRate_method.Invoke(ObjPointer);

        ///<summary>Get the offset within the level sequence to start playing</summary>
        public QualifiedFrameTime GetStartTime()  => 
            MovieSceneSequencePlayer_methods.GetStartTime_method.Invoke(ObjPointer);

        ///<summary>Go to end of the sequence and stop. Adheres to 'When Finished' section rules.</summary>
        public void GoToEndAndStop()  => 
            MovieSceneSequencePlayer_methods.GoToEndAndStop_method.Invoke(ObjPointer);

        ///<summary>Check whether the sequence is paused.</summary>
        public bool IsPaused()  => 
            MovieSceneSequencePlayer_methods.IsPaused_method.Invoke(ObjPointer);

        ///<summary>Check whether the sequence is actively playing.</summary>
        public bool IsPlaying()  => 
            MovieSceneSequencePlayer_methods.IsPlaying_method.Invoke(ObjPointer);

        ///<summary>Check whether playback is reversed.</summary>
        public bool IsReversed()  => 
            MovieSceneSequencePlayer_methods.IsReversed_method.Invoke(ObjPointer);

        ///<summary>
        ///Jump to the specified frame position, without evaluating the sequence in between the current and desired time (as if in a paused state)
        ///@
        ///</summary>
        ///<remarks>param NewPosition     The new frame time to jump to</remarks>
        public void JumpToFrame(FrameTime NewPosition)  => 
            MovieSceneSequencePlayer_methods.JumpToFrame_method.Invoke(ObjPointer, NewPosition);

        ///<summary>Jump to Position</summary>
        public void JumpToPosition(float NewPlaybackPosition)  => 
            MovieSceneSequencePlayer_methods.JumpToPosition_method.Invoke(ObjPointer, NewPlaybackPosition);

        ///<summary>
        ///Jump to the specified time in seconds, without evaluating the sequence in between the current and desired time (as if in a paused state)
        ///@
        ///</summary>
        ///<remarks>param TimeInSeconds   The desired time in seconds</remarks>
        public void JumpToSeconds(float TimeInSeconds)  => 
            MovieSceneSequencePlayer_methods.JumpToSeconds_method.Invoke(ObjPointer, TimeInSeconds);

        ///<summary>Pause playback.</summary>
        public void Pause()  => 
            MovieSceneSequencePlayer_methods.Pause_method.Invoke(ObjPointer);

        ///<summary>Start playback forwards from the current time cursor position, using the current play rate.</summary>
        public void Play()  => 
            MovieSceneSequencePlayer_methods.Play_method.Invoke(ObjPointer);

        ///<summary>Start playback from the current time cursor position, looping the specified number of times.</summary>
        ///<remarks>
        ///@param NumLoops - The number of loops to play. -1 indicates infinite looping.
        ///</remarks>
        public void PlayLooping(int NumLoops)  => 
            MovieSceneSequencePlayer_methods.PlayLooping_method.Invoke(ObjPointer, NumLoops);

        ///<summary>Reverse playback.</summary>
        public void PlayReverse()  => 
            MovieSceneSequencePlayer_methods.PlayReverse_method.Invoke(ObjPointer);

        ///<summary>
        ///Play the sequence from the current time, to the specified frame position
        ///@
        ///</summary>
        ///<remarks>param NewPosition     The new frame time to play to</remarks>
        public void PlayToFrame(FrameTime NewPosition)  => 
            MovieSceneSequencePlayer_methods.PlayToFrame_method.Invoke(ObjPointer, NewPosition);

        ///<summary>
        ///Play the sequence from the current time, to the specified time in seconds
        ///@
        ///</summary>
        ///<remarks>param TimeInSeconds   The desired time in seconds</remarks>
        public void PlayToSeconds(float TimeInSeconds)  => 
            MovieSceneSequencePlayer_methods.PlayToSeconds_method.Invoke(ObjPointer, TimeInSeconds);

        ///<summary>Scrub playback.</summary>
        public void Scrub()  => 
            MovieSceneSequencePlayer_methods.Scrub_method.Invoke(ObjPointer);

        ///<summary>
        ///Scrub the sequence from the current time, to the specified frame position
        ///@
        ///</summary>
        ///<remarks>param NewPosition     The new frame time to scrub to</remarks>
        public void ScrubToFrame(FrameTime NewPosition)  => 
            MovieSceneSequencePlayer_methods.ScrubToFrame_method.Invoke(ObjPointer, NewPosition);

        ///<summary>
        ///Scrub the sequence from the current time, to the specified time in seconds
        ///@
        ///</summary>
        ///<remarks>param TimeInSeconds   The desired time in seconds</remarks>
        public void ScrubToSeconds(float TimeInSeconds)  => 
            MovieSceneSequencePlayer_methods.ScrubToSeconds_method.Invoke(ObjPointer, TimeInSeconds);

        ///<summary>Set whether to disable camera cuts</summary>
        public void SetDisableCameraCuts(bool bInDisableCameraCuts)  => 
            MovieSceneSequencePlayer_methods.SetDisableCameraCuts_method.Invoke(ObjPointer, bInDisableCameraCuts);

        ///<summary>
        ///Set the valid play range for this sequence, determined by a starting frame number (in this sequence player's plaback frame), and a number of frames duration
        ///@
        ///</summary>
        ///<remarks>
        ///param StartFrame      The frame number to start playing back the sequence
        ///@param Duration        The number of frames to play
        ///</remarks>
        public void SetFrameRange(int StartFrame, int Duration)  => 
            MovieSceneSequencePlayer_methods.SetFrameRange_method.Invoke(ObjPointer, StartFrame, Duration);

        ///<summary>Set the frame-rate that this player should play with, making all frame numbers in the specified time-space</summary>
        public void SetFrameRate(FrameRate FrameRate)  => 
            MovieSceneSequencePlayer_methods.SetFrameRate_method.Invoke(ObjPointer, FrameRate);

        ///<summary>Set Playback Position</summary>
        public void SetPlaybackPosition(float NewPlaybackPosition)  => 
            MovieSceneSequencePlayer_methods.SetPlaybackPosition_method.Invoke(ObjPointer, NewPlaybackPosition);

        ///<summary>Set Playback Range</summary>
        public void SetPlaybackRange(float NewStartTime, float NewEndTime)  => 
            MovieSceneSequencePlayer_methods.SetPlaybackRange_method.Invoke(ObjPointer, NewStartTime, NewEndTime);

        ///<summary>Set the playback rate of this player.</summary>
        ///<remarks>
        ///Negative values will play the animation in reverse.
        ///@param PlayRate - The new rate of playback for the animation.
        ///</remarks>
        public void SetPlayRate(float PlayRate)  => 
            MovieSceneSequencePlayer_methods.SetPlayRate_method.Invoke(ObjPointer, PlayRate);

        ///<summary>
        ///Set the valid play range for this sequence, determined by a starting time  and a duration (in seconds)
        ///@
        ///</summary>
        ///<remarks>
        ///param StartTime       The time to start playing back the sequence in seconds
        ///@param Duration        The length to play for
        ///</remarks>
        public void SetTimeRange(float StartTime, float Duration)  => 
            MovieSceneSequencePlayer_methods.SetTimeRange_method.Invoke(ObjPointer, StartTime, Duration);

        ///<summary>Stop playback.</summary>
        public void Stop()  => 
            MovieSceneSequencePlayer_methods.Stop_method.Invoke(ObjPointer);
         //TODO: multicast delegate FOnMovieSceneSequencePlayerEvent OnPlay
         //TODO: multicast delegate FOnMovieSceneSequencePlayerEvent OnPlayReverse
         //TODO: multicast delegate FOnMovieSceneSequencePlayerEvent OnStop
         //TODO: multicast delegate FOnMovieSceneSequencePlayerEvent OnPause
         //TODO: multicast delegate FOnMovieSceneSequencePlayerEvent OnFinished
        ///<summary>Movie player status.</summary>
        public unsafe byte Status {
            get {return MovieSceneSequencePlayer_ptr->Status;}
            set {MovieSceneSequencePlayer_ptr->Status = value;}
        }
        public bool bReversePlayback {
            get {return Main.GetGetBoolPropertyByName(this, "bReversePlayback"); }
            set {Main.SetGetBoolPropertyByName(this, "bReversePlayback", value); }
        }
        ///<summary>The sequence to play back</summary>
        public unsafe MovieSceneSequence Sequence {
            get {return MovieSceneSequencePlayer_ptr->Sequence;}
            set {MovieSceneSequencePlayer_ptr->Sequence = value;}
        }
        ///<summary>Time (in playback frames) at which to start playing the sequence (defaults to the lower bound of the sequence's play range)</summary>
        public unsafe FrameNumber StartTime {
            get {return MovieSceneSequencePlayer_ptr->StartTime;}
            set {MovieSceneSequencePlayer_ptr->StartTime = value;}
        }
        ///<summary>Time (in playback frames) at which to stop playing the sequence (defaults to the upper bound of the sequence's play range)</summary>
        public unsafe int DurationFrames {
            get {return MovieSceneSequencePlayer_ptr->DurationFrames;}
            set {MovieSceneSequencePlayer_ptr->DurationFrames = value;}
        }
        ///<summary>The number of times we have looped in the current playback</summary>
        public unsafe int CurrentNumLoops {
            get {return MovieSceneSequencePlayer_ptr->CurrentNumLoops;}
            set {MovieSceneSequencePlayer_ptr->CurrentNumLoops = value;}
        }
        ///<summary>Specific playback settings for the animation.</summary>
        public unsafe MovieSceneSequencePlaybackSettings PlaybackSettings {
            get {return MovieSceneSequencePlayer_ptr->PlaybackSettings;}
            set {MovieSceneSequencePlayer_ptr->PlaybackSettings = value;}
        }
        ///<summary>The root template instance we're evaluating</summary>
        public unsafe MovieSceneRootEvaluationTemplateInstance RootTemplateInstance {
            get {return MovieSceneSequencePlayer_ptr->RootTemplateInstance;}
            set {MovieSceneSequencePlayer_ptr->RootTemplateInstance = value;}
        }
        static MovieSceneSequencePlayer() {
            StaticClass = Main.GetClass("MovieSceneSequencePlayer");
        }
        internal unsafe MovieSceneSequencePlayer_fields* MovieSceneSequencePlayer_ptr => (MovieSceneSequencePlayer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneSequencePlayer(IntPtr p) => UObject.Make<MovieSceneSequencePlayer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneSequencePlayer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneSequencePlayer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
