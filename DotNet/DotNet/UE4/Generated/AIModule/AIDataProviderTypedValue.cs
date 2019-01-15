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


namespace UE4.AIModule{
        ///<summary>AIData Provider Typed Value</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct AIDataProviderTypedValue {
            ///<summary>type of value</summary>
            public SubclassOf<Property> PropertyType {
                get {return PropertyType_class; }
                set {PropertyType_class = value; }
            }
            [FieldOffset(40)] private IntPtr PropertyType_class;

        }
}
