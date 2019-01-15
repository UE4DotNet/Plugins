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
using UE4.DotNetTest.Native;
using UE4.Engine;

namespace UE4.DotNetTest {
    ///<summary>Dot Net Test Projectile</summary>
    public unsafe partial class DotNetTestProjectile : Actor  {
        ///<summary>Sphere collision component</summary>
        public unsafe SphereComponent CollisionComp {
            get {return DotNetTestProjectile_ptr->CollisionComp;}
            set {DotNetTestProjectile_ptr->CollisionComp = value;}
        }
        ///<summary>Projectile movement component</summary>
        public unsafe ProjectileMovementComponent ProjectileMovement {
            get {return DotNetTestProjectile_ptr->ProjectileMovement;}
        }
        static DotNetTestProjectile() {
            StaticClass = Main.GetClass("DotNetTestProjectile");
        }
        internal unsafe DotNetTestProjectile_fields* DotNetTestProjectile_ptr => (DotNetTestProjectile_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DotNetTestProjectile(IntPtr p) => UObject.Make<DotNetTestProjectile>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DotNetTestProjectile DefaultObject => Main.GetDefaultObject(StaticClass);
    }
}
