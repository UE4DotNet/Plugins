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
    ///<summary>Hierarchical Instanced Static Mesh Component</summary>
    public unsafe partial class HierarchicalInstancedStaticMeshComponent : InstancedStaticMeshComponent  {

        ///<summary>Removes all the instances with indices specified in the InstancesToRemove array. Returns true on success.</summary>
        public bool RemoveInstances(byte InstancesToRemove /*TODO: array TArray */)  => 
            HierarchicalInstancedStaticMeshComponent_methods.RemoveInstances_method.Invoke(ObjPointer, InstancesToRemove);
         //TODO: array not UObject TArray SortedInstances
        ///<summary>The number of instances in the ClusterTree. Subsequent instances will always be rendered.</summary>
        public unsafe int NumBuiltInstances {
            get {return HierarchicalInstancedStaticMeshComponent_ptr->NumBuiltInstances;}
            set {HierarchicalInstancedStaticMeshComponent_ptr->NumBuiltInstances = value;}
        }
        ///<summary>Bounding box of any built instances (cached from the ClusterTree)</summary>
        public unsafe Box BuiltInstanceBounds {
            get {return HierarchicalInstancedStaticMeshComponent_ptr->BuiltInstanceBounds;}
            set {HierarchicalInstancedStaticMeshComponent_ptr->BuiltInstanceBounds = value;}
        }
        ///<summary>Bounding box of any unbuilt instances</summary>
        public unsafe Box UnbuiltInstanceBounds {
            get {return HierarchicalInstancedStaticMeshComponent_ptr->UnbuiltInstanceBounds;}
            set {HierarchicalInstancedStaticMeshComponent_ptr->UnbuiltInstanceBounds = value;}
        }
         //TODO: array not UObject TArray UnbuiltInstanceBoundsList
        public bool bEnableDensityScaling {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableDensityScaling"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableDensityScaling", value); }
        }
        ///<summary>The number of nodes in the occlusion layer</summary>
        public unsafe int OcclusionLayerNumNodes {
            get {return HierarchicalInstancedStaticMeshComponent_ptr->OcclusionLayerNumNodes;}
            set {HierarchicalInstancedStaticMeshComponent_ptr->OcclusionLayerNumNodes = value;}
        }
        ///<summary>The last mesh bounds that was cache</summary>
        public unsafe BoxSphereBounds CacheMeshExtendedBounds {
            get {return HierarchicalInstancedStaticMeshComponent_ptr->CacheMeshExtendedBounds;}
            set {HierarchicalInstancedStaticMeshComponent_ptr->CacheMeshExtendedBounds = value;}
        }
        public bool bDisableCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableCollision", value); }
        }
        ///<summary>Instances to render (including removed one until the build is complete)</summary>
        public unsafe int InstanceCountToRender {
            get {return HierarchicalInstancedStaticMeshComponent_ptr->InstanceCountToRender;}
            set {HierarchicalInstancedStaticMeshComponent_ptr->InstanceCountToRender = value;}
        }
        static HierarchicalInstancedStaticMeshComponent() {
            StaticClass = Main.GetClass("HierarchicalInstancedStaticMeshComponent");
        }
        internal unsafe HierarchicalInstancedStaticMeshComponent_fields* HierarchicalInstancedStaticMeshComponent_ptr => (HierarchicalInstancedStaticMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HierarchicalInstancedStaticMeshComponent(IntPtr p) => UObject.Make<HierarchicalInstancedStaticMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HierarchicalInstancedStaticMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HierarchicalInstancedStaticMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
