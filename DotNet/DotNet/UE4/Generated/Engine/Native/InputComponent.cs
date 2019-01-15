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

using UE4.InputCore;

namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=392 )]
    internal unsafe struct InputComponent_fields {
        [FieldOffset(368)] public NativeArray CachedKeyToActionInfo;
    }
    internal unsafe struct InputComponent_methods {
        internal struct GetControllerAnalogKeyState_method {
            static internal IntPtr GetControllerAnalogKeyState_ptr;
            static GetControllerAnalogKeyState_method() {
                GetControllerAnalogKeyState_ptr = Main.GetMethodUFunction(InputComponent.StaticClass, "GetControllerAnalogKeyState");
            }

            internal static unsafe float Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, GetControllerAnalogKeyState_ptr, new IntPtr(p)); ;
                return *((float*)(b+32));
            }
        }
        internal struct GetControllerAnalogStickState_method {
            static internal IntPtr GetControllerAnalogStickState_ptr;
            static GetControllerAnalogStickState_method() {
                GetControllerAnalogStickState_ptr = Main.GetMethodUFunction(InputComponent.StaticClass, "GetControllerAnalogStickState");
            }

            internal static unsafe (float, float) Invoke(IntPtr obj, byte WhichStick) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = WhichStick;
                Main.GetProcessEvent(obj, GetControllerAnalogStickState_ptr, new IntPtr(p)); ;
                return (*((float*)(b+4)),*((float*)(b+8)));
            }
        }
        internal struct GetControllerKeyTimeDown_method {
            static internal IntPtr GetControllerKeyTimeDown_ptr;
            static GetControllerKeyTimeDown_method() {
                GetControllerKeyTimeDown_ptr = Main.GetMethodUFunction(InputComponent.StaticClass, "GetControllerKeyTimeDown");
            }

            internal static unsafe float Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, GetControllerKeyTimeDown_ptr, new IntPtr(p)); ;
                return *((float*)(b+32));
            }
        }
        internal struct GetControllerMouseDelta_method {
            static internal IntPtr GetControllerMouseDelta_ptr;
            static GetControllerMouseDelta_method() {
                GetControllerMouseDelta_ptr = Main.GetMethodUFunction(InputComponent.StaticClass, "GetControllerMouseDelta");
            }

            internal static unsafe (float, float) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetControllerMouseDelta_ptr, new IntPtr(p)); ;
                return (*((float*)(b+0)),*((float*)(b+4)));
            }
        }
        internal struct GetControllerVectorKeyState_method {
            static internal IntPtr GetControllerVectorKeyState_ptr;
            static GetControllerVectorKeyState_method() {
                GetControllerVectorKeyState_ptr = Main.GetMethodUFunction(InputComponent.StaticClass, "GetControllerVectorKeyState");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, GetControllerVectorKeyState_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+32));
            }
        }
        internal struct GetTouchState_method {
            static internal IntPtr GetTouchState_ptr;
            static GetTouchState_method() {
                GetTouchState_ptr = Main.GetMethodUFunction(InputComponent.StaticClass, "GetTouchState");
            }

            internal static unsafe (float, float, bool) Invoke(IntPtr obj, int FingerIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = FingerIndex;
                Main.GetProcessEvent(obj, GetTouchState_ptr, new IntPtr(p)); ;
                return (*((float*)(b+4)),*((float*)(b+8)),*((bool*)(b+12)));
            }
        }
        internal struct IsControllerKeyDown_method {
            static internal IntPtr IsControllerKeyDown_ptr;
            static IsControllerKeyDown_method() {
                IsControllerKeyDown_ptr = Main.GetMethodUFunction(InputComponent.StaticClass, "IsControllerKeyDown");
            }

            internal static unsafe bool Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, IsControllerKeyDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct WasControllerKeyJustPressed_method {
            static internal IntPtr WasControllerKeyJustPressed_ptr;
            static WasControllerKeyJustPressed_method() {
                WasControllerKeyJustPressed_ptr = Main.GetMethodUFunction(InputComponent.StaticClass, "WasControllerKeyJustPressed");
            }

            internal static unsafe bool Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, WasControllerKeyJustPressed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct WasControllerKeyJustReleased_method {
            static internal IntPtr WasControllerKeyJustReleased_ptr;
            static WasControllerKeyJustReleased_method() {
                WasControllerKeyJustReleased_ptr = Main.GetMethodUFunction(InputComponent.StaticClass, "WasControllerKeyJustReleased");
            }

            internal static unsafe bool Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, WasControllerKeyJustReleased_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
    }
    internal unsafe struct InputComponent_events {
    }
}
