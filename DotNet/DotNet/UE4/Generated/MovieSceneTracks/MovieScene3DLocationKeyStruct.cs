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
        ///<summary>Proxy structure for translation keys in 3D transform sections.</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct MovieScene3DLocationKeyStruct {
            ///<summary>The key's translation value.</summary>
            [FieldOffset(8)] Vector Location;

            ///<summary>The key's time.</summary>
            [FieldOffset(20)] FrameNumber Time;

        }
}
