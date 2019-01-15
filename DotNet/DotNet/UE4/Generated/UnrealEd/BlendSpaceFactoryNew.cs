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
    ///<summary>Blend Space Factory New</summary>
    public unsafe partial class BlendSpaceFactoryNew : Factory  {
        ///<summary>Target Skeleton</summary>
        public unsafe Skeleton TargetSkeleton {
            get {return BlendSpaceFactoryNew_ptr->TargetSkeleton;}
            set {BlendSpaceFactoryNew_ptr->TargetSkeleton = value;}
        }
        ///<summary>The preview mesh to use with this animation</summary>
        public unsafe SkeletalMesh PreviewSkeletalMesh {
            get {return BlendSpaceFactoryNew_ptr->PreviewSkeletalMesh;}
            set {BlendSpaceFactoryNew_ptr->PreviewSkeletalMesh = value;}
        }
        static BlendSpaceFactoryNew() {
            StaticClass = Main.GetClass("BlendSpaceFactoryNew");
        }
        internal unsafe BlendSpaceFactoryNew_fields* BlendSpaceFactoryNew_ptr => (BlendSpaceFactoryNew_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlendSpaceFactoryNew(IntPtr p) => UObject.Make<BlendSpaceFactoryNew>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlendSpaceFactoryNew DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlendSpaceFactoryNew New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
