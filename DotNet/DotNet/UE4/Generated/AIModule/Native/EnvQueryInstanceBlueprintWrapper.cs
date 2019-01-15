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

namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct EnvQueryInstanceBlueprintWrapper_fields {
        [FieldOffset(64)] public int QueryID;
        [FieldOffset(104)] public IntPtr ItemType;
        [FieldOffset(112)] public int OptionIndex;
        [FieldOffset(120)] byte OnQueryFinishedEvent; //TODO: multicast delegate FEQSQueryDoneSignature OnQueryFinishedEvent
    }
    internal unsafe struct EnvQueryInstanceBlueprintWrapper_methods {
        internal struct GetItemScore_method {
            static internal IntPtr GetItemScore_ptr;
            static GetItemScore_method() {
                GetItemScore_ptr = Main.GetMethodUFunction(EnvQueryInstanceBlueprintWrapper.StaticClass, "GetItemScore");
            }

            internal static unsafe float Invoke(IntPtr obj, int ItemIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ItemIndex;
                Main.GetProcessEvent(obj, GetItemScore_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct GetResultsAsActors_method {
            static internal IntPtr GetResultsAsActors_ptr;
            static GetResultsAsActors_method() {
                GetResultsAsActors_ptr = Main.GetMethodUFunction(EnvQueryInstanceBlueprintWrapper.StaticClass, "GetResultsAsActors");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetResultsAsActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUObjectCollection<Actor>(b+0);
            }
        }
        internal struct GetResultsAsLocations_method {
            static internal IntPtr GetResultsAsLocations_ptr;
            static GetResultsAsLocations_method() {
                GetResultsAsLocations_ptr = Main.GetMethodUFunction(EnvQueryInstanceBlueprintWrapper.StaticClass, "GetResultsAsLocations");
            }

            internal static unsafe IReadOnlyCollection<Vector> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetResultsAsLocations_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<Vector>(b+0);
            }
        }
        internal struct SetNamedParam_method {
            static internal IntPtr SetNamedParam_ptr;
            static SetNamedParam_method() {
                SetNamedParam_ptr = Main.GetMethodUFunction(EnvQueryInstanceBlueprintWrapper.StaticClass, "SetNamedParam");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParamName, float Value) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParamName;
                *((float*)(b+12)) = Value;
                Main.GetProcessEvent(obj, SetNamedParam_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct EnvQueryInstanceBlueprintWrapper_events {
    }
}
