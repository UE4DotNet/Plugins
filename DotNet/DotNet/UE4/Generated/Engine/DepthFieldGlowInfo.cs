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
        ///<summary>info for glow when using depth field rendering</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct DepthFieldGlowInfo {
            [FieldOffset(0)] public bool bEnableGlow;

            ///<summary>base color to use for the glow</summary>
            [FieldOffset(4)] LinearColor GlowColor;

            ///<summary>if bEnableGlow, outline glow outer radius (0 to 1, 0.</summary>
            ///<remarks>
            ///5 is edge of character silhouette)
            ///glow influence will be 0 at GlowOuterRadius.X and 1 at GlowOuterRadius.Y
            ///</remarks>
            [FieldOffset(20)] Vector2D GlowOuterRadius;

            ///<summary>if bEnableGlow, outline glow inner radius (0 to 1, 0.</summary>
            ///<remarks>
            ///5 is edge of character silhouette)
            ///glow influence will be 1 at GlowInnerRadius.X and 0 at GlowInnerRadius.Y
            ///</remarks>
            [FieldOffset(28)] Vector2D GlowInnerRadius;

        }
}
