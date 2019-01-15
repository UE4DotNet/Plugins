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
    ///<summary>Exporter</summary>
    public unsafe partial class Exporter : UObject  {

        ///<summary>Export the given object to file.</summary>
        ///<remarks>
        ///Child classes do not override this, but they do provide an Export() function
        ///to do the resource-specific export work.
        ///
        ///@param        Task            The task to export.
        ///
        ///@return       true if the the object was successfully exported
        ///</remarks>
        public static bool RunAssetExportTask(AssetExportTask Task)  => 
            Exporter_methods.RunAssetExportTask_method.Invoke(Task);

        ///<summary>Export the given objects to files.</summary>
        ///<remarks>
        ///Child classes do not override this, but they do provide an Export() function
        ///to do the resource-specific export work.
        ///
        ///@param       ExportTasks             The array of tasks to export.
        ///
        ///@return      true if all tasks ran without error
        ///</remarks>
        public static bool RunAssetExportTasks(byte ExportTasks /*TODO: array TArray */)  => 
            Exporter_methods.RunAssetExportTasks_method.Invoke(ExportTasks);
        ///<summary>Supported class of this exporter</summary>
        public unsafe SubclassOf<UObject> SupportedClass {
            get {return Exporter_ptr->SupportedClass;}
            set {Exporter_ptr->SupportedClass = value;}
        }
        ///<summary>The root scope of objects to be exported, only used if PPF_ExportsNotFullyQualfied is set</summary>
        ///<remarks>Objects being exported that are contained within ExportRootScope will use just their name instead of a full path</remarks>
        public unsafe UObject ExportRootScope {
            get {return Exporter_ptr->ExportRootScope;}
            set {Exporter_ptr->ExportRootScope = value;}
        }
         //TODO: array not UObject TArray FormatExtension
         //TODO: array not UObject TArray FormatDescription
        ///<summary>Index into FormatExtension/FormatDescription of the preferred export format.</summary>
        public unsafe int PreferredFormatIndex {
            get {return Exporter_ptr->PreferredFormatIndex;}
            set {Exporter_ptr->PreferredFormatIndex = value;}
        }
        ///<summary>Current indentation of spaces of the exported text</summary>
        public unsafe int TextIndent {
            get {return Exporter_ptr->TextIndent;}
            set {Exporter_ptr->TextIndent = value;}
        }
        public bool bText {
            get {return Main.GetGetBoolPropertyByName(this, "bText"); }
            set {Main.SetGetBoolPropertyByName(this, "bText", value); }
        }
        public bool bSelectedOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bSelectedOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bSelectedOnly", value); }
        }
        public bool bForceFileOperations {
            get {return Main.GetGetBoolPropertyByName(this, "bForceFileOperations"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceFileOperations", value); }
        }
        ///<summary>Export Task</summary>
        public unsafe AssetExportTask ExportTask {
            get {return Exporter_ptr->ExportTask;}
            set {Exporter_ptr->ExportTask = value;}
        }
        static Exporter() {
            StaticClass = Main.GetClass("Exporter");
        }
        internal unsafe Exporter_fields* Exporter_ptr => (Exporter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Exporter(IntPtr p) => UObject.Make<Exporter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Exporter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Exporter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
