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
    internal unsafe struct StaticMeshActor_fields {
        [FieldOffset(1008)]  public IntPtr  StaticMeshComponent;
        [FieldOffset(1016)] public bool bStaticMeshReplicateMovement;
        [FieldOffset(1017)] byte NavigationGeometryGatheringMode; //TODO: enum ENavDataGatheringMode NavigationGeometryGatheringMode
    }
    internal unsafe struct StaticMeshActor_methods {
        internal struct SetMobility_method {
            static internal IntPtr SetMobility_ptr;
            static SetMobility_method() {
                SetMobility_ptr = Main.GetMethodUFunction(StaticMeshActor.StaticClass, "SetMobility");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InMobility) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InMobility;
                Main.GetProcessEvent(obj, SetMobility_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct StaticMeshActor_events {
    }
}
