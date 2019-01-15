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


namespace UE4.OculusHMD{
        ///<summary>Oculus Splash Desc</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct OculusSplashDesc {
            ///<summary>Texture to display</summary>
            [FieldOffset(0)] SoftObjectPath TexturePath;

            ///<summary>transform of center of quad (meters).</summary>
            [FieldOffset(32)] Transform TransformInMeters;

            ///<summary>Dimensions in meters.</summary>
            [FieldOffset(80)] Vector2D QuadSizeInMeters;

            ///<summary>A delta rotation that will be added each rendering frame (half rate of full vsync).</summary>
            [FieldOffset(96)] Quat DeltaRotation;

            ///<summary>Texture offset amount from the top left corner.</summary>
            [FieldOffset(112)] Vector2D TextureOffset;

            ///<summary>Texture scale.</summary>
            [FieldOffset(120)] Vector2D TextureScale;

            [FieldOffset(128)] public bool bNoAlphaChannel;

        }
}
