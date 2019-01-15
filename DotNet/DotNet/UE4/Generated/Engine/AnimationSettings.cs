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
    ///<summary>Default animation settings.</summary>
    public unsafe partial class AnimationSettings : DeveloperSettings  {
        ///<summary>compression upgrade version</summary>
        public unsafe int CompressCommandletVersion {
            get {return AnimationSettings_ptr->CompressCommandletVersion;}
            set {AnimationSettings_ptr->CompressCommandletVersion = value;}
        }
         //TODO: array not UObject TArray KeyEndEffectorsMatchNameArray
        ///<summary>Default Compression Algorithm</summary>
        public unsafe SubclassOf<AnimCompress> DefaultCompressionAlgorithm {
            get {return AnimationSettings_ptr->DefaultCompressionAlgorithm;}
            set {AnimationSettings_ptr->DefaultCompressionAlgorithm = value;}
        }
        ///<summary>Rotation Compression Format</summary>
        public unsafe byte RotationCompressionFormat {
            get {return AnimationSettings_ptr->RotationCompressionFormat;}
            set {AnimationSettings_ptr->RotationCompressionFormat = value;}
        }
        ///<summary>Translation Compression Format</summary>
        public unsafe byte TranslationCompressionFormat {
            get {return AnimationSettings_ptr->TranslationCompressionFormat;}
            set {AnimationSettings_ptr->TranslationCompressionFormat = value;}
        }
        ///<summary>Max error for compression of curves using remove redundant keys</summary>
        public unsafe float MaxCurveError {
            get {return AnimationSettings_ptr->MaxCurveError;}
            set {AnimationSettings_ptr->MaxCurveError = value;}
        }
        ///<summary>The alternate error threshold (0.</summary>
        ///<remarks>
        ///0 means don't try anything other than the current / default scheme)
        ///
        ///Determines the current setting for world-space error tolerance in the animation compressor.
        ///When requested, animation being compressed will also consider an alternative compression
        ///method if the end result of that method produces less error than the AlternativeCompressionThreshold.
        ///Also known as "Max End Effector Error"
        ///</remarks>
        public unsafe float AlternativeCompressionThreshold {
            get {return AnimationSettings_ptr->AlternativeCompressionThreshold;}
            set {AnimationSettings_ptr->AlternativeCompressionThreshold = value;}
        }
        public bool ForceRecompression {
            get {return Main.GetGetBoolPropertyByName(this, "ForceRecompression"); }
            set {Main.SetGetBoolPropertyByName(this, "ForceRecompression", value); }
        }
        public bool bOnlyCheckForMissingSkeletalMeshes {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlyCheckForMissingSkeletalMeshes"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlyCheckForMissingSkeletalMeshes", value); }
        }
        public bool bForceBelowThreshold {
            get {return Main.GetGetBoolPropertyByName(this, "bForceBelowThreshold"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceBelowThreshold", value); }
        }
        public bool bFirstRecompressUsingCurrentOrDefault {
            get {return Main.GetGetBoolPropertyByName(this, "bFirstRecompressUsingCurrentOrDefault"); }
            set {Main.SetGetBoolPropertyByName(this, "bFirstRecompressUsingCurrentOrDefault", value); }
        }
        public bool bRaiseMaxErrorToExisting {
            get {return Main.GetGetBoolPropertyByName(this, "bRaiseMaxErrorToExisting"); }
            set {Main.SetGetBoolPropertyByName(this, "bRaiseMaxErrorToExisting", value); }
        }
        public bool bTryFixedBitwiseCompression {
            get {return Main.GetGetBoolPropertyByName(this, "bTryFixedBitwiseCompression"); }
            set {Main.SetGetBoolPropertyByName(this, "bTryFixedBitwiseCompression", value); }
        }
        public bool bTryPerTrackBitwiseCompression {
            get {return Main.GetGetBoolPropertyByName(this, "bTryPerTrackBitwiseCompression"); }
            set {Main.SetGetBoolPropertyByName(this, "bTryPerTrackBitwiseCompression", value); }
        }
        public bool bTryLinearKeyRemovalCompression {
            get {return Main.GetGetBoolPropertyByName(this, "bTryLinearKeyRemovalCompression"); }
            set {Main.SetGetBoolPropertyByName(this, "bTryLinearKeyRemovalCompression", value); }
        }
        public bool bTryIntervalKeyRemoval {
            get {return Main.GetGetBoolPropertyByName(this, "bTryIntervalKeyRemoval"); }
            set {Main.SetGetBoolPropertyByName(this, "bTryIntervalKeyRemoval", value); }
        }
        public bool bEnablePerformanceLog {
            get {return Main.GetGetBoolPropertyByName(this, "bEnablePerformanceLog"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnablePerformanceLog", value); }
        }
        public bool bStripAnimationDataOnDedicatedServer {
            get {return Main.GetGetBoolPropertyByName(this, "bStripAnimationDataOnDedicatedServer"); }
            set {Main.SetGetBoolPropertyByName(this, "bStripAnimationDataOnDedicatedServer", value); }
        }
        public bool bTickAnimationOnSkeletalMeshInit {
            get {return Main.GetGetBoolPropertyByName(this, "bTickAnimationOnSkeletalMeshInit"); }
            set {Main.SetGetBoolPropertyByName(this, "bTickAnimationOnSkeletalMeshInit", value); }
        }
        static AnimationSettings() {
            StaticClass = Main.GetClass("AnimationSettings");
        }
        internal unsafe AnimationSettings_fields* AnimationSettings_ptr => (AnimationSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationSettings(IntPtr p) => UObject.Make<AnimationSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
