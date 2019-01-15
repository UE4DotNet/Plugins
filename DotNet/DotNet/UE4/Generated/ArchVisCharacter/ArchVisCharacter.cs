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
using UE4.ArchVisCharacter.Native;
using UE4.Engine;

namespace UE4.ArchVisCharacter {
    ///<summary>Arch Vis Character</summary>
    public unsafe partial class ArchVisCharacter : Character  {
         //TODO: string FString LookUpAxisName
         //TODO: string FString LookUpAtRateAxisName
         //TODO: string FString TurnAxisName
         //TODO: string FString TurnAtRateAxisName
         //TODO: string FString MoveForwardAxisName
         //TODO: string FString MoveRightAxisName
        ///<summary>Controls how aggressively mouse motion translates to character rotation in the pitch axis.</summary>
        public unsafe float MouseSensitivityScale_Pitch {
            get {return ArchVisCharacter_ptr->MouseSensitivityScale_Pitch;}
        }
        ///<summary>Controls how aggressively mouse motion translates to character rotation in the yaw axis.</summary>
        public unsafe float MouseSensitivityScale_Yaw {
            get {return ArchVisCharacter_ptr->MouseSensitivityScale_Yaw;}
        }
        static ArchVisCharacter() {
            StaticClass = Main.GetClass("ArchVisCharacter");
        }
        internal unsafe ArchVisCharacter_fields* ArchVisCharacter_ptr => (ArchVisCharacter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ArchVisCharacter(IntPtr p) => UObject.Make<ArchVisCharacter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ArchVisCharacter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ArchVisCharacter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
