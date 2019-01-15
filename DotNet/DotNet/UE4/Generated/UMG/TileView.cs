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
    ///<summary>A ListView that presents the contents as a set of tiles all uniformly sized.</summary>
    public unsafe partial class TileView : ListView  {

        ///<summary>Sets the height of every tile entry</summary>
        public void SetEntryHeight(float NewHeight)  => 
            TileView_methods.SetEntryHeight_method.Invoke(ObjPointer, NewHeight);

        ///<summary>Sets the width if every tile entry</summary>
        public void SetEntryWidth(float NewWidth)  => 
            TileView_methods.SetEntryWidth_method.Invoke(ObjPointer, NewWidth);
        ///<summary>The height of each tile</summary>
        public unsafe float EntryHeight {
            get {return TileView_ptr->EntryHeight;}
            set {TileView_ptr->EntryHeight = value;}
        }
        ///<summary>The width of each tile</summary>
        public unsafe float EntryWidth {
            get {return TileView_ptr->EntryWidth;}
            set {TileView_ptr->EntryWidth = value;}
        }
         //TODO: enum EListItemAlignment TileAlignment
        public bool bWrapHorizontalNavigation {
            get {return Main.GetGetBoolPropertyByName(this, "bWrapHorizontalNavigation"); }
            set {Main.SetGetBoolPropertyByName(this, "bWrapHorizontalNavigation", value); }
        }
        static TileView() {
            StaticClass = Main.GetClass("TileView");
        }
        internal unsafe TileView_fields* TileView_ptr => (TileView_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TileView(IntPtr p) => UObject.Make<TileView>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TileView DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TileView New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
