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

namespace UE4.AIModule {
    ///<summary>RunBehavior task allows pushing subtrees on execution stack.</summary>
    ///<remarks>
    ///Subtree asset can't be changed in runtime!
    ///
    ///This limitation is caused by support for subtree's root level decorators,
    ///which are injected into parent tree, and structure of running tree
    ///cannot be modified in runtime (see: BTNode: ExecutionIndex, MemoryOffset)
    ///
    ///Use RunBehaviorDynamic task for subtrees that need to be changed in runtime.
    ///</remarks>
    public unsafe partial class BTTask_RunBehavior : BTTaskNode  {
        ///<summary>behavior to run</summary>
        public unsafe BehaviorTree BehaviorAsset {
            get {return BTTask_RunBehavior_ptr->BehaviorAsset;}
            set {BTTask_RunBehavior_ptr->BehaviorAsset = value;}
        }
        static BTTask_RunBehavior() {
            StaticClass = Main.GetClass("BTTask_RunBehavior");
        }
        internal unsafe BTTask_RunBehavior_fields* BTTask_RunBehavior_ptr => (BTTask_RunBehavior_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_RunBehavior(IntPtr p) => UObject.Make<BTTask_RunBehavior>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_RunBehavior DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_RunBehavior New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
