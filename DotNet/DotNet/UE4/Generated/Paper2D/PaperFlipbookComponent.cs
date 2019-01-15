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
using UE4.Paper2D.Native;
using UE4.Engine;

namespace UE4.Paper2D {
    ///<summary>Paper Flipbook Component</summary>
    public unsafe partial class PaperFlipbookComponent : MeshComponent  {

        ///<summary>Gets the flipbook used by this instance.</summary>
        public PaperFlipbook GetFlipbook()  => 
            PaperFlipbookComponent_methods.GetFlipbook_method.Invoke(ObjPointer);

        ///<summary>Get the nominal framerate that the flipbook will be played back at (ignoring PlayRate), in frames per second</summary>
        public float GetFlipbookFramerate()  => 
            PaperFlipbookComponent_methods.GetFlipbookFramerate_method.Invoke(ObjPointer);

        ///<summary>Get length of the flipbook (in seconds)</summary>
        public float GetFlipbookLength()  => 
            PaperFlipbookComponent_methods.GetFlipbookLength_method.Invoke(ObjPointer);

        ///<summary>Get length of the flipbook (in frames)</summary>
        public int GetFlipbookLengthInFrames()  => 
            PaperFlipbookComponent_methods.GetFlipbookLengthInFrames_method.Invoke(ObjPointer);

        ///<summary>Get the current playback position (in seconds) of the flipbook</summary>
        public float GetPlaybackPosition()  => 
            PaperFlipbookComponent_methods.GetPlaybackPosition_method.Invoke(ObjPointer);

        ///<summary>Get the current playback position (in frames) of the flipbook</summary>
        public int GetPlaybackPositionInFrames()  => 
            PaperFlipbookComponent_methods.GetPlaybackPositionInFrames_method.Invoke(ObjPointer);

        ///<summary>Get the current play rate for this flipbook</summary>
        public float GetPlayRate()  => 
            PaperFlipbookComponent_methods.GetPlayRate_method.Invoke(ObjPointer);

        ///<summary>Get whether we are looping or not</summary>
        public bool IsLooping()  => 
            PaperFlipbookComponent_methods.IsLooping_method.Invoke(ObjPointer);

        ///<summary>Get whether this flipbook is playing or not.</summary>
        public bool IsPlaying()  => 
            PaperFlipbookComponent_methods.IsPlaying_method.Invoke(ObjPointer);

        ///<summary>Get whether we are reversing or not</summary>
        public bool IsReversing()  => 
            PaperFlipbookComponent_methods.IsReversing_method.Invoke(ObjPointer);

        ///<summary>Start playback of flipbook</summary>
        public void Play()  => 
            PaperFlipbookComponent_methods.Play_method.Invoke(ObjPointer);

        ///<summary>Start playback of flipbook from the start</summary>
        public void PlayFromStart()  => 
            PaperFlipbookComponent_methods.PlayFromStart_method.Invoke(ObjPointer);

        ///<summary>Start playback of flipbook in reverse</summary>
        public void Reverse()  => 
            PaperFlipbookComponent_methods.Reverse_method.Invoke(ObjPointer);

        ///<summary>Start playback of flipbook in reverse from the end</summary>
        public void ReverseFromEnd()  => 
            PaperFlipbookComponent_methods.ReverseFromEnd_method.Invoke(ObjPointer);

        ///<summary>Change the flipbook used by this instance (will reset the play time to 0 if it is a new flipbook).</summary>
        public bool SetFlipbook(PaperFlipbook NewFlipbook)  => 
            PaperFlipbookComponent_methods.SetFlipbook_method.Invoke(ObjPointer, NewFlipbook);

        ///<summary>true means we should loop, false means we should not.</summary>
        public void SetLooping(bool bNewLooping)  => 
            PaperFlipbookComponent_methods.SetLooping_method.Invoke(ObjPointer, bNewLooping);

        ///<summary>Set the new playback position time to use</summary>
        public void SetNewTime(float NewTime)  => 
            PaperFlipbookComponent_methods.SetNewTime_method.Invoke(ObjPointer, NewTime);

