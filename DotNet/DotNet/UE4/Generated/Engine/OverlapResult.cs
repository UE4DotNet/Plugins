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
        ///<summary>Structure containing information about one hit of an overlap test</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct OverlapResult {
            [FieldOffset(0)] byte Actor; //TODO: weak object TWeakObjectPtr<AActor> Actor

            [FieldOffset(8)] byte Component; //TODO: weak object TWeakObjectPtr<UPrimitiveComponent> Component

            [FieldOffset(20)] public bool bBlockingHit;

        }
}
