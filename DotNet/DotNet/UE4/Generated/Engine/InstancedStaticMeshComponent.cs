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
    ///<summary>A component that efficiently renders multiple instances of the same StaticMesh.</summary>
    public unsafe partial class InstancedStaticMeshComponent : StaticMeshComponent  {

        ///<summary>Add an instance to this component. Transform is given in local space of this component.</summary>
        public int AddInstance(Transform InstanceTransform)  => 
            InstancedStaticMeshComponent_methods.AddInstance_method.Invoke(ObjPointer, InstanceTransform);

        ///<summary>Add an instance to this component. Transform is given in world space.</summary>
        public int AddInstanceWorldSpace(Transform WorldTransform)  => 
            InstancedStaticMeshComponent_methods.AddInstanceWorldSpace_method.Invoke(ObjPointer, WorldTransform);

        ///<summary>Clear all instances being rendered by this component.</summary>
        public void ClearInstances()  => 
            InstancedStaticMeshComponent_methods.ClearInstances_method.Invoke(ObjPointer);

        ///<summary>Get the number of instances in this component.</summary>
        public int GetInstanceCount()  => 
            InstancedStaticMeshComponent_methods.GetInstanceCount_method.Invoke(ObjPointer);

        ///<summary>Returns the instances with instance bounds overlapping the specified box. The return value is an array of instance indices.</summary>
        public IReadOnlyCollection<int> GetInstancesOverlappingBox(Box Box, bool bBoxInWorldSpace)  => 
            InstancedStaticMeshComponent_methods.GetInstancesOverlappingBox_method.Invoke(ObjPointer, Box, bBoxInWorldSpace);

        ///<summary>Returns the instances with instance bounds overlapping the specified sphere. The return value is an array of instance indices.</summary>
        public IReadOnlyCollection<int> GetInstancesOverlappingSphere(Vector Center, float Radius, bool bSphereInWorldSpace)  => 
            InstancedStaticMeshComponent_methods.GetInstancesOverlappingSphere_method.Invoke(ObjPointer, Center, Radius, bSphereInWorldSpace);

        ///<summary>Get the transform for the instance specified. Instance is returned in local space of this component unless bWorldSpace is set.  Returns True on success.</summary>
        public (Transform, bool) GetInstanceTransform(int InstanceIndex, bool bWorldSpace)  => 
            InstancedStaticMeshComponent_methods.GetInstanceTransform_method.Invoke(ObjPointer, InstanceIndex, bWorldSpace);

        ///<summary>Remove the instance specified. Returns True on success. Note that this will leave the array in order, but may shrink it.</summary>
        public bool RemoveInstance(int InstanceIndex)  => 
            InstancedStaticMeshComponent_methods.RemoveInstance_method.Invoke(ObjPointer, InstanceIndex);

        ///<summary>Sets the fading start and culling end distances for this component.</summary>
        public void SetCullDistances(int StartCullDistance, int EndCullDistance)  => 
            InstancedStaticMeshComponent_methods.SetCullDistances_method.Invoke(ObjPointer, StartCullDistance, EndCullDistance);

        ///<summary>Update the transform for the instance specified.</summary>
        ///<remarks>
        ///@param InstanceIndex                  The index of the instance to update
        ///@param NewInstanceTransform   The new transform
        ///@param bWorldSpace                    If true, the new transform interpreted as a World Space transform, otherwise it is interpreted as Local Space
        ///@param bMarkRenderStateDirty  If true, the change should be visible immediately. If you are updating many instances you should only set this to true for the last instance.
        ///@param bTeleport                              Whether or not the instance's physics should be moved normally, or teleported (moved instantly, ignoring velocity).
        ///@return                                               True on success.
        ///</remarks>
        public bool UpdateInstanceTransform(int InstanceIndex, Transform NewInstanceTransform, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport)  => 
            InstancedStaticMeshComponent_methods.UpdateInstanceTransform_method.Invoke(ObjPointer, InstanceIndex, NewInstanceTransform, bWorldSpace, bMarkRenderStateDirty, bTeleport);
         //TODO: array not UObject TArray PerInstanceSMData
        ///<summary>Value used to seed the random number stream that generates random numbers for each of this mesh's instances.</summary>
        ///<remarks>
        ///The random number is stored in a buffer accessible to materials through the PerInstanceRandom expression. If
        ///      this is set to zero (default), it will be populated automatically by the editor.
        ///</remarks>
        public unsafe int InstancingRandomSeed {
            get {return InstancedStaticMeshComponent_ptr->InstancingRandomSeed;}
            set {InstancedStaticMeshComponent_ptr->InstancingRandomSeed = value;}
        }
        ///<summary>Distance from camera at which each instance begins to fade out.</summary>
        public unsafe int InstanceStartCullDistance {
            get {return InstancedStaticMeshComponent_ptr->InstanceStartCullDistance;}
        }
        ///<summary>Distance from camera at which each instance completely fades out.</summary>
        public unsafe int InstanceEndCullDistance {
            get {return InstancedStaticMeshComponent_ptr->InstanceEndCullDistance;}
        }
         //TODO: array not UObject TArray InstanceReorderTable
        ///<summary>Number of pending lightmaps still to be calculated (Apply()'d).</summary>
        public unsafe int NumPendingLightmaps {
            get {return InstancedStaticMeshComponent_ptr->NumPendingLightmaps;}
            set {InstancedStaticMeshComponent_ptr->NumPendingLightmaps = value;}
        }
         //TODO: array not UObject TArray CachedMappings
        static InstancedStaticMeshComponent() {
            StaticClass = Main.GetClass("InstancedStaticMeshComponent");
        }
        internal unsafe InstancedStaticMeshComponent_fields* InstancedStaticMeshComponent_ptr => (InstancedStaticMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InstancedStaticMeshComponent(IntPtr p) => UObject.Make<InstancedStaticMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InstancedStaticMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InstancedStaticMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
