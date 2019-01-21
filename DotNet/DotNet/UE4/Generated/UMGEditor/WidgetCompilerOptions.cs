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


namespace UE4.UMGEditor{
        ///<summary>Widget Compiler Options</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct WidgetCompilerOptions {
            [FieldOffset(0)] public bool bCookSlowConstructionWidgetTree;

            [FieldOffset(1)] public bool bWidgetSupportsDynamicCreation;

            [FieldOffset(2)] public bool bAllowBlueprintTick;

            [FieldOffset(3)] public bool bAllowBlueprintPaint;

            [FieldOffset(4)] byte PropertyBindingRule; //TODO: enum EPropertyBindingPermissionLevel PropertyBindingRule

            [FieldOffset(8)] byte Rules; //TODO: array TArray Rules

        }
}
