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


namespace UE4.FunctionalTesting.Native {
    [StructLayout( LayoutKind.Explicit, Size=72 )]
    internal unsafe struct GroundTruthData_fields {
        [FieldOffset(56)] public bool bResetGroundTruth;
        [FieldOffset(64)]  public IntPtr  ObjectData;
    }
    internal unsafe struct GroundTruthData_methods {
        internal struct CanModify_method {
            static internal IntPtr CanModify_ptr;
            static CanModify_method() {
                CanModify_ptr = Main.GetMethodUFunction(GroundTruthData.StaticClass, "CanModify");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CanModify_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct LoadObject_method {
            static internal IntPtr LoadObject_ptr;
            static LoadObject_method() {
                LoadObject_ptr = Main.GetMethodUFunction(GroundTruthData.StaticClass, "LoadObject");
            }

            internal static unsafe UObject Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, LoadObject_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct SaveObject_method {
            static internal IntPtr SaveObject_ptr;
            static SaveObject_method() {
                SaveObject_ptr = Main.GetMethodUFunction(GroundTruthData.StaticClass, "SaveObject");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject GroundTruth) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = GroundTruth;
                Main.GetProcessEvent(obj, SaveObject_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct GroundTruthData_events {
    }
}
