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
    [StructLayout( LayoutKind.Explicit, Size=464 )]
    internal unsafe struct AIPerceptionComponent_fields {
        [FieldOffset(256)] public NativeArray SensesConfig;
        [FieldOffset(272)] public IntPtr DominantSense;
        [FieldOffset(296)]  public IntPtr  AIOwner;
        [FieldOffset(432)] byte OnPerceptionUpdated; //TODO: multicast delegate FPerceptionUpdatedDelegate OnPerceptionUpdated
        [FieldOffset(448)] byte OnTargetPerceptionUpdated; //TODO: multicast delegate FActorPerceptionUpdatedDelegate OnTargetPerceptionUpdated
    }
    internal unsafe struct AIPerceptionComponent_methods {
        internal struct GetActorsPerception_method {
            static internal IntPtr GetActorsPerception_ptr;
            static GetActorsPerception_method() {
                GetActorsPerception_ptr = Main.GetMethodUFunction(AIPerceptionComponent.StaticClass, "GetActorsPerception");
            }

            internal static unsafe (ActorPerceptionBlueprintInfo, bool) Invoke(IntPtr obj, Actor Actor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Actor;
                Main.GetProcessEvent(obj, GetActorsPerception_ptr, new IntPtr(p)); ;
                return (*((ActorPerceptionBlueprintInfo*)(b+8)),*((bool*)(b+40)));
            }
        }
        internal struct GetCurrentlyPerceivedActors_method {
            static internal IntPtr GetCurrentlyPerceivedActors_ptr;
            static GetCurrentlyPerceivedActors_method() {
                GetCurrentlyPerceivedActors_ptr = Main.GetMethodUFunction(AIPerceptionComponent.StaticClass, "GetCurrentlyPerceivedActors");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(IntPtr obj, SubclassOf<AISense> SenseToUse) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SenseToUse;
                Main.GetProcessEvent(obj, GetCurrentlyPerceivedActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutActors
                return UObject.ToUObjectCollection<Actor>(b+8);
            }
        }
        internal struct GetKnownPerceivedActors_method {
            static internal IntPtr GetKnownPerceivedActors_ptr;
            static GetKnownPerceivedActors_method() {
                GetKnownPerceivedActors_ptr = Main.GetMethodUFunction(AIPerceptionComponent.StaticClass, "GetKnownPerceivedActors");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(IntPtr obj, SubclassOf<AISense> SenseToUse) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SenseToUse;
                Main.GetProcessEvent(obj, GetKnownPerceivedActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutActors
                return UObject.ToUObjectCollection<Actor>(b+8);
            }
        }
        internal struct GetPerceivedActors_method {
            static internal IntPtr GetPerceivedActors_ptr;
            static GetPerceivedActors_method() {
                GetPerceivedActors_ptr = Main.GetMethodUFunction(AIPerceptionComponent.StaticClass, "GetPerceivedActors");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(IntPtr obj, SubclassOf<AISense> SenseToUse) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SenseToUse;
                Main.GetProcessEvent(obj, GetPerceivedActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutActors
                return UObject.ToUObjectCollection<Actor>(b+8);
            }
        }
        internal struct GetPerceivedHostileActors_method {
            static internal IntPtr GetPerceivedHostileActors_ptr;
            static GetPerceivedHostileActors_method() {
                GetPerceivedHostileActors_ptr = Main.GetMethodUFunction(AIPerceptionComponent.StaticClass, "GetPerceivedHostileActors");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPerceivedHostileActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutActors
                return UObject.ToUObjectCollection<Actor>(b+0);
            }
        }
        internal struct RequestStimuliListenerUpdate_method {
            static internal IntPtr RequestStimuliListenerUpdate_ptr;
            static RequestStimuliListenerUpdate_method() {
                RequestStimuliListenerUpdate_ptr = Main.GetMethodUFunction(AIPerceptionComponent.StaticClass, "RequestStimuliListenerUpdate");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RequestStimuliListenerUpdate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSenseEnabled_method {
            static internal IntPtr SetSenseEnabled_ptr;
            static SetSenseEnabled_method() {
                SetSenseEnabled_ptr = Main.GetMethodUFunction(AIPerceptionComponent.StaticClass, "SetSenseEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<AISense> SenseClass, bool bEnable) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SenseClass;
                *((bool*)(b+8)) = bEnable;
                Main.GetProcessEvent(obj, SetSenseEnabled_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AIPerceptionComponent_events {
    }
}
