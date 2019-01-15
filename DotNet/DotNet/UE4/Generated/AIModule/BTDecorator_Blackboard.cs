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
    ///<summary>Blackboard decorator node.</summary>
    ///<remarks>A decorator node that bases its condition on a Blackboard key.</remarks>
    public unsafe partial class BTDecorator_Blackboard : BTDecorator_BlackboardBase  {
        ///<summary>value for arithmetic operations</summary>
        public unsafe int IntValue {
            get {return BTDecorator_Blackboard_ptr->IntValue;}
            set {BTDecorator_Blackboard_ptr->IntValue = value;}
        }
        ///<summary>value for arithmetic operations</summary>
        public unsafe float FloatValue {
            get {return BTDecorator_Blackboard_ptr->FloatValue;}
            set {BTDecorator_Blackboard_ptr->FloatValue = value;}
        }
         //TODO: string FString StringValue
         //TODO: string FString CachedDescription
        ///<summary>operation type</summary>
        public unsafe byte OperationType {
            get {return BTDecorator_Blackboard_ptr->OperationType;}
            set {BTDecorator_Blackboard_ptr->OperationType = value;}
        }
        ///<summary>when observer can try to request abort?</summary>
        public unsafe byte NotifyObserver {
            get {return BTDecorator_Blackboard_ptr->NotifyObserver;}
            set {BTDecorator_Blackboard_ptr->NotifyObserver = value;}
        }
        ///<summary>Basic Operation</summary>
        public unsafe byte BasicOperation {
            get {return BTDecorator_Blackboard_ptr->BasicOperation;}
            set {BTDecorator_Blackboard_ptr->BasicOperation = value;}
        }
        ///<summary>Arithmetic Operation</summary>
        public unsafe byte ArithmeticOperation {
            get {return BTDecorator_Blackboard_ptr->ArithmeticOperation;}
            set {BTDecorator_Blackboard_ptr->ArithmeticOperation = value;}
        }
        ///<summary>Text Operation</summary>
        public unsafe byte TextOperation {
            get {return BTDecorator_Blackboard_ptr->TextOperation;}
            set {BTDecorator_Blackboard_ptr->TextOperation = value;}
        }
        static BTDecorator_Blackboard() {
            StaticClass = Main.GetClass("BTDecorator_Blackboard");
        }
        internal unsafe BTDecorator_Blackboard_fields* BTDecorator_Blackboard_ptr => (BTDecorator_Blackboard_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_Blackboard(IntPtr p) => UObject.Make<BTDecorator_Blackboard>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_Blackboard DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_Blackboard New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
