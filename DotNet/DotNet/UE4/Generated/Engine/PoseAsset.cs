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
    ///<summary>* Pose Asset that can be blended by weight of curves</summary>
    public unsafe partial class PoseAsset : AnimationAsset  {
        ///<summary>Animation Pose Data</summary>
        public unsafe PoseDataContainer PoseContainer {
            get {return PoseAsset_ptr->PoseContainer;}
            set {PoseAsset_ptr->PoseContainer = value;}
        }
        public bool bAdditivePose {
            get {return Main.GetGetBoolPropertyByName(this, "bAdditivePose"); }
            set {Main.SetGetBoolPropertyByName(this, "bAdditivePose", value); }
        }
        ///<summary>if -1, use ref pose</summary>
        public unsafe int BasePoseIndex {
            get {return PoseAsset_ptr->BasePoseIndex;}
            set {PoseAsset_ptr->BasePoseIndex = value;}
        }
        ///<summary>Base pose to use when retargeting</summary>
        public unsafe Name RetargetSource {
            get {return PoseAsset_ptr->RetargetSource;}
            set {PoseAsset_ptr->RetargetSource = value;}
        }
        ///<summary>Source Animation</summary>
        public unsafe AnimSequence SourceAnimation {
            get {return PoseAsset_ptr->SourceAnimation;}
            set {PoseAsset_ptr->SourceAnimation = value;}
        }
        static PoseAsset() {
            StaticClass = Main.GetClass("PoseAsset");
        }
        internal unsafe PoseAsset_fields* PoseAsset_ptr => (PoseAsset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PoseAsset(IntPtr p) => UObject.Make<PoseAsset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PoseAsset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PoseAsset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
