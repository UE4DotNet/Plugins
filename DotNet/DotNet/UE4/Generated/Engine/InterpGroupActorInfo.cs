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
        ///<summary>A group and all the actors controlled by the group</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct InterpGroupActorInfo {
            [FieldOffset(0)] public Name ObjectName;

            [FieldOffset(16)] byte Actors; //TODO: array TArray Actors

        }
}
