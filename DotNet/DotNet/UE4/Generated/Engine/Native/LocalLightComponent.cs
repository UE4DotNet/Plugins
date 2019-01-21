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
    [StructLayout( LayoutKind.Explicit, Size=976 )]
    internal unsafe struct LocalLightComponent_fields {
        [FieldOffset(952)] byte IntensityUnits; //TODO: enum ELightUnits IntensityUnits
        [FieldOffset(960)] public float AttenuationRadius;
        [FieldOffset(964)] public LightmassPointLightSettings LightmassSettings;
    }
    internal unsafe struct LocalLightComponent_methods {
        internal struct GetUnitsConversionFactor_method {
            static internal IntPtr GetUnitsConversionFactor_ptr;
            static GetUnitsConversionFactor_method() {
                GetUnitsConversionFactor_ptr = Main.GetMethodUFunction(LocalLightComponent.StaticClass, "GetUnitsConversionFactor");
            }

            internal static unsafe float Invoke(ELightUnits SrcUnits, ELightUnits TargetUnits, float CosHalfConeAngle) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)SrcUnits;
                *(b+1) = (byte)TargetUnits;
                *((float*)(b+4)) = CosHalfConeAngle;
                Main.GetProcessEvent(LocalLightComponent.DefaultObject, GetUnitsConversionFactor_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct SetAttenuationRadius_method {
            static internal IntPtr SetAttenuationRadius_ptr;
            static SetAttenuationRadius_method() {
                SetAttenuationRadius_ptr = Main.GetMethodUFunction(LocalLightComponent.StaticClass, "SetAttenuationRadius");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewRadius) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewRadius;
                Main.GetProcessEvent(obj, SetAttenuationRadius_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct LocalLightComponent_events {
    }
}
