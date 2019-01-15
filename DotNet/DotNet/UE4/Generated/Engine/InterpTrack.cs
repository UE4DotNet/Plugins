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
    ///<summary>Interp Track</summary>
    public unsafe partial class InterpTrack : UObject  {
        ///<summary>A list of subtracks that belong to this track</summary>
        public ObjectArrayField<InterpTrack> SubTracks{ get {
            if(SubTracks_store == null) SubTracks_store = new ObjectArrayField<InterpTrack> (&InterpTrack_ptr->SubTracks);
            return SubTracks_store;
        } }
        private ObjectArrayField<InterpTrack> SubTracks_store;

         //TODO: array not UObject TArray SubTrackGroups
         //TODO: array not UObject TArray SupportedSubTracks
        ///<summary>Track Inst Class</summary>
        public unsafe SubclassOf<InterpTrackInst> TrackInstClass {
            get {return InterpTrack_ptr->TrackInstClass;}
            set {InterpTrack_ptr->TrackInstClass = value;}
        }
        ///<summary>Sets the condition that must be met for this track to be enabled</summary>
        public unsafe byte ActiveCondition {
            get {return InterpTrack_ptr->ActiveCondition;}
            set {InterpTrack_ptr->ActiveCondition = value;}
        }
         //TODO: string FString TrackTitle
        public bool bOnePerGroup {
            get {return Main.GetGetBoolPropertyByName(this, "bOnePerGroup"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnePerGroup", value); }
        }
        public bool bDirGroupOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bDirGroupOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bDirGroupOnly", value); }
        }
        public bool bDisableTrack {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableTrack"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableTrack", value); }
        }
        public bool bIsSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bIsSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsSelected", value); }
        }
        ///<summary>Track Icon</summary>
        public unsafe Texture2D TrackIcon {
            get {return InterpTrack_ptr->TrackIcon;}
            set {InterpTrack_ptr->TrackIcon = value;}
        }
        public bool bIsAnimControlTrack {
            get {return Main.GetGetBoolPropertyByName(this, "bIsAnimControlTrack"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsAnimControlTrack", value); }
        }
        public bool bSubTrackOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bSubTrackOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bSubTrackOnly", value); }
        }
        public bool bVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bVisible", value); }
        }
        public bool bIsRecording {
            get {return Main.GetGetBoolPropertyByName(this, "bIsRecording"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsRecording", value); }
        }
        public bool bIsCollapsed {
            get {return Main.GetGetBoolPropertyByName(this, "bIsCollapsed"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsCollapsed", value); }
        }
        static InterpTrack() {
            StaticClass = Main.GetClass("InterpTrack");
        }
        internal unsafe InterpTrack_fields* InterpTrack_ptr => (InterpTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrack(IntPtr p) => UObject.Make<InterpTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
