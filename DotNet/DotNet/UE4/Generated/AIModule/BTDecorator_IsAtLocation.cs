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
    ///<summary>Is At Location decorator node.</summary>
    ///<remarks>A decorator node that checks if AI controlled pawn is at given location.</remarks>
    public unsafe partial class BTDecorator_IsAtLocation : BTDecorator_BlackboardBase  {
        ///<summary>distance threshold to accept as being at location</summary>
        public unsafe float AcceptableRadius {
            get {return BTDecorator_IsAtLocation_ptr->AcceptableRadius;}
            set {BTDecorator_IsAtLocation_ptr->AcceptableRadius = value;}
        }
        ///<summary>Parametrized Acceptable Radius</summary>
        public unsafe AIDataProviderFloatValue ParametrizedAcceptableRadius {
            get {return BTDecorator_IsAtLocation_ptr->ParametrizedAcceptableRadius;}
            set {BTDecorator_IsAtLocation_ptr->ParametrizedAcceptableRadius = value;}
        }
         //TODO: enum FAIDistanceType GeometricDistanceType
        public bool bUseParametrizedRadius {
            get {return Main.GetGetBoolPropertyByName(this, "bUseParametrizedRadius"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseParametrizedRadius", value); }
        }
        public bool bUseNavAgentGoalLocation {
            get {return Main.GetGetBoolPropertyByName(this, "bUseNavAgentGoalLocation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseNavAgentGoalLocation", value); }
        }
        public bool bPathFindingBasedTest {
            get {return Main.GetGetBoolPropertyByName(this, "bPathFindingBasedTest"); }
            set {Main.SetGetBoolPropertyByName(this, "bPathFindingBasedTest", value); }
        }
        static BTDecorator_IsAtLocation() {
            StaticClass = Main.GetClass("BTDecorator_IsAtLocation");
        }
        internal unsafe BTDecorator_IsAtLocation_fields* BTDecorator_IsAtLocation_ptr => (BTDecorator_IsAtLocation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_IsAtLocation(IntPtr p) => UObject.Make<BTDecorator_IsAtLocation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_IsAtLocation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_IsAtLocation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
