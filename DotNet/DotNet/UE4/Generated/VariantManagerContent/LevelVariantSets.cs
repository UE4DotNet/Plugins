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
using UE4.VariantManagerContent.Native;

namespace UE4.VariantManagerContent {
    ///<summary>Level Variant Sets</summary>
    public unsafe partial class LevelVariantSets : UObject  {

        ///<summary>Get Num Variant Sets</summary>
        public int GetNumVariantSets()  => 
            LevelVariantSets_methods.GetNumVariantSets_method.Invoke(ObjPointer);

        ///<summary>Get Variant Set</summary>
        public VariantSet GetVariantSet(int VariantSetIndex)  => 
            LevelVariantSets_methods.GetVariantSet_method.Invoke(ObjPointer, VariantSetIndex);
        ///<summary>Variant Sets</summary>
        public ObjectArrayField<VariantSet> VariantSets{ get {
            if(VariantSets_store == null) VariantSets_store = new ObjectArrayField<VariantSet> (&LevelVariantSets_ptr->VariantSets);
            return VariantSets_store;
        } }
        private ObjectArrayField<VariantSet> VariantSets_store;

         //TODO: map TMap DisplayNodeExpansionStates
        static LevelVariantSets() {
            StaticClass = Main.GetClass("LevelVariantSets");
        }
        internal unsafe LevelVariantSets_fields* LevelVariantSets_ptr => (LevelVariantSets_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelVariantSets(IntPtr p) => UObject.Make<LevelVariantSets>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelVariantSets DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelVariantSets New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
