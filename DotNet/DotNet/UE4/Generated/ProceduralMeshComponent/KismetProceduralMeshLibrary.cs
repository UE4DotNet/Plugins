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
    ///<summary>Kismet Procedural Mesh Library</summary>
    public unsafe partial class KismetProceduralMeshLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Automatically generate normals and tangent vectors for a mesh
        ///UVs are required for correct tangent generation.
        ///</summary>
        public static (IReadOnlyCollection<Vector>, IReadOnlyCollection<ProcMeshTangent>) CalculateTangentsForMesh(byte Vertices /*TODO: array TArray */, byte Triangles /*TODO: array TArray */, byte UVs /*TODO: array TArray */)  => 
            KismetProceduralMeshLibrary_methods.CalculateTangentsForMesh_method.Invoke(Vertices, Triangles, UVs);

        ///<summary>Add a quad, specified by four indices, to a triangle index buffer as two triangles.</summary>
        public static void ConvertQuadToTriangles(byte Triangles /*TODO: array TArray */, int Vert0, int Vert1, int Vert2, int Vert3)  => 
            KismetProceduralMeshLibrary_methods.ConvertQuadToTriangles_method.Invoke(Triangles, Vert0, Vert1, Vert2, Vert3);

        ///<summary>Copy materials from StaticMeshComponent to ProceduralMeshComponent.</summary>
        public static void CopyProceduralMeshFromStaticMeshComponent(StaticMeshComponent StaticMeshComponent, int LODIndex, ProceduralMeshComponent ProcMeshComponent, bool bCreateCollision)  => 
            KismetProceduralMeshLibrary_methods.CopyProceduralMeshFromStaticMeshComponent_method.Invoke(StaticMeshComponent, LODIndex, ProcMeshComponent, bCreateCollision);

        ///<summary>Generate an index buffer for a grid of quads.</summary>
        ///<remarks>
        ///@param  NumX                    Number of vertices in X direction (must be >= 2)
        ///@param  NumY                    Number of vertices in y direction (must be >= 2)
        ///@param  bWinding                Reverses winding of indices generated for each quad
        ///@out    Triangles               Output index buffer
        ///</remarks>
        public static IReadOnlyCollection<int> CreateGridMeshTriangles(int NumX, int NumY, bool bWinding)  => 
            KismetProceduralMeshLibrary_methods.CreateGridMeshTriangles_method.Invoke(NumX, NumY, bWinding);

        ///<summary>Generate vertex and index buffer for a simple box, given the supplied dimensions. Normals, UVs and tangents are also generated for each vertex.</summary>
        public static (IReadOnlyCollection<Vector>, IReadOnlyCollection<int>, IReadOnlyCollection<Vector>, IReadOnlyCollection<Vector2D>, IReadOnlyCollection<ProcMeshTangent>) GenerateBoxMesh(Vector BoxRadius)  => 
            KismetProceduralMeshLibrary_methods.GenerateBoxMesh_method.Invoke(BoxRadius);

        ///<summary>Grab geometry data from a ProceduralMeshComponent.</summary>
        public static (IReadOnlyCollection<Vector>, IReadOnlyCollection<int>, IReadOnlyCollection<Vector>, IReadOnlyCollection<Vector2D>, IReadOnlyCollection<ProcMeshTangent>) GetSectionFromProceduralMesh(ProceduralMeshComponent InProcMesh, int SectionIndex)  => 
            KismetProceduralMeshLibrary_methods.GetSectionFromProceduralMesh_method.Invoke(InProcMesh, SectionIndex);

        ///<summary>Grab geometry data from a StaticMesh asset.</summary>
        public static (IReadOnlyCollection<Vector>, IReadOnlyCollection<int>, IReadOnlyCollection<Vector>, IReadOnlyCollection<Vector2D>, IReadOnlyCollection<ProcMeshTangent>) GetSectionFromStaticMesh(StaticMesh InMesh, int LODIndex, int SectionIndex)  => 
            KismetProceduralMeshLibrary_methods.GetSectionFromStaticMesh_method.Invoke(InMesh, LODIndex, SectionIndex);

        ///<summary>Slice the ProceduralMeshComponent (including simple convex collision) using a plane.</summary>
        ///<remarks>
        ///Optionally create 'cap' geometry.
        ///@param  InProcMesh                              ProceduralMeshComponent to slice
        ///@param  PlanePosition                   Point on the plane to use for slicing, in world space
        ///@param  PlaneNormal                             Normal of plane used for slicing. Geometry on the positive side of the plane will be kept.
        ///@param  bCreateOtherHalf                If true, an additional ProceduralMeshComponent (OutOtherHalfProcMesh) will be created using the other half of the sliced geometry
        ///@param  OutOtherHalfProcMesh    If bCreateOtherHalf is set, this is the new component created. Its owner will be the same as the supplied InProcMesh.
        ///@param  CapOption                               If and how to create 'cap' geometry on the slicing plane
        ///@param  CapMaterial                             If creating a new section for the cap, assign this material to that section
        ///</remarks>
        public static ProceduralMeshComponent SliceProceduralMesh(ProceduralMeshComponent InProcMesh, Vector PlanePosition, Vector PlaneNormal, bool bCreateOtherHalf, EProcMeshSliceCapOption CapOption, MaterialInterface CapMaterial)  => 
            KismetProceduralMeshLibrary_methods.SliceProceduralMesh_method.Invoke(InProcMesh, PlanePosition, PlaneNormal, bCreateOtherHalf, CapOption, CapMaterial);
        static KismetProceduralMeshLibrary() {
            StaticClass = Main.GetClass("KismetProceduralMeshLibrary");
        }
        internal unsafe KismetProceduralMeshLibrary_fields* KismetProceduralMeshLibrary_ptr => (KismetProceduralMeshLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetProceduralMeshLibrary(IntPtr p) => UObject.Make<KismetProceduralMeshLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetProceduralMeshLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetProceduralMeshLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
