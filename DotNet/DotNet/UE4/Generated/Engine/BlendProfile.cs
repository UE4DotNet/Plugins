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
    ///<summary>
    ///A blend profile is a set of per-bone scales that can be used in transitions and blend lists
    ///to tweak the weights of specific bones.
    ///</summary>
    ///<remarks>The scales are applied to the normal weight for that bone</remarks>
    public unsafe partial class BlendProfile : UObject  {
        ///<summary>The skeleton that owns this profile</summary>
        public unsafe Skeleton OwningSkeleton {
            get {return BlendProfile_ptr->OwningSkeleton;}
            set {BlendProfile_ptr->OwningSkeleton = value;}
        }
         //TODO: array not UObject TArray ProfileEntries
        static BlendProfile() {
            StaticClass = Main.GetClass("BlendProfile");
        }
        internal unsafe BlendProfile_fields* BlendProfile_ptr => (BlendProfile_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlendProfile(IntPtr p) => UObject.Make<BlendProfile>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlendProfile DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlendProfile New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
