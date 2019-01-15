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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Interp Filter Custom</summary>
    public unsafe partial class InterpFilter_Custom : InterpFilter  {
        ///<summary>Which groups are included in this filter.</summary>
        public ObjectArrayField<InterpGroup> GroupsToInclude{ get {
            if(GroupsToInclude_store == null) GroupsToInclude_store = new ObjectArrayField<InterpGroup> (&InterpFilter_Custom_ptr->GroupsToInclude);
            return GroupsToInclude_store;
        } }
        private ObjectArrayField<InterpGroup> GroupsToInclude_store;

        static InterpFilter_Custom() {
            StaticClass = Main.GetClass("InterpFilter_Custom");
        }
        internal unsafe InterpFilter_Custom_fields* InterpFilter_Custom_ptr => (InterpFilter_Custom_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpFilter_Custom(IntPtr p) => UObject.Make<InterpFilter_Custom>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpFilter_Custom DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpFilter_Custom New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
