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


namespace UE4.DatasmithContent.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct DatasmithContentBlueprintLibrary_fields {
    }
    internal unsafe struct DatasmithContentBlueprintLibrary_methods {
        internal struct GetAllDatasmithUserData_method {
            static internal IntPtr GetAllDatasmithUserData_ptr;
            static GetAllDatasmithUserData_method() {
                GetAllDatasmithUserData_ptr = Main.GetMethodUFunction(DatasmithContentBlueprintLibrary.StaticClass, "GetAllDatasmithUserData");
            }

            internal static unsafe IReadOnlyCollection<DatasmithAssetUserData> Invoke(SubclassOf<UObject> ObjectClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ObjectClass;
                Main.GetProcessEvent(DatasmithContentBlueprintLibrary.DefaultObject, GetAllDatasmithUserData_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutUserData
                return UObject.ToUObjectCollection<DatasmithAssetUserData>(b+8);
            }
        }
        internal struct GetAllObjectsAndValuesForKey_method {
            static internal IntPtr GetAllObjectsAndValuesForKey_ptr;
            static GetAllObjectsAndValuesForKey_method() {
                GetAllObjectsAndValuesForKey_ptr = Main.GetMethodUFunction(DatasmithContentBlueprintLibrary.StaticClass, "GetAllObjectsAndValuesForKey");
            }

            internal static unsafe (IReadOnlyCollection<UObject>, IReadOnlyCollection<string>) Invoke(Name Key, SubclassOf<UObject> ObjectClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = Key;
                *((IntPtr*)(b+16)) = ObjectClass;
                Main.GetProcessEvent(DatasmithContentBlueprintLibrary.DefaultObject, GetAllObjectsAndValuesForKey_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutObjects
                 //TODO: array TArray OutValues
                return (UObject.ToUObjectCollection<UObject>(b+24),UObject.ToStringCollection(b+40));
            }
        }
        internal struct GetDatasmithUserData_method {
            static internal IntPtr GetDatasmithUserData_ptr;
            static GetDatasmithUserData_method() {
                GetDatasmithUserData_ptr = Main.GetMethodUFunction(DatasmithContentBlueprintLibrary.StaticClass, "GetDatasmithUserData");
            }

            internal static unsafe DatasmithAssetUserData Invoke(UObject UObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                Main.GetProcessEvent(DatasmithContentBlueprintLibrary.DefaultObject, GetDatasmithUserData_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetDatasmithUserDataKeysAndValuesForValue_method {
            static internal IntPtr GetDatasmithUserDataKeysAndValuesForValue_ptr;
            static GetDatasmithUserDataKeysAndValuesForValue_method() {
                GetDatasmithUserDataKeysAndValuesForValue_ptr = Main.GetMethodUFunction(DatasmithContentBlueprintLibrary.StaticClass, "GetDatasmithUserDataKeysAndValuesForValue");
            }

            internal static unsafe (IReadOnlyCollection<Name>, IReadOnlyCollection<string>) Invoke(UObject UObject, string StringToMatch) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                var StringToMatch_handle = GCHandle.Alloc(StringToMatch, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = StringToMatch_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = StringToMatch.Length;
                *(int*)(b+IntPtr.Size+4+8) = StringToMatch.Length;
                Main.GetProcessEvent(DatasmithContentBlueprintLibrary.DefaultObject, GetDatasmithUserDataKeysAndValuesForValue_ptr, new IntPtr(p)); ;
                StringToMatch_handle.Free();
                 //TODO: array TArray OutKeys
                 //TODO: array TArray OutValues
                return (UObject.ToUnmangedCollection<Name>(b+24),UObject.ToStringCollection(b+40));
            }
        }
        internal struct GetDatasmithUserDataValueForKey_method {
            static internal IntPtr GetDatasmithUserDataValueForKey_ptr;
            static GetDatasmithUserDataValueForKey_method() {
                GetDatasmithUserDataValueForKey_ptr = Main.GetMethodUFunction(DatasmithContentBlueprintLibrary.StaticClass, "GetDatasmithUserDataValueForKey");
            }

            internal static unsafe string Invoke(UObject UObject, Name Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = Key;
                Main.GetProcessEvent(DatasmithContentBlueprintLibrary.DefaultObject, GetDatasmithUserDataValueForKey_ptr, new IntPtr(p)); ;
                return FString.Get(b+24);
            }
        }
    }
    internal unsafe struct DatasmithContentBlueprintLibrary_events {
    }
}
