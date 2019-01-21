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

using UE4.SlateCore;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=1032 )]
    internal unsafe struct ExpandableArea_fields {
        [FieldOffset(408)] public ExpandableAreaStyle Style;
        [FieldOffset(744)] public SlateBrush BorderBrush;
        [FieldOffset(904)] public SlateColor BorderColor;
        [FieldOffset(944)] public bool bIsExpanded;
        [FieldOffset(948)] public float MaxHeight;
        [FieldOffset(952)] public Margin HeaderPadding;
        [FieldOffset(968)] public Margin AreaPadding;
        [FieldOffset(984)] byte OnExpansionChanged; //TODO: multicast delegate FOnExpandableAreaExpansionChanged OnExpansionChanged
        [FieldOffset(1000)]  public IntPtr  HeaderContent;
        [FieldOffset(1008)]  public IntPtr  BodyContent;
    }
    internal unsafe struct ExpandableArea_methods {
        internal struct GetIsExpanded_method {
            static internal IntPtr GetIsExpanded_ptr;
            static GetIsExpanded_method() {
                GetIsExpanded_ptr = Main.GetMethodUFunction(ExpandableArea.StaticClass, "GetIsExpanded");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetIsExpanded_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetIsExpanded_method {
            static internal IntPtr SetIsExpanded_ptr;
            static SetIsExpanded_method() {
                SetIsExpanded_ptr = Main.GetMethodUFunction(ExpandableArea.StaticClass, "SetIsExpanded");
            }

            internal static unsafe void Invoke(IntPtr obj, bool IsExpanded) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = IsExpanded;
                Main.GetProcessEvent(obj, SetIsExpanded_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIsExpanded_Animated_method {
            static internal IntPtr SetIsExpanded_Animated_ptr;
            static SetIsExpanded_Animated_method() {
                SetIsExpanded_Animated_ptr = Main.GetMethodUFunction(ExpandableArea.StaticClass, "SetIsExpanded_Animated");
            }

            internal static unsafe void Invoke(IntPtr obj, bool IsExpanded) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = IsExpanded;
                Main.GetProcessEvent(obj, SetIsExpanded_Animated_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ExpandableArea_events {
    }
}
