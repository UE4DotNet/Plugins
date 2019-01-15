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
    ///<summary>Anim Montage Factory</summary>
    public unsafe partial class AnimMontageFactory : Factory  {
        ///<summary>Target Skeleton</summary>
        public unsafe Skeleton TargetSkeleton {
            get {return AnimMontageFactory_ptr->TargetSkeleton;}
            set {AnimMontageFactory_ptr->TargetSkeleton = value;}
        }
        ///<summary>Used when creating a montage from an AnimSequence, becomes the only AnimSequence contained</summary>
        public unsafe AnimSequence SourceAnimation {
            get {return AnimMontageFactory_ptr->SourceAnimation;}
            set {AnimMontageFactory_ptr->SourceAnimation = value;}
        }
        ///<summary>The preview mesh to use with this animation</summary>
        public unsafe SkeletalMesh PreviewSkeletalMesh {
            get {return AnimMontageFactory_ptr->PreviewSkeletalMesh;}
            set {AnimMontageFactory_ptr->PreviewSkeletalMesh = value;}
        }
        static AnimMontageFactory() {
            StaticClass = Main.GetClass("AnimMontageFactory");
        }
        internal unsafe AnimMontageFactory_fields* AnimMontageFactory_ptr => (AnimMontageFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimMontageFactory(IntPtr p) => UObject.Make<AnimMontageFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimMontageFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimMontageFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
