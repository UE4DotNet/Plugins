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

using UE4.Engine;

namespace UE4.ProceduralMeshComponent.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct KismetProceduralMeshLibrary_fields {
    }
    internal unsafe struct KismetProceduralMeshLibrary_methods {
        internal struct CalculateTangentsForMesh_method {
            static internal IntPtr CalculateTangentsForMesh_ptr;
            static CalculateTangentsForMesh_method() {
                CalculateTangentsForMesh_ptr = Main.GetMethodUFunction(KismetProceduralMeshLibrary.StaticClass, "CalculateTangentsForMesh");
            }

            internal static unsafe (IReadOnlyCollection<Vector>, IReadOnlyCollection<ProcMeshTangent>) Invoke(byte Vertices /*TODO: array TArray */, byte Triangles /*TODO: array TArray */, byte UVs /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Vertices
                throw new NotImplementedException(); //TODO: array TArray Triangles
                throw new NotImplementedException(); //TODO: array TArray UVs
                Main.GetProcessEvent(KismetProceduralMeshLibrary.DefaultObject, CalculateTangentsForMesh_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Vertices
                 //TODO: array TArray Triangles
                 //TODO: array TArray UVs
                 //TODO: array TArray Normals
                 //TODO: array TArray Tangents
                return (UObject.ToUnmangedCollection<Vector>(b+48),UObject.ToUnmangedCollection<ProcMeshTangent>(b+64));
            }
        }
        internal struct ConvertQuadToTriangles_method {
            static internal IntPtr ConvertQuadToTriangles_ptr;
            static ConvertQuadToTriangles_method() {
                ConvertQuadToTriangles_ptr = Main.GetMethodUFunction(KismetProceduralMeshLibrary.StaticClass, "ConvertQuadToTriangles");
            }

            internal static unsafe void Invoke(byte Triangles /*TODO: array TArray */, int Vert0, int Vert1, int Vert2, int Vert3) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Triangles
                *((int*)(b+16)) = Vert0;
                *((int*)(b+20)) = Vert1;
                *((int*)(b+24)) = Vert2;
                *((int*)(b+28)) = Vert3;
                Main.GetProcessEvent(KismetProceduralMeshLibrary.DefaultObject, ConvertQuadToTriangles_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Triangles
            }
        }
        internal struct CopyProceduralMeshFromStaticMeshComponent_method {
            static internal IntPtr CopyProceduralMeshFromStaticMeshComponent_ptr;
            static CopyProceduralMeshFromStaticMeshComponent_method() {
                CopyProceduralMeshFromStaticMeshComponent_ptr = Main.GetMethodUFunction(KismetProceduralMeshLibrary.StaticClass, "CopyProceduralMeshFromStaticMeshComponent");
            }

            internal static unsafe void Invoke(StaticMeshComponent StaticMeshComponent, int LODIndex, ProceduralMeshComponent ProcMeshComponent, bool bCreateCollision) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = StaticMeshComponent;
                *((int*)(b+8)) = LODIndex;
                *((IntPtr*)(b+16)) = ProcMeshComponent;
                *((bool*)(b+24)) = bCreateCollision;
                Main.GetProcessEvent(KismetProceduralMeshLibrary.DefaultObject, CopyProceduralMeshFromStaticMeshComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CreateGridMeshTriangles_method {
            static internal IntPtr CreateGridMeshTriangles_ptr;
            static CreateGridMeshTriangles_method() {
                CreateGridMeshTriangles_ptr = Main.GetMethodUFunction(KismetProceduralMeshLibrary.StaticClass, "CreateGridMeshTriangles");
            }

            internal static unsafe IReadOnlyCollection<int> Invoke(int NumX, int NumY, bool bWinding) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NumX;
                *((int*)(b+4)) = NumY;
                *((bool*)(b+8)) = bWinding;
                Main.GetProcessEvent(KismetProceduralMeshLibrary.DefaultObject, CreateGridMeshTriangles_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Triangles
                return UObject.ToUnmangedCollection<int>(b+16);
            }
        }
        internal struct GenerateBoxMesh_method {
            static internal IntPtr GenerateBoxMesh_ptr;
            static GenerateBoxMesh_method() {
                GenerateBoxMesh_ptr = Main.GetMethodUFunction(KismetProceduralMeshLibrary.StaticClass, "GenerateBoxMesh");
            }

            internal static unsafe (IReadOnlyCollection<Vector>, IReadOnlyCollection<int>, IReadOnlyCollection<Vector>, IReadOnlyCollection<Vector2D>, IReadOnlyCollection<ProcMeshTangent>) Invoke(Vector BoxRadius) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = BoxRadius;
                Main.GetProcessEvent(KismetProceduralMeshLibrary.DefaultObject, GenerateBoxMesh_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Vertices
                 //TODO: array TArray Triangles
                 //TODO: array TArray Normals
                 //TODO: array TArray UVs
                 //TODO: array TArray Tangents
                return (UObject.ToUnmangedCollection<Vector>(b+16),UObject.ToUnmangedCollection<int>(b+32),UObject.ToUnmangedCollection<Vector>(b+48),UObject.ToUnmangedCollection<Vector2D>(b+64),UObject.ToUnmangedCollection<ProcMeshTangent>(b+80));
            }
        }
        internal struct GetSectionFromProceduralMesh_method {
            static internal IntPtr GetSectionFromProceduralMesh_ptr;
            static GetSectionFromProceduralMesh_method() {
                GetSectionFromProceduralMesh_ptr = Main.GetMethodUFunction(KismetProceduralMeshLibrary.StaticClass, "GetSectionFromProceduralMesh");
            }

            internal static unsafe (IReadOnlyCollection<Vector>, IReadOnlyCollection<int>, IReadOnlyCollection<Vector>, IReadOnlyCollection<Vector2D>, IReadOnlyCollection<ProcMeshTangent>) Invoke(ProceduralMeshComponent InProcMesh, int SectionIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InProcMesh;
                *((int*)(b+8)) = SectionIndex;
                Main.GetProcessEvent(KismetProceduralMeshLibrary.DefaultObject, GetSectionFromProceduralMesh_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Vertices
                 //TODO: array TArray Triangles
                 //TODO: array TArray Normals
                 //TODO: array TArray UVs
                 //TODO: array TArray Tangents
                return (UObject.ToUnmangedCollection<Vector>(b+16),UObject.ToUnmangedCollection<int>(b+32),UObject.ToUnmangedCollection<Vector>(b+48),UObject.ToUnmangedCollection<Vector2D>(b+64),UObject.ToUnmangedCollection<ProcMeshTangent>(b+80));
            }
        }
        internal struct GetSectionFromStaticMesh_method {
            static internal IntPtr GetSectionFromStaticMesh_ptr;
            static GetSectionFromStaticMesh_method() {
                GetSectionFromStaticMesh_ptr = Main.GetMethodUFunction(KismetProceduralMeshLibrary.StaticClass, "GetSectionFromStaticMesh");
            }

            internal static unsafe (IReadOnlyCollection<Vector>, IReadOnlyCollection<int>, IReadOnlyCollection<Vector>, IReadOnlyCollection<Vector2D>, IReadOnlyCollection<ProcMeshTangent>) Invoke(StaticMesh InMesh, int LODIndex, int SectionIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InMesh;
                *((int*)(b+8)) = LODIndex;
                *((int*)(b+12)) = SectionIndex;
                Main.GetProcessEvent(KismetProceduralMeshLibrary.DefaultObject, GetSectionFromStaticMesh_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Vertices
                 //TODO: array TArray Triangles
                 //TODO: array TArray Normals
                 //TODO: array TArray UVs
                 //TODO: array TArray Tangents
                return (UObject.ToUnmangedCollection<Vector>(b+16),UObject.ToUnmangedCollection<int>(b+32),UObject.ToUnmangedCollection<Vector>(b+48),UObject.ToUnmangedCollection<Vector2D>(b+64),UObject.ToUnmangedCollection<ProcMeshTangent>(b+80));
            }
        }
        internal struct SliceProceduralMesh_method {
            static internal IntPtr SliceProceduralMesh_ptr;
            static SliceProceduralMesh_method() {
                SliceProceduralMesh_ptr = Main.GetMethodUFunction(KismetProceduralMeshLibrary.StaticClass, "SliceProceduralMesh");
            }

            internal static unsafe ProceduralMeshComponent Invoke(ProceduralMeshComponent InProcMesh, Vector PlanePosition, Vector PlaneNormal, bool bCreateOtherHalf, EProcMeshSliceCapOption CapOption, MaterialInterface CapMaterial) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InProcMesh;
                *((Vector*)(b+8)) = PlanePosition;
                *((Vector*)(b+20)) = PlaneNormal;
                *((bool*)(b+32)) = bCreateOtherHalf;
                *(b+48) = (byte)CapOption;
                *((IntPtr*)(b+56)) = CapMaterial;
                Main.GetProcessEvent(KismetProceduralMeshLibrary.DefaultObject, SliceProceduralMesh_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+40));
            }
        }
    }
    internal unsafe struct KismetProceduralMeshLibrary_events {
    }
}
