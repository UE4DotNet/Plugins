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
        ///<summary>Struct that encompasses the most common types of data.</summary>
        ///<remarks>
        ///This is the data payload
        ///of PlatformInterfaceDelegateResult.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct PlatformInterfaceData {
            [FieldOffset(0)] public Name DataName;

            [FieldOffset(12)] public byte Type;

            [FieldOffset(16)] public int IntValue;

            [FieldOffset(20)] public float FloatValue;

            [FieldOffset(24)] byte StringValue; //TODO: string FString StringValue

            [FieldOffset(40)] 
            private IntPtr  ObjectValue_field;
            ///<summary>Object Value</summary>
            public UObject ObjectValue {
                get {return ObjectValue_field;}
                set {ObjectValue_field = value;}
            }

        }
}
