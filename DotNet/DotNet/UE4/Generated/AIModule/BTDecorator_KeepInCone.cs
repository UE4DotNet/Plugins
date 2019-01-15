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
    ///<summary>Cooldown decorator node.</summary>
    ///<remarks>A decorator node that bases its condition on whether the observed position is still inside a cone. The cone's direction is calculated when the node first becomes relevant.</remarks>
    public unsafe partial class BTDecorator_KeepInCone : BTDecorator  {
        ///<summary>max allowed time for execution of underlying node</summary>
        public unsafe float ConeHalfAngle {
            get {return BTDecorator_KeepInCone_ptr->ConeHalfAngle;}
            set {BTDecorator_KeepInCone_ptr->ConeHalfAngle = value;}
        }
        ///<summary>blackboard key selector</summary>
        public unsafe BlackboardKeySelector ConeOrigin {
            get {return BTDecorator_KeepInCone_ptr->ConeOrigin;}
            set {BTDecorator_KeepInCone_ptr->ConeOrigin = value;}
        }
        ///<summary>blackboard key selector</summary>
        public unsafe BlackboardKeySelector Observed {
            get {return BTDecorator_KeepInCone_ptr->Observed;}
            set {BTDecorator_KeepInCone_ptr->Observed = value;}
        }
        public bool bUseSelfAsOrigin {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSelfAsOrigin"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSelfAsOrigin", value); }
        }
        public bool bUseSelfAsObserved {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSelfAsObserved"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSelfAsObserved", value); }
        }
        static BTDecorator_KeepInCone() {
            StaticClass = Main.GetClass("BTDecorator_KeepInCone");
        }
        internal unsafe BTDecorator_KeepInCone_fields* BTDecorator_KeepInCone_ptr => (BTDecorator_KeepInCone_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_KeepInCone(IntPtr p) => UObject.Make<BTDecorator_KeepInCone>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_KeepInCone DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_KeepInCone New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
