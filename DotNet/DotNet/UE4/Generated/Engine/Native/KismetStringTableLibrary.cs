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
    internal unsafe struct KismetStringTableLibrary_fields {
    }
    internal unsafe struct KismetStringTableLibrary_methods {
        internal struct GetKeysFromStringTable_method {
            static internal IntPtr GetKeysFromStringTable_ptr;
            static GetKeysFromStringTable_method() {
                GetKeysFromStringTable_ptr = Main.GetMethodUFunction(KismetStringTableLibrary.StaticClass, "GetKeysFromStringTable");
            }

            internal static unsafe IReadOnlyCollection<string> Invoke(Name TableId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = TableId;
                Main.GetProcessEvent(KismetStringTableLibrary.DefaultObject, GetKeysFromStringTable_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToStringCollection(b+16);
            }
        }
        internal struct GetMetaDataIdsFromStringTableEntry_method {
            static internal IntPtr GetMetaDataIdsFromStringTableEntry_ptr;
            static GetMetaDataIdsFromStringTableEntry_method() {
                GetMetaDataIdsFromStringTableEntry_ptr = Main.GetMethodUFunction(KismetStringTableLibrary.StaticClass, "GetMetaDataIdsFromStringTableEntry");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(Name TableId, string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = TableId;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Key.Length;
                *(int*)(b+IntPtr.Size+4+16) = Key.Length;
                Main.GetProcessEvent(KismetStringTableLibrary.DefaultObject, GetMetaDataIdsFromStringTableEntry_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<Name>(b+32);
            }
        }
        internal struct GetRegisteredStringTables_method {
            static internal IntPtr GetRegisteredStringTables_ptr;
            static GetRegisteredStringTables_method() {
                GetRegisteredStringTables_ptr = Main.GetMethodUFunction(KismetStringTableLibrary.StaticClass, "GetRegisteredStringTables");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetStringTableLibrary.DefaultObject, GetRegisteredStringTables_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<Name>(b+0);
            }
        }
        internal struct GetTableEntryMetaData_method {
            static internal IntPtr GetTableEntryMetaData_ptr;
            static GetTableEntryMetaData_method() {
                GetTableEntryMetaData_ptr = Main.GetMethodUFunction(KismetStringTableLibrary.StaticClass, "GetTableEntryMetaData");
            }

            internal static unsafe string Invoke(Name TableId, string Key, Name MetaDataId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = TableId;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Key.Length;
                *(int*)(b+IntPtr.Size+4+16) = Key.Length;
                *((Name*)(b+32)) = MetaDataId;
                Main.GetProcessEvent(KismetStringTableLibrary.DefaultObject, GetTableEntryMetaData_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return FString.Get(b+48);
            }
        }
        internal struct GetTableEntrySourceString_method {
            static internal IntPtr GetTableEntrySourceString_ptr;
            static GetTableEntrySourceString_method() {
                GetTableEntrySourceString_ptr = Main.GetMethodUFunction(KismetStringTableLibrary.StaticClass, "GetTableEntrySourceString");
            }

            internal static unsafe string Invoke(Name TableId, string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = TableId;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Key.Length;
                *(int*)(b+IntPtr.Size+4+16) = Key.Length;
                Main.GetProcessEvent(KismetStringTableLibrary.DefaultObject, GetTableEntrySourceString_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return FString.Get(b+32);
            }
        }
        internal struct GetTableNamespace_method {
            static internal IntPtr GetTableNamespace_ptr;
            static GetTableNamespace_method() {
                GetTableNamespace_ptr = Main.GetMethodUFunction(KismetStringTableLibrary.StaticClass, "GetTableNamespace");
            }

            internal static unsafe string Invoke(Name TableId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = TableId;
                Main.GetProcessEvent(KismetStringTableLibrary.DefaultObject, GetTableNamespace_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct IsRegisteredTableEntry_method {
            static internal IntPtr IsRegisteredTableEntry_ptr;
            static IsRegisteredTableEntry_method() {
                IsRegisteredTableEntry_ptr = Main.GetMethodUFunction(KismetStringTableLibrary.StaticClass, "IsRegisteredTableEntry");
            }

            internal static unsafe bool Invoke(Name TableId, string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = TableId;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Key.Length;
                *(int*)(b+IntPtr.Size+4+16) = Key.Length;
                Main.GetProcessEvent(KismetStringTableLibrary.DefaultObject, IsRegisteredTableEntry_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct IsRegisteredTableId_method {
            static internal IntPtr IsRegisteredTableId_ptr;
            static IsRegisteredTableId_method() {
                IsRegisteredTableId_ptr = Main.GetMethodUFunction(KismetStringTableLibrary.StaticClass, "IsRegisteredTableId");
            }

            internal static unsafe bool Invoke(Name TableId) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = TableId;
                Main.GetProcessEvent(KismetStringTableLibrary.DefaultObject, IsRegisteredTableId_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
    }
    internal unsafe struct KismetStringTableLibrary_events {
    }
}
