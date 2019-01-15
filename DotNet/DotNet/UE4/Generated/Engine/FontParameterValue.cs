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
        ///<summary>Editable font parameter.</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct FontParameterValue {
            ///<summary>Parameter Info</summary>
            [FieldOffset(12)] MaterialParameterInfo ParameterInfo;

            [FieldOffset(32)] 
            private IntPtr  FontValue_field;
            ///<summary>Font Value</summary>
            public Font FontValue {
                get {return FontValue_field;}
                set {FontValue_field = value;}
            }

            [FieldOffset(40)] public int FontPage;

            ///<summary>Expression GUID</summary>
            [FieldOffset(44)] FGuid ExpressionGUID;

        }
}
