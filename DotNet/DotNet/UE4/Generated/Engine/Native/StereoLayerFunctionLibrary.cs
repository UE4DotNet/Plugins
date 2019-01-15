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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct StereoLayerFunctionLibrary_fields {
    }
    internal unsafe struct StereoLayerFunctionLibrary_methods {
        internal struct EnableAutoLoadingSplashScreen_method {
            static internal IntPtr EnableAutoLoadingSplashScreen_ptr;
            static EnableAutoLoadingSplashScreen_method() {
                EnableAutoLoadingSplashScreen_ptr = Main.GetMethodUFunction(StereoLayerFunctionLibrary.StaticClass, "EnableAutoLoadingSplashScreen");
            }

            internal static unsafe void Invoke(bool InAutoShowEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InAutoShowEnabled;
                Main.GetProcessEvent(StereoLayerFunctionLibrary.DefaultObject, EnableAutoLoadingSplashScreen_ptr, new IntPtr(p)); ;
            }
        }
        internal struct HideSplashScreen_method {
            static internal IntPtr HideSplashScreen_ptr;
            static HideSplashScreen_method() {
                HideSplashScreen_ptr = Main.GetMethodUFunction(StereoLayerFunctionLibrary.StaticClass, "HideSplashScreen");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(StereoLayerFunctionLibrary.DefaultObject, HideSplashScreen_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSplashScreen_method {
            static internal IntPtr SetSplashScreen_ptr;
            static SetSplashScreen_method() {
                SetSplashScreen_ptr = Main.GetMethodUFunction(StereoLayerFunctionLibrary.StaticClass, "SetSplashScreen");
            }

            internal static unsafe void Invoke(Texture Texture, Vector2D Scale, Vector2D Offset, bool bShowLoadingMovie, bool bShowOnSet) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Texture;
                *((Vector2D*)(b+8)) = Scale;
                *((Vector2D*)(b+16)) = Offset;
                *((bool*)(b+24)) = bShowLoadingMovie;
                *((bool*)(b+25)) = bShowOnSet;
                Main.GetProcessEvent(StereoLayerFunctionLibrary.DefaultObject, SetSplashScreen_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ShowSplashScreen_method {
            static internal IntPtr ShowSplashScreen_ptr;
            static ShowSplashScreen_method() {
                ShowSplashScreen_ptr = Main.GetMethodUFunction(StereoLayerFunctionLibrary.StaticClass, "ShowSplashScreen");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(StereoLayerFunctionLibrary.DefaultObject, ShowSplashScreen_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct StereoLayerFunctionLibrary_events {
    }
}
