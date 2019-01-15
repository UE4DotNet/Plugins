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
    ///<summary>Implements the Editor's user settings.</summary>
    public unsafe partial class AutomationTestSettings : UObject  {
         //TODO: array not UObject TArray EngineTestModules
         //TODO: array not UObject TArray EditorTestModules
        ///<summary>The automation test map to be used for several of the automation tests.</summary>
        public unsafe SoftObjectPath AutomationTestmap {
            get {return AutomationTestSettings_ptr->AutomationTestmap;}
            set {AutomationTestSettings_ptr->AutomationTestmap = value;}
        }
         //TODO: array not UObject TArray EditorPerformanceTestMaps
         //TODO: array not UObject TArray AssetsToOpen
        ///<summary>Editor build promotion test settings</summary>
        public unsafe BuildPromotionTestSettings BuildPromotionTest {
            get {return AutomationTestSettings_ptr->BuildPromotionTest;}
            set {AutomationTestSettings_ptr->BuildPromotionTest = value;}
        }
        ///<summary>Material editor promotion test settings</summary>
        public unsafe MaterialEditorPromotionSettings MaterialEditorPromotionTest {
            get {return AutomationTestSettings_ptr->MaterialEditorPromotionTest;}
            set {AutomationTestSettings_ptr->MaterialEditorPromotionTest = value;}
        }
        ///<summary>Particle editor promotion test settings</summary>
        public unsafe ParticleEditorPromotionSettings ParticleEditorPromotionTest {
            get {return AutomationTestSettings_ptr->ParticleEditorPromotionTest;}
            set {AutomationTestSettings_ptr->ParticleEditorPromotionTest = value;}
        }
        ///<summary>Blueprint editor promotion test settings</summary>
        public unsafe BlueprintEditorPromotionSettings BlueprintEditorPromotionTest {
            get {return AutomationTestSettings_ptr->BlueprintEditorPromotionTest;}
            set {AutomationTestSettings_ptr->BlueprintEditorPromotionTest = value;}
        }
         //TODO: array not UObject TArray TestLevelFolders
         //TODO: array not UObject TArray ExternalTools
         //TODO: array not UObject TArray ImportExportTestDefinitions
         //TODO: array not UObject TArray LaunchOnSettings
        ///<summary>The default resolution to take all automation screenshots at.</summary>
        public unsafe IntPoint DefaultScreenshotResolution {
            get {return AutomationTestSettings_ptr->DefaultScreenshotResolution;}
            set {AutomationTestSettings_ptr->DefaultScreenshotResolution = value;}
        }
        static AutomationTestSettings() {
            StaticClass = Main.GetClass("AutomationTestSettings");
        }
        internal unsafe AutomationTestSettings_fields* AutomationTestSettings_ptr => (AutomationTestSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AutomationTestSettings(IntPtr p) => UObject.Make<AutomationTestSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AutomationTestSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AutomationTestSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
