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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1144 )]
    internal unsafe struct SkeletalMesh_fields {
        [FieldOffset(104)]  public IntPtr  Skeleton;
        [FieldOffset(112)] public BoxSphereBounds ImportedBounds;
        [FieldOffset(140)] public BoxSphereBounds ExtendedBounds;
        [FieldOffset(168)] public Vector PositiveBoundsExtension;
        [FieldOffset(180)] public Vector NegativeBoundsExtension;
        [FieldOffset(192)] public NativeArray Materials;
        [FieldOffset(208)] public NativeArray SkelMirrorTable;
        [FieldOffset(224)] public byte SkelMirrorAxis;
        [FieldOffset(225)] public byte SkelMirrorFlipAxis;
        [FieldOffset(232)] public NativeArray LODInfo;
        [FieldOffset(248)] public PerPlatformInt MinLod;
        [FieldOffset(336)]  public IntPtr  LODSettings;
        [FieldOffset(344)] public bool bUseFullPrecisionUVs;
        [FieldOffset(344)] public bool bUseHighPrecisionTangentBasis;
        [FieldOffset(344)] public bool bHasBeenSimplified;
        [FieldOffset(344)] public bool bHasVertexColors;
        [FieldOffset(348)] public FGuid VertexColorGuid;
        [FieldOffset(364)] public bool bEnablePerPolyCollision;
        [FieldOffset(368)]  public IntPtr  BodySetup;
        [FieldOffset(376)]  public IntPtr  PhysicsAsset;
        [FieldOffset(384)]  public IntPtr  ShadowPhysicsAsset;
        [FieldOffset(392)] public NativeArray NodeMappingData;
        [FieldOffset(408)]  public IntPtr  AssetImportData;
        [FieldOffset(448)]  public IntPtr  ThumbnailInfo;
        [FieldOffset(456)] public bool bHasCustomDefaultEditorCamera;
        [FieldOffset(460)] public Vector DefaultEditorCameraLocation;
        [FieldOffset(472)] public Rotator DefaultEditorCameraRotation;
        [FieldOffset(484)] public Vector DefaultEditorCameraLookAt;
        [FieldOffset(496)] public float DefaultEditorCameraOrthoZoom;
        [FieldOffset(504)] public PreviewAssetAttachContainer PreviewAttachedAssetContainer;
        [FieldOffset(528)] public NativeArray MorphTargets;
        [FieldOffset(912)] public float FloorOffset;
        [FieldOffset(920)] public NativeArray RetargetBasePose;
        [FieldOffset(952)] public IntPtr PostProcessAnimBlueprint;
        [FieldOffset(960)] public NativeArray MeshClothingAssets;
        [FieldOffset(976)] public SkeletalMeshSamplingInfo SamplingInfo;
        [FieldOffset(1024)] public NativeArray AssetUserData;
        [FieldOffset(1064)] public NativeArray Sockets;
    }
    internal unsafe struct SkeletalMesh_methods {
        internal struct FindSocket_method {
            static internal IntPtr FindSocket_ptr;
            static FindSocket_method() {
                FindSocket_ptr = Main.GetMethodUFunction(SkeletalMesh.StaticClass, "FindSocket");
            }

            internal static unsafe SkeletalMeshSocket Invoke(IntPtr obj, Name InSocketName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InSocketName;
                Main.GetProcessEvent(obj, FindSocket_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct FindSocketAndIndex_method {
            static internal IntPtr FindSocketAndIndex_ptr;
            static FindSocketAndIndex_method() {
                FindSocketAndIndex_ptr = Main.GetMethodUFunction(SkeletalMesh.StaticClass, "FindSocketAndIndex");
            }

            internal static unsafe (int, SkeletalMeshSocket) Invoke(IntPtr obj, Name InSocketName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InSocketName;
                Main.GetProcessEvent(obj, FindSocketAndIndex_ptr, new IntPtr(p)); ;
                return (*((int*)(b+12)),*((IntPtr*)(b+16)));
            }
        }
        internal struct GetBounds_method {
            static internal IntPtr GetBounds_ptr;
            static GetBounds_method() {
                GetBounds_ptr = Main.GetMethodUFunction(SkeletalMesh.StaticClass, "GetBounds");
            }

            internal static unsafe BoxSphereBounds Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetBounds_ptr, new IntPtr(p)); ;
                return *((BoxSphereBounds*)(b+0));
            }
        }
        internal struct GetImportedBounds_method {
            static internal IntPtr GetImportedBounds_ptr;
            static GetImportedBounds_method() {
                GetImportedBounds_ptr = Main.GetMethodUFunction(SkeletalMesh.StaticClass, "GetImportedBounds");
            }

            internal static unsafe BoxSphereBounds Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetImportedBounds_ptr, new IntPtr(p)); ;
                return *((BoxSphereBounds*)(b+0));
            }
        }
        internal struct GetNodeMappingContainer_method {
            static internal IntPtr GetNodeMappingContainer_ptr;
            static GetNodeMappingContainer_method() {
                GetNodeMappingContainer_ptr = Main.GetMethodUFunction(SkeletalMesh.StaticClass, "GetNodeMappingContainer");
            }

            internal static unsafe NodeMappingContainer Invoke(IntPtr obj, Blueprint SourceAsset) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SourceAsset;
                Main.GetProcessEvent(obj, GetNodeMappingContainer_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetSocketByIndex_method {
            static internal IntPtr GetSocketByIndex_ptr;
            static GetSocketByIndex_method() {
                GetSocketByIndex_ptr = Main.GetMethodUFunction(SkeletalMesh.StaticClass, "GetSocketByIndex");
            }

            internal static unsafe SkeletalMeshSocket Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, GetSocketByIndex_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct IsSectionUsingCloth_method {
            static internal IntPtr IsSectionUsingCloth_ptr;
            static IsSectionUsingCloth_method() {
                IsSectionUsingCloth_ptr = Main.GetMethodUFunction(SkeletalMesh.StaticClass, "IsSectionUsingCloth");
            }

            internal static unsafe bool Invoke(IntPtr obj, int InSectionIndex, bool bCheckCorrespondingSections) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InSectionIndex;
                *((bool*)(b+4)) = bCheckCorrespondingSections;
                Main.GetProcessEvent(obj, IsSectionUsingCloth_ptr, new IntPtr(p)); ;
                return *((bool*)(b+5));
            }
        }
        internal struct NumSockets_method {
            static internal IntPtr NumSockets_ptr;
            static NumSockets_method() {
                NumSockets_ptr = Main.GetMethodUFunction(SkeletalMesh.StaticClass, "NumSockets");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, NumSockets_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct SetLODSettings_method {
            static internal IntPtr SetLODSettings_ptr;
            static SetLODSettings_method() {
                SetLODSettings_ptr = Main.GetMethodUFunction(SkeletalMesh.StaticClass, "SetLODSettings");
            }

            internal static unsafe void Invoke(IntPtr obj, SkeletalMeshLODSettings InLODSettings) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InLODSettings;
                Main.GetProcessEvent(obj, SetLODSettings_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SkeletalMesh_events {
    }
}
