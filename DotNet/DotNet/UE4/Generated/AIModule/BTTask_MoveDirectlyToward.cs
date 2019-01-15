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
    ///<summary>Move Directly Toward task node.</summary>
    ///<remarks>Moves the AI pawn toward the specified Actor or Location (Vector) blackboard entry in a straight line, without regard to any navigation system. If you need the AI to navigate, use the "Move To" node instead.</remarks>
    public unsafe partial class BTTask_MoveDirectlyToward : BTTask_MoveTo  {
        public bool bDisablePathUpdateOnGoalLocationChange {
            get {return Main.GetGetBoolPropertyByName(this, "bDisablePathUpdateOnGoalLocationChange"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisablePathUpdateOnGoalLocationChange", value); }
        }
        public bool bProjectVectorGoalToNavigation {
            get {return Main.GetGetBoolPropertyByName(this, "bProjectVectorGoalToNavigation"); }
            set {Main.SetGetBoolPropertyByName(this, "bProjectVectorGoalToNavigation", value); }
        }
        public bool bUpdatedDeprecatedProperties {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdatedDeprecatedProperties"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdatedDeprecatedProperties", value); }
        }
        static BTTask_MoveDirectlyToward() {
            StaticClass = Main.GetClass("BTTask_MoveDirectlyToward");
        }
        internal unsafe BTTask_MoveDirectlyToward_fields* BTTask_MoveDirectlyToward_ptr => (BTTask_MoveDirectlyToward_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_MoveDirectlyToward(IntPtr p) => UObject.Make<BTTask_MoveDirectlyToward>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_MoveDirectlyToward DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_MoveDirectlyToward New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
