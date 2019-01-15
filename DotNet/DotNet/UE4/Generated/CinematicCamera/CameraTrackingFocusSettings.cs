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
        ///<summary>Settings to control tracking-focus mode.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct CameraTrackingFocusSettings {
            [FieldOffset(0)] 
            private IntPtr  ActorToTrack_field;
            ///<summary>Focus distance will be tied to this actor's location.</summary>
            public Actor ActorToTrack {
                get {return ActorToTrack_field;}
                set {ActorToTrack_field = value;}
            }

            ///<summary>Offset from actor position to track. Relative to actor if tracking an actor, relative to world otherwise.</summary>
            [FieldOffset(8)] Vector RelativeOffset;

            [FieldOffset(20)] public bool bDrawDebugTrackingFocusPoint;

        }
}
