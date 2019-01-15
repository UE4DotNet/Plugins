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
using UE4.NavigationSystem;

namespace UE4.AIModule {
    ///<summary>Pawn Action Move</summary>
    public unsafe partial class PawnAction_Move : PawnAction  {
        ///<summary>Goal Actor</summary>
        public unsafe Actor GoalActor {
            get {return PawnAction_Move_ptr->GoalActor;}
            set {PawnAction_Move_ptr->GoalActor = value;}
        }
        ///<summary>Goal Location</summary>
        public unsafe Vector GoalLocation {
            get {return PawnAction_Move_ptr->GoalLocation;}
            set {PawnAction_Move_ptr->GoalLocation = value;}
        }
        ///<summary>Acceptable Radius</summary>
        public unsafe float AcceptableRadius {
            get {return PawnAction_Move_ptr->AcceptableRadius;}
            set {PawnAction_Move_ptr->AcceptableRadius = value;}
        }
        ///<summary>"None" will result in default filter being used</summary>
        public unsafe SubclassOf<NavigationQueryFilter> FilterClass {
            get {return PawnAction_Move_ptr->FilterClass;}
            set {PawnAction_Move_ptr->FilterClass = value;}
        }
        public bool bAllowStrafe {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowStrafe"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowStrafe", value); }
        }
        public bool bFinishOnOverlap {
            get {return Main.GetGetBoolPropertyByName(this, "bFinishOnOverlap"); }
            set {Main.SetGetBoolPropertyByName(this, "bFinishOnOverlap", value); }
        }
        public bool bUsePathfinding {
            get {return Main.GetGetBoolPropertyByName(this, "bUsePathfinding"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsePathfinding", value); }
        }
        public bool bAllowPartialPath {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowPartialPath"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowPartialPath", value); }
        }
        public bool bProjectGoalToNavigation {
            get {return Main.GetGetBoolPropertyByName(this, "bProjectGoalToNavigation"); }
            set {Main.SetGetBoolPropertyByName(this, "bProjectGoalToNavigation", value); }
        }
        public bool bUpdatePathToGoal {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdatePathToGoal"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdatePathToGoal", value); }
        }
        public bool bAbortChildActionOnPathChange {
            get {return Main.GetGetBoolPropertyByName(this, "bAbortChildActionOnPathChange"); }
            set {Main.SetGetBoolPropertyByName(this, "bAbortChildActionOnPathChange", value); }
        }
        static PawnAction_Move() {
            StaticClass = Main.GetClass("PawnAction_Move");
        }
        internal unsafe PawnAction_Move_fields* PawnAction_Move_ptr => (PawnAction_Move_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PawnAction_Move(IntPtr p) => UObject.Make<PawnAction_Move>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PawnAction_Move DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PawnAction_Move New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
