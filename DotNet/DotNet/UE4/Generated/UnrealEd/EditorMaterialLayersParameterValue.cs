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
        ///<summary>Editor Material Layers Parameter Value</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct EditorMaterialLayersParameterValue {
            [FieldOffset(40)] 
            private IntPtr  FunctionValue_field;
            ///<summary>Function Value</summary>
            public MaterialFunctionInterface FunctionValue {
                get {return FunctionValue_field;}
                set {FunctionValue_field = value;}
            }

        }
}
