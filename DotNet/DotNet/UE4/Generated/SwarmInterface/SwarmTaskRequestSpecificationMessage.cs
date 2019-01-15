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
        ///<summary>Swarm Task Request Specification Message</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct SwarmTaskRequestSpecificationMessage {
            ///<summary>The GUID used for identifying the Task being referred to</summary>
            [FieldOffset(0)] FGuid TaskGuid;

            [FieldOffset(16)] byte Parameters; //TODO: string FString Parameters

            [FieldOffset(32)] public byte Flags;

            [FieldOffset(36)] byte Cost; //TODO: numeric uint32 Cost

            [FieldOffset(40)] byte Dependencies; //TODO: array TArray Dependencies

        }
}
