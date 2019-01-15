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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Anim Blueprint Factory</summary>
    public unsafe partial class AnimBlueprintFactory : Factory  {
        ///<summary>The type of blueprint that will be created</summary>
        public unsafe byte BlueprintType {
            get {return AnimBlueprintFactory_ptr->BlueprintType;}
            set {AnimBlueprintFactory_ptr->BlueprintType = value;}
        }
        ///<summary>The parent class of the created blueprint</summary>
        public unsafe SubclassOf<AnimInstance> ParentClass {
            get {return AnimBlueprintFactory_ptr->ParentClass;}
            set {AnimBlueprintFactory_ptr->ParentClass = value;}
        }
        ///<summary>The kind of skeleton that animation graphs compiled from the blueprint will animate</summary>
        public unsafe Skeleton TargetSkeleton {
            get {return AnimBlueprintFactory_ptr->TargetSkeleton;}
            set {AnimBlueprintFactory_ptr->TargetSkeleton = value;}
        }
        ///<summary>The preview mesh to use with this animation blueprint</summary>
        public unsafe SkeletalMesh PreviewSkeletalMesh {
            get {return AnimBlueprintFactory_ptr->PreviewSkeletalMesh;}
            set {AnimBlueprintFactory_ptr->PreviewSkeletalMesh = value;}
        }
        static AnimBlueprintFactory() {
            StaticClass = Main.GetClass("AnimBlueprintFactory");
        }
        internal unsafe AnimBlueprintFactory_fields* AnimBlueprintFactory_ptr => (AnimBlueprintFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimBlueprintFactory(IntPtr p) => UObject.Make<AnimBlueprintFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimBlueprintFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimBlueprintFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
