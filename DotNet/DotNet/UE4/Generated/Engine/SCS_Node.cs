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
    ///<summary>SCS Node</summary>
    public unsafe partial class SCS_Node : UObject  {
        ///<summary>Component class</summary>
        public unsafe SubclassOf<UObject> ComponentClass {
            get {return SCS_Node_ptr->ComponentClass;}
            set {SCS_Node_ptr->ComponentClass = value;}
        }
        ///<summary>Template for the component to create</summary>
        public unsafe ActorComponent ComponentTemplate {
            get {return SCS_Node_ptr->ComponentTemplate;}
            set {SCS_Node_ptr->ComponentTemplate = value;}
        }
        ///<summary>Cached data for faster runtime instancing (only used in cooked builds)</summary>
        public unsafe BlueprintCookedComponentInstancingData CookedComponentInstancingData {
            get {return SCS_Node_ptr->CookedComponentInstancingData;}
            set {SCS_Node_ptr->CookedComponentInstancingData = value;}
        }
        ///<summary>Variable Name</summary>
        public unsafe Name VariableName {
            get {return SCS_Node_ptr->VariableName;}
            set {SCS_Node_ptr->VariableName = value;}
        }
         //TODO: text FText CategoryName
        ///<summary>Socket/Bone that Node might attach to</summary>
        public unsafe Name AttachToName {
            get {return SCS_Node_ptr->AttachToName;}
            set {SCS_Node_ptr->AttachToName = value;}
        }
        ///<summary>Component template or variable that Node might be parented to</summary>
        public unsafe Name ParentComponentOrVariableName {
            get {return SCS_Node_ptr->ParentComponentOrVariableName;}
            set {SCS_Node_ptr->ParentComponentOrVariableName = value;}
        }
        ///<summary>If the node is attached to another node inherited from a parent Blueprint, this contains the name of the Blueprint parent class that owns the component template //@TODO: We can potentially remove this if/when inherited SCS component template instances are included in subobject serialization, as we could then infer that the owner class is always the same as the BP class.</summary>
        public unsafe Name ParentComponentOwnerClassName {
            get {return SCS_Node_ptr->ParentComponentOwnerClassName;}
            set {SCS_Node_ptr->ParentComponentOwnerClassName = value;}
        }
        public bool bIsParentComponentNative {
            get {return Main.GetGetBoolPropertyByName(this, "bIsParentComponentNative"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsParentComponentNative", value); }
        }
        ///<summary>Set of child nodes</summary>
        public ObjectArrayField<SCS_Node> ChildNodes{ get {
            if(ChildNodes_store == null) ChildNodes_store = new ObjectArrayField<SCS_Node> (&SCS_Node_ptr->ChildNodes);
            return ChildNodes_store;
        } }
        private ObjectArrayField<SCS_Node> ChildNodes_store;

         //TODO: array not UObject TArray MetaDataArray
        ///<summary>Variable Guid</summary>
        public unsafe FGuid VariableGuid {
            get {return SCS_Node_ptr->VariableGuid;}
            set {SCS_Node_ptr->VariableGuid = value;}
        }
        ///<summary>Internal variable name.</summary>
        ///<remarks>
        ///This is used for:
        ///                      a) Generating the component template (archetype) object name.
        ///                      b) A UObjectProperty in the generated Blueprint class. This holds a reference to the component instance created at Actor construction time.
        ///                      c) Archetype lookup through the generated Blueprint class. All instances route back to the archetype through the variable name (i.e. not the template name).
        ///</remarks>
        public unsafe Name InternalVariableName {
            get {return SCS_Node_ptr->InternalVariableName;}
            set {SCS_Node_ptr->InternalVariableName = value;}
        }
        static SCS_Node() {
            StaticClass = Main.GetClass("SCS_Node");
        }
        internal unsafe SCS_Node_fields* SCS_Node_ptr => (SCS_Node_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SCS_Node(IntPtr p) => UObject.Make<SCS_Node>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SCS_Node DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SCS_Node New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
