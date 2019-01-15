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

namespace UE4.UMG {
    ///<summary>
    ///The Menu Anchor allows you to specify an location that a popup menu should be anchored to,
    ///and should be summoned from.
    ///</summary>
    ///<remarks>
    ///* Single Child
    ///* Popup
    ///</remarks>
    public unsafe partial class MenuAnchor : ContentWidget  {

        ///<summary>Closes the menu if it is currently open.</summary>
        public void Close()  => 
            MenuAnchor_methods.Close_method.Invoke(ObjPointer);

        ///<summary>@return The current menu position</summary>
        public Vector2D GetMenuPosition()  => 
            MenuAnchor_methods.GetMenuPosition_method.Invoke(ObjPointer);

        ///<summary>@return Whether this menu has open submenus</summary>
        public bool HasOpenSubMenus()  => 
            MenuAnchor_methods.HasOpenSubMenus_method.Invoke(ObjPointer);

        ///<summary>@return true if the popup is open; false otherwise.</summary>
        public bool IsOpen()  => 
            MenuAnchor_methods.IsOpen_method.Invoke(ObjPointer);

        ///<summary>Opens the menu if it is not already open</summary>
        public void Open(bool bFocusMenu)  => 
            MenuAnchor_methods.Open_method.Invoke(ObjPointer, bFocusMenu);

        ///<summary>@</summary>
        ///<remarks>
        ///return true if we should open the menu due to a click. Sometimes we should not, if
        ///the same MouseDownEvent that just closed the menu is about to re-open it because it
        ///happens to land on the button.
        ///</remarks>
        public bool ShouldOpenDueToClick()  => 
            MenuAnchor_methods.ShouldOpenDueToClick_method.Invoke(ObjPointer);

        ///<summary>Toggles the menus open state.</summary>
        ///<remarks>
        ///@param bFocusOnOpen  Should we focus the popup as soon as it opens?
        ///</remarks>
        public void ToggleOpen(bool bFocusOnOpen)  => 
            MenuAnchor_methods.ToggleOpen_method.Invoke(ObjPointer, bFocusOnOpen);
        ///<summary>The widget class to spawn when the menu is required.</summary>
        ///<remarks>
        ///Creates the widget freshly each time.
        ///If you want to customize the creation of the popup, you should bind a function to OnGetMenuContentEvent
        ///instead.
        ///</remarks>
        public unsafe SubclassOf<UserWidget> MenuClass {
            get {return MenuAnchor_ptr->MenuClass;}
        }
         //TODO: delegate FGetWidget OnGetMenuContentEvent
        ///<summary>The placement location of the summoned widget.</summary>
        public unsafe byte Placement {
            get {return MenuAnchor_ptr->Placement;}
        }
        public bool ShouldDeferPaintingAfterWindowContent {
            get {return Main.GetGetBoolPropertyByName(this, "ShouldDeferPaintingAfterWindowContent"); }
        }
        public bool UseApplicationMenuStack {
            get {return Main.GetGetBoolPropertyByName(this, "UseApplicationMenuStack"); }
        }
         //TODO: multicast delegate FOnMenuOpenChangedEvent OnMenuOpenChanged
        static MenuAnchor() {
            StaticClass = Main.GetClass("MenuAnchor");
        }
        internal unsafe MenuAnchor_fields* MenuAnchor_ptr => (MenuAnchor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MenuAnchor(IntPtr p) => UObject.Make<MenuAnchor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MenuAnchor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MenuAnchor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
