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
        ///<summary>Audio Quality Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct AudioQualitySettings {
            [FieldOffset(0)] byte DisplayName; //TODO: text FText DisplayName

            [FieldOffset(24)] public int MaxChannels;

        }
}
