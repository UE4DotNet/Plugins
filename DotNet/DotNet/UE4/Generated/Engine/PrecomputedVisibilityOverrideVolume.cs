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
    ///<summary>Precomputed Visibility Override Volume</summary>
    public unsafe partial class PrecomputedVisibilityOverrideVolume : Volume  {
        ///<summary>Array of actors that will always be considered visible by Precomputed Visibility when viewed from inside this volume.</summary>
        public ObjectArrayField<Actor> OverrideVisibleActors{ get {
            if(OverrideVisibleActors_store == null) OverrideVisibleActors_store = new ObjectArrayField<Actor> (&PrecomputedVisibilityOverrideVolume_ptr->OverrideVisibleActors);
            return OverrideVisibleActors_store;
        } }
        private ObjectArrayField<Actor> OverrideVisibleActors_store;

        ///<summary>Array of actors that will always be considered invisible by Precomputed Visibility when viewed from inside this volume.</summary>
        public ObjectArrayField<Actor> OverrideInvisibleActors{ get {
            if(OverrideInvisibleActors_store == null) OverrideInvisibleActors_store = new ObjectArrayField<Actor> (&PrecomputedVisibilityOverrideVolume_ptr->OverrideInvisibleActors);
            return OverrideInvisibleActors_store;
        } }
        private ObjectArrayField<Actor> OverrideInvisibleActors_store;

         //TODO: array not UObject TArray OverrideInvisibleLevels
        static PrecomputedVisibilityOverrideVolume() {
            StaticClass = Main.GetClass("PrecomputedVisibilityOverrideVolume");
        }
        internal unsafe PrecomputedVisibilityOverrideVolume_fields* PrecomputedVisibilityOverrideVolume_ptr => (PrecomputedVisibilityOverrideVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PrecomputedVisibilityOverrideVolume(IntPtr p) => UObject.Make<PrecomputedVisibilityOverrideVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PrecomputedVisibilityOverrideVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PrecomputedVisibilityOverrideVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
