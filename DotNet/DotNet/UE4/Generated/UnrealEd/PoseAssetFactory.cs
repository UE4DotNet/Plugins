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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Pose Asset Factory</summary>
    public unsafe partial class PoseAssetFactory : Factory  {
        ///<summary>Target Skeleton</summary>
        public unsafe Skeleton TargetSkeleton {
            get {return PoseAssetFactory_ptr->TargetSkeleton;}
            set {PoseAssetFactory_ptr->TargetSkeleton = value;}
        }
        ///<summary>The preview mesh to use with this pose asset</summary>
        public unsafe SkeletalMesh PreviewSkeletalMesh {
            get {return PoseAssetFactory_ptr->PreviewSkeletalMesh;}
            set {PoseAssetFactory_ptr->PreviewSkeletalMesh = value;}
        }
        ///<summary>Used when creating a composite from an AnimSequence, becomes the only AnimSequence contained</summary>
        public unsafe AnimSequence SourceAnimation {
            get {return PoseAssetFactory_ptr->SourceAnimation;}
            set {PoseAssetFactory_ptr->SourceAnimation = value;}
        }
        static PoseAssetFactory() {
            StaticClass = Main.GetClass("PoseAssetFactory");
        }
        internal unsafe PoseAssetFactory_fields* PoseAssetFactory_ptr => (PoseAssetFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PoseAssetFactory(IntPtr p) => UObject.Make<PoseAssetFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PoseAssetFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PoseAssetFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
