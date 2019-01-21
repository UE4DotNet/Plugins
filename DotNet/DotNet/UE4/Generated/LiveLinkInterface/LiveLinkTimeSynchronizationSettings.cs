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


namespace UE4.LiveLinkInterface{
        ///<summary>Live Link Time Synchronization Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct LiveLinkTimeSynchronizationSettings {
            ///<summary>The frame rate of the source.</summary>
            ///<remarks>
            ///This should be the frame rate the source is "stamped" at, not necessarily the frame rate the source is sending.
            ///The source should supply this whenever possible.
            ///</remarks>
            [FieldOffset(0)] FrameRate FrameRate;

        }
}
