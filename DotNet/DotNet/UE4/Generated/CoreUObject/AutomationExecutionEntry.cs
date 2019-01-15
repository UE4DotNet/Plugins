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
        ///<summary>Automation Execution Entry</summary>
        [StructLayout( LayoutKind.Explicit, Size=88 )]
        public unsafe struct AutomationExecutionEntry {
            ///<summary>Event</summary>
            [FieldOffset(0)] AutomationEvent Event;

            [FieldOffset(56)] byte Filename; //TODO: string FString Filename

            [FieldOffset(72)] public int LineNumber;

            ///<summary>Timestamp</summary>
            [FieldOffset(80)] FDateTime Timestamp;

        }
}
