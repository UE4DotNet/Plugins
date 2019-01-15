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
    ///<summary>Anim Compress Automatic</summary>
    public unsafe partial class AnimCompress_Automatic : AnimCompress  {
        ///<summary>
        ///Maximum amount of error that a compression technique can introduce in an end effector
        ///Determines the current setting for world - space error tolerance in the animation compressor.
        ///</summary>
        ///<remarks>
        ///When requested, animation being compressed will also consider an alternative compression
        ///method if the end result of that method produces less error than the AlternativeCompressionThreshold.
        ///Also known as "Alternative Compression Threshold"
        ///</remarks>
        public unsafe float MaxEndEffectorError {
            get {return AnimCompress_Automatic_ptr->MaxEndEffectorError;}
            set {AnimCompress_Automatic_ptr->MaxEndEffectorError = value;}
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
        public bool bRunCurrentDefaultCompressor {
            get {return Main.GetGetBoolPropertyByName(this, "bRunCurrentDefaultCompressor"); }
            set {Main.SetGetBoolPropertyByName(this, "bRunCurrentDefaultCompressor", value); }
        }
        public bool bAutoReplaceIfExistingErrorTooGreat {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoReplaceIfExistingErrorTooGreat"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoReplaceIfExistingErrorTooGreat", value); }
        }
        public bool bRaiseMaxErrorToExisting {
            get {return Main.GetGetBoolPropertyByName(this, "bRaiseMaxErrorToExisting"); }
            set {Main.SetGetBoolPropertyByName(this, "bRaiseMaxErrorToExisting", value); }
        }
        static AnimCompress_Automatic() {
            StaticClass = Main.GetClass("AnimCompress_Automatic");
        }
        internal unsafe AnimCompress_Automatic_fields* AnimCompress_Automatic_ptr => (AnimCompress_Automatic_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimCompress_Automatic(IntPtr p) => UObject.Make<AnimCompress_Automatic>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimCompress_Automatic DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimCompress_Automatic New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
