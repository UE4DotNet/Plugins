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
        ///<summary>Blueprint Input Action Delegate Binding</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct BlueprintInputActionDelegateBinding {
            [FieldOffset(4)] public Name InputActionName;

            [FieldOffset(16)] public byte InputKeyEvent;

            [FieldOffset(20)] public Name FunctionNameToBind;

        }
}
