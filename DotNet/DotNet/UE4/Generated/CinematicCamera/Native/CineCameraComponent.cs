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


namespace UE4.CinematicCamera.Native {
    [StructLayout( LayoutKind.Explicit, Size=2320 )]
    internal unsafe struct CineCameraComponent_fields {
        [FieldOffset(2096)] public CameraFilmbackSettings FilmbackSettings;
        [FieldOffset(2108)] public CameraLensSettings LensSettings;
        [FieldOffset(2136)] public CameraFocusSettings FocusSettings;
        [FieldOffset(2192)] public float CurrentFocalLength;
        [FieldOffset(2196)] public float CurrentAperture;
        [FieldOffset(2200)] public float CurrentFocusDistance;
        [FieldOffset(2204)] public float CurrentHorizontalFOV;
        [FieldOffset(2216)]  public IntPtr  FocusPlaneVisualizationMesh;
        [FieldOffset(2224)]  public IntPtr  FocusPlaneVisualizationMaterial;
        [FieldOffset(2232)]  public IntPtr  DebugFocusPlaneComponent;
        [FieldOffset(2240)]  public IntPtr  DebugFocusPlaneMID;
        [FieldOffset(2248)] public NativeArray FilmbackPresets;
        [FieldOffset(2264)] public NativeArray LensPresets;
        [FieldOffset(2280)] byte DefaultFilmbackPresetName; //TODO: string FString DefaultFilmbackPresetName
        [FieldOffset(2296)] byte DefaultLensPresetName; //TODO: string FString DefaultLensPresetName
        [FieldOffset(2312)] public float DefaultLensFocalLength;
        [FieldOffset(2316)] public float DefaultLensFStop;
    }
    internal unsafe struct CineCameraComponent_methods {
        internal struct GetFilmbackPresetName_method {
            static internal IntPtr GetFilmbackPresetName_ptr;
            static GetFilmbackPresetName_method() {
                GetFilmbackPresetName_ptr = Main.GetMethodUFunction(CineCameraComponent.StaticClass, "GetFilmbackPresetName");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFilmbackPresetName_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetHorizontalFieldOfView_method {
            static internal IntPtr GetHorizontalFieldOfView_ptr;
            static GetHorizontalFieldOfView_method() {
                GetHorizontalFieldOfView_ptr = Main.GetMethodUFunction(CineCameraComponent.StaticClass, "GetHorizontalFieldOfView");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetHorizontalFieldOfView_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetLensPresetName_method {
            static internal IntPtr GetLensPresetName_ptr;
            static GetLensPresetName_method() {
                GetLensPresetName_ptr = Main.GetMethodUFunction(CineCameraComponent.StaticClass, "GetLensPresetName");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLensPresetName_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetVerticalFieldOfView_method {
            static internal IntPtr GetVerticalFieldOfView_ptr;
            static GetVerticalFieldOfView_method() {
                GetVerticalFieldOfView_ptr = Main.GetMethodUFunction(CineCameraComponent.StaticClass, "GetVerticalFieldOfView");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetVerticalFieldOfView_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct SetFilmbackPresetByName_method {
            static internal IntPtr SetFilmbackPresetByName_ptr;
            static SetFilmbackPresetByName_method() {
                SetFilmbackPresetByName_ptr = Main.GetMethodUFunction(CineCameraComponent.StaticClass, "SetFilmbackPresetByName");
            }

            internal static unsafe void Invoke(IntPtr obj, string InPresetName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var InPresetName_handle = GCHandle.Alloc(InPresetName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InPresetName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InPresetName.Length;
                *(int*)(b+IntPtr.Size+4+0) = InPresetName.Length;
                Main.GetProcessEvent(obj, SetFilmbackPresetByName_ptr, new IntPtr(p)); ;
                InPresetName_handle.Free();
            }
        }
        internal struct SetLensPresetByName_method {
            static internal IntPtr SetLensPresetByName_ptr;
            static SetLensPresetByName_method() {
                SetLensPresetByName_ptr = Main.GetMethodUFunction(CineCameraComponent.StaticClass, "SetLensPresetByName");
            }

            internal static unsafe void Invoke(IntPtr obj, string InPresetName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var InPresetName_handle = GCHandle.Alloc(InPresetName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InPresetName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InPresetName.Length;
                *(int*)(b+IntPtr.Size+4+0) = InPresetName.Length;
                Main.GetProcessEvent(obj, SetLensPresetByName_ptr, new IntPtr(p)); ;
                InPresetName_handle.Free();
            }
        }
    }
    internal unsafe struct CineCameraComponent_events {
    }
}
