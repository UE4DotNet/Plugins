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


namespace UE4.PacketHandler{
        ///<summary>Configuration for FNetAnalyticsData - enabling/disabling analytics data, based on DataName</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct NetAnalyticsDataConfig {
            [FieldOffset(0)] public Name DataName;

            [FieldOffset(12)] public bool bEnabled;

        }
}
