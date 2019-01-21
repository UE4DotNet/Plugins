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


namespace UE4.LiveLinkInterface{
        ///<summary>Live Link Frame Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        public unsafe struct LiveLinkFrameData {
            [FieldOffset(0)] byte Transforms; //TODO: array TArray Transforms

            [FieldOffset(16)] byte CurveElements; //TODO: array TArray CurveElements

            ///<summary>World Time</summary>
            [FieldOffset(32)] LiveLinkWorldTime WorldTime;

            ///<summary>Meta Data</summary>
            [FieldOffset(48)] LiveLinkMetaData MetaData;

        }
}
