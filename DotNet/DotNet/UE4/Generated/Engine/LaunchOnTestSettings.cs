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
        ///<summary>Holds settings for the editor Launch On With Map Iterations test.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct LaunchOnTestSettings {
            ///<summary>Map to be used for the Launch On test *</summary>
            [FieldOffset(0)] FilePath LaunchOnTestmap;

            [FieldOffset(16)] byte DeviceID; //TODO: string FString DeviceID

        }
}
