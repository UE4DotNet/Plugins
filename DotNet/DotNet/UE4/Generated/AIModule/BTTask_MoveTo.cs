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
using UE4.NavigationSystem;

namespace UE4.AIModule {
    ///<summary>Move To task node.</summary>
    ///<remarks>Moves the AI pawn toward the specified Actor or Location blackboard entry using the navigation system.</remarks>
    public unsafe partial class BTTask_MoveTo : BTTask_BlackboardBase  {
        ///<summary>fixed distance added to threshold between AI and goal location in destination reach test</summary>
        public unsafe float AcceptableRadius {
            get {return BTTask_MoveTo_ptr->AcceptableRadius;}
            set {BTTask_MoveTo_ptr->AcceptableRadius = value;}
        }
        ///<summary>"None" will result in default filter being used</summary>
        public unsafe SubclassOf<NavigationQueryFilter> FilterClass {
            get {return BTTask_MoveTo_ptr->FilterClass;}
            set {BTTask_MoveTo_ptr->FilterClass = value;}
        }
        ///<summary>
        ///if task is expected to react to changes to location represented by BB key
        ///    this property can be used to tweak sensitivity of the mechanism.
        ///</summary>
        ///<remarks>
        ///Value is
        ///    recommended to be less then AcceptableRadius
        ///</remarks>
        public unsafe float ObservedBlackboardValueTolerance {
            get {return BTTask_MoveTo_ptr->ObservedBlackboardValueTolerance;}
            set {BTTask_MoveTo_ptr->ObservedBlackboardValueTolerance = value;}
        }
        public bool bObserveBlackboardValue {
            get {return Main.GetGetBoolPropertyByName(this, "bObserveBlackboardValue"); }
            set {Main.SetGetBoolPropertyByName(this, "bObserveBlackboardValue", value); }
        }
        public bool bAllowStrafe {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowStrafe"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowStrafe", value); }
        }
        public bool bAllowPartialPath {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowPartialPath"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowPartialPath", value); }
        }
        public bool bTrackMovingGoal {
            get {return Main.GetGetBoolPropertyByName(this, "bTrackMovingGoal"); }
            set {Main.SetGetBoolPropertyByName(this, "bTrackMovingGoal", value); }
        }
        public bool bProjectGoalLocation {
            get {return Main.GetGetBoolPropertyByName(this, "bProjectGoalLocation"); }
            set {Main.SetGetBoolPropertyByName(this, "bProjectGoalLocation", value); }
        }
        public bool bReachTestIncludesAgentRadius {
            get {return Main.GetGetBoolPropertyByName(this, "bReachTestIncludesAgentRadius"); }
            set {Main.SetGetBoolPropertyByName(this, "bReachTestIncludesAgentRadius", value); }
        }
        public bool bReachTestIncludesGoalRadius {
            get {return Main.GetGetBoolPropertyByName(this, "bReachTestIncludesGoalRadius"); }
            set {Main.SetGetBoolPropertyByName(this, "bReachTestIncludesGoalRadius", value); }
        }
        public bool bStopOnOverlap {
            get {return Main.GetGetBoolPropertyByName(this, "bStopOnOverlap"); }
            set {Main.SetGetBoolPropertyByName(this, "bStopOnOverlap", value); }
        }
        public bool bStopOnOverlapNeedsUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bStopOnOverlapNeedsUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bStopOnOverlapNeedsUpdate", value); }
        }
        static BTTask_MoveTo() {
            StaticClass = Main.GetClass("BTTask_MoveTo");
        }
        internal unsafe BTTask_MoveTo_fields* BTTask_MoveTo_ptr => (BTTask_MoveTo_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_MoveTo(IntPtr p) => UObject.Make<BTTask_MoveTo>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_MoveTo DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_MoveTo New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
