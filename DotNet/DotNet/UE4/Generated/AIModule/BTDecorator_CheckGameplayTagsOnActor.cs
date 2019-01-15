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
using UE4.AIModule.Native;
using UE4.GameplayTags;

namespace UE4.AIModule {
    ///<summary>GameplayTag decorator node.</summary>
    ///<remarks>
    ///A decorator node that bases its condition on whether the specified Actor (in the blackboard) has a Gameplay Tag or
    ///Tags specified.
    ///</remarks>
    public unsafe partial class BTDecorator_CheckGameplayTagsOnActor : BTDecorator  {
        ///<summary>Actor to Check</summary>
        public unsafe BlackboardKeySelector ActorToCheck {
            get {return BTDecorator_CheckGameplayTagsOnActor_ptr->ActorToCheck;}
            set {BTDecorator_CheckGameplayTagsOnActor_ptr->ActorToCheck = value;}
        }
         //TODO: enum EGameplayContainerMatchType TagsToMatch
        ///<summary>Gameplay Tags</summary>
        public unsafe GameplayTagContainer GameplayTags {
            get {return BTDecorator_CheckGameplayTagsOnActor_ptr->GameplayTags;}
            set {BTDecorator_CheckGameplayTagsOnActor_ptr->GameplayTags = value;}
        }
         //TODO: string FString CachedDescription
        static BTDecorator_CheckGameplayTagsOnActor() {
            StaticClass = Main.GetClass("BTDecorator_CheckGameplayTagsOnActor");
        }
        internal unsafe BTDecorator_CheckGameplayTagsOnActor_fields* BTDecorator_CheckGameplayTagsOnActor_ptr => (BTDecorator_CheckGameplayTagsOnActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_CheckGameplayTagsOnActor(IntPtr p) => UObject.Make<BTDecorator_CheckGameplayTagsOnActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_CheckGameplayTagsOnActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_CheckGameplayTagsOnActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
