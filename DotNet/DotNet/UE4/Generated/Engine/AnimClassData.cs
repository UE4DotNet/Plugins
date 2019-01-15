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
    ///<summary>Anim Class Data</summary>
    public unsafe partial class AnimClassData : UObject  {
         //TODO: array not UObject TArray BakedStateMachines
        ///<summary>Target skeleton for this blueprint class</summary>
        public unsafe Skeleton TargetSkeleton {
            get {return AnimClassData_ptr->TargetSkeleton;}
            set {AnimClassData_ptr->TargetSkeleton = value;}
        }
         //TODO: array not UObject TArray AnimNotifies
        ///<summary>The index of the root node in the animation tree</summary>
        public unsafe int RootAnimNodeIndex {
            get {return AnimClassData_ptr->RootAnimNodeIndex;}
            set {AnimClassData_ptr->RootAnimNodeIndex = value;}
        }
         //TODO: array not UObject TArray OrderedSavedPoseIndices
        ///<summary>Root Anim Node Property</summary>
        public unsafe StructProperty RootAnimNodeProperty {
            get {return AnimClassData_ptr->RootAnimNodeProperty;}
            set {AnimClassData_ptr->RootAnimNodeProperty = value;}
        }
        ///<summary>The array of anim nodes</summary>
        public ObjectArrayField<StructProperty> AnimNodeProperties{ get {
            if(AnimNodeProperties_store == null) AnimNodeProperties_store = new ObjectArrayField<StructProperty> (&AnimClassData_ptr->AnimNodeProperties);
            return AnimNodeProperties_store;
        } }
        private ObjectArrayField<StructProperty> AnimNodeProperties_store;

         //TODO: array not UObject TArray SyncGroupNames
        static AnimClassData() {
            StaticClass = Main.GetClass("AnimClassData");
        }
        internal unsafe AnimClassData_fields* AnimClassData_ptr => (AnimClassData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimClassData(IntPtr p) => UObject.Make<AnimClassData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimClassData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimClassData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
