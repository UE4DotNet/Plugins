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


namespace UE4.ViewportInteraction{
        ///<summary>Represents a generic action</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct ViewportActionKeyInput {
            [FieldOffset(0)] public Name ActionType;

            [FieldOffset(12)] public byte Event;

            [FieldOffset(13)] public bool bIsInputCaptured;

        }
}
