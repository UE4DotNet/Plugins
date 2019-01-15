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
    [StructLayout( LayoutKind.Explicit, Size=784 )]
    internal unsafe struct SceneCaptureComponent_fields {
        [FieldOffset(624)] byte PrimitiveRenderMode; //TODO: enum ESceneCapturePrimitiveRenderMode PrimitiveRenderMode
        [FieldOffset(632)] public NativeArray HiddenComponents;
        [FieldOffset(648)] public NativeArray HiddenActors;
        [FieldOffset(664)] public NativeArray ShowOnlyComponents;
        [FieldOffset(680)] public NativeArray ShowOnlyActors;
        [FieldOffset(696)] public bool bCaptureEveryFrame;
        [FieldOffset(697)] public bool bCaptureOnMovement;
        [FieldOffset(698)] public bool bAlwaysPersistRenderingState;
        [FieldOffset(700)] public float LODDistanceFactor;
        [FieldOffset(704)] public float MaxViewDistanceOverride;
        [FieldOffset(708)] public int CaptureSortPriority;
        [FieldOffset(712)] public NativeArray ShowFlagSettings;
        [FieldOffset(752)] byte ProfilingEventName; //TODO: string FString ProfilingEventName
    }
    internal unsafe struct SceneCaptureComponent_methods {
        internal struct ClearHiddenComponents_method {
            static internal IntPtr ClearHiddenComponents_ptr;
            static ClearHiddenComponents_method() {
                ClearHiddenComponents_ptr = Main.GetMethodUFunction(SceneCaptureComponent.StaticClass, "ClearHiddenComponents");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearHiddenComponents_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearShowOnlyComponents_method {
            static internal IntPtr ClearShowOnlyComponents_ptr;
            static ClearShowOnlyComponents_method() {
                ClearShowOnlyComponents_ptr = Main.GetMethodUFunction(SceneCaptureComponent.StaticClass, "ClearShowOnlyComponents");
            }

            internal static unsafe void Invoke(IntPtr obj, PrimitiveComponent InComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InComponent;
                Main.GetProcessEvent(obj, ClearShowOnlyComponents_ptr, new IntPtr(p)); ;
            }
        }
        internal struct HideActorComponents_method {
            static internal IntPtr HideActorComponents_ptr;
            static HideActorComponents_method() {
                HideActorComponents_ptr = Main.GetMethodUFunction(SceneCaptureComponent.StaticClass, "HideActorComponents");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor InActor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InActor;
                Main.GetProcessEvent(obj, HideActorComponents_ptr, new IntPtr(p)); ;
            }
        }
        internal struct HideComponent_method {
            static internal IntPtr HideComponent_ptr;
            static HideComponent_method() {
                HideComponent_ptr = Main.GetMethodUFunction(SceneCaptureComponent.StaticClass, "HideComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, PrimitiveComponent InComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InComponent;
                Main.GetProcessEvent(obj, HideComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveShowOnlyActorComponents_method {
            static internal IntPtr RemoveShowOnlyActorComponents_ptr;
            static RemoveShowOnlyActorComponents_method() {
                RemoveShowOnlyActorComponents_ptr = Main.GetMethodUFunction(SceneCaptureComponent.StaticClass, "RemoveShowOnlyActorComponents");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor InActor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InActor;
                Main.GetProcessEvent(obj, RemoveShowOnlyActorComponents_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveShowOnlyComponent_method {
            static internal IntPtr RemoveShowOnlyComponent_ptr;
            static RemoveShowOnlyComponent_method() {
                RemoveShowOnlyComponent_ptr = Main.GetMethodUFunction(SceneCaptureComponent.StaticClass, "RemoveShowOnlyComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, PrimitiveComponent InComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InComponent;
                Main.GetProcessEvent(obj, RemoveShowOnlyComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCaptureSortPriority_method {
            static internal IntPtr SetCaptureSortPriority_ptr;
            static SetCaptureSortPriority_method() {
                SetCaptureSortPriority_ptr = Main.GetMethodUFunction(SceneCaptureComponent.StaticClass, "SetCaptureSortPriority");
            }

            internal static unsafe void Invoke(IntPtr obj, int NewCaptureSortPriority) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NewCaptureSortPriority;
                Main.GetProcessEvent(obj, SetCaptureSortPriority_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ShowOnlyActorComponents_method {
            static internal IntPtr ShowOnlyActorComponents_ptr;
            static ShowOnlyActorComponents_method() {
                ShowOnlyActorComponents_ptr = Main.GetMethodUFunction(SceneCaptureComponent.StaticClass, "ShowOnlyActorComponents");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor InActor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InActor;
                Main.GetProcessEvent(obj, ShowOnlyActorComponents_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ShowOnlyComponent_method {
            static internal IntPtr ShowOnlyComponent_ptr;
            static ShowOnlyComponent_method() {
                ShowOnlyComponent_ptr = Main.GetMethodUFunction(SceneCaptureComponent.StaticClass, "ShowOnlyComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, PrimitiveComponent InComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InComponent;
                Main.GetProcessEvent(obj, ShowOnlyComponent_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SceneCaptureComponent_events {
    }
}
