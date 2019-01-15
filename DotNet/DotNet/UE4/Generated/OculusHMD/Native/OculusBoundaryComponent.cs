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


namespace UE4.OculusHMD.Native {
    [StructLayout( LayoutKind.Explicit, Size=312 )]
    internal unsafe struct OculusBoundaryComponent_fields {
        [FieldOffset(256)] byte OnOuterBoundaryTriggered; //TODO: multicast delegate FOculusOuterBoundaryTriggeredEvent OnOuterBoundaryTriggered
        [FieldOffset(272)] byte OnOuterBoundaryReturned; //TODO: multicast delegate FOculusOuterBoundaryReturnedEvent OnOuterBoundaryReturned
    }
    internal unsafe struct OculusBoundaryComponent_methods {
        internal struct CheckIfPointWithinOuterBounds_method {
            static internal IntPtr CheckIfPointWithinOuterBounds_ptr;
            static CheckIfPointWithinOuterBounds_method() {
                CheckIfPointWithinOuterBounds_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "CheckIfPointWithinOuterBounds");
            }

            internal static unsafe BoundaryTestResult Invoke(IntPtr obj, Vector Point) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                Main.GetProcessEvent(obj, CheckIfPointWithinOuterBounds_ptr, new IntPtr(p)); ;
                return *((BoundaryTestResult*)(b+12));
            }
        }
        internal struct CheckIfPointWithinPlayArea_method {
            static internal IntPtr CheckIfPointWithinPlayArea_ptr;
            static CheckIfPointWithinPlayArea_method() {
                CheckIfPointWithinPlayArea_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "CheckIfPointWithinPlayArea");
            }

            internal static unsafe BoundaryTestResult Invoke(IntPtr obj, Vector Point) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                Main.GetProcessEvent(obj, CheckIfPointWithinPlayArea_ptr, new IntPtr(p)); ;
                return *((BoundaryTestResult*)(b+12));
            }
        }
        internal struct GetOuterBoundaryDimensions_method {
            static internal IntPtr GetOuterBoundaryDimensions_ptr;
            static GetOuterBoundaryDimensions_method() {
                GetOuterBoundaryDimensions_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "GetOuterBoundaryDimensions");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOuterBoundaryDimensions_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetOuterBoundaryPoints_method {
            static internal IntPtr GetOuterBoundaryPoints_ptr;
            static GetOuterBoundaryPoints_method() {
                GetOuterBoundaryPoints_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "GetOuterBoundaryPoints");
            }

            internal static unsafe IReadOnlyCollection<Vector> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOuterBoundaryPoints_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<Vector>(b+0);
            }
        }
        internal struct GetPlayAreaDimensions_method {
            static internal IntPtr GetPlayAreaDimensions_ptr;
            static GetPlayAreaDimensions_method() {
                GetPlayAreaDimensions_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "GetPlayAreaDimensions");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlayAreaDimensions_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetPlayAreaPoints_method {
            static internal IntPtr GetPlayAreaPoints_ptr;
            static GetPlayAreaPoints_method() {
                GetPlayAreaPoints_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "GetPlayAreaPoints");
            }

            internal static unsafe IReadOnlyCollection<Vector> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlayAreaPoints_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<Vector>(b+0);
            }
        }
        internal struct GetTriggeredOuterBoundaryInfo_method {
            static internal IntPtr GetTriggeredOuterBoundaryInfo_ptr;
            static GetTriggeredOuterBoundaryInfo_method() {
                GetTriggeredOuterBoundaryInfo_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "GetTriggeredOuterBoundaryInfo");
            }

            internal static unsafe IReadOnlyCollection<BoundaryTestResult> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTriggeredOuterBoundaryInfo_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<BoundaryTestResult>(b+0);
            }
        }
        internal struct GetTriggeredPlayAreaInfo_method {
            static internal IntPtr GetTriggeredPlayAreaInfo_ptr;
            static GetTriggeredPlayAreaInfo_method() {
                GetTriggeredPlayAreaInfo_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "GetTriggeredPlayAreaInfo");
            }

            internal static unsafe BoundaryTestResult Invoke(IntPtr obj, ETrackedDeviceType DeviceType) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)DeviceType;
                Main.GetProcessEvent(obj, GetTriggeredPlayAreaInfo_ptr, new IntPtr(p)); ;
                return *((BoundaryTestResult*)(b+4));
            }
        }
        internal struct IsOuterBoundaryDisplayed_method {
            static internal IntPtr IsOuterBoundaryDisplayed_ptr;
            static IsOuterBoundaryDisplayed_method() {
                IsOuterBoundaryDisplayed_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "IsOuterBoundaryDisplayed");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsOuterBoundaryDisplayed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsOuterBoundaryTriggered_method {
            static internal IntPtr IsOuterBoundaryTriggered_ptr;
            static IsOuterBoundaryTriggered_method() {
                IsOuterBoundaryTriggered_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "IsOuterBoundaryTriggered");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsOuterBoundaryTriggered_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct RequestOuterBoundaryVisible_method {
            static internal IntPtr RequestOuterBoundaryVisible_ptr;
            static RequestOuterBoundaryVisible_method() {
                RequestOuterBoundaryVisible_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "RequestOuterBoundaryVisible");
            }

            internal static unsafe bool Invoke(IntPtr obj, bool BoundaryVisible) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = BoundaryVisible;
                Main.GetProcessEvent(obj, RequestOuterBoundaryVisible_ptr, new IntPtr(p)); ;
                return *((bool*)(b+1));
            }
        }
        internal struct ResetOuterBoundaryColor_method {
            static internal IntPtr ResetOuterBoundaryColor_ptr;
            static ResetOuterBoundaryColor_method() {
                ResetOuterBoundaryColor_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "ResetOuterBoundaryColor");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetOuterBoundaryColor_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetOuterBoundaryColor_method {
            static internal IntPtr SetOuterBoundaryColor_ptr;
            static SetOuterBoundaryColor_method() {
                SetOuterBoundaryColor_ptr = Main.GetMethodUFunction(OculusBoundaryComponent.StaticClass, "SetOuterBoundaryColor");
            }

            internal static unsafe bool Invoke(IntPtr obj, Color InBoundaryColor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Color*)(b+0)) = InBoundaryColor;
                Main.GetProcessEvent(obj, SetOuterBoundaryColor_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
    }
    internal unsafe struct OculusBoundaryComponent_events {
    }
}
