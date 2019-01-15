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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct VisualLoggerKismetLibrary_fields {
    }
    internal unsafe struct VisualLoggerKismetLibrary_methods {
        internal struct EnableRecording_method {
            static internal IntPtr EnableRecording_ptr;
            static EnableRecording_method() {
                EnableRecording_ptr = Main.GetMethodUFunction(VisualLoggerKismetLibrary.StaticClass, "EnableRecording");
            }

            internal static unsafe void Invoke(bool bEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnabled;
                Main.GetProcessEvent(VisualLoggerKismetLibrary.DefaultObject, EnableRecording_ptr, new IntPtr(p)); ;
            }
        }
        internal struct LogBox_method {
            static internal IntPtr LogBox_ptr;
            static LogBox_method() {
                LogBox_ptr = Main.GetMethodUFunction(VisualLoggerKismetLibrary.StaticClass, "LogBox");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Box BoxShape, string Text, LinearColor ObjectColor, Name LogCategory, bool bAddToMessageLog) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Box*)(b+8)) = BoxShape;
                var Text_handle = GCHandle.Alloc(Text, GCHandleType.Pinned);
                *(IntPtr*)(b+40) = Text_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+40) = Text.Length;
                *(int*)(b+IntPtr.Size+4+40) = Text.Length;
                *((LinearColor*)(b+56)) = ObjectColor;
                *((Name*)(b+72)) = LogCategory;
                *((bool*)(b+84)) = bAddToMessageLog;
                Main.GetProcessEvent(VisualLoggerKismetLibrary.DefaultObject, LogBox_ptr, new IntPtr(p)); ;
                Text_handle.Free();
            }
        }
        internal struct LogLocation_method {
            static internal IntPtr LogLocation_ptr;
            static LogLocation_method() {
                LogLocation_ptr = Main.GetMethodUFunction(VisualLoggerKismetLibrary.StaticClass, "LogLocation");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector Location, string Text, LinearColor ObjectColor, float Radius, Name LogCategory, bool bAddToMessageLog) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Location;
                var Text_handle = GCHandle.Alloc(Text, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = Text_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = Text.Length;
                *(int*)(b+IntPtr.Size+4+24) = Text.Length;
                *((LinearColor*)(b+40)) = ObjectColor;
                *((float*)(b+56)) = Radius;
                *((Name*)(b+60)) = LogCategory;
                *((bool*)(b+72)) = bAddToMessageLog;
                Main.GetProcessEvent(VisualLoggerKismetLibrary.DefaultObject, LogLocation_ptr, new IntPtr(p)); ;
                Text_handle.Free();
            }
        }
        internal struct LogSegment_method {
            static internal IntPtr LogSegment_ptr;
            static LogSegment_method() {
                LogSegment_ptr = Main.GetMethodUFunction(VisualLoggerKismetLibrary.StaticClass, "LogSegment");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector SegmentStart, Vector SegmentEnd, string Text, LinearColor ObjectColor, float Thickness, Name CategoryName, bool bAddToMessageLog) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = SegmentStart;
                *((Vector*)(b+20)) = SegmentEnd;
                var Text_handle = GCHandle.Alloc(Text, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = Text_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = Text.Length;
                *(int*)(b+IntPtr.Size+4+32) = Text.Length;
                *((LinearColor*)(b+48)) = ObjectColor;
                *((float*)(b+64)) = Thickness;
                *((Name*)(b+68)) = CategoryName;
                *((bool*)(b+80)) = bAddToMessageLog;
                Main.GetProcessEvent(VisualLoggerKismetLibrary.DefaultObject, LogSegment_ptr, new IntPtr(p)); ;
                Text_handle.Free();
            }
        }
        internal struct LogText_method {
            static internal IntPtr LogText_ptr;
            static LogText_method() {
                LogText_ptr = Main.GetMethodUFunction(VisualLoggerKismetLibrary.StaticClass, "LogText");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, string Text, Name LogCategory, bool bAddToMessageLog) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                var Text_handle = GCHandle.Alloc(Text, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = Text_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = Text.Length;
                *(int*)(b+IntPtr.Size+4+8) = Text.Length;
                *((Name*)(b+24)) = LogCategory;
                *((bool*)(b+36)) = bAddToMessageLog;
                Main.GetProcessEvent(VisualLoggerKismetLibrary.DefaultObject, LogText_ptr, new IntPtr(p)); ;
                Text_handle.Free();
            }
        }
        internal struct RedirectVislog_method {
            static internal IntPtr RedirectVislog_ptr;
            static RedirectVislog_method() {
                RedirectVislog_ptr = Main.GetMethodUFunction(VisualLoggerKismetLibrary.StaticClass, "RedirectVislog");
            }

            internal static unsafe void Invoke(UObject SourceOwner, UObject DestinationOwner) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SourceOwner;
                *((IntPtr*)(b+8)) = DestinationOwner;
                Main.GetProcessEvent(VisualLoggerKismetLibrary.DefaultObject, RedirectVislog_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct VisualLoggerKismetLibrary_events {
    }
}
