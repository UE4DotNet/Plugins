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


namespace UE4.MediaAssets{
        ///<summary>Information about a capture device.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct MediaCaptureDevice {
            [FieldOffset(0)] byte DisplayName; //TODO: text FText DisplayName

            [FieldOffset(24)] byte Url; //TODO: string FString Url

        }
}
