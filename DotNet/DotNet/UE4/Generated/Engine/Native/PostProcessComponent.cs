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
    [StructLayout( LayoutKind.Explicit, Size=1968 )]
    internal unsafe struct PostProcessComponent_fields {
        [FieldOffset(640)] public PostProcessSettings Settings;
        [FieldOffset(1952)] public float Priority;
        [FieldOffset(1956)] public float BlendRadius;
        [FieldOffset(1960)] public float BlendWeight;
        [FieldOffset(1964)] public bool bEnabled;
        [FieldOffset(1964)] public bool bUnbound;
    }
    internal unsafe struct PostProcessComponent_methods {
        internal struct AddOrUpdateBlendable_method {
            static internal IntPtr AddOrUpdateBlendable_ptr;
            static AddOrUpdateBlendable_method() {
                AddOrUpdateBlendable_ptr = Main.GetMethodUFunction(PostProcessComponent.StaticClass, "AddOrUpdateBlendable");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InBlendableObject /*TODO: interface TScriptInterface */, float InWeight) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface InBlendableObject
                *((float*)(b+16)) = InWeight;
                Main.GetProcessEvent(obj, AddOrUpdateBlendable_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface InBlendableObject
            }
        }
    }
    internal unsafe struct PostProcessComponent_events {
    }
}
