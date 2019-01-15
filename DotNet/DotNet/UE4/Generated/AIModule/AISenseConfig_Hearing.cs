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
    ///<summary>AISense Config Hearing</summary>
    public unsafe partial class AISenseConfig_Hearing : AISenseConfig  {
        ///<summary>Implementation</summary>
        public unsafe SubclassOf<AISense_Hearing> Implementation {
            get {return AISenseConfig_Hearing_ptr->Implementation;}
        }
        ///<summary>Hearing Range</summary>
        public unsafe float HearingRange {
            get {return AISenseConfig_Hearing_ptr->HearingRange;}
        }
        ///<summary>Lo SHearing Range</summary>
        public unsafe float LoSHearingRange {
            get {return AISenseConfig_Hearing_ptr->LoSHearingRange;}
        }
        public bool bUseLoSHearing {
            get {return Main.GetGetBoolPropertyByName(this, "bUseLoSHearing"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseLoSHearing", value); }
        }
        ///<summary>Detection by Affiliation</summary>
        public unsafe AISenseAffiliationFilter DetectionByAffiliation {
            get {return AISenseConfig_Hearing_ptr->DetectionByAffiliation;}
        }
        static AISenseConfig_Hearing() {
            StaticClass = Main.GetClass("AISenseConfig_Hearing");
        }
        internal unsafe AISenseConfig_Hearing_fields* AISenseConfig_Hearing_ptr => (AISenseConfig_Hearing_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISenseConfig_Hearing(IntPtr p) => UObject.Make<AISenseConfig_Hearing>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISenseConfig_Hearing DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISenseConfig_Hearing New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
