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
        ///<summary>Replicated data when playing a root motion montage.</summary>
        [StructLayout( LayoutKind.Explicit, Size=344 )]
        public unsafe struct RepRootMotionMontage {
            [FieldOffset(0)] public bool bIsActive;

            [FieldOffset(8)] 
            private IntPtr  AnimMontage_field;
            ///<summary>AnimMontage providing Root Motion</summary>
            public AnimMontage AnimMontage {
                get {return AnimMontage_field;}
                set {AnimMontage_field = value;}
            }

            [FieldOffset(16)] public float Position;

            ///<summary>Location</summary>
            [FieldOffset(20)] Vector_NetQuantize100 Location;

            ///<summary>Rotation</summary>
            [FieldOffset(32)] Rotator Rotation;

            [FieldOffset(48)] 
            private IntPtr  MovementBase_field;
            ///<summary>Movement Relative to Base</summary>
            public PrimitiveComponent MovementBase {
                get {return MovementBase_field;}
                set {MovementBase_field = value;}
            }

            [FieldOffset(56)] public Name MovementBaseBoneName;

            [FieldOffset(68)] public bool bRelativePosition;

            [FieldOffset(69)] public bool bRelativeRotation;

            ///<summary>State of Root Motion Sources on Authority</summary>
            [FieldOffset(72)] RootMotionSourceGroup AuthoritativeRootMotion;

            ///<summary>Acceleration</summary>
            [FieldOffset(320)] Vector_NetQuantize10 Acceleration;

            ///<summary>Velocity</summary>
            [FieldOffset(332)] Vector_NetQuantize10 LinearVelocity;

        }
}
