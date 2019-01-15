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
    ///<summary>BTFunction Library</summary>
    public unsafe partial class BTFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Resets indicated value to "not set" value, based on values type</summary>
        public static void ClearBlackboardValue(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.ClearBlackboardValue_method.Invoke(NodeOwner, Key);

        ///<summary>(DEPRECATED) Use ClearBlackboardValue instead</summary>
        public static void ClearBlackboardValueAsVector(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.ClearBlackboardValueAsVector_method.Invoke(NodeOwner, Key);

        ///<summary>Get Blackboard Value as Actor</summary>
        public static Actor GetBlackboardValueAsActor(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.GetBlackboardValueAsActor_method.Invoke(NodeOwner, Key);

        ///<summary>Get Blackboard Value as Bool</summary>
        public static bool GetBlackboardValueAsBool(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.GetBlackboardValueAsBool_method.Invoke(NodeOwner, Key);

        ///<summary>Get Blackboard Value as Class</summary>
        public static SubclassOf<UObject> GetBlackboardValueAsClass(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.GetBlackboardValueAsClass_method.Invoke(NodeOwner, Key);

        ///<summary>Get Blackboard Value as Enum</summary>
        public static byte GetBlackboardValueAsEnum(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.GetBlackboardValueAsEnum_method.Invoke(NodeOwner, Key);

        ///<summary>Get Blackboard Value as Float</summary>
        public static float GetBlackboardValueAsFloat(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.GetBlackboardValueAsFloat_method.Invoke(NodeOwner, Key);

        ///<summary>Get Blackboard Value as Int</summary>
        public static int GetBlackboardValueAsInt(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.GetBlackboardValueAsInt_method.Invoke(NodeOwner, Key);

        ///<summary>Get Blackboard Value as Name</summary>
        public static Name GetBlackboardValueAsName(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.GetBlackboardValueAsName_method.Invoke(NodeOwner, Key);

        ///<summary>Get Blackboard Value as Object</summary>
        public static UObject GetBlackboardValueAsObject(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.GetBlackboardValueAsObject_method.Invoke(NodeOwner, Key);

        ///<summary>Get Blackboard Value as Rotator</summary>
        public static Rotator GetBlackboardValueAsRotator(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.GetBlackboardValueAsRotator_method.Invoke(NodeOwner, Key);

        ///<summary>Get Blackboard Value as String</summary>
        public static string GetBlackboardValueAsString(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.GetBlackboardValueAsString_method.Invoke(NodeOwner, Key);

        ///<summary>Get Blackboard Value as Vector</summary>
        public static Vector GetBlackboardValueAsVector(BTNode NodeOwner, BlackboardKeySelector Key)  => 
            BTFunctionLibrary_methods.GetBlackboardValueAsVector_method.Invoke(NodeOwner, Key);

        ///<summary>Get Owner Component</summary>
        public static BehaviorTreeComponent GetOwnerComponent(BTNode NodeOwner)  => 
            BTFunctionLibrary_methods.GetOwnerComponent_method.Invoke(NodeOwner);

        ///<summary>Get Owners Blackboard</summary>
        public static BlackboardComponent GetOwnersBlackboard(BTNode NodeOwner)  => 
            BTFunctionLibrary_methods.GetOwnersBlackboard_method.Invoke(NodeOwner);

        ///<summary>Set Blackboard Value as Bool</summary>
        public static void SetBlackboardValueAsBool(BTNode NodeOwner, BlackboardKeySelector Key, bool Value)  => 
            BTFunctionLibrary_methods.SetBlackboardValueAsBool_method.Invoke(NodeOwner, Key, Value);

        ///<summary>Set Blackboard Value as Class</summary>
        public static void SetBlackboardValueAsClass(BTNode NodeOwner, BlackboardKeySelector Key, SubclassOf<UObject> Value)  => 
            BTFunctionLibrary_methods.SetBlackboardValueAsClass_method.Invoke(NodeOwner, Key, Value);

        ///<summary>Set Blackboard Value as Enum</summary>
        public static void SetBlackboardValueAsEnum(BTNode NodeOwner, BlackboardKeySelector Key, byte Value)  => 
            BTFunctionLibrary_methods.SetBlackboardValueAsEnum_method.Invoke(NodeOwner, Key, Value);

        ///<summary>Set Blackboard Value as Float</summary>
        public static void SetBlackboardValueAsFloat(BTNode NodeOwner, BlackboardKeySelector Key, float Value)  => 
            BTFunctionLibrary_methods.SetBlackboardValueAsFloat_method.Invoke(NodeOwner, Key, Value);

        ///<summary>Set Blackboard Value as Int</summary>
        public static void SetBlackboardValueAsInt(BTNode NodeOwner, BlackboardKeySelector Key, int Value)  => 
            BTFunctionLibrary_methods.SetBlackboardValueAsInt_method.Invoke(NodeOwner, Key, Value);

        ///<summary>Set Blackboard Value as Name</summary>
        public static void SetBlackboardValueAsName(BTNode NodeOwner, BlackboardKeySelector Key, Name Value)  => 
            BTFunctionLibrary_methods.SetBlackboardValueAsName_method.Invoke(NodeOwner, Key, Value);

        ///<summary>Set Blackboard Value as Object</summary>
        public static void SetBlackboardValueAsObject(BTNode NodeOwner, BlackboardKeySelector Key, UObject Value)  => 
            BTFunctionLibrary_methods.SetBlackboardValueAsObject_method.Invoke(NodeOwner, Key, Value);

        ///<summary>Set Blackboard Value as Rotator</summary>
        public static void SetBlackboardValueAsRotator(BTNode NodeOwner, BlackboardKeySelector Key, Rotator Value)  => 
            BTFunctionLibrary_methods.SetBlackboardValueAsRotator_method.Invoke(NodeOwner, Key, Value);

        ///<summary>Set Blackboard Value as String</summary>
        public static void SetBlackboardValueAsString(BTNode NodeOwner, BlackboardKeySelector Key, string Value)  => 
            BTFunctionLibrary_methods.SetBlackboardValueAsString_method.Invoke(NodeOwner, Key, Value);

        ///<summary>Set Blackboard Value as Vector</summary>
        public static void SetBlackboardValueAsVector(BTNode NodeOwner, BlackboardKeySelector Key, Vector Value)  => 
            BTFunctionLibrary_methods.SetBlackboardValueAsVector_method.Invoke(NodeOwner, Key, Value);

        ///<summary>Initialize variables marked as "instance memory" and set owning actor for blackboard operations</summary>
        public static void StartUsingExternalEvent(BTNode NodeOwner, Actor OwningActor)  => 
            BTFunctionLibrary_methods.StartUsingExternalEvent_method.Invoke(NodeOwner, OwningActor);

        ///<summary>Save variables marked as "instance memory" and clear owning actor</summary>
        public static void StopUsingExternalEvent(BTNode NodeOwner)  => 
            BTFunctionLibrary_methods.StopUsingExternalEvent_method.Invoke(NodeOwner);
        static BTFunctionLibrary() {
            StaticClass = Main.GetClass("BTFunctionLibrary");
        }
        internal unsafe BTFunctionLibrary_fields* BTFunctionLibrary_ptr => (BTFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTFunctionLibrary(IntPtr p) => UObject.Make<BTFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
