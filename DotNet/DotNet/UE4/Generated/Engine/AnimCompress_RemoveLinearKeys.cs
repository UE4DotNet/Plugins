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
    ///<summary>Anim Compress Remove Linear Keys</summary>
    public unsafe partial class AnimCompress_RemoveLinearKeys : AnimCompress  {
        ///<summary>Maximum position difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
        public unsafe float MaxPosDiff {
            get {return AnimCompress_RemoveLinearKeys_ptr->MaxPosDiff;}
            set {AnimCompress_RemoveLinearKeys_ptr->MaxPosDiff = value;}
        }
        ///<summary>Maximum angle difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
        public unsafe float MaxAngleDiff {
            get {return AnimCompress_RemoveLinearKeys_ptr->MaxAngleDiff;}
            set {AnimCompress_RemoveLinearKeys_ptr->MaxAngleDiff = value;}
        }
        ///<summary>Maximum Scale difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
        public unsafe float MaxScaleDiff {
            get {return AnimCompress_RemoveLinearKeys_ptr->MaxScaleDiff;}
            set {AnimCompress_RemoveLinearKeys_ptr->MaxScaleDiff = value;}
        }
        ///<summary>As keys are tested for removal, we monitor the effects all the way down to the end effectors.</summary>
        ///<remarks>
        ///If their position changes by more than this amount as a result of removing a key, the key will be retained.
        ///This value is used for all bones except the end-effectors parent.
        ///</remarks>
        public unsafe float MaxEffectorDiff {
            get {return AnimCompress_RemoveLinearKeys_ptr->MaxEffectorDiff;}
            set {AnimCompress_RemoveLinearKeys_ptr->MaxEffectorDiff = value;}
        }
        ///<summary>As keys are tested for removal, we monitor the effects all the way down to the end effectors.</summary>
        ///<remarks>
        ///If their position changes by more than this amount as a result of removing a key, the key will be retained.
        ///This value is used for the end-effectors parent, allowing tighter restrictions near the end of a skeletal chain.
        ///</remarks>
        public unsafe float MinEffectorDiff {
            get {return AnimCompress_RemoveLinearKeys_ptr->MinEffectorDiff;}
            set {AnimCompress_RemoveLinearKeys_ptr->MinEffectorDiff = value;}
        }
        ///<summary>Error threshold for End Effectors with Sockets attached to them.</summary>
        ///<remarks>Typically more important bone, where we want to be less aggressive with compression.</remarks>
        public unsafe float EffectorDiffSocket {
            get {return AnimCompress_RemoveLinearKeys_ptr->EffectorDiffSocket;}
            set {AnimCompress_RemoveLinearKeys_ptr->EffectorDiffSocket = value;}
        }
        ///<summary>A scale value which increases the likelihood that a bone will retain a key if it's parent also had a key at the same time position.</summary>
        ///<remarks>Higher values can remove shaking artifacts from the animation, at the cost of compression.</remarks>
        public unsafe float ParentKeyScale {
            get {return AnimCompress_RemoveLinearKeys_ptr->ParentKeyScale;}
            set {AnimCompress_RemoveLinearKeys_ptr->ParentKeyScale = value;}
        }
        public bool bRetarget {
            get {return Main.GetGetBoolPropertyByName(this, "bRetarget"); }
            set {Main.SetGetBoolPropertyByName(this, "bRetarget", value); }
        }
        public bool bActuallyFilterLinearKeys {
            get {return Main.GetGetBoolPropertyByName(this, "bActuallyFilterLinearKeys"); }
            set {Main.SetGetBoolPropertyByName(this, "bActuallyFilterLinearKeys", value); }
        }
        public bool bOptimizeForForwardPlayback {
            get {return Main.GetGetBoolPropertyByName(this, "bOptimizeForForwardPlayback"); }
            set {Main.SetGetBoolPropertyByName(this, "bOptimizeForForwardPlayback", value); }
        }
        public bool bUseDecompression {
            get {return Main.GetGetBoolPropertyByName(this, "bUseDecompression"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseDecompression", value); }
        }
        public bool bUseMultithreading {
            get {return Main.GetGetBoolPropertyByName(this, "bUseMultithreading"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseMultithreading", value); }
        }
        static AnimCompress_RemoveLinearKeys() {
            StaticClass = Main.GetClass("AnimCompress_RemoveLinearKeys");
        }
        internal unsafe AnimCompress_RemoveLinearKeys_fields* AnimCompress_RemoveLinearKeys_ptr => (AnimCompress_RemoveLinearKeys_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimCompress_RemoveLinearKeys(IntPtr p) => UObject.Make<AnimCompress_RemoveLinearKeys>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimCompress_RemoveLinearKeys DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimCompress_RemoveLinearKeys New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
