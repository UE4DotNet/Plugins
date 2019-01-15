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


namespace UE4.LocationServicesBPLibrary.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct LocationServices_fields {
    }
    internal unsafe struct LocationServices_methods {
        internal struct AreLocationServicesEnabled_method {
            static internal IntPtr AreLocationServicesEnabled_ptr;
            static AreLocationServicesEnabled_method() {
                AreLocationServicesEnabled_ptr = Main.GetMethodUFunction(LocationServices.StaticClass, "AreLocationServicesEnabled");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(LocationServices.DefaultObject, AreLocationServicesEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetLastKnownLocation_method {
            static internal IntPtr GetLastKnownLocation_ptr;
            static GetLastKnownLocation_method() {
                GetLastKnownLocation_ptr = Main.GetMethodUFunction(LocationServices.StaticClass, "GetLastKnownLocation");
            }

            internal static unsafe LocationServicesData Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(LocationServices.DefaultObject, GetLastKnownLocation_ptr, new IntPtr(p)); ;
                return *((LocationServicesData*)(b+0));
            }
        }
        internal struct GetLocationServicesImpl_method {
            static internal IntPtr GetLocationServicesImpl_ptr;
            static GetLocationServicesImpl_method() {
                GetLocationServicesImpl_ptr = Main.GetMethodUFunction(LocationServices.StaticClass, "GetLocationServicesImpl");
            }

            internal static unsafe LocationServicesImpl Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(LocationServices.DefaultObject, GetLocationServicesImpl_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct InitLocationServices_method {
            static internal IntPtr InitLocationServices_ptr;
            static InitLocationServices_method() {
                InitLocationServices_ptr = Main.GetMethodUFunction(LocationServices.StaticClass, "InitLocationServices");
            }

            internal static unsafe bool Invoke(ELocationAccuracy Accuracy, float UpdateFrequency, float MinDistanceFilter) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Accuracy;
                *((float*)(b+4)) = UpdateFrequency;
                *((float*)(b+8)) = MinDistanceFilter;
                Main.GetProcessEvent(LocationServices.DefaultObject, InitLocationServices_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct IsLocationAccuracyAvailable_method {
            static internal IntPtr IsLocationAccuracyAvailable_ptr;
            static IsLocationAccuracyAvailable_method() {
                IsLocationAccuracyAvailable_ptr = Main.GetMethodUFunction(LocationServices.StaticClass, "IsLocationAccuracyAvailable");
            }

            internal static unsafe bool Invoke(ELocationAccuracy Accuracy) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Accuracy;
                Main.GetProcessEvent(LocationServices.DefaultObject, IsLocationAccuracyAvailable_ptr, new IntPtr(p)); ;
                return *((bool*)(b+1));
            }
        }
        internal struct StartLocationServices_method {
            static internal IntPtr StartLocationServices_ptr;
            static StartLocationServices_method() {
                StartLocationServices_ptr = Main.GetMethodUFunction(LocationServices.StaticClass, "StartLocationServices");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(LocationServices.DefaultObject, StartLocationServices_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct StopLocationServices_method {
            static internal IntPtr StopLocationServices_ptr;
            static StopLocationServices_method() {
                StopLocationServices_ptr = Main.GetMethodUFunction(LocationServices.StaticClass, "StopLocationServices");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(LocationServices.DefaultObject, StopLocationServices_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct LocationServices_events {
    }
}
