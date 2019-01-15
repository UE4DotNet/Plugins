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
    internal unsafe struct InputSettings_fields {
        [FieldOffset(56)] public NativeArray AxisConfig;
        [FieldOffset(72)] public bool bAltEnterTogglesFullscreen;
        [FieldOffset(72)] public bool bF11TogglesFullscreen;
        [FieldOffset(72)] public bool bUseMouseForTouch;
        [FieldOffset(72)] public bool bEnableMouseSmoothing;
        [FieldOffset(72)] public bool bEnableFOVScaling;
        [FieldOffset(72)] public bool bCaptureMouseOnLaunch;
        [FieldOffset(72)] public bool bAlwaysShowTouchInterface;
        [FieldOffset(73)] public bool bShowConsoleOnFourFingerTap;
        [FieldOffset(73)] public bool bEnableGestureRecognizer;
        [FieldOffset(74)] public bool bUseAutocorrect;
        [FieldOffset(80)] public NativeArray ExcludedAutocorrectOS;
        [FieldOffset(96)] public NativeArray ExcludedAutocorrectCultures;
        [FieldOffset(112)] public NativeArray ExcludedAutocorrectDeviceModels;
        [FieldOffset(128)] byte DefaultViewportMouseCaptureMode; //TODO: enum EMouseCaptureMode DefaultViewportMouseCaptureMode
        [FieldOffset(129)] byte DefaultViewportMouseLockMode; //TODO: enum EMouseLockMode DefaultViewportMouseLockMode
        [FieldOffset(132)] public float FOVScale;
        [FieldOffset(136)] public float DoubleClickTime;
        [FieldOffset(144)] public NativeArray ActionMappings;
        [FieldOffset(160)] public NativeArray AxisMappings;
        [FieldOffset(176)] public SoftObjectPath DefaultTouchInterface;
        [FieldOffset(240)] public NativeArray ConsoleKeys;
    }
    internal unsafe struct InputSettings_methods {
        internal struct AddActionMapping_method {
            static internal IntPtr AddActionMapping_ptr;
            static AddActionMapping_method() {
                AddActionMapping_ptr = Main.GetMethodUFunction(InputSettings.StaticClass, "AddActionMapping");
            }

            internal static unsafe void Invoke(IntPtr obj, InputActionKeyMapping KeyMapping, bool bForceRebuildKeymaps) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputActionKeyMapping*)(b+0)) = KeyMapping;
                *((bool*)(b+48)) = bForceRebuildKeymaps;
                Main.GetProcessEvent(obj, AddActionMapping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddAxisMapping_method {
            static internal IntPtr AddAxisMapping_ptr;
            static AddAxisMapping_method() {
                AddAxisMapping_ptr = Main.GetMethodUFunction(InputSettings.StaticClass, "AddAxisMapping");
            }

            internal static unsafe void Invoke(IntPtr obj, InputAxisKeyMapping KeyMapping, bool bForceRebuildKeymaps) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputAxisKeyMapping*)(b+0)) = KeyMapping;
                *((bool*)(b+48)) = bForceRebuildKeymaps;
                Main.GetProcessEvent(obj, AddAxisMapping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ForceRebuildKeymaps_method {
            static internal IntPtr ForceRebuildKeymaps_ptr;
            static ForceRebuildKeymaps_method() {
                ForceRebuildKeymaps_ptr = Main.GetMethodUFunction(InputSettings.StaticClass, "ForceRebuildKeymaps");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ForceRebuildKeymaps_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetActionMappingByName_method {
            static internal IntPtr GetActionMappingByName_ptr;
            static GetActionMappingByName_method() {
                GetActionMappingByName_ptr = Main.GetMethodUFunction(InputSettings.StaticClass, "GetActionMappingByName");
            }

            internal static unsafe IReadOnlyCollection<InputActionKeyMapping> Invoke(IntPtr obj, Name InActionName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InActionName;
                Main.GetProcessEvent(obj, GetActionMappingByName_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutMappings
                return UObject.ToUnmangedCollection<InputActionKeyMapping>(b+16);
            }
        }
        internal struct GetActionNames_method {
            static internal IntPtr GetActionNames_ptr;
            static GetActionNames_method() {
                GetActionNames_ptr = Main.GetMethodUFunction(InputSettings.StaticClass, "GetActionNames");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActionNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActionNames
                return UObject.ToUnmangedCollection<Name>(b+0);
            }
        }
        internal struct GetAxisMappingByName_method {
            static internal IntPtr GetAxisMappingByName_ptr;
            static GetAxisMappingByName_method() {
                GetAxisMappingByName_ptr = Main.GetMethodUFunction(InputSettings.StaticClass, "GetAxisMappingByName");
            }

            internal static unsafe IReadOnlyCollection<InputAxisKeyMapping> Invoke(IntPtr obj, Name InAxisName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InAxisName;
                Main.GetProcessEvent(obj, GetAxisMappingByName_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutMappings
                return UObject.ToUnmangedCollection<InputAxisKeyMapping>(b+16);
            }
        }
        internal struct GetAxisNames_method {
            static internal IntPtr GetAxisNames_ptr;
            static GetAxisNames_method() {
                GetAxisNames_ptr = Main.GetMethodUFunction(InputSettings.StaticClass, "GetAxisNames");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAxisNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray AxisNames
                return UObject.ToUnmangedCollection<Name>(b+0);
            }
        }
        internal struct GetInputSettings_method {
            static internal IntPtr GetInputSettings_ptr;
            static GetInputSettings_method() {
                GetInputSettings_ptr = Main.GetMethodUFunction(InputSettings.StaticClass, "GetInputSettings");
            }

            internal static unsafe InputSettings Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(InputSettings.DefaultObject, GetInputSettings_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct RemoveActionMapping_method {
            static internal IntPtr RemoveActionMapping_ptr;
            static RemoveActionMapping_method() {
                RemoveActionMapping_ptr = Main.GetMethodUFunction(InputSettings.StaticClass, "RemoveActionMapping");
            }

            internal static unsafe void Invoke(IntPtr obj, InputActionKeyMapping KeyMapping, bool bForceRebuildKeymaps) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputActionKeyMapping*)(b+0)) = KeyMapping;
                *((bool*)(b+48)) = bForceRebuildKeymaps;
                Main.GetProcessEvent(obj, RemoveActionMapping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveAxisMapping_method {
            static internal IntPtr RemoveAxisMapping_ptr;
            static RemoveAxisMapping_method() {
                RemoveAxisMapping_ptr = Main.GetMethodUFunction(InputSettings.StaticClass, "RemoveAxisMapping");
            }

            internal static unsafe void Invoke(IntPtr obj, InputAxisKeyMapping KeyMapping, bool bForceRebuildKeymaps) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputAxisKeyMapping*)(b+0)) = KeyMapping;
                *((bool*)(b+48)) = bForceRebuildKeymaps;
                Main.GetProcessEvent(obj, RemoveAxisMapping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SaveKeyMappings_method {
            static internal IntPtr SaveKeyMappings_ptr;
            static SaveKeyMappings_method() {
                SaveKeyMappings_ptr = Main.GetMethodUFunction(InputSettings.StaticClass, "SaveKeyMappings");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SaveKeyMappings_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct InputSettings_events {
    }
}
