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


namespace UE4.EngineMessages{
        ///<summary>Implements a message for denying service access to a remote user.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct EngineServiceAuthDeny {
            [FieldOffset(0)] byte UserName; //TODO: string FString UserName

            [FieldOffset(16)] byte UserToDeny; //TODO: string FString UserToDeny

        }
}
