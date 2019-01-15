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
        ///<summary>A single object bound to a UMG sequence.</summary>
        [StructLayout( LayoutKind.Explicit, Size=44 )]
        public unsafe struct WidgetAnimationBinding {
            [FieldOffset(0)] public Name WidgetName;

            [FieldOffset(12)] public Name SlotWidgetName;

            ///<summary>Animation Guid</summary>
            [FieldOffset(24)] FGuid AnimationGuid;

            [FieldOffset(40)] public bool bIsRootWidget;

        }
}
