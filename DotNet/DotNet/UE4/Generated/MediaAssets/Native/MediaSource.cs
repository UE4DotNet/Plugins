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


namespace UE4.MediaAssets.Native {
    [StructLayout( LayoutKind.Explicit, Size=64 )]
    internal unsafe struct MediaSource_fields {
    }
    internal unsafe struct MediaSource_methods {
        internal struct GetUrl_method {
            static internal IntPtr GetUrl_ptr;
            static GetUrl_method() {
                GetUrl_ptr = Main.GetMethodUFunction(MediaSource.StaticClass, "GetUrl");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUrl_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct Validate_method {
            static internal IntPtr Validate_ptr;
            static Validate_method() {
                Validate_ptr = Main.GetMethodUFunction(MediaSource.StaticClass, "Validate");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Validate_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct MediaSource_events {
    }
}
