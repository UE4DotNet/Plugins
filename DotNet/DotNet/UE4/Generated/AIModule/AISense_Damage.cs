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
using UE4.Engine;

namespace UE4.AIModule {
    ///<summary>AISense Damage</summary>
    public unsafe partial class AISense_Damage : AISense  {

        ///<summary>EventLocation will be reported as Instigator's location at the moment of event happening</summary>
        public static void ReportDamageEvent(UObject WorldContextObject, Actor DamagedActor, Actor Instigator, float DamageAmount, Vector EventLocation, Vector HitLocation)  => 
            AISense_Damage_methods.ReportDamageEvent_method.Invoke(WorldContextObject, DamagedActor, Instigator, DamageAmount, EventLocation, HitLocation);
         //TODO: array not UObject TArray RegisteredEvents
        static AISense_Damage() {
            StaticClass = Main.GetClass("AISense_Damage");
        }
        internal unsafe AISense_Damage_fields* AISense_Damage_ptr => (AISense_Damage_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISense_Damage(IntPtr p) => UObject.Make<AISense_Damage>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISense_Damage DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISense_Damage New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
