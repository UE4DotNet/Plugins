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


namespace UE4.SwarmInterface{
        ///<summary>Swarm Alert Message</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct SwarmAlertMessage {
            ///<summary>The Job Guid</summary>
            [FieldOffset(0)] FGuid JobGuid;

            [FieldOffset(16)] public byte AlertLevel;

            ///<summary>The identifier for the object that is associated with the issue</summary>
            [FieldOffset(20)] FGuid ObjectGuid;

            [FieldOffset(36)] public int TypeId;

            [FieldOffset(40)] byte TextMessage; //TODO: string FString TextMessage

        }
}
