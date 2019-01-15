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
        ///<summary>Swarm Pong Message</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct SwarmPongMessage {
            [FieldOffset(0)] public bool bIsEditor;

            [FieldOffset(8)] byte ComputerName; //TODO: string FString ComputerName

        }
}
