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
        ///<summary>Proxy structure for 3D transform section key data.</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct MovieScene3DTransformKeyStruct {
            ///<summary>The key's translation value.</summary>
            [FieldOffset(8)] Vector Location;

            ///<summary>The key's rotation value.</summary>
            [FieldOffset(20)] Rotator Rotation;

            ///<summary>The key's scale value.</summary>
            [FieldOffset(32)] Vector Scale;

            ///<summary>The key's time.</summary>
            [FieldOffset(44)] FrameNumber Time;

        }
}
