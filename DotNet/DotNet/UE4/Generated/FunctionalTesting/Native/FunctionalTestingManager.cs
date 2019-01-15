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
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct FunctionalTestingManager_fields {
        [FieldOffset(56)] public NativeArray TestsLeft;
        [FieldOffset(72)] public NativeArray AllTests;
        [FieldOffset(88)] byte OnSetupTests; //TODO: multicast delegate FFunctionalTestEventSignature OnSetupTests
        [FieldOffset(104)] byte OnTestsComplete; //TODO: multicast delegate FFunctionalTestEventSignature OnTestsComplete
        [FieldOffset(120)] byte OnTestsBegin; //TODO: multicast delegate FFunctionalTestEventSignature OnTestsBegin
    }
    internal unsafe struct FunctionalTestingManager_methods {
        internal struct RunAllFunctionalTests_method {
            static internal IntPtr RunAllFunctionalTests_ptr;
            static RunAllFunctionalTests_method() {
                RunAllFunctionalTests_ptr = Main.GetMethodUFunction(FunctionalTestingManager.StaticClass, "RunAllFunctionalTests");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, bool bNewLog, bool bRunLooped, string FailedTestsReproString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((bool*)(b+8)) = bNewLog;
                *((bool*)(b+9)) = bRunLooped;
                var FailedTestsReproString_handle = GCHandle.Alloc(FailedTestsReproString, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = FailedTestsReproString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = FailedTestsReproString.Length;
                *(int*)(b+IntPtr.Size+4+16) = FailedTestsReproString.Length;
                Main.GetProcessEvent(FunctionalTestingManager.DefaultObject, RunAllFunctionalTests_ptr, new IntPtr(p)); ;
                FailedTestsReproString_handle.Free();
                return *((bool*)(b+32));
            }
        }
    }
    internal unsafe struct FunctionalTestingManager_events {
    }
}
