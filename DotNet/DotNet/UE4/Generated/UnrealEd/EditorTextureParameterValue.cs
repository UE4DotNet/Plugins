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

using UE4.Engine;

namespace UE4.UnrealEd{
        ///<summary>Editor Texture Parameter Value</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct EditorTextureParameterValue {
            [FieldOffset(40)] 
            private IntPtr  ParameterValue_field;
            ///<summary>Parameter Value</summary>
            public Texture ParameterValue {
                get {return ParameterValue_field;}
                set {ParameterValue_field = value;}
            }

        }
}
