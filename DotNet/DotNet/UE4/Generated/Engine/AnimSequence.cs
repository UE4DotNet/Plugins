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
    ///<summary>Anim Sequence</summary>
    public unsafe partial class AnimSequence : AnimSequenceBase  {
        ///<summary>Number of raw frames in this sequence (not used by engine - just for informational purposes).</summary>
        public unsafe int NumFrames {
            get {return AnimSequence_ptr->NumFrames;}
            set {AnimSequence_ptr->NumFrames = value;}
        }
        ///<summary>The DCC framerate of the imported file. UI information only, unit are Hz</summary>
        public unsafe float ImportFileFramerate {
            get {return AnimSequence_ptr->ImportFileFramerate;}
            set {AnimSequence_ptr->ImportFileFramerate = value;}
        }
        ///<summary>The resample framerate that was computed during import. UI information only, unit are Hz</summary>
        public unsafe int ImportResampleFramerate {
            get {return AnimSequence_ptr->ImportResampleFramerate;}
            set {AnimSequence_ptr->ImportResampleFramerate = value;}
        }
         //TODO: array not UObject TArray TrackToSkeletonMapTable
        ///<summary>Update this if the contents of RawAnimationData changes;</summary>
        public unsafe FGuid RawDataGuid {
            get {return AnimSequence_ptr->RawDataGuid;}
            set {AnimSequence_ptr->RawDataGuid = value;}
        }
         //TODO: array not UObject TArray AnimationTrackNames
        ///<summary>The compression scheme that was most recently used to compress this animation.</summary>
        public unsafe AnimCompress CompressionScheme {
            get {return AnimSequence_ptr->CompressionScheme;}
            set {AnimSequence_ptr->CompressionScheme = value;}
        }
        ///<summary>Additive animation type. *</summary>
        public unsafe byte AdditiveAnimType {
            get {return AnimSequence_ptr->AdditiveAnimType;}
            set {AnimSequence_ptr->AdditiveAnimType = value;}
        }
        ///<summary>Additive refrerence pose type. Refer above enum type</summary>
        public unsafe byte RefPoseType {
            get {return AnimSequence_ptr->RefPoseType;}
            set {AnimSequence_ptr->RefPoseType = value;}
        }
        ///<summary>Additive reference animation if it's relevant - i.e. AnimScaled or AnimFrame *</summary>
        public unsafe AnimSequence RefPoseSeq {
            get {return AnimSequence_ptr->RefPoseSeq;}
            set {AnimSequence_ptr->RefPoseSeq = value;}
        }
        ///<summary>Additve reference frame if RefPoseType == AnimFrame *</summary>
        public unsafe int RefFrameIndex {
            get {return AnimSequence_ptr->RefFrameIndex;}
            set {AnimSequence_ptr->RefFrameIndex = value;}
        }
        ///<summary>The version of the global encoding package used at the time of import</summary>
        public unsafe int EncodingPkgVersion {
            get {return AnimSequence_ptr->EncodingPkgVersion;}
            set {AnimSequence_ptr->EncodingPkgVersion = value;}
        }
        ///<summary>Base pose to use when retargeting</summary>
        public unsafe Name RetargetSource {
            get {return AnimSequence_ptr->RetargetSource;}
            set {AnimSequence_ptr->RetargetSource = value;}
        }
         //TODO: enum EAnimInterpolationType Interpolation
        public bool bEnableRootMotion {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableRootMotion"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableRootMotion", value); }
        }
        ///<summary>Root Bone will be locked to that position when extracting root motion.*</summary>
        public unsafe byte RootMotionRootLock {
            get {return AnimSequence_ptr->RootMotionRootLock;}
            set {AnimSequence_ptr->RootMotionRootLock = value;}
        }
        public bool bForceRootLock {
            get {return Main.GetGetBoolPropertyByName(this, "bForceRootLock"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceRootLock", value); }
        }
        public bool bUseNormalizedRootMotionScale {
            get {return Main.GetGetBoolPropertyByName(this, "bUseNormalizedRootMotionScale"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseNormalizedRootMotionScale", value); }
        }
        public bool bRootMotionSettingsCopiedFromMontage {
            get {return Main.GetGetBoolPropertyByName(this, "bRootMotionSettingsCopiedFromMontage"); }
            set {Main.SetGetBoolPropertyByName(this, "bRootMotionSettingsCopiedFromMontage", value); }
        }
        ///<summary>Saved version number with CompressAnimations commandlet. To help with doing it in multiple passes.</summary>
        public unsafe int CompressCommandletVersion {
            get {return AnimSequence_ptr->CompressCommandletVersion;}
            set {AnimSequence_ptr->CompressCommandletVersion = value;}
        }
        public bool bDoNotOverrideCompression {
            get {return Main.GetGetBoolPropertyByName(this, "bDoNotOverrideCompression"); }
            set {Main.SetGetBoolPropertyByName(this, "bDoNotOverrideCompression", value); }
        }
        public bool bWasCompressedWithoutTranslations {
            get {return Main.GetGetBoolPropertyByName(this, "bWasCompressedWithoutTranslations"); }
            set {Main.SetGetBoolPropertyByName(this, "bWasCompressedWithoutTranslations", value); }
        }
        ///<summary>Importing data and options used for this mesh</summary>
        public unsafe AssetImportData AssetImportData {
            get {return AnimSequence_ptr->AssetImportData;}
            set {AnimSequence_ptr->AssetImportData = value;}
        }
        public bool bNeedsRebake {
            get {return Main.GetGetBoolPropertyByName(this, "bNeedsRebake"); }
            set {Main.SetGetBoolPropertyByName(this, "bNeedsRebake", value); }
        }
         //TODO: array not UObject TArray AuthoredSyncMarkers
        static AnimSequence() {
            StaticClass = Main.GetClass("AnimSequence");
        }
        internal unsafe AnimSequence_fields* AnimSequence_ptr => (AnimSequence_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimSequence(IntPtr p) => UObject.Make<AnimSequence>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimSequence DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimSequence New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
