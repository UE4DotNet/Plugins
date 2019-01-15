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
using UE4.Localization.Native;

namespace UE4.Localization {
    ///<summary>Localization Target Set</summary>
    public unsafe partial class LocalizationTargetSet : UObject  {
        ///<summary>Target Objects</summary>
        public ObjectArrayField<LocalizationTarget> TargetObjects{ get {
            if(TargetObjects_store == null) TargetObjects_store = new ObjectArrayField<LocalizationTarget> (&LocalizationTargetSet_ptr->TargetObjects);
            return TargetObjects_store;
        } }
        private ObjectArrayField<LocalizationTarget> TargetObjects_store;

        static LocalizationTargetSet() {
            StaticClass = Main.GetClass("LocalizationTargetSet");
        }
        internal unsafe LocalizationTargetSet_fields* LocalizationTargetSet_ptr => (LocalizationTargetSet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LocalizationTargetSet(IntPtr p) => UObject.Make<LocalizationTargetSet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LocalizationTargetSet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LocalizationTargetSet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
