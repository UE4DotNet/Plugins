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
    [StructLayout( LayoutKind.Explicit, Size=288 )]
    internal unsafe struct PlatformEventsComponent_fields {
        [FieldOffset(256)] byte PlatformChangedToLaptopModeDelegate; //TODO: multicast delegate FPlatformEventDelegate PlatformChangedToLaptopModeDelegate
        [FieldOffset(272)] byte PlatformChangedToTabletModeDelegate; //TODO: multicast delegate FPlatformEventDelegate PlatformChangedToTabletModeDelegate
    }
    internal unsafe struct PlatformEventsComponent_methods {
        internal struct IsInLaptopMode_method {
            static internal IntPtr IsInLaptopMode_ptr;
            static IsInLaptopMode_method() {
                IsInLaptopMode_ptr = Main.GetMethodUFunction(PlatformEventsComponent.StaticClass, "IsInLaptopMode");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsInLaptopMode_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsInTabletMode_method {
            static internal IntPtr IsInTabletMode_ptr;
            static IsInTabletMode_method() {
                IsInTabletMode_ptr = Main.GetMethodUFunction(PlatformEventsComponent.StaticClass, "IsInTabletMode");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsInTabletMode_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SupportsConvertibleLaptops_method {
            static internal IntPtr SupportsConvertibleLaptops_ptr;
            static SupportsConvertibleLaptops_method() {
                SupportsConvertibleLaptops_ptr = Main.GetMethodUFunction(PlatformEventsComponent.StaticClass, "SupportsConvertibleLaptops");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SupportsConvertibleLaptops_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct PlatformEventsComponent_events {
    }
}
