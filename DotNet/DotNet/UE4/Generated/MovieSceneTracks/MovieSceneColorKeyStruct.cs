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
        ///<summary>Proxy structure for color section key data.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct MovieSceneColorKeyStruct {
            ///<summary>The key's color value.</summary>
            [FieldOffset(8)] LinearColor Color;

            ///<summary>The key's time.</summary>
            [FieldOffset(24)] FrameNumber Time;

        }
}
