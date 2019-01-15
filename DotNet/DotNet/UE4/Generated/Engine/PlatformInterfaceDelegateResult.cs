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
        ///<summary>Generic structure for returning most any kind of data from C++ to delegate functions</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct PlatformInterfaceDelegateResult {
            [FieldOffset(0)] public bool bSuccessful;

            ///<summary>The result actual data</summary>
            [FieldOffset(8)] PlatformInterfaceData Data;

        }
}
