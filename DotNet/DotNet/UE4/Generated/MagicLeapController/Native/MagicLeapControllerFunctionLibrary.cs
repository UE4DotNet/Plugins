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

namespace UE4.MagicLeapController.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MagicLeapControllerFunctionLibrary_fields {
    }
    internal unsafe struct MagicLeapControllerFunctionLibrary_methods {
        internal struct CalibrateControllerNow_method {
            static internal IntPtr CalibrateControllerNow_ptr;
            static CalibrateControllerNow_method() {
                CalibrateControllerNow_ptr = Main.GetMethodUFunction(MagicLeapControllerFunctionLibrary.StaticClass, "CalibrateControllerNow");
            }

            internal static unsafe void Invoke(EControllerHand Hand, Vector StartPosition, Rotator StartOrientation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                *((Vector*)(b+4)) = StartPosition;
                *((Rotator*)(b+16)) = StartOrientation;
                Main.GetProcessEvent(MagicLeapControllerFunctionLibrary.DefaultObject, CalibrateControllerNow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetControllerMapping_method {
            static internal IntPtr GetControllerMapping_ptr;
            static GetControllerMapping_method() {
                GetControllerMapping_ptr = Main.GetMethodUFunction(MagicLeapControllerFunctionLibrary.StaticClass, "GetControllerMapping");
            }

            internal static unsafe (EControllerHand, bool) Invoke(int ControllerIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ControllerIndex;
                Main.GetProcessEvent(MagicLeapControllerFunctionLibrary.DefaultObject, GetControllerMapping_ptr, new IntPtr(p)); ;
                return (*((EControllerHand*)(b+4)),*((bool*)(b+5)));
            }
        }
        internal struct GetMLControllerType_method {
            static internal IntPtr GetMLControllerType_ptr;
            static GetMLControllerType_method() {
                GetMLControllerType_ptr = Main.GetMethodUFunction(MagicLeapControllerFunctionLibrary.StaticClass, "GetMLControllerType");
            }

            internal static unsafe EMLControllerType Invoke(EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(MagicLeapControllerFunctionLibrary.DefaultObject, GetMLControllerType_ptr, new IntPtr(p)); ;
                return *((EMLControllerType*)(b+1));
            }
        }
        internal struct InvertControllerMapping_method {
            static internal IntPtr InvertControllerMapping_ptr;
            static InvertControllerMapping_method() {
                InvertControllerMapping_ptr = Main.GetMethodUFunction(MagicLeapControllerFunctionLibrary.StaticClass, "InvertControllerMapping");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapControllerFunctionLibrary.DefaultObject, InvertControllerMapping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct MaxSupportedMagicLeapControllers_method {
            static internal IntPtr MaxSupportedMagicLeapControllers_ptr;
            static MaxSupportedMagicLeapControllers_method() {
                MaxSupportedMagicLeapControllers_ptr = Main.GetMethodUFunction(MagicLeapControllerFunctionLibrary.StaticClass, "MaxSupportedMagicLeapControllers");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapControllerFunctionLibrary.DefaultObject, MaxSupportedMagicLeapControllers_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct PlayControllerHapticFeedback_method {
            static internal IntPtr PlayControllerHapticFeedback_ptr;
            static PlayControllerHapticFeedback_method() {
                PlayControllerHapticFeedback_ptr = Main.GetMethodUFunction(MagicLeapControllerFunctionLibrary.StaticClass, "PlayControllerHapticFeedback");
            }

            internal static unsafe bool Invoke(EControllerHand Hand, EMLControllerHapticPattern HapticPattern, EMLControllerHapticIntensity Intensity) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                *(b+1) = (byte)HapticPattern;
                *(b+2) = (byte)Intensity;
                Main.GetProcessEvent(MagicLeapControllerFunctionLibrary.DefaultObject, PlayControllerHapticFeedback_ptr, new IntPtr(p)); ;
                return *((bool*)(b+3));
            }
        }
        internal struct PlayControllerLED_method {
            static internal IntPtr PlayControllerLED_ptr;
            static PlayControllerLED_method() {
                PlayControllerLED_ptr = Main.GetMethodUFunction(MagicLeapControllerFunctionLibrary.StaticClass, "PlayControllerLED");
            }

            internal static unsafe bool Invoke(EControllerHand Hand, EMLControllerLEDPattern LEDPattern, EMLControllerLEDColor LEDColor, float DurationInSec) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                *(b+1) = (byte)LEDPattern;
                *(b+2) = (byte)LEDColor;
                *((float*)(b+4)) = DurationInSec;
                Main.GetProcessEvent(MagicLeapControllerFunctionLibrary.DefaultObject, PlayControllerLED_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct PlayControllerLEDEffect_method {
            static internal IntPtr PlayControllerLEDEffect_ptr;
            static PlayControllerLEDEffect_method() {
                PlayControllerLEDEffect_ptr = Main.GetMethodUFunction(MagicLeapControllerFunctionLibrary.StaticClass, "PlayControllerLEDEffect");
            }

            internal static unsafe bool Invoke(EControllerHand Hand, EMLControllerLEDEffect LEDEffect, EMLControllerLEDSpeed LEDSpeed, EMLControllerLEDPattern LEDPattern, EMLControllerLEDColor LEDColor, float DurationInSec) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                *(b+1) = (byte)LEDEffect;
                *(b+2) = (byte)LEDSpeed;
                *(b+3) = (byte)LEDPattern;
                *(b+4) = (byte)LEDColor;
                *((float*)(b+8)) = DurationInSec;
                Main.GetProcessEvent(MagicLeapControllerFunctionLibrary.DefaultObject, PlayControllerLEDEffect_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
    }
    internal unsafe struct MagicLeapControllerFunctionLibrary_events {
    }
}
