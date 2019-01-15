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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1016 )]
    internal unsafe struct LevelScriptActor_fields {
        [FieldOffset(1008)] public bool bInputEnabled;
    }
    internal unsafe struct LevelScriptActor_methods {
        internal struct RemoteEvent_method {
            static internal IntPtr RemoteEvent_ptr;
            static RemoteEvent_method() {
                RemoteEvent_ptr = Main.GetMethodUFunction(LevelScriptActor.StaticClass, "RemoteEvent");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name EventName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = EventName;
                Main.GetProcessEvent(obj, RemoteEvent_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct SetCinematicMode_method {
            static internal IntPtr SetCinematicMode_ptr;
            static SetCinematicMode_method() {
                SetCinematicMode_ptr = Main.GetMethodUFunction(LevelScriptActor.StaticClass, "SetCinematicMode");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bCinematicMode, bool bHidePlayer, bool bAffectsHUD, bool bAffectsMovement, bool bAffectsTurning) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bCinematicMode;
                *((bool*)(b+1)) = bHidePlayer;
                *((bool*)(b+2)) = bAffectsHUD;
                *((bool*)(b+3)) = bAffectsMovement;
                *((bool*)(b+4)) = bAffectsTurning;
                Main.GetProcessEvent(obj, SetCinematicMode_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct LevelScriptActor_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct LevelReset_event {
            private static DelegateHolder<NativeFuncDelegate> LevelReset_link;
            private static unsafe void LevelReset_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<LevelScriptActor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_LevelReset();
            }
            internal static void Setup() {
                LevelReset_link = new DelegateHolder<NativeFuncDelegate>(LevelReset_process_event);
                var uf = Main.GetUFunction("LevelReset");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(LevelReset_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct WorldOriginLocationChanged_event {
            private static DelegateHolder<NativeFuncDelegate> WorldOriginLocationChanged_link;
            private static unsafe void WorldOriginLocationChanged_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<LevelScriptActor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_WorldOriginLocationChanged(*(IntVector*)(b+0), *(IntVector*)(b+12));
            }
            internal static void Setup() {
                WorldOriginLocationChanged_link = new DelegateHolder<NativeFuncDelegate>(WorldOriginLocationChanged_process_event);
                var uf = Main.GetUFunction("WorldOriginLocationChanged");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(WorldOriginLocationChanged_link.Delegate));
            }
        }
    }
}
