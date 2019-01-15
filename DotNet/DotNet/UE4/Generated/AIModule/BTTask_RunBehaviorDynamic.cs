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
    ///<summary>RunBehaviorDynamic task allows pushing subtrees on execution stack.</summary>
    ///<remarks>
    ///Subtree asset can be assigned at runtime with SetDynamicSubtree function of BehaviorTreeComponent.
    ///
    ///Does NOT support subtree's root level decorators!
    ///</remarks>
    public unsafe partial class BTTask_RunBehaviorDynamic : BTTaskNode  {
        ///<summary>Gameplay tag that will identify this task for subtree injection</summary>
        public unsafe GameplayTag InjectionTag {
            get {return BTTask_RunBehaviorDynamic_ptr->InjectionTag;}
            set {BTTask_RunBehaviorDynamic_ptr->InjectionTag = value;}
        }
        ///<summary>default behavior to run</summary>
        public unsafe BehaviorTree DefaultBehaviorAsset {
            get {return BTTask_RunBehaviorDynamic_ptr->DefaultBehaviorAsset;}
            set {BTTask_RunBehaviorDynamic_ptr->DefaultBehaviorAsset = value;}
        }
        ///<summary>current subtree</summary>
        public unsafe BehaviorTree BehaviorAsset {
            get {return BTTask_RunBehaviorDynamic_ptr->BehaviorAsset;}
            set {BTTask_RunBehaviorDynamic_ptr->BehaviorAsset = value;}
        }
        static BTTask_RunBehaviorDynamic() {
            StaticClass = Main.GetClass("BTTask_RunBehaviorDynamic");
        }
        internal unsafe BTTask_RunBehaviorDynamic_fields* BTTask_RunBehaviorDynamic_ptr => (BTTask_RunBehaviorDynamic_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_RunBehaviorDynamic(IntPtr p) => UObject.Make<BTTask_RunBehaviorDynamic>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_RunBehaviorDynamic DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_RunBehaviorDynamic New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
