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


namespace UE4.Paper2D{
        ///<summary>Paper Flipbook Key Frame</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct PaperFlipbookKeyFrame {
            [FieldOffset(0)] 
            private IntPtr  Sprite_field;
            ///<summary>Sprite</summary>
            public PaperSprite Sprite {
                get {return Sprite_field;}
                set {Sprite_field = value;}
            }

            [FieldOffset(8)] public int FrameRun;

        }
}
