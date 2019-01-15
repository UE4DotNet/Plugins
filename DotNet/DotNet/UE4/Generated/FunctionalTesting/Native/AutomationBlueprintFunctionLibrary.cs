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

namespace UE4.FunctionalTesting.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct AutomationBlueprintFunctionLibrary_fields {
    }
    internal unsafe struct AutomationBlueprintFunctionLibrary_methods {
        internal struct AreAutomatedTestsRunning_method {
            static internal IntPtr AreAutomatedTestsRunning_ptr;
            static AreAutomatedTestsRunning_method() {
                AreAutomatedTestsRunning_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "AreAutomatedTestsRunning");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, AreAutomatedTestsRunning_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct DisableStatGroup_method {
            static internal IntPtr DisableStatGroup_ptr;
            static DisableStatGroup_method() {
                DisableStatGroup_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "DisableStatGroup");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Name GroupName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Name*)(b+8)) = GroupName;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, DisableStatGroup_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableStatGroup_method {
            static internal IntPtr EnableStatGroup_ptr;
            static EnableStatGroup_method() {
                EnableStatGroup_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "EnableStatGroup");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Name GroupName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Name*)(b+8)) = GroupName;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, EnableStatGroup_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetDefaultScreenshotOptionsForGameplay_method {
            static internal IntPtr GetDefaultScreenshotOptionsForGameplay_ptr;
            static GetDefaultScreenshotOptionsForGameplay_method() {
                GetDefaultScreenshotOptionsForGameplay_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "GetDefaultScreenshotOptionsForGameplay");
            }

            internal static unsafe AutomationScreenshotOptions Invoke(EComparisonTolerance Tolerance, float Delay) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Tolerance;
                *((float*)(b+4)) = Delay;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, GetDefaultScreenshotOptionsForGameplay_ptr, new IntPtr(p)); ;
                return *((AutomationScreenshotOptions*)(b+8));
            }
        }
        internal struct GetDefaultScreenshotOptionsForRendering_method {
            static internal IntPtr GetDefaultScreenshotOptionsForRendering_ptr;
            static GetDefaultScreenshotOptionsForRendering_method() {
                GetDefaultScreenshotOptionsForRendering_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "GetDefaultScreenshotOptionsForRendering");
            }

            internal static unsafe AutomationScreenshotOptions Invoke(EComparisonTolerance Tolerance, float Delay) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Tolerance;
                *((float*)(b+4)) = Delay;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, GetDefaultScreenshotOptionsForRendering_ptr, new IntPtr(p)); ;
                return *((AutomationScreenshotOptions*)(b+8));
            }
        }
        internal struct GetStatCallCount_method {
            static internal IntPtr GetStatCallCount_ptr;
            static GetStatCallCount_method() {
                GetStatCallCount_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "GetStatCallCount");
            }

            internal static unsafe float Invoke(Name StatName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = StatName;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, GetStatCallCount_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetStatExcAverage_method {
            static internal IntPtr GetStatExcAverage_ptr;
            static GetStatExcAverage_method() {
                GetStatExcAverage_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "GetStatExcAverage");
            }

            internal static unsafe float Invoke(Name StatName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = StatName;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, GetStatExcAverage_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetStatExcMax_method {
            static internal IntPtr GetStatExcMax_ptr;
            static GetStatExcMax_method() {
                GetStatExcMax_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "GetStatExcMax");
            }

            internal static unsafe float Invoke(Name StatName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = StatName;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, GetStatExcMax_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetStatIncAverage_method {
            static internal IntPtr GetStatIncAverage_ptr;
            static GetStatIncAverage_method() {
                GetStatIncAverage_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "GetStatIncAverage");
            }

            internal static unsafe float Invoke(Name StatName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = StatName;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, GetStatIncAverage_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetStatIncMax_method {
            static internal IntPtr GetStatIncMax_ptr;
            static GetStatIncMax_method() {
                GetStatIncMax_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "GetStatIncMax");
            }

            internal static unsafe float Invoke(Name StatName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = StatName;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, GetStatIncMax_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct SetScalabilityQualityLevelRelativeToMax_method {
            static internal IntPtr SetScalabilityQualityLevelRelativeToMax_ptr;
            static SetScalabilityQualityLevelRelativeToMax_method() {
                SetScalabilityQualityLevelRelativeToMax_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "SetScalabilityQualityLevelRelativeToMax");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, int Value) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((int*)(b+8)) = Value;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, SetScalabilityQualityLevelRelativeToMax_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetScalabilityQualityToEpic_method {
            static internal IntPtr SetScalabilityQualityToEpic_ptr;
            static SetScalabilityQualityToEpic_method() {
                SetScalabilityQualityToEpic_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "SetScalabilityQualityToEpic");
            }

            internal static unsafe void Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, SetScalabilityQualityToEpic_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetScalabilityQualityToLow_method {
            static internal IntPtr SetScalabilityQualityToLow_ptr;
            static SetScalabilityQualityToLow_method() {
                SetScalabilityQualityToLow_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "SetScalabilityQualityToLow");
            }

            internal static unsafe void Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, SetScalabilityQualityToLow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct TakeAutomationScreenshot_method {
            static internal IntPtr TakeAutomationScreenshot_ptr;
            static TakeAutomationScreenshot_method() {
                TakeAutomationScreenshot_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "TakeAutomationScreenshot");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, LatentActionInfo LatentInfo, string Name, string Notes, AutomationScreenshotOptions Options) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((LatentActionInfo*)(b+8)) = LatentInfo;
                var Name_handle = GCHandle.Alloc(Name, GCHandleType.Pinned);
                *(IntPtr*)(b+40) = Name_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+40) = Name.Length;
                *(int*)(b+IntPtr.Size+4+40) = Name.Length;
                var Notes_handle = GCHandle.Alloc(Notes, GCHandleType.Pinned);
                *(IntPtr*)(b+56) = Notes_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+56) = Notes.Length;
                *(int*)(b+IntPtr.Size+4+56) = Notes.Length;
                *((AutomationScreenshotOptions*)(b+72)) = Options;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, TakeAutomationScreenshot_ptr, new IntPtr(p)); ;
                Name_handle.Free();
                Notes_handle.Free();
            }
        }
        internal struct TakeAutomationScreenshotAtCamera_method {
            static internal IntPtr TakeAutomationScreenshotAtCamera_ptr;
            static TakeAutomationScreenshotAtCamera_method() {
                TakeAutomationScreenshotAtCamera_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "TakeAutomationScreenshotAtCamera");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, LatentActionInfo LatentInfo, CameraActor Camera, string NameOverride, string Notes, AutomationScreenshotOptions Options) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((LatentActionInfo*)(b+8)) = LatentInfo;
                *((IntPtr*)(b+40)) = Camera;
                var NameOverride_handle = GCHandle.Alloc(NameOverride, GCHandleType.Pinned);
                *(IntPtr*)(b+48) = NameOverride_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+48) = NameOverride.Length;
                *(int*)(b+IntPtr.Size+4+48) = NameOverride.Length;
                var Notes_handle = GCHandle.Alloc(Notes, GCHandleType.Pinned);
                *(IntPtr*)(b+64) = Notes_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+64) = Notes.Length;
                *(int*)(b+IntPtr.Size+4+64) = Notes.Length;
                *((AutomationScreenshotOptions*)(b+80)) = Options;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, TakeAutomationScreenshotAtCamera_ptr, new IntPtr(p)); ;
                NameOverride_handle.Free();
                Notes_handle.Free();
            }
        }
        internal struct TakeAutomationScreenshotOfUI_method {
            static internal IntPtr TakeAutomationScreenshotOfUI_ptr;
            static TakeAutomationScreenshotOfUI_method() {
                TakeAutomationScreenshotOfUI_ptr = Main.GetMethodUFunction(AutomationBlueprintFunctionLibrary.StaticClass, "TakeAutomationScreenshotOfUI");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, LatentActionInfo LatentInfo, string Name, AutomationScreenshotOptions Options) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((LatentActionInfo*)(b+8)) = LatentInfo;
                var Name_handle = GCHandle.Alloc(Name, GCHandleType.Pinned);
                *(IntPtr*)(b+40) = Name_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+40) = Name.Length;
                *(int*)(b+IntPtr.Size+4+40) = Name.Length;
                *((AutomationScreenshotOptions*)(b+56)) = Options;
                Main.GetProcessEvent(AutomationBlueprintFunctionLibrary.DefaultObject, TakeAutomationScreenshotOfUI_ptr, new IntPtr(p)); ;
                Name_handle.Free();
            }
        }
    }
    internal unsafe struct AutomationBlueprintFunctionLibrary_events {
    }
}
