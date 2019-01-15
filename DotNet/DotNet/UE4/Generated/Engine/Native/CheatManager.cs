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
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct CheatManager_fields {
        [FieldOffset(56)]  public IntPtr  DebugCameraControllerRef;
        [FieldOffset(64)] public IntPtr DebugCameraControllerClass;
    }
    internal unsafe struct CheatManager_methods {
        internal struct ChangeSize_method {
            static internal IntPtr ChangeSize_ptr;
            static ChangeSize_method() {
                ChangeSize_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "ChangeSize");
            }

            internal static unsafe void Invoke(IntPtr obj, float F) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = F;
                Main.GetProcessEvent(obj, ChangeSize_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DamageTarget_method {
            static internal IntPtr DamageTarget_ptr;
            static DamageTarget_method() {
                DamageTarget_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "DamageTarget");
            }

            internal static unsafe void Invoke(IntPtr obj, float DamageAmount) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = DamageAmount;
                Main.GetProcessEvent(obj, DamageTarget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DestroyTarget_method {
            static internal IntPtr DestroyTarget_ptr;
            static DestroyTarget_method() {
                DestroyTarget_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "DestroyTarget");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, DestroyTarget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DisableDebugCamera_method {
            static internal IntPtr DisableDebugCamera_ptr;
            static DisableDebugCamera_method() {
                DisableDebugCamera_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "DisableDebugCamera");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, DisableDebugCamera_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableDebugCamera_method {
            static internal IntPtr EnableDebugCamera_ptr;
            static EnableDebugCamera_method() {
                EnableDebugCamera_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "EnableDebugCamera");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, EnableDebugCamera_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Fly_method {
            static internal IntPtr Fly_ptr;
            static Fly_method() {
                Fly_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "Fly");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Fly_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FreezeFrame_method {
            static internal IntPtr FreezeFrame_ptr;
            static FreezeFrame_method() {
                FreezeFrame_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "FreezeFrame");
            }

            internal static unsafe void Invoke(IntPtr obj, float Delay) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Delay;
                Main.GetProcessEvent(obj, FreezeFrame_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Ghost_method {
            static internal IntPtr Ghost_ptr;
            static Ghost_method() {
                Ghost_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "Ghost");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Ghost_ptr, new IntPtr(p)); ;
            }
        }
        internal struct God_method {
            static internal IntPtr God_ptr;
            static God_method() {
                God_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "God");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, God_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayersOnly_method {
            static internal IntPtr PlayersOnly_ptr;
            static PlayersOnly_method() {
                PlayersOnly_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "PlayersOnly");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, PlayersOnly_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Slomo_method {
            static internal IntPtr Slomo_ptr;
            static Slomo_method() {
                Slomo_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "Slomo");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewTimeDilation) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewTimeDilation;
                Main.GetProcessEvent(obj, Slomo_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Teleport_method {
            static internal IntPtr Teleport_ptr;
            static Teleport_method() {
                Teleport_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "Teleport");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Teleport_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Walk_method {
            static internal IntPtr Walk_ptr;
            static Walk_method() {
                Walk_ptr = Main.GetMethodUFunction(CheatManager.StaticClass, "Walk");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Walk_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct CheatManager_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct ReceiveEndPlay_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveEndPlay_link;
            private static unsafe void ReceiveEndPlay_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<CheatManager>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveEndPlay();
            }
            internal static void Setup() {
                ReceiveEndPlay_link = new DelegateHolder<NativeFuncDelegate>(ReceiveEndPlay_process_event);
                var uf = Main.GetUFunction("ReceiveEndPlay");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveEndPlay_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct ReceiveInitCheatManager_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveInitCheatManager_link;
            private static unsafe void ReceiveInitCheatManager_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<CheatManager>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveInitCheatManager();
            }
            internal static void Setup() {
                ReceiveInitCheatManager_link = new DelegateHolder<NativeFuncDelegate>(ReceiveInitCheatManager_process_event);
                var uf = Main.GetUFunction("ReceiveInitCheatManager");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveInitCheatManager_link.Delegate));
            }
        }
    }
}
