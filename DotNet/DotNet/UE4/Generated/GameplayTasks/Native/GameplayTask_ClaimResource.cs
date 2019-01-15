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
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct GameplayTask_ClaimResource_fields {
    }
    internal unsafe struct GameplayTask_ClaimResource_methods {
        internal struct ClaimResource_method {
            static internal IntPtr ClaimResource_ptr;
            static ClaimResource_method() {
                ClaimResource_ptr = Main.GetMethodUFunction(GameplayTask_ClaimResource.StaticClass, "ClaimResource");
            }

            internal static unsafe GameplayTask_ClaimResource Invoke(byte InTaskOwner /*TODO: interface TScriptInterface */, SubclassOf<GameplayTaskResource> ResourceClass, byte Priority, Name TaskInstanceName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface InTaskOwner
                *((IntPtr*)(b+16)) = ResourceClass;
                *(b+24) = Priority;
                *((Name*)(b+28)) = TaskInstanceName;
                Main.GetProcessEvent(GameplayTask_ClaimResource.DefaultObject, ClaimResource_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface InTaskOwner
                return *((IntPtr*)(b+40));
            }
        }
        internal struct ClaimResources_method {
            static internal IntPtr ClaimResources_ptr;
            static ClaimResources_method() {
                ClaimResources_ptr = Main.GetMethodUFunction(GameplayTask_ClaimResource.StaticClass, "ClaimResources");
            }

            internal static unsafe GameplayTask_ClaimResource Invoke(byte InTaskOwner /*TODO: interface TScriptInterface */, byte ResourceClasses /*TODO: array TArray */, byte Priority, Name TaskInstanceName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface InTaskOwner
                throw new NotImplementedException(); //TODO: array TArray ResourceClasses
                *(b+32) = Priority;
                *((Name*)(b+36)) = TaskInstanceName;
                Main.GetProcessEvent(GameplayTask_ClaimResource.DefaultObject, ClaimResources_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface InTaskOwner
                 //TODO: array TArray ResourceClasses
                return *((IntPtr*)(b+48));
            }
        }
    }
    internal unsafe struct GameplayTask_ClaimResource_events {
    }
}
