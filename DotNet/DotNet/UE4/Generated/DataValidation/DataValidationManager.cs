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
using UE4.DataValidation.Native;

namespace UE4.DataValidation {
    ///<summary>Manages centralized execution and tracking of data validation, as well as handling console commands,</summary>
    ///<remarks>and some misc tasks like local log hooking</remarks>
    public unsafe partial class DataValidationManager : UObject  {
         //TODO: array not UObject TArray ExcludedDirectories
        ///<summary>The class to instantiate as the manager object. Defaults to this class but can be overridden</summary>
        public unsafe SoftClassPath DataValidationManagerClassName {
            get {return DataValidationManager_ptr->DataValidationManagerClassName;}
            set {DataValidationManager_ptr->DataValidationManagerClassName = value;}
        }
        static DataValidationManager() {
            StaticClass = Main.GetClass("DataValidationManager");
        }
        internal unsafe DataValidationManager_fields* DataValidationManager_ptr => (DataValidationManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DataValidationManager(IntPtr p) => UObject.Make<DataValidationManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DataValidationManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DataValidationManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
