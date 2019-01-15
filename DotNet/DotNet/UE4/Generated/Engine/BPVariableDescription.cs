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
        ///<summary>Struct indicating a variable in the generated class</summary>
        [StructLayout( LayoutKind.Explicit, Size=240 )]
        public unsafe struct BPVariableDescription {
            [FieldOffset(0)] public Name VarName;

            ///<summary>A Guid that will remain constant even if the VarName changes</summary>
            [FieldOffset(12)] FGuid VarGuid;

            ///<summary>Type of the variable</summary>
            [FieldOffset(32)] EdGraphPinType VarType;

            [FieldOffset(144)] byte FriendlyName; //TODO: string FString FriendlyName

            [FieldOffset(160)] byte Category; //TODO: text FText Category

            [FieldOffset(184)] byte PropertyFlags; //TODO: numeric uint64 PropertyFlags

            [FieldOffset(192)] public Name RepNotifyFunc;

            [FieldOffset(204)] public byte ReplicationCondition;

            [FieldOffset(208)] byte MetaDataArray; //TODO: array TArray MetaDataArray

            [FieldOffset(224)] byte DefaultValue; //TODO: string FString DefaultValue

        }
}
