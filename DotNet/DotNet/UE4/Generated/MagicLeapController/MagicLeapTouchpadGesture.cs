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


namespace UE4.MagicLeapController{
        ///<summary>Information about a recognized touchpad gesture.</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct MagicLeapTouchpadGesture {
            [FieldOffset(0)] byte Hand; //TODO: enum EControllerHand Hand

            [FieldOffset(1)] byte Type; //TODO: enum EMagicLeapTouchpadGestureType Type

            [FieldOffset(2)] byte Direction; //TODO: enum EMagicLeapTouchpadGestureDirection Direction

            ///<summary>Gesture position (x,y) and force (z).</summary>
            ///<remarks>Position is in the [-1.0,1.0] range and force is in the [0.0,1.0] range.</remarks>
            [FieldOffset(4)] Vector PositionAndForce;

            [FieldOffset(16)] public float Speed;

            [FieldOffset(20)] public float Distance;

            [FieldOffset(24)] public float FingerGap;

            [FieldOffset(28)] public float Radius;

            [FieldOffset(32)] public float Angle;

        }
}
