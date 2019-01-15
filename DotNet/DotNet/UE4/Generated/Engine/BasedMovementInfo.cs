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
        ///<summary>Struct to hold information about the "base" object the character is standing on.</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct BasedMovementInfo {
            [FieldOffset(0)] 
            private IntPtr  MovementBase_field;
            ///<summary>Component we are based on</summary>
            public PrimitiveComponent MovementBase {
                get {return MovementBase_field;}
                set {MovementBase_field = value;}
            }

            [FieldOffset(8)] public Name BoneName;

            ///<summary>Location relative to MovementBase. Only valid if HasRelativeLocation() is true.</summary>
            [FieldOffset(20)] Vector_NetQuantize100 Location;

            ///<summary>Rotation: relative to MovementBase if HasRelativeRotation() is true, absolute otherwise.</summary>
            [FieldOffset(32)] Rotator Rotation;

            [FieldOffset(44)] public bool bServerHasBaseComponent;

            [FieldOffset(45)] public bool bRelativeRotation;

            [FieldOffset(46)] public bool bServerHasVelocity;

        }
}
