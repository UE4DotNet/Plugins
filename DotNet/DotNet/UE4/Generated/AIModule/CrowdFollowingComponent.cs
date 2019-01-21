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
    ///<summary>Crowd Following Component</summary>
    public unsafe partial class CrowdFollowingComponent : PathFollowingComponent  {

        ///<summary>master switch for crowd steering & avoidance</summary>
        public void SuspendCrowdSteering(bool bSuspend)  => 
            CrowdFollowingComponent_methods.SuspendCrowdSteering_method.Invoke(ObjPointer, bSuspend);
        ///<summary>Character Movement</summary>
        public unsafe CharacterMovementComponent CharacterMovement {
            get {return CrowdFollowingComponent_ptr->CharacterMovement;}
            set {CrowdFollowingComponent_ptr->CharacterMovement = value;}
        }
        ///<summary>Crowd Agent Move Direction</summary>
        public unsafe Vector CrowdAgentMoveDirection {
            get {return CrowdFollowingComponent_ptr->CrowdAgentMoveDirection;}
            set {CrowdFollowingComponent_ptr->CrowdAgentMoveDirection = value;}
        }
        static CrowdFollowingComponent() {
            StaticClass = Main.GetClass("CrowdFollowingComponent");
        }
        internal unsafe CrowdFollowingComponent_fields* CrowdFollowingComponent_ptr => (CrowdFollowingComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CrowdFollowingComponent(IntPtr p) => UObject.Make<CrowdFollowingComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CrowdFollowingComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CrowdFollowingComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
