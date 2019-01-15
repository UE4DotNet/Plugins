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


namespace UE4.MovieSceneTracks{
        ///<summary>Event Payload</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct EventPayload {
            [FieldOffset(0)] public Name EventName;

            ///<summary>The event parameters</summary>
            [FieldOffset(16)] MovieSceneEventParameters Parameters;

        }
}
