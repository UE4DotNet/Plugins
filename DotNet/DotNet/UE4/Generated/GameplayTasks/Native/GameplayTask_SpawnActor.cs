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

namespace UE4.GameplayTasks.Native {
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct GameplayTask_SpawnActor_fields {
        [FieldOffset(136)] byte Success; //TODO: multicast delegate FGameplayTaskSpawnActorDelegate Success
        [FieldOffset(152)] byte DidNotSpawn; //TODO: multicast delegate FGameplayTaskSpawnActorDelegate DidNotSpawn
        [FieldOffset(192)] public IntPtr ClassToSpawn;
    }
    internal unsafe struct GameplayTask_SpawnActor_methods {
        internal struct BeginSpawningActor_method {
            static internal IntPtr BeginSpawningActor_ptr;
            static BeginSpawningActor_method() {
                BeginSpawningActor_ptr = Main.GetMethodUFunction(GameplayTask_SpawnActor.StaticClass, "BeginSpawningActor");
            }

            internal static unsafe (Actor, bool) Invoke(IntPtr obj, UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(obj, BeginSpawningActor_ptr, new IntPtr(p)); ;
                return (*((IntPtr*)(b+8)),*((bool*)(b+16)));
            }
        }
        internal struct FinishSpawningActor_method {
            static internal IntPtr FinishSpawningActor_ptr;
            static FinishSpawningActor_method() {
                FinishSpawningActor_ptr = Main.GetMethodUFunction(GameplayTask_SpawnActor.StaticClass, "FinishSpawningActor");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject WorldContextObject, Actor SpawnedActor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = SpawnedActor;
                Main.GetProcessEvent(obj, FinishSpawningActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SpawnActor_method {
            static internal IntPtr SpawnActor_ptr;
            static SpawnActor_method() {
                SpawnActor_ptr = Main.GetMethodUFunction(GameplayTask_SpawnActor.StaticClass, "SpawnActor");
            }

            internal static unsafe GameplayTask_SpawnActor Invoke(byte TaskOwner /*TODO: interface TScriptInterface */, Vector SpawnLocation, Rotator SpawnRotation, SubclassOf<Actor> Class, bool bSpawnOnlyOnAuthority) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface TaskOwner
                *((Vector*)(b+16)) = SpawnLocation;
                *((Rotator*)(b+28)) = SpawnRotation;
                *((IntPtr*)(b+40)) = Class;
                *((bool*)(b+48)) = bSpawnOnlyOnAuthority;
                Main.GetProcessEvent(GameplayTask_SpawnActor.DefaultObject, SpawnActor_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface TaskOwner
                return *((IntPtr*)(b+56));
            }
        }
    }
    internal unsafe struct GameplayTask_SpawnActor_events {
    }
}
