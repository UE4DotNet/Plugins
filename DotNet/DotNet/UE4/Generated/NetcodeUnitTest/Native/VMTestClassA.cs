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


namespace UE4.NetcodeUnitTest.Native {
    [StructLayout( LayoutKind.Explicit, Size=528 )]
    internal unsafe struct VMTestClassA_fields {
        [FieldOffset(56)]  public IntPtr  AObjectRef;
        [FieldOffset(64)] public byte ByteProp;
        [FieldOffset(66)] byte UInt16Prop; //TODO: numeric uint16 UInt16Prop
        [FieldOffset(68)] byte UInt32Prop; //TODO: numeric uint32 UInt32Prop
        [FieldOffset(72)] byte UInt64Prop; //TODO: numeric uint64 UInt64Prop
        [FieldOffset(80)] public sbyte Int8Prop;
        [FieldOffset(82)] public short Int16Prop;
        [FieldOffset(84)] public int Int32Prop;
        [FieldOffset(88)] public long Int64Prop;
        [FieldOffset(96)] public float FloatProp;
        [FieldOffset(104)] public double DoubleProp;
        [FieldOffset(112)] public bool bBoolPropA;
        [FieldOffset(113)] public bool bBoolPropB;
        [FieldOffset(114)] public bool bBoolPropC;
        [FieldOffset(115)] public bool bBoolPropD;
        [FieldOffset(116)] public bool bBoolPropE;
        [FieldOffset(120)] public Name NameProp;
        [FieldOffset(136)] byte StringProp; //TODO: string FString StringProp
        [FieldOffset(152)] byte TextProp; //TODO: text FText TextProp
        [FieldOffset(176)] public byte BytePropArray;
        [FieldOffset(184)]  public IntPtr  ObjectPropArray;
        [FieldOffset(200)] public NativeArray DynBytePropArray;
        [FieldOffset(216)] public NativeArray DynBoolPropArray;
        [FieldOffset(232)] public NativeArray DynObjectPropArray;
        [FieldOffset(248)] public NativeArray DynNamePropArray;
        [FieldOffset(264)] public NativeArray DynDoublePropArray;
        [FieldOffset(280)] public NativeArray DynFloatPropArray;
        [FieldOffset(296)] public NativeArray DynInt16PropArray;
        [FieldOffset(312)] public NativeArray DynInt64PropArray;
        [FieldOffset(328)] public NativeArray DynInt8PropArray;
        [FieldOffset(344)] public NativeArray DynIntPropArray;
        [FieldOffset(360)] public NativeArray DynUInt16PropArray;
        [FieldOffset(376)] public NativeArray DynUIntPropArray;
        [FieldOffset(392)] public NativeArray DynUInt64PropArray;
        [FieldOffset(408)] public NativeArray DynStringPropArray;
        [FieldOffset(424)] public NativeArray DynTextPropArray;
        [FieldOffset(440)] public NativeArray DynClassPropArray;
        [FieldOffset(456)] public NativeArray DynPawnPropArray;
        [FieldOffset(472)] public Vector StructProp;
        [FieldOffset(484)] public Vector StructPropArray;
        [FieldOffset(512)] public NativeArray DynStructPropArray;
    }
    internal unsafe struct VMTestClassA_methods {
    }
    internal unsafe struct VMTestClassA_events {
    }
}
