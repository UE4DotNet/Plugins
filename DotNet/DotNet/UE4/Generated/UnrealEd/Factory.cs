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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>
    ///Base class for all factories
    ///An object responsible for creating and importing new objects.
    ///</summary>
    public unsafe partial class Factory : UObject  {
        public bool bCreateNew {
            get {return Main.GetGetBoolPropertyByName(this, "bCreateNew"); }
            set {Main.SetGetBoolPropertyByName(this, "bCreateNew", value); }
        }
        ///<summary>The class manufactured by this factory.</summary>
        public unsafe SubclassOf<UObject> SupportedClass {
            get {return Factory_ptr->SupportedClass;}
            set {Factory_ptr->SupportedClass = value;}
        }
        ///<summary>Class of the context object used to help create the object.</summary>
        public unsafe SubclassOf<UObject> ContextClass {
            get {return Factory_ptr->ContextClass;}
            set {Factory_ptr->ContextClass = value;}
        }
         //TODO: array not UObject TArray Formats
        public bool bEditAfterNew {
            get {return Main.GetGetBoolPropertyByName(this, "bEditAfterNew"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditAfterNew", value); }
        }
        public bool bEditorImport {
            get {return Main.GetGetBoolPropertyByName(this, "bEditorImport"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditorImport", value); }
        }
        public bool bText {
            get {return Main.GetGetBoolPropertyByName(this, "bText"); }
            set {Main.SetGetBoolPropertyByName(this, "bText", value); }
        }
        ///<summary>Determines the order in which factories are tried when importing or reimporting an object.</summary>
        ///<remarks>Factories with higher priority values will go first. Factories with negative priorities will be excluded.</remarks>
        public unsafe int ImportPriority {
            get {return Factory_ptr->ImportPriority;}
            set {Factory_ptr->ImportPriority = value;}
        }
        ///<summary>Data for how to import files via the automated command line importing interface</summary>
        public unsafe AutomatedAssetImportData AutomatedImportData {
            get {return Factory_ptr->AutomatedImportData;}
            set {Factory_ptr->AutomatedImportData = value;}
        }
        ///<summary>Task for importing file via script interfaces</summary>
        public unsafe AssetImportTask AssetImportTask {
            get {return Factory_ptr->AssetImportTask;}
            set {Factory_ptr->AssetImportTask = value;}
        }
        ///<summary>
        ///For interactive object imports, this value indicates whether the user wants
        ///objects to be automatically overwritten (See EAppReturnType), or -1 if the
        ///user should be prompted.
        ///</summary>
        public unsafe int OverwriteYesOrNoToAllState {
            get {return Factory_ptr->OverwriteYesOrNoToAllState;}
            set {Factory_ptr->OverwriteYesOrNoToAllState = value;}
        }
        static Factory() {
            StaticClass = Main.GetClass("Factory");
        }
        internal unsafe Factory_fields* Factory_ptr => (Factory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Factory(IntPtr p) => UObject.Make<Factory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Factory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Factory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
