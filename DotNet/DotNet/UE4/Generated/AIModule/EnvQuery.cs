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
    ///<summary>Env Query</summary>
    public unsafe partial class EnvQuery : DataAsset  {
        ///<summary>Graph for query</summary>
        public unsafe EdGraph EdGraph {
            get {return EnvQuery_ptr->EdGraph;}
            set {EnvQuery_ptr->EdGraph = value;}
        }
        ///<summary>Query Name</summary>
        public unsafe Name QueryName {
            get {return EnvQuery_ptr->QueryName;}
            set {EnvQuery_ptr->QueryName = value;}
        }
        ///<summary>Options</summary>
        public ObjectArrayField<EnvQueryOption> Options{ get {
            if(Options_store == null) Options_store = new ObjectArrayField<EnvQueryOption> (&EnvQuery_ptr->Options);
            return Options_store;
        } }
        private ObjectArrayField<EnvQueryOption> Options_store;

        static EnvQuery() {
            StaticClass = Main.GetClass("EnvQuery");
        }
        internal unsafe EnvQuery_fields* EnvQuery_ptr => (EnvQuery_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQuery(IntPtr p) => UObject.Make<EnvQuery>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQuery DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQuery New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
