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

using UE4.Engine;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=480 )]
    internal unsafe struct Viewport_fields {
        [FieldOffset(424)] public LinearColor BackgroundColor;
    }
    internal unsafe struct Viewport_methods {
        internal struct GetViewLocation_method {
            static internal IntPtr GetViewLocation_ptr;
            static GetViewLocation_method() {
                GetViewLocation_ptr = Main.GetMethodUFunction(Viewport.StaticClass, "GetViewLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetViewLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetViewportWorld_method {
            static internal IntPtr GetViewportWorld_ptr;
            static GetViewportWorld_method() {
                GetViewportWorld_ptr = Main.GetMethodUFunction(Viewport.StaticClass, "GetViewportWorld");
            }

            internal static unsafe World Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetViewportWorld_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetViewRotation_method {
            static internal IntPtr GetViewRotation_ptr;
            static GetViewRotation_method() {
                GetViewRotation_ptr = Main.GetMethodUFunction(Viewport.StaticClass, "GetViewRotation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetViewRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+0));
            }
        }
        internal struct SetViewLocation_method {
            static internal IntPtr SetViewLocation_ptr;
            static SetViewLocation_method() {
                SetViewLocation_ptr = Main.GetMethodUFunction(Viewport.StaticClass, "SetViewLocation");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Location) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Location;
                Main.GetProcessEvent(obj, SetViewLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetViewRotation_method {
            static internal IntPtr SetViewRotation_ptr;
            static SetViewRotation_method() {
                SetViewRotation_ptr = Main.GetMethodUFunction(Viewport.StaticClass, "SetViewRotation");
            }

            internal static unsafe void Invoke(IntPtr obj, Rotator Rotation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = Rotation;
                Main.GetProcessEvent(obj, SetViewRotation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Spawn_method {
            static internal IntPtr Spawn_ptr;
            static Spawn_method() {
                Spawn_ptr = Main.GetMethodUFunction(Viewport.StaticClass, "Spawn");
            }

            internal static unsafe Actor Invoke(IntPtr obj, SubclassOf<Actor> ActorClass) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ActorClass;
                Main.GetProcessEvent(obj, Spawn_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
    }
    internal unsafe struct Viewport_events {
    }
}
