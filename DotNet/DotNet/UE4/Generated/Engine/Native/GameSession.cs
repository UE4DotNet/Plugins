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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1048 )]
    internal unsafe struct GameSession_fields {
        [FieldOffset(1016)] public int MaxSpectators;
        [FieldOffset(1020)] public int MaxPlayers;
        [FieldOffset(1024)] public int MaxPartySize;
        [FieldOffset(1028)] public byte MaxSplitscreensPerConnection;
        [FieldOffset(1029)] public bool bRequiresPushToTalk;
        [FieldOffset(1032)] public Name SessionName;
    }
    internal unsafe struct GameSession_methods {
    }
    internal unsafe struct GameSession_events {
    }
}
