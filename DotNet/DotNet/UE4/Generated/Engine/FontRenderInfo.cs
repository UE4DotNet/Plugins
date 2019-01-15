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
        ///<summary>information used in font rendering</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct FontRenderInfo {
            [FieldOffset(0)] public bool bClipText;

            [FieldOffset(0)] public bool bEnableShadow;

            ///<summary>depth field glow parameters (only usable if font was imported with a depth field)</summary>
            [FieldOffset(4)] DepthFieldGlowInfo GlowInfo;

        }
}
