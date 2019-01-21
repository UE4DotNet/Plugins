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
        ///<summary>
        ///Cached camera POV info, stored as optimization so we only
        ///need to do a full camera update once per tick.
        ///</summary>
        [StructLayout( LayoutKind.Explicit, Size=1376 )]
        public unsafe struct CameraCacheEntry {
            [FieldOffset(0)] public float TimeStamp;

            ///<summary>Camera POV to cache.</summary>
            [FieldOffset(16)] MinimalViewInfo POV;

        }
}
