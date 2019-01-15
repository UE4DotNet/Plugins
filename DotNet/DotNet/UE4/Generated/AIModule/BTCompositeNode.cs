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
    ///<summary>BTComposite Node</summary>
    public unsafe partial class BTCompositeNode : BTNode  {
         //TODO: array not UObject TArray Children
        ///<summary>service nodes</summary>
        public ObjectArrayField<BTService> Services{ get {
            if(Services_store == null) Services_store = new ObjectArrayField<BTService> (&BTCompositeNode_ptr->Services);
            return Services_store;
        } }
        private ObjectArrayField<BTService> Services_store;

        public bool bApplyDecoratorScope {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyDecoratorScope"); }
            set {Main.SetGetBoolPropertyByName(this, "bApplyDecoratorScope", value); }
        }
        static BTCompositeNode() {
            StaticClass = Main.GetClass("BTCompositeNode");
        }
        internal unsafe BTCompositeNode_fields* BTCompositeNode_ptr => (BTCompositeNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTCompositeNode(IntPtr p) => UObject.Make<BTCompositeNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTCompositeNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTCompositeNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
