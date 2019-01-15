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
using UE4.Landscape.Native;
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Landscape Heightfield Collision Component</summary>
    public unsafe partial class LandscapeHeightfieldCollisionComponent : PrimitiveComponent  {
        ///<summary>List of layers painted on this component. Matches the WeightmapLayerAllocations array in the LandscapeComponent.</summary>
        public ObjectArrayField<LandscapeLayerInfoObject> ComponentLayerInfos{ get {
            if(ComponentLayerInfos_store == null) ComponentLayerInfos_store = new ObjectArrayField<LandscapeLayerInfoObject> (&LandscapeHeightfieldCollisionComponent_ptr->ComponentLayerInfos);
            return ComponentLayerInfos_store;
        } }
        private ObjectArrayField<LandscapeLayerInfoObject> ComponentLayerInfos_store;

        ///<summary>Offset of component in landscape quads</summary>
        public unsafe int SectionBaseX {
            get {return LandscapeHeightfieldCollisionComponent_ptr->SectionBaseX;}
            set {LandscapeHeightfieldCollisionComponent_ptr->SectionBaseX = value;}
        }
        ///<summary>Section Base Y</summary>
        public unsafe int SectionBaseY {
            get {return LandscapeHeightfieldCollisionComponent_ptr->SectionBaseY;}
            set {LandscapeHeightfieldCollisionComponent_ptr->SectionBaseY = value;}
        }
        ///<summary>Size of component in collision quads</summary>
        public unsafe int CollisionSizeQuads {
            get {return LandscapeHeightfieldCollisionComponent_ptr->CollisionSizeQuads;}
            set {LandscapeHeightfieldCollisionComponent_ptr->CollisionSizeQuads = value;}
        }
        ///<summary>Collision scale: (ComponentSizeQuads) / (CollisionSizeQuads)</summary>
        public unsafe float CollisionScale {
            get {return LandscapeHeightfieldCollisionComponent_ptr->CollisionScale;}
            set {LandscapeHeightfieldCollisionComponent_ptr->CollisionScale = value;}
        }
        ///<summary>Size of component's "simple collision" in collision quads</summary>
        public unsafe int SimpleCollisionSizeQuads {
            get {return LandscapeHeightfieldCollisionComponent_ptr->SimpleCollisionSizeQuads;}
            set {LandscapeHeightfieldCollisionComponent_ptr->SimpleCollisionSizeQuads = value;}
        }
         //TODO: array not UObject TArray CollisionQuadFlags
        ///<summary>Guid used to share PhysX heightfield objects in the editor</summary>
        public unsafe FGuid HeightfieldGuid {
            get {return LandscapeHeightfieldCollisionComponent_ptr->HeightfieldGuid;}
            set {LandscapeHeightfieldCollisionComponent_ptr->HeightfieldGuid = value;}
        }
        ///<summary>Cached local-space bounding box, created at heightmap update time</summary>
        public unsafe Box CachedLocalBox {
            get {return LandscapeHeightfieldCollisionComponent_ptr->CachedLocalBox;}
            set {LandscapeHeightfieldCollisionComponent_ptr->CachedLocalBox = value;}
        }
         //TODO: lazy object TLazyObjectPtr<ULandscapeComponent> RenderComponent
        ///<summary>This is a list of physical materials that is actually used by a cooked HeightField</summary>
        public ObjectArrayField<PhysicalMaterial> CookedPhysicalMaterials{ get {
            if(CookedPhysicalMaterials_store == null) CookedPhysicalMaterials_store = new ObjectArrayField<PhysicalMaterial> (&LandscapeHeightfieldCollisionComponent_ptr->CookedPhysicalMaterials);
            return CookedPhysicalMaterials_store;
        } }
        private ObjectArrayField<PhysicalMaterial> CookedPhysicalMaterials_store;

        static LandscapeHeightfieldCollisionComponent() {
            StaticClass = Main.GetClass("LandscapeHeightfieldCollisionComponent");
        }
        internal unsafe LandscapeHeightfieldCollisionComponent_fields* LandscapeHeightfieldCollisionComponent_ptr => (LandscapeHeightfieldCollisionComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeHeightfieldCollisionComponent(IntPtr p) => UObject.Make<LandscapeHeightfieldCollisionComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeHeightfieldCollisionComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeHeightfieldCollisionComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
