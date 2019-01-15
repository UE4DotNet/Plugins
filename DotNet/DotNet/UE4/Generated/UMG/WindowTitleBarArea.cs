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
using UE4.UMG.Native;
using UE4.SlateCore;

namespace UE4.UMG {
    ///<summary>A panel for defining a region of the UI that should allow users to drag the window on desktop platforms.</summary>
    public unsafe partial class WindowTitleBarArea : ContentWidget  {

        ///<summary>Set Horizontal Alignment</summary>
        public void SetHorizontalAlignment(byte InHorizontalAlignment)  => 
            WindowTitleBarArea_methods.SetHorizontalAlignment_method.Invoke(ObjPointer, InHorizontalAlignment);

        ///<summary>Set Padding</summary>
        public void SetPadding(Margin InPadding)  => 
            WindowTitleBarArea_methods.SetPadding_method.Invoke(ObjPointer, InPadding);

        ///<summary>Set Vertical Alignment</summary>
        public void SetVerticalAlignment(byte InVerticalAlignment)  => 
            WindowTitleBarArea_methods.SetVerticalAlignment_method.Invoke(ObjPointer, InVerticalAlignment);
        public bool bWindowButtonsEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bWindowButtonsEnabled"); }
        }
        public bool bDoubleClickTogglesFullscreen {
            get {return Main.GetGetBoolPropertyByName(this, "bDoubleClickTogglesFullscreen"); }
        }
        static WindowTitleBarArea() {
            StaticClass = Main.GetClass("WindowTitleBarArea");
        }
        internal unsafe WindowTitleBarArea_fields* WindowTitleBarArea_ptr => (WindowTitleBarArea_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WindowTitleBarArea(IntPtr p) => UObject.Make<WindowTitleBarArea>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WindowTitleBarArea DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WindowTitleBarArea New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
