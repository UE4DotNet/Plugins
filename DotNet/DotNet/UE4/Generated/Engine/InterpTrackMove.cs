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
    ///<summary>Track containing data for moving an actor around over time.</summary>
    public unsafe partial class InterpTrackMove : InterpTrack  {
        ///<summary>Actual position keyframe data.</summary>
        public unsafe InterpCurveVector PosTrack {
            get {return InterpTrackMove_ptr->PosTrack;}
        }
        ///<summary>Actual rotation keyframe data, stored as Euler angles in degrees, for easy editing on curve.</summary>
        public unsafe InterpCurveVector EulerTrack {
            get {return InterpTrackMove_ptr->EulerTrack;}
            set {InterpTrackMove_ptr->EulerTrack = value;}
        }
        ///<summary>Lookup Track</summary>
        public unsafe InterpLookupTrack LookupTrack {
            get {return InterpTrackMove_ptr->LookupTrack;}
            set {InterpTrackMove_ptr->LookupTrack = value;}
        }
        ///<summary>When using IMR_LookAtGroup, specifies the Group which this track should always point its actor at.</summary>
        public unsafe Name LookAtGroupName {
            get {return InterpTrackMove_ptr->LookAtGroupName;}
            set {InterpTrackMove_ptr->LookAtGroupName = value;}
        }
        ///<summary>Controls the tightness of the curve for the translation path.</summary>
        public unsafe float LinCurveTension {
            get {return InterpTrackMove_ptr->LinCurveTension;}
            set {InterpTrackMove_ptr->LinCurveTension = value;}
        }
        ///<summary>Controls the tightness of the curve for the rotation path.</summary>
        public unsafe float AngCurveTension {
            get {return InterpTrackMove_ptr->AngCurveTension;}
            set {InterpTrackMove_ptr->AngCurveTension = value;}
        }
        public bool bUseQuatInterpolation {
            get {return Main.GetGetBoolPropertyByName(this, "bUseQuatInterpolation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseQuatInterpolation", value); }
        }
        public bool bShowArrowAtKeys {
            get {return Main.GetGetBoolPropertyByName(this, "bShowArrowAtKeys"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowArrowAtKeys", value); }
        }
        public bool bDisableMovement {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableMovement"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableMovement", value); }
        }
        public bool bShowTranslationOnCurveEd {
            get {return Main.GetGetBoolPropertyByName(this, "bShowTranslationOnCurveEd"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowTranslationOnCurveEd", value); }
        }
        public bool bShowRotationOnCurveEd {
            get {return Main.GetGetBoolPropertyByName(this, "bShowRotationOnCurveEd"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowRotationOnCurveEd", value); }
        }
        public bool bHide3DTrack {
            get {return Main.GetGetBoolPropertyByName(this, "bHide3DTrack"); }
            set {Main.SetGetBoolPropertyByName(this, "bHide3DTrack", value); }
        }
        ///<summary>Rot Mode</summary>
        public unsafe byte RotMode {
            get {return InterpTrackMove_ptr->RotMode;}
            set {InterpTrackMove_ptr->RotMode = value;}
        }
        static InterpTrackMove() {
            StaticClass = Main.GetClass("InterpTrackMove");
        }
        internal unsafe InterpTrackMove_fields* InterpTrackMove_ptr => (InterpTrackMove_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackMove(IntPtr p) => UObject.Make<InterpTrackMove>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackMove DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackMove New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
