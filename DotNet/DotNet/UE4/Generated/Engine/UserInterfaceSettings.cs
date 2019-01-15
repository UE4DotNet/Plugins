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
    ///<summary>User Interface settings that control Slate and UMG.</summary>
    public unsafe partial class UserInterfaceSettings : DeveloperSettings  {
         //TODO: enum ERenderFocusRule RenderFocusRule
         //TODO: map TMap HardwareCursors
         //TODO: map TMap SoftwareCursors
        ///<summary>An optional application scale to apply on top of the custom scaling rules.</summary>
        ///<remarks>
        ///So if you want to expose a
        ///property in your game title, you can modify this underlying value to scale the entire UI.
        ///</remarks>
        public unsafe float ApplicationScale {
            get {return UserInterfaceSettings_ptr->ApplicationScale;}
            set {UserInterfaceSettings_ptr->ApplicationScale = value;}
        }
         //TODO: enum EUIScalingRule UIScaleRule
        ///<summary>Set DPI Scale Rule to Custom, and this class will be used instead of any of the built-in rules.</summary>
        public unsafe SoftClassPath CustomScalingRuleClass {
            get {return UserInterfaceSettings_ptr->CustomScalingRuleClass;}
            set {UserInterfaceSettings_ptr->CustomScalingRuleClass = value;}
        }
        ///<summary>Controls how the UI is scaled at different resolutions based on the DPI Scale Rule</summary>
        public unsafe RuntimeFloatCurve UIScaleCurve {
            get {return UserInterfaceSettings_ptr->UIScaleCurve;}
            set {UserInterfaceSettings_ptr->UIScaleCurve = value;}
        }
        public bool bAllowHighDPIInGameMode {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowHighDPIInGameMode"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowHighDPIInGameMode", value); }
        }
        public bool bLoadWidgetsOnDedicatedServer {
            get {return Main.GetGetBoolPropertyByName(this, "bLoadWidgetsOnDedicatedServer"); }
            set {Main.SetGetBoolPropertyByName(this, "bLoadWidgetsOnDedicatedServer", value); }
        }
        ///<summary>Cursor Classes</summary>
        public ObjectArrayField<UObject> CursorClasses{ get {
            if(CursorClasses_store == null) CursorClasses_store = new ObjectArrayField<UObject> (&UserInterfaceSettings_ptr->CursorClasses);
            return CursorClasses_store;
        } }
        private ObjectArrayField<UObject> CursorClasses_store;

        ///<summary>Custom Scaling Rule Class Instance</summary>
        public unsafe SubclassOf<UObject> CustomScalingRuleClassInstance {
            get {return UserInterfaceSettings_ptr->CustomScalingRuleClassInstance;}
            set {UserInterfaceSettings_ptr->CustomScalingRuleClassInstance = value;}
        }
        ///<summary>Custom Scaling Rule</summary>
        public unsafe DPICustomScalingRule CustomScalingRule {
            get {return UserInterfaceSettings_ptr->CustomScalingRule;}
            set {UserInterfaceSettings_ptr->CustomScalingRule = value;}
        }
        static UserInterfaceSettings() {
            StaticClass = Main.GetClass("UserInterfaceSettings");
        }
        internal unsafe UserInterfaceSettings_fields* UserInterfaceSettings_ptr => (UserInterfaceSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UserInterfaceSettings(IntPtr p) => UObject.Make<UserInterfaceSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UserInterfaceSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UserInterfaceSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
