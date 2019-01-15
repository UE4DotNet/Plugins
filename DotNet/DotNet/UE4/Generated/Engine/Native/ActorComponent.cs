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
    [StructLayout( LayoutKind.Explicit, Size=256 )]
    internal unsafe struct ActorComponent_fields {
        [FieldOffset(64)] public ActorComponentTickFunction PrimaryComponentTick;
        [FieldOffset(152)] public NativeArray ComponentTags;
        [FieldOffset(168)] public NativeArray AssetUserData;
        [FieldOffset(184)] public bool bReplicates;
        [FieldOffset(184)] public bool bNetAddressable;
        [FieldOffset(186)] public bool bAutoActivate;
        [FieldOffset(186)] public bool bIsActive;
        [FieldOffset(186)] public bool bEditableWhenInherited;
        [FieldOffset(186)] public bool bCanEverAffectNavigation;
        [FieldOffset(187)] public bool bIsEditorOnly;
        [FieldOffset(189)] byte CreationMethod; //TODO: enum EComponentCreationMethod CreationMethod
        [FieldOffset(192)] public NativeArray UCSModifiedProperties;
        [FieldOffset(208)] byte OnComponentActivated; //TODO: multicast delegate FActorComponentActivatedSignature OnComponentActivated
        [FieldOffset(224)] byte OnComponentDeactivated; //TODO: multicast delegate FActorComponentDeactivateSignature OnComponentDeactivated
    }
    internal unsafe struct ActorComponent_methods {
        internal struct Activate_method {
            static internal IntPtr Activate_ptr;
            static Activate_method() {
                Activate_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "Activate");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bReset) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bReset;
                Main.GetProcessEvent(obj, Activate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddTickPrerequisiteActor_method {
            static internal IntPtr AddTickPrerequisiteActor_ptr;
            static AddTickPrerequisiteActor_method() {
                AddTickPrerequisiteActor_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "AddTickPrerequisiteActor");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor PrerequisiteActor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PrerequisiteActor;
                Main.GetProcessEvent(obj, AddTickPrerequisiteActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddTickPrerequisiteComponent_method {
            static internal IntPtr AddTickPrerequisiteComponent_ptr;
            static AddTickPrerequisiteComponent_method() {
                AddTickPrerequisiteComponent_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "AddTickPrerequisiteComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, ActorComponent PrerequisiteComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PrerequisiteComponent;
                Main.GetProcessEvent(obj, AddTickPrerequisiteComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ComponentHasTag_method {
            static internal IntPtr ComponentHasTag_ptr;
            static ComponentHasTag_method() {
                ComponentHasTag_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "ComponentHasTag");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name Tag) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = Tag;
                Main.GetProcessEvent(obj, ComponentHasTag_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct Deactivate_method {
            static internal IntPtr Deactivate_ptr;
            static Deactivate_method() {
                Deactivate_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "Deactivate");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Deactivate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetComponentTickInterval_method {
            static internal IntPtr GetComponentTickInterval_ptr;
            static GetComponentTickInterval_method() {
                GetComponentTickInterval_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "GetComponentTickInterval");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetComponentTickInterval_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetOwner_method {
            static internal IntPtr GetOwner_ptr;
            static GetOwner_method() {
                GetOwner_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "GetOwner");
            }

            internal static unsafe Actor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwner_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct IsActive_method {
            static internal IntPtr IsActive_ptr;
            static IsActive_method() {
                IsActive_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "IsActive");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsActive_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsBeingDestroyed_method {
            static internal IntPtr IsBeingDestroyed_ptr;
            static IsBeingDestroyed_method() {
                IsBeingDestroyed_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "IsBeingDestroyed");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsBeingDestroyed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsComponentTickEnabled_method {
            static internal IntPtr IsComponentTickEnabled_ptr;
            static IsComponentTickEnabled_method() {
                IsComponentTickEnabled_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "IsComponentTickEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsComponentTickEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_DestroyComponent_method {
            static internal IntPtr K2_DestroyComponent_ptr;
            static K2_DestroyComponent_method() {
                K2_DestroyComponent_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "K2_DestroyComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject UObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                Main.GetProcessEvent(obj, K2_DestroyComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveTickPrerequisiteActor_method {
            static internal IntPtr RemoveTickPrerequisiteActor_ptr;
            static RemoveTickPrerequisiteActor_method() {
                RemoveTickPrerequisiteActor_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "RemoveTickPrerequisiteActor");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor PrerequisiteActor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PrerequisiteActor;
                Main.GetProcessEvent(obj, RemoveTickPrerequisiteActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveTickPrerequisiteComponent_method {
            static internal IntPtr RemoveTickPrerequisiteComponent_ptr;
            static RemoveTickPrerequisiteComponent_method() {
                RemoveTickPrerequisiteComponent_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "RemoveTickPrerequisiteComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, ActorComponent PrerequisiteComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PrerequisiteComponent;
                Main.GetProcessEvent(obj, RemoveTickPrerequisiteComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetActive_method {
            static internal IntPtr SetActive_ptr;
            static SetActive_method() {
                SetActive_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "SetActive");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewActive, bool bReset) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewActive;
                *((bool*)(b+1)) = bReset;
                Main.GetProcessEvent(obj, SetActive_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAutoActivate_method {
            static internal IntPtr SetAutoActivate_ptr;
            static SetAutoActivate_method() {
                SetAutoActivate_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "SetAutoActivate");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewAutoActivate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewAutoActivate;
                Main.GetProcessEvent(obj, SetAutoActivate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetComponentTickEnabled_method {
            static internal IntPtr SetComponentTickEnabled_ptr;
            static SetComponentTickEnabled_method() {
                SetComponentTickEnabled_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "SetComponentTickEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnabled;
                Main.GetProcessEvent(obj, SetComponentTickEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetComponentTickInterval_method {
            static internal IntPtr SetComponentTickInterval_ptr;
            static SetComponentTickInterval_method() {
                SetComponentTickInterval_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "SetComponentTickInterval");
            }

            internal static unsafe void Invoke(IntPtr obj, float TickInterval) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = TickInterval;
                Main.GetProcessEvent(obj, SetComponentTickInterval_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIsReplicated_method {
            static internal IntPtr SetIsReplicated_ptr;
            static SetIsReplicated_method() {
                SetIsReplicated_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "SetIsReplicated");
            }

            internal static unsafe void Invoke(IntPtr obj, bool ShouldReplicate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = ShouldReplicate;
                Main.GetProcessEvent(obj, SetIsReplicated_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTickableWhenPaused_method {
            static internal IntPtr SetTickableWhenPaused_ptr;
            static SetTickableWhenPaused_method() {
                SetTickableWhenPaused_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "SetTickableWhenPaused");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bTickableWhenPaused) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bTickableWhenPaused;
                Main.GetProcessEvent(obj, SetTickableWhenPaused_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTickGroup_method {
            static internal IntPtr SetTickGroup_ptr;
            static SetTickGroup_method() {
                SetTickGroup_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "SetTickGroup");
            }

            internal static unsafe void Invoke(IntPtr obj, byte NewTickGroup) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = NewTickGroup;
                Main.GetProcessEvent(obj, SetTickGroup_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ToggleActive_method {
            static internal IntPtr ToggleActive_ptr;
            static ToggleActive_method() {
                ToggleActive_ptr = Main.GetMethodUFunction(ActorComponent.StaticClass, "ToggleActive");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ToggleActive_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ActorComponent_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct ReceiveBeginPlay_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveBeginPlay_link;
            private static unsafe void ReceiveBeginPlay_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<ActorComponent>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveBeginPlay();
            }
            internal static void Setup() {
                ReceiveBeginPlay_link = new DelegateHolder<NativeFuncDelegate>(ReceiveBeginPlay_process_event);
                var uf = Main.GetUFunction("ReceiveBeginPlay");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveBeginPlay_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct ReceiveEndPlay_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveEndPlay_link;
            private static unsafe void ReceiveEndPlay_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<ActorComponent>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveEndPlay(*(b+0));
            }
            internal static void Setup() {
                ReceiveEndPlay_link = new DelegateHolder<NativeFuncDelegate>(ReceiveEndPlay_process_event);
                var uf = Main.GetUFunction("ReceiveEndPlay");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveEndPlay_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        internal unsafe struct ReceiveTick_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveTick_link;
            private static unsafe void ReceiveTick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<ActorComponent>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveTick(*(float*)(b+0));
            }
            internal static void Setup() {
                ReceiveTick_link = new DelegateHolder<NativeFuncDelegate>(ReceiveTick_process_event);
                var uf = Main.GetUFunction("ReceiveTick");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveTick_link.Delegate));
            }
        }
    }
}
