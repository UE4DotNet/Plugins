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
    internal unsafe struct DataTableFunctionLibrary_fields {
    }
    internal unsafe struct DataTableFunctionLibrary_methods {
        internal struct DoesDataTableRowExist_method {
            static internal IntPtr DoesDataTableRowExist_ptr;
            static DoesDataTableRowExist_method() {
                DoesDataTableRowExist_ptr = Main.GetMethodUFunction(DataTableFunctionLibrary.StaticClass, "DoesDataTableRowExist");
            }

            internal static unsafe bool Invoke(DataTable Table, Name RowName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Table;
                *((Name*)(b+8)) = RowName;
                Main.GetProcessEvent(DataTableFunctionLibrary.DefaultObject, DoesDataTableRowExist_ptr, new IntPtr(p)); ;
                return *((bool*)(b+20));
            }
        }
        internal struct EvaluateCurveTableRow_method {
            static internal IntPtr EvaluateCurveTableRow_ptr;
            static EvaluateCurveTableRow_method() {
                EvaluateCurveTableRow_ptr = Main.GetMethodUFunction(DataTableFunctionLibrary.StaticClass, "EvaluateCurveTableRow");
            }

            internal static unsafe (byte, float) Invoke(CurveTable CurveTable, Name RowName, float InXY, string ContextString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = CurveTable;
                *((Name*)(b+8)) = RowName;
                *((float*)(b+20)) = InXY;
                var ContextString_handle = GCHandle.Alloc(ContextString, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = ContextString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = ContextString.Length;
                *(int*)(b+IntPtr.Size+4+32) = ContextString.Length;
                Main.GetProcessEvent(DataTableFunctionLibrary.DefaultObject, EvaluateCurveTableRow_ptr, new IntPtr(p)); ;
                ContextString_handle.Free();
                return (*(b+24),*((float*)(b+28)));
            }
        }
        internal struct FillDataTableFromCSVFile_method {
            static internal IntPtr FillDataTableFromCSVFile_ptr;
            static FillDataTableFromCSVFile_method() {
                FillDataTableFromCSVFile_ptr = Main.GetMethodUFunction(DataTableFunctionLibrary.StaticClass, "FillDataTableFromCSVFile");
            }

            internal static unsafe bool Invoke(DataTable DataTable, string CSVFilePath) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = DataTable;
                var CSVFilePath_handle = GCHandle.Alloc(CSVFilePath, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = CSVFilePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = CSVFilePath.Length;
                *(int*)(b+IntPtr.Size+4+8) = CSVFilePath.Length;
                Main.GetProcessEvent(DataTableFunctionLibrary.DefaultObject, FillDataTableFromCSVFile_ptr, new IntPtr(p)); ;
                CSVFilePath_handle.Free();
                return *((bool*)(b+24));
            }
        }
        internal struct FillDataTableFromCSVString_method {
            static internal IntPtr FillDataTableFromCSVString_ptr;
            static FillDataTableFromCSVString_method() {
                FillDataTableFromCSVString_ptr = Main.GetMethodUFunction(DataTableFunctionLibrary.StaticClass, "FillDataTableFromCSVString");
            }

            internal static unsafe bool Invoke(DataTable DataTable, string CSVString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = DataTable;
                var CSVString_handle = GCHandle.Alloc(CSVString, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = CSVString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = CSVString.Length;
                *(int*)(b+IntPtr.Size+4+8) = CSVString.Length;
                Main.GetProcessEvent(DataTableFunctionLibrary.DefaultObject, FillDataTableFromCSVString_ptr, new IntPtr(p)); ;
                CSVString_handle.Free();
                return *((bool*)(b+24));
            }
        }
        internal struct FillDataTableFromJSONFile_method {
            static internal IntPtr FillDataTableFromJSONFile_ptr;
            static FillDataTableFromJSONFile_method() {
                FillDataTableFromJSONFile_ptr = Main.GetMethodUFunction(DataTableFunctionLibrary.StaticClass, "FillDataTableFromJSONFile");
            }

            internal static unsafe bool Invoke(DataTable DataTable, string JSONFilePath) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = DataTable;
                var JSONFilePath_handle = GCHandle.Alloc(JSONFilePath, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = JSONFilePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = JSONFilePath.Length;
                *(int*)(b+IntPtr.Size+4+8) = JSONFilePath.Length;
                Main.GetProcessEvent(DataTableFunctionLibrary.DefaultObject, FillDataTableFromJSONFile_ptr, new IntPtr(p)); ;
                JSONFilePath_handle.Free();
                return *((bool*)(b+24));
            }
        }
        internal struct FillDataTableFromJSONString_method {
            static internal IntPtr FillDataTableFromJSONString_ptr;
            static FillDataTableFromJSONString_method() {
                FillDataTableFromJSONString_ptr = Main.GetMethodUFunction(DataTableFunctionLibrary.StaticClass, "FillDataTableFromJSONString");
            }

            internal static unsafe bool Invoke(DataTable DataTable, string JSONString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = DataTable;
                var JSONString_handle = GCHandle.Alloc(JSONString, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = JSONString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = JSONString.Length;
                *(int*)(b+IntPtr.Size+4+8) = JSONString.Length;
                Main.GetProcessEvent(DataTableFunctionLibrary.DefaultObject, FillDataTableFromJSONString_ptr, new IntPtr(p)); ;
                JSONString_handle.Free();
                return *((bool*)(b+24));
            }
        }
        internal struct GetDataTableColumnAsString_method {
            static internal IntPtr GetDataTableColumnAsString_ptr;
            static GetDataTableColumnAsString_method() {
                GetDataTableColumnAsString_ptr = Main.GetMethodUFunction(DataTableFunctionLibrary.StaticClass, "GetDataTableColumnAsString");
            }

            internal static unsafe IReadOnlyCollection<string> Invoke(DataTable DataTable, Name PropertyName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = DataTable;
                *((Name*)(b+8)) = PropertyName;
                Main.GetProcessEvent(DataTableFunctionLibrary.DefaultObject, GetDataTableColumnAsString_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToStringCollection(b+24);
            }
        }
        internal struct GetDataTableRowFromName_method {
            static internal IntPtr GetDataTableRowFromName_ptr;
            static GetDataTableRowFromName_method() {
                GetDataTableRowFromName_ptr = Main.GetMethodUFunction(DataTableFunctionLibrary.StaticClass, "GetDataTableRowFromName");
            }

            internal static unsafe (TableRowBase, bool) Invoke(DataTable Table, Name RowName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Table;
                *((Name*)(b+8)) = RowName;
                Main.GetProcessEvent(DataTableFunctionLibrary.DefaultObject, GetDataTableRowFromName_ptr, new IntPtr(p)); ;
                return (*((TableRowBase*)(b+24)),*((bool*)(b+32)));
            }
        }
        internal struct GetDataTableRowNames_method {
            static internal IntPtr GetDataTableRowNames_ptr;
            static GetDataTableRowNames_method() {
                GetDataTableRowNames_ptr = Main.GetMethodUFunction(DataTableFunctionLibrary.StaticClass, "GetDataTableRowNames");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(DataTable Table) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Table;
                Main.GetProcessEvent(DataTableFunctionLibrary.DefaultObject, GetDataTableRowNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutRowNames
                return UObject.ToUnmangedCollection<Name>(b+8);
            }
        }
    }
    internal unsafe struct DataTableFunctionLibrary_events {
    }
}
