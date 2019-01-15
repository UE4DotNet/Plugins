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

namespace UE4.AIModule {
    ///<summary>Env Query Test Trace</summary>
    public unsafe partial class EnvQueryTest_Trace : EnvQueryTest  {
        ///<summary>trace data</summary>
        public unsafe EnvTraceData TraceData {
            get {return EnvQueryTest_Trace_ptr->TraceData;}
            set {EnvQueryTest_Trace_ptr->TraceData = value;}
        }
        ///<summary>trace direction</summary>
        public unsafe AIDataProviderBoolValue TraceFromContext {
            get {return EnvQueryTest_Trace_ptr->TraceFromContext;}
            set {EnvQueryTest_Trace_ptr->TraceFromContext = value;}
        }
        ///<summary>Z offset from item</summary>
        public unsafe AIDataProviderFloatValue ItemHeightOffset {
            get {return EnvQueryTest_Trace_ptr->ItemHeightOffset;}
            set {EnvQueryTest_Trace_ptr->ItemHeightOffset = value;}
        }
        ///<summary>Z offset from querier</summary>
        public unsafe AIDataProviderFloatValue ContextHeightOffset {
            get {return EnvQueryTest_Trace_ptr->ContextHeightOffset;}
            set {EnvQueryTest_Trace_ptr->ContextHeightOffset = value;}
        }
        ///<summary>context: other end of trace test</summary>
        public unsafe SubclassOf<EnvQueryContext> Context {
            get {return EnvQueryTest_Trace_ptr->Context;}
            set {EnvQueryTest_Trace_ptr->Context = value;}
        }
        static EnvQueryTest_Trace() {
            StaticClass = Main.GetClass("EnvQueryTest_Trace");
        }
        internal unsafe EnvQueryTest_Trace_fields* EnvQueryTest_Trace_ptr => (EnvQueryTest_Trace_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryTest_Trace(IntPtr p) => UObject.Make<EnvQueryTest_Trace>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryTest_Trace DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryTest_Trace New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
