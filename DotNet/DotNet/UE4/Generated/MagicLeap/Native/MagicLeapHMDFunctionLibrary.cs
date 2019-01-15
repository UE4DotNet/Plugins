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

using UE4.Engine;

namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MagicLeapHMDFunctionLibrary_fields {
    }
    internal unsafe struct MagicLeapHMDFunctionLibrary_methods {
        internal struct GetHeadTrackingState_method {
            static internal IntPtr GetHeadTrackingState_ptr;
            static GetHeadTrackingState_method() {
                GetHeadTrackingState_ptr = Main.GetMethodUFunction(MagicLeapHMDFunctionLibrary.StaticClass, "GetHeadTrackingState");
            }

            internal static unsafe (HeadTrackingState, bool) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapHMDFunctionLibrary.DefaultObject, GetHeadTrackingState_ptr, new IntPtr(p)); ;
                return (*((HeadTrackingState*)(b+0)),*((bool*)(b+8)));
            }
        }
        internal struct GetMLSDKVersion_method {
            static internal IntPtr GetMLSDKVersion_ptr;
            static GetMLSDKVersion_method() {
                GetMLSDKVersion_ptr = Main.GetMethodUFunction(MagicLeapHMDFunctionLibrary.StaticClass, "GetMLSDKVersion");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapHMDFunctionLibrary.DefaultObject, GetMLSDKVersion_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetMLSDKVersionMajor_method {
            static internal IntPtr GetMLSDKVersionMajor_ptr;
            static GetMLSDKVersionMajor_method() {
                GetMLSDKVersionMajor_ptr = Main.GetMethodUFunction(MagicLeapHMDFunctionLibrary.StaticClass, "GetMLSDKVersionMajor");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapHMDFunctionLibrary.DefaultObject, GetMLSDKVersionMajor_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetMLSDKVersionMinor_method {
            static internal IntPtr GetMLSDKVersionMinor_ptr;
            static GetMLSDKVersionMinor_method() {
                GetMLSDKVersionMinor_ptr = Main.GetMethodUFunction(MagicLeapHMDFunctionLibrary.StaticClass, "GetMLSDKVersionMinor");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapHMDFunctionLibrary.DefaultObject, GetMLSDKVersionMinor_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetMLSDKVersionRevision_method {
            static internal IntPtr GetMLSDKVersionRevision_ptr;
            static GetMLSDKVersionRevision_method() {
                GetMLSDKVersionRevision_ptr = Main.GetMethodUFunction(MagicLeapHMDFunctionLibrary.StaticClass, "GetMLSDKVersionRevision");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapHMDFunctionLibrary.DefaultObject, GetMLSDKVersionRevision_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct IsRunningOnMagicLeapHMD_method {
            static internal IntPtr IsRunningOnMagicLeapHMD_ptr;
            static IsRunningOnMagicLeapHMD_method() {
                IsRunningOnMagicLeapHMD_ptr = Main.GetMethodUFunction(MagicLeapHMDFunctionLibrary.StaticClass, "IsRunningOnMagicLeapHMD");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapHMDFunctionLibrary.DefaultObject, IsRunningOnMagicLeapHMD_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetBaseOrientation_method {
            static internal IntPtr SetBaseOrientation_ptr;
            static SetBaseOrientation_method() {
                SetBaseOrientation_ptr = Main.GetMethodUFunction(MagicLeapHMDFunctionLibrary.StaticClass, "SetBaseOrientation");
            }

            internal static unsafe void Invoke(Quat InBaseOrientation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Quat*)(b+0)) = InBaseOrientation;
                Main.GetProcessEvent(MagicLeapHMDFunctionLibrary.DefaultObject, SetBaseOrientation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBasePosition_method {
            static internal IntPtr SetBasePosition_ptr;
            static SetBasePosition_method() {
                SetBasePosition_ptr = Main.GetMethodUFunction(MagicLeapHMDFunctionLibrary.StaticClass, "SetBasePosition");
            }

            internal static unsafe void Invoke(Vector InBasePosition) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InBasePosition;
                Main.GetProcessEvent(MagicLeapHMDFunctionLibrary.DefaultObject, SetBasePosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBaseRotation_method {
            static internal IntPtr SetBaseRotation_ptr;
            static SetBaseRotation_method() {
                SetBaseRotation_ptr = Main.GetMethodUFunction(MagicLeapHMDFunctionLibrary.StaticClass, "SetBaseRotation");
            }

            internal static unsafe void Invoke(Rotator InBaseRotation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = InBaseRotation;
                Main.GetProcessEvent(MagicLeapHMDFunctionLibrary.DefaultObject, SetBaseRotation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFocusActor_method {
            static internal IntPtr SetFocusActor_ptr;
            static SetFocusActor_method() {
                SetFocusActor_ptr = Main.GetMethodUFunction(MagicLeapHMDFunctionLibrary.StaticClass, "SetFocusActor");
            }

            internal static unsafe void Invoke(Actor InFocusActor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InFocusActor;
                Main.GetProcessEvent(MagicLeapHMDFunctionLibrary.DefaultObject, SetFocusActor_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MagicLeapHMDFunctionLibrary_events {
    }
}
