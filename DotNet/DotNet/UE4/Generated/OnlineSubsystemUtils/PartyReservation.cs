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
        ///<summary>A whole party reservation</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct PartyReservation {
            [FieldOffset(0)] public int TeamNum;

            ///<summary>Player initiating the request</summary>
            [FieldOffset(8)] UniqueNetIdRepl PartyLeader;

            [FieldOffset(48)] byte PartyMembers; //TODO: array TArray PartyMembers

        }
}
