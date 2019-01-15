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
using UE4.InputCore;

namespace UE4.Engine {
    ///<summary>Implement an Actor component for input bindings.</summary>
    ///<remarks>
    ///An Input Component is a transient component that enables an Actor to bind various forms of input events to delegate functions.
    ///Input components are processed from a stack managed by the PlayerController and processed by the PlayerInput.
    ///Each binding can consume the input event preventing other components on the input stack from processing the input.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Gameplay/Input/index.html
    ///</remarks>
    public unsafe partial class InputComponent : ActorComponent  {

        ///<summary>Returns the analog value for the given key/button.  If analog isn't supported, returns 1 for down and 0 for up.</summary>
        public float GetControllerAnalogKeyState(Key Key)  => 
            InputComponent_methods.GetControllerAnalogKeyState_method.Invoke(ObjPointer, Key);

        ///<summary>Retrieves the X and Y displacement of the given analog stick.  For WhickStick, 0 = left, 1 = right.</summary>
        public (float, float) GetControllerAnalogStickState(byte WhichStick)  => 
            InputComponent_methods.GetControllerAnalogStickState_method.Invoke(ObjPointer, WhichStick);

        ///<summary>Returns how long the given key/button has been down.  Returns 0 if it's up or it just went down this frame.</summary>
        public float GetControllerKeyTimeDown(Key Key)  => 
            InputComponent_methods.GetControllerKeyTimeDown_method.Invoke(ObjPointer, Key);

        ///<summary>Retrieves how far the mouse moved this frame.</summary>
        public (float, float) GetControllerMouseDelta()  => 
            InputComponent_methods.GetControllerMouseDelta_method.Invoke(ObjPointer);

        ///<summary>Returns the vector value for the given key/button.</summary>
        public Vector GetControllerVectorKeyState(Key Key)  => 
            InputComponent_methods.GetControllerVectorKeyState_method.Invoke(ObjPointer, Key);

        ///<summary>Returns the location of a touch, and if it's held down</summary>
        public (float, float, bool) GetTouchState(int FingerIndex)  => 
            InputComponent_methods.GetTouchState_method.Invoke(ObjPointer, FingerIndex);

        ///<summary>Returns true if the given key/button is pressed on the input of the controller (if present)</summary>
        public bool IsControllerKeyDown(Key Key)  => 
            InputComponent_methods.IsControllerKeyDown_method.Invoke(ObjPointer, Key);

        ///<summary>Returns true if the given key/button was up last frame and down this frame.</summary>
        public bool WasControllerKeyJustPressed(Key Key)  => 
            InputComponent_methods.WasControllerKeyJustPressed_method.Invoke(ObjPointer, Key);

        ///<summary>Returns true if the given key/button was down last frame and up this frame.</summary>
        public bool WasControllerKeyJustReleased(Key Key)  => 
            InputComponent_methods.WasControllerKeyJustReleased_method.Invoke(ObjPointer, Key);
         //TODO: array not UObject TArray CachedKeyToActionInfo
        static InputComponent() {
            StaticClass = Main.GetClass("InputComponent");
        }
        internal unsafe InputComponent_fields* InputComponent_ptr => (InputComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InputComponent(IntPtr p) => UObject.Make<InputComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InputComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InputComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
