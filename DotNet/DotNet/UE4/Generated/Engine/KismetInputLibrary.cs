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

#pragma warning disable CS0108
using UE4.Engine.Native;
using UE4.Slate;
using UE4.InputCore;
using UE4.SlateCore;

namespace UE4.Engine {
    ///<summary>Kismet Input Library</summary>
    public unsafe partial class KismetInputLibrary : BlueprintFunctionLibrary  {

        ///<summary>Calibrate the tilt for the input device</summary>
        public static void CalibrateTilt()  => 
            KismetInputLibrary_methods.CalibrateTilt_method.Invoke();

        ///<summary>
        ///Test if the input chords are equal (A == B)
        ///@
        ///</summary>
        ///<remarks>
        ///param A - The chord to compare against
        ///@param B - The chord to compare
        ///@returns True if the chords are equal, false otherwise
        ///</remarks>
        public static bool EqualEqual_InputChordInputChord(InputChord A, InputChord B)  => 
            KismetInputLibrary_methods.EqualEqual_InputChordInputChord_method.Invoke(A, B);

        ///<summary>
        ///Test if the input key are equal (A == B)
        ///@
        ///</summary>
        ///<remarks>
        ///param A - The key to compare against
        ///@param B - The key to compare
        ///@returns True if the key are equal, false otherwise
        ///</remarks>
        public static bool EqualEqual_KeyKey(Key A, Key B)  => 
            KismetInputLibrary_methods.EqualEqual_KeyKey_method.Invoke(A, B);

        ///<summary>Get Analog Value</summary>
        public static float GetAnalogValue(AnalogInputEvent Input)  => 
            KismetInputLibrary_methods.GetAnalogValue_method.Invoke(Input);

        ///<summary>Returns the key for this event.</summary>
        ///<remarks>
        ///@return  Key name
        ///</remarks>
        public static Key GetKey(KeyEvent Input)  => 
            KismetInputLibrary_methods.GetKey_method.Invoke(Input);

        ///<summary>Get User Index</summary>
        public static int GetUserIndex(KeyEvent Input)  => 
            KismetInputLibrary_methods.GetUserIndex_method.Invoke(Input);

        ///<summary>
        ///Returns true if either alt key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return  True if alt is pressed</remarks>
        public static bool InputEvent_IsAltDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsAltDown_method.Invoke(Input);

        ///<summary>
        ///Returns true if either command key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return  True if command is pressed</remarks>
        public static bool InputEvent_IsCommandDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsCommandDown_method.Invoke(Input);

        ///<summary>
        ///Returns true if either control key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return  True if control is pressed</remarks>
        public static bool InputEvent_IsControlDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsControlDown_method.Invoke(Input);

        ///<summary>
        ///Returns true if left alt key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return  True if left alt is pressed</remarks>
        public static bool InputEvent_IsLeftAltDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsLeftAltDown_method.Invoke(Input);

        ///<summary>
        ///Returns true if left command key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return  True if left command is pressed</remarks>
        public static bool InputEvent_IsLeftCommandDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsLeftCommandDown_method.Invoke(Input);

        ///<summary>
        ///Returns true if left control key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return  True if left control is pressed</remarks>
        public static bool InputEvent_IsLeftControlDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsLeftControlDown_method.Invoke(Input);

        ///<summary>
        ///Returns true if left shift key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return True if left shift is pressed.</remarks>
        public static bool InputEvent_IsLeftShiftDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsLeftShiftDown_method.Invoke(Input);

