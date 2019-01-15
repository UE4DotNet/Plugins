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
        ///<summary>This structure describes metadata associated with a user declared function or macro</summary>
        ///<remarks>It will be turned into regular metadata during compilation</remarks>
        [StructLayout( LayoutKind.Explicit, Size=120 )]
        public unsafe struct KismetUserDeclaredFunctionMetadata {
            [FieldOffset(0)] byte ToolTip; //TODO: text FText ToolTip

            [FieldOffset(24)] byte Category; //TODO: text FText Category

            [FieldOffset(48)] byte Keywords; //TODO: text FText Keywords

            [FieldOffset(72)] byte CompactNodeTitle; //TODO: text FText CompactNodeTitle

            ///<summary>Instance Title Color</summary>
            [FieldOffset(96)] LinearColor InstanceTitleColor;

            [FieldOffset(112)] public bool bCallInEditor;

            [FieldOffset(113)] public sbyte HasLatentFunctions;

        }
}
