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
using UE4.FunctionalTesting.Native;

namespace UE4.FunctionalTesting {
    ///<summary>Trace Query Test Results</summary>
    public unsafe partial class TraceQueryTestResults : UObject  {

        ///<summary>Output string value</summary>
        public string ToString()  => 
            TraceQueryTestResults_methods.ToString_method.Invoke(ObjPointer);
        ///<summary>Results for channel trace</summary>
        public unsafe TraceQueryTestResultsInner ChannelResults {
            get {return TraceQueryTestResults_ptr->ChannelResults;}
            set {TraceQueryTestResults_ptr->ChannelResults = value;}
        }
        ///<summary>Results for object trace</summary>
        public unsafe TraceQueryTestResultsInner ObjectResults {
            get {return TraceQueryTestResults_ptr->ObjectResults;}
            set {TraceQueryTestResults_ptr->ObjectResults = value;}
        }
        ///<summary>Results for profile trace</summary>
        public unsafe TraceQueryTestResultsInner ProfileResults {
            get {return TraceQueryTestResults_ptr->ProfileResults;}
            set {TraceQueryTestResults_ptr->ProfileResults = value;}
        }
        static TraceQueryTestResults() {
            StaticClass = Main.GetClass("TraceQueryTestResults");
        }
        internal unsafe TraceQueryTestResults_fields* TraceQueryTestResults_ptr => (TraceQueryTestResults_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TraceQueryTestResults(IntPtr p) => UObject.Make<TraceQueryTestResults>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TraceQueryTestResults DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TraceQueryTestResults New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
