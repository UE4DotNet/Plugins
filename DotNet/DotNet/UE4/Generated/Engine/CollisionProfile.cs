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
    ///<summary>Set up and modify collision settings.</summary>
    public unsafe partial class CollisionProfile : DeveloperSettings  {
         //TODO: array not UObject TArray Profiles
         //TODO: array not UObject TArray DefaultChannelResponses
         //TODO: array not UObject TArray EditProfiles
         //TODO: array not UObject TArray ProfileRedirects
         //TODO: array not UObject TArray CollisionChannelRedirects
        static CollisionProfile() {
            StaticClass = Main.GetClass("CollisionProfile");
        }
        internal unsafe CollisionProfile_fields* CollisionProfile_ptr => (CollisionProfile_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CollisionProfile(IntPtr p) => UObject.Make<CollisionProfile>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CollisionProfile DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CollisionProfile New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
