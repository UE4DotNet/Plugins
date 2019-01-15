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
        ///<summary>Describes the physical state of a rigid body.</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct RigidBodyState {
            ///<summary>Position</summary>
            [FieldOffset(0)] Vector_NetQuantize100 Position;

            ///<summary>Quaternion</summary>
            [FieldOffset(16)] Quat Quaternion;

            ///<summary>Lin Vel</summary>
            [FieldOffset(32)] Vector_NetQuantize100 LinVel;

            ///<summary>Ang Vel</summary>
            [FieldOffset(44)] Vector_NetQuantize100 AngVel;

            [FieldOffset(56)] public byte Flags;

        }
}
