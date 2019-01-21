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


namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MagicLeapARPinFunctionLibrary_fields {
    }
    internal unsafe struct MagicLeapARPinFunctionLibrary_methods {
        internal struct GetARPinPositionAndOrientation_method {
            static internal IntPtr GetARPinPositionAndOrientation_ptr;
            static GetARPinPositionAndOrientation_method() {
                GetARPinPositionAndOrientation_ptr = Main.GetMethodUFunction(MagicLeapARPinFunctionLibrary.StaticClass, "GetARPinPositionAndOrientation");
            }

            internal static unsafe (Vector, Rotator, bool, bool) Invoke(FGuid PinID) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FGuid*)(b+0)) = PinID;
                Main.GetProcessEvent(MagicLeapARPinFunctionLibrary.DefaultObject, GetARPinPositionAndOrientation_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+16)),*((Rotator*)(b+28)),*((bool*)(b+40)),*((bool*)(b+41)));
            }
        }
        internal struct GetAvailableARPins_method {
            static internal IntPtr GetAvailableARPins_ptr;
            static GetAvailableARPins_method() {
                GetAvailableARPins_ptr = Main.GetMethodUFunction(MagicLeapARPinFunctionLibrary.StaticClass, "GetAvailableARPins");
            }

            internal static unsafe (IReadOnlyCollection<FGuid>, EPassableWorldError) Invoke(int NumRequested) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NumRequested;
                Main.GetProcessEvent(MagicLeapARPinFunctionLibrary.DefaultObject, GetAvailableARPins_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Pins
                return (UObject.ToUnmangedCollection<FGuid>(b+8),*((EPassableWorldError*)(b+24)));
            }
        }
        internal struct GetClosestARPin_method {
            static internal IntPtr GetClosestARPin_ptr;
            static GetClosestARPin_method() {
                GetClosestARPin_ptr = Main.GetMethodUFunction(MagicLeapARPinFunctionLibrary.StaticClass, "GetClosestARPin");
            }

            internal static unsafe (FGuid, EPassableWorldError) Invoke(Vector SearchPoint) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = SearchPoint;
                Main.GetProcessEvent(MagicLeapARPinFunctionLibrary.DefaultObject, GetClosestARPin_ptr, new IntPtr(p)); ;
                return (*((FGuid*)(b+12)),*((EPassableWorldError*)(b+28)));
            }
        }
        internal struct GetNumAvailableARPins_method {
            static internal IntPtr GetNumAvailableARPins_ptr;
            static GetNumAvailableARPins_method() {
                GetNumAvailableARPins_ptr = Main.GetMethodUFunction(MagicLeapARPinFunctionLibrary.StaticClass, "GetNumAvailableARPins");
            }

            internal static unsafe (int, EPassableWorldError) Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapARPinFunctionLibrary.DefaultObject, GetNumAvailableARPins_ptr, new IntPtr(p)); ;
                return (*((int*)(b+0)),*((EPassableWorldError*)(b+4)));
            }
        }
    }
    internal unsafe struct MagicLeapARPinFunctionLibrary_events {
    }
}
