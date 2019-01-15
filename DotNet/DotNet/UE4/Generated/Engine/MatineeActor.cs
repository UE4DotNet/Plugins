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
    ///<summary>Matinee Actor</summary>
    public unsafe partial class MatineeActor : Actor  {

        ///<summary>Changes the direction of playback (go in reverse if it was going forward, or vice versa)</summary>
        public void ChangePlaybackDirection()  => 
            MatineeActor_methods.ChangePlaybackDirection_method.Invoke(ObjPointer);

        ///<summary>Enable Group by Name</summary>
        public void EnableGroupByName(string GroupName, bool bEnable)  => 
            MatineeActor_methods.EnableGroupByName_method.Invoke(ObjPointer, GroupName, bEnable);

        ///<summary>Hold playback at its current position. Calling Pause again will continue playback in its current direction.</summary>
        public void Pause()  => 
            MatineeActor_methods.Pause_method.Invoke(ObjPointer);

        ///<summary>Begin playback of the matinee.</summary>
        ///<remarks>
        ///Only called in game.
        ///Will then advance Position by (PlayRate * Deltatime) each time the matinee is ticked.
        ///</remarks>
        public void Play()  => 
            MatineeActor_methods.Play_method.Invoke(ObjPointer);

        ///<summary>Similar to play, but the playback will go backwards until the beginning of the sequence is reached.</summary>
        public void Reverse()  => 
            MatineeActor_methods.Reverse_method.Invoke(ObjPointer);

        ///<summary>Change the looping behaviour of this matinee</summary>
        public void SetLoopingState(bool bNewLooping)  => 
            MatineeActor_methods.SetLoopingState_method.Invoke(ObjPointer, bNewLooping);

        ///<summary>Set the position of the interpolation.</summary>
        ///<remarks>
        ///@note if the interpolation is not currently active, this function doesn't send any Kismet events
        ///@param NewPosition the new position to set the interpolation to
        ///@param bJump if true, teleport to the new position (don't trigger any events between the old and new positions, etc)
        ///</remarks>
        public void SetPosition(float NewPosition, bool bJump)  => 
            MatineeActor_methods.SetPosition_method.Invoke(ObjPointer, NewPosition, bJump);

        ///<summary>Stops playback at the current position</summary>
        public void Stop()  => 
            MatineeActor_methods.Stop_method.Invoke(ObjPointer);
        ///<summary>The matinee data used by this actor</summary>
        public unsafe InterpData MatineeData {
            get {return MatineeActor_ptr->MatineeData;}
            set {MatineeActor_ptr->MatineeData = value;}
        }
        ///<summary>Name of controller node in level script, used to know what function to try and find for events</summary>
        public unsafe Name MatineeControllerName {
            get {return MatineeActor_ptr->MatineeControllerName;}
            set {MatineeActor_ptr->MatineeControllerName = value;}
        }
        ///<summary>Time multiplier for playback.</summary>
        public unsafe float PlayRate {
            get {return MatineeActor_ptr->PlayRate;}
            set {MatineeActor_ptr->PlayRate = value;}
        }
        public bool bPlayOnLevelLoad {
            get {return Main.GetGetBoolPropertyByName(this, "bPlayOnLevelLoad"); }
            set {Main.SetGetBoolPropertyByName(this, "bPlayOnLevelLoad", value); }
        }
        public bool bForceStartPos {
            get {return Main.GetGetBoolPropertyByName(this, "bForceStartPos"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceStartPos", value); }
        }
        ///<summary>Time position to always start at if bForceStartPos is set to true.</summary>
        public unsafe float ForceStartPosition {
            get {return MatineeActor_ptr->ForceStartPosition;}
            set {MatineeActor_ptr->ForceStartPosition = value;}
        }
        public bool bLooping {
            get {return Main.GetGetBoolPropertyByName(this, "bLooping"); }
            set {Main.SetGetBoolPropertyByName(this, "bLooping", value); }
        }
        public bool bRewindOnPlay {
            get {return Main.GetGetBoolPropertyByName(this, "bRewindOnPlay"); }
            set {Main.SetGetBoolPropertyByName(this, "bRewindOnPlay", value); }
        }
        public bool bNoResetOnRewind {
            get {return Main.GetGetBoolPropertyByName(this, "bNoResetOnRewind"); }
            set {Main.SetGetBoolPropertyByName(this, "bNoResetOnRewind", value); }
        }
        public bool bRewindIfAlreadyPlaying {
            get {return Main.GetGetBoolPropertyByName(this, "bRewindIfAlreadyPlaying"); }
            set {Main.SetGetBoolPropertyByName(this, "bRewindIfAlreadyPlaying", value); }
        }
        public bool bDisableRadioFilter {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableRadioFilter"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableRadioFilter", value); }
        }
        public bool bClientSideOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bClientSideOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bClientSideOnly", value); }
        }
        public bool bSkipUpdateIfNotVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bSkipUpdateIfNotVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bSkipUpdateIfNotVisible", value); }
        }
        public bool bIsSkippable {
            get {return Main.GetGetBoolPropertyByName(this, "bIsSkippable"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsSkippable", value); }
        }
        ///<summary>Preferred local viewport number (when split screen is active) the director track should associate with, or zero for 'all'.</summary>
        public unsafe int PreferredSplitScreenNum {
            get {return MatineeActor_ptr->PreferredSplitScreenNum;}
            set {MatineeActor_ptr->PreferredSplitScreenNum = value;}
        }
        public bool bDisableMovementInput {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableMovementInput"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableMovementInput", value); }
        }
        public bool bDisableLookAtInput {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableLookAtInput"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableLookAtInput", value); }
        }
        public bool bHidePlayer {
            get {return Main.GetGetBoolPropertyByName(this, "bHidePlayer"); }
            set {Main.SetGetBoolPropertyByName(this, "bHidePlayer", value); }
        }
        public bool bHideHud {
            get {return Main.GetGetBoolPropertyByName(this, "bHideHud"); }
            set {Main.SetGetBoolPropertyByName(this, "bHideHud", value); }
        }
         //TODO: array not UObject TArray GroupActorInfos
        public bool bShouldShowGore {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldShowGore"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldShowGore", value); }
        }
        ///<summary>Instance data for interp groups. One for each variable/group combination.</summary>
        public ObjectArrayField<InterpGroupInst> GroupInst{ get {
            if(GroupInst_store == null) GroupInst_store = new ObjectArrayField<InterpGroupInst> (&MatineeActor_ptr->GroupInst);
            return GroupInst_store;
        } }
        private ObjectArrayField<InterpGroupInst> GroupInst_store;

         //TODO: array not UObject TArray CameraCuts
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return MatineeActor_ptr->SpriteComponent;}
            set {MatineeActor_ptr->SpriteComponent = value;}
        }
        public bool bIsBeingEdited {
            get {return Main.GetGetBoolPropertyByName(this, "bIsBeingEdited"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsBeingEdited", value); }
        }
        public bool bIsScrubbing {
            get {return Main.GetGetBoolPropertyByName(this, "bIsScrubbing"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsScrubbing", value); }
        }
        public bool bIsPlaying {
            get {return Main.GetGetBoolPropertyByName(this, "bIsPlaying"); }
        }
        public bool bReversePlayback {
            get {return Main.GetGetBoolPropertyByName(this, "bReversePlayback"); }
            set {Main.SetGetBoolPropertyByName(this, "bReversePlayback", value); }
        }
        public bool bPaused {
            get {return Main.GetGetBoolPropertyByName(this, "bPaused"); }
            set {Main.SetGetBoolPropertyByName(this, "bPaused", value); }
        }
        public bool bPendingStop {
            get {return Main.GetGetBoolPropertyByName(this, "bPendingStop"); }
            set {Main.SetGetBoolPropertyByName(this, "bPendingStop", value); }
        }
        ///<summary>Interp Position</summary>
        public unsafe float InterpPosition {
            get {return MatineeActor_ptr->InterpPosition;}
        }
        ///<summary>Counter to indicate that play count has changed. Used to work around single frames that go from play-stop-play where bIsPlaying won't get replicated.</summary>
        public unsafe byte ReplicationForceIsPlaying {
            get {return MatineeActor_ptr->ReplicationForceIsPlaying;}
            set {MatineeActor_ptr->ReplicationForceIsPlaying = value;}
        }
         //TODO: multicast delegate FOnMatineeEvent OnPlay
         //TODO: multicast delegate FOnMatineeEvent OnStop
         //TODO: multicast delegate FOnMatineeEvent OnPause
        static MatineeActor() {
            StaticClass = Main.GetClass("MatineeActor");
        }
        internal unsafe MatineeActor_fields* MatineeActor_ptr => (MatineeActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MatineeActor(IntPtr p) => UObject.Make<MatineeActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MatineeActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MatineeActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
