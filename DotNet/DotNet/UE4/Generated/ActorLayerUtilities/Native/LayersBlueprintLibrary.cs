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

namespace UE4.ActorLayerUtilities.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct LayersBlueprintLibrary_fields {
    }
    internal unsafe struct LayersBlueprintLibrary_methods {
        internal struct GetActors_method {
            static internal IntPtr GetActors_ptr;
            static GetActors_method() {
                GetActors_ptr = Main.GetMethodUFunction(LayersBlueprintLibrary.StaticClass, "GetActors");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(UObject WorldContextObject, ActorLayer ActorLayer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((ActorLayer*)(b+8)) = ActorLayer;
                Main.GetProcessEvent(LayersBlueprintLibrary.DefaultObject, GetActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUObjectCollection<Actor>(b+24);
            }
        }
    }
    internal unsafe struct LayersBlueprintLibrary_events {
    }
}
