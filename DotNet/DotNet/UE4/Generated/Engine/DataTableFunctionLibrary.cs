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

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Data Table Function Library</summary>
    public unsafe partial class DataTableFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Evaluate Curve Table Row</summary>
        public static (byte, float) EvaluateCurveTableRow(CurveTable CurveTable, Name RowName, float InXY, string ContextString)  => 
            DataTableFunctionLibrary_methods.EvaluateCurveTableRow_method.Invoke(CurveTable, RowName, InXY, ContextString);

        ///<summary>Empty and fill a Data Table from CSV file.</summary>
        ///<remarks>
        ///@param       CSVFilePath     The file path of the CSV file.
        ///@return      True if the operation succeeds, check the log for errors if it didn't succeed.
        ///</remarks>
        public static bool FillDataTableFromCSVFile(DataTable DataTable, string CSVFilePath)  => 
            DataTableFunctionLibrary_methods.FillDataTableFromCSVFile_method.Invoke(DataTable, CSVFilePath);

        ///<summary>Empty and fill a Data Table from CSV string.</summary>
        ///<remarks>
        ///@param       CSVString       The Data that representing the contents of a CSV file.
        ///@return      True if the operation succeeds, check the log for errors if it didn't succeed.
        ///</remarks>
        public static bool FillDataTableFromCSVString(DataTable DataTable, string CSVString)  => 
            DataTableFunctionLibrary_methods.FillDataTableFromCSVString_method.Invoke(DataTable, CSVString);

        ///<summary>Empty and fill a Data Table from JSON file.</summary>
        ///<remarks>
        ///@param       JSONFilePath    The file path of the JSON file.
        ///@return      True if the operation succeeds, check the log for errors if it didn't succeed.
        ///</remarks>
        public static bool FillDataTableFromJSONFile(DataTable DataTable, string JSONFilePath)  => 
            DataTableFunctionLibrary_methods.FillDataTableFromJSONFile_method.Invoke(DataTable, JSONFilePath);

        ///<summary>Empty and fill a Data Table from JSON string.</summary>
        ///<remarks>
        ///@param       JSONString      The Data that representing the contents of a JSON file.
        ///@return      True if the operation succeeds, check the log for errors if it didn't succeed.
        ///</remarks>
        public static bool FillDataTableFromJSONString(DataTable DataTable, string JSONString)  => 
            DataTableFunctionLibrary_methods.FillDataTableFromJSONString_method.Invoke(DataTable, JSONString);

        ///<summary>Export from the DataTable all the row for one column. Export it as string. The row name is not included.</summary>
        public static IReadOnlyCollection<string> GetDataTableColumnAsString(DataTable DataTable, Name PropertyName)  => 
            DataTableFunctionLibrary_methods.GetDataTableColumnAsString_method.Invoke(DataTable, PropertyName);

        ///<summary>Get a Row from a DataTable given a RowName</summary>
        public static (TableRowBase, bool) GetDataTableRowFromName(DataTable Table, Name RowName)  => 
            DataTableFunctionLibrary_methods.GetDataTableRowFromName_method.Invoke(Table, RowName);

        ///<summary>Get Data Table Row Names</summary>
        public static IReadOnlyCollection<Name> GetDataTableRowNames(DataTable Table)  => 
            DataTableFunctionLibrary_methods.GetDataTableRowNames_method.Invoke(Table);
        static DataTableFunctionLibrary() {
            StaticClass = Main.GetClass("DataTableFunctionLibrary");
        }
        internal unsafe DataTableFunctionLibrary_fields* DataTableFunctionLibrary_ptr => (DataTableFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DataTableFunctionLibrary(IntPtr p) => UObject.Make<DataTableFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DataTableFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DataTableFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