        ///<summary>Jump to a position in the flipbook (expressed in seconds). If bFireEvents is true, event functions will fire, otherwise they will not.</summary>
        public void SetPlaybackPosition(float NewPosition, bool bFireEvents)  => 
            PaperFlipbookComponent_methods.SetPlaybackPosition_method.Invoke(ObjPointer, NewPosition, bFireEvents);

        ///<summary>Jump to a position in the flipbook (expressed in frames). If bFireEvents is true, event functions will fire, otherwise they will not.</summary>
        public void SetPlaybackPositionInFrames(int NewFramePosition, bool bFireEvents)  => 
            PaperFlipbookComponent_methods.SetPlaybackPositionInFrames_method.Invoke(ObjPointer, NewFramePosition, bFireEvents);

        ///<summary>Sets the new play rate for this flipbook</summary>
        public void SetPlayRate(float NewRate)  => 
            PaperFlipbookComponent_methods.SetPlayRate_method.Invoke(ObjPointer, NewRate);

        ///<summary>Set color of the sprite</summary>
        public void SetSpriteColor(LinearColor NewColor)  => 
            PaperFlipbookComponent_methods.SetSpriteColor_method.Invoke(ObjPointer, NewColor);

        ///<summary>Stop playback of flipbook</summary>
        public void Stop()  => 
            PaperFlipbookComponent_methods.Stop_method.Invoke(ObjPointer);
        ///<summary>Flipbook currently being played</summary>
        public unsafe PaperFlipbook SourceFlipbook {
            get {return PaperFlipbookComponent_ptr->SourceFlipbook;}
            set {PaperFlipbookComponent_ptr->SourceFlipbook = value;}
        }
        ///<summary>Current play rate of the flipbook</summary>
        public unsafe float PlayRate {
            get {return PaperFlipbookComponent_ptr->PlayRate;}
            set {PaperFlipbookComponent_ptr->PlayRate = value;}
        }
        public bool bLooping {
            get {return Main.GetGetBoolPropertyByName(this, "bLooping"); }
            set {Main.SetGetBoolPropertyByName(this, "bLooping", value); }
        }
        public bool bReversePlayback {
            get {return Main.GetGetBoolPropertyByName(this, "bReversePlayback"); }
            set {Main.SetGetBoolPropertyByName(this, "bReversePlayback", value); }
        }
        public bool bPlaying {
            get {return Main.GetGetBoolPropertyByName(this, "bPlaying"); }
            set {Main.SetGetBoolPropertyByName(this, "bPlaying", value); }
        }
        ///<summary>Current position in the timeline</summary>
        public unsafe float AccumulatedTime {
            get {return PaperFlipbookComponent_ptr->AccumulatedTime;}
            set {PaperFlipbookComponent_ptr->AccumulatedTime = value;}
        }
        ///<summary>Last frame index calculated</summary>
        public unsafe int CachedFrameIndex {
            get {return PaperFlipbookComponent_ptr->CachedFrameIndex;}
            set {PaperFlipbookComponent_ptr->CachedFrameIndex = value;}
        }
        ///<summary>Vertex color to apply to the frames</summary>
        public unsafe LinearColor SpriteColor {
            get {return PaperFlipbookComponent_ptr->SpriteColor;}
        }
        ///<summary>The cached body setup</summary>
        public unsafe BodySetup CachedBodySetup {
            get {return PaperFlipbookComponent_ptr->CachedBodySetup;}
            set {PaperFlipbookComponent_ptr->CachedBodySetup = value;}
        }
         //TODO: multicast delegate FFlipbookFinishedPlaySignature OnFinishedPlaying
        static PaperFlipbookComponent() {
            StaticClass = Main.GetClass("PaperFlipbookComponent");
        }
        internal unsafe PaperFlipbookComponent_fields* PaperFlipbookComponent_ptr => (PaperFlipbookComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperFlipbookComponent(IntPtr p) => UObject.Make<PaperFlipbookComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperFlipbookComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperFlipbookComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
