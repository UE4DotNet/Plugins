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

using UE4.Engine;

namespace UE4.BlueprintGraph{
        ///<summary>User Pin Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=152 )]
        public unsafe struct UserPinInfo {
            [FieldOffset(0)] public Name PinName;

            ///<summary>Type info for the pin</summary>
            [FieldOffset(16)] EdGraphPinType PinType;

            [FieldOffset(128)] public byte DesiredPinDirection;

            [FieldOffset(136)] byte PinDefaultValue; //TODO: string FString PinDefaultValue

        }
}
