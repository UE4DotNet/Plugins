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
    ///<summary>Cone check decorator node.</summary>
    ///<remarks>A decorator node that bases its condition on a cone check, using Blackboard entries to form the parameters of the check.</remarks>
    public unsafe partial class BTDecorator_ConeCheck : BTDecorator  {
        ///<summary>Angle between cone direction and code cone edge, or a half of the total cone angle</summary>
        public unsafe float ConeHalfAngle {
            get {return BTDecorator_ConeCheck_ptr->ConeHalfAngle;}
            set {BTDecorator_ConeCheck_ptr->ConeHalfAngle = value;}
        }
        ///<summary>blackboard key selector</summary>
        public unsafe BlackboardKeySelector ConeOrigin {
            get {return BTDecorator_ConeCheck_ptr->ConeOrigin;}
            set {BTDecorator_ConeCheck_ptr->ConeOrigin = value;}
        }
        ///<summary>"None" means "use ConeOrigin's direction"</summary>
        public unsafe BlackboardKeySelector ConeDirection {
            get {return BTDecorator_ConeCheck_ptr->ConeDirection;}
            set {BTDecorator_ConeCheck_ptr->ConeDirection = value;}
        }
        ///<summary>blackboard key selector</summary>
        public unsafe BlackboardKeySelector Observed {
            get {return BTDecorator_ConeCheck_ptr->Observed;}
            set {BTDecorator_ConeCheck_ptr->Observed = value;}
        }
        static BTDecorator_ConeCheck() {
            StaticClass = Main.GetClass("BTDecorator_ConeCheck");
        }
        internal unsafe BTDecorator_ConeCheck_fields* BTDecorator_ConeCheck_ptr => (BTDecorator_ConeCheck_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_ConeCheck(IntPtr p) => UObject.Make<BTDecorator_ConeCheck>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_ConeCheck DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_ConeCheck New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
