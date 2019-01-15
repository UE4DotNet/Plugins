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

using UE4.GameplayTags;

namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=832 )]
    internal unsafe struct BehaviorTreeComponent_fields {
        [FieldOffset(384)] public NativeArray NodeInstances;
    }
    internal unsafe struct BehaviorTreeComponent_methods {
        internal struct AddCooldownTagDuration_method {
            static internal IntPtr AddCooldownTagDuration_ptr;
            static AddCooldownTagDuration_method() {
                AddCooldownTagDuration_ptr = Main.GetMethodUFunction(BehaviorTreeComponent.StaticClass, "AddCooldownTagDuration");
            }

            internal static unsafe void Invoke(IntPtr obj, GameplayTag CooldownTag, float CooldownDuration, bool bAddToExistingDuration) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = CooldownTag;
                *((float*)(b+12)) = CooldownDuration;
                *((bool*)(b+16)) = bAddToExistingDuration;
                Main.GetProcessEvent(obj, AddCooldownTagDuration_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetTagCooldownEndTime_method {
            static internal IntPtr GetTagCooldownEndTime_ptr;
            static GetTagCooldownEndTime_method() {
                GetTagCooldownEndTime_ptr = Main.GetMethodUFunction(BehaviorTreeComponent.StaticClass, "GetTagCooldownEndTime");
            }

            internal static unsafe float Invoke(IntPtr obj, GameplayTag CooldownTag) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = CooldownTag;
                Main.GetProcessEvent(obj, GetTagCooldownEndTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct SetDynamicSubtree_method {
            static internal IntPtr SetDynamicSubtree_ptr;
            static SetDynamicSubtree_method() {
                SetDynamicSubtree_ptr = Main.GetMethodUFunction(BehaviorTreeComponent.StaticClass, "SetDynamicSubtree");
            }

            internal static unsafe void Invoke(IntPtr obj, GameplayTag InjectTag, BehaviorTree BehaviorAsset) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = InjectTag;
                *((IntPtr*)(b+16)) = BehaviorAsset;
                Main.GetProcessEvent(obj, SetDynamicSubtree_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct BehaviorTreeComponent_events {
    }
}
