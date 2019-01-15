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
        ///<summary>Simple structure for redirecting an old asset name/path to a new one</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct AssetManagerRedirect {
            [FieldOffset(0)] byte Old; //TODO: string FString Old

            [FieldOffset(16)] byte New; //TODO: string FString New

        }
}
