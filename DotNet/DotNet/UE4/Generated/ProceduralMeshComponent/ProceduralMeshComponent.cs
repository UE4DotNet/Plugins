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
using UE4.ProceduralMeshComponent.Native;
using UE4.Engine;

namespace UE4.ProceduralMeshComponent {
    ///<summary>
    ///Component that allows you to specify custom triangle mesh geometry
    ///Beware! This feature is experimental and may be substantially changed in future releases.
    ///</summary>
    public unsafe partial class ProceduralMeshComponent : MeshComponent  {

        ///<summary>Add simple collision convex to this component</summary>
        public void AddCollisionConvexMesh(byte ConvexVerts /*TODO: array TArray */)  => 
            ProceduralMeshComponent_methods.AddCollisionConvexMesh_method.Invoke(ObjPointer, ConvexVerts);

        ///<summary>Clear all mesh sections and reset to empty state</summary>
        public void ClearAllMeshSections()  => 
            ProceduralMeshComponent_methods.ClearAllMeshSections_method.Invoke(ObjPointer);

        ///<summary>Add simple collision convex to this component</summary>
        public void ClearCollisionConvexMeshes()  => 
            ProceduralMeshComponent_methods.ClearCollisionConvexMeshes_method.Invoke(ObjPointer);

        ///<summary>Clear a section of the procedural mesh. Other sections do not change index.</summary>
        public void ClearMeshSection(int SectionIndex)  => 
            ProceduralMeshComponent_methods.ClearMeshSection_method.Invoke(ObjPointer, SectionIndex);

        ///<summary>Create/replace a section for this procedural mesh component.</summary>
        ///<remarks>
        ///This function is deprecated for Blueprints because it uses the unsupported 'Color' type. Use new 'Create Mesh Section' function which uses LinearColor instead.
        ///@param  SectionIndex            Index of the section to create or replace.
        ///@param  Vertices                        Vertex buffer of all vertex positions to use for this mesh section.
        ///@param  Triangles                       Index buffer indicating which vertices make up each triangle. Length must be a multiple of 3.
        ///@param  Normals                         Optional array of normal vectors for each vertex. If supplied, must be same length as Vertices array.
        ///@param  UV0                                     Optional array of texture co-ordinates for each vertex. If supplied, must be same length as Vertices array.
        ///@param  VertexColors            Optional array of colors for each vertex. If supplied, must be same length as Vertices array.
        ///@param  Tangents                        Optional array of tangent vector for each vertex. If supplied, must be same length as Vertices array.
        ///@param  bCreateCollision        Indicates whether collision should be created for this section. This adds significant cost.
        ///</remarks>
        public void CreateMeshSection(int SectionIndex, byte Vertices /*TODO: array TArray */, byte Triangles /*TODO: array TArray */, byte Normals /*TODO: array TArray */, byte UV0 /*TODO: array TArray */, byte VertexColors /*TODO: array TArray */, byte Tangents /*TODO: array TArray */, bool bCreateCollision)  => 
            ProceduralMeshComponent_methods.CreateMeshSection_method.Invoke(ObjPointer, SectionIndex, Vertices, Triangles, Normals, UV0, VertexColors, Tangents, bCreateCollision);

        ///<summary>Create/replace a section for this procedural mesh component.</summary>
        ///<remarks>
        ///@param  SectionIndex            Index of the section to create or replace.
        ///@param  Vertices                        Vertex buffer of all vertex positions to use for this mesh section.
        ///@param  Triangles                       Index buffer indicating which vertices make up each triangle. Length must be a multiple of 3.
        ///@param  Normals                         Optional array of normal vectors for each vertex. If supplied, must be same length as Vertices array.
        ///@param  UV0                                     Optional array of texture co-ordinates for each vertex. If supplied, must be same length as Vertices array.
        ///@param  VertexColors            Optional array of colors for each vertex. If supplied, must be same length as Vertices array.
        ///@param  Tangents                        Optional array of tangent vector for each vertex. If supplied, must be same length as Vertices array.
        ///@param  bCreateCollision        Indicates whether collision should be created for this section. This adds significant cost.
        ///</remarks>
        public void CreateMeshSection_LinearColor(int SectionIndex, byte Vertices /*TODO: array TArray */, byte Triangles /*TODO: array TArray */, byte Normals /*TODO: array TArray */, byte UV0 /*TODO: array TArray */, byte UV1 /*TODO: array TArray */, byte UV2 /*TODO: array TArray */, byte UV3 /*TODO: array TArray */, byte VertexColors /*TODO: array TArray */, byte Tangents /*TODO: array TArray */, bool bCreateCollision)  => 
            ProceduralMeshComponent_methods.CreateMeshSection_LinearColor_method.Invoke(ObjPointer, SectionIndex, Vertices, Triangles, Normals, UV0, UV1, UV2, UV3, VertexColors, Tangents, bCreateCollision);

        ///<summary>Returns number of sections currently created for this component</summary>
        public int GetNumSections()  => 
            ProceduralMeshComponent_methods.GetNumSections_method.Invoke(ObjPointer);

