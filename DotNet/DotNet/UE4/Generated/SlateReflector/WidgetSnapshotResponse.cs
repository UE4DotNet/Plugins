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


namespace UE4.SlateReflector{
        ///<summary>Implements a message that is used to receive a widget snapshot from a remote target.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct WidgetSnapshotResponse {
            ///<summary>The request ID of this snapshot (used to identify the correct response from the target)</summary>
            [FieldOffset(0)] FGuid SnapshotRequestId;

            [FieldOffset(16)] byte SnapshotData; //TODO: array TArray SnapshotData

        }
}
