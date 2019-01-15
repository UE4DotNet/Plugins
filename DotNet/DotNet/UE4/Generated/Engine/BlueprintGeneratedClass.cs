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
    ///<summary>Blueprint Generated Class</summary>
    public unsafe partial class BlueprintGeneratedClass : Class  {
        ///<summary>Num Replicated Properties</summary>
        public unsafe int NumReplicatedProperties {
            get {return BlueprintGeneratedClass_ptr->NumReplicatedProperties;}
            set {BlueprintGeneratedClass_ptr->NumReplicatedProperties = value;}
        }
        public bool bHasNativizedParent {
            get {return Main.GetGetBoolPropertyByName(this, "bHasNativizedParent"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasNativizedParent", value); }
        }
        ///<summary>Array of objects containing information for dynamically binding delegates to functions in this blueprint</summary>
        public ObjectArrayField<DynamicBlueprintBinding> DynamicBindingObjects{ get {
            if(DynamicBindingObjects_store == null) DynamicBindingObjects_store = new ObjectArrayField<DynamicBlueprintBinding> (&BlueprintGeneratedClass_ptr->DynamicBindingObjects);
            return DynamicBindingObjects_store;
        } }
        private ObjectArrayField<DynamicBlueprintBinding> DynamicBindingObjects_store;

        ///<summary>Array of component template objects, used by AddComponent function</summary>
        public ObjectArrayField<ActorComponent> ComponentTemplates{ get {
            if(ComponentTemplates_store == null) ComponentTemplates_store = new ObjectArrayField<ActorComponent> (&BlueprintGeneratedClass_ptr->ComponentTemplates);
            return ComponentTemplates_store;
        } }
        private ObjectArrayField<ActorComponent> ComponentTemplates_store;

        ///<summary>Array of templates for timelines that should be created</summary>
        public ObjectArrayField<TimelineTemplate> Timelines{ get {
            if(Timelines_store == null) Timelines_store = new ObjectArrayField<TimelineTemplate> (&BlueprintGeneratedClass_ptr->Timelines);
            return Timelines_store;
        } }
        private ObjectArrayField<TimelineTemplate> Timelines_store;

        ///<summary>'Simple' construction script - graph of components to instance</summary>
        public unsafe SimpleConstructionScript SimpleConstructionScript {
            get {return BlueprintGeneratedClass_ptr->SimpleConstructionScript;}
            set {BlueprintGeneratedClass_ptr->SimpleConstructionScript = value;}
        }
        ///<summary>Stores data to override (in children classes) components (created by SCS) from parent classes</summary>
        public unsafe InheritableComponentHandler InheritableComponentHandler {
            get {return BlueprintGeneratedClass_ptr->InheritableComponentHandler;}
            set {BlueprintGeneratedClass_ptr->InheritableComponentHandler = value;}
        }
        ///<summary>Uber Graph Frame Pointer Property</summary>
        public unsafe StructProperty UberGraphFramePointerProperty {
            get {return BlueprintGeneratedClass_ptr->UberGraphFramePointerProperty;}
            set {BlueprintGeneratedClass_ptr->UberGraphFramePointerProperty = value;}
        }
        ///<summary>Uber Graph Function</summary>
        public unsafe Function UberGraphFunction {
            get {return BlueprintGeneratedClass_ptr->UberGraphFunction;}
            set {BlueprintGeneratedClass_ptr->UberGraphFunction = value;}
        }
        ///<summary>Overriden Archetype for CDO</summary>
        public unsafe UObject OverridenArchetypeForCDO {
            get {return BlueprintGeneratedClass_ptr->OverridenArchetypeForCDO;}
            set {BlueprintGeneratedClass_ptr->OverridenArchetypeForCDO = value;}
        }
         //TODO: map TMap PropertyGuids
         //TODO: map TMap CookedComponentInstancingData
        static BlueprintGeneratedClass() {
            StaticClass = Main.GetClass("BlueprintGeneratedClass");
        }
        internal unsafe BlueprintGeneratedClass_fields* BlueprintGeneratedClass_ptr => (BlueprintGeneratedClass_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintGeneratedClass(IntPtr p) => UObject.Make<BlueprintGeneratedClass>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintGeneratedClass DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintGeneratedClass New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
