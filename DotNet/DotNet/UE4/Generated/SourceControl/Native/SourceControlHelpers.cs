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


namespace UE4.SourceControl.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct SourceControlHelpers_fields {
    }
    internal unsafe struct SourceControlHelpers_methods {
        internal struct CheckInFile_method {
            static internal IntPtr CheckInFile_ptr;
            static CheckInFile_method() {
                CheckInFile_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "CheckInFile");
            }

            internal static unsafe bool Invoke(string InFile, string InDescription, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InFile_handle = GCHandle.Alloc(InFile, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InFile_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InFile.Length;
                *(int*)(b+IntPtr.Size+4+0) = InFile.Length;
                var InDescription_handle = GCHandle.Alloc(InDescription, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = InDescription_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = InDescription.Length;
                *(int*)(b+IntPtr.Size+4+16) = InDescription.Length;
                *((bool*)(b+32)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, CheckInFile_ptr, new IntPtr(p)); ;
                InFile_handle.Free();
                InDescription_handle.Free();
                return *((bool*)(b+33));
            }
        }
        internal struct CheckInFiles_method {
            static internal IntPtr CheckInFiles_ptr;
            static CheckInFiles_method() {
                CheckInFiles_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "CheckInFiles");
            }

            internal static unsafe bool Invoke(byte InFiles /*TODO: array TArray */, string InDescription, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray InFiles
                var InDescription_handle = GCHandle.Alloc(InDescription, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = InDescription_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = InDescription.Length;
                *(int*)(b+IntPtr.Size+4+16) = InDescription.Length;
                *((bool*)(b+32)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, CheckInFiles_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InFiles
                InDescription_handle.Free();
                return *((bool*)(b+33));
            }
        }
        internal struct CheckOutFile_method {
            static internal IntPtr CheckOutFile_ptr;
            static CheckOutFile_method() {
                CheckOutFile_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "CheckOutFile");
            }

            internal static unsafe bool Invoke(string InFile, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InFile_handle = GCHandle.Alloc(InFile, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InFile_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InFile.Length;
                *(int*)(b+IntPtr.Size+4+0) = InFile.Length;
                *((bool*)(b+16)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, CheckOutFile_ptr, new IntPtr(p)); ;
                InFile_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct CheckOutFiles_method {
            static internal IntPtr CheckOutFiles_ptr;
            static CheckOutFiles_method() {
                CheckOutFiles_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "CheckOutFiles");
            }

            internal static unsafe bool Invoke(byte InFiles /*TODO: array TArray */, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray InFiles
                *((bool*)(b+16)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, CheckOutFiles_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InFiles
                return *((bool*)(b+17));
            }
        }
        internal struct CheckOutOrAddFile_method {
            static internal IntPtr CheckOutOrAddFile_ptr;
            static CheckOutOrAddFile_method() {
                CheckOutOrAddFile_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "CheckOutOrAddFile");
            }

            internal static unsafe bool Invoke(string InFile, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InFile_handle = GCHandle.Alloc(InFile, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InFile_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InFile.Length;
                *(int*)(b+IntPtr.Size+4+0) = InFile.Length;
                *((bool*)(b+16)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, CheckOutOrAddFile_ptr, new IntPtr(p)); ;
                InFile_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct CopyFile_method {
            static internal IntPtr CopyFile_ptr;
            static CopyFile_method() {
                CopyFile_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "CopyFile");
            }

            internal static unsafe bool Invoke(string InSourceFile, string InDestFile, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InSourceFile_handle = GCHandle.Alloc(InSourceFile, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InSourceFile_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InSourceFile.Length;
                *(int*)(b+IntPtr.Size+4+0) = InSourceFile.Length;
                var InDestFile_handle = GCHandle.Alloc(InDestFile, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = InDestFile_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = InDestFile.Length;
                *(int*)(b+IntPtr.Size+4+16) = InDestFile.Length;
                *((bool*)(b+32)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, CopyFile_ptr, new IntPtr(p)); ;
                InSourceFile_handle.Free();
                InDestFile_handle.Free();
                return *((bool*)(b+33));
            }
        }
        internal struct CurrentProvider_method {
            static internal IntPtr CurrentProvider_ptr;
            static CurrentProvider_method() {
                CurrentProvider_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "CurrentProvider");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, CurrentProvider_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct IsAvailable_method {
            static internal IntPtr IsAvailable_ptr;
            static IsAvailable_method() {
                IsAvailable_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "IsAvailable");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, IsAvailable_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsEnabled_method {
            static internal IntPtr IsEnabled_ptr;
            static IsEnabled_method() {
                IsEnabled_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "IsEnabled");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, IsEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct LastErrorMsg_method {
            static internal IntPtr LastErrorMsg_ptr;
            static LastErrorMsg_method() {
                LastErrorMsg_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "LastErrorMsg");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, LastErrorMsg_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct MarkFileForAdd_method {
            static internal IntPtr MarkFileForAdd_ptr;
            static MarkFileForAdd_method() {
                MarkFileForAdd_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "MarkFileForAdd");
            }

            internal static unsafe bool Invoke(string InFile, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InFile_handle = GCHandle.Alloc(InFile, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InFile_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InFile.Length;
                *(int*)(b+IntPtr.Size+4+0) = InFile.Length;
                *((bool*)(b+16)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, MarkFileForAdd_ptr, new IntPtr(p)); ;
                InFile_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct MarkFileForDelete_method {
            static internal IntPtr MarkFileForDelete_ptr;
            static MarkFileForDelete_method() {
                MarkFileForDelete_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "MarkFileForDelete");
            }

            internal static unsafe bool Invoke(string InFile, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InFile_handle = GCHandle.Alloc(InFile, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InFile_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InFile.Length;
                *(int*)(b+IntPtr.Size+4+0) = InFile.Length;
                *((bool*)(b+16)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, MarkFileForDelete_ptr, new IntPtr(p)); ;
                InFile_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct MarkFilesForAdd_method {
            static internal IntPtr MarkFilesForAdd_ptr;
            static MarkFilesForAdd_method() {
                MarkFilesForAdd_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "MarkFilesForAdd");
            }

            internal static unsafe bool Invoke(byte InFiles /*TODO: array TArray */, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray InFiles
                *((bool*)(b+16)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, MarkFilesForAdd_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InFiles
                return *((bool*)(b+17));
            }
        }
        internal struct QueryFileState_method {
            static internal IntPtr QueryFileState_ptr;
            static QueryFileState_method() {
                QueryFileState_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "QueryFileState");
            }

            internal static unsafe SourceControlState Invoke(string InFile, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InFile_handle = GCHandle.Alloc(InFile, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InFile_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InFile.Length;
                *(int*)(b+IntPtr.Size+4+0) = InFile.Length;
                *((bool*)(b+16)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, QueryFileState_ptr, new IntPtr(p)); ;
                InFile_handle.Free();
                return *((SourceControlState*)(b+24));
            }
        }
        internal struct RevertFile_method {
            static internal IntPtr RevertFile_ptr;
            static RevertFile_method() {
                RevertFile_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "RevertFile");
            }

            internal static unsafe bool Invoke(string InFile, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InFile_handle = GCHandle.Alloc(InFile, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InFile_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InFile.Length;
                *(int*)(b+IntPtr.Size+4+0) = InFile.Length;
                *((bool*)(b+16)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, RevertFile_ptr, new IntPtr(p)); ;
                InFile_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct RevertFiles_method {
            static internal IntPtr RevertFiles_ptr;
            static RevertFiles_method() {
                RevertFiles_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "RevertFiles");
            }

            internal static unsafe bool Invoke(byte InFiles /*TODO: array TArray */, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray InFiles
                *((bool*)(b+16)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, RevertFiles_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InFiles
                return *((bool*)(b+17));
            }
        }
        internal struct RevertUnchangedFile_method {
            static internal IntPtr RevertUnchangedFile_ptr;
            static RevertUnchangedFile_method() {
                RevertUnchangedFile_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "RevertUnchangedFile");
            }

            internal static unsafe bool Invoke(string InFile, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InFile_handle = GCHandle.Alloc(InFile, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InFile_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InFile.Length;
                *(int*)(b+IntPtr.Size+4+0) = InFile.Length;
                *((bool*)(b+16)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, RevertUnchangedFile_ptr, new IntPtr(p)); ;
                InFile_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct RevertUnchangedFiles_method {
            static internal IntPtr RevertUnchangedFiles_ptr;
            static RevertUnchangedFiles_method() {
                RevertUnchangedFiles_ptr = Main.GetMethodUFunction(SourceControlHelpers.StaticClass, "RevertUnchangedFiles");
            }

            internal static unsafe bool Invoke(byte InFiles /*TODO: array TArray */, bool bSilent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray InFiles
                *((bool*)(b+16)) = bSilent;
                Main.GetProcessEvent(SourceControlHelpers.DefaultObject, RevertUnchangedFiles_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InFiles
                return *((bool*)(b+17));
            }
        }
    }
    internal unsafe struct SourceControlHelpers_events {
    }
}
