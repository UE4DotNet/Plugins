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

namespace UE4.OnlineSubsystemUtils{
        ///<summary>A single player reservation</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct PlayerReservation {
            ///<summary>Unique id for this reservation</summary>
            [FieldOffset(0)] UniqueNetIdRepl UniqueId;

            [FieldOffset(40)] byte ValidationStr; //TODO: string FString ValidationStr

            [FieldOffset(56)] byte Platform; //TODO: string FString Platform

            [FieldOffset(72)] public bool bAllowCrossplay;

            [FieldOffset(76)] public float ElapsedTime;

        }
}
