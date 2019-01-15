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
    ///<summary>Composite generator allows using multiple generators in single query option</summary>
    ///<remarks>All child generators must produce exactly the same item type!</remarks>
    public unsafe partial class EnvQueryGenerator_Composite : EnvQueryGenerator  {
        ///<summary>Generators</summary>
        public ObjectArrayField<EnvQueryGenerator> Generators{ get {
            if(Generators_store == null) Generators_store = new ObjectArrayField<EnvQueryGenerator> (&EnvQueryGenerator_Composite_ptr->Generators);
            return Generators_store;
        } }
        private ObjectArrayField<EnvQueryGenerator> Generators_store;

        public bool bAllowDifferentItemTypes {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowDifferentItemTypes"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowDifferentItemTypes", value); }
        }
        public bool bHasMatchingItemType {
            get {return Main.GetGetBoolPropertyByName(this, "bHasMatchingItemType"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasMatchingItemType", value); }
        }
        ///<summary>Forced Item Type</summary>
        public unsafe SubclassOf<EnvQueryItemType> ForcedItemType {
            get {return EnvQueryGenerator_Composite_ptr->ForcedItemType;}
            set {EnvQueryGenerator_Composite_ptr->ForcedItemType = value;}
        }
        static EnvQueryGenerator_Composite() {
            StaticClass = Main.GetClass("EnvQueryGenerator_Composite");
        }
        internal unsafe EnvQueryGenerator_Composite_fields* EnvQueryGenerator_Composite_ptr => (EnvQueryGenerator_Composite_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryGenerator_Composite(IntPtr p) => UObject.Make<EnvQueryGenerator_Composite>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryGenerator_Composite DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryGenerator_Composite New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
