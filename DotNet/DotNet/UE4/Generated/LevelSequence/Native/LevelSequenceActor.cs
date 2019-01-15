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

using UE4.MovieScene;
using UE4.Engine;

namespace UE4.LevelSequence.Native {
    [StructLayout( LayoutKind.Explicit, Size=1184 )]
    internal unsafe struct LevelSequenceActor_fields {
        [FieldOffset(1016)] public bool bAutoPlay;
        [FieldOffset(1024)] public MovieSceneSequencePlaybackSettings PlaybackSettings;
        [FieldOffset(1088)]  public IntPtr  SequencePlayer;
        [FieldOffset(1096)] public SoftObjectPath LevelSequence;
        [FieldOffset(1128)] public NativeArray AdditionalEventReceivers;
        [FieldOffset(1144)]  public IntPtr  BurnInOptions;
        [FieldOffset(1152)]  public IntPtr  BindingOverrides;
        [FieldOffset(1160)] public bool bOverrideInstanceData;
        [FieldOffset(1168)]  public IntPtr  DefaultInstanceData;
        [FieldOffset(1176)]  public IntPtr  BurnInInstance;
    }
    internal unsafe struct LevelSequenceActor_methods {
        internal struct AddBinding_method {
            static internal IntPtr AddBinding_ptr;
            static AddBinding_method() {
                AddBinding_ptr = Main.GetMethodUFunction(LevelSequenceActor.StaticClass, "AddBinding");
            }

            internal static unsafe void Invoke(IntPtr obj, MovieSceneObjectBindingID Binding, Actor Actor, bool bAllowBindingsFromAsset) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((MovieSceneObjectBindingID*)(b+0)) = Binding;
                *((IntPtr*)(b+24)) = Actor;
                *((bool*)(b+32)) = bAllowBindingsFromAsset;
                Main.GetProcessEvent(obj, AddBinding_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetSequence_method {
            static internal IntPtr GetSequence_ptr;
            static GetSequence_method() {
                GetSequence_ptr = Main.GetMethodUFunction(LevelSequenceActor.StaticClass, "GetSequence");
            }

            internal static unsafe LevelSequence Invoke(IntPtr obj, bool bLoad, bool bInitializePlayer) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bLoad;
                *((bool*)(b+1)) = bInitializePlayer;
                Main.GetProcessEvent(obj, GetSequence_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct RemoveBinding_method {
            static internal IntPtr RemoveBinding_ptr;
            static RemoveBinding_method() {
                RemoveBinding_ptr = Main.GetMethodUFunction(LevelSequenceActor.StaticClass, "RemoveBinding");
            }

            internal static unsafe void Invoke(IntPtr obj, MovieSceneObjectBindingID Binding, Actor Actor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((MovieSceneObjectBindingID*)(b+0)) = Binding;
                *((IntPtr*)(b+24)) = Actor;
                Main.GetProcessEvent(obj, RemoveBinding_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetBinding_method {
            static internal IntPtr ResetBinding_ptr;
            static ResetBinding_method() {
                ResetBinding_ptr = Main.GetMethodUFunction(LevelSequenceActor.StaticClass, "ResetBinding");
            }

            internal static unsafe void Invoke(IntPtr obj, MovieSceneObjectBindingID Binding) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((MovieSceneObjectBindingID*)(b+0)) = Binding;
                Main.GetProcessEvent(obj, ResetBinding_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetBindings_method {
            static internal IntPtr ResetBindings_ptr;
            static ResetBindings_method() {
                ResetBindings_ptr = Main.GetMethodUFunction(LevelSequenceActor.StaticClass, "ResetBindings");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetBindings_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBinding_method {
            static internal IntPtr SetBinding_ptr;
            static SetBinding_method() {
                SetBinding_ptr = Main.GetMethodUFunction(LevelSequenceActor.StaticClass, "SetBinding");
            }

            internal static unsafe void Invoke(IntPtr obj, MovieSceneObjectBindingID Binding, byte Actors /*TODO: array TArray */, bool bAllowBindingsFromAsset) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((MovieSceneObjectBindingID*)(b+0)) = Binding;
                throw new NotImplementedException(); //TODO: array TArray Actors
                *((bool*)(b+40)) = bAllowBindingsFromAsset;
                Main.GetProcessEvent(obj, SetBinding_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Actors
            }
        }
        internal struct SetEventReceivers_method {
            static internal IntPtr SetEventReceivers_ptr;
            static SetEventReceivers_method() {
                SetEventReceivers_ptr = Main.GetMethodUFunction(LevelSequenceActor.StaticClass, "SetEventReceivers");
            }

            internal static unsafe void Invoke(IntPtr obj, byte AdditionalReceivers /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray AdditionalReceivers
                Main.GetProcessEvent(obj, SetEventReceivers_ptr, new IntPtr(p)); ;
                 //TODO: array TArray AdditionalReceivers
            }
        }
        internal struct SetSequence_method {
            static internal IntPtr SetSequence_ptr;
            static SetSequence_method() {
                SetSequence_ptr = Main.GetMethodUFunction(LevelSequenceActor.StaticClass, "SetSequence");
            }

            internal static unsafe void Invoke(IntPtr obj, LevelSequence InSequence) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InSequence;
                Main.GetProcessEvent(obj, SetSequence_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct LevelSequenceActor_events {
    }
}
