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
    [StructLayout( LayoutKind.Explicit, Size=72 )]
    internal unsafe struct NavigationSystem_fields {
    }
    internal unsafe struct NavigationSystem_methods {
        internal struct SimpleMoveToActor_method {
            static internal IntPtr SimpleMoveToActor_ptr;
            static SimpleMoveToActor_method() {
                SimpleMoveToActor_ptr = Main.GetMethodUFunction(NavigationSystem.StaticClass, "SimpleMoveToActor");
            }

            internal static unsafe void Invoke(Controller Controller, Actor Goal) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                *((IntPtr*)(b+8)) = Goal;
                Main.GetProcessEvent(NavigationSystem.DefaultObject, SimpleMoveToActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SimpleMoveToLocation_method {
            static internal IntPtr SimpleMoveToLocation_ptr;
            static SimpleMoveToLocation_method() {
                SimpleMoveToLocation_ptr = Main.GetMethodUFunction(NavigationSystem.StaticClass, "SimpleMoveToLocation");
            }

            internal static unsafe void Invoke(Controller Controller, Vector Goal) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                *((Vector*)(b+8)) = Goal;
                Main.GetProcessEvent(NavigationSystem.DefaultObject, SimpleMoveToLocation_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct NavigationSystem_events {
    }
}
