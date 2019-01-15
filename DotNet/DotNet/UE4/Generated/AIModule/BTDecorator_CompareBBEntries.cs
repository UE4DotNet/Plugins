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
    ///<summary>Blackboard comparison decorator node.</summary>
    ///<remarks>A decorator node that bases its condition on a comparison between two Blackboard keys.</remarks>
    public unsafe partial class BTDecorator_CompareBBEntries : BTDecorator  {
        ///<summary>operation type</summary>
        public unsafe byte Operator {
            get {return BTDecorator_CompareBBEntries_ptr->Operator;}
            set {BTDecorator_CompareBBEntries_ptr->Operator = value;}
        }
        ///<summary>blackboard key selector</summary>
        public unsafe BlackboardKeySelector BlackboardKeyA {
            get {return BTDecorator_CompareBBEntries_ptr->BlackboardKeyA;}
            set {BTDecorator_CompareBBEntries_ptr->BlackboardKeyA = value;}
        }
        ///<summary>blackboard key selector</summary>
        public unsafe BlackboardKeySelector BlackboardKeyB {
            get {return BTDecorator_CompareBBEntries_ptr->BlackboardKeyB;}
            set {BTDecorator_CompareBBEntries_ptr->BlackboardKeyB = value;}
        }
        static BTDecorator_CompareBBEntries() {
            StaticClass = Main.GetClass("BTDecorator_CompareBBEntries");
        }
        internal unsafe BTDecorator_CompareBBEntries_fields* BTDecorator_CompareBBEntries_ptr => (BTDecorator_CompareBBEntries_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_CompareBBEntries(IntPtr p) => UObject.Make<BTDecorator_CompareBBEntries>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_CompareBBEntries DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_CompareBBEntries New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
