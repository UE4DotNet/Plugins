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

using UE4.Engine;

namespace UE4.UMGEditor{
        ///<summary>Directory Widget Compiler Options</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct DirectoryWidgetCompilerOptions {
            ///<summary>Directory</summary>
            [FieldOffset(0)] DirectoryPath Directory;

            [FieldOffset(16)] byte IgnoredWidgets; //TODO: array TArray IgnoredWidgets

            ///<summary>Options</summary>
            [FieldOffset(32)] WidgetCompilerOptions Options;

        }
}
