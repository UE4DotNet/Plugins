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


namespace UE4.CustomMeshComponent.Native {
    [StructLayout( LayoutKind.Explicit, Size=1568 )]
    internal unsafe struct CustomMeshComponent_fields {
    }
    internal unsafe struct CustomMeshComponent_methods {
        internal struct AddCustomMeshTriangles_method {
            static internal IntPtr AddCustomMeshTriangles_ptr;
            static AddCustomMeshTriangles_method() {
                AddCustomMeshTriangles_ptr = Main.GetMethodUFunction(CustomMeshComponent.StaticClass, "AddCustomMeshTriangles");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Triangles /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Triangles
                Main.GetProcessEvent(obj, AddCustomMeshTriangles_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Triangles
            }
        }
        internal struct ClearCustomMeshTriangles_method {
            static internal IntPtr ClearCustomMeshTriangles_ptr;
            static ClearCustomMeshTriangles_method() {
                ClearCustomMeshTriangles_ptr = Main.GetMethodUFunction(CustomMeshComponent.StaticClass, "ClearCustomMeshTriangles");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearCustomMeshTriangles_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCustomMeshTriangles_method {
            static internal IntPtr SetCustomMeshTriangles_ptr;
            static SetCustomMeshTriangles_method() {
                SetCustomMeshTriangles_ptr = Main.GetMethodUFunction(CustomMeshComponent.StaticClass, "SetCustomMeshTriangles");
            }

            internal static unsafe bool Invoke(IntPtr obj, byte Triangles /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Triangles
                Main.GetProcessEvent(obj, SetCustomMeshTriangles_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Triangles
                return *((bool*)(b+16));
            }
        }
    }
    internal unsafe struct CustomMeshComponent_events {
    }
}
