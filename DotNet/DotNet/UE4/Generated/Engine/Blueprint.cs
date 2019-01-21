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
    ///<summary>
    ///Blueprints are special assets that provide an intuitive, node-based interface that can be used to create new types of Actors
    ///and script level events; giving designers and gameplay programmers the tools to quickly create and iterate gameplay from
    ///within Unreal Editor without ever needing to write a line of code.
    ///</summary>
    public unsafe partial class Blueprint : BlueprintCore  {
        public bool bRecompileOnLoad {
            get {return Main.GetGetBoolPropertyByName(this, "bRecompileOnLoad"); }
            set {Main.SetGetBoolPropertyByName(this, "bRecompileOnLoad", value); }
        }
        ///<summary>Pointer to the parent class that the generated class should derive from.</summary>
        ///<remarks>
        ///This *can* be null under rare circumstances,
        ///one such case can be created by creating a blueprint (A) based on another blueprint (B), shutting down the editor, and
        ///deleting the parent blueprint. Exported as Alphabetical in GetAssetRegistryTags
        ///</remarks>
        public unsafe SubclassOf<UObject> ParentClass {
            get {return Blueprint_ptr->ParentClass;}
            set {Blueprint_ptr->ParentClass = value;}
        }
        ///<summary>PRIVATE Innermost Previous CDO</summary>
        public unsafe UObject PRIVATE_InnermostPreviousCDO {
            get {return Blueprint_ptr->PRIVATE_InnermostPreviousCDO;}
            set {Blueprint_ptr->PRIVATE_InnermostPreviousCDO = value;}
        }
        public bool bHasBeenRegenerated {
            get {return Main.GetGetBoolPropertyByName(this, "bHasBeenRegenerated"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasBeenRegenerated", value); }
        }
        public bool bIsRegeneratingOnLoad {
            get {return Main.GetGetBoolPropertyByName(this, "bIsRegeneratingOnLoad"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsRegeneratingOnLoad", value); }
        }
        public bool bIsNewlyCreated {
            get {return Main.GetGetBoolPropertyByName(this, "bIsNewlyCreated"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsNewlyCreated", value); }
        }
        public bool bForceFullEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bForceFullEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceFullEditor", value); }
        }
        public bool bQueuedForCompilation {
            get {return Main.GetGetBoolPropertyByName(this, "bQueuedForCompilation"); }
            set {Main.SetGetBoolPropertyByName(this, "bQueuedForCompilation", value); }
        }
        public bool bRunConstructionScriptOnDrag {
            get {return Main.GetGetBoolPropertyByName(this, "bRunConstructionScriptOnDrag"); }
            set {Main.SetGetBoolPropertyByName(this, "bRunConstructionScriptOnDrag", value); }
        }
        public bool bRunConstructionScriptInSequencer {
            get {return Main.GetGetBoolPropertyByName(this, "bRunConstructionScriptInSequencer"); }
            set {Main.SetGetBoolPropertyByName(this, "bRunConstructionScriptInSequencer", value); }
        }
        public bool bGenerateConstClass {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateConstClass"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateConstClass", value); }
        }
        public bool bGenerateAbstractClass {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateAbstractClass"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateAbstractClass", value); }
        }
         //TODO: string FString BlueprintDescription
         //TODO: string FString BlueprintCategory
         //TODO: array not UObject TArray HideCategories
         //TODO: enum EBlueprintNativizationFlag NativizationFlag
        public bool bDisplayCompilePIEWarning {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayCompilePIEWarning"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayCompilePIEWarning", value); }
        }
        ///<summary>Guid key for finding searchable data for Blueprint in the DDC</summary>
        public unsafe FGuid SearchGuid {
            get {return Blueprint_ptr->SearchGuid;}
            set {Blueprint_ptr->SearchGuid = value;}
        }
        public bool bDeprecate {
            get {return Main.GetGetBoolPropertyByName(this, "bDeprecate"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeprecate", value); }
        }
         //TODO: enum EBlueprintCompileMode CompileMode
        ///<summary>'Simple' construction script - graph of components to instance</summary>
        public unsafe SimpleConstructionScript SimpleConstructionScript {
            get {return Blueprint_ptr->SimpleConstructionScript;}
            set {Blueprint_ptr->SimpleConstructionScript = value;}
        }
        ///<summary>Set of pages that combine into a single uber-graph</summary>
        public ObjectArrayField<EdGraph> UbergraphPages{ get {
            if(UbergraphPages_store == null) UbergraphPages_store = new ObjectArrayField<EdGraph> (&Blueprint_ptr->UbergraphPages);
            return UbergraphPages_store;
        } }
        private ObjectArrayField<EdGraph> UbergraphPages_store;

        ///<summary>Set of functions implemented for this class graphically</summary>
        public ObjectArrayField<EdGraph> FunctionGraphs{ get {
            if(FunctionGraphs_store == null) FunctionGraphs_store = new ObjectArrayField<EdGraph> (&Blueprint_ptr->FunctionGraphs);
            return FunctionGraphs_store;
        } }
        private ObjectArrayField<EdGraph> FunctionGraphs_store;

        ///<summary>Graphs of signatures for delegates</summary>
        public ObjectArrayField<EdGraph> DelegateSignatureGraphs{ get {
            if(DelegateSignatureGraphs_store == null) DelegateSignatureGraphs_store = new ObjectArrayField<EdGraph> (&Blueprint_ptr->DelegateSignatureGraphs);
            return DelegateSignatureGraphs_store;
        } }
        private ObjectArrayField<EdGraph> DelegateSignatureGraphs_store;

        ///<summary>Set of macros implemented for this class</summary>
        public ObjectArrayField<EdGraph> MacroGraphs{ get {
            if(MacroGraphs_store == null) MacroGraphs_store = new ObjectArrayField<EdGraph> (&Blueprint_ptr->MacroGraphs);
            return MacroGraphs_store;
        } }
        private ObjectArrayField<EdGraph> MacroGraphs_store;

        ///<summary>Set of functions actually compiled for this class</summary>
        public ObjectArrayField<EdGraph> IntermediateGeneratedGraphs{ get {
            if(IntermediateGeneratedGraphs_store == null) IntermediateGeneratedGraphs_store = new ObjectArrayField<EdGraph> (&Blueprint_ptr->IntermediateGeneratedGraphs);
            return IntermediateGeneratedGraphs_store;
        } }
        private ObjectArrayField<EdGraph> IntermediateGeneratedGraphs_store;

        ///<summary>Set of functions actually compiled for this class</summary>
        public ObjectArrayField<EdGraph> EventGraphs{ get {
            if(EventGraphs_store == null) EventGraphs_store = new ObjectArrayField<EdGraph> (&Blueprint_ptr->EventGraphs);
            return EventGraphs_store;
        } }
        private ObjectArrayField<EdGraph> EventGraphs_store;

         //TODO: map TMap PRIVATE_CachedMacroInfo
        public bool bDuplicatingReadOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bDuplicatingReadOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bDuplicatingReadOnly", value); }
        }
        ///<summary>Array of component template objects, used by AddComponent function</summary>
        public ObjectArrayField<ActorComponent> ComponentTemplates{ get {
            if(ComponentTemplates_store == null) ComponentTemplates_store = new ObjectArrayField<ActorComponent> (&Blueprint_ptr->ComponentTemplates);
            return ComponentTemplates_store;
        } }
        private ObjectArrayField<ActorComponent> ComponentTemplates_store;

        ///<summary>Array of templates for timelines that should be created</summary>
        public ObjectArrayField<TimelineTemplate> Timelines{ get {
            if(Timelines_store == null) Timelines_store = new ObjectArrayField<TimelineTemplate> (&Blueprint_ptr->Timelines);
            return Timelines_store;
        } }
        private ObjectArrayField<TimelineTemplate> Timelines_store;

        ///<summary>Stores data to override (in children classes) components (created by SCS) from parent classes</summary>
        public unsafe InheritableComponentHandler InheritableComponentHandler {
            get {return Blueprint_ptr->InheritableComponentHandler;}
            set {Blueprint_ptr->InheritableComponentHandler = value;}
        }
        ///<summary>The type of this blueprint</summary>
        public unsafe byte BlueprintType {
            get {return Blueprint_ptr->BlueprintType;}
            set {Blueprint_ptr->BlueprintType = value;}
        }
        ///<summary>The current status of this blueprint</summary>
        public unsafe byte Status {
            get {return Blueprint_ptr->Status;}
            set {Blueprint_ptr->Status = value;}
        }
         //TODO: array not UObject TArray NewVariables
         //TODO: array not UObject TArray CategorySorting
         //TODO: array not UObject TArray ImplementedInterfaces
        ///<summary>The version of the blueprint system that was used to  create this blueprint</summary>
        public unsafe int BlueprintSystemVersion {
            get {return Blueprint_ptr->BlueprintSystemVersion;}
            set {Blueprint_ptr->BlueprintSystemVersion = value;}
        }
         //TODO: array not UObject TArray LastEditedDocuments
         //TODO: map TMap Bookmarks
         //TODO: array not UObject TArray BookmarkNodes
        ///<summary>Persistent debugging options</summary>
        public ObjectArrayField<Breakpoint> Breakpoints{ get {
            if(Breakpoints_store == null) Breakpoints_store = new ObjectArrayField<Breakpoint> (&Blueprint_ptr->Breakpoints);
            return Breakpoints_store;
        } }
        private ObjectArrayField<Breakpoint> Breakpoints_store;

         //TODO: array not UObject TArray WatchedPins
         //TODO: map TMap ComponentTemplateNameIndex
         //TODO: map TMap OldToNewComponentTemplateNames
        ///<summary>Information for thumbnail rendering</summary>
        public unsafe ThumbnailInfo ThumbnailInfo {
            get {return Blueprint_ptr->ThumbnailInfo;}
            set {Blueprint_ptr->ThumbnailInfo = value;}
        }
        public bool bBeingCompiled {
            get {return Main.GetGetBoolPropertyByName(this, "bBeingCompiled"); }
            set {Main.SetGetBoolPropertyByName(this, "bBeingCompiled", value); }
        }
         //TODO: numeric uint32 CrcLastCompiledCDO
         //TODO: numeric uint32 CrcLastCompiledSignature
        ///<summary>If this BP is just a duplicate created for a specific compilation, the reference to original GeneratedClass is needed</summary>
        public unsafe SubclassOf<UObject> OriginalClass {
            get {return Blueprint_ptr->OriginalClass;}
            set {Blueprint_ptr->OriginalClass = value;}
        }
        static Blueprint() {
            StaticClass = Main.GetClass("Blueprint");
        }
        internal unsafe Blueprint_fields* Blueprint_ptr => (Blueprint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Blueprint(IntPtr p) => UObject.Make<Blueprint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Blueprint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Blueprint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
