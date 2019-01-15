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
    ///A DamageType is intended to define and describe a particular form of damage and to provide an avenue
    ///for customizing responses to damage from various sources.
    ///</summary>
    ///<remarks>
    ///For example, a game could make a DamageType_Fire set it up to ignite the damaged actor.
    ///
    ///DamageTypes are never instanced and should be treated as immutable data holders with static code
    ///functionality.  They should never be stateful.
    ///</remarks>
    public unsafe partial class DamageType : UObject  {
        public bool bCausedByWorld {
            get {return Main.GetGetBoolPropertyByName(this, "bCausedByWorld"); }
        }
        public bool bScaleMomentumByMass {
            get {return Main.GetGetBoolPropertyByName(this, "bScaleMomentumByMass"); }
        }
        public bool bRadialDamageVelChange {
            get {return Main.GetGetBoolPropertyByName(this, "bRadialDamageVelChange"); }
        }
        ///<summary>The magnitude of impulse to apply to the Actors damaged by this type.</summary>
        public unsafe float DamageImpulse {
            get {return DamageType_ptr->DamageImpulse;}
        }
        ///<summary>How large the impulse should be applied to destructible meshes</summary>
        public unsafe float DestructibleImpulse {
            get {return DamageType_ptr->DestructibleImpulse;}
        }
        ///<summary>How much the damage spreads on a destructible mesh</summary>
        public unsafe float DestructibleDamageSpreadScale {
            get {return DamageType_ptr->DestructibleDamageSpreadScale;}
        }
        ///<summary>Damage fall-off for radius damage (exponent).  Default 1.0=linear, 2.0=square of distance, etc.</summary>
        public unsafe float DamageFalloff {
            get {return DamageType_ptr->DamageFalloff;}
        }
        static DamageType() {
            StaticClass = Main.GetClass("DamageType");
        }
        internal unsafe DamageType_fields* DamageType_ptr => (DamageType_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DamageType(IntPtr p) => UObject.Make<DamageType>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DamageType DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DamageType New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
