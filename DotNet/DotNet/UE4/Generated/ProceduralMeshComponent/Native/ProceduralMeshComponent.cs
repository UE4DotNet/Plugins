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


namespace UE4.ProceduralMeshComponent.Native {
    [StructLayout( LayoutKind.Explicit, Size=1664 )]
    internal unsafe struct ProceduralMeshComponent_fields {
        [FieldOffset(1568)] public bool bUseComplexAsSimpleCollision;
        [FieldOffset(1569)] public bool bUseAsyncCooking;
        [FieldOffset(1576)]  public IntPtr  ProcMeshBodySetup;
        [FieldOffset(1584)] public NativeArray ProcMeshSections;
        [FieldOffset(1600)] public NativeArray CollisionConvexElems;
        [FieldOffset(1616)] public BoxSphereBounds LocalBounds;
        [FieldOffset(1648)] public NativeArray AsyncBodySetupQueue;
    }
    internal unsafe struct ProceduralMeshComponent_methods {
        internal struct AddCollisionConvexMesh_method {
            static internal IntPtr AddCollisionConvexMesh_ptr;
            static AddCollisionConvexMesh_method() {
                AddCollisionConvexMesh_ptr = Main.GetMethodUFunction(ProceduralMeshComponent.StaticClass, "AddCollisionConvexMesh");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ConvexVerts /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ConvexVerts
                Main.GetProcessEvent(obj, AddCollisionConvexMesh_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ConvexVerts
            }
        }
        internal struct ClearAllMeshSections_method {
            static internal IntPtr ClearAllMeshSections_ptr;
            static ClearAllMeshSections_method() {
                ClearAllMeshSections_ptr = Main.GetMethodUFunction(ProceduralMeshComponent.StaticClass, "ClearAllMeshSections");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearAllMeshSections_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearCollisionConvexMeshes_method {
            static internal IntPtr ClearCollisionConvexMeshes_ptr;
            static ClearCollisionConvexMeshes_method() {
                ClearCollisionConvexMeshes_ptr = Main.GetMethodUFunction(ProceduralMeshComponent.StaticClass, "ClearCollisionConvexMeshes");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearCollisionConvexMeshes_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMeshSection_method {
            static internal IntPtr ClearMeshSection_ptr;
            static ClearMeshSection_method() {
                ClearMeshSection_ptr = Main.GetMethodUFunction(ProceduralMeshComponent.StaticClass, "ClearMeshSection");
            }

            internal static unsafe void Invoke(IntPtr obj, int SectionIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = SectionIndex;
                Main.GetProcessEvent(obj, ClearMeshSection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CreateMeshSection_method {
            static internal IntPtr CreateMeshSection_ptr;
            static CreateMeshSection_method() {
                CreateMeshSection_ptr = Main.GetMethodUFunction(ProceduralMeshComponent.StaticClass, "CreateMeshSection");
            }

            internal static unsafe void Invoke(IntPtr obj, int SectionIndex, byte Vertices /*TODO: array TArray */, byte Triangles /*TODO: array TArray */, byte Normals /*TODO: array TArray */, byte UV0 /*TODO: array TArray */, byte VertexColors /*TODO: array TArray */, byte Tangents /*TODO: array TArray */, bool bCreateCollision) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = SectionIndex;
                throw new NotImplementedException(); //TODO: array TArray Vertices
                throw new NotImplementedException(); //TODO: array TArray Triangles
                throw new NotImplementedException(); //TODO: array TArray Normals
                throw new NotImplementedException(); //TODO: array TArray UV0
                throw new NotImplementedException(); //TODO: array TArray VertexColors
                throw new NotImplementedException(); //TODO: array TArray Tangents
                *((bool*)(b+104)) = bCreateCollision;
                Main.GetProcessEvent(obj, CreateMeshSection_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Vertices
                 //TODO: array TArray Triangles
                 //TODO: array TArray Normals
                 //TODO: array TArray UV0
                 //TODO: array TArray VertexColors
                 //TODO: array TArray Tangents
            }
        }
        internal struct CreateMeshSection_LinearColor_method {
            static internal IntPtr CreateMeshSection_LinearColor_ptr;
            static CreateMeshSection_LinearColor_method() {
                CreateMeshSection_LinearColor_ptr = Main.GetMethodUFunction(ProceduralMeshComponent.StaticClass, "CreateMeshSection_LinearColor");
            }

            internal static unsafe void Invoke(IntPtr obj, int SectionIndex, byte Vertices /*TODO: array TArray */, byte Triangles /*TODO: array TArray */, byte Normals /*TODO: array TArray */, byte UV0 /*TODO: array TArray */, byte UV1 /*TODO: array TArray */, byte UV2 /*TODO: array TArray */, byte UV3 /*TODO: array TArray */, byte VertexColors /*TODO: array TArray */, byte Tangents /*TODO: array TArray */, bool bCreateCollision) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = SectionIndex;
                throw new NotImplementedException(); //TODO: array TArray Vertices
                throw new NotImplementedException(); //TODO: array TArray Triangles
                throw new NotImplementedException(); //TODO: array TArray Normals
                throw new NotImplementedException(); //TODO: array TArray UV0
                throw new NotImplementedException(); //TODO: array TArray UV1
                throw new NotImplementedException(); //TODO: array TArray UV2
                throw new NotImplementedException(); //TODO: array TArray UV3
                throw new NotImplementedException(); //TODO: array TArray VertexColors
                throw new NotImplementedException(); //TODO: array TArray Tangents
                *((bool*)(b+152)) = bCreateCollision;
                Main.GetProcessEvent(obj, CreateMeshSection_LinearColor_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Vertices
                 //TODO: array TArray Triangles
                 //TODO: array TArray Normals
                 //TODO: array TArray UV0
                 //TODO: array TArray UV1
                 //TODO: array TArray UV2
                 //TODO: array TArray UV3
                 //TODO: array TArray VertexColors
                 //TODO: array TArray Tangents
            }
        }
        internal struct GetNumSections_method {
            static internal IntPtr GetNumSections_ptr;
            static GetNumSections_method() {
                GetNumSections_ptr = Main.GetMethodUFunction(ProceduralMeshComponent.StaticClass, "GetNumSections");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumSections_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct IsMeshSectionVisible_method {
            static internal IntPtr IsMeshSectionVisible_ptr;
            static IsMeshSectionVisible_method() {
                IsMeshSectionVisible_ptr = Main.GetMethodUFunction(ProceduralMeshComponent.StaticClass, "IsMeshSectionVisible");
            }

            internal static unsafe bool Invoke(IntPtr obj, int SectionIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = SectionIndex;
                Main.GetProcessEvent(obj, IsMeshSectionVisible_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct SetMeshSectionVisible_method {
            static internal IntPtr SetMeshSectionVisible_ptr;
            static SetMeshSectionVisible_method() {
                SetMeshSectionVisible_ptr = Main.GetMethodUFunction(ProceduralMeshComponent.StaticClass, "SetMeshSectionVisible");
            }

            internal static unsafe void Invoke(IntPtr obj, int SectionIndex, bool bNewVisibility) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = SectionIndex;
                *((bool*)(b+4)) = bNewVisibility;
                Main.GetProcessEvent(obj, SetMeshSectionVisible_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UpdateMeshSection_method {
            static internal IntPtr UpdateMeshSection_ptr;
            static UpdateMeshSection_method() {
                UpdateMeshSection_ptr = Main.GetMethodUFunction(ProceduralMeshComponent.StaticClass, "UpdateMeshSection");
            }

            internal static unsafe void Invoke(IntPtr obj, int SectionIndex, byte Vertices /*TODO: array TArray */, byte Normals /*TODO: array TArray */, byte UV0 /*TODO: array TArray */, byte VertexColors /*TODO: array TArray */, byte Tangents /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = SectionIndex;
                throw new NotImplementedException(); //TODO: array TArray Vertices
                throw new NotImplementedException(); //TODO: array TArray Normals
                throw new NotImplementedException(); //TODO: array TArray UV0
                throw new NotImplementedException(); //TODO: array TArray VertexColors
                throw new NotImplementedException(); //TODO: array TArray Tangents
                Main.GetProcessEvent(obj, UpdateMeshSection_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Vertices
                 //TODO: array TArray Normals
                 //TODO: array TArray UV0
                 //TODO: array TArray VertexColors
                 //TODO: array TArray Tangents
            }
        }
        internal struct UpdateMeshSection_LinearColor_method {
            static internal IntPtr UpdateMeshSection_LinearColor_ptr;
            static UpdateMeshSection_LinearColor_method() {
                UpdateMeshSection_LinearColor_ptr = Main.GetMethodUFunction(ProceduralMeshComponent.StaticClass, "UpdateMeshSection_LinearColor");
            }

            internal static unsafe void Invoke(IntPtr obj, int SectionIndex, byte Vertices /*TODO: array TArray */, byte Normals /*TODO: array TArray */, byte UV0 /*TODO: array TArray */, byte UV1 /*TODO: array TArray */, byte UV2 /*TODO: array TArray */, byte UV3 /*TODO: array TArray */, byte VertexColors /*TODO: array TArray */, byte Tangents /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = SectionIndex;
                throw new NotImplementedException(); //TODO: array TArray Vertices
                throw new NotImplementedException(); //TODO: array TArray Normals
                throw new NotImplementedException(); //TODO: array TArray UV0
                throw new NotImplementedException(); //TODO: array TArray UV1
                throw new NotImplementedException(); //TODO: array TArray UV2
                throw new NotImplementedException(); //TODO: array TArray UV3
                throw new NotImplementedException(); //TODO: array TArray VertexColors
                throw new NotImplementedException(); //TODO: array TArray Tangents
                Main.GetProcessEvent(obj, UpdateMeshSection_LinearColor_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Vertices
                 //TODO: array TArray Normals
                 //TODO: array TArray UV0
                 //TODO: array TArray UV1
                 //TODO: array TArray UV2
                 //TODO: array TArray UV3
                 //TODO: array TArray VertexColors
                 //TODO: array TArray Tangents
            }
        }
    }
    internal unsafe struct ProceduralMeshComponent_events {
    }
}
