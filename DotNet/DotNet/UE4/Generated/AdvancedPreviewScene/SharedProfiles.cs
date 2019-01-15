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
using UE4.AdvancedPreviewScene.Native;

namespace UE4.AdvancedPreviewScene {
    ///<summary>Shared Profiles</summary>
    public unsafe partial class SharedProfiles : UObject  {
         //TODO: array not UObject TArray Profiles
        static SharedProfiles() {
            StaticClass = Main.GetClass("SharedProfiles");
        }
        internal unsafe SharedProfiles_fields* SharedProfiles_ptr => (SharedProfiles_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SharedProfiles(IntPtr p) => UObject.Make<SharedProfiles>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SharedProfiles DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SharedProfiles New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
