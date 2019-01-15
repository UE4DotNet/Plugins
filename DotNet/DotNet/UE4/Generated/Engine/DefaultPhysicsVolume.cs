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
    ///DefaultPhysicsVolume determines the physical effects an actor will experience if they are not inside any user specified PhysicsVolume
    ///@
    ///</summary>
    ///<remarks>see APhysicsVolume</remarks>
    public unsafe partial class DefaultPhysicsVolume : PhysicsVolume  {
        static DefaultPhysicsVolume() {
            StaticClass = Main.GetClass("DefaultPhysicsVolume");
        }
        internal unsafe DefaultPhysicsVolume_fields* DefaultPhysicsVolume_ptr => (DefaultPhysicsVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DefaultPhysicsVolume(IntPtr p) => UObject.Make<DefaultPhysicsVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DefaultPhysicsVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DefaultPhysicsVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
