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
        ///<summary>Struct for handling positions relative to a base actor, which is potentially moving</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct BasedPosition {
            [FieldOffset(0)] 
            private IntPtr  Base_field;
            ///<summary>Base</summary>
            public Actor Base {
                get {return Base_field;}
                set {Base_field = value;}
            }

            ///<summary>Position</summary>
            [FieldOffset(8)] Vector Position;

            ///<summary>Cached Base Location</summary>
            [FieldOffset(20)] Vector CachedBaseLocation;

            ///<summary>Cached Base Rotation</summary>
            [FieldOffset(32)] Rotator CachedBaseRotation;

            ///<summary>Cached Trans Position</summary>
            [FieldOffset(44)] Vector CachedTransPosition;

        }
}
