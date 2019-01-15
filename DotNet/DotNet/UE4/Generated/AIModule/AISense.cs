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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>AISense</summary>
    public unsafe partial class AISense : UObject  {
        ///<summary>age past which stimulus of this sense are "forgotten"</summary>
        public unsafe float DefaultExpirationAge {
            get {return AISense_ptr->DefaultExpirationAge;}
        }
         //TODO: enum EAISenseNotifyType NotifyType
        public bool bWantsNewPawnNotification {
            get {return Main.GetGetBoolPropertyByName(this, "bWantsNewPawnNotification"); }
        }
        public bool bAutoRegisterAllPawnsAsSources {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoRegisterAllPawnsAsSources"); }
        }
        ///<summary>Perception System Instance</summary>
        public unsafe AIPerceptionSystem PerceptionSystemInstance {
            get {return AISense_ptr->PerceptionSystemInstance;}
            set {AISense_ptr->PerceptionSystemInstance = value;}
        }
        static AISense() {
            StaticClass = Main.GetClass("AISense");
        }
        internal unsafe AISense_fields* AISense_ptr => (AISense_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISense(IntPtr p) => UObject.Make<AISense>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISense DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISense New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
