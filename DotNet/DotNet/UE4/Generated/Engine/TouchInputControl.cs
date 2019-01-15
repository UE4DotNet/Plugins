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

using UE4.InputCore;

namespace UE4.Engine{
        ///<summary>Touch Input Control</summary>
        [StructLayout( LayoutKind.Explicit, Size=120 )]
        public unsafe struct TouchInputControl {
            [FieldOffset(0)] 
            private IntPtr  Image1_field;
            ///<summary>For sticks, this is the Thumb</summary>
            public Texture2D Image1 {
                get {return Image1_field;}
                set {Image1_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  Image2_field;
            ///<summary>For sticks, this is the Background</summary>
            public Texture2D Image2 {
                get {return Image2_field;}
                set {Image2_field = value;}
            }

            ///<summary>The center point of the control (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
            [FieldOffset(16)] Vector2D Center;

            ///<summary>The size of the control (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
            [FieldOffset(24)] Vector2D VisualSize;

            ///<summary>For sticks, the size of the thumb (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
            [FieldOffset(32)] Vector2D ThumbSize;

            ///<summary>The interactive size of the control (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
            [FieldOffset(40)] Vector2D InteractionSize;

            ///<summary>The scale for control input</summary>
            [FieldOffset(48)] Vector2D InputScale;

            ///<summary>The main input to send from this control (for sticks, this is the horizontal axis)</summary>
            [FieldOffset(56)] Key MainInputKey;

            ///<summary>The alternate input to send from this control (for sticks, this is the vertical axis)</summary>
            [FieldOffset(88)] Key AltInputKey;

        }
}
