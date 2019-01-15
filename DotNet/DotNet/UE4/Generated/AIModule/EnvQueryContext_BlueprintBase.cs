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
    ///<summary>Env Query Context Blueprint Base</summary>
    public unsafe partial class EnvQueryContext_BlueprintBase : EnvQueryContext  {
        //TODO: class_event: event with array parameter ProvideActorsSet
        //TODO: class_event: event with array parameter ProvideLocationsSet

        ///<summary>Provide Single Actor</summary>
        public event ProvideSingleActor_delegate ProvideSingleActor;
        public delegate Actor ProvideSingleActor_delegate(UObject QuerierObject, Actor QuerierActor, Actor ResultingActor);
        internal Actor on_ProvideSingleActor(UObject QuerierObject, Actor QuerierActor, Actor ResultingActor) =>
            ProvideSingleActor != null ? ProvideSingleActor(QuerierObject, QuerierActor, ResultingActor) : ResultingActor;


        ///<summary>Provide Single Location</summary>
        public event ProvideSingleLocation_delegate ProvideSingleLocation;
        public delegate Vector ProvideSingleLocation_delegate(UObject QuerierObject, Actor QuerierActor, Vector ResultingLocation);
        internal Vector on_ProvideSingleLocation(UObject QuerierObject, Actor QuerierActor, Vector ResultingLocation) =>
            ProvideSingleLocation != null ? ProvideSingleLocation(QuerierObject, QuerierActor, ResultingLocation) : ResultingLocation;

        static EnvQueryContext_BlueprintBase() {
            StaticClass = Main.GetClass("EnvQueryContext_BlueprintBase");
            //TODO: call_event_setup: event with array parameter: ProvideActorsSet
            //TODO: call_event_setup: event with array parameter: ProvideLocationsSet
            EnvQueryContext_BlueprintBase_events.ProvideSingleActor_event.Setup();
            EnvQueryContext_BlueprintBase_events.ProvideSingleLocation_event.Setup();
        }
        internal unsafe EnvQueryContext_BlueprintBase_fields* EnvQueryContext_BlueprintBase_ptr => (EnvQueryContext_BlueprintBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryContext_BlueprintBase(IntPtr p) => UObject.Make<EnvQueryContext_BlueprintBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryContext_BlueprintBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryContext_BlueprintBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
