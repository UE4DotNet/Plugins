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
    [StructLayout( LayoutKind.Explicit, Size=432 )]
    internal unsafe struct LevelStreamingKismet_fields {
        [FieldOffset(416)] public bool bInitiallyLoaded;
        [FieldOffset(416)] public bool bInitiallyVisible;
    }
    internal unsafe struct LevelStreamingKismet_methods {
        internal struct LoadLevelInstance_method {
            static internal IntPtr LoadLevelInstance_ptr;
            static LoadLevelInstance_method() {
                LoadLevelInstance_ptr = Main.GetMethodUFunction(LevelStreamingKismet.StaticClass, "LoadLevelInstance");
            }

            internal static unsafe (bool, LevelStreamingKismet) Invoke(UObject WorldContextObject, string LevelName, Vector Location, Rotator Rotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                var LevelName_handle = GCHandle.Alloc(LevelName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = LevelName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = LevelName.Length;
                *(int*)(b+IntPtr.Size+4+8) = LevelName.Length;
                *((Vector*)(b+24)) = Location;
                *((Rotator*)(b+36)) = Rotation;
                Main.GetProcessEvent(LevelStreamingKismet.DefaultObject, LoadLevelInstance_ptr, new IntPtr(p)); ;
                LevelName_handle.Free();
                return (*((bool*)(b+48)),*((IntPtr*)(b+56)));
            }
        }
        internal struct LoadLevelInstanceBySoftObjectPtr_method {
            static internal IntPtr LoadLevelInstanceBySoftObjectPtr_ptr;
            static LoadLevelInstanceBySoftObjectPtr_method() {
                LoadLevelInstanceBySoftObjectPtr_ptr = Main.GetMethodUFunction(LevelStreamingKismet.StaticClass, "LoadLevelInstanceBySoftObjectPtr");
            }

            internal static unsafe (bool, LevelStreamingKismet) Invoke(UObject WorldContextObject, byte Level /*TODO: soft object TSoftObjectPtr<UWorld> */, Vector Location, Rotator Rotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                throw new NotImplementedException(); //TODO: soft object TSoftObjectPtr<UWorld> Level
                *((Vector*)(b+56)) = Location;
                *((Rotator*)(b+68)) = Rotation;
                Main.GetProcessEvent(LevelStreamingKismet.DefaultObject, LoadLevelInstanceBySoftObjectPtr_ptr, new IntPtr(p)); ;
                 //TODO: soft object TSoftObjectPtr<UWorld> Level
                return (*((bool*)(b+80)),*((IntPtr*)(b+88)));
            }
        }
    }
    internal unsafe struct LevelStreamingKismet_events {
    }
}
