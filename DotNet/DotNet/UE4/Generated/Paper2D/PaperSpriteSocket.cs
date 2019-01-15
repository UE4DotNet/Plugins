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
        ///<summary>@TODO: Should have some nice UI and enforce unique names, etc...</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct PaperSpriteSocket {
            ///<summary>Transform in pivot space (*not* texture space)</summary>
            [FieldOffset(0)] Transform LocalTransform;

            [FieldOffset(48)] public Name SocketName;

        }
}
