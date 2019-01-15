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
    [StructLayout( LayoutKind.Explicit, Size=1760 )]
    internal unsafe struct StaticMeshComponent_fields {
        [FieldOffset(1560)] public int ForcedLodModel;
        [FieldOffset(1564)] public int PreviousLODLevel;
        [FieldOffset(1568)] public int MinLOD;
        [FieldOffset(1572)] public int SubDivisionStepSize;
        [FieldOffset(1576)]  public IntPtr  StaticMesh;
        [FieldOffset(1584)] public Color WireframeColorOverride;
        [FieldOffset(1588)] public int SelectedEditorSection;
        [FieldOffset(1592)] public int SelectedEditorMaterial;
        [FieldOffset(1596)] public int SectionIndexPreview;
        [FieldOffset(1600)] public int MaterialIndexPreview;
        [FieldOffset(1604)] public int StaticMeshImportVersion;
        [FieldOffset(1608)] public bool bOverrideWireframeColor;
        [FieldOffset(1608)] public bool bOverrideMinLOD;
        [FieldOffset(1608)] public bool bOverrideNavigationExport;
        [FieldOffset(1608)] public bool bForceNavigationObstacle;
        [FieldOffset(1608)] public bool bDisallowMeshPaintPerInstance;
        [FieldOffset(1608)] public bool bIgnoreInstanceForTextureStreaming;
        [FieldOffset(1609)] public bool bOverrideLightMapRes;
        [FieldOffset(1609)] public bool bCastDistanceFieldIndirectShadow;
        [FieldOffset(1609)] public bool bOverrideDistanceFieldSelfShadowBias;
        [FieldOffset(1609)] public bool bUseSubDivisions;
        [FieldOffset(1609)] public bool bUseDefaultCollision;
        [FieldOffset(1609)] public bool bCustomOverrideVertexColorPerLOD;
        [FieldOffset(1609)] public bool bDisplayVertexColors;
        [FieldOffset(1609)] public bool bReverseCulling;
        [FieldOffset(1612)] public int OverriddenLightMapRes;
        [FieldOffset(1616)] public float DistanceFieldIndirectShadowMinVisibility;
        [FieldOffset(1620)] public float DistanceFieldSelfShadowBias;
        [FieldOffset(1624)] public float StreamingDistanceMultiplier;
        [FieldOffset(1648)] public NativeArray LODData;
        [FieldOffset(1664)] public NativeArray StreamingTextureData;
        [FieldOffset(1680)] byte StaticMeshDerivedDataKey; //TODO: string FString StaticMeshDerivedDataKey
        [FieldOffset(1696)] public NativeArray MaterialStreamingRelativeBoxes;
        [FieldOffset(1712)] public LightmassPrimitiveSettings LightmassSettings;
    }
    internal unsafe struct StaticMeshComponent_methods {
        internal struct GetLocalBounds_method {
            static internal IntPtr GetLocalBounds_ptr;
            static GetLocalBounds_method() {
                GetLocalBounds_ptr = Main.GetMethodUFunction(StaticMeshComponent.StaticClass, "GetLocalBounds");
            }

            internal static unsafe (Vector, Vector) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLocalBounds_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+0)),*((Vector*)(b+12)));
            }
        }
        internal struct SetDistanceFieldSelfShadowBias_method {
            static internal IntPtr SetDistanceFieldSelfShadowBias_ptr;
            static SetDistanceFieldSelfShadowBias_method() {
                SetDistanceFieldSelfShadowBias_ptr = Main.GetMethodUFunction(StaticMeshComponent.StaticClass, "SetDistanceFieldSelfShadowBias");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetDistanceFieldSelfShadowBias_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetForcedLodModel_method {
            static internal IntPtr SetForcedLodModel_ptr;
            static SetForcedLodModel_method() {
                SetForcedLodModel_ptr = Main.GetMethodUFunction(StaticMeshComponent.StaticClass, "SetForcedLodModel");
            }

            internal static unsafe void Invoke(IntPtr obj, int NewForcedLodModel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NewForcedLodModel;
                Main.GetProcessEvent(obj, SetForcedLodModel_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetReverseCulling_method {
            static internal IntPtr SetReverseCulling_ptr;
            static SetReverseCulling_method() {
                SetReverseCulling_ptr = Main.GetMethodUFunction(StaticMeshComponent.StaticClass, "SetReverseCulling");
            }

            internal static unsafe void Invoke(IntPtr obj, bool ReverseCulling) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = ReverseCulling;
                Main.GetProcessEvent(obj, SetReverseCulling_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStaticMesh_method {
            static internal IntPtr SetStaticMesh_ptr;
            static SetStaticMesh_method() {
                SetStaticMesh_ptr = Main.GetMethodUFunction(StaticMeshComponent.StaticClass, "SetStaticMesh");
            }

            internal static unsafe bool Invoke(IntPtr obj, StaticMesh NewMesh) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewMesh;
                Main.GetProcessEvent(obj, SetStaticMesh_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
    }
    internal unsafe struct StaticMeshComponent_events {
    }
}
