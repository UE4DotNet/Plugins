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
    ///<summary>Run Environment Query System Query task node.</summary>
    ///<remarks>Runs the specified environment query when executed.</remarks>
    public unsafe partial class BTTask_RunEQSQuery : BTTask_BlackboardBase  {
        ///<summary>query to run</summary>
        public unsafe EnvQuery QueryTemplate {
            get {return BTTask_RunEQSQuery_ptr->QueryTemplate;}
            set {BTTask_RunEQSQuery_ptr->QueryTemplate = value;}
        }
         //TODO: array not UObject TArray QueryParams
         //TODO: array not UObject TArray QueryConfig
        ///<summary>determines which item will be stored (All = only first matching)</summary>
        public unsafe byte RunMode {
            get {return BTTask_RunEQSQuery_ptr->RunMode;}
            set {BTTask_RunEQSQuery_ptr->RunMode = value;}
        }
        ///<summary>blackboard key storing an EQS query template</summary>
        public unsafe BlackboardKeySelector EQSQueryBlackboardKey {
            get {return BTTask_RunEQSQuery_ptr->EQSQueryBlackboardKey;}
            set {BTTask_RunEQSQuery_ptr->EQSQueryBlackboardKey = value;}
        }
        public bool bUseBBKey {
            get {return Main.GetGetBoolPropertyByName(this, "bUseBBKey"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseBBKey", value); }
        }
        ///<summary>EQSRequest</summary>
        public unsafe EQSParametrizedQueryExecutionRequest EQSRequest {
            get {return BTTask_RunEQSQuery_ptr->EQSRequest;}
            set {BTTask_RunEQSQuery_ptr->EQSRequest = value;}
        }
        static BTTask_RunEQSQuery() {
            StaticClass = Main.GetClass("BTTask_RunEQSQuery");
        }
        internal unsafe BTTask_RunEQSQuery_fields* BTTask_RunEQSQuery_ptr => (BTTask_RunEQSQuery_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_RunEQSQuery(IntPtr p) => UObject.Make<BTTask_RunEQSQuery>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_RunEQSQuery DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_RunEQSQuery New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
