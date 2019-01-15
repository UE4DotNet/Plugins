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
        ///<summary>Entry for a delegate to assign after a blueprint has been instanced</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct BlueprintComponentDelegateBinding {
            [FieldOffset(0)] public Name ComponentPropertyName;

            [FieldOffset(12)] public Name DelegatePropertyName;

            [FieldOffset(24)] public Name FunctionNameToBind;

        }
}