        ///<summary>Returns whether a particular section is currently visible</summary>
        public bool IsMeshSectionVisible(int SectionIndex)  => 
            ProceduralMeshComponent_methods.IsMeshSectionVisible_method.Invoke(ObjPointer, SectionIndex);

        ///<summary>Control visibility of a particular section</summary>
        public void SetMeshSectionVisible(int SectionIndex, bool bNewVisibility)  => 
            ProceduralMeshComponent_methods.SetMeshSectionVisible_method.Invoke(ObjPointer, SectionIndex, bNewVisibility);

        ///<summary>Updates a section of this procedural mesh component.</summary>
        ///<remarks>
        ///This is faster than CreateMeshSection, but does not let you change topology. Collision info is also updated.
        ///This function is deprecated for Blueprints because it uses the unsupported 'Color' type. Use new 'Create Mesh Section' function which uses LinearColor instead.
        ///@param  Vertices                        Vertex buffer of all vertex positions to use for this mesh section.
        ///@param  Normals                         Optional array of normal vectors for each vertex. If supplied, must be same length as Vertices array.
        ///@param  UV0                                     Optional array of texture co-ordinates for each vertex. If supplied, must be same length as Vertices array.
        ///@param  VertexColors            Optional array of colors for each vertex. If supplied, must be same length as Vertices array.
        ///@param  Tangents                        Optional array of tangent vector for each vertex. If supplied, must be same length as Vertices array.
        ///</remarks>
        public void UpdateMeshSection(int SectionIndex, byte Vertices /*TODO: array TArray */, byte Normals /*TODO: array TArray */, byte UV0 /*TODO: array TArray */, byte VertexColors /*TODO: array TArray */, byte Tangents /*TODO: array TArray */)  => 
            ProceduralMeshComponent_methods.UpdateMeshSection_method.Invoke(ObjPointer, SectionIndex, Vertices, Normals, UV0, VertexColors, Tangents);

        ///<summary>Updates a section of this procedural mesh component.</summary>
        ///<remarks>
        ///This is faster than CreateMeshSection, but does not let you change topology. Collision info is also updated.
        ///@param  Vertices                        Vertex buffer of all vertex positions to use for this mesh section.
        ///@param  Normals                         Optional array of normal vectors for each vertex. If supplied, must be same length as Vertices array.
        ///@param  UV0                                     Optional array of texture co-ordinates for each vertex. If supplied, must be same length as Vertices array.
        ///@param  VertexColors            Optional array of colors for each vertex. If supplied, must be same length as Vertices array.
        ///@param  Tangents                        Optional array of tangent vector for each vertex. If supplied, must be same length as Vertices array.
        ///</remarks>
        public void UpdateMeshSection_LinearColor(int SectionIndex, byte Vertices /*TODO: array TArray */, byte Normals /*TODO: array TArray */, byte UV0 /*TODO: array TArray */, byte UV1 /*TODO: array TArray */, byte UV2 /*TODO: array TArray */, byte UV3 /*TODO: array TArray */, byte VertexColors /*TODO: array TArray */, byte Tangents /*TODO: array TArray */)  => 
            ProceduralMeshComponent_methods.UpdateMeshSection_LinearColor_method.Invoke(ObjPointer, SectionIndex, Vertices, Normals, UV0, UV1, UV2, UV3, VertexColors, Tangents);
        public bool bUseComplexAsSimpleCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bUseComplexAsSimpleCollision"); }
        }
        public bool bUseAsyncCooking {
            get {return Main.GetGetBoolPropertyByName(this, "bUseAsyncCooking"); }
        }
        ///<summary>Collision data</summary>
        public unsafe BodySetup ProcMeshBodySetup {
            get {return ProceduralMeshComponent_ptr->ProcMeshBodySetup;}
            set {ProceduralMeshComponent_ptr->ProcMeshBodySetup = value;}
        }
         //TODO: array not UObject TArray ProcMeshSections
         //TODO: array not UObject TArray CollisionConvexElems
        ///<summary>Local space bounds of mesh</summary>
        public unsafe BoxSphereBounds LocalBounds {
            get {return ProceduralMeshComponent_ptr->LocalBounds;}
            set {ProceduralMeshComponent_ptr->LocalBounds = value;}
        }
        ///<summary>Queue for async body setups that are being cooked</summary>
        public ObjectArrayField<BodySetup> AsyncBodySetupQueue{ get {
            if(AsyncBodySetupQueue_store == null) AsyncBodySetupQueue_store = new ObjectArrayField<BodySetup> (&ProceduralMeshComponent_ptr->AsyncBodySetupQueue);
            return AsyncBodySetupQueue_store;
        } }
        private ObjectArrayField<BodySetup> AsyncBodySetupQueue_store;

        static ProceduralMeshComponent() {
            StaticClass = Main.GetClass("ProceduralMeshComponent");
        }
        internal unsafe ProceduralMeshComponent_fields* ProceduralMeshComponent_ptr => (ProceduralMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProceduralMeshComponent(IntPtr p) => UObject.Make<ProceduralMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProceduralMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProceduralMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
