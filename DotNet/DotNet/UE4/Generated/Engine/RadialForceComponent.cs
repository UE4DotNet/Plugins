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
    ///<summary>Used to emit a radial force or impulse that can affect physics objects and or destructible objects.</summary>
    public unsafe partial class RadialForceComponent : SceneComponent  {

        ///<summary>Add an object type for this radial force to affect</summary>
        public void AddObjectTypeToAffect(byte ObjectType)  => 
            RadialForceComponent_methods.AddObjectTypeToAffect_method.Invoke(ObjPointer, ObjectType);

        ///<summary>Fire a single impulse</summary>
        public void FireImpulse()  => 
            RadialForceComponent_methods.FireImpulse_method.Invoke(ObjPointer);

        ///<summary>Remove an object type that is affected by this radial force</summary>
        public void RemoveObjectTypeToAffect(byte ObjectType)  => 
            RadialForceComponent_methods.RemoveObjectTypeToAffect_method.Invoke(ObjPointer, ObjectType);
        ///<summary>The radius to apply the force or impulse in</summary>
        public unsafe float Radius {
            get {return RadialForceComponent_ptr->Radius;}
            set {RadialForceComponent_ptr->Radius = value;}
        }
        ///<summary>How the force or impulse should fall off as object are further away from the center</summary>
        public unsafe byte Falloff {
            get {return RadialForceComponent_ptr->Falloff;}
            set {RadialForceComponent_ptr->Falloff = value;}
        }
        ///<summary>How strong the impulse should be</summary>
        public unsafe float ImpulseStrength {
            get {return RadialForceComponent_ptr->ImpulseStrength;}
            set {RadialForceComponent_ptr->ImpulseStrength = value;}
        }
        public bool bImpulseVelChange {
            get {return Main.GetGetBoolPropertyByName(this, "bImpulseVelChange"); }
            set {Main.SetGetBoolPropertyByName(this, "bImpulseVelChange", value); }
        }
        public bool bIgnoreOwningActor {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreOwningActor"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreOwningActor", value); }
        }
        ///<summary>How strong the force should be</summary>
        public unsafe float ForceStrength {
            get {return RadialForceComponent_ptr->ForceStrength;}
            set {RadialForceComponent_ptr->ForceStrength = value;}
        }
        ///<summary>If > 0.f, will cause damage to destructible meshes as well</summary>
        public unsafe float DestructibleDamage {
            get {return RadialForceComponent_ptr->DestructibleDamage;}
            set {RadialForceComponent_ptr->DestructibleDamage = value;}
        }
         //TODO: array not UObject TArray ObjectTypesToAffect
        static RadialForceComponent() {
            StaticClass = Main.GetClass("RadialForceComponent");
        }
        internal unsafe RadialForceComponent_fields* RadialForceComponent_ptr => (RadialForceComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RadialForceComponent(IntPtr p) => UObject.Make<RadialForceComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RadialForceComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RadialForceComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
