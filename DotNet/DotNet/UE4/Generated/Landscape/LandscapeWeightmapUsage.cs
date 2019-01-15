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


namespace UE4.Landscape{
        ///<summary>Structure storing channel usage for weightmap textures</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct LandscapeWeightmapUsage {
            [FieldOffset(0)] 
            private IntPtr  ChannelUsage_field;
            ///<summary>Channel Usage</summary>
            public LandscapeComponent ChannelUsage {
                get {return ChannelUsage_field;}
                set {ChannelUsage_field = value;}
            }

        }
}
