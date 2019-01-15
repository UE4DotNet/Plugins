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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Defines a curve of interpolated points to evaluate over a given range</summary>
    public unsafe partial class CurveBase : UObject  {

        ///<summary>Get the time range across all curves</summary>
        public (float, float) GetTimeRange()  => 
            CurveBase_methods.GetTimeRange_method.Invoke(ObjPointer);

        ///<summary>Get the value range across all curves</summary>
        public (float, float) GetValueRange()  => 
            CurveBase_methods.GetValueRange_method.Invoke(ObjPointer);
        ///<summary>Asset Import Data</summary>
        public unsafe AssetImportData AssetImportData {
            get {return CurveBase_ptr->AssetImportData;}
            set {CurveBase_ptr->AssetImportData = value;}
        }
        static CurveBase() {
            StaticClass = Main.GetClass("CurveBase");
        }
        internal unsafe CurveBase_fields* CurveBase_ptr => (CurveBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurveBase(IntPtr p) => UObject.Make<CurveBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurveBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurveBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
