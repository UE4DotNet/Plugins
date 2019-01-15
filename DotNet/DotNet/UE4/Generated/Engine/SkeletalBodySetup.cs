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
    ///<summary>Skeletal Body Setup</summary>
    public unsafe partial class SkeletalBodySetup : BodySetup  {
        ///<summary>dummy place for customization inside phat. Profiles are ordered dynamically and we need a static place for detail customization</summary>
        public unsafe PhysicalAnimationProfile CurrentPhysicalAnimationProfile {
            get {return SkeletalBodySetup_ptr->CurrentPhysicalAnimationProfile;}
            set {SkeletalBodySetup_ptr->CurrentPhysicalAnimationProfile = value;}
        }
        public bool bSkipScaleFromAnimation {
            get {return Main.GetGetBoolPropertyByName(this, "bSkipScaleFromAnimation"); }
            set {Main.SetGetBoolPropertyByName(this, "bSkipScaleFromAnimation", value); }
        }
         //TODO: array not UObject TArray PhysicalAnimationData
        static SkeletalBodySetup() {
            StaticClass = Main.GetClass("SkeletalBodySetup");
        }
        internal unsafe SkeletalBodySetup_fields* SkeletalBodySetup_ptr => (SkeletalBodySetup_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkeletalBodySetup(IntPtr p) => UObject.Make<SkeletalBodySetup>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkeletalBodySetup DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkeletalBodySetup New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
