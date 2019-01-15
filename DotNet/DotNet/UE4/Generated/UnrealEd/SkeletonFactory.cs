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
    ///<summary>Skeleton Factory</summary>
    public unsafe partial class SkeletonFactory : Factory  {
        ///<summary>The skeletal mesh with which to initialize this skeleton.</summary>
        public unsafe SkeletalMesh TargetSkeletalMesh {
            get {return SkeletonFactory_ptr->TargetSkeletalMesh;}
            set {SkeletonFactory_ptr->TargetSkeletalMesh = value;}
        }
        static SkeletonFactory() {
            StaticClass = Main.GetClass("SkeletonFactory");
        }
        internal unsafe SkeletonFactory_fields* SkeletonFactory_ptr => (SkeletonFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkeletonFactory(IntPtr p) => UObject.Make<SkeletonFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkeletonFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkeletonFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
