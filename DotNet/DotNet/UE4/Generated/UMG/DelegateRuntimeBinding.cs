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


namespace UE4.UMG{
        ///<summary>Delegate Runtime Binding</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct DelegateRuntimeBinding {
            [FieldOffset(0)] byte ObjectName; //TODO: string FString ObjectName

            [FieldOffset(16)] public Name PropertyName;

            [FieldOffset(28)] public Name FunctionName;

            ///<summary>Source Path</summary>
            [FieldOffset(40)] DynamicPropertyPath SourcePath;

            [FieldOffset(88)] byte Kind; //TODO: enum EBindingKind Kind

        }
}
