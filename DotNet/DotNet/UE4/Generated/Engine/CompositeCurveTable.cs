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
    ///<summary>Curve table composed of a stack of other curve tables.</summary>
    public unsafe partial class CompositeCurveTable : CurveTable  {
        ///<summary>Parent tables</summary>
        ///<remarks>Tables with higher indices override data in tables with lower indices</remarks>
        public ObjectArrayField<CurveTable> ParentTables{ get {
            if(ParentTables_store == null) ParentTables_store = new ObjectArrayField<CurveTable> (&CompositeCurveTable_ptr->ParentTables);
            return ParentTables_store;
        } }
        private ObjectArrayField<CurveTable> ParentTables_store;

        ///<summary>temporary copy used to detect changes so we can update delegates correctly on removal</summary>
        public ObjectArrayField<CurveTable> OldParentTables{ get {
            if(OldParentTables_store == null) OldParentTables_store = new ObjectArrayField<CurveTable> (&CompositeCurveTable_ptr->OldParentTables);
            return OldParentTables_store;
        } }
        private ObjectArrayField<CurveTable> OldParentTables_store;

        static CompositeCurveTable() {
            StaticClass = Main.GetClass("CompositeCurveTable");
        }
        internal unsafe CompositeCurveTable_fields* CompositeCurveTable_ptr => (CompositeCurveTable_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CompositeCurveTable(IntPtr p) => UObject.Make<CompositeCurveTable>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CompositeCurveTable DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CompositeCurveTable New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
