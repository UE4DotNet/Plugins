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
    ///<summary>
    ///A CameraShake is an asset that defines how to shake the camera in
    ///a particular way.
    ///</summary>
    ///<remarks>
    ///CameraShakes can be authored as either oscillating shakes,
    ///animated shakes, or both.
    ///
    ///An oscillating shake will sinusoidally vibrate various camera parameters over time. Each location
    ///and rotation axis can be oscillated independently with different parameters to create complex and
    ///random-feeling shakes. These are easier to author and tweak, but can still feel mechanical and are
    ///limited to vibration-style shakes, such as earthquakes.
    ///
    ///Animated shakes play keyframed camera animations.  These can take more effort to author, but enable
    ///more natural-feeling results and things like directional shakes.  For instance, you can have an explosion
    ///to the camera's right push it primarily to the left.
    ///</remarks>
    public unsafe partial class CameraShake : UObject  {

        ///<summary>Called every tick to let the shake modify the point of view</summary>
        public event BlueprintUpdateCameraShake_delegate BlueprintUpdateCameraShake;
        public delegate (MinimalViewInfo, MinimalViewInfo) BlueprintUpdateCameraShake_delegate(float DeltaTime, float Alpha, MinimalViewInfo POV, MinimalViewInfo ModifiedPOV);
        internal (MinimalViewInfo, MinimalViewInfo) on_BlueprintUpdateCameraShake(float DeltaTime, float Alpha, MinimalViewInfo POV, MinimalViewInfo ModifiedPOV) =>
            BlueprintUpdateCameraShake != null ? BlueprintUpdateCameraShake(DeltaTime, Alpha, POV, ModifiedPOV) : (POV, ModifiedPOV);


        ///<summary>Called when the shake starts playing</summary>
        public event ReceivePlayShake_delegate ReceivePlayShake;
        public delegate void ReceivePlayShake_delegate(float Scale);
        internal void on_ReceivePlayShake(float Scale) =>
            ReceivePlayShake?.Invoke(Scale);


        ///<summary>Called when the shake is explicitly stopped.</summary>
        ///<remarks>
        ///@param bImmediatly           If true, shake stops right away regardless of blend out settings. If false, shake may blend out according to its settings.
        ///</remarks>
        public event ReceiveStopShake_delegate ReceiveStopShake;
        public delegate void ReceiveStopShake_delegate(bool bImmediately);
        internal void on_ReceiveStopShake(bool bImmediately) =>
            ReceiveStopShake?.Invoke(bImmediately);


        ///<summary>Called to allow a shake to decide when it's finished playing.</summary>
        public event ReceiveIsFinished_delegate ReceiveIsFinished;
        public delegate bool ReceiveIsFinished_delegate(bool ReturnValue);
        internal bool on_ReceiveIsFinished(bool ReturnValue) =>
            ReceiveIsFinished != null ? ReceiveIsFinished(ReturnValue) : ReturnValue;

        public bool bSingleInstance {
            get {return Main.GetGetBoolPropertyByName(this, "bSingleInstance"); }
            set {Main.SetGetBoolPropertyByName(this, "bSingleInstance", value); }
        }
        ///<summary>Duration in seconds of current screen shake. Less than 0 means indefinite, 0 means no oscillation.</summary>
        public unsafe float OscillationDuration {
            get {return CameraShake_ptr->OscillationDuration;}
            set {CameraShake_ptr->OscillationDuration = value;}
        }
        ///<summary>Duration of the blend-in, where the oscillation scales from 0 to 1.</summary>
        public unsafe float OscillationBlendInTime {
            get {return CameraShake_ptr->OscillationBlendInTime;}
            set {CameraShake_ptr->OscillationBlendInTime = value;}
        }
        ///<summary>Duration of the blend-out, where the oscillation scales from 1 to 0.</summary>
        public unsafe float OscillationBlendOutTime {
            get {return CameraShake_ptr->OscillationBlendOutTime;}
            set {CameraShake_ptr->OscillationBlendOutTime = value;}
        }
        ///<summary>Rotational oscillation</summary>
        public unsafe ROscillator RotOscillation {
            get {return CameraShake_ptr->RotOscillation;}
            set {CameraShake_ptr->RotOscillation = value;}
        }
        ///<summary>Positional oscillation</summary>
        public unsafe VOscillator LocOscillation {
            get {return CameraShake_ptr->LocOscillation;}
            set {CameraShake_ptr->LocOscillation = value;}
        }
        ///<summary>FOV oscillation</summary>
        public unsafe FOscillator FOVOscillation {
            get {return CameraShake_ptr->FOVOscillation;}
            set {CameraShake_ptr->FOVOscillation = value;}
        }
        ///<summary>Scalar defining how fast to play the anim.</summary>
        public unsafe float AnimPlayRate {
            get {return CameraShake_ptr->AnimPlayRate;}
            set {CameraShake_ptr->AnimPlayRate = value;}
        }
        ///<summary>Scalar defining how "intense" to play the anim.</summary>
        public unsafe float AnimScale {
            get {return CameraShake_ptr->AnimScale;}
            set {CameraShake_ptr->AnimScale = value;}
        }
        ///<summary>Linear blend-in time.</summary>
        public unsafe float AnimBlendInTime {
            get {return CameraShake_ptr->AnimBlendInTime;}
            set {CameraShake_ptr->AnimBlendInTime = value;}
        }
        ///<summary>Linear blend-out time.</summary>
        public unsafe float AnimBlendOutTime {
            get {return CameraShake_ptr->AnimBlendOutTime;}
            set {CameraShake_ptr->AnimBlendOutTime = value;}
        }
        ///<summary>When bRandomAnimSegment is true, this defines how long the anim should play.</summary>
        public unsafe float RandomAnimSegmentDuration {
            get {return CameraShake_ptr->RandomAnimSegmentDuration;}
            set {CameraShake_ptr->RandomAnimSegmentDuration = value;}
        }
        ///<summary>Source camera animation to play. Can be null.</summary>
        public unsafe CameraAnim Anim {
            get {return CameraShake_ptr->Anim;}
            set {CameraShake_ptr->Anim = value;}
        }
        public bool bRandomAnimSegment {
            get {return Main.GetGetBoolPropertyByName(this, "bRandomAnimSegment"); }
            set {Main.SetGetBoolPropertyByName(this, "bRandomAnimSegment", value); }
        }
        ///<summary>Camera Owner</summary>
        public unsafe PlayerCameraManager CameraOwner {
            get {return CameraShake_ptr->CameraOwner;}
        }
        ///<summary>Overall intensity scale for this shake instance.</summary>
        public unsafe float ShakeScale {
            get {return CameraShake_ptr->ShakeScale;}
        }
        ///<summary>Time remaining for oscillation shakes. Less than 0.f means shake infinitely.</summary>
        public unsafe float OscillatorTimeRemaining {
            get {return CameraShake_ptr->OscillatorTimeRemaining;}
        }
        ///<summary>The playing instance of the CameraAnim-based shake, if any.</summary>
        public unsafe CameraAnimInst AnimInst {
            get {return CameraShake_ptr->AnimInst;}
        }
        static CameraShake() {
            StaticClass = Main.GetClass("CameraShake");
            CameraShake_events.BlueprintUpdateCameraShake_event.Setup();
            CameraShake_events.ReceivePlayShake_event.Setup();
            CameraShake_events.ReceiveStopShake_event.Setup();
            CameraShake_events.ReceiveIsFinished_event.Setup();
        }
        internal unsafe CameraShake_fields* CameraShake_ptr => (CameraShake_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CameraShake(IntPtr p) => UObject.Make<CameraShake>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CameraShake DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CameraShake New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
