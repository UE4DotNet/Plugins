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
        ///<summary>Widget Navigation Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=44 )]
        public unsafe struct WidgetNavigationData {
            [FieldOffset(0)] byte Rule; //TODO: enum EUINavigationRule Rule

            [FieldOffset(4)] public Name WidgetToFocus;

            [FieldOffset(16)] byte Widget; //TODO: weak object TWeakObjectPtr<UWidget> Widget

            [FieldOffset(24)] byte CustomDelegate; //TODO: delegate FCustomWidgetNavigationDelegate CustomDelegate

        }
}
