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
    ///<summary>
    ///Task are leaf nodes of behavior tree, which perform actual actions
    ///Because some of them can be instanced for specific AI, following virtual functions are not marked as const:
    /// - ExecuteTask
    /// - AbortTask
    /// - TickTask
    /// - OnMessage
    ///If your node is not being instanced (default behavior), DO NOT change any properties of object within those functions!
    ///Template nodes are shared across all behavior tree components using the same tree asset and must store
    ///</summary>
    ///<remarks>their runtime properties in provided NodeMemory block (allocation size determined by GetInstanceMemorySize() )</remarks>
    public unsafe partial class BTTaskNode : BTNode  {
        ///<summary>service nodes</summary>
        public ObjectArrayField<BTService> Services{ get {
            if(Services_store == null) Services_store = new ObjectArrayField<BTService> (&BTTaskNode_ptr->Services);
            return Services_store;
        } }
        private ObjectArrayField<BTService> Services_store;

        public bool bIgnoreRestartSelf {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreRestartSelf"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreRestartSelf", value); }
        }
        static BTTaskNode() {
            StaticClass = Main.GetClass("BTTaskNode");
        }
        internal unsafe BTTaskNode_fields* BTTaskNode_ptr => (BTTaskNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTaskNode(IntPtr p) => UObject.Make<BTTaskNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTaskNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTaskNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
