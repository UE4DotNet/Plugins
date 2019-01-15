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


namespace UE4.MagicLeap{
        ///<summary>Result of a raycast.</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct RaycastHitResult {
            [FieldOffset(0)] byte HitState; //TODO: enum ERaycastResultState HitState

            ///<summary>Where in the world the collision happened.</summary>
            ///<remarks>
            ///This field is only valid if the state
            ///        is either HitUnobserved or HitObserved.
            ///</remarks>
            [FieldOffset(4)] Vector HitPoint;

            ///<summary>Normal to the surface where the ray collided.</summary>
            ///<remarks>
            ///This field is only valid if the state
            ///        is either HitUnobserved or HitObserved
            ///</remarks>
            [FieldOffset(16)] Vector Normal;

            [FieldOffset(28)] public float Confidence;

            [FieldOffset(32)] public int UserData;

        }
}
