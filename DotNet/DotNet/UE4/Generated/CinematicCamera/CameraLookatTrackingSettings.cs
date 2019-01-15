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

using UE4.Engine;

namespace UE4.CinematicCamera{
        ///<summary>Settings to control the camera's lookat feature</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct CameraLookatTrackingSettings {
            [FieldOffset(0)] public bool bEnableLookAtTracking;

            [FieldOffset(0)] public bool bDrawDebugLookAtTrackingPosition;

            [FieldOffset(4)] public float LookAtTrackingInterpSpeed;

            [FieldOffset(24)] 
            private IntPtr  ActorToTrack_field;
            ///<summary>If set, camera will track this actor's location</summary>
            public Actor ActorToTrack {
                get {return ActorToTrack_field;}
                set {ActorToTrack_field = value;}
            }

            ///<summary>Offset from actor position to look at. Relative to actor if tracking an actor, relative to world otherwise.</summary>
            [FieldOffset(32)] Vector RelativeOffset;

            [FieldOffset(44)] public bool bAllowRoll;

        }
}
