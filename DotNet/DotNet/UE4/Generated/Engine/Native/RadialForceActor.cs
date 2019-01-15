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
    [StructLayout( LayoutKind.Explicit, Size=1024 )]
    internal unsafe struct RadialForceActor_fields {
        [FieldOffset(1008)]  public IntPtr  ForceComponent;
        [FieldOffset(1016)]  public IntPtr  SpriteComponent;
    }
    internal unsafe struct RadialForceActor_methods {
        internal struct DisableForce_method {
            static internal IntPtr DisableForce_ptr;
            static DisableForce_method() {
                DisableForce_ptr = Main.GetMethodUFunction(RadialForceActor.StaticClass, "DisableForce");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, DisableForce_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableForce_method {
            static internal IntPtr EnableForce_ptr;
            static EnableForce_method() {
                EnableForce_ptr = Main.GetMethodUFunction(RadialForceActor.StaticClass, "EnableForce");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, EnableForce_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FireImpulse_method {
            static internal IntPtr FireImpulse_ptr;
            static FireImpulse_method() {
                FireImpulse_ptr = Main.GetMethodUFunction(RadialForceActor.StaticClass, "FireImpulse");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, FireImpulse_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ToggleForce_method {
            static internal IntPtr ToggleForce_ptr;
            static ToggleForce_method() {
                ToggleForce_ptr = Main.GetMethodUFunction(RadialForceActor.StaticClass, "ToggleForce");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ToggleForce_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct RadialForceActor_events {
    }
}
