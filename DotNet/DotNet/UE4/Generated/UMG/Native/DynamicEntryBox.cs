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


namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=704 )]
    internal unsafe struct DynamicEntryBox_fields {
        [FieldOffset(400)] public int NumDesignerPreviewEntries;
        [FieldOffset(496)] byte EntryBoxType; //TODO: enum EDynamicBoxType EntryBoxType
        [FieldOffset(500)] public Vector2D EntrySpacing;
        [FieldOffset(512)] public NativeArray SpacingPattern;
        [FieldOffset(528)] public SlateChildSize EntrySizeRule;
        [FieldOffset(536)] public byte EntryHorizontalAlignment;
        [FieldOffset(537)] public byte EntryVerticalAlignment;
        [FieldOffset(540)] public int MaxElementSize;
        [FieldOffset(560)] public IntPtr EntryWidgetClass;
    }
    internal unsafe struct DynamicEntryBox_methods {
        internal struct BP_CreateEntry_method {
            static internal IntPtr BP_CreateEntry_ptr;
            static BP_CreateEntry_method() {
                BP_CreateEntry_ptr = Main.GetMethodUFunction(DynamicEntryBox.StaticClass, "BP_CreateEntry");
            }

            internal static unsafe UserWidget Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, BP_CreateEntry_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct BP_CreateEntryOfClass_method {
            static internal IntPtr BP_CreateEntryOfClass_ptr;
            static BP_CreateEntryOfClass_method() {
                BP_CreateEntryOfClass_ptr = Main.GetMethodUFunction(DynamicEntryBox.StaticClass, "BP_CreateEntryOfClass");
            }

            internal static unsafe UserWidget Invoke(IntPtr obj, SubclassOf<UserWidget> EntryClass) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = EntryClass;
                Main.GetProcessEvent(obj, BP_CreateEntryOfClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetAllEntries_method {
            static internal IntPtr GetAllEntries_ptr;
            static GetAllEntries_method() {
                GetAllEntries_ptr = Main.GetMethodUFunction(DynamicEntryBox.StaticClass, "GetAllEntries");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ReturnValue /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ReturnValue
                Main.GetProcessEvent(obj, GetAllEntries_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
            }
        }
        internal struct GetNumEntries_method {
            static internal IntPtr GetNumEntries_ptr;
            static GetNumEntries_method() {
                GetNumEntries_ptr = Main.GetMethodUFunction(DynamicEntryBox.StaticClass, "GetNumEntries");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumEntries_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct RemoveEntry_method {
            static internal IntPtr RemoveEntry_ptr;
            static RemoveEntry_method() {
                RemoveEntry_ptr = Main.GetMethodUFunction(DynamicEntryBox.StaticClass, "RemoveEntry");
            }

            internal static unsafe void Invoke(IntPtr obj, UserWidget EntryWidget) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = EntryWidget;
                Main.GetProcessEvent(obj, RemoveEntry_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Reset_method {
            static internal IntPtr Reset_ptr;
            static Reset_method() {
                Reset_ptr = Main.GetMethodUFunction(DynamicEntryBox.StaticClass, "Reset");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bDeleteWidgets) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bDeleteWidgets;
                Main.GetProcessEvent(obj, Reset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEntrySpacing_method {
            static internal IntPtr SetEntrySpacing_ptr;
            static SetEntrySpacing_method() {
                SetEntrySpacing_ptr = Main.GetMethodUFunction(DynamicEntryBox.StaticClass, "SetEntrySpacing");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D InEntrySpacing) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InEntrySpacing;
                Main.GetProcessEvent(obj, SetEntrySpacing_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct DynamicEntryBox_events {
    }
}
