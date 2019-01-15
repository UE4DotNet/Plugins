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
    ///<summary>K2Node Switch String</summary>
    public unsafe partial class K2Node_SwitchString : K2Node_Switch  {
         //TODO: array not UObject TArray PinNames
        public bool bIsCaseSensitive {
            get {return Main.GetGetBoolPropertyByName(this, "bIsCaseSensitive"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsCaseSensitive", value); }
        }
        static K2Node_SwitchString() {
            StaticClass = Main.GetClass("K2Node_SwitchString");
        }
        internal unsafe K2Node_SwitchString_fields* K2Node_SwitchString_ptr => (K2Node_SwitchString_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_SwitchString(IntPtr p) => UObject.Make<K2Node_SwitchString>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_SwitchString DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_SwitchString New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
