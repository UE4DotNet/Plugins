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


namespace UE4.CoreUObject{
        ///<summary>Circular dependency on Core vs UHT means we have to noexport these structs so tools can build</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct JoinabilitySettings {
            [FieldOffset(0)] public Name SessionName;

            [FieldOffset(12)] public bool bPublicSearchable;

            [FieldOffset(13)] public bool bAllowInvites;

            [FieldOffset(14)] public bool bJoinViaPresence;

            [FieldOffset(15)] public bool bJoinViaPresenceFriendsOnly;

            [FieldOffset(16)] public int MaxPlayers;

            [FieldOffset(20)] public int MaxPartySize;

        }
}
