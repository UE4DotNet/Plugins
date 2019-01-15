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
        ///<summary>Editable texture parameter.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct TextureParameterValue {
            ///<summary>Parameter Info</summary>
            [FieldOffset(12)] MaterialParameterInfo ParameterInfo;

            [FieldOffset(32)] 
            private IntPtr  ParameterValue_field;
            ///<summary>Parameter Value</summary>
            public Texture ParameterValue {
                get {return ParameterValue_field;}
                set {ParameterValue_field = value;}
            }

            ///<summary>Expression GUID</summary>
            [FieldOffset(40)] FGuid ExpressionGUID;

        }
}
