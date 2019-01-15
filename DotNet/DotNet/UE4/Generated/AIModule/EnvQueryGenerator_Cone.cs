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
    ///<summary>Env Query Generator Cone</summary>
    public unsafe partial class EnvQueryGenerator_Cone : EnvQueryGenerator_ProjectedPoints  {
        ///<summary>Distance between each point of the same angle</summary>
        public unsafe AIDataProviderFloatValue AlignedPointsDistance {
            get {return EnvQueryGenerator_Cone_ptr->AlignedPointsDistance;}
            set {EnvQueryGenerator_Cone_ptr->AlignedPointsDistance = value;}
        }
        ///<summary>Maximum degrees of the generated cone</summary>
        public unsafe AIDataProviderFloatValue ConeDegrees {
            get {return EnvQueryGenerator_Cone_ptr->ConeDegrees;}
            set {EnvQueryGenerator_Cone_ptr->ConeDegrees = value;}
        }
        ///<summary>The step of the angle increase.</summary>
        ///<remarks>
        ///Angle step must be >=1
        ///Smaller values generate less items
        ///</remarks>
        public unsafe AIDataProviderFloatValue AngleStep {
            get {return EnvQueryGenerator_Cone_ptr->AngleStep;}
            set {EnvQueryGenerator_Cone_ptr->AngleStep = value;}
        }
        ///<summary>Generation distance</summary>
        public unsafe AIDataProviderFloatValue Range {
            get {return EnvQueryGenerator_Cone_ptr->Range;}
            set {EnvQueryGenerator_Cone_ptr->Range = value;}
        }
        ///<summary>The actor (or actors) that will generate a cone in their facing direction</summary>
        public unsafe SubclassOf<EnvQueryContext> CenterActor {
            get {return EnvQueryGenerator_Cone_ptr->CenterActor;}
            set {EnvQueryGenerator_Cone_ptr->CenterActor = value;}
        }
        public bool bIncludeContextLocation {
            get {return Main.GetGetBoolPropertyByName(this, "bIncludeContextLocation"); }
            set {Main.SetGetBoolPropertyByName(this, "bIncludeContextLocation", value); }
        }
        static EnvQueryGenerator_Cone() {
            StaticClass = Main.GetClass("EnvQueryGenerator_Cone");
        }
        internal unsafe EnvQueryGenerator_Cone_fields* EnvQueryGenerator_Cone_ptr => (EnvQueryGenerator_Cone_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryGenerator_Cone(IntPtr p) => UObject.Make<EnvQueryGenerator_Cone>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryGenerator_Cone DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryGenerator_Cone New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
