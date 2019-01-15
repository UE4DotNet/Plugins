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
    [StructLayout( LayoutKind.Explicit, Size=688 )]
    internal unsafe struct ChildActorComponent_fields {
        [FieldOffset(624)] public IntPtr ChildActorClass;
        [FieldOffset(632)]  public IntPtr  ChildActor;
        [FieldOffset(640)]  public IntPtr  ChildActorTemplate;
    }
    internal unsafe struct ChildActorComponent_methods {
        internal struct SetChildActorClass_method {
            static internal IntPtr SetChildActorClass_ptr;
            static SetChildActorClass_method() {
                SetChildActorClass_ptr = Main.GetMethodUFunction(ChildActorComponent.StaticClass, "SetChildActorClass");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<Actor> InClass) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InClass;
                Main.GetProcessEvent(obj, SetChildActorClass_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ChildActorComponent_events {
    }
}
