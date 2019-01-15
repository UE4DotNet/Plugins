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
        ///<summary>Implements a message for executing a console command.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct EngineServiceExecuteCommand {
            [FieldOffset(0)] byte Command; //TODO: string FString Command

            [FieldOffset(16)] byte UserName; //TODO: string FString UserName

        }
}
