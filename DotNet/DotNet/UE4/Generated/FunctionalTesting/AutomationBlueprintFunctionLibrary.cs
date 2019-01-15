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
using UE4.FunctionalTesting.Native;
using UE4.Engine;

namespace UE4.FunctionalTesting {
    ///<summary>Automation Blueprint Function Library</summary>
    public unsafe partial class AutomationBlueprintFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Lets you know if any automated tests are running, or are about to run and the automation system is spinning up tests.</summary>
        public static bool AreAutomatedTestsRunning()  => 
            AutomationBlueprintFunctionLibrary_methods.AreAutomatedTestsRunning_method.Invoke();

        ///<summary>Disable Stat Group</summary>
        public static void DisableStatGroup(UObject WorldContextObject, Name GroupName)  => 
            AutomationBlueprintFunctionLibrary_methods.DisableStatGroup_method.Invoke(WorldContextObject, GroupName);

        ///<summary>Enable Stat Group</summary>
        public static void EnableStatGroup(UObject WorldContextObject, Name GroupName)  => 
            AutomationBlueprintFunctionLibrary_methods.EnableStatGroup_method.Invoke(WorldContextObject, GroupName);

        ///<summary>Get Default Screenshot Options for Gameplay</summary>
        public static AutomationScreenshotOptions GetDefaultScreenshotOptionsForGameplay(EComparisonTolerance Tolerance, float Delay)  => 
            AutomationBlueprintFunctionLibrary_methods.GetDefaultScreenshotOptionsForGameplay_method.Invoke(Tolerance, Delay);

        ///<summary>Get Default Screenshot Options for Rendering</summary>
        public static AutomationScreenshotOptions GetDefaultScreenshotOptionsForRendering(EComparisonTolerance Tolerance, float Delay)  => 
            AutomationBlueprintFunctionLibrary_methods.GetDefaultScreenshotOptionsForRendering_method.Invoke(Tolerance, Delay);

        ///<summary>Get Stat Call Count</summary>
        public static float GetStatCallCount(Name StatName)  => 
            AutomationBlueprintFunctionLibrary_methods.GetStatCallCount_method.Invoke(StatName);

        ///<summary>Get Stat Exc Average</summary>
        public static float GetStatExcAverage(Name StatName)  => 
            AutomationBlueprintFunctionLibrary_methods.GetStatExcAverage_method.Invoke(StatName);

        ///<summary>Get Stat Exc Max</summary>
        public static float GetStatExcMax(Name StatName)  => 
            AutomationBlueprintFunctionLibrary_methods.GetStatExcMax_method.Invoke(StatName);

        ///<summary>Get Stat Inc Average</summary>
        public static float GetStatIncAverage(Name StatName)  => 
            AutomationBlueprintFunctionLibrary_methods.GetStatIncAverage_method.Invoke(StatName);

        ///<summary>Get Stat Inc Max</summary>
        public static float GetStatIncMax(Name StatName)  => 
            AutomationBlueprintFunctionLibrary_methods.GetStatIncMax_method.Invoke(StatName);

        ///<summary>
        ///Sets all other settings based on an overall value
        ///@
        ///</summary>
        ///<remarks>param Value 0:Cinematic, 1:Epic...etc.</remarks>
        public static void SetScalabilityQualityLevelRelativeToMax(UObject WorldContextObject, int Value)  => 
            AutomationBlueprintFunctionLibrary_methods.SetScalabilityQualityLevelRelativeToMax_method.Invoke(WorldContextObject, Value);

        ///<summary>Set Scalability Quality to Epic</summary>
        public static void SetScalabilityQualityToEpic(UObject WorldContextObject)  => 
            AutomationBlueprintFunctionLibrary_methods.SetScalabilityQualityToEpic_method.Invoke(WorldContextObject);

        ///<summary>Set Scalability Quality to Low</summary>
        public static void SetScalabilityQualityToLow(UObject WorldContextObject)  => 
            AutomationBlueprintFunctionLibrary_methods.SetScalabilityQualityToLow_method.Invoke(WorldContextObject);

        ///<summary>Takes a screenshot of the game's viewport.  Does not capture any UI.</summary>
        public static void TakeAutomationScreenshot(UObject WorldContextObject, LatentActionInfo LatentInfo, string Name, string Notes, AutomationScreenshotOptions Options)  => 
            AutomationBlueprintFunctionLibrary_methods.TakeAutomationScreenshot_method.Invoke(WorldContextObject, LatentInfo, Name, Notes, Options);

        ///<summary>Takes a screenshot of the game's viewport, from a particular camera actors POV.  Does not capture any UI.</summary>
        public static void TakeAutomationScreenshotAtCamera(UObject WorldContextObject, LatentActionInfo LatentInfo, CameraActor Camera, string NameOverride, string Notes, AutomationScreenshotOptions Options)  => 
            AutomationBlueprintFunctionLibrary_methods.TakeAutomationScreenshotAtCamera_method.Invoke(WorldContextObject, LatentInfo, Camera, NameOverride, Notes, Options);

        ///<summary>Take Automation Screenshot Of UI</summary>
        public static void TakeAutomationScreenshotOfUI(UObject WorldContextObject, LatentActionInfo LatentInfo, string Name, AutomationScreenshotOptions Options)  => 
            AutomationBlueprintFunctionLibrary_methods.TakeAutomationScreenshotOfUI_method.Invoke(WorldContextObject, LatentInfo, Name, Options);
        static AutomationBlueprintFunctionLibrary() {
            StaticClass = Main.GetClass("AutomationBlueprintFunctionLibrary");
        }
        internal unsafe AutomationBlueprintFunctionLibrary_fields* AutomationBlueprintFunctionLibrary_ptr => (AutomationBlueprintFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AutomationBlueprintFunctionLibrary(IntPtr p) => UObject.Make<AutomationBlueprintFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AutomationBlueprintFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AutomationBlueprintFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
