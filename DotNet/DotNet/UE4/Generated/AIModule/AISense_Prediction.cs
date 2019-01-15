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
    ///<summary>AISense Prediction</summary>
    public unsafe partial class AISense_Prediction : AISense  {

        ///<summary>Asks perception system to supply Requestor with PredictedActor's predicted location in PredictionTime seconds</summary>
        ///<remarks>Location is being predicted based on PredicterActor's current location and velocity</remarks>
        public static void RequestControllerPredictionEvent(AIController Requestor, Actor PredictedActor, float PredictionTime)  => 
            AISense_Prediction_methods.RequestControllerPredictionEvent_method.Invoke(Requestor, PredictedActor, PredictionTime);

        ///<summary>Asks perception system to supply Requestor with PredictedActor's predicted location in PredictionTime seconds</summary>
        ///<remarks>Location is being predicted based on PredicterActor's current location and velocity</remarks>
        public static void RequestPawnPredictionEvent(Pawn Requestor, Actor PredictedActor, float PredictionTime)  => 
            AISense_Prediction_methods.RequestPawnPredictionEvent_method.Invoke(Requestor, PredictedActor, PredictionTime);
         //TODO: array not UObject TArray RegisteredEvents
        static AISense_Prediction() {
            StaticClass = Main.GetClass("AISense_Prediction");
        }
        internal unsafe AISense_Prediction_fields* AISense_Prediction_ptr => (AISense_Prediction_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISense_Prediction(IntPtr p) => UObject.Make<AISense_Prediction>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISense_Prediction DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISense_Prediction New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
