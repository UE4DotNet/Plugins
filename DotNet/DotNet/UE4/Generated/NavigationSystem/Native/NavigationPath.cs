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


namespace UE4.NavigationSystem.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct NavigationPath_fields {
        [FieldOffset(56)] byte PathUpdatedNotifier; //TODO: multicast delegate FOnNavigationPathUpdated PathUpdatedNotifier
        [FieldOffset(72)] public NativeArray PathPoints;
        [FieldOffset(88)] public byte RecalculateOnInvalidation;
    }
    internal unsafe struct NavigationPath_methods {
        internal struct EnableDebugDrawing_method {
            static internal IntPtr EnableDebugDrawing_ptr;
            static EnableDebugDrawing_method() {
                EnableDebugDrawing_ptr = Main.GetMethodUFunction(NavigationPath.StaticClass, "EnableDebugDrawing");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bShouldDrawDebugData, LinearColor PathColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bShouldDrawDebugData;
                *((LinearColor*)(b+4)) = PathColor;
                Main.GetProcessEvent(obj, EnableDebugDrawing_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableRecalculationOnInvalidation_method {
            static internal IntPtr EnableRecalculationOnInvalidation_ptr;
            static EnableRecalculationOnInvalidation_method() {
                EnableRecalculationOnInvalidation_ptr = Main.GetMethodUFunction(NavigationPath.StaticClass, "EnableRecalculationOnInvalidation");
            }

            internal static unsafe void Invoke(IntPtr obj, byte DoRecalculation) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = DoRecalculation;
                Main.GetProcessEvent(obj, EnableRecalculationOnInvalidation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetDebugString_method {
            static internal IntPtr GetDebugString_ptr;
            static GetDebugString_method() {
                GetDebugString_ptr = Main.GetMethodUFunction(NavigationPath.StaticClass, "GetDebugString");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDebugString_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetPathCost_method {
            static internal IntPtr GetPathCost_ptr;
            static GetPathCost_method() {
                GetPathCost_ptr = Main.GetMethodUFunction(NavigationPath.StaticClass, "GetPathCost");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPathCost_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPathLength_method {
            static internal IntPtr GetPathLength_ptr;
            static GetPathLength_method() {
                GetPathLength_ptr = Main.GetMethodUFunction(NavigationPath.StaticClass, "GetPathLength");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPathLength_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct IsPartial_method {
            static internal IntPtr IsPartial_ptr;
            static IsPartial_method() {
                IsPartial_ptr = Main.GetMethodUFunction(NavigationPath.StaticClass, "IsPartial");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPartial_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsStringPulled_method {
            static internal IntPtr IsStringPulled_ptr;
            static IsStringPulled_method() {
                IsStringPulled_ptr = Main.GetMethodUFunction(NavigationPath.StaticClass, "IsStringPulled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsStringPulled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsValid_method {
            static internal IntPtr IsValid_ptr;
            static IsValid_method() {
                IsValid_ptr = Main.GetMethodUFunction(NavigationPath.StaticClass, "IsValid");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsValid_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct NavigationPath_events {
    }
}
