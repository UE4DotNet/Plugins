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
    ///Auxiliary nodes are supporting nodes, that receive notification about execution flow and can be ticked
    ///Because some of them can be instanced for specific AI, following virtual functions are not marked as const:
    /// - OnBecomeRelevant
    /// - OnCeaseRelevant
    /// - TickNode
    ///If your node is not being instanced (default behavior), DO NOT change any properties of object within those functions!
    ///Template nodes are shared across all behavior tree components using the same tree asset and must store
    ///</summary>
    ///<remarks>their runtime properties in provided NodeMemory block (allocation size determined by GetInstanceMemorySize() )</remarks>
    public unsafe partial class BTAuxiliaryNode : BTNode  {
        static BTAuxiliaryNode() {
            StaticClass = Main.GetClass("BTAuxiliaryNode");
        }
        internal unsafe BTAuxiliaryNode_fields* BTAuxiliaryNode_ptr => (BTAuxiliaryNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTAuxiliaryNode(IntPtr p) => UObject.Make<BTAuxiliaryNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTAuxiliaryNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTAuxiliaryNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
