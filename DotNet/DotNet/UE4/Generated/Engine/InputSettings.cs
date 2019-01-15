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
    ///Project wide settings for input handling
    ///@
    ///</summary>
    ///<remarks>see https://docs.unrealengine.com/latest/INT/Gameplay/Input/index.html</remarks>
    public unsafe partial class InputSettings : UObject  {

        ///<summary>Programmatically add an action mapping to the project defaults</summary>
        public void AddActionMapping(InputActionKeyMapping KeyMapping, bool bForceRebuildKeymaps)  => 
            InputSettings_methods.AddActionMapping_method.Invoke(ObjPointer, KeyMapping, bForceRebuildKeymaps);

        ///<summary>Programmatically add an axis mapping to the project defaults</summary>
        public void AddAxisMapping(InputAxisKeyMapping KeyMapping, bool bForceRebuildKeymaps)  => 
            InputSettings_methods.AddAxisMapping_method.Invoke(ObjPointer, KeyMapping, bForceRebuildKeymaps);

        ///<summary>When changes are made to the default mappings, push those changes out to PlayerInput key maps</summary>
        public void ForceRebuildKeymaps()  => 
            InputSettings_methods.ForceRebuildKeymaps_method.Invoke(ObjPointer);

        ///<summary>Get Action Mapping by Name</summary>
        public IReadOnlyCollection<InputActionKeyMapping> GetActionMappingByName(Name InActionName)  => 
            InputSettings_methods.GetActionMappingByName_method.Invoke(ObjPointer, InActionName);

        ///<summary>Populate a list of all defined action names</summary>
        public IReadOnlyCollection<Name> GetActionNames()  => 
            InputSettings_methods.GetActionNames_method.Invoke(ObjPointer);

        ///<summary>Retrieve all axis mappings by a certain name.</summary>
        public IReadOnlyCollection<InputAxisKeyMapping> GetAxisMappingByName(Name InAxisName)  => 
            InputSettings_methods.GetAxisMappingByName_method.Invoke(ObjPointer, InAxisName);

        ///<summary>Populate a list of all defined axis names</summary>
        public IReadOnlyCollection<Name> GetAxisNames()  => 
            InputSettings_methods.GetAxisNames_method.Invoke(ObjPointer);

        ///<summary>Returns the game local input settings (action mappings, axis mappings, etc...)</summary>
        public static InputSettings GetInputSettings()  => 
            InputSettings_methods.GetInputSettings_method.Invoke();

        ///<summary>Programmatically remove an action mapping to the project defaults</summary>
        public void RemoveActionMapping(InputActionKeyMapping KeyMapping, bool bForceRebuildKeymaps)  => 
            InputSettings_methods.RemoveActionMapping_method.Invoke(ObjPointer, KeyMapping, bForceRebuildKeymaps);

        ///<summary>Programmatically remove an axis mapping to the project defaults</summary>
        public void RemoveAxisMapping(InputAxisKeyMapping KeyMapping, bool bForceRebuildKeymaps)  => 
            InputSettings_methods.RemoveAxisMapping_method.Invoke(ObjPointer, KeyMapping, bForceRebuildKeymaps);

        ///<summary>Flush the current mapping values to the config file</summary>
        public void SaveKeyMappings()  => 
            InputSettings_methods.SaveKeyMappings_method.Invoke(ObjPointer);
         //TODO: array not UObject TArray AxisConfig
        public bool bAltEnterTogglesFullscreen {
            get {return Main.GetGetBoolPropertyByName(this, "bAltEnterTogglesFullscreen"); }
            set {Main.SetGetBoolPropertyByName(this, "bAltEnterTogglesFullscreen", value); }
        }
        public bool bF11TogglesFullscreen {
            get {return Main.GetGetBoolPropertyByName(this, "bF11TogglesFullscreen"); }
            set {Main.SetGetBoolPropertyByName(this, "bF11TogglesFullscreen", value); }
        }
        public bool bUseMouseForTouch {
            get {return Main.GetGetBoolPropertyByName(this, "bUseMouseForTouch"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseMouseForTouch", value); }
        }
        public bool bEnableMouseSmoothing {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableMouseSmoothing"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableMouseSmoothing", value); }
        }
        public bool bEnableFOVScaling {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableFOVScaling"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableFOVScaling", value); }
        }
        public bool bCaptureMouseOnLaunch {
            get {return Main.GetGetBoolPropertyByName(this, "bCaptureMouseOnLaunch"); }
            set {Main.SetGetBoolPropertyByName(this, "bCaptureMouseOnLaunch", value); }
        }
        public bool bAlwaysShowTouchInterface {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysShowTouchInterface"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlwaysShowTouchInterface", value); }
        }
        public bool bShowConsoleOnFourFingerTap {
            get {return Main.GetGetBoolPropertyByName(this, "bShowConsoleOnFourFingerTap"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowConsoleOnFourFingerTap", value); }
        }
        public bool bEnableGestureRecognizer {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableGestureRecognizer"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableGestureRecognizer", value); }
        }
        public bool bUseAutocorrect {
            get {return Main.GetGetBoolPropertyByName(this, "bUseAutocorrect"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseAutocorrect", value); }
        }
         //TODO: array not UObject TArray ExcludedAutocorrectOS
         //TODO: array not UObject TArray ExcludedAutocorrectCultures
         //TODO: array not UObject TArray ExcludedAutocorrectDeviceModels
         //TODO: enum EMouseCaptureMode DefaultViewportMouseCaptureMode
         //TODO: enum EMouseLockMode DefaultViewportMouseLockMode
        ///<summary>The scaling value to multiply the field of view by</summary>
        public unsafe float FOVScale {
            get {return InputSettings_ptr->FOVScale;}
            set {InputSettings_ptr->FOVScale = value;}
        }
        ///<summary>If a key is pressed twice in this amount of time it is considered a "double click"</summary>
        public unsafe float DoubleClickTime {
            get {return InputSettings_ptr->DoubleClickTime;}
            set {InputSettings_ptr->DoubleClickTime = value;}
        }
         //TODO: array not UObject TArray ActionMappings
         //TODO: array not UObject TArray AxisMappings
        ///<summary>The default on-screen touch input interface for the game (can be null to disable the onscreen interface)</summary>
        public unsafe SoftObjectPath DefaultTouchInterface {
            get {return InputSettings_ptr->DefaultTouchInterface;}
            set {InputSettings_ptr->DefaultTouchInterface = value;}
        }
         //TODO: array not UObject TArray ConsoleKeys
        static InputSettings() {
            StaticClass = Main.GetClass("InputSettings");
        }
        internal unsafe InputSettings_fields* InputSettings_ptr => (InputSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InputSettings(IntPtr p) => UObject.Make<InputSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InputSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InputSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
