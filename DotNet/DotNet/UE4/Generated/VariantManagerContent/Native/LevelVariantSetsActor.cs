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


namespace UE4.VariantManagerContent.Native {
    [StructLayout( LayoutKind.Explicit, Size=1040 )]
    internal unsafe struct LevelVariantSetsActor_fields {
        [FieldOffset(1008)] public SoftObjectPath LevelVariantSets;
    }
    internal unsafe struct LevelVariantSetsActor_methods {
        internal struct GetLevelVariantSets_method {
            static internal IntPtr GetLevelVariantSets_ptr;
            static GetLevelVariantSets_method() {
                GetLevelVariantSets_ptr = Main.GetMethodUFunction(LevelVariantSetsActor.StaticClass, "GetLevelVariantSets");
            }

            internal static unsafe LevelVariantSets Invoke(IntPtr obj, bool bLoad) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bLoad;
                Main.GetProcessEvent(obj, GetLevelVariantSets_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SetLevelVariantSets_method {
            static internal IntPtr SetLevelVariantSets_ptr;
            static SetLevelVariantSets_method() {
                SetLevelVariantSets_ptr = Main.GetMethodUFunction(LevelVariantSetsActor.StaticClass, "SetLevelVariantSets");
            }

            internal static unsafe void Invoke(IntPtr obj, LevelVariantSets InVariantSets) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InVariantSets;
                Main.GetProcessEvent(obj, SetLevelVariantSets_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SwitchOnVariantByIndex_method {
            static internal IntPtr SwitchOnVariantByIndex_ptr;
            static SwitchOnVariantByIndex_method() {
                SwitchOnVariantByIndex_ptr = Main.GetMethodUFunction(LevelVariantSetsActor.StaticClass, "SwitchOnVariantByIndex");
            }

            internal static unsafe bool Invoke(IntPtr obj, int VariantSetIndex, int VariantIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = VariantSetIndex;
                *((int*)(b+4)) = VariantIndex;
                Main.GetProcessEvent(obj, SwitchOnVariantByIndex_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct SwitchOnVariantByName_method {
            static internal IntPtr SwitchOnVariantByName_ptr;
            static SwitchOnVariantByName_method() {
                SwitchOnVariantByName_ptr = Main.GetMethodUFunction(LevelVariantSetsActor.StaticClass, "SwitchOnVariantByName");
            }

            internal static unsafe bool Invoke(IntPtr obj, string VariantSetName, string VariantName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var VariantSetName_handle = GCHandle.Alloc(VariantSetName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = VariantSetName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = VariantSetName.Length;
                *(int*)(b+IntPtr.Size+4+0) = VariantSetName.Length;
                var VariantName_handle = GCHandle.Alloc(VariantName, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = VariantName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = VariantName.Length;
                *(int*)(b+IntPtr.Size+4+16) = VariantName.Length;
                Main.GetProcessEvent(obj, SwitchOnVariantByName_ptr, new IntPtr(p)); ;
                VariantSetName_handle.Free();
                VariantName_handle.Free();
                return *((bool*)(b+32));
            }
        }
    }
    internal unsafe struct LevelVariantSetsActor_events {
    }
}
