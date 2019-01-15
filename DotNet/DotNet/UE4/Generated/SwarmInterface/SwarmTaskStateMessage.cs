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
        ///<summary>Swarm Task State Message</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct SwarmTaskStateMessage {
            ///<summary>The Task GUID used for identifying the Task</summary>
            [FieldOffset(0)] FGuid FGuid;

            [FieldOffset(16)] public byte State;

            [FieldOffset(24)] byte Message; //TODO: string FString Message

            [FieldOffset(40)] public int ExitCode;

            [FieldOffset(48)] public double RunningTime;

        }
}