        ///<summary>
        ///Returns whether or not this character is an auto-repeated keystroke
        ///@
        ///</summary>
        ///<remarks>return  True if this character is a repeat</remarks>
        public static bool InputEvent_IsRepeat(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsRepeat_method.Invoke(Input);

        ///<summary>
        ///Returns true if right alt key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return  True if right alt is pressed</remarks>
        public static bool InputEvent_IsRightAltDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsRightAltDown_method.Invoke(Input);

        ///<summary>
        ///Returns true if right command key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return  True if right command is pressed</remarks>
        public static bool InputEvent_IsRightCommandDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsRightCommandDown_method.Invoke(Input);

        ///<summary>
        ///Returns true if left control key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return  True if left control is pressed</remarks>
        public static bool InputEvent_IsRightControlDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsRightControlDown_method.Invoke(Input);

        ///<summary>
        ///Returns true if right shift key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return True if right shift is pressed.</remarks>
        public static bool InputEvent_IsRightShiftDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsRightShiftDown_method.Invoke(Input);

        ///<summary>
        ///Returns true if either shift key was down when this event occurred
        ///@
        ///</summary>
        ///<remarks>return  True if shift is pressed</remarks>
        public static bool InputEvent_IsShiftDown(InputEvent Input)  => 
            KismetInputLibrary_methods.InputEvent_IsShiftDown_method.Invoke(Input);

        ///<summary>@returns The display name of the key.</summary>
        public static byte /*TODO: text FText*/ Key_GetDisplayName(Key Key)  => 
            KismetInputLibrary_methods.Key_GetDisplayName_method.Invoke(Key);

        ///<summary>@returns True if the key is a float axis</summary>
        public static bool Key_IsFloatAxis(Key Key)  => 
            KismetInputLibrary_methods.Key_IsFloatAxis_method.Invoke(Key);

        ///<summary>@returns True if the key is a gamepad button</summary>
        public static bool Key_IsGamepadKey(Key Key)  => 
            KismetInputLibrary_methods.Key_IsGamepadKey_method.Invoke(Key);

        ///<summary>@returns True if the key is a keyboard button</summary>
        public static bool Key_IsKeyboardKey(Key Key)  => 
            KismetInputLibrary_methods.Key_IsKeyboardKey_method.Invoke(Key);

        ///<summary>@returns True if the key is a modifier key: Ctrl, Command, Alt, Shift</summary>
        public static bool Key_IsModifierKey(Key Key)  => 
            KismetInputLibrary_methods.Key_IsModifierKey_method.Invoke(Key);

        ///<summary>@returns True if the key is a mouse button</summary>
        public static bool Key_IsMouseButton(Key Key)  => 
            KismetInputLibrary_methods.Key_IsMouseButton_method.Invoke(Key);

        ///<summary>@returns True if this is a valid key.</summary>
        public static bool Key_IsValid(Key Key)  => 
            KismetInputLibrary_methods.Key_IsValid_method.Invoke(Key);

        ///<summary>@returns True if the key is a vector axis</summary>
        public static bool Key_IsVectorAxis(Key Key)  => 
            KismetInputLibrary_methods.Key_IsVectorAxis_method.Invoke(Key);

        ///<summary>@return the distance the mouse traveled since the last event was handled.</summary>
        public static Vector2D PointerEvent_GetCursorDelta(PointerEvent Input)  => 
            KismetInputLibrary_methods.PointerEvent_GetCursorDelta_method.Invoke(Input);

        ///<summary>Mouse button that caused this event to be raised (possibly EB_None)</summary>
        public static Key PointerEvent_GetEffectingButton(PointerEvent Input)  => 
            KismetInputLibrary_methods.PointerEvent_GetEffectingButton_method.Invoke(Input);

        ///<summary>@return The change in gesture value since the last gesture event of the same type.</summary>
        public static Vector2D PointerEvent_GetGestureDelta(PointerEvent Input)  => 
            KismetInputLibrary_methods.PointerEvent_GetGestureDelta_method.Invoke(Input);

        ///<summary>@return The type of touch gesture</summary>
        public static ESlateGesture PointerEvent_GetGestureType(PointerEvent Input)  => 
            KismetInputLibrary_methods.PointerEvent_GetGestureType_method.Invoke(Input);

        ///<summary>@return The position of the cursor in screen space last time we handled an input event</summary>
        public static Vector2D PointerEvent_GetLastScreenSpacePosition(PointerEvent Input)  => 
            KismetInputLibrary_methods.PointerEvent_GetLastScreenSpacePosition_method.Invoke(Input);

        ///<summary>@return The unique identifier of the pointer (e.g., finger index)</summary>
        public static int PointerEvent_GetPointerIndex(PointerEvent Input)  => 
            KismetInputLibrary_methods.PointerEvent_GetPointerIndex_method.Invoke(Input);

        ///<summary>@return The position of the cursor in screen space</summary>
        public static Vector2D PointerEvent_GetScreenSpacePosition(PointerEvent Input)  => 
            KismetInputLibrary_methods.PointerEvent_GetScreenSpacePosition_method.Invoke(Input);

        ///<summary>@return The index of the touch pad that generated this event (for platforms with multiple touch pads per user)</summary>
        public static int PointerEvent_GetTouchpadIndex(PointerEvent Input)  => 
            KismetInputLibrary_methods.PointerEvent_GetTouchpadIndex_method.Invoke(Input);

        ///<summary>@return The index of the user that caused the event</summary>
        public static int PointerEvent_GetUserIndex(PointerEvent Input)  => 
            KismetInputLibrary_methods.PointerEvent_GetUserIndex_method.Invoke(Input);

        ///<summary>How much did the mouse wheel turn since the last mouse event</summary>
        public static float PointerEvent_GetWheelDelta(PointerEvent Input)  => 
            KismetInputLibrary_methods.PointerEvent_GetWheelDelta_method.Invoke(Input);

        ///<summary>Mouse buttons that are currently pressed</summary>
        public static bool PointerEvent_IsMouseButtonDown(PointerEvent Input, Key MouseButton)  => 
            KismetInputLibrary_methods.PointerEvent_IsMouseButtonDown_method.Invoke(Input, MouseButton);

        ///<summary>@return Is this event a result from a touch (as opposed to a mouse)</summary>
        public static bool PointerEvent_IsTouchEvent(PointerEvent Input)  => 
            KismetInputLibrary_methods.PointerEvent_IsTouchEvent_method.Invoke(Input);
        static KismetInputLibrary() {
            StaticClass = Main.GetClass("KismetInputLibrary");
        }
        internal unsafe KismetInputLibrary_fields* KismetInputLibrary_ptr => (KismetInputLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetInputLibrary(IntPtr p) => UObject.Make<KismetInputLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetInputLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetInputLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
