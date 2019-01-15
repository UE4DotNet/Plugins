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
using UE4.Paper2D.Native;
using UE4.Engine;

namespace UE4.Paper2D {
    ///<summary>A component that handles rendering and collision for many instances of one or more UPaperSprite assets.</summary>
    ///<remarks>
    ///@see UPrimitiveComponent, UPaperSprite
    ///</remarks>
    public unsafe partial class PaperGroupedSpriteComponent : MeshComponent  {

        ///<summary>Add an instance to this component. Transform can be given either in the local space of this component or world space.</summary>
        public int AddInstance(Transform Transform, PaperSprite Sprite, bool bWorldSpace, LinearColor Color)  => 
            PaperGroupedSpriteComponent_methods.AddInstance_method.Invoke(ObjPointer, Transform, Sprite, bWorldSpace, Color);

        ///<summary>Clear all instances being rendered by this component</summary>
        public void ClearInstances()  => 
            PaperGroupedSpriteComponent_methods.ClearInstances_method.Invoke(ObjPointer);

        ///<summary>Get the number of instances in this component</summary>
        public int GetInstanceCount()  => 
            PaperGroupedSpriteComponent_methods.GetInstanceCount_method.Invoke(ObjPointer);

        ///<summary>Get the transform for the instance specified. Instance is returned in local space of this component unless bWorldSpace is set.  Returns True on success.</summary>
        public (Transform, bool) GetInstanceTransform(int InstanceIndex, bool bWorldSpace)  => 
            PaperGroupedSpriteComponent_methods.GetInstanceTransform_method.Invoke(ObjPointer, InstanceIndex, bWorldSpace);

        ///<summary>Remove the instance specified. Returns True on success.</summary>
        public bool RemoveInstance(int InstanceIndex)  => 
            PaperGroupedSpriteComponent_methods.RemoveInstance_method.Invoke(ObjPointer, InstanceIndex);

        ///<summary>Sort all instances by their world space position along the specified axis</summary>
        public void SortInstancesAlongAxis(Vector WorldSpaceSortAxis)  => 
            PaperGroupedSpriteComponent_methods.SortInstancesAlongAxis_method.Invoke(ObjPointer, WorldSpaceSortAxis);

        ///<summary>Update the color for the instance specified. Returns True on success.</summary>
        public bool UpdateInstanceColor(int InstanceIndex, LinearColor NewInstanceColor, bool bMarkRenderStateDirty)  => 
            PaperGroupedSpriteComponent_methods.UpdateInstanceColor_method.Invoke(ObjPointer, InstanceIndex, NewInstanceColor, bMarkRenderStateDirty);

        ///<summary>Update the transform for the instance specified. Instance is given in local space of this component unless bWorldSpace is set.  Returns True on success.</summary>
        public bool UpdateInstanceTransform(int InstanceIndex, Transform NewInstanceTransform, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport)  => 
            PaperGroupedSpriteComponent_methods.UpdateInstanceTransform_method.Invoke(ObjPointer, InstanceIndex, NewInstanceTransform, bWorldSpace, bMarkRenderStateDirty, bTeleport);
        ///<summary>Array of materials used by the instances</summary>
        public ObjectArrayField<MaterialInterface> InstanceMaterials{ get {
            if(InstanceMaterials_store == null) InstanceMaterials_store = new ObjectArrayField<MaterialInterface> (&PaperGroupedSpriteComponent_ptr->InstanceMaterials);
            return InstanceMaterials_store;
        } }
        private ObjectArrayField<MaterialInterface> InstanceMaterials_store;

         //TODO: array not UObject TArray PerInstanceSpriteData
        static PaperGroupedSpriteComponent() {
            StaticClass = Main.GetClass("PaperGroupedSpriteComponent");
        }
        internal unsafe PaperGroupedSpriteComponent_fields* PaperGroupedSpriteComponent_ptr => (PaperGroupedSpriteComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperGroupedSpriteComponent(IntPtr p) => UObject.Make<PaperGroupedSpriteComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperGroupedSpriteComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperGroupedSpriteComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
