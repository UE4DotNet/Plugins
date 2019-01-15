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
        ///<summary>Holds the packet simulation settings in one place</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct PacketSimulationSettings {
            [FieldOffset(0)] public int PktLoss;

            [FieldOffset(4)] public int PktOrder;

            [FieldOffset(8)] public int PktDup;

            [FieldOffset(12)] public int PktLag;

            [FieldOffset(16)] public int PktLagVariance;

        }
}
