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
    ///<summary>Blend Space Factory 1D</summary>
    public unsafe partial class BlendSpaceFactory1D : Factory  {
        ///<summary>Target Skeleton</summary>
        public unsafe Skeleton TargetSkeleton {
            get {return BlendSpaceFactory1D_ptr->TargetSkeleton;}
            set {BlendSpaceFactory1D_ptr->TargetSkeleton = value;}
        }
        ///<summary>The preview mesh to use with this animation</summary>
        public unsafe SkeletalMesh PreviewSkeletalMesh {
            get {return BlendSpaceFactory1D_ptr->PreviewSkeletalMesh;}
            set {BlendSpaceFactory1D_ptr->PreviewSkeletalMesh = value;}
        }
        static BlendSpaceFactory1D() {
            StaticClass = Main.GetClass("BlendSpaceFactory1D");
        }
        internal unsafe BlendSpaceFactory1D_fields* BlendSpaceFactory1D_ptr => (BlendSpaceFactory1D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlendSpaceFactory1D(IntPtr p) => UObject.Make<BlendSpaceFactory1D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlendSpaceFactory1D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlendSpaceFactory1D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
