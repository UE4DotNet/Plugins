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
using UE4.FunctionalTesting.Native;

namespace UE4.FunctionalTesting {
    ///<summary>Ground Truth Data</summary>
    public unsafe partial class GroundTruthData : UObject  {

        ///<summary>Can Modify</summary>
        public bool CanModify()  => 
            GroundTruthData_methods.CanModify_method.Invoke(ObjPointer);

        ///<summary>Load Object</summary>
        public UObject LoadObject()  => 
            GroundTruthData_methods.LoadObject_method.Invoke(ObjPointer);

        ///<summary>Save Object</summary>
        public void SaveObject(UObject GroundTruth)  => 
            GroundTruthData_methods.SaveObject_method.Invoke(ObjPointer, GroundTruth);
        public bool bResetGroundTruth {
            get {return Main.GetGetBoolPropertyByName(this, "bResetGroundTruth"); }
            set {Main.SetGetBoolPropertyByName(this, "bResetGroundTruth", value); }
        }
        ///<summary>Object Data</summary>
        public unsafe UObject ObjectData {
            get {return GroundTruthData_ptr->ObjectData;}
            set {GroundTruthData_ptr->ObjectData = value;}
        }
        static GroundTruthData() {
            StaticClass = Main.GetClass("GroundTruthData");
        }
        internal unsafe GroundTruthData_fields* GroundTruthData_ptr => (GroundTruthData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GroundTruthData(IntPtr p) => UObject.Make<GroundTruthData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GroundTruthData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GroundTruthData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
