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
    [StructLayout( LayoutKind.Explicit, Size=1552 )]
    internal unsafe struct MeshComponent_fields {
        [FieldOffset(1504)] public NativeArray OverrideMaterials;
    }
    internal unsafe struct MeshComponent_methods {
        internal struct GetMaterialIndex_method {
            static internal IntPtr GetMaterialIndex_ptr;
            static GetMaterialIndex_method() {
                GetMaterialIndex_ptr = Main.GetMethodUFunction(MeshComponent.StaticClass, "GetMaterialIndex");
            }

            internal static unsafe int Invoke(IntPtr obj, Name MaterialSlotName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = MaterialSlotName;
                Main.GetProcessEvent(obj, GetMaterialIndex_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct GetMaterials_method {
            static internal IntPtr GetMaterials_ptr;
            static GetMaterials_method() {
                GetMaterials_ptr = Main.GetMethodUFunction(MeshComponent.StaticClass, "GetMaterials");
            }

            internal static unsafe IReadOnlyCollection<MaterialInterface> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMaterials_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUObjectCollection<MaterialInterface>(b+0);
            }
        }
        internal struct GetMaterialSlotNames_method {
            static internal IntPtr GetMaterialSlotNames_ptr;
            static GetMaterialSlotNames_method() {
                GetMaterialSlotNames_ptr = Main.GetMethodUFunction(MeshComponent.StaticClass, "GetMaterialSlotNames");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMaterialSlotNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<Name>(b+0);
            }
        }
        internal struct IsMaterialSlotNameValid_method {
            static internal IntPtr IsMaterialSlotNameValid_ptr;
            static IsMaterialSlotNameValid_method() {
                IsMaterialSlotNameValid_ptr = Main.GetMethodUFunction(MeshComponent.StaticClass, "IsMaterialSlotNameValid");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name MaterialSlotName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = MaterialSlotName;
                Main.GetProcessEvent(obj, IsMaterialSlotNameValid_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct PrestreamTextures_method {
            static internal IntPtr PrestreamTextures_ptr;
            static PrestreamTextures_method() {
                PrestreamTextures_ptr = Main.GetMethodUFunction(MeshComponent.StaticClass, "PrestreamTextures");
            }

            internal static unsafe void Invoke(IntPtr obj, float Seconds, bool bPrioritizeCharacterTextures, int CinematicTextureGroups) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Seconds;
                *((bool*)(b+4)) = bPrioritizeCharacterTextures;
                *((int*)(b+8)) = CinematicTextureGroups;
                Main.GetProcessEvent(obj, PrestreamTextures_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetScalarParameterValueOnMaterials_method {
            static internal IntPtr SetScalarParameterValueOnMaterials_ptr;
            static SetScalarParameterValueOnMaterials_method() {
                SetScalarParameterValueOnMaterials_ptr = Main.GetMethodUFunction(MeshComponent.StaticClass, "SetScalarParameterValueOnMaterials");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, float ParameterValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((float*)(b+12)) = ParameterValue;
                Main.GetProcessEvent(obj, SetScalarParameterValueOnMaterials_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVectorParameterValueOnMaterials_method {
            static internal IntPtr SetVectorParameterValueOnMaterials_ptr;
            static SetVectorParameterValueOnMaterials_method() {
                SetVectorParameterValueOnMaterials_ptr = Main.GetMethodUFunction(MeshComponent.StaticClass, "SetVectorParameterValueOnMaterials");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, Vector ParameterValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((Vector*)(b+12)) = ParameterValue;
                Main.GetProcessEvent(obj, SetVectorParameterValueOnMaterials_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MeshComponent_events {
    }
}
