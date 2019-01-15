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


namespace UE4.MagicLeapSecureStorage.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MagicLeapSecureStorage_fields {
    }
    internal unsafe struct MagicLeapSecureStorage_methods {
        internal struct DeleteSecureData_method {
            static internal IntPtr DeleteSecureData_ptr;
            static DeleteSecureData_method() {
                DeleteSecureData_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "DeleteSecureData");
            }

            internal static unsafe bool Invoke(string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, DeleteSecureData_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return *((bool*)(b+16));
            }
        }
        internal struct GetSecureBool_method {
            static internal IntPtr GetSecureBool_ptr;
            static GetSecureBool_method() {
                GetSecureBool_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "GetSecureBool");
            }

            internal static unsafe (bool, bool) Invoke(string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, GetSecureBool_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return (*((bool*)(b+16)),*((bool*)(b+17)));
            }
        }
        internal struct GetSecureByte_method {
            static internal IntPtr GetSecureByte_ptr;
            static GetSecureByte_method() {
                GetSecureByte_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "GetSecureByte");
            }

            internal static unsafe (byte, bool) Invoke(string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, GetSecureByte_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return (*(b+16),*((bool*)(b+17)));
            }
        }
        internal struct GetSecureFloat_method {
            static internal IntPtr GetSecureFloat_ptr;
            static GetSecureFloat_method() {
                GetSecureFloat_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "GetSecureFloat");
            }

            internal static unsafe (float, bool) Invoke(string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, GetSecureFloat_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return (*((float*)(b+16)),*((bool*)(b+20)));
            }
        }
        internal struct GetSecureInt_method {
            static internal IntPtr GetSecureInt_ptr;
            static GetSecureInt_method() {
                GetSecureInt_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "GetSecureInt");
            }

            internal static unsafe (int, bool) Invoke(string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, GetSecureInt_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return (*((int*)(b+16)),*((bool*)(b+20)));
            }
        }
        internal struct GetSecureRotator_method {
            static internal IntPtr GetSecureRotator_ptr;
            static GetSecureRotator_method() {
                GetSecureRotator_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "GetSecureRotator");
            }

            internal static unsafe (Rotator, bool) Invoke(string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, GetSecureRotator_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return (*((Rotator*)(b+16)),*((bool*)(b+28)));
            }
        }
        internal struct GetSecureString_method {
            static internal IntPtr GetSecureString_ptr;
            static GetSecureString_method() {
                GetSecureString_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "GetSecureString");
            }

            internal static unsafe (string, bool) Invoke(string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, GetSecureString_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return (FString.Get(b+16),*((bool*)(b+32)));
            }
        }
        internal struct GetSecureTransform_method {
            static internal IntPtr GetSecureTransform_ptr;
            static GetSecureTransform_method() {
                GetSecureTransform_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "GetSecureTransform");
            }

            internal static unsafe (Transform, bool) Invoke(string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, GetSecureTransform_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return (*((Transform*)(b+16)),*((bool*)(b+64)));
            }
        }
        internal struct GetSecureVector_method {
            static internal IntPtr GetSecureVector_ptr;
            static GetSecureVector_method() {
                GetSecureVector_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "GetSecureVector");
            }

            internal static unsafe (Vector, bool) Invoke(string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, GetSecureVector_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return (*((Vector*)(b+16)),*((bool*)(b+28)));
            }
        }
        internal struct PutSecureBool_method {
            static internal IntPtr PutSecureBool_ptr;
            static PutSecureBool_method() {
                PutSecureBool_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "PutSecureBool");
            }

            internal static unsafe bool Invoke(string Key, bool DataToStore) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                *((bool*)(b+16)) = DataToStore;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, PutSecureBool_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct PutSecureByte_method {
            static internal IntPtr PutSecureByte_ptr;
            static PutSecureByte_method() {
                PutSecureByte_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "PutSecureByte");
            }

            internal static unsafe bool Invoke(string Key, byte DataToStore) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                *(b+16) = DataToStore;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, PutSecureByte_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct PutSecureFloat_method {
            static internal IntPtr PutSecureFloat_ptr;
            static PutSecureFloat_method() {
                PutSecureFloat_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "PutSecureFloat");
            }

            internal static unsafe bool Invoke(string Key, float DataToStore) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                *((float*)(b+16)) = DataToStore;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, PutSecureFloat_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return *((bool*)(b+20));
            }
        }
        internal struct PutSecureInt_method {
            static internal IntPtr PutSecureInt_ptr;
            static PutSecureInt_method() {
                PutSecureInt_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "PutSecureInt");
            }

            internal static unsafe bool Invoke(string Key, int DataToStore) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                *((int*)(b+16)) = DataToStore;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, PutSecureInt_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return *((bool*)(b+20));
            }
        }
        internal struct PutSecureRotator_method {
            static internal IntPtr PutSecureRotator_ptr;
            static PutSecureRotator_method() {
                PutSecureRotator_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "PutSecureRotator");
            }

            internal static unsafe bool Invoke(string Key, Rotator DataToStore) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                *((Rotator*)(b+16)) = DataToStore;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, PutSecureRotator_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return *((bool*)(b+28));
            }
        }
        internal struct PutSecureString_method {
            static internal IntPtr PutSecureString_ptr;
            static PutSecureString_method() {
                PutSecureString_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "PutSecureString");
            }

            internal static unsafe bool Invoke(string Key, string DataToStore) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                var DataToStore_handle = GCHandle.Alloc(DataToStore, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = DataToStore_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = DataToStore.Length;
                *(int*)(b+IntPtr.Size+4+16) = DataToStore.Length;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, PutSecureString_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                DataToStore_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct PutSecureTransform_method {
            static internal IntPtr PutSecureTransform_ptr;
            static PutSecureTransform_method() {
                PutSecureTransform_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "PutSecureTransform");
            }

            internal static unsafe bool Invoke(string Key, Transform DataToStore) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                *((Transform*)(b+16)) = DataToStore;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, PutSecureTransform_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return *((bool*)(b+64));
            }
        }
        internal struct PutSecureVector_method {
            static internal IntPtr PutSecureVector_ptr;
            static PutSecureVector_method() {
                PutSecureVector_ptr = Main.GetMethodUFunction(MagicLeapSecureStorage.StaticClass, "PutSecureVector");
            }

            internal static unsafe bool Invoke(string Key, Vector DataToStore) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Key.Length;
                *(int*)(b+IntPtr.Size+4+0) = Key.Length;
                *((Vector*)(b+16)) = DataToStore;
                Main.GetProcessEvent(MagicLeapSecureStorage.DefaultObject, PutSecureVector_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return *((bool*)(b+28));
            }
        }
    }
    internal unsafe struct MagicLeapSecureStorage_events {
    }
}
