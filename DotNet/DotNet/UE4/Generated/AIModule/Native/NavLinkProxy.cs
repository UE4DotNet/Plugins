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
    [StructLayout( LayoutKind.Explicit, Size=1104 )]
    internal unsafe struct NavLinkProxy_fields {
        [FieldOffset(1024)] public NativeArray PointLinks;
        [FieldOffset(1040)] public NativeArray SegmentLinks;
        [FieldOffset(1056)]  public IntPtr  SmartLinkComp;
        [FieldOffset(1064)] public bool bSmartLinkIsRelevant;
        [FieldOffset(1072)]  public IntPtr  EdRenderComp;
        [FieldOffset(1080)]  public IntPtr  SpriteComponent;
        [FieldOffset(1088)] byte OnSmartLinkReached; //TODO: multicast delegate FSmartLinkReachedSignature OnSmartLinkReached
    }
    internal unsafe struct NavLinkProxy_methods {
        internal struct HasMovingAgents_method {
            static internal IntPtr HasMovingAgents_ptr;
            static HasMovingAgents_method() {
                HasMovingAgents_ptr = Main.GetMethodUFunction(NavLinkProxy.StaticClass, "HasMovingAgents");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasMovingAgents_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsSmartLinkEnabled_method {
            static internal IntPtr IsSmartLinkEnabled_ptr;
            static IsSmartLinkEnabled_method() {
                IsSmartLinkEnabled_ptr = Main.GetMethodUFunction(NavLinkProxy.StaticClass, "IsSmartLinkEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsSmartLinkEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct ResumePathFollowing_method {
            static internal IntPtr ResumePathFollowing_ptr;
            static ResumePathFollowing_method() {
                ResumePathFollowing_ptr = Main.GetMethodUFunction(NavLinkProxy.StaticClass, "ResumePathFollowing");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor Agent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Agent;
                Main.GetProcessEvent(obj, ResumePathFollowing_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSmartLinkEnabled_method {
            static internal IntPtr SetSmartLinkEnabled_ptr;
            static SetSmartLinkEnabled_method() {
                SetSmartLinkEnabled_ptr = Main.GetMethodUFunction(NavLinkProxy.StaticClass, "SetSmartLinkEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnabled;
                Main.GetProcessEvent(obj, SetSmartLinkEnabled_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct NavLinkProxy_events {
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct ReceiveSmartLinkReached_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveSmartLinkReached_link;
            private static unsafe void ReceiveSmartLinkReached_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<NavLinkProxy>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveSmartLinkReached(UObject.Make<Actor>(*(IntPtr*)(b+0)), *(Vector*)(b+8));
            }
            internal static void Setup() {
                ReceiveSmartLinkReached_link = new DelegateHolder<NativeFuncDelegate>(ReceiveSmartLinkReached_process_event);
                var uf = Main.GetUFunction("ReceiveSmartLinkReached");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveSmartLinkReached_link.Delegate));
            }
        }
    }
}
