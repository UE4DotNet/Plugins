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
    [StructLayout( LayoutKind.Explicit, Size=88 )]
    internal unsafe struct MobileInstalledContent_fields {
    }
    internal unsafe struct MobileInstalledContent_methods {
        internal struct GetDiskFreeSpace_method {
            static internal IntPtr GetDiskFreeSpace_ptr;
            static GetDiskFreeSpace_method() {
                GetDiskFreeSpace_ptr = Main.GetMethodUFunction(MobileInstalledContent.StaticClass, "GetDiskFreeSpace");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDiskFreeSpace_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetInstalledContentSize_method {
            static internal IntPtr GetInstalledContentSize_ptr;
            static GetInstalledContentSize_method() {
                GetInstalledContentSize_ptr = Main.GetMethodUFunction(MobileInstalledContent.StaticClass, "GetInstalledContentSize");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetInstalledContentSize_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct Mount_method {
            static internal IntPtr Mount_ptr;
            static Mount_method() {
                Mount_ptr = Main.GetMethodUFunction(MobileInstalledContent.StaticClass, "Mount");
            }

            internal static unsafe bool Invoke(IntPtr obj, int PakOrder, string MountPoint) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PakOrder;
                var MountPoint_handle = GCHandle.Alloc(MountPoint, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = MountPoint_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = MountPoint.Length;
                *(int*)(b+IntPtr.Size+4+8) = MountPoint.Length;
                Main.GetProcessEvent(obj, Mount_ptr, new IntPtr(p)); ;
                MountPoint_handle.Free();
                return *((bool*)(b+24));
            }
        }
    }
    internal unsafe struct MobileInstalledContent_events {
    }
}
