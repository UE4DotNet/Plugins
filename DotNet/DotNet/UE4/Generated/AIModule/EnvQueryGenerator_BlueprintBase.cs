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
    ///<summary>Env Query Generator Blueprint Base</summary>
    public unsafe partial class EnvQueryGenerator_BlueprintBase : EnvQueryGenerator  {
        //TODO: class_event: event with array parameter DoItemGeneration

        ///<summary>Add Generated Actor</summary>
        public void AddGeneratedActor(Actor GeneratedActor)  => 
            EnvQueryGenerator_BlueprintBase_methods.AddGeneratedActor_method.Invoke(ObjPointer, GeneratedActor);

        ///<summary>Add Generated Vector</summary>
        public void AddGeneratedVector(Vector GeneratedVector)  => 
            EnvQueryGenerator_BlueprintBase_methods.AddGeneratedVector_method.Invoke(ObjPointer, GeneratedVector);

        ///<summary>Get Querier</summary>
        public UObject GetQuerier()  => 
            EnvQueryGenerator_BlueprintBase_methods.GetQuerier_method.Invoke(ObjPointer);
         //TODO: text FText GeneratorsActionDescription
        ///<summary>context</summary>
        public unsafe SubclassOf<EnvQueryContext> Context {
            get {return EnvQueryGenerator_BlueprintBase_ptr->Context;}
            set {EnvQueryGenerator_BlueprintBase_ptr->Context = value;}
        }
        ///<summary>@</summary>
        ///<remarks>
        ///todo this should show up only in the generator's BP, but
        ///    due to the way EQS editor is generating widgets it's there as well
        ///    It's a bug and we'll fix it
        ///</remarks>
        public unsafe SubclassOf<EnvQueryItemType> GeneratedItemType {
            get {return EnvQueryGenerator_BlueprintBase_ptr->GeneratedItemType;}
            set {EnvQueryGenerator_BlueprintBase_ptr->GeneratedItemType = value;}
        }
        static EnvQueryGenerator_BlueprintBase() {
            StaticClass = Main.GetClass("EnvQueryGenerator_BlueprintBase");
            //TODO: call_event_setup: event with array parameter: DoItemGeneration
        }
        internal unsafe EnvQueryGenerator_BlueprintBase_fields* EnvQueryGenerator_BlueprintBase_ptr => (EnvQueryGenerator_BlueprintBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryGenerator_BlueprintBase(IntPtr p) => UObject.Make<EnvQueryGenerator_BlueprintBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryGenerator_BlueprintBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryGenerator_BlueprintBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
