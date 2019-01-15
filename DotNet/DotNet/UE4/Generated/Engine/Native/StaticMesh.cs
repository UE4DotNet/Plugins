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
    [StructLayout( LayoutKind.Explicit, Size=888 )]
    internal unsafe struct StaticMesh_fields {
        [FieldOffset(88)] public NativeArray SourceModels;
        [FieldOffset(104)]  public IntPtr  MeshDescriptions;
        [FieldOffset(112)] public MeshSectionInfoMap SectionInfoMap;
        [FieldOffset(192)] public MeshSectionInfoMap OriginalSectionInfoMap;
        [FieldOffset(272)] public Name LODGroup;
        [FieldOffset(284)] public bool bAutoComputeLODScreenSize;
        [FieldOffset(288)] public int ImportVersion;
        [FieldOffset(296)] public NativeArray MaterialRemapIndexPerImportVersion;
        [FieldOffset(312)] public int LightmapUVVersion;
        [FieldOffset(320)] public PerPlatformInt MinLOD;
        [FieldOffset(424)] public NativeArray StaticMaterials;
        [FieldOffset(440)] public float LightmapUVDensity;
        [FieldOffset(444)] public int LightMapResolution;
        [FieldOffset(448)] public int LightMapCoordinateIndex;
        [FieldOffset(452)] public float DistanceFieldSelfShadowBias;
        [FieldOffset(456)] public bool bGenerateMeshDistanceField;
        [FieldOffset(464)]  public IntPtr  BodySetup;
        [FieldOffset(472)] public int LODForCollision;
        [FieldOffset(476)] public bool bHasNavigationData;
        [FieldOffset(476)] public bool bSupportUniformlyDistributedSampling;
        [FieldOffset(480)] public float LpvBiasMultiplier;
        [FieldOffset(484)] public bool bAllowCPUAccess;
        [FieldOffset(512)]  public IntPtr  AssetImportData;
        [FieldOffset(552)]  public IntPtr  ThumbnailInfo;
        [FieldOffset(560)] public AssetEditorOrbitCameraPosition EditorCameraPosition;
        [FieldOffset(600)] public bool bCustomizedCollision;
        [FieldOffset(604)] public int LODForOccluderMesh;
        [FieldOffset(632)] public NativeArray Sockets;
        [FieldOffset(664)] public Vector PositiveBoundsExtension;
        [FieldOffset(676)] public Vector NegativeBoundsExtension;
        [FieldOffset(688)] public BoxSphereBounds ExtendedBounds;
        [FieldOffset(784)] public int ElementToIgnoreForTexFactor;
        [FieldOffset(792)] public NativeArray AssetUserData;
        [FieldOffset(816)]  public IntPtr  EditableMesh;
        [FieldOffset(824)]  public IntPtr  NavCollision;
    }
    internal unsafe struct StaticMesh_methods {
        internal struct GetBoundingBox_method {
            static internal IntPtr GetBoundingBox_ptr;
            static GetBoundingBox_method() {
                GetBoundingBox_ptr = Main.GetMethodUFunction(StaticMesh.StaticClass, "GetBoundingBox");
            }

            internal static unsafe Box Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetBoundingBox_ptr, new IntPtr(p)); ;
                return *((Box*)(b+0));
            }
        }
        internal struct GetBounds_method {
            static internal IntPtr GetBounds_ptr;
            static GetBounds_method() {
                GetBounds_ptr = Main.GetMethodUFunction(StaticMesh.StaticClass, "GetBounds");
            }

            internal static unsafe BoxSphereBounds Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetBounds_ptr, new IntPtr(p)); ;
                return *((BoxSphereBounds*)(b+0));
            }
        }
        internal struct GetMaterial_method {
            static internal IntPtr GetMaterial_ptr;
            static GetMaterial_method() {
                GetMaterial_ptr = Main.GetMethodUFunction(StaticMesh.StaticClass, "GetMaterial");
            }

            internal static unsafe MaterialInterface Invoke(IntPtr obj, int MaterialIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MaterialIndex;
                Main.GetProcessEvent(obj, GetMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetMaterialIndex_method {
            static internal IntPtr GetMaterialIndex_ptr;
            static GetMaterialIndex_method() {
                GetMaterialIndex_ptr = Main.GetMethodUFunction(StaticMesh.StaticClass, "GetMaterialIndex");
            }

            internal static unsafe int Invoke(IntPtr obj, Name MaterialSlotName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = MaterialSlotName;
                Main.GetProcessEvent(obj, GetMaterialIndex_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct GetNumLODs_method {
            static internal IntPtr GetNumLODs_ptr;
            static GetNumLODs_method() {
                GetNumLODs_ptr = Main.GetMethodUFunction(StaticMesh.StaticClass, "GetNumLODs");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumLODs_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetNumSections_method {
            static internal IntPtr GetNumSections_ptr;
            static GetNumSections_method() {
                GetNumSections_ptr = Main.GetMethodUFunction(StaticMesh.StaticClass, "GetNumSections");
            }

            internal static unsafe int Invoke(IntPtr obj, int InLOD) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InLOD;
                Main.GetProcessEvent(obj, GetNumSections_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct SetMaterial_method {
            static internal IntPtr SetMaterial_ptr;
            static SetMaterial_method() {
                SetMaterial_ptr = Main.GetMethodUFunction(StaticMesh.StaticClass, "SetMaterial");
            }

            internal static unsafe void Invoke(IntPtr obj, int MaterialIndex, MaterialInterface NewMaterial) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MaterialIndex;
                *((IntPtr*)(b+8)) = NewMaterial;
                Main.GetProcessEvent(obj, SetMaterial_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct StaticMesh_events {
    }
}
