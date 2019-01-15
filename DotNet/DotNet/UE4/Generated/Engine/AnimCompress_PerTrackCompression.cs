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
    ///<summary>Anim Compress Per Track Compression</summary>
    public unsafe partial class AnimCompress_PerTrackCompression : AnimCompress_RemoveLinearKeys  {
        ///<summary>Maximum threshold to use when replacing a component with zero. Lower values retain more keys, but yield less compression.</summary>
        public unsafe float MaxZeroingThreshold {
            get {return AnimCompress_PerTrackCompression_ptr->MaxZeroingThreshold;}
            set {AnimCompress_PerTrackCompression_ptr->MaxZeroingThreshold = value;}
        }
        ///<summary>Maximum position difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
        public unsafe float MaxPosDiffBitwise {
            get {return AnimCompress_PerTrackCompression_ptr->MaxPosDiffBitwise;}
            set {AnimCompress_PerTrackCompression_ptr->MaxPosDiffBitwise = value;}
        }
        ///<summary>Maximum angle difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
        public unsafe float MaxAngleDiffBitwise {
            get {return AnimCompress_PerTrackCompression_ptr->MaxAngleDiffBitwise;}
            set {AnimCompress_PerTrackCompression_ptr->MaxAngleDiffBitwise = value;}
        }
        ///<summary>Maximum position difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
        public unsafe float MaxScaleDiffBitwise {
            get {return AnimCompress_PerTrackCompression_ptr->MaxScaleDiffBitwise;}
            set {AnimCompress_PerTrackCompression_ptr->MaxScaleDiffBitwise = value;}
        }
         //TODO: array not UObject TArray AllowedRotationFormats
         //TODO: array not UObject TArray AllowedTranslationFormats
         //TODO: array not UObject TArray AllowedScaleFormats
        public bool bResampleAnimation {
            get {return Main.GetGetBoolPropertyByName(this, "bResampleAnimation"); }
            set {Main.SetGetBoolPropertyByName(this, "bResampleAnimation", value); }
        }
        ///<summary>When bResampleAnimation is true, this defines the desired framerate</summary>
        public unsafe float ResampledFramerate {
            get {return AnimCompress_PerTrackCompression_ptr->ResampledFramerate;}
            set {AnimCompress_PerTrackCompression_ptr->ResampledFramerate = value;}
        }
        ///<summary>Animations with fewer keys than MinKeysForResampling will not be resampled.</summary>
        public unsafe int MinKeysForResampling {
            get {return AnimCompress_PerTrackCompression_ptr->MinKeysForResampling;}
            set {AnimCompress_PerTrackCompression_ptr->MinKeysForResampling = value;}
        }
        public bool bUseAdaptiveError {
            get {return Main.GetGetBoolPropertyByName(this, "bUseAdaptiveError"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseAdaptiveError", value); }
        }
        public bool bUseOverrideForEndEffectors {
            get {return Main.GetGetBoolPropertyByName(this, "bUseOverrideForEndEffectors"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseOverrideForEndEffectors", value); }
        }
        ///<summary>A bias added to the track height before using it to calculate the adaptive error</summary>
        public unsafe int TrackHeightBias {
            get {return AnimCompress_PerTrackCompression_ptr->TrackHeightBias;}
            set {AnimCompress_PerTrackCompression_ptr->TrackHeightBias = value;}
        }
        ///<summary>
        ///Reduces the error tolerance the further up the tree that a key occurs
        ///EffectiveErrorTolerance = Max(BaseErrorTolerance / Power(ParentingDivisor, Max(Height+Bias,0) * ParentingDivisorExponent), ZeroingThreshold)
        ///</summary>
        ///<remarks>Only has an effect bUseAdaptiveError is true</remarks>
        public unsafe float ParentingDivisor {
            get {return AnimCompress_PerTrackCompression_ptr->ParentingDivisor;}
            set {AnimCompress_PerTrackCompression_ptr->ParentingDivisor = value;}
        }
        ///<summary>
        ///Reduces the error tolerance the further up the tree that a key occurs
        ///EffectiveErrorTolerance = Max(BaseErrorTolerance / Power(ParentingDivisor, Max(Height+Bias,0) * ParentingDivisorExponent), ZeroingThreshold)
        ///</summary>
        ///<remarks>Only has an effect bUseAdaptiveError is true</remarks>
        public unsafe float ParentingDivisorExponent {
            get {return AnimCompress_PerTrackCompression_ptr->ParentingDivisorExponent;}
            set {AnimCompress_PerTrackCompression_ptr->ParentingDivisorExponent = value;}
        }
        public bool bUseAdaptiveError2 {
            get {return Main.GetGetBoolPropertyByName(this, "bUseAdaptiveError2"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseAdaptiveError2", value); }
        }
        ///<summary>This ratio determines how much error in end effector rotation can come from a given track's rotation error or translation error.</summary>
        ///<remarks>If 1, all of it must come from rotation error, if 0.5, half can come from each, and if 0.0, all must come from translation error.</remarks>
        public unsafe float RotationErrorSourceRatio {
            get {return AnimCompress_PerTrackCompression_ptr->RotationErrorSourceRatio;}
            set {AnimCompress_PerTrackCompression_ptr->RotationErrorSourceRatio = value;}
        }
        ///<summary>This ratio determines how much error in end effector translation can come from a given track's rotation error or translation error.</summary>
        ///<remarks>If 1, all of it must come from rotation error, if 0.5, half can come from each, and if 0.0, all must come from translation error.</remarks>
        public unsafe float TranslationErrorSourceRatio {
            get {return AnimCompress_PerTrackCompression_ptr->TranslationErrorSourceRatio;}
            set {AnimCompress_PerTrackCompression_ptr->TranslationErrorSourceRatio = value;}
        }
        ///<summary>This ratio determines how much error in end effector scale can come from a given track's rotation error or scale error.</summary>
        ///<remarks>If 1, all of it must come from rotation error, if 0.5, half can come from each, and if 0.0, all must come from scale error.</remarks>
        public unsafe float ScaleErrorSourceRatio {
            get {return AnimCompress_PerTrackCompression_ptr->ScaleErrorSourceRatio;}
            set {AnimCompress_PerTrackCompression_ptr->ScaleErrorSourceRatio = value;}
        }
        ///<summary>A fraction that determines how much of the total error budget can be introduced by any particular track</summary>
        public unsafe float MaxErrorPerTrackRatio {
            get {return AnimCompress_PerTrackCompression_ptr->MaxErrorPerTrackRatio;}
            set {AnimCompress_PerTrackCompression_ptr->MaxErrorPerTrackRatio = value;}
        }
        ///<summary>How big of a perturbation should be made when probing error propagation</summary>
        public unsafe float PerturbationProbeSize {
            get {return AnimCompress_PerTrackCompression_ptr->PerturbationProbeSize;}
            set {AnimCompress_PerTrackCompression_ptr->PerturbationProbeSize = value;}
        }
        static AnimCompress_PerTrackCompression() {
            StaticClass = Main.GetClass("AnimCompress_PerTrackCompression");
        }
        internal unsafe AnimCompress_PerTrackCompression_fields* AnimCompress_PerTrackCompression_ptr => (AnimCompress_PerTrackCompression_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimCompress_PerTrackCompression(IntPtr p) => UObject.Make<AnimCompress_PerTrackCompression>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimCompress_PerTrackCompression DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimCompress_PerTrackCompression New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
