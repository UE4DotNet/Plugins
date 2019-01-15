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
        ///<summary>Automation Event</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct AutomationEvent {
            [FieldOffset(0)] byte Type; //TODO: enum EAutomationEventType Type

            [FieldOffset(8)] byte Message; //TODO: string FString Message

            [FieldOffset(24)] byte Context; //TODO: string FString Context

            ///<summary>Artifact</summary>
            [FieldOffset(40)] FGuid Artifact;

        }
}
