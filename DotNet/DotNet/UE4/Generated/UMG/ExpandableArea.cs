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
    ///<summary>Expandable Area</summary>
    public unsafe partial class ExpandableArea : Widget  {

        ///<summary>Get Is Expanded</summary>
        public bool GetIsExpanded()  => 
            ExpandableArea_methods.GetIsExpanded_method.Invoke(ObjPointer);

        ///<summary>Set Is Expanded</summary>
        public void SetIsExpanded(bool IsExpanded)  => 
            ExpandableArea_methods.SetIsExpanded_method.Invoke(ObjPointer, IsExpanded);

        ///<summary>Set Is Expanded Animated</summary>
        public void SetIsExpanded_Animated(bool IsExpanded)  => 
            ExpandableArea_methods.SetIsExpanded_Animated_method.Invoke(ObjPointer, IsExpanded);
        ///<summary>Style</summary>
        public unsafe ExpandableAreaStyle Style {
            get {return ExpandableArea_ptr->Style;}
            set {ExpandableArea_ptr->Style = value;}
        }
        ///<summary>Border Brush</summary>
        public unsafe SlateBrush BorderBrush {
            get {return ExpandableArea_ptr->BorderBrush;}
        }
        ///<summary>Border Color</summary>
        public unsafe SlateColor BorderColor {
            get {return ExpandableArea_ptr->BorderColor;}
        }
        public bool bIsExpanded {
            get {return Main.GetGetBoolPropertyByName(this, "bIsExpanded"); }
        }
        ///<summary>The maximum height of the area</summary>
        public unsafe float MaxHeight {
            get {return ExpandableArea_ptr->MaxHeight;}
        }
        ///<summary>Header Padding</summary>
        public unsafe Margin HeaderPadding {
            get {return ExpandableArea_ptr->HeaderPadding;}
        }
        ///<summary>Area Padding</summary>
        public unsafe Margin AreaPadding {
            get {return ExpandableArea_ptr->AreaPadding;}
        }
         //TODO: multicast delegate FOnExpandableAreaExpansionChanged OnExpansionChanged
        ///<summary>Header Content</summary>
        public unsafe Widget HeaderContent {
            get {return ExpandableArea_ptr->HeaderContent;}
            set {ExpandableArea_ptr->HeaderContent = value;}
        }
        ///<summary>Body Content</summary>
        public unsafe Widget BodyContent {
            get {return ExpandableArea_ptr->BodyContent;}
            set {ExpandableArea_ptr->BodyContent = value;}
        }
        static ExpandableArea() {
            StaticClass = Main.GetClass("ExpandableArea");
        }
        internal unsafe ExpandableArea_fields* ExpandableArea_ptr => (ExpandableArea_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ExpandableArea(IntPtr p) => UObject.Make<ExpandableArea>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ExpandableArea DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ExpandableArea New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
