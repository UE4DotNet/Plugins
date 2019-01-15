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
using UE4.Engine;

namespace UE4.BlueprintGraph {
    ///<summary>K2Node Get Class Defaults</summary>
    public unsafe partial class K2Node_GetClassDefaults : K2Node  {
        ///<summary>Blueprint that we subscribed OnBlueprintChangedDelegate and OnBlueprintCompiledDelegate to</summary>
        public unsafe Blueprint BlueprintSubscribedTo {
            get {return K2Node_GetClassDefaults_ptr->BlueprintSubscribedTo;}
            set {K2Node_GetClassDefaults_ptr->BlueprintSubscribedTo = value;}
        }
         //TODO: array not UObject TArray ShowPinForProperties
        public bool bExcludeObjectContainers {
            get {return Main.GetGetBoolPropertyByName(this, "bExcludeObjectContainers"); }
            set {Main.SetGetBoolPropertyByName(this, "bExcludeObjectContainers", value); }
        }
        static K2Node_GetClassDefaults() {
            StaticClass = Main.GetClass("K2Node_GetClassDefaults");
        }
        internal unsafe K2Node_GetClassDefaults_fields* K2Node_GetClassDefaults_ptr => (K2Node_GetClassDefaults_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_GetClassDefaults(IntPtr p) => UObject.Make<K2Node_GetClassDefaults>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_GetClassDefaults DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_GetClassDefaults New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
