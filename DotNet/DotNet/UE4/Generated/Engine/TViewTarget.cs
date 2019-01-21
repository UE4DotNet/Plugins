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


namespace UE4.Engine{
        ///<summary>A ViewTarget is the primary actor the camera is associated with.</summary>
        [StructLayout( LayoutKind.Explicit, Size=1392 )]
        public unsafe struct TViewTarget {
            [FieldOffset(0)] 
            private IntPtr  Target_field;
            ///<summary>Target Actor used to compute POV</summary>
            public Actor Target {
                get {return Target_field;}
                set {Target_field = value;}
            }

            ///<summary>Computed point of view</summary>
            [FieldOffset(16)] MinimalViewInfo POV;

            [FieldOffset(1376)] 
            private IntPtr  PlayerState_field;
            ///<summary>PlayerState (used to follow same player through pawn transitions, etc., when spectating)</summary>
            public PlayerState PlayerState {
                get {return PlayerState_field;}
                set {PlayerState_field = value;}
            }

        }
}
