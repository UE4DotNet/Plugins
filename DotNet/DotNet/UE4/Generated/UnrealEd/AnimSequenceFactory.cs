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
    ///<summary>Anim Sequence Factory</summary>
    public unsafe partial class AnimSequenceFactory : Factory  {
        ///<summary>Target Skeleton</summary>
        public unsafe Skeleton TargetSkeleton {
            get {return AnimSequenceFactory_ptr->TargetSkeleton;}
            set {AnimSequenceFactory_ptr->TargetSkeleton = value;}
        }
        ///<summary>The preview mesh to use with this animation</summary>
        public unsafe SkeletalMesh PreviewSkeletalMesh {
            get {return AnimSequenceFactory_ptr->PreviewSkeletalMesh;}
            set {AnimSequenceFactory_ptr->PreviewSkeletalMesh = value;}
        }
        static AnimSequenceFactory() {
            StaticClass = Main.GetClass("AnimSequenceFactory");
        }
        internal unsafe AnimSequenceFactory_fields* AnimSequenceFactory_ptr => (AnimSequenceFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimSequenceFactory(IntPtr p) => UObject.Make<AnimSequenceFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimSequenceFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimSequenceFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
