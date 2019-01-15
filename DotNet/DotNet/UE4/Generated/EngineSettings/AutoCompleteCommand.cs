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


namespace UE4.EngineSettings{
        ///<summary>Structure for auto-complete commands and their descriptions.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct AutoCompleteCommand {
            [FieldOffset(0)] byte Command; //TODO: string FString Command

            [FieldOffset(16)] byte Desc; //TODO: string FString Desc

        }
}
