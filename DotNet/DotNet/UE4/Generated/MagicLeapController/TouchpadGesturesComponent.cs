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
using UE4.MagicLeapController.Native;
using UE4.Engine;

namespace UE4.MagicLeapController {
    ///<summary>Delegates touchpad gesture events for the Magic Leap Controller & MLMA</summary>
    public unsafe partial class TouchpadGesturesComponent : ActorComponent  {
         //TODO: multicast delegate FTouchpadGestureEvent OnTouchpadGestureStart
         //TODO: multicast delegate FTouchpadGestureEvent OnTouchpadGestureContinue
         //TODO: multicast delegate FTouchpadGestureEvent OnTouchpadGestureEnd
        static TouchpadGesturesComponent() {
            StaticClass = Main.GetClass("TouchpadGesturesComponent");
        }
        internal unsafe TouchpadGesturesComponent_fields* TouchpadGesturesComponent_ptr => (TouchpadGesturesComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TouchpadGesturesComponent(IntPtr p) => UObject.Make<TouchpadGesturesComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TouchpadGesturesComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TouchpadGesturesComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
