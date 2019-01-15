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
        ///<summary>General purpose data structure for grouping all parameters needed when sizing or wrapping a string</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct TextSizingParameters {
            [FieldOffset(0)] public float DrawX;

            [FieldOffset(4)] public float DrawY;

            [FieldOffset(8)] public float DrawXL;

            [FieldOffset(12)] public float DrawYL;

            ///<summary>A value between 0.0 and 1.0, which represents how much the width/height should be scaled, where 1.0 represents 100% scaling.</summary>
            [FieldOffset(16)] Vector2D Scaling;

            [FieldOffset(24)] 
            private IntPtr  DrawFont_field;
            ///<summary>the font to use for sizing/wrapping the string</summary>
            public Font DrawFont {
                get {return DrawFont_field;}
                set {DrawFont_field = value;}
            }

            ///<summary>Horizontal spacing adjustment between characters and vertical spacing adjustment between wrapped lines</summary>
            [FieldOffset(32)] Vector2D SpacingAdjust;

        }
}
