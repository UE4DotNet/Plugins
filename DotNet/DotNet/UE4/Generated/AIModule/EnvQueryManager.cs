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
    ///<summary>Env Query Manager</summary>
    public unsafe partial class EnvQueryManager : UObject  {

        ///<summary>Run EQSQuery</summary>
        public static EnvQueryInstanceBlueprintWrapper RunEQSQuery(UObject WorldContextObject, EnvQuery QueryTemplate, UObject Querier, byte RunMode, SubclassOf<EnvQueryInstanceBlueprintWrapper> WrapperClass)  => 
            EnvQueryManager_methods.RunEQSQuery_method.Invoke(WorldContextObject, QueryTemplate, Querier, RunMode, WrapperClass);
         //TODO: array not UObject TArray InstanceCache
        ///<summary>local cache of context objects for managing BP based objects</summary>
        public ObjectArrayField<EnvQueryContext> LocalContexts{ get {
            if(LocalContexts_store == null) LocalContexts_store = new ObjectArrayField<EnvQueryContext> (&EnvQueryManager_ptr->LocalContexts);
            return LocalContexts_store;
        } }
        private ObjectArrayField<EnvQueryContext> LocalContexts_store;

        ///<summary>GCShielded Wrappers</summary>
        public ObjectArrayField<EnvQueryInstanceBlueprintWrapper> GCShieldedWrappers{ get {
            if(GCShieldedWrappers_store == null) GCShieldedWrappers_store = new ObjectArrayField<EnvQueryInstanceBlueprintWrapper> (&EnvQueryManager_ptr->GCShieldedWrappers);
            return GCShieldedWrappers_store;
        } }
        private ObjectArrayField<EnvQueryInstanceBlueprintWrapper> GCShieldedWrappers_store;

        ///<summary>how long are we allowed to test per update, in seconds.</summary>
        public unsafe float MaxAllowedTestingTime {
            get {return EnvQueryManager_ptr->MaxAllowedTestingTime;}
            set {EnvQueryManager_ptr->MaxAllowedTestingTime = value;}
        }
        public bool bTestQueriesUsingBreadth {
            get {return Main.GetGetBoolPropertyByName(this, "bTestQueriesUsingBreadth"); }
            set {Main.SetGetBoolPropertyByName(this, "bTestQueriesUsingBreadth", value); }
        }
        ///<summary>if greater than zero, we will warn once when the number of queries is greater than or equal to this number, and log the queries out</summary>
        public unsafe int QueryCountWarningThreshold {
            get {return EnvQueryManager_ptr->QueryCountWarningThreshold;}
            set {EnvQueryManager_ptr->QueryCountWarningThreshold = value;}
        }
        ///<summary>how often (in seconds) we will warn about the number of queries (allows us to catch multiple occurrences in a session)</summary>
        public unsafe double QueryCountWarningInterval {
            get {return EnvQueryManager_ptr->QueryCountWarningInterval;}
            set {EnvQueryManager_ptr->QueryCountWarningInterval = value;}
        }
        static EnvQueryManager() {
            StaticClass = Main.GetClass("EnvQueryManager");
        }
        internal unsafe EnvQueryManager_fields* EnvQueryManager_ptr => (EnvQueryManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryManager(IntPtr p) => UObject.Make<EnvQueryManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
