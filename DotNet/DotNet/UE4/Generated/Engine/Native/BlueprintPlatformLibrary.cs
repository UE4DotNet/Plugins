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
    internal unsafe struct BlueprintPlatformLibrary_fields {
    }
    internal unsafe struct BlueprintPlatformLibrary_methods {
        internal struct CancelLocalNotification_method {
            static internal IntPtr CancelLocalNotification_ptr;
            static CancelLocalNotification_method() {
                CancelLocalNotification_ptr = Main.GetMethodUFunction(BlueprintPlatformLibrary.StaticClass, "CancelLocalNotification");
            }

            internal static unsafe void Invoke(string ActivationEvent) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var ActivationEvent_handle = GCHandle.Alloc(ActivationEvent, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = ActivationEvent_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = ActivationEvent.Length;
                *(int*)(b+IntPtr.Size+4+0) = ActivationEvent.Length;
                Main.GetProcessEvent(BlueprintPlatformLibrary.DefaultObject, CancelLocalNotification_ptr, new IntPtr(p)); ;
                ActivationEvent_handle.Free();
            }
        }
        internal struct ClearAllLocalNotifications_method {
            static internal IntPtr ClearAllLocalNotifications_ptr;
            static ClearAllLocalNotifications_method() {
                ClearAllLocalNotifications_ptr = Main.GetMethodUFunction(BlueprintPlatformLibrary.StaticClass, "ClearAllLocalNotifications");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(BlueprintPlatformLibrary.DefaultObject, ClearAllLocalNotifications_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetLaunchNotification_method {
            static internal IntPtr GetLaunchNotification_ptr;
            static GetLaunchNotification_method() {
                GetLaunchNotification_ptr = Main.GetMethodUFunction(BlueprintPlatformLibrary.StaticClass, "GetLaunchNotification");
            }

            internal static unsafe (bool, string, int) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(BlueprintPlatformLibrary.DefaultObject, GetLaunchNotification_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+0)),FString.Get(b+8),*((int*)(b+24)));
            }
        }
        internal struct ScheduleLocalNotificationAtTime_method {
            static internal IntPtr ScheduleLocalNotificationAtTime_ptr;
            static ScheduleLocalNotificationAtTime_method() {
                ScheduleLocalNotificationAtTime_ptr = Main.GetMethodUFunction(BlueprintPlatformLibrary.StaticClass, "ScheduleLocalNotificationAtTime");
            }

            internal static unsafe void Invoke(FDateTime FireDateTime, bool LocalTime, byte Title /*TODO: text FText */, byte Body /*TODO: text FText */, byte Action /*TODO: text FText */, string ActivationEvent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = FireDateTime;
                *((bool*)(b+8)) = LocalTime;
                throw new NotImplementedException(); //TODO: text FText Title
                throw new NotImplementedException(); //TODO: text FText Body
                throw new NotImplementedException(); //TODO: text FText Action
                var ActivationEvent_handle = GCHandle.Alloc(ActivationEvent, GCHandleType.Pinned);
                *(IntPtr*)(b+88) = ActivationEvent_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+88) = ActivationEvent.Length;
                *(int*)(b+IntPtr.Size+4+88) = ActivationEvent.Length;
                Main.GetProcessEvent(BlueprintPlatformLibrary.DefaultObject, ScheduleLocalNotificationAtTime_ptr, new IntPtr(p)); ;
                 //TODO: text FText Title
                 //TODO: text FText Body
                 //TODO: text FText Action
                ActivationEvent_handle.Free();
            }
        }
        internal struct ScheduleLocalNotificationBadgeAtTime_method {
            static internal IntPtr ScheduleLocalNotificationBadgeAtTime_ptr;
            static ScheduleLocalNotificationBadgeAtTime_method() {
                ScheduleLocalNotificationBadgeAtTime_ptr = Main.GetMethodUFunction(BlueprintPlatformLibrary.StaticClass, "ScheduleLocalNotificationBadgeAtTime");
            }

            internal static unsafe void Invoke(FDateTime FireDateTime, bool LocalTime, string ActivationEvent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = FireDateTime;
                *((bool*)(b+8)) = LocalTime;
                var ActivationEvent_handle = GCHandle.Alloc(ActivationEvent, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = ActivationEvent_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = ActivationEvent.Length;
                *(int*)(b+IntPtr.Size+4+16) = ActivationEvent.Length;
                Main.GetProcessEvent(BlueprintPlatformLibrary.DefaultObject, ScheduleLocalNotificationBadgeAtTime_ptr, new IntPtr(p)); ;
                ActivationEvent_handle.Free();
            }
        }
        internal struct ScheduleLocalNotificationBadgeFromNow_method {
            static internal IntPtr ScheduleLocalNotificationBadgeFromNow_ptr;
            static ScheduleLocalNotificationBadgeFromNow_method() {
                ScheduleLocalNotificationBadgeFromNow_ptr = Main.GetMethodUFunction(BlueprintPlatformLibrary.StaticClass, "ScheduleLocalNotificationBadgeFromNow");
            }

            internal static unsafe void Invoke(int inSecondsFromNow, string ActivationEvent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = inSecondsFromNow;
                var ActivationEvent_handle = GCHandle.Alloc(ActivationEvent, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = ActivationEvent_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = ActivationEvent.Length;
                *(int*)(b+IntPtr.Size+4+8) = ActivationEvent.Length;
                Main.GetProcessEvent(BlueprintPlatformLibrary.DefaultObject, ScheduleLocalNotificationBadgeFromNow_ptr, new IntPtr(p)); ;
                ActivationEvent_handle.Free();
            }
        }
        internal struct ScheduleLocalNotificationFromNow_method {
            static internal IntPtr ScheduleLocalNotificationFromNow_ptr;
            static ScheduleLocalNotificationFromNow_method() {
                ScheduleLocalNotificationFromNow_ptr = Main.GetMethodUFunction(BlueprintPlatformLibrary.StaticClass, "ScheduleLocalNotificationFromNow");
            }

            internal static unsafe void Invoke(int inSecondsFromNow, byte Title /*TODO: text FText */, byte Body /*TODO: text FText */, byte Action /*TODO: text FText */, string ActivationEvent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = inSecondsFromNow;
                throw new NotImplementedException(); //TODO: text FText Title
                throw new NotImplementedException(); //TODO: text FText Body
                throw new NotImplementedException(); //TODO: text FText Action
                var ActivationEvent_handle = GCHandle.Alloc(ActivationEvent, GCHandleType.Pinned);
                *(IntPtr*)(b+80) = ActivationEvent_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+80) = ActivationEvent.Length;
                *(int*)(b+IntPtr.Size+4+80) = ActivationEvent.Length;
                Main.GetProcessEvent(BlueprintPlatformLibrary.DefaultObject, ScheduleLocalNotificationFromNow_ptr, new IntPtr(p)); ;
                 //TODO: text FText Title
                 //TODO: text FText Body
                 //TODO: text FText Action
                ActivationEvent_handle.Free();
            }
        }
    }
    internal unsafe struct BlueprintPlatformLibrary_events {
    }
}
