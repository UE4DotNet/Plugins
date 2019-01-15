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
        ///<summary>Struct that exists to store runtime cache to make key to action lookups faster.</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct CachedKeyToActionInfo {
            [FieldOffset(0)] 
            private IntPtr  PlayerInput_field;
            ///<summary>Which PlayerInput object this has been built for</summary>
            public PlayerInput PlayerInput {
                get {return PlayerInput_field;}
                set {PlayerInput_field = value;}
            }

        }
}
