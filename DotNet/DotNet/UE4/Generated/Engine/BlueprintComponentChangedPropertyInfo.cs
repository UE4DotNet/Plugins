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
        ///<summary>A single changed Blueprint component property.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct BlueprintComponentChangedPropertyInfo {
            [FieldOffset(0)] public Name PropertyName;

            [FieldOffset(12)] public int ArrayIndex;

            [FieldOffset(16)] 
            private IntPtr  PropertyScope_field;
            ///<summary>The parent struct (owner) of the changed property.</summary>
            public Struct PropertyScope {
                get {return PropertyScope_field;}
                set {PropertyScope_field = value;}
            }

        }
}
