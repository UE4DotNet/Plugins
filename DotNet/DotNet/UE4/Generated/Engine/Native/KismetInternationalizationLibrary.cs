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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct KismetInternationalizationLibrary_fields {
    }
    internal unsafe struct KismetInternationalizationLibrary_methods {
        internal struct ClearCurrentAssetGroupCulture_method {
            static internal IntPtr ClearCurrentAssetGroupCulture_ptr;
            static ClearCurrentAssetGroupCulture_method() {
                ClearCurrentAssetGroupCulture_ptr = Main.GetMethodUFunction(KismetInternationalizationLibrary.StaticClass, "ClearCurrentAssetGroupCulture");
            }

            internal static unsafe void Invoke(Name AssetGroup, bool SaveToConfig) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = AssetGroup;
                *((bool*)(b+12)) = SaveToConfig;
                Main.GetProcessEvent(KismetInternationalizationLibrary.DefaultObject, ClearCurrentAssetGroupCulture_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetCurrentAssetGroupCulture_method {
            static internal IntPtr GetCurrentAssetGroupCulture_ptr;
            static GetCurrentAssetGroupCulture_method() {
                GetCurrentAssetGroupCulture_ptr = Main.GetMethodUFunction(KismetInternationalizationLibrary.StaticClass, "GetCurrentAssetGroupCulture");
            }

            internal static unsafe string Invoke(Name AssetGroup) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = AssetGroup;
                Main.GetProcessEvent(KismetInternationalizationLibrary.DefaultObject, GetCurrentAssetGroupCulture_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct GetCurrentCulture_method {
            static internal IntPtr GetCurrentCulture_ptr;
            static GetCurrentCulture_method() {
                GetCurrentCulture_ptr = Main.GetMethodUFunction(KismetInternationalizationLibrary.StaticClass, "GetCurrentCulture");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetInternationalizationLibrary.DefaultObject, GetCurrentCulture_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetCurrentLanguage_method {
            static internal IntPtr GetCurrentLanguage_ptr;
            static GetCurrentLanguage_method() {
                GetCurrentLanguage_ptr = Main.GetMethodUFunction(KismetInternationalizationLibrary.StaticClass, "GetCurrentLanguage");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetInternationalizationLibrary.DefaultObject, GetCurrentLanguage_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetCurrentLocale_method {
            static internal IntPtr GetCurrentLocale_ptr;
            static GetCurrentLocale_method() {
                GetCurrentLocale_ptr = Main.GetMethodUFunction(KismetInternationalizationLibrary.StaticClass, "GetCurrentLocale");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetInternationalizationLibrary.DefaultObject, GetCurrentLocale_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct SetCurrentAssetGroupCulture_method {
            static internal IntPtr SetCurrentAssetGroupCulture_ptr;
            static SetCurrentAssetGroupCulture_method() {
                SetCurrentAssetGroupCulture_ptr = Main.GetMethodUFunction(KismetInternationalizationLibrary.StaticClass, "SetCurrentAssetGroupCulture");
            }

            internal static unsafe bool Invoke(Name AssetGroup, string Culture, bool SaveToConfig) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = AssetGroup;
                var Culture_handle = GCHandle.Alloc(Culture, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Culture_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Culture.Length;
                *(int*)(b+IntPtr.Size+4+16) = Culture.Length;
                *((bool*)(b+32)) = SaveToConfig;
                Main.GetProcessEvent(KismetInternationalizationLibrary.DefaultObject, SetCurrentAssetGroupCulture_ptr, new IntPtr(p)); ;
                Culture_handle.Free();
                return *((bool*)(b+33));
            }
        }
        internal struct SetCurrentCulture_method {
            static internal IntPtr SetCurrentCulture_ptr;
            static SetCurrentCulture_method() {
                SetCurrentCulture_ptr = Main.GetMethodUFunction(KismetInternationalizationLibrary.StaticClass, "SetCurrentCulture");
            }

            internal static unsafe bool Invoke(string Culture, bool SaveToConfig) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Culture_handle = GCHandle.Alloc(Culture, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Culture_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Culture.Length;
                *(int*)(b+IntPtr.Size+4+0) = Culture.Length;
                *((bool*)(b+16)) = SaveToConfig;
                Main.GetProcessEvent(KismetInternationalizationLibrary.DefaultObject, SetCurrentCulture_ptr, new IntPtr(p)); ;
                Culture_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct SetCurrentLanguage_method {
            static internal IntPtr SetCurrentLanguage_ptr;
            static SetCurrentLanguage_method() {
                SetCurrentLanguage_ptr = Main.GetMethodUFunction(KismetInternationalizationLibrary.StaticClass, "SetCurrentLanguage");
            }

            internal static unsafe bool Invoke(string Culture, bool SaveToConfig) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Culture_handle = GCHandle.Alloc(Culture, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Culture_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Culture.Length;
                *(int*)(b+IntPtr.Size+4+0) = Culture.Length;
                *((bool*)(b+16)) = SaveToConfig;
                Main.GetProcessEvent(KismetInternationalizationLibrary.DefaultObject, SetCurrentLanguage_ptr, new IntPtr(p)); ;
                Culture_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct SetCurrentLanguageAndLocale_method {
            static internal IntPtr SetCurrentLanguageAndLocale_ptr;
            static SetCurrentLanguageAndLocale_method() {
                SetCurrentLanguageAndLocale_ptr = Main.GetMethodUFunction(KismetInternationalizationLibrary.StaticClass, "SetCurrentLanguageAndLocale");
            }

            internal static unsafe bool Invoke(string Culture, bool SaveToConfig) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Culture_handle = GCHandle.Alloc(Culture, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Culture_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Culture.Length;
                *(int*)(b+IntPtr.Size+4+0) = Culture.Length;
                *((bool*)(b+16)) = SaveToConfig;
                Main.GetProcessEvent(KismetInternationalizationLibrary.DefaultObject, SetCurrentLanguageAndLocale_ptr, new IntPtr(p)); ;
                Culture_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct SetCurrentLocale_method {
            static internal IntPtr SetCurrentLocale_ptr;
            static SetCurrentLocale_method() {
                SetCurrentLocale_ptr = Main.GetMethodUFunction(KismetInternationalizationLibrary.StaticClass, "SetCurrentLocale");
            }

            internal static unsafe bool Invoke(string Culture, bool SaveToConfig) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Culture_handle = GCHandle.Alloc(Culture, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Culture_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Culture.Length;
                *(int*)(b+IntPtr.Size+4+0) = Culture.Length;
                *((bool*)(b+16)) = SaveToConfig;
                Main.GetProcessEvent(KismetInternationalizationLibrary.DefaultObject, SetCurrentLocale_ptr, new IntPtr(p)); ;
                Culture_handle.Free();
                return *((bool*)(b+17));
            }
        }
    }
    internal unsafe struct KismetInternationalizationLibrary_events {
    }
}
