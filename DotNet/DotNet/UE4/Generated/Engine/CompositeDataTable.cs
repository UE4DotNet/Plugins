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
    ///<summary>Data table composed of a stack of other data tables.</summary>
    public unsafe partial class CompositeDataTable : DataTable  {
        ///<summary>Parent tables</summary>
        ///<remarks>Tables with higher indices override data in tables with lower indices</remarks>
        public ObjectArrayField<DataTable> ParentTables{ get {
            if(ParentTables_store == null) ParentTables_store = new ObjectArrayField<DataTable> (&CompositeDataTable_ptr->ParentTables);
            return ParentTables_store;
        } }
        private ObjectArrayField<DataTable> ParentTables_store;

        ///<summary>temporary copy used to detect changes so we can update delegates correctly on removal</summary>
        public ObjectArrayField<DataTable> OldParentTables{ get {
            if(OldParentTables_store == null) OldParentTables_store = new ObjectArrayField<DataTable> (&CompositeDataTable_ptr->OldParentTables);
            return OldParentTables_store;
        } }
        private ObjectArrayField<DataTable> OldParentTables_store;

        static CompositeDataTable() {
            StaticClass = Main.GetClass("CompositeDataTable");
        }
        internal unsafe CompositeDataTable_fields* CompositeDataTable_ptr => (CompositeDataTable_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CompositeDataTable(IntPtr p) => UObject.Make<CompositeDataTable>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CompositeDataTable DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CompositeDataTable New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
