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
    [StructLayout( LayoutKind.Explicit, Size=656 )]
    internal unsafe struct WindDirectionalSourceComponent_fields {
        [FieldOffset(624)] public float Strength;
        [FieldOffset(628)] public float Speed;
        [FieldOffset(632)] public float MinGustAmount;
        [FieldOffset(636)] public float MaxGustAmount;
        [FieldOffset(640)] public float Radius;
        [FieldOffset(644)] public bool bPointWind;
    }
    internal unsafe struct WindDirectionalSourceComponent_methods {
        internal struct SetMaximumGustAmount_method {
            static internal IntPtr SetMaximumGustAmount_ptr;
            static SetMaximumGustAmount_method() {
                SetMaximumGustAmount_ptr = Main.GetMethodUFunction(WindDirectionalSourceComponent.StaticClass, "SetMaximumGustAmount");
            }

            internal static unsafe void Invoke(IntPtr obj, float InNewMaxGust) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InNewMaxGust;
                Main.GetProcessEvent(obj, SetMaximumGustAmount_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMinimumGustAmount_method {
            static internal IntPtr SetMinimumGustAmount_ptr;
            static SetMinimumGustAmount_method() {
                SetMinimumGustAmount_ptr = Main.GetMethodUFunction(WindDirectionalSourceComponent.StaticClass, "SetMinimumGustAmount");
            }

            internal static unsafe void Invoke(IntPtr obj, float InNewMinGust) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InNewMinGust;
                Main.GetProcessEvent(obj, SetMinimumGustAmount_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRadius_method {
            static internal IntPtr SetRadius_ptr;
            static SetRadius_method() {
                SetRadius_ptr = Main.GetMethodUFunction(WindDirectionalSourceComponent.StaticClass, "SetRadius");
            }

            internal static unsafe void Invoke(IntPtr obj, float InNewRadius) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InNewRadius;
                Main.GetProcessEvent(obj, SetRadius_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSpeed_method {
            static internal IntPtr SetSpeed_ptr;
            static SetSpeed_method() {
                SetSpeed_ptr = Main.GetMethodUFunction(WindDirectionalSourceComponent.StaticClass, "SetSpeed");
            }

            internal static unsafe void Invoke(IntPtr obj, float InNewSpeed) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InNewSpeed;
                Main.GetProcessEvent(obj, SetSpeed_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStrength_method {
            static internal IntPtr SetStrength_ptr;
            static SetStrength_method() {
                SetStrength_ptr = Main.GetMethodUFunction(WindDirectionalSourceComponent.StaticClass, "SetStrength");
            }

            internal static unsafe void Invoke(IntPtr obj, float InNewStrength) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InNewStrength;
                Main.GetProcessEvent(obj, SetStrength_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWindType_method {
            static internal IntPtr SetWindType_ptr;
            static SetWindType_method() {
                SetWindType_ptr = Main.GetMethodUFunction(WindDirectionalSourceComponent.StaticClass, "SetWindType");
            }

            internal static unsafe void Invoke(IntPtr obj, EWindSourceType InNewType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)InNewType;
                Main.GetProcessEvent(obj, SetWindType_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct WindDirectionalSourceComponent_events {
    }
}
