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
        ///<summary>Helper struct for storing the camera world-position for each camera cut in the cinematic.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct CameraCutInfo {
            ///<summary>Location</summary>
            [FieldOffset(0)] Vector Location;

            [FieldOffset(12)] public float TimeStamp;

        }
}
