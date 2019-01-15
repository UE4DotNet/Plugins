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


namespace UE4.MRMesh.Native {
    [StructLayout( LayoutKind.Explicit, Size=1600 )]
    internal unsafe struct MRMeshComponent_fields {
        [FieldOffset(1528)]  public IntPtr  Material;
        [FieldOffset(1536)] public bool bCreateMeshProxySections;
        [FieldOffset(1537)] public bool bUpdateNavMeshOnMeshUpdate;
        [FieldOffset(1544)] public NativeArray BodySetups;
    }
    internal unsafe struct MRMeshComponent_methods {
        internal struct Clear_method {
            static internal IntPtr Clear_ptr;
            static Clear_method() {
                Clear_ptr = Main.GetMethodUFunction(MRMeshComponent.StaticClass, "Clear");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Clear_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ForceNavMeshUpdate_method {
            static internal IntPtr ForceNavMeshUpdate_ptr;
            static ForceNavMeshUpdate_method() {
                ForceNavMeshUpdate_ptr = Main.GetMethodUFunction(MRMeshComponent.StaticClass, "ForceNavMeshUpdate");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ForceNavMeshUpdate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsConnected_method {
            static internal IntPtr IsConnected_ptr;
            static IsConnected_method() {
                IsConnected_ptr = Main.GetMethodUFunction(MRMeshComponent.StaticClass, "IsConnected");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsConnected_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct MRMeshComponent_events {
    }
}
