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
        ///<summary>Sprite Instance Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct SpriteInstanceData {
            ///<summary>Transform</summary>
            [FieldOffset(0)] Matrix Transform;

            [FieldOffset(64)] 
            private IntPtr  SourceSprite_field;
            ///<summary>Source Sprite</summary>
            public PaperSprite SourceSprite {
                get {return SourceSprite_field;}
                set {SourceSprite_field = value;}
            }

            ///<summary>Vertex Color</summary>
            [FieldOffset(72)] Color VertexColor;

            [FieldOffset(76)] public int MaterialIndex;

        }
}
