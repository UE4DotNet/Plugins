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
        ///<summary>Draw to Render Target Context</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct DrawToRenderTargetContext {
            [FieldOffset(0)] 
            private IntPtr  RenderTarget_field;
            ///<summary>Render Target</summary>
            public TextureRenderTarget2D RenderTarget {
                get {return RenderTarget_field;}
                set {RenderTarget_field = value;}
            }

        }
}
