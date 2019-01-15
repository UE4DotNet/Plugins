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
    ///<summary>Subsurface Scattering profile asset, can be specified at the material.</summary>
    ///<remarks>
    ///Only for "Subsurface Profile" materials, is use during Screenspace Subsurface Scattering
    ///Don't change at runtime. All properties in here are per material - texture like variations need to come from properties that are in the GBuffer.
    ///</remarks>
    public unsafe partial class SubsurfaceProfile : UObject  {
        ///<summary>Settings</summary>
        public unsafe SubsurfaceProfileStruct Settings {
            get {return SubsurfaceProfile_ptr->Settings;}
            set {SubsurfaceProfile_ptr->Settings = value;}
        }
        static SubsurfaceProfile() {
            StaticClass = Main.GetClass("SubsurfaceProfile");
        }
        internal unsafe SubsurfaceProfile_fields* SubsurfaceProfile_ptr => (SubsurfaceProfile_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SubsurfaceProfile(IntPtr p) => UObject.Make<SubsurfaceProfile>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SubsurfaceProfile DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SubsurfaceProfile New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
