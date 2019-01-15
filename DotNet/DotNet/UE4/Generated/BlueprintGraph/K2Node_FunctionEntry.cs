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
    ///<summary>K2Node Function Entry</summary>
    public unsafe partial class K2Node_FunctionEntry : K2Node_FunctionTerminator  {
        ///<summary>If specified, the function that is created for this entry point will have this name.  Otherwise, it will have the function signature's name</summary>
        public unsafe Name CustomGeneratedFunctionName {
            get {return K2Node_FunctionEntry_ptr->CustomGeneratedFunctionName;}
            set {K2Node_FunctionEntry_ptr->CustomGeneratedFunctionName = value;}
        }
        ///<summary>Function metadata</summary>
        public unsafe KismetUserDeclaredFunctionMetadata MetaData {
            get {return K2Node_FunctionEntry_ptr->MetaData;}
            set {K2Node_FunctionEntry_ptr->MetaData = value;}
        }
         //TODO: array not UObject TArray LocalVariables
        public bool bEnforceConstCorrectness {
            get {return Main.GetGetBoolPropertyByName(this, "bEnforceConstCorrectness"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnforceConstCorrectness", value); }
        }
        ///<summary>Any extra flags that the function may need</summary>
        public unsafe int ExtraFlags {
            get {return K2Node_FunctionEntry_ptr->ExtraFlags;}
            set {K2Node_FunctionEntry_ptr->ExtraFlags = value;}
        }
        static K2Node_FunctionEntry() {
            StaticClass = Main.GetClass("K2Node_FunctionEntry");
        }
        internal unsafe K2Node_FunctionEntry_fields* K2Node_FunctionEntry_ptr => (K2Node_FunctionEntry_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_FunctionEntry(IntPtr p) => UObject.Make<K2Node_FunctionEntry>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_FunctionEntry DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_FunctionEntry New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
