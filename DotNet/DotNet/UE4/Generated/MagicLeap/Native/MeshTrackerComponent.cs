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

using UE4.MRMesh;

namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=752 )]
    internal unsafe struct MeshTrackerComponent_fields {
        [FieldOffset(624)] byte OnMeshTrackerUpdated; //TODO: multicast delegate FOnMeshTrackerUpdated OnMeshTrackerUpdated
        [FieldOffset(640)] public bool ScanWorld;
        [FieldOffset(641)] byte MeshType; //TODO: enum EMeshType MeshType
        [FieldOffset(648)]  public IntPtr  BoundingVolume;
        [FieldOffset(656)] byte LevelOfDetail; //TODO: enum EMeshLOD LevelOfDetail
        [FieldOffset(660)] public float PerimeterOfGapsToFill;
        [FieldOffset(664)] public bool Planarize;
        [FieldOffset(668)] public float DisconnectedSectionArea;
        [FieldOffset(672)] public bool RequestNormals;
        [FieldOffset(673)] public bool RequestVertexConfidence;
        [FieldOffset(674)] byte VertexColorMode; //TODO: enum EMLMeshVertexColorMode VertexColorMode
        [FieldOffset(680)] public NativeArray BlockVertexColors;
        [FieldOffset(696)] public LinearColor VertexColorFromConfidenceZero;
        [FieldOffset(712)] public LinearColor VertexColorFromConfidenceOne;
        [FieldOffset(728)] public bool RemoveOverlappingTriangles;
        [FieldOffset(736)]  public IntPtr  MRMesh;
    }
    internal unsafe struct MeshTrackerComponent_methods {
        internal struct ConnectMRMesh_method {
            static internal IntPtr ConnectMRMesh_ptr;
            static ConnectMRMesh_method() {
                ConnectMRMesh_ptr = Main.GetMethodUFunction(MeshTrackerComponent.StaticClass, "ConnectMRMesh");
            }

            internal static unsafe void Invoke(IntPtr obj, MRMeshComponent InMRMeshPtr) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InMRMeshPtr;
                Main.GetProcessEvent(obj, ConnectMRMesh_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DisconnectMRMesh_method {
            static internal IntPtr DisconnectMRMesh_ptr;
            static DisconnectMRMesh_method() {
                DisconnectMRMesh_ptr = Main.GetMethodUFunction(MeshTrackerComponent.StaticClass, "DisconnectMRMesh");
            }

            internal static unsafe void Invoke(IntPtr obj, MRMeshComponent InMRMeshPtr) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InMRMeshPtr;
                Main.GetProcessEvent(obj, DisconnectMRMesh_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MeshTrackerComponent_events {
    }
}
