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

namespace UE4.OnlineSubsystemUtils {
    ///<summary>Types of reservation requests that can be made by this beacon</summary>
    public enum EClientRequestType {
        NonePending = 0x00000000, 
        ExistingSessionReservation = 0x00000001, 
        ReservationUpdate = 0x00000002, 
        EmptyServerReservation = 0x00000003, 
        Reconnect = 0x00000004, 
        Abandon = 0x00000005, 
        EClientRequestType_MAX = 0x00000006
    }
}
