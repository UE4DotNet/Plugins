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
    ///<summary>K2Node Switch</summary>
    public unsafe partial class K2Node_Switch : K2Node  {
        public bool bHasDefaultPin {
            get {return Main.GetGetBoolPropertyByName(this, "bHasDefaultPin"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasDefaultPin", value); }
        }
        ///<summary>The function underpining the switch, if required</summary>
        public unsafe Name FunctionName {
            get {return K2Node_Switch_ptr->FunctionName;}
            set {K2Node_Switch_ptr->FunctionName = value;}
        }
        ///<summary>The class that the function is from.</summary>
        public unsafe SubclassOf<UObject> FunctionClass {
            get {return K2Node_Switch_ptr->FunctionClass;}
            set {K2Node_Switch_ptr->FunctionClass = value;}
        }
        static K2Node_Switch() {
            StaticClass = Main.GetClass("K2Node_Switch");
        }
        internal unsafe K2Node_Switch_fields* K2Node_Switch_ptr => (K2Node_Switch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_Switch(IntPtr p) => UObject.Make<K2Node_Switch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_Switch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_Switch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
