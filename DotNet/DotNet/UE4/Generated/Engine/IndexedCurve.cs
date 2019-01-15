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
        ///<summary>A curve base class which enables key handles to index lookups.</summary>
        ///<remarks>
        ///@todo sequencer: Some heavy refactoring can be done here. Much more stuff can go in this base class.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=88 )]
        public unsafe struct IndexedCurve {
            ///<summary>Map of which key handles go to which indices.</summary>
            [FieldOffset(8)] KeyHandleMap KeyHandlesToIndices;

        }
}
