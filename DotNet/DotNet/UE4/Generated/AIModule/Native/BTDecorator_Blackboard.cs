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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=224 )]
    internal unsafe struct BTDecorator_Blackboard_fields {
        [FieldOffset(176)] public int IntValue;
        [FieldOffset(180)] public float FloatValue;
        [FieldOffset(184)] byte StringValue; //TODO: string FString StringValue
        [FieldOffset(200)] byte CachedDescription; //TODO: string FString CachedDescription
        [FieldOffset(216)] public byte OperationType;
        [FieldOffset(217)] public byte NotifyObserver;
        [FieldOffset(218)] public byte BasicOperation;
        [FieldOffset(219)] public byte ArithmeticOperation;
        [FieldOffset(220)] public byte TextOperation;
    }
    internal unsafe struct BTDecorator_Blackboard_methods {
    }
    internal unsafe struct BTDecorator_Blackboard_events {
    }
}
