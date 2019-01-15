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
    [StructLayout( LayoutKind.Explicit, Size=1016 )]
    internal unsafe struct ExpandableArea_fields {
        [FieldOffset(392)] public ExpandableAreaStyle Style;
        [FieldOffset(728)] public SlateBrush BorderBrush;
        [FieldOffset(888)] public SlateColor BorderColor;
        [FieldOffset(928)] public bool bIsExpanded;
        [FieldOffset(932)] public float MaxHeight;
        [FieldOffset(936)] public Margin HeaderPadding;
        [FieldOffset(952)] public Margin AreaPadding;
        [FieldOffset(968)] byte OnExpansionChanged; //TODO: multicast delegate FOnExpandableAreaExpansionChanged OnExpansionChanged
        [FieldOffset(984)]  public IntPtr  HeaderContent;
        [FieldOffset(992)]  public IntPtr  BodyContent;
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
