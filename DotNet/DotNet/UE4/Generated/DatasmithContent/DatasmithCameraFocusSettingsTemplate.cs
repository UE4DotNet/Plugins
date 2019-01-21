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


namespace UE4.DatasmithContent{
        ///<summary>Datasmith Camera Focus Settings Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct DatasmithCameraFocusSettingsTemplate {
            [FieldOffset(0)] byte FocusMethod; //TODO: enum ECameraFocusMethod FocusMethod

            [FieldOffset(4)] public float ManualFocusDistance;

        }
}
