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
        ///<summary>Serialized ULevel information about dynamic texture instances</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct DynamicTextureInstance {
            [FieldOffset(40)] 
            private IntPtr  Texture_field;
            ///<summary>Texture that is used by a dynamic UPrimitiveComponent.</summary>
            public Texture2D Texture {
                get {return Texture_field;}
                set {Texture_field = value;}
            }

            [FieldOffset(48)] public bool bAttached;

            [FieldOffset(52)] public float OriginalRadius;

        }
}
