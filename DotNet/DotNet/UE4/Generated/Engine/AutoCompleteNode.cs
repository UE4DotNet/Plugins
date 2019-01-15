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
        ///<summary>Node for storing an auto-complete tree based on each char in the command.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct AutoCompleteNode {
            [FieldOffset(0)] public int IndexChar;

            [FieldOffset(8)] byte AutoCompleteListIndices; //TODO: array TArray AutoCompleteListIndices

        }
}
