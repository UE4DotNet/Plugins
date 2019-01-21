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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=504 )]
    internal unsafe struct EnvQueryManager_fields {
        [FieldOffset(336)] public NativeArray InstanceCache;
        [FieldOffset(352)] public NativeArray LocalContexts;
        [FieldOffset(368)] public NativeArray GCShieldedWrappers;
        [FieldOffset(468)] public float MaxAllowedTestingTime;
        [FieldOffset(472)] public bool bTestQueriesUsingBreadth;
        [FieldOffset(476)] public int QueryCountWarningThreshold;
        [FieldOffset(480)] public double QueryCountWarningInterval;
    }
    internal unsafe struct EnvQueryManager_methods {
        internal struct RunEQSQuery_method {
            static internal IntPtr RunEQSQuery_ptr;
            static RunEQSQuery_method() {
                RunEQSQuery_ptr = Main.GetMethodUFunction(EnvQueryManager.StaticClass, "RunEQSQuery");
            }

            internal static unsafe EnvQueryInstanceBlueprintWrapper Invoke(UObject WorldContextObject, EnvQuery QueryTemplate, UObject Querier, byte RunMode, SubclassOf<EnvQueryInstanceBlueprintWrapper> WrapperClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = QueryTemplate;
                *((IntPtr*)(b+16)) = Querier;
                *(b+24) = RunMode;
                *((IntPtr*)(b+32)) = WrapperClass;
                Main.GetProcessEvent(EnvQueryManager.DefaultObject, RunEQSQuery_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+40));
            }
        }
    }
    internal unsafe struct EnvQueryManager_events {
    }
}
