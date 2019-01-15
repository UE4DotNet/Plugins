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
        ///<summary>Represent a current play position in an animation</summary>
        ///<remarks>based on sync markers</remarks>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct MarkerSyncAnimPosition {
            [FieldOffset(0)] public Name PreviousMarkerName;

            [FieldOffset(12)] public Name NextMarkerName;

            [FieldOffset(24)] public float PositionBetweenMarkers;

        }
}
