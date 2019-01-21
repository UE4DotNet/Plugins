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


namespace UE4.VariantManagerContent.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct LevelVariantSets_fields {
        [FieldOffset(56)] public NativeArray VariantSets;
        [FieldOffset(72)] byte DisplayNodeExpansionStates; //TODO: map TMap DisplayNodeExpansionStates
    }
    internal unsafe struct LevelVariantSets_methods {
        internal struct GetNumVariantSets_method {
            static internal IntPtr GetNumVariantSets_ptr;
            static GetNumVariantSets_method() {
                GetNumVariantSets_ptr = Main.GetMethodUFunction(LevelVariantSets.StaticClass, "GetNumVariantSets");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumVariantSets_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetVariantSet_method {
            static internal IntPtr GetVariantSet_ptr;
            static GetVariantSet_method() {
                GetVariantSet_ptr = Main.GetMethodUFunction(LevelVariantSets.StaticClass, "GetVariantSet");
            }

            internal static unsafe VariantSet Invoke(IntPtr obj, int VariantSetIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = VariantSetIndex;
                Main.GetProcessEvent(obj, GetVariantSet_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
    }
    internal unsafe struct LevelVariantSets_events {
    }
}
