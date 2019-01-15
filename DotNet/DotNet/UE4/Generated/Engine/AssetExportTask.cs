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
    ///<summary>Contains data for a group of assets to import</summary>
    public unsafe partial class AssetExportTask : UObject  {
        ///<summary>Asset to export</summary>
        public unsafe UObject UObject {
            get {return AssetExportTask_ptr->UObject;}
            set {AssetExportTask_ptr->UObject = value;}
        }
        ///<summary>Optional exporter, otherwise it will be determined automatically</summary>
        public unsafe Exporter Exporter {
            get {return AssetExportTask_ptr->Exporter;}
            set {AssetExportTask_ptr->Exporter = value;}
        }
         //TODO: string FString Filename
        public bool bSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bSelected", value); }
        }
        public bool bReplaceIdentical {
            get {return Main.GetGetBoolPropertyByName(this, "bReplaceIdentical"); }
            set {Main.SetGetBoolPropertyByName(this, "bReplaceIdentical", value); }
        }
        public bool bPrompt {
            get {return Main.GetGetBoolPropertyByName(this, "bPrompt"); }
            set {Main.SetGetBoolPropertyByName(this, "bPrompt", value); }
        }
        public bool bAutomated {
            get {return Main.GetGetBoolPropertyByName(this, "bAutomated"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutomated", value); }
        }
        public bool bUseFileArchive {
            get {return Main.GetGetBoolPropertyByName(this, "bUseFileArchive"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseFileArchive", value); }
        }
        public bool bWriteEmptyFiles {
            get {return Main.GetGetBoolPropertyByName(this, "bWriteEmptyFiles"); }
            set {Main.SetGetBoolPropertyByName(this, "bWriteEmptyFiles", value); }
        }
        ///<summary>Array of objects to ignore exporting</summary>
        public ObjectArrayField<UObject> IgnoreObjectList{ get {
            if(IgnoreObjectList_store == null) IgnoreObjectList_store = new ObjectArrayField<UObject> (&AssetExportTask_ptr->IgnoreObjectList);
            return IgnoreObjectList_store;
        } }
        private ObjectArrayField<UObject> IgnoreObjectList_store;

        ///<summary>Exporter specific options</summary>
        public unsafe UObject Options {
            get {return AssetExportTask_ptr->Options;}
            set {AssetExportTask_ptr->Options = value;}
        }
         //TODO: array not UObject TArray Errors
        static AssetExportTask() {
            StaticClass = Main.GetClass("AssetExportTask");
        }
        internal unsafe AssetExportTask_fields* AssetExportTask_ptr => (AssetExportTask_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AssetExportTask(IntPtr p) => UObject.Make<AssetExportTask>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AssetExportTask DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AssetExportTask New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
