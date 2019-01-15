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
    [StructLayout( LayoutKind.Explicit, Size=304 )]
    internal unsafe struct MaterialInterface_fields {
        [FieldOffset(72)]  public IntPtr  SubsurfaceProfile;
        [FieldOffset(88)] public LightmassMaterialInterfaceSettings LightmassSettings;
        [FieldOffset(108)] public bool bTextureStreamingDataSorted;
        [FieldOffset(112)] public int TextureStreamingDataVersion;
        [FieldOffset(120)] public NativeArray TextureStreamingData;
        [FieldOffset(136)] public NativeArray AssetUserData;
        [FieldOffset(152)] public SoftObjectPath PreviewMesh;
        [FieldOffset(184)]  public IntPtr  ThumbnailInfo;
        [FieldOffset(192)] byte LayerParameterExpansion; //TODO: map TMap LayerParameterExpansion
        [FieldOffset(272)]  public IntPtr  AssetImportData;
        [FieldOffset(280)] public FGuid LightingGuid;
    }
    internal unsafe struct MaterialInterface_methods {
        internal struct GetBaseMaterial_method {
            static internal IntPtr GetBaseMaterial_ptr;
            static GetBaseMaterial_method() {
                GetBaseMaterial_ptr = Main.GetMethodUFunction(MaterialInterface.StaticClass, "GetBaseMaterial");
            }

            internal static unsafe Material Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetBaseMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetPhysicalMaterial_method {
            static internal IntPtr GetPhysicalMaterial_ptr;
            static GetPhysicalMaterial_method() {
                GetPhysicalMaterial_ptr = Main.GetMethodUFunction(MaterialInterface.StaticClass, "GetPhysicalMaterial");
            }

            internal static unsafe PhysicalMaterial Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPhysicalMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct SetForceMipLevelsToBeResident_method {
            static internal IntPtr SetForceMipLevelsToBeResident_ptr;
            static SetForceMipLevelsToBeResident_method() {
                SetForceMipLevelsToBeResident_ptr = Main.GetMethodUFunction(MaterialInterface.StaticClass, "SetForceMipLevelsToBeResident");
            }

            internal static unsafe void Invoke(IntPtr obj, bool OverrideForceMiplevelsToBeResident, bool bForceMiplevelsToBeResidentValue, float ForceDuration, int CinematicTextureGroups) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = OverrideForceMiplevelsToBeResident;
                *((bool*)(b+1)) = bForceMiplevelsToBeResidentValue;
                *((float*)(b+4)) = ForceDuration;
                *((int*)(b+8)) = CinematicTextureGroups;
                Main.GetProcessEvent(obj, SetForceMipLevelsToBeResident_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MaterialInterface_events {
    }
}
