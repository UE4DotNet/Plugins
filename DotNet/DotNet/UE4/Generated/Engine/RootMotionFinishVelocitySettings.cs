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
        ///<summary>Struct for RootMotion Finish Velocity options.</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct RootMotionFinishVelocitySettings {
            [FieldOffset(0)] byte Mode; //TODO: enum ERootMotionFinishVelocityMode Mode

            ///<summary>Set Velocity if Mode == SetVelocity</summary>
            [FieldOffset(4)] Vector SetVelocity;

            [FieldOffset(16)] public float ClampVelocity;

        }
}
