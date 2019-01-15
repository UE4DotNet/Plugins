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
    ///<summary>Kismet String Table Library</summary>
    public unsafe partial class KismetStringTableLibrary : BlueprintFunctionLibrary  {

        ///<summary>Returns an array of all keys within the given string table</summary>
        public static IReadOnlyCollection<string> GetKeysFromStringTable(Name TableId)  => 
            KismetStringTableLibrary_methods.GetKeysFromStringTable_method.Invoke(TableId);

        ///<summary>Returns an array of all meta-data IDs within the given string table entry</summary>
        public static IReadOnlyCollection<Name> GetMetaDataIdsFromStringTableEntry(Name TableId, string Key)  => 
            KismetStringTableLibrary_methods.GetMetaDataIdsFromStringTableEntry_method.Invoke(TableId, Key);

        ///<summary>Returns an array of all registered string table IDs</summary>
        public static IReadOnlyCollection<Name> GetRegisteredStringTables()  => 
            KismetStringTableLibrary_methods.GetRegisteredStringTables_method.Invoke();

        ///<summary>Returns the specified meta-data of the given string table entry (or an empty string).</summary>
        public static string GetTableEntryMetaData(Name TableId, string Key, Name MetaDataId)  => 
            KismetStringTableLibrary_methods.GetTableEntryMetaData_method.Invoke(TableId, Key, MetaDataId);

        ///<summary>Returns the source string of the given string table entry (or an empty string).</summary>
        public static string GetTableEntrySourceString(Name TableId, string Key)  => 
            KismetStringTableLibrary_methods.GetTableEntrySourceString_method.Invoke(TableId, Key);

        ///<summary>Returns the namespace of the given string table.</summary>
        public static string GetTableNamespace(Name TableId)  => 
            KismetStringTableLibrary_methods.GetTableNamespace_method.Invoke(TableId);

        ///<summary>Returns true if the given table ID corresponds to a registered string table, and that table has.</summary>
        public static bool IsRegisteredTableEntry(Name TableId, string Key)  => 
            KismetStringTableLibrary_methods.IsRegisteredTableEntry_method.Invoke(TableId, Key);

        ///<summary>Returns true if the given table ID corresponds to a registered string table.</summary>
        public static bool IsRegisteredTableId(Name TableId)  => 
            KismetStringTableLibrary_methods.IsRegisteredTableId_method.Invoke(TableId);
        static KismetStringTableLibrary() {
            StaticClass = Main.GetClass("KismetStringTableLibrary");
        }
        internal unsafe KismetStringTableLibrary_fields* KismetStringTableLibrary_ptr => (KismetStringTableLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetStringTableLibrary(IntPtr p) => UObject.Make<KismetStringTableLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetStringTableLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetStringTableLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
