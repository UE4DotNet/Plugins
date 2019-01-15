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
        ///<summary>A pose in component space (i.e. each transform is relative to the component's transform)</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct ComponentSpacePose {
            [FieldOffset(0)] byte Transforms; //TODO: array TArray Transforms

            [FieldOffset(16)] byte Names; //TODO: array TArray Names

        }
}
