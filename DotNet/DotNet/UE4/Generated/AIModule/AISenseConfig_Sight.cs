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
    ///<summary>AISense Config Sight</summary>
    public unsafe partial class AISenseConfig_Sight : AISenseConfig  {
        ///<summary>Implementation</summary>
        public unsafe SubclassOf<AISense_Sight> Implementation {
            get {return AISenseConfig_Sight_ptr->Implementation;}
        }
        ///<summary>Maximum sight distance to notice a target.</summary>
        public unsafe float SightRadius {
            get {return AISenseConfig_Sight_ptr->SightRadius;}
        }
        ///<summary>Maximum sight distance to see target that has been already seen.</summary>
        public unsafe float LoseSightRadius {
            get {return AISenseConfig_Sight_ptr->LoseSightRadius;}
        }
        ///<summary>How far to the side AI can see, in degrees.</summary>
        ///<remarks>
        ///Use SetPeripheralVisionAngle to change the value at runtime.
        ///    The value represents the angle measured in relation to the forward vector, not the whole range.
        ///</remarks>
        public unsafe float PeripheralVisionAngleDegrees {
            get {return AISenseConfig_Sight_ptr->PeripheralVisionAngleDegrees;}
        }
        ///<summary>Detection by Affiliation</summary>
        public unsafe AISenseAffiliationFilter DetectionByAffiliation {
            get {return AISenseConfig_Sight_ptr->DetectionByAffiliation;}
        }
        ///<summary>If not an InvalidRange (which is the default), we will always be able to see the target that has already been seen if they are within this range of their last seen location.</summary>
        public unsafe float AutoSuccessRangeFromLastSeenLocation {
            get {return AISenseConfig_Sight_ptr->AutoSuccessRangeFromLastSeenLocation;}
        }
        static AISenseConfig_Sight() {
            StaticClass = Main.GetClass("AISenseConfig_Sight");
        }
        internal unsafe AISenseConfig_Sight_fields* AISenseConfig_Sight_ptr => (AISenseConfig_Sight_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISenseConfig_Sight(IntPtr p) => UObject.Make<AISenseConfig_Sight>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISenseConfig_Sight DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISenseConfig_Sight New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
