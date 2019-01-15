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
        ///<summary>Property Editor Test Sub Struct</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct PropertyEditorTestSubStruct {
            [FieldOffset(0)] public int FirstProperty;

            [FieldOffset(4)] public int SecondProperty;

            ///<summary>Customized Struct Inside Uncustomized Struct</summary>
            [FieldOffset(8)] LinearColor CustomizedStructInsideUncustomizedStruct;

            ///<summary>Customized Struct Inside Uncustomized Struct 2</summary>
            [FieldOffset(24)] SoftObjectPath CustomizedStructInsideUncustomizedStruct2;

        }
}
