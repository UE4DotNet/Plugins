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
    ///<summary>Cooldown decorator node.</summary>
    ///<remarks>A decorator node that bases its condition on whether a path exists between two points from the Blackboard.</remarks>
    public unsafe partial class BTDecorator_DoesPathExist : BTDecorator  {
        ///<summary>blackboard key selector</summary>
        public unsafe BlackboardKeySelector BlackboardKeyA {
            get {return BTDecorator_DoesPathExist_ptr->BlackboardKeyA;}
            set {BTDecorator_DoesPathExist_ptr->BlackboardKeyA = value;}
        }
        ///<summary>blackboard key selector</summary>
        public unsafe BlackboardKeySelector BlackboardKeyB {
            get {return BTDecorator_DoesPathExist_ptr->BlackboardKeyB;}
            set {BTDecorator_DoesPathExist_ptr->BlackboardKeyB = value;}
        }
        public bool bUseSelf {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSelf"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSelf", value); }
        }
        ///<summary>Path Query Type</summary>
        public unsafe byte PathQueryType {
            get {return BTDecorator_DoesPathExist_ptr->PathQueryType;}
            set {BTDecorator_DoesPathExist_ptr->PathQueryType = value;}
        }
        ///<summary>"None" will result in default filter being used</summary>
        public unsafe SubclassOf<NavigationQueryFilter> FilterClass {
            get {return BTDecorator_DoesPathExist_ptr->FilterClass;}
            set {BTDecorator_DoesPathExist_ptr->FilterClass = value;}
        }
        static BTDecorator_DoesPathExist() {
            StaticClass = Main.GetClass("BTDecorator_DoesPathExist");
        }
        internal unsafe BTDecorator_DoesPathExist_fields* BTDecorator_DoesPathExist_ptr => (BTDecorator_DoesPathExist_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_DoesPathExist(IntPtr p) => UObject.Make<BTDecorator_DoesPathExist>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_DoesPathExist DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_DoesPathExist New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
