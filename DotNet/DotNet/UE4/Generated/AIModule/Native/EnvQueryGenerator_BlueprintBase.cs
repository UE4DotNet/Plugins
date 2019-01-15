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
    internal unsafe struct EnvQueryGenerator_BlueprintBase_fields {
        [FieldOffset(96)] byte GeneratorsActionDescription; //TODO: text FText GeneratorsActionDescription
        [FieldOffset(120)] public IntPtr Context;
        [FieldOffset(128)] public IntPtr GeneratedItemType;
    }
    internal unsafe struct EnvQueryGenerator_BlueprintBase_methods {
        internal struct AddGeneratedActor_method {
            static internal IntPtr AddGeneratedActor_ptr;
            static AddGeneratedActor_method() {
                AddGeneratedActor_ptr = Main.GetMethodUFunction(EnvQueryGenerator_BlueprintBase.StaticClass, "AddGeneratedActor");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor GeneratedActor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = GeneratedActor;
                Main.GetProcessEvent(obj, AddGeneratedActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddGeneratedVector_method {
            static internal IntPtr AddGeneratedVector_ptr;
            static AddGeneratedVector_method() {
                AddGeneratedVector_ptr = Main.GetMethodUFunction(EnvQueryGenerator_BlueprintBase.StaticClass, "AddGeneratedVector");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector GeneratedVector) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = GeneratedVector;
                Main.GetProcessEvent(obj, AddGeneratedVector_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetQuerier_method {
            static internal IntPtr GetQuerier_ptr;
            static GetQuerier_method() {
                GetQuerier_ptr = Main.GetMethodUFunction(EnvQueryGenerator_BlueprintBase.StaticClass, "GetQuerier");
            }

            internal static unsafe UObject Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetQuerier_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
    }
    internal unsafe struct EnvQueryGenerator_BlueprintBase_events {
        //TODO: event_native: event with array parameterDoItemGeneration
    }
}
