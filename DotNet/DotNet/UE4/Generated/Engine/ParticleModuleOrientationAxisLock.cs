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
    ///<summary>Particle Module Orientation Axis Lock</summary>
    public unsafe partial class ParticleModuleOrientationAxisLock : ParticleModuleOrientationBase  {
        ///<summary>The lock axis flag setting.</summary>
        ///<remarks>
        ///Can be one of the following:
        ///        EPAL_NONE                       No locking to an axis.
        ///        EPAL_X                          Lock the sprite facing towards +X.
        ///        EPAL_Y                          Lock the sprite facing towards +Y.
        ///        EPAL_Z                          Lock the sprite facing towards +Z.
        ///        EPAL_NEGATIVE_X         Lock the sprite facing towards -X.
        ///        EPAL_NEGATIVE_Y         Lock the sprite facing towards -Y.
        ///        EPAL_NEGATIVE_Z         Lock the sprite facing towards -Z.
        ///        EPAL_ROTATE_X           Lock the sprite rotation on the X-axis.
        ///        EPAL_ROTATE_Y           Lock the sprite rotation on the Y-axis.
        ///        EPAL_ROTATE_Z           Lock the sprite rotation on the Z-axis.
        ///</remarks>
        public unsafe byte LockAxisFlags {
            get {return ParticleModuleOrientationAxisLock_ptr->LockAxisFlags;}
            set {ParticleModuleOrientationAxisLock_ptr->LockAxisFlags = value;}
        }
        static ParticleModuleOrientationAxisLock() {
            StaticClass = Main.GetClass("ParticleModuleOrientationAxisLock");
        }
        internal unsafe ParticleModuleOrientationAxisLock_fields* ParticleModuleOrientationAxisLock_ptr => (ParticleModuleOrientationAxisLock_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleOrientationAxisLock(IntPtr p) => UObject.Make<ParticleModuleOrientationAxisLock>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleOrientationAxisLock DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleOrientationAxisLock New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
