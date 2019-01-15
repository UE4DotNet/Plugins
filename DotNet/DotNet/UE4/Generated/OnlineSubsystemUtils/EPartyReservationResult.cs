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
    ///<summary>The result code that will be returned during party reservation</summary>
    public enum EPartyReservationResult {
        NoResult = 0x00000000, 
        RequestPending = 0x00000001, 
        GeneralError = 0x00000002, 
        PartyLimitReached = 0x00000003, 
        IncorrectPlayerCount = 0x00000004, 
        RequestTimedOut = 0x00000005, 
        ReservationDuplicate = 0x00000006, 
        ReservationNotFound = 0x00000007, 
        ReservationAccepted = 0x00000008, 
        ReservationDenied = 0x00000009, 
        ReservationDenied_CrossPlayRestriction = 0x0000000a, 
        ReservationDenied_Banned = 0x0000000b, 
        ReservationRequestCanceled = 0x0000000c, 
        ReservationInvalid = 0x0000000d, 
        BadSessionId = 0x0000000e, 
        ReservationDenied_ContainsExistingPlayers = 0x0000000f, 
        EPartyReservationResult_MAX = 0x00000010
    }
}
