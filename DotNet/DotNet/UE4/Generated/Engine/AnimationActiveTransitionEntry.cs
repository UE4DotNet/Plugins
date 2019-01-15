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
        ///<summary>Information about an active transition on the transition stack</summary>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct AnimationActiveTransitionEntry {
            [FieldOffset(144)] 
            private IntPtr  BlendProfile_field;
            ///<summary>Blend profile to use for this transition. Specifying this will make the transition evaluate per-bone</summary>
            public BlendProfile BlendProfile {
                get {return BlendProfile_field;}
                set {BlendProfile_field = value;}
            }

        }
}
