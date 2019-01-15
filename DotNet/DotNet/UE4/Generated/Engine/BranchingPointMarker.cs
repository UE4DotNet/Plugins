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
        ///<summary>AnimNotifies marked as BranchingPoints will create these markers on their Begin/End times.</summary>
        ///<remarks>They create stopping points when the Montage is being ticked to dispatch events.</remarks>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct BranchingPointMarker {
            [FieldOffset(0)] public int NotifyIndex;

            [FieldOffset(4)] public float TriggerTime;

            [FieldOffset(8)] public byte NotifyEventType;

        }
}
