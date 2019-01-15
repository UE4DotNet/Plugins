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

namespace UE4.UnrealEd {
    ///<summary>Physics Asset Generation Settings</summary>
    public unsafe partial class PhysicsAssetGenerationSettings : UObject  {
        ///<summary>Create Params</summary>
        public unsafe PhysAssetCreateParams CreateParams {
            get {return PhysicsAssetGenerationSettings_ptr->CreateParams;}
            set {PhysicsAssetGenerationSettings_ptr->CreateParams = value;}
        }
        static PhysicsAssetGenerationSettings() {
            StaticClass = Main.GetClass("PhysicsAssetGenerationSettings");
        }
        internal unsafe PhysicsAssetGenerationSettings_fields* PhysicsAssetGenerationSettings_ptr => (PhysicsAssetGenerationSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsAssetGenerationSettings(IntPtr p) => UObject.Make<PhysicsAssetGenerationSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsAssetGenerationSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsAssetGenerationSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
