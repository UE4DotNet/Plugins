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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Factory that creates curve assets, prompting to pick the kind of curve at creation time</summary>
    public unsafe partial class CurveFactory : Factory  {
        ///<summary>The type of blueprint that will be created</summary>
        public unsafe SubclassOf<CurveBase> CurveClass {
            get {return CurveFactory_ptr->CurveClass;}
            set {CurveFactory_ptr->CurveClass = value;}
        }
        static CurveFactory() {
            StaticClass = Main.GetClass("CurveFactory");
        }
        internal unsafe CurveFactory_fields* CurveFactory_ptr => (CurveFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurveFactory(IntPtr p) => UObject.Make<CurveFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurveFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurveFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
