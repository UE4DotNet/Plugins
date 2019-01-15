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
    ///<summary>BTService Run EQS</summary>
    public unsafe partial class BTService_RunEQS : BTService_BlackboardBase  {
        ///<summary>EQSRequest</summary>
        public unsafe EQSParametrizedQueryExecutionRequest EQSRequest {
            get {return BTService_RunEQS_ptr->EQSRequest;}
            set {BTService_RunEQS_ptr->EQSRequest = value;}
        }
        static BTService_RunEQS() {
            StaticClass = Main.GetClass("BTService_RunEQS");
        }
        internal unsafe BTService_RunEQS_fields* BTService_RunEQS_ptr => (BTService_RunEQS_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTService_RunEQS(IntPtr p) => UObject.Make<BTService_RunEQS>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTService_RunEQS DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTService_RunEQS New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
