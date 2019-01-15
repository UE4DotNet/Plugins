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

using UE4.Slate;
using UE4.InputCore;
using UE4.SlateCore;

namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct KismetInputLibrary_fields {
    }
    internal unsafe struct KismetInputLibrary_methods {
        internal struct CalibrateTilt_method {
            static internal IntPtr CalibrateTilt_ptr;
            static CalibrateTilt_method() {
                CalibrateTilt_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "CalibrateTilt");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, CalibrateTilt_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EqualEqual_InputChordInputChord_method {
            static internal IntPtr EqualEqual_InputChordInputChord_ptr;
            static EqualEqual_InputChordInputChord_method() {
                EqualEqual_InputChordInputChord_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "EqualEqual_InputChordInputChord");
            }

            internal static unsafe bool Invoke(InputChord A, InputChord B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputChord*)(b+0)) = A;
                *((InputChord*)(b+40)) = B;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, EqualEqual_InputChordInputChord_ptr, new IntPtr(p)); ;
                return *((bool*)(b+80));
            }
        }
        internal struct EqualEqual_KeyKey_method {
            static internal IntPtr EqualEqual_KeyKey_ptr;
            static EqualEqual_KeyKey_method() {
                EqualEqual_KeyKey_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "EqualEqual_KeyKey");
            }

            internal static unsafe bool Invoke(Key A, Key B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = A;
                *((Key*)(b+32)) = B;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, EqualEqual_KeyKey_ptr, new IntPtr(p)); ;
                return *((bool*)(b+64));
            }
        }
        internal struct GetAnalogValue_method {
            static internal IntPtr GetAnalogValue_ptr;
            static GetAnalogValue_method() {
                GetAnalogValue_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "GetAnalogValue");
            }

            internal static unsafe float Invoke(AnalogInputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AnalogInputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, GetAnalogValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+72));
            }
        }
        internal struct GetKey_method {
            static internal IntPtr GetKey_ptr;
            static GetKey_method() {
                GetKey_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "GetKey");
            }

            internal static unsafe Key Invoke(KeyEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((KeyEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, GetKey_ptr, new IntPtr(p)); ;
                return *((Key*)(b+64));
            }
        }
        internal struct GetUserIndex_method {
            static internal IntPtr GetUserIndex_ptr;
            static GetUserIndex_method() {
                GetUserIndex_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "GetUserIndex");
            }

            internal static unsafe int Invoke(KeyEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((KeyEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, GetUserIndex_ptr, new IntPtr(p)); ;
                return *((int*)(b+64));
            }
        }
        internal struct InputEvent_IsAltDown_method {
            static internal IntPtr InputEvent_IsAltDown_ptr;
            static InputEvent_IsAltDown_method() {
                InputEvent_IsAltDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsAltDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsAltDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsCommandDown_method {
            static internal IntPtr InputEvent_IsCommandDown_ptr;
            static InputEvent_IsCommandDown_method() {
                InputEvent_IsCommandDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsCommandDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsCommandDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsControlDown_method {
            static internal IntPtr InputEvent_IsControlDown_ptr;
            static InputEvent_IsControlDown_method() {
                InputEvent_IsControlDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsControlDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsControlDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsLeftAltDown_method {
            static internal IntPtr InputEvent_IsLeftAltDown_ptr;
            static InputEvent_IsLeftAltDown_method() {
                InputEvent_IsLeftAltDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsLeftAltDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsLeftAltDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsLeftCommandDown_method {
            static internal IntPtr InputEvent_IsLeftCommandDown_ptr;
            static InputEvent_IsLeftCommandDown_method() {
                InputEvent_IsLeftCommandDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsLeftCommandDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsLeftCommandDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsLeftControlDown_method {
            static internal IntPtr InputEvent_IsLeftControlDown_ptr;
            static InputEvent_IsLeftControlDown_method() {
                InputEvent_IsLeftControlDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsLeftControlDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsLeftControlDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsLeftShiftDown_method {
            static internal IntPtr InputEvent_IsLeftShiftDown_ptr;
            static InputEvent_IsLeftShiftDown_method() {
                InputEvent_IsLeftShiftDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsLeftShiftDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsLeftShiftDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsRepeat_method {
            static internal IntPtr InputEvent_IsRepeat_ptr;
            static InputEvent_IsRepeat_method() {
                InputEvent_IsRepeat_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsRepeat");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsRepeat_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsRightAltDown_method {
            static internal IntPtr InputEvent_IsRightAltDown_ptr;
            static InputEvent_IsRightAltDown_method() {
                InputEvent_IsRightAltDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsRightAltDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsRightAltDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsRightCommandDown_method {
            static internal IntPtr InputEvent_IsRightCommandDown_ptr;
            static InputEvent_IsRightCommandDown_method() {
                InputEvent_IsRightCommandDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsRightCommandDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsRightCommandDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsRightControlDown_method {
            static internal IntPtr InputEvent_IsRightControlDown_ptr;
            static InputEvent_IsRightControlDown_method() {
                InputEvent_IsRightControlDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsRightControlDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsRightControlDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsRightShiftDown_method {
            static internal IntPtr InputEvent_IsRightShiftDown_ptr;
            static InputEvent_IsRightShiftDown_method() {
                InputEvent_IsRightShiftDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsRightShiftDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsRightShiftDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct InputEvent_IsShiftDown_method {
            static internal IntPtr InputEvent_IsShiftDown_ptr;
            static InputEvent_IsShiftDown_method() {
                InputEvent_IsShiftDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "InputEvent_IsShiftDown");
            }

            internal static unsafe bool Invoke(InputEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, InputEvent_IsShiftDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct Key_GetDisplayName_method {
            static internal IntPtr Key_GetDisplayName_ptr;
            static Key_GetDisplayName_method() {
                Key_GetDisplayName_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "Key_GetDisplayName");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, Key_GetDisplayName_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Key_IsFloatAxis_method {
            static internal IntPtr Key_IsFloatAxis_ptr;
            static Key_IsFloatAxis_method() {
                Key_IsFloatAxis_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "Key_IsFloatAxis");
            }

            internal static unsafe bool Invoke(Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, Key_IsFloatAxis_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct Key_IsGamepadKey_method {
            static internal IntPtr Key_IsGamepadKey_ptr;
            static Key_IsGamepadKey_method() {
                Key_IsGamepadKey_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "Key_IsGamepadKey");
            }

            internal static unsafe bool Invoke(Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, Key_IsGamepadKey_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct Key_IsKeyboardKey_method {
            static internal IntPtr Key_IsKeyboardKey_ptr;
            static Key_IsKeyboardKey_method() {
                Key_IsKeyboardKey_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "Key_IsKeyboardKey");
            }

            internal static unsafe bool Invoke(Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, Key_IsKeyboardKey_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct Key_IsModifierKey_method {
            static internal IntPtr Key_IsModifierKey_ptr;
            static Key_IsModifierKey_method() {
                Key_IsModifierKey_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "Key_IsModifierKey");
            }

            internal static unsafe bool Invoke(Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, Key_IsModifierKey_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct Key_IsMouseButton_method {
            static internal IntPtr Key_IsMouseButton_ptr;
            static Key_IsMouseButton_method() {
                Key_IsMouseButton_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "Key_IsMouseButton");
            }

            internal static unsafe bool Invoke(Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, Key_IsMouseButton_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct Key_IsValid_method {
            static internal IntPtr Key_IsValid_ptr;
            static Key_IsValid_method() {
                Key_IsValid_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "Key_IsValid");
            }

            internal static unsafe bool Invoke(Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, Key_IsValid_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct Key_IsVectorAxis_method {
            static internal IntPtr Key_IsVectorAxis_ptr;
            static Key_IsVectorAxis_method() {
                Key_IsVectorAxis_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "Key_IsVectorAxis");
            }

            internal static unsafe bool Invoke(Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, Key_IsVectorAxis_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct PointerEvent_GetCursorDelta_method {
            static internal IntPtr PointerEvent_GetCursorDelta_ptr;
            static PointerEvent_GetCursorDelta_method() {
                PointerEvent_GetCursorDelta_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_GetCursorDelta");
            }

            internal static unsafe Vector2D Invoke(PointerEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_GetCursorDelta_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+120));
            }
        }
        internal struct PointerEvent_GetEffectingButton_method {
            static internal IntPtr PointerEvent_GetEffectingButton_ptr;
            static PointerEvent_GetEffectingButton_method() {
                PointerEvent_GetEffectingButton_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_GetEffectingButton");
            }

            internal static unsafe Key Invoke(PointerEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_GetEffectingButton_ptr, new IntPtr(p)); ;
                return *((Key*)(b+120));
            }
        }
        internal struct PointerEvent_GetGestureDelta_method {
            static internal IntPtr PointerEvent_GetGestureDelta_ptr;
            static PointerEvent_GetGestureDelta_method() {
                PointerEvent_GetGestureDelta_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_GetGestureDelta");
            }

            internal static unsafe Vector2D Invoke(PointerEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_GetGestureDelta_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+120));
            }
        }
        internal struct PointerEvent_GetGestureType_method {
            static internal IntPtr PointerEvent_GetGestureType_ptr;
            static PointerEvent_GetGestureType_method() {
                PointerEvent_GetGestureType_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_GetGestureType");
            }

            internal static unsafe ESlateGesture Invoke(PointerEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_GetGestureType_ptr, new IntPtr(p)); ;
                return *((ESlateGesture*)(b+120));
            }
        }
        internal struct PointerEvent_GetLastScreenSpacePosition_method {
            static internal IntPtr PointerEvent_GetLastScreenSpacePosition_ptr;
            static PointerEvent_GetLastScreenSpacePosition_method() {
                PointerEvent_GetLastScreenSpacePosition_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_GetLastScreenSpacePosition");
            }

            internal static unsafe Vector2D Invoke(PointerEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_GetLastScreenSpacePosition_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+120));
            }
        }
        internal struct PointerEvent_GetPointerIndex_method {
            static internal IntPtr PointerEvent_GetPointerIndex_ptr;
            static PointerEvent_GetPointerIndex_method() {
                PointerEvent_GetPointerIndex_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_GetPointerIndex");
            }

            internal static unsafe int Invoke(PointerEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_GetPointerIndex_ptr, new IntPtr(p)); ;
                return *((int*)(b+120));
            }
        }
        internal struct PointerEvent_GetScreenSpacePosition_method {
            static internal IntPtr PointerEvent_GetScreenSpacePosition_ptr;
            static PointerEvent_GetScreenSpacePosition_method() {
                PointerEvent_GetScreenSpacePosition_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_GetScreenSpacePosition");
            }

            internal static unsafe Vector2D Invoke(PointerEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_GetScreenSpacePosition_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+120));
            }
        }
        internal struct PointerEvent_GetTouchpadIndex_method {
            static internal IntPtr PointerEvent_GetTouchpadIndex_ptr;
            static PointerEvent_GetTouchpadIndex_method() {
                PointerEvent_GetTouchpadIndex_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_GetTouchpadIndex");
            }

            internal static unsafe int Invoke(PointerEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_GetTouchpadIndex_ptr, new IntPtr(p)); ;
                return *((int*)(b+120));
            }
        }
        internal struct PointerEvent_GetUserIndex_method {
            static internal IntPtr PointerEvent_GetUserIndex_ptr;
            static PointerEvent_GetUserIndex_method() {
                PointerEvent_GetUserIndex_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_GetUserIndex");
            }

            internal static unsafe int Invoke(PointerEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_GetUserIndex_ptr, new IntPtr(p)); ;
                return *((int*)(b+120));
            }
        }
        internal struct PointerEvent_GetWheelDelta_method {
            static internal IntPtr PointerEvent_GetWheelDelta_ptr;
            static PointerEvent_GetWheelDelta_method() {
                PointerEvent_GetWheelDelta_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_GetWheelDelta");
            }

            internal static unsafe float Invoke(PointerEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_GetWheelDelta_ptr, new IntPtr(p)); ;
                return *((float*)(b+120));
            }
        }
        internal struct PointerEvent_IsMouseButtonDown_method {
            static internal IntPtr PointerEvent_IsMouseButtonDown_ptr;
            static PointerEvent_IsMouseButtonDown_method() {
                PointerEvent_IsMouseButtonDown_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_IsMouseButtonDown");
            }

            internal static unsafe bool Invoke(PointerEvent Input, Key MouseButton) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                *((Key*)(b+120)) = MouseButton;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_IsMouseButtonDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+152));
            }
        }
        internal struct PointerEvent_IsTouchEvent_method {
            static internal IntPtr PointerEvent_IsTouchEvent_ptr;
            static PointerEvent_IsTouchEvent_method() {
                PointerEvent_IsTouchEvent_ptr = Main.GetMethodUFunction(KismetInputLibrary.StaticClass, "PointerEvent_IsTouchEvent");
            }

            internal static unsafe bool Invoke(PointerEvent Input) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Input;
                Main.GetProcessEvent(KismetInputLibrary.DefaultObject, PointerEvent_IsTouchEvent_ptr, new IntPtr(p)); ;
                return *((bool*)(b+120));
            }
        }
    }
    internal unsafe struct KismetInputLibrary_events {
    }
}
