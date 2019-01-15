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
using UE4.BlueprintGraph.Native;

namespace UE4.BlueprintGraph {
    ///<summary>K2Node Create Delegate</summary>
    public unsafe partial class K2Node_CreateDelegate : K2Node  {
        ///<summary>Selected Function Name</summary>
        public unsafe Name SelectedFunctionName {
            get {return K2Node_CreateDelegate_ptr->SelectedFunctionName;}
            set {K2Node_CreateDelegate_ptr->SelectedFunctionName = value;}
        }
        ///<summary>Selected Function Guid</summary>
        public unsafe FGuid SelectedFunctionGuid {
            get {return K2Node_CreateDelegate_ptr->SelectedFunctionGuid;}
            set {K2Node_CreateDelegate_ptr->SelectedFunctionGuid = value;}
        }
        static K2Node_CreateDelegate() {
            StaticClass = Main.GetClass("K2Node_CreateDelegate");
        }
        internal unsafe K2Node_CreateDelegate_fields* K2Node_CreateDelegate_ptr => (K2Node_CreateDelegate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_CreateDelegate(IntPtr p) => UObject.Make<K2Node_CreateDelegate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_CreateDelegate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_CreateDelegate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
