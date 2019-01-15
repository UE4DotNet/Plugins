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
    ///<summary>Widget Navigation</summary>
    public unsafe partial class WidgetNavigation : UObject  {
        ///<summary>Happens when the user presses up arrow, joystick, d-pad.</summary>
        public unsafe WidgetNavigationData Up {
            get {return WidgetNavigation_ptr->Up;}
        }
        ///<summary>Happens when the user presses down arrow, joystick, d-pad.</summary>
        public unsafe WidgetNavigationData Down {
            get {return WidgetNavigation_ptr->Down;}
        }
        ///<summary>Happens when the user presses left arrow, joystick, d-pad.</summary>
        public unsafe WidgetNavigationData Left {
            get {return WidgetNavigation_ptr->Left;}
        }
        ///<summary>Happens when the user presses right arrow, joystick, d-pad.</summary>
        public unsafe WidgetNavigationData Right {
            get {return WidgetNavigation_ptr->Right;}
        }
        ///<summary>Happens when the user presses Tab.</summary>
        public unsafe WidgetNavigationData Next {
            get {return WidgetNavigation_ptr->Next;}
        }
        ///<summary>Happens when the user presses Shift+Tab.</summary>
        public unsafe WidgetNavigationData Previous {
            get {return WidgetNavigation_ptr->Previous;}
        }
        static WidgetNavigation() {
            StaticClass = Main.GetClass("WidgetNavigation");
        }
        internal unsafe WidgetNavigation_fields* WidgetNavigation_ptr => (WidgetNavigation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetNavigation(IntPtr p) => UObject.Make<WidgetNavigation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetNavigation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetNavigation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
