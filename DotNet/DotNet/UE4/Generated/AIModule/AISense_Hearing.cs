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
    ///<summary>AISense Hearing</summary>
    public unsafe partial class AISense_Hearing : AISense  {

        ///<summary>Report a noise event.</summary>
        ///<remarks>
        ///@param NoiseLocation Location of the noise.
        ///@param Loudness Loudness of the noise. If MaxRange is non-zero, modifies MaxRange, otherwise modifies the squared distance of the sensor's range.
        ///@param Instigator Actor that triggered the noise.
        ///@param MaxRange Max range at which the sound can be heard, multiplied by Loudness. Values <= 0 mean no limit (still limited by listener's range however).
        ///@param Tag Identifier for the event.
        ///</remarks>
        public static void ReportNoiseEvent(UObject WorldContextObject, Vector NoiseLocation, float Loudness, Actor Instigator, float MaxRange, Name Tag)  => 
            AISense_Hearing_methods.ReportNoiseEvent_method.Invoke(WorldContextObject, NoiseLocation, Loudness, Instigator, MaxRange, Tag);
         //TODO: array not UObject TArray NoiseEvents
        ///<summary>Defaults to 0 to have instant notification.</summary>
        ///<remarks>
        ///Setting to > 0 will result in delaying
        ///    when AI hears the sound based on the distance from the source
        ///</remarks>
        public unsafe float SpeedOfSoundSq {
            get {return AISense_Hearing_ptr->SpeedOfSoundSq;}
            set {AISense_Hearing_ptr->SpeedOfSoundSq = value;}
        }
        static AISense_Hearing() {
            StaticClass = Main.GetClass("AISense_Hearing");
        }
        internal unsafe AISense_Hearing_fields* AISense_Hearing_ptr => (AISense_Hearing_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISense_Hearing(IntPtr p) => UObject.Make<AISense_Hearing>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISense_Hearing DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISense_Hearing New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
