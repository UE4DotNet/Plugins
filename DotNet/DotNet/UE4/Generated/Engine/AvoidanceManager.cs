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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Avoidance Manager</summary>
    public unsafe partial class AvoidanceManager : UObject  {

        ///<summary>Calculate avoidance velocity for component (avoids collisions with the supplied component)</summary>
        public Vector GetAvoidanceVelocityForComponent(MovementComponent MovementComp)  => 
            AvoidanceManager_methods.GetAvoidanceVelocityForComponent_method.Invoke(ObjPointer, MovementComp);

        ///<summary>Get appropriate UID for use when reporting to this function or requesting RVO assistance.</summary>
        public int GetNewAvoidanceUID()  => 
            AvoidanceManager_methods.GetNewAvoidanceUID_method.Invoke(ObjPointer);

        ///<summary>Get the number of avoidance objects currently in the manager.</summary>
        public int GetObjectCount()  => 
            AvoidanceManager_methods.GetObjectCount_method.Invoke(ObjPointer);

        ///<summary>Register with the given avoidance manager.</summary>
        ///<remarks>
        ///@param AvoidanceWeight      When avoiding each other, actors divert course in proportion to their relative weights. Range is 0.0 to 1.0. Special: at 1.0, actor will not divert course at all.
        ///</remarks>
        public bool RegisterMovementComponent(MovementComponent MovementComp, float AvoidanceWeight)  => 
            AvoidanceManager_methods.RegisterMovementComponent_method.Invoke(ObjPointer, MovementComp, AvoidanceWeight);
        ///<summary>How long an avoidance UID must not be updated before the system will put it back in the pool. Actual delay is up to 150% of this value.</summary>
        public unsafe float DefaultTimeToLive {
            get {return AvoidanceManager_ptr->DefaultTimeToLive;}
            set {AvoidanceManager_ptr->DefaultTimeToLive = value;}
        }
        ///<summary>How long to stay on course (barring collision) after making an avoidance move</summary>
        public unsafe float LockTimeAfterAvoid {
            get {return AvoidanceManager_ptr->LockTimeAfterAvoid;}
            set {AvoidanceManager_ptr->LockTimeAfterAvoid = value;}
        }
        ///<summary>How long to stay on course (barring collision) after making an unobstructed move (should be > 0.0, but can be less than a full frame)</summary>
        public unsafe float LockTimeAfterClean {
            get {return AvoidanceManager_ptr->LockTimeAfterClean;}
            set {AvoidanceManager_ptr->LockTimeAfterClean = value;}
        }
        ///<summary>This is how far forward in time (seconds) we extend our velocity cones and thus our prediction</summary>
        public unsafe float DeltaTimeToPredict {
            get {return AvoidanceManager_ptr->DeltaTimeToPredict;}
            set {AvoidanceManager_ptr->DeltaTimeToPredict = value;}
        }
        ///<summary>Multiply the radius of all STORED avoidance objects by this value to allow a little extra room for avoidance maneuvers.</summary>
        public unsafe float ArtificialRadiusExpansion {
            get {return AvoidanceManager_ptr->ArtificialRadiusExpansion;}
            set {AvoidanceManager_ptr->ArtificialRadiusExpansion = value;}
        }
        ///<summary>Allowable height margin between obstacles and agents. This is over and above the difference in agent heights.</summary>
        public unsafe float HeightCheckMargin {
            get {return AvoidanceManager_ptr->HeightCheckMargin;}
            set {AvoidanceManager_ptr->HeightCheckMargin = value;}
        }
        static AvoidanceManager() {
            StaticClass = Main.GetClass("AvoidanceManager");
        }
        internal unsafe AvoidanceManager_fields* AvoidanceManager_ptr => (AvoidanceManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AvoidanceManager(IntPtr p) => UObject.Make<AvoidanceManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AvoidanceManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AvoidanceManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
