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
    [StructLayout( LayoutKind.Explicit, Size=416 )]
    internal unsafe struct LevelStreaming_fields {
        [FieldOffset(72)] byte WorldAsset; //TODO: soft object TSoftObjectPtr<UWorld> WorldAsset
        [FieldOffset(120)] public Name PackageNameToLoad;
        [FieldOffset(136)] public NativeArray LODPackageNames;
        [FieldOffset(176)] public Transform LevelTransform;
        [FieldOffset(224)] public int LevelLODIndex;
        [FieldOffset(230)] public bool bShouldBeVisibleInEditor;
        [FieldOffset(230)] public bool bShouldBeVisible;
        [FieldOffset(230)] public bool bShouldBeLoaded;
        [FieldOffset(230)] public bool bLocked;
        [FieldOffset(230)] public bool bIsStatic;
        [FieldOffset(230)] public bool bShouldBlockOnLoad;
        [FieldOffset(231)] public bool bShouldBlockOnUnload;
        [FieldOffset(231)] public bool bDisableDistanceStreaming;
        [FieldOffset(231)] public bool bDrawOnLevelStatusMap;
        [FieldOffset(236)] public LinearColor LevelColor;
        [FieldOffset(256)] public NativeArray EditorStreamingVolumes;
        [FieldOffset(272)] public float MinTimeBetweenVolumeUnloadRequests;
        [FieldOffset(280)] public NativeArray Keywords;
        [FieldOffset(296)] byte OnLevelLoaded; //TODO: multicast delegate FLevelStreamingLoadedStatus OnLevelLoaded
        [FieldOffset(312)] byte OnLevelUnloaded; //TODO: multicast delegate FLevelStreamingLoadedStatus OnLevelUnloaded
        [FieldOffset(328)] byte OnLevelShown; //TODO: multicast delegate FLevelStreamingVisibilityStatus OnLevelShown
        [FieldOffset(344)] byte OnLevelHidden; //TODO: multicast delegate FLevelStreamingVisibilityStatus OnLevelHidden
        [FieldOffset(360)]  public IntPtr  LoadedLevel;
        [FieldOffset(368)]  public IntPtr  PendingUnloadLevel;
        [FieldOffset(376)] public Name FolderPath;
    }
    internal unsafe struct LevelStreaming_methods {
        internal struct CreateInstance_method {
            static internal IntPtr CreateInstance_ptr;
            static CreateInstance_method() {
                CreateInstance_ptr = Main.GetMethodUFunction(LevelStreaming.StaticClass, "CreateInstance");
            }

            internal static unsafe LevelStreaming Invoke(IntPtr obj, string UniqueInstanceName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var UniqueInstanceName_handle = GCHandle.Alloc(UniqueInstanceName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = UniqueInstanceName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = UniqueInstanceName.Length;
                *(int*)(b+IntPtr.Size+4+0) = UniqueInstanceName.Length;
                Main.GetProcessEvent(obj, CreateInstance_ptr, new IntPtr(p)); ;
                UniqueInstanceName_handle.Free();
                return *((IntPtr*)(b+16));
            }
        }
        internal struct GetLevelScriptActor_method {
            static internal IntPtr GetLevelScriptActor_ptr;
            static GetLevelScriptActor_method() {
                GetLevelScriptActor_ptr = Main.GetMethodUFunction(LevelStreaming.StaticClass, "GetLevelScriptActor");
            }

            internal static unsafe LevelScriptActor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLevelScriptActor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetWorldAssetPackageFName_method {
            static internal IntPtr GetWorldAssetPackageFName_ptr;
            static GetWorldAssetPackageFName_method() {
                GetWorldAssetPackageFName_ptr = Main.GetMethodUFunction(LevelStreaming.StaticClass, "GetWorldAssetPackageFName");
            }

            internal static unsafe Name Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetWorldAssetPackageFName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+0));
            }
        }
        internal struct IsLevelLoaded_method {
            static internal IntPtr IsLevelLoaded_ptr;
            static IsLevelLoaded_method() {
                IsLevelLoaded_ptr = Main.GetMethodUFunction(LevelStreaming.StaticClass, "IsLevelLoaded");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsLevelLoaded_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsLevelVisible_method {
            static internal IntPtr IsLevelVisible_ptr;
            static IsLevelVisible_method() {
                IsLevelVisible_ptr = Main.GetMethodUFunction(LevelStreaming.StaticClass, "IsLevelVisible");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsLevelVisible_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsStreamingStatePending_method {
            static internal IntPtr IsStreamingStatePending_ptr;
            static IsStreamingStatePending_method() {
                IsStreamingStatePending_ptr = Main.GetMethodUFunction(LevelStreaming.StaticClass, "IsStreamingStatePending");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsStreamingStatePending_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetLevelLODIndex_method {
            static internal IntPtr SetLevelLODIndex_ptr;
            static SetLevelLODIndex_method() {
                SetLevelLODIndex_ptr = Main.GetMethodUFunction(LevelStreaming.StaticClass, "SetLevelLODIndex");
            }

            internal static unsafe void Invoke(IntPtr obj, int LODIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = LODIndex;
                Main.GetProcessEvent(obj, SetLevelLODIndex_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetShouldBeLoaded_method {
            static internal IntPtr SetShouldBeLoaded_ptr;
            static SetShouldBeLoaded_method() {
                SetShouldBeLoaded_ptr = Main.GetMethodUFunction(LevelStreaming.StaticClass, "SetShouldBeLoaded");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInShouldBeLoaded) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInShouldBeLoaded;
                Main.GetProcessEvent(obj, SetShouldBeLoaded_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetShouldBeVisible_method {
            static internal IntPtr SetShouldBeVisible_ptr;
            static SetShouldBeVisible_method() {
                SetShouldBeVisible_ptr = Main.GetMethodUFunction(LevelStreaming.StaticClass, "SetShouldBeVisible");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInShouldBeVisible) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInShouldBeVisible;
                Main.GetProcessEvent(obj, SetShouldBeVisible_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ShouldBeLoaded_method {
            static internal IntPtr ShouldBeLoaded_ptr;
            static ShouldBeLoaded_method() {
                ShouldBeLoaded_ptr = Main.GetMethodUFunction(LevelStreaming.StaticClass, "ShouldBeLoaded");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ShouldBeLoaded_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct LevelStreaming_events {
    }
}
