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


namespace UE4.MobilePatchingUtils.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MobilePatchingLibrary_fields {
    }
    internal unsafe struct MobilePatchingLibrary_methods {
        internal struct GetActiveDeviceProfileName_method {
            static internal IntPtr GetActiveDeviceProfileName_ptr;
            static GetActiveDeviceProfileName_method() {
                GetActiveDeviceProfileName_ptr = Main.GetMethodUFunction(MobilePatchingLibrary.StaticClass, "GetActiveDeviceProfileName");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MobilePatchingLibrary.DefaultObject, GetActiveDeviceProfileName_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetInstalledContent_method {
            static internal IntPtr GetInstalledContent_ptr;
            static GetInstalledContent_method() {
                GetInstalledContent_ptr = Main.GetMethodUFunction(MobilePatchingLibrary.StaticClass, "GetInstalledContent");
            }

            internal static unsafe MobileInstalledContent Invoke(string InstallDirectory) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InstallDirectory_handle = GCHandle.Alloc(InstallDirectory, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InstallDirectory_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InstallDirectory.Length;
                *(int*)(b+IntPtr.Size+4+0) = InstallDirectory.Length;
                Main.GetProcessEvent(MobilePatchingLibrary.DefaultObject, GetInstalledContent_ptr, new IntPtr(p)); ;
                InstallDirectory_handle.Free();
                return *((IntPtr*)(b+16));
            }
        }
        internal struct GetSupportedPlatformNames_method {
            static internal IntPtr GetSupportedPlatformNames_ptr;
            static GetSupportedPlatformNames_method() {
                GetSupportedPlatformNames_ptr = Main.GetMethodUFunction(MobilePatchingLibrary.StaticClass, "GetSupportedPlatformNames");
            }

            internal static unsafe IReadOnlyCollection<string> Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MobilePatchingLibrary.DefaultObject, GetSupportedPlatformNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToStringCollection(b+0);
            }
        }
        internal struct HasActiveWiFiConnection_method {
            static internal IntPtr HasActiveWiFiConnection_ptr;
            static HasActiveWiFiConnection_method() {
                HasActiveWiFiConnection_ptr = Main.GetMethodUFunction(MobilePatchingLibrary.StaticClass, "HasActiveWiFiConnection");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MobilePatchingLibrary.DefaultObject, HasActiveWiFiConnection_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct RequestContent_method {
            static internal IntPtr RequestContent_ptr;
            static RequestContent_method() {
                RequestContent_ptr = Main.GetMethodUFunction(MobilePatchingLibrary.StaticClass, "RequestContent");
            }

            internal static unsafe void Invoke(string RemoteManifestURL, string CloudURL, string InstallDirectory, byte OnSucceeded /*TODO: delegate FOnRequestContentSucceeded */, byte OnFailed /*TODO: delegate FOnRequestContentFailed */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var RemoteManifestURL_handle = GCHandle.Alloc(RemoteManifestURL, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = RemoteManifestURL_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = RemoteManifestURL.Length;
                *(int*)(b+IntPtr.Size+4+0) = RemoteManifestURL.Length;
                var CloudURL_handle = GCHandle.Alloc(CloudURL, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = CloudURL_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = CloudURL.Length;
                *(int*)(b+IntPtr.Size+4+16) = CloudURL.Length;
                var InstallDirectory_handle = GCHandle.Alloc(InstallDirectory, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = InstallDirectory_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = InstallDirectory.Length;
                *(int*)(b+IntPtr.Size+4+32) = InstallDirectory.Length;
                throw new NotImplementedException(); //TODO: delegate FOnRequestContentSucceeded OnSucceeded
                throw new NotImplementedException(); //TODO: delegate FOnRequestContentFailed OnFailed
                Main.GetProcessEvent(MobilePatchingLibrary.DefaultObject, RequestContent_ptr, new IntPtr(p)); ;
                RemoteManifestURL_handle.Free();
                CloudURL_handle.Free();
                InstallDirectory_handle.Free();
                 //TODO: delegate FOnRequestContentSucceeded OnSucceeded
                 //TODO: delegate FOnRequestContentFailed OnFailed
            }
        }
    }
    internal unsafe struct MobilePatchingLibrary_events {
    }
}
