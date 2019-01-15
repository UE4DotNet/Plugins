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


namespace UE4.BlueprintGraph{
        ///<summary>
        ///Structure used to automatically convert blueprintcallable functions (that have blueprint parameter) calls (in bp graph)
        ///into their never versions (with class param instead of blueprint).
        ///</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct BlueprintCallableFunctionRedirect {
            [FieldOffset(0)] byte ClassName; //TODO: string FString ClassName

            [FieldOffset(16)] byte OldFunctionName; //TODO: string FString OldFunctionName

            [FieldOffset(32)] byte NewFunctionName; //TODO: string FString NewFunctionName

            [FieldOffset(48)] byte BlueprintParamName; //TODO: string FString BlueprintParamName

            [FieldOffset(64)] byte ClassParamName; //TODO: string FString ClassParamName

        }
}
