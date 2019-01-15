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
    [StructLayout( LayoutKind.Explicit, Size=768 )]
    internal unsafe struct MeshTrackerComponent_fields {
        [FieldOffset(624)] byte OnMeshTrackerUpdated; //TODO: multicast delegate FOnMeshTrackerUpdated OnMeshTrackerUpdated
        [FieldOffset(640)] public bool ScanWorld;
        [FieldOffset(641)] byte MeshType; //TODO: enum EMeshType MeshType
        [FieldOffset(644)] public float MeshingPollTime;
        [FieldOffset(648)]  public IntPtr  BoundingVolume;
        [FieldOffset(656)] public bool IgnoreBoundingVolume;
        [FieldOffset(660)] public int TargetNumberTriangles;
        [FieldOffset(664)] public bool FillGaps;
        [FieldOffset(668)] public float PerimeterOfGapsToFill;
        [FieldOffset(672)] public bool Planarize;
        [FieldOffset(673)] public bool RemoveDisconnectedSections;
        [FieldOffset(676)] public float DisconnectedSectionArea;
        [FieldOffset(680)] public float MinDistanceRescan;
        [FieldOffset(684)] public bool RequestNormals;
        [FieldOffset(685)] public bool RequestVertexConfidence;
        [FieldOffset(686)] byte VertexColorMode; //TODO: enum EMLMeshVertexColorMode VertexColorMode
        [FieldOffset(688)] public NativeArray BlockVertexColors;
        [FieldOffset(704)] public LinearColor VertexColorFromConfidenceZero;
        [FieldOffset(720)] public LinearColor VertexColorFromConfidenceOne;
        [FieldOffset(736)] public bool RemoveOverlappingTriangles;
        [FieldOffset(744)]  public IntPtr  MRMesh;
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
        internal struct ForceMeshUpdate_method {
            static internal IntPtr ForceMeshUpdate_ptr;
            static ForceMeshUpdate_method() {
                ForceMeshUpdate_ptr = Main.GetMethodUFunction(MeshTrackerComponent.StaticClass, "ForceMeshUpdate");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ForceMeshUpdate_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct MeshTrackerComponent_events {
    }
}
