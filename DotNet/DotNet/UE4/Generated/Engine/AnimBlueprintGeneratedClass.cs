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
    ///<summary>Anim Blueprint Generated Class</summary>
    public unsafe partial class AnimBlueprintGeneratedClass : BlueprintGeneratedClass  {
         //TODO: array not UObject TArray BakedStateMachines
        ///<summary>Target skeleton for this blueprint class</summary>
        public unsafe Skeleton TargetSkeleton {
            get {return AnimBlueprintGeneratedClass_ptr->TargetSkeleton;}
            set {AnimBlueprintGeneratedClass_ptr->TargetSkeleton = value;}
        }
         //TODO: array not UObject TArray AnimNotifies
        ///<summary>The index of the root node in the animation tree</summary>
        public unsafe int RootAnimNodeIndex {
            get {return AnimBlueprintGeneratedClass_ptr->RootAnimNodeIndex;}
            set {AnimBlueprintGeneratedClass_ptr->RootAnimNodeIndex = value;}
        }
         //TODO: array not UObject TArray OrderedSavedPoseIndices
         //TODO: array not UObject TArray SyncGroupNames
        static AnimBlueprintGeneratedClass() {
            StaticClass = Main.GetClass("AnimBlueprintGeneratedClass");
        }
        internal unsafe AnimBlueprintGeneratedClass_fields* AnimBlueprintGeneratedClass_ptr => (AnimBlueprintGeneratedClass_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimBlueprintGeneratedClass(IntPtr p) => UObject.Make<AnimBlueprintGeneratedClass>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimBlueprintGeneratedClass DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimBlueprintGeneratedClass New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
