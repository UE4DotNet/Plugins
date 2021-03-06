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
    ///<summary>Env Query Option</summary>
    public unsafe partial class EnvQueryOption : UObject  {
        ///<summary>Generator</summary>
        public unsafe EnvQueryGenerator Generator {
            get {return EnvQueryOption_ptr->Generator;}
            set {EnvQueryOption_ptr->Generator = value;}
        }
        ///<summary>Tests</summary>
        public ObjectArrayField<EnvQueryTest> Tests{ get {
            if(Tests_store == null) Tests_store = new ObjectArrayField<EnvQueryTest> (&EnvQueryOption_ptr->Tests);
            return Tests_store;
        } }
        private ObjectArrayField<EnvQueryTest> Tests_store;

        static EnvQueryOption() {
            StaticClass = Main.GetClass("EnvQueryOption");
        }
        internal unsafe EnvQueryOption_fields* EnvQueryOption_ptr => (EnvQueryOption_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryOption(IntPtr p) => UObject.Make<EnvQueryOption>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryOption DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryOption New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
