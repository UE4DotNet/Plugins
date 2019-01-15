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


namespace UE4.GameplayTasks.Native {
    [StructLayout( LayoutKind.Explicit, Size=384 )]
    internal unsafe struct GameplayTasksComponent_fields {
        [FieldOffset(264)] public bool bIsNetDirty;
        [FieldOffset(272)] public NativeArray SimulatedTasks;
        [FieldOffset(288)] public NativeArray TaskPriorityQueue;
        [FieldOffset(320)] public NativeArray TickingTasks;
        [FieldOffset(336)] public NativeArray KnownTasks;
        [FieldOffset(360)] byte OnClaimedResourcesChange; //TODO: multicast delegate FOnClaimedResourcesChangeSignature OnClaimedResourcesChange
    }
    internal unsafe struct GameplayTasksComponent_methods {
        internal struct K2_RunGameplayTask_method {
            static internal IntPtr K2_RunGameplayTask_ptr;
            static K2_RunGameplayTask_method() {
                K2_RunGameplayTask_ptr = Main.GetMethodUFunction(GameplayTasksComponent.StaticClass, "K2_RunGameplayTask");
            }

            internal static unsafe EGameplayTaskRunResult Invoke(byte TaskOwner /*TODO: interface TScriptInterface */, GameplayTask Task, byte Priority, byte AdditionalRequiredResources /*TODO: array TArray */, byte AdditionalClaimedResources /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface TaskOwner
                *((IntPtr*)(b+16)) = Task;
                *(b+24) = Priority;
                throw new NotImplementedException(); //TODO: array TArray AdditionalRequiredResources
                throw new NotImplementedException(); //TODO: array TArray AdditionalClaimedResources
                Main.GetProcessEvent(GameplayTasksComponent.DefaultObject, K2_RunGameplayTask_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface TaskOwner
                 //TODO: array TArray AdditionalRequiredResources
                 //TODO: array TArray AdditionalClaimedResources
                return *((EGameplayTaskRunResult*)(b+64));
            }
        }
    }
    internal unsafe struct GameplayTasksComponent_events {
    }
}
