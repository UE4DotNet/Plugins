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
    ///<summary>
    ///AIDataProvider_QueryParams is used with environment queries
    ///It allows defining simple parameters for running query,
    ///which are not tied to any specific pawn, but defined
    ///for every query execution.
    ///</summary>
    public unsafe partial class AIDataProvider_QueryParams : AIDataProvider  {
        ///<summary>Arbitrary name this query parameter will be exposed as to outside world (like BT nodes)</summary>
        public unsafe Name ParamName {
            get {return AIDataProvider_QueryParams_ptr->ParamName;}
            set {AIDataProvider_QueryParams_ptr->ParamName = value;}
        }
        ///<summary>Float Value</summary>
        public unsafe float FloatValue {
            get {return AIDataProvider_QueryParams_ptr->FloatValue;}
            set {AIDataProvider_QueryParams_ptr->FloatValue = value;}
        }
        ///<summary>Int Value</summary>
        public unsafe int IntValue {
            get {return AIDataProvider_QueryParams_ptr->IntValue;}
            set {AIDataProvider_QueryParams_ptr->IntValue = value;}
        }
        public bool BoolValue {
            get {return Main.GetGetBoolPropertyByName(this, "BoolValue"); }
            set {Main.SetGetBoolPropertyByName(this, "BoolValue", value); }
        }
        static AIDataProvider_QueryParams() {
            StaticClass = Main.GetClass("AIDataProvider_QueryParams");
        }
        internal unsafe AIDataProvider_QueryParams_fields* AIDataProvider_QueryParams_ptr => (AIDataProvider_QueryParams_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIDataProvider_QueryParams(IntPtr p) => UObject.Make<AIDataProvider_QueryParams>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIDataProvider_QueryParams DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIDataProvider_QueryParams New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
