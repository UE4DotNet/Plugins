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
using UE4.NetcodeUnitTest.Native;

namespace UE4.NetcodeUnitTest {
    ///<summary>VMTest Class B</summary>
    public unsafe partial class VMTestClassB : UObject  {
        ///<summary>BObject Ref</summary>
        public unsafe UObject BObjectRef {
            get {return VMTestClassB_ptr->BObjectRef;}
            set {VMTestClassB_ptr->BObjectRef = value;}
        }
        static VMTestClassB() {
            StaticClass = Main.GetClass("VMTestClassB");
        }
        internal unsafe VMTestClassB_fields* VMTestClassB_ptr => (VMTestClassB_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VMTestClassB(IntPtr p) => UObject.Make<VMTestClassB>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VMTestClassB DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VMTestClassB New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
