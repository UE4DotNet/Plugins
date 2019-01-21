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
using UE4.Engine;

namespace UE4.VariantManagerContent {
    ///<summary>Level Variant Sets Actor</summary>
    public unsafe partial class LevelVariantSetsActor : Actor  {

        ///<summary>Get Level Variant Sets</summary>
        public LevelVariantSets GetLevelVariantSets(bool bLoad)  => 
            LevelVariantSetsActor_methods.GetLevelVariantSets_method.Invoke(ObjPointer, bLoad);

        ///<summary>Set Level Variant Sets</summary>
        public void SetLevelVariantSets(LevelVariantSets InVariantSets)  => 
            LevelVariantSetsActor_methods.SetLevelVariantSets_method.Invoke(ObjPointer, InVariantSets);

        ///<summary>Switch on Variant by Index</summary>
        public bool SwitchOnVariantByIndex(int VariantSetIndex, int VariantIndex)  => 
            LevelVariantSetsActor_methods.SwitchOnVariantByIndex_method.Invoke(ObjPointer, VariantSetIndex, VariantIndex);

        ///<summary>Switch on Variant by Name</summary>
        public bool SwitchOnVariantByName(string VariantSetName, string VariantName)  => 
            LevelVariantSetsActor_methods.SwitchOnVariantByName_method.Invoke(ObjPointer, VariantSetName, VariantName);
        ///<summary>Level Variant Sets</summary>
        public unsafe SoftObjectPath LevelVariantSets {
            get {return LevelVariantSetsActor_ptr->LevelVariantSets;}
        }
        static LevelVariantSetsActor() {
            StaticClass = Main.GetClass("LevelVariantSetsActor");
        }
        internal unsafe LevelVariantSetsActor_fields* LevelVariantSetsActor_ptr => (LevelVariantSetsActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelVariantSetsActor(IntPtr p) => UObject.Make<LevelVariantSetsActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelVariantSetsActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelVariantSetsActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
