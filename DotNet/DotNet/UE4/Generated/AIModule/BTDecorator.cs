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
    ///Decorators are supporting nodes placed on parent-child connection, that receive notification about execution flow and can be ticked
    ///Because some of them can be instanced for specific AI, following virtual functions are not marked as const:
    /// - OnNodeActivation
    /// - OnNodeDeactivation
    /// - OnNodeProcessed
    /// - OnBecomeRelevant (from UBTAuxiliaryNode)
    /// - OnCeaseRelevant (from UBTAuxiliaryNode)
    /// - TickNode (from UBTAuxiliaryNode)
    ///If your node is not being instanced (default behavior), DO NOT change any properties of object within those functions!
    ///Template nodes are shared across all behavior tree components using the same tree asset and must store
    ///</summary>
    ///<remarks>their runtime properties in provided NodeMemory block (allocation size determined by GetInstanceMemorySize() )</remarks>
    public unsafe partial class BTDecorator : BTAuxiliaryNode  {
        public bool bInverseCondition {
            get {return Main.GetGetBoolPropertyByName(this, "bInverseCondition"); }
            set {Main.SetGetBoolPropertyByName(this, "bInverseCondition", value); }
        }
        ///<summary>flow controller settings</summary>
        public unsafe byte FlowAbortMode {
            get {return BTDecorator_ptr->FlowAbortMode;}
            set {BTDecorator_ptr->FlowAbortMode = value;}
        }
        static BTDecorator() {
            StaticClass = Main.GetClass("BTDecorator");
        }
        internal unsafe BTDecorator_fields* BTDecorator_ptr => (BTDecorator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator(IntPtr p) => UObject.Make<BTDecorator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
