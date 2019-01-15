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
    ///<summary>Blackboard Data</summary>
    public unsafe partial class BlackboardData : DataAsset  {
        ///<summary>parent blackboard (keys can be overridden)</summary>
        public unsafe BlackboardData Parent {
            get {return BlackboardData_ptr->Parent;}
            set {BlackboardData_ptr->Parent = value;}
        }
         //TODO: array not UObject TArray ParentKeys
         //TODO: array not UObject TArray Keys
        public bool bHasSynchronizedKeys {
            get {return Main.GetGetBoolPropertyByName(this, "bHasSynchronizedKeys"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasSynchronizedKeys", value); }
        }
        static BlackboardData() {
            StaticClass = Main.GetClass("BlackboardData");
        }
        internal unsafe BlackboardData_fields* BlackboardData_ptr => (BlackboardData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlackboardData(IntPtr p) => UObject.Make<BlackboardData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlackboardData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlackboardData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
