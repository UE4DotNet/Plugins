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


namespace UE4.Engine{
        ///<summary>PSCPool</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct PSCPool {
            [FieldOffset(0)] byte FreeElements; //TODO: array TArray FreeElements

            [FieldOffset(16)] byte InUseComponents_Auto; //TODO: array TArray InUseComponents_Auto

            [FieldOffset(32)] byte InUseComponents_Manual; //TODO: array TArray InUseComponents_Manual

        }
}
