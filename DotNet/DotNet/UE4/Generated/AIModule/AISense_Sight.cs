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
    ///<summary>AISense Sight</summary>
    public unsafe partial class AISense_Sight : AISense  {
        ///<summary>Max Traces Per Tick</summary>
        public unsafe int MaxTracesPerTick {
            get {return AISense_Sight_ptr->MaxTracesPerTick;}
            set {AISense_Sight_ptr->MaxTracesPerTick = value;}
        }
        ///<summary>Min Queries Per Time Slice Check</summary>
        public unsafe int MinQueriesPerTimeSliceCheck {
            get {return AISense_Sight_ptr->MinQueriesPerTimeSliceCheck;}
            set {AISense_Sight_ptr->MinQueriesPerTimeSliceCheck = value;}
        }
        ///<summary>Max Time Slice Per Tick</summary>
        public unsafe double MaxTimeSlicePerTick {
            get {return AISense_Sight_ptr->MaxTimeSlicePerTick;}
            set {AISense_Sight_ptr->MaxTimeSlicePerTick = value;}
        }
        ///<summary>High Importance Query Distance Threshold</summary>
        public unsafe float HighImportanceQueryDistanceThreshold {
            get {return AISense_Sight_ptr->HighImportanceQueryDistanceThreshold;}
            set {AISense_Sight_ptr->HighImportanceQueryDistanceThreshold = value;}
        }
        ///<summary>Max Query Importance</summary>
        public unsafe float MaxQueryImportance {
            get {return AISense_Sight_ptr->MaxQueryImportance;}
            set {AISense_Sight_ptr->MaxQueryImportance = value;}
        }
        ///<summary>Sight Limit Query Importance</summary>
        public unsafe float SightLimitQueryImportance {
            get {return AISense_Sight_ptr->SightLimitQueryImportance;}
            set {AISense_Sight_ptr->SightLimitQueryImportance = value;}
        }
        static AISense_Sight() {
            StaticClass = Main.GetClass("AISense_Sight");
        }
        internal unsafe AISense_Sight_fields* AISense_Sight_ptr => (AISense_Sight_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISense_Sight(IntPtr p) => UObject.Make<AISense_Sight>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISense_Sight DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISense_Sight New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
