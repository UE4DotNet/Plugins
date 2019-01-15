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


namespace UE4.UnrealEd{
        ///<summary>This structs properties should be pushed out to categories inside its parent category unless it is in an array</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct PropertyEditorTestBasicStruct {
            [FieldOffset(0)] public int IntPropertyInsideAStruct;

            [FieldOffset(4)] public float FloatPropertyInsideAStruct;

            [FieldOffset(8)] 
            private IntPtr  ObjectPropertyInsideAStruct_field;
            ///<summary>Object Property Inside AStruct</summary>
            public UObject ObjectPropertyInsideAStruct {
                get {return ObjectPropertyInsideAStruct_field;}
                set {ObjectPropertyInsideAStruct_field = value;}
            }

            ///<summary>Inner Struct</summary>
            [FieldOffset(16)] PropertyEditorTestSubStruct InnerStruct;

        }
}
