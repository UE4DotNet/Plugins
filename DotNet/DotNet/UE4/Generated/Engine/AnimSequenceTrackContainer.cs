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
        ///<summary>These two always should go together, but it is not right now.</summary>
        ///<remarks>
        ///I wonder in the future, we change all compressed to be inside as well, so they all stay together
        ///When remove tracks, it should be handled together
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct AnimSequenceTrackContainer {
            [FieldOffset(0)] byte AnimationTracks; //TODO: array TArray AnimationTracks

            [FieldOffset(16)] byte TrackNames; //TODO: array TArray TrackNames

        }
}
