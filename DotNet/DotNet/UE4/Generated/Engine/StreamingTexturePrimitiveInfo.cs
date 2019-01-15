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
        ///<summary>Information about a streaming texture that a primitive uses for rendering.</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct StreamingTexturePrimitiveInfo {
            [FieldOffset(0)] 
            private IntPtr  Texture_field;
            ///<summary>Texture</summary>
            public Texture2D Texture {
                get {return Texture_field;}
                set {Texture_field = value;}
            }

            ///<summary>The streaming bounds of the texture, usually the component material bounds.</summary>
            ///<remarks>
            ///Usually only valid for registered component, as component bounds are only updated when the components are registered.
            ///otherwise only PackedRelativeBox can be used.Irrelevant when the component is not registered, as the component could be moved by ULevel::ApplyWorldOffset()
            ///In that case, only PackedRelativeBox is meaningful.
            ///</remarks>
            [FieldOffset(8)] BoxSphereBounds Bounds;

            [FieldOffset(36)] public float TexelFactor;

            [FieldOffset(40)] byte PackedRelativeBox; //TODO: numeric uint32 PackedRelativeBox

        }
}
