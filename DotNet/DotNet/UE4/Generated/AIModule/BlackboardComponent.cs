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
    ///<summary>Blackboard Component</summary>
    public unsafe partial class BlackboardComponent : ActorComponent  {

        ///<summary>Clear Value</summary>
        public void ClearValue(Name KeyName)  => 
            BlackboardComponent_methods.ClearValue_method.Invoke(ObjPointer, KeyName);

        ///<summary>return false if call failed (most probably no such entry in BB)</summary>
        public (Vector, bool) GetLocationFromEntry(Name KeyName)  => 
            BlackboardComponent_methods.GetLocationFromEntry_method.Invoke(ObjPointer, KeyName);

        ///<summary>return false if call failed (most probably no such entry in BB)</summary>
        public (Rotator, bool) GetRotationFromEntry(Name KeyName)  => 
            BlackboardComponent_methods.GetRotationFromEntry_method.Invoke(ObjPointer, KeyName);

        ///<summary>Get Value as Bool</summary>
        public bool GetValueAsBool(Name KeyName)  => 
            BlackboardComponent_methods.GetValueAsBool_method.Invoke(ObjPointer, KeyName);

        ///<summary>Get Value as Class</summary>
        public SubclassOf<UObject> GetValueAsClass(Name KeyName)  => 
            BlackboardComponent_methods.GetValueAsClass_method.Invoke(ObjPointer, KeyName);

        ///<summary>Get Value as Enum</summary>
        public byte GetValueAsEnum(Name KeyName)  => 
            BlackboardComponent_methods.GetValueAsEnum_method.Invoke(ObjPointer, KeyName);

        ///<summary>Get Value as Float</summary>
        public float GetValueAsFloat(Name KeyName)  => 
            BlackboardComponent_methods.GetValueAsFloat_method.Invoke(ObjPointer, KeyName);

        ///<summary>Get Value as Int</summary>
        public int GetValueAsInt(Name KeyName)  => 
            BlackboardComponent_methods.GetValueAsInt_method.Invoke(ObjPointer, KeyName);

        ///<summary>Get Value as Name</summary>
        public Name GetValueAsName(Name KeyName)  => 
            BlackboardComponent_methods.GetValueAsName_method.Invoke(ObjPointer, KeyName);

        ///<summary>Get Value as Object</summary>
        public UObject GetValueAsObject(Name KeyName)  => 
            BlackboardComponent_methods.GetValueAsObject_method.Invoke(ObjPointer, KeyName);

        ///<summary>Get Value as Rotator</summary>
        public Rotator GetValueAsRotator(Name KeyName)  => 
            BlackboardComponent_methods.GetValueAsRotator_method.Invoke(ObjPointer, KeyName);

        ///<summary>Get Value as String</summary>
        public string GetValueAsString(Name KeyName)  => 
            BlackboardComponent_methods.GetValueAsString_method.Invoke(ObjPointer, KeyName);

        ///<summary>Get Value as Vector</summary>
        public Vector GetValueAsVector(Name KeyName)  => 
            BlackboardComponent_methods.GetValueAsVector_method.Invoke(ObjPointer, KeyName);

        ///<summary>If the vector value has been set (and not cleared), this function returns true (indicating that the value should be valid).  If it's not set, the vector value is invalid and this function will return false.  (Also returns false if the key specified does not hold a vector.)</summary>
        public bool IsVectorValueSet(Name KeyName)  => 
            BlackboardComponent_methods.IsVectorValueSet_method.Invoke(ObjPointer, KeyName);

        ///<summary>Set Value as Bool</summary>
        public void SetValueAsBool(Name KeyName, bool BoolValue)  => 
            BlackboardComponent_methods.SetValueAsBool_method.Invoke(ObjPointer, KeyName, BoolValue);

        ///<summary>Set Value as Class</summary>
        public void SetValueAsClass(Name KeyName, SubclassOf<UObject> ClassValue)  => 
            BlackboardComponent_methods.SetValueAsClass_method.Invoke(ObjPointer, KeyName, ClassValue);

        ///<summary>Set Value as Enum</summary>
        public void SetValueAsEnum(Name KeyName, byte EnumValue)  => 
            BlackboardComponent_methods.SetValueAsEnum_method.Invoke(ObjPointer, KeyName, EnumValue);

        ///<summary>Set Value as Float</summary>
        public void SetValueAsFloat(Name KeyName, float FloatValue)  => 
            BlackboardComponent_methods.SetValueAsFloat_method.Invoke(ObjPointer, KeyName, FloatValue);

        ///<summary>Set Value as Int</summary>
        public void SetValueAsInt(Name KeyName, int IntValue)  => 
            BlackboardComponent_methods.SetValueAsInt_method.Invoke(ObjPointer, KeyName, IntValue);

        ///<summary>Set Value as Name</summary>
        public void SetValueAsName(Name KeyName, Name NameValue)  => 
            BlackboardComponent_methods.SetValueAsName_method.Invoke(ObjPointer, KeyName, NameValue);

        ///<summary>Set Value as Object</summary>
        public void SetValueAsObject(Name KeyName, UObject ObjectValue)  => 
            BlackboardComponent_methods.SetValueAsObject_method.Invoke(ObjPointer, KeyName, ObjectValue);

        ///<summary>Set Value as Rotator</summary>
        public void SetValueAsRotator(Name KeyName, Rotator VectorValue)  => 
            BlackboardComponent_methods.SetValueAsRotator_method.Invoke(ObjPointer, KeyName, VectorValue);

        ///<summary>Set Value as String</summary>
        public void SetValueAsString(Name KeyName, string StringValue)  => 
            BlackboardComponent_methods.SetValueAsString_method.Invoke(ObjPointer, KeyName, StringValue);

        ///<summary>Set Value as Vector</summary>
        public void SetValueAsVector(Name KeyName, Vector VectorValue)  => 
            BlackboardComponent_methods.SetValueAsVector_method.Invoke(ObjPointer, KeyName, VectorValue);
        ///<summary>cached behavior tree component</summary>
        public unsafe BrainComponent BrainComp {
            get {return BlackboardComponent_ptr->BrainComp;}
            set {BlackboardComponent_ptr->BrainComp = value;}
        }
        ///<summary>data asset defining entries</summary>
        public unsafe BlackboardData BlackboardAsset {
            get {return BlackboardComponent_ptr->BlackboardAsset;}
            set {BlackboardComponent_ptr->BlackboardAsset = value;}
        }
        ///<summary>instanced keys with custom data allocations</summary>
        public ObjectArrayField<BlackboardKeyType> KeyInstances{ get {
            if(KeyInstances_store == null) KeyInstances_store = new ObjectArrayField<BlackboardKeyType> (&BlackboardComponent_ptr->KeyInstances);
            return KeyInstances_store;
        } }
        private ObjectArrayField<BlackboardKeyType> KeyInstances_store;

        static BlackboardComponent() {
            StaticClass = Main.GetClass("BlackboardComponent");
        }
        internal unsafe BlackboardComponent_fields* BlackboardComponent_ptr => (BlackboardComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlackboardComponent(IntPtr p) => UObject.Make<BlackboardComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlackboardComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlackboardComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
