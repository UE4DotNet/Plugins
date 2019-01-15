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
        ///<summary>Used by UUIString::WrapString to track information about each line that is generated as the result of wrapping.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct WrappedStringElement {
            [FieldOffset(0)] byte Value; //TODO: string FString Value

            ///<summary>the size (in pixels) that it will take to render this string</summary>
            [FieldOffset(16)] Vector2D LineExtent;

        }
}
