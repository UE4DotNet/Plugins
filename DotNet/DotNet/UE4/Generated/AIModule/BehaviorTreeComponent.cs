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
    ///<summary>Behavior Tree Component</summary>
    public unsafe partial class BehaviorTreeComponent : BrainComponent  {

        ///<summary>add to the cooldown tag's duration</summary>
        public void AddCooldownTagDuration(GameplayTag CooldownTag, float CooldownDuration, bool bAddToExistingDuration)  => 
            BehaviorTreeComponent_methods.AddCooldownTagDuration_method.Invoke(ObjPointer, CooldownTag, CooldownDuration, bAddToExistingDuration);

        ///<summary>@return the cooldown tag end time, 0.0f if CooldownTag is not found</summary>
        public float GetTagCooldownEndTime(GameplayTag CooldownTag)  => 
            BehaviorTreeComponent_methods.GetTagCooldownEndTime_method.Invoke(ObjPointer, CooldownTag);

        ///<summary>assign subtree to RunBehaviorDynamic task specified by tag</summary>
        public void SetDynamicSubtree(GameplayTag InjectTag, BehaviorTree BehaviorAsset)  => 
            BehaviorTreeComponent_methods.SetDynamicSubtree_method.Invoke(ObjPointer, InjectTag, BehaviorAsset);
        ///<summary>instanced nodes</summary>
        public ObjectArrayField<BTNode> NodeInstances{ get {
            if(NodeInstances_store == null) NodeInstances_store = new ObjectArrayField<BTNode> (&BehaviorTreeComponent_ptr->NodeInstances);
            return NodeInstances_store;
        } }
        private ObjectArrayField<BTNode> NodeInstances_store;

        static BehaviorTreeComponent() {
            StaticClass = Main.GetClass("BehaviorTreeComponent");
        }
        internal unsafe BehaviorTreeComponent_fields* BehaviorTreeComponent_ptr => (BehaviorTreeComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BehaviorTreeComponent(IntPtr p) => UObject.Make<BehaviorTreeComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BehaviorTreeComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BehaviorTreeComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
