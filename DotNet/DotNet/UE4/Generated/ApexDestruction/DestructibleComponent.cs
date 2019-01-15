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
using UE4.ApexDestruction.Native;
using UE4.Engine;

namespace UE4.ApexDestruction {
    ///<summary>This component holds the physics data for a DestructibleActor.</summary>
    ///<remarks>The USkeletalMesh pointer in the base class (SkinnedMeshComponent) MUST be a DestructibleMesh</remarks>
    public unsafe partial class DestructibleComponent : SkinnedMeshComponent  {

        ///<summary>Take damage</summary>
        public void ApplyDamage(float DamageAmount, Vector HitLocation, Vector ImpulseDir, float ImpulseStrength)  => 
            DestructibleComponent_methods.ApplyDamage_method.Invoke(ObjPointer, DamageAmount, HitLocation, ImpulseDir, ImpulseStrength);

            // float DamageAmount CPF_Parm, CPF_ZeroConstructor, CPF_IsPlainOldData, CPF_NoDestructor, CPF_HasGetValueTypeHash, CPF_NativeAccessSpecifierPublic
            // FVector HitLocation CPF_ConstParm, CPF_Parm, CPF_OutParm, CPF_ReferenceParm, CPF_IsPlainOldData, CPF_NoDestructor, CPF_HasGetValueTypeHash, CPF_NativeAccessSpecifierPublic
            // FVector ImpulseDir CPF_ConstParm, CPF_Parm, CPF_OutParm, CPF_ReferenceParm, CPF_IsPlainOldData, CPF_NoDestructor, CPF_HasGetValueTypeHash, CPF_NativeAccessSpecifierPublic
            // float ImpulseStrength CPF_Parm, CPF_ZeroConstructor, CPF_IsPlainOldData, CPF_NoDestructor, CPF_HasGetValueTypeHash, CPF_NativeAccessSpecifierPublic


        ///<summary>Take radius damage</summary>
        public void ApplyRadiusDamage(float BaseDamage, Vector HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage)  => 
            DestructibleComponent_methods.ApplyRadiusDamage_method.Invoke(ObjPointer, BaseDamage, HurtOrigin, DamageRadius, ImpulseStrength, bFullDamage);

            // float BaseDamage CPF_Parm, CPF_ZeroConstructor, CPF_IsPlainOldData, CPF_NoDestructor, CPF_HasGetValueTypeHash, CPF_NativeAccessSpecifierPublic
            // FVector HurtOrigin CPF_ConstParm, CPF_Parm, CPF_OutParm, CPF_ReferenceParm, CPF_IsPlainOldData, CPF_NoDestructor, CPF_HasGetValueTypeHash, CPF_NativeAccessSpecifierPublic
            // float DamageRadius CPF_Parm, CPF_ZeroConstructor, CPF_IsPlainOldData, CPF_NoDestructor, CPF_HasGetValueTypeHash, CPF_NativeAccessSpecifierPublic
            // float ImpulseStrength CPF_Parm, CPF_ZeroConstructor, CPF_IsPlainOldData, CPF_NoDestructor, CPF_HasGetValueTypeHash, CPF_NativeAccessSpecifierPublic
            // bool bFullDamage CPF_Parm, CPF_ZeroConstructor, CPF_IsPlainOldData, CPF_NoDestructor, CPF_HasGetValueTypeHash, CPF_NativeAccessSpecifierPublic


        ///<summary>Get Destructible Mesh</summary>
        public DestructibleMesh GetDestructibleMesh()  => 
            DestructibleComponent_methods.GetDestructibleMesh_method.Invoke(ObjPointer);

            // UDestructibleMesh* ReturnValue CPF_Parm, CPF_OutParm, CPF_ZeroConstructor, CPF_ReturnParm, CPF_IsPlainOldData, CPF_NoDestructor, CPF_HasGetValueTypeHash, CPF_NativeAccessSpecifierPublic


        ///<summary>Set Destructible Mesh</summary>
        public void SetDestructibleMesh(DestructibleMesh NewMesh)  => 
            DestructibleComponent_methods.SetDestructibleMesh_method.Invoke(ObjPointer, NewMesh);

            // UDestructibleMesh* NewMesh CPF_Parm, CPF_ZeroConstructor, CPF_IsPlainOldData, CPF_NoDestructor, CPF_HasGetValueTypeHash, CPF_NativeAccessSpecifierPublic

        public bool bFractureEffectOverride {
            get {return Main.GetGetBoolPropertyByName(this, "bFractureEffectOverride"); }
            set {Main.SetGetBoolPropertyByName(this, "bFractureEffectOverride", value); }
        }
         //TODO: array TArray FractureEffects
        public bool bEnableHardSleeping {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableHardSleeping"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableHardSleeping", value); }
        }
        ///<summary>The minimum size required to treat chunks as Large.</summary>
        public unsafe float LargeChunkThreshold {
            get {return DestructibleComponent_ptr->LargeChunkThreshold;}
            set {DestructibleComponent_ptr->LargeChunkThreshold = value;}
        }
        ///<summary>Provide a blueprint interface for setting the destructible mesh</summary>
        public unsafe DestructibleMesh DestructibleMesh {
            get {return DestructibleComponent_ptr->DestructibleMesh;}
            set {DestructibleComponent_ptr->DestructibleMesh = value;}
        }
         //TODO: multicast delegate FComponentFractureSignature OnComponentFracture
        static DestructibleComponent() {
            StaticClass = Main.GetClass("DestructibleComponent");
        }
        internal unsafe DestructibleComponent_fields* DestructibleComponent_ptr => (DestructibleComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DestructibleComponent(IntPtr p) => UObject.Make<DestructibleComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DestructibleComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DestructibleComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
