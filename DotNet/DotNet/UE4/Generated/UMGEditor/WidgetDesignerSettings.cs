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
using UE4.UMGEditor.Native;
using UE4.Engine;

namespace UE4.UMGEditor {
    ///<summary>Implements the settings for the Widget Blueprint Designer.</summary>
    public unsafe partial class WidgetDesignerSettings : DeveloperSettings  {
        public bool GridSnapEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "GridSnapEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "GridSnapEnabled", value); }
        }
        ///<summary>Grid Snap Size</summary>
        public unsafe int GridSnapSize {
            get {return WidgetDesignerSettings_ptr->GridSnapSize;}
            set {WidgetDesignerSettings_ptr->GridSnapSize = value;}
        }
        public bool bLockToPanelOnDragByDefault {
            get {return Main.GetGetBoolPropertyByName(this, "bLockToPanelOnDragByDefault"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockToPanelOnDragByDefault", value); }
        }
        public bool bShowOutlines {
            get {return Main.GetGetBoolPropertyByName(this, "bShowOutlines"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowOutlines", value); }
        }
        public bool bExecutePreConstructEvent {
            get {return Main.GetGetBoolPropertyByName(this, "bExecutePreConstructEvent"); }
            set {Main.SetGetBoolPropertyByName(this, "bExecutePreConstructEvent", value); }
        }
        public bool bRespectLocks {
            get {return Main.GetGetBoolPropertyByName(this, "bRespectLocks"); }
            set {Main.SetGetBoolPropertyByName(this, "bRespectLocks", value); }
        }
        static WidgetDesignerSettings() {
            StaticClass = Main.GetClass("WidgetDesignerSettings");
        }
        internal unsafe WidgetDesignerSettings_fields* WidgetDesignerSettings_ptr => (WidgetDesignerSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetDesignerSettings(IntPtr p) => UObject.Make<WidgetDesignerSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetDesignerSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetDesignerSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
