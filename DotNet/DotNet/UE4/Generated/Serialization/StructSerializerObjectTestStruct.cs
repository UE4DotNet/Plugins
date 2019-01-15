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


namespace UE4.Serialization{
        ///<summary>Test structure for UObject properties.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct StructSerializerObjectTestStruct {
            ///<summary>Class</summary>
            public SubclassOf<UObject> Class {
                get {return Class_class; }
                set {Class_class = value; }
            }
            [FieldOffset(0)] private IntPtr Class_class;

            [FieldOffset(8)] 
            private IntPtr  ObjectPtr_field;
            ///<summary>Object Ptr</summary>
            public UObject ObjectPtr {
                get {return ObjectPtr_field;}
                set {ObjectPtr_field = value;}
            }

        }
}
