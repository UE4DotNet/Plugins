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
    ///<summary>A special box panel that auto-generates its entries at both design-time and runtime.</summary>
    ///<remarks>
    ///Useful for cases where you can have a varying number of entries, but it isn't worth the effort or conceptual overhead to set up a list/tile view.
    ///Note that entries here are *not* virtualized as they are in the list views, so generally this should be avoided if you intend to scroll through lots of items.
    ///
    ///No children can be manually added in the designer - all are auto-generated based on the given entry class.
    ///</remarks>
    public unsafe partial class DynamicEntryBox : Widget  {

        ///<summary>Creates and establishes a new dynamic entry in the box</summary>
        public UserWidget BP_CreateEntry()  => 
            DynamicEntryBox_methods.BP_CreateEntry_method.Invoke(ObjPointer);

        ///<summary>Get All Entries</summary>
        public void GetAllEntries(byte ReturnValue /*TODO: array TArray */)  => 
            DynamicEntryBox_methods.GetAllEntries_method.Invoke(ObjPointer, ReturnValue);

        ///<summary>Get Num Entries</summary>
        public int GetNumEntries()  => 
            DynamicEntryBox_methods.GetNumEntries_method.Invoke(ObjPointer);

        ///<summary>Remove Entry</summary>
        public void RemoveEntry(UserWidget EntryWidget)  => 
            DynamicEntryBox_methods.RemoveEntry_method.Invoke(ObjPointer, EntryWidget);

        ///<summary>Clear out the box entries, optionally deleting the underlying Slate widgets entirely as well.</summary>
        public void Reset(bool bDeleteWidgets)  => 
            DynamicEntryBox_methods.Reset_method.Invoke(ObjPointer, bDeleteWidgets);

        ///<summary>Set Entry Spacing</summary>
        public void SetEntrySpacing(Vector2D InEntrySpacing)  => 
            DynamicEntryBox_methods.SetEntrySpacing_method.Invoke(ObjPointer, InEntrySpacing);
        ///<summary>Num Designer Preview Entries</summary>
        public unsafe int NumDesignerPreviewEntries {
            get {return DynamicEntryBox_ptr->NumDesignerPreviewEntries;}
            set {DynamicEntryBox_ptr->NumDesignerPreviewEntries = value;}
        }
         //TODO: enum EDynamicBoxType EntryBoxType
        ///<summary>The padding to apply between entries in the box.</summary>
        ///<remarks>
        ///Note horizontal boxes only use the X and vertical boxes only use Y. Value is also ignored for the first entry in the box.
        ///Wrap and Overlay types use both X and Y for spacing.
        ///</remarks>
        public unsafe Vector2D EntrySpacing {
            get {return DynamicEntryBox_ptr->EntrySpacing;}
        }
         //TODO: array not UObject TArray SpacingPattern
        ///<summary>Sizing rule to apply to generated entries. Horizontal/Vertical boxes only.</summary>
        public unsafe SlateChildSize EntrySizeRule {
            get {return DynamicEntryBox_ptr->EntrySizeRule;}
        }
        ///<summary>Horizontal alignment of generated entries. Horizontal/Vertical/Wrap boxes only.</summary>
        public unsafe byte EntryHorizontalAlignment {
            get {return DynamicEntryBox_ptr->EntryHorizontalAlignment;}
        }
        ///<summary>Vertical alignment of generated entries. Horizontal/Vertical/Wrap boxes only.</summary>
        public unsafe byte EntryVerticalAlignment {
            get {return DynamicEntryBox_ptr->EntryVerticalAlignment;}
        }
        ///<summary>The maximum size of each entry in the dominant axis of the box. Vertical/Horizontal boxes only.</summary>
        public unsafe int MaxElementSize {
            get {return DynamicEntryBox_ptr->MaxElementSize;}
        }
        ///<summary>The class of widget to create entries of.</summary>
        ///<remarks>If natively binding this widget, use the EntryClass UPROPERTY metadata to specify the desired entry widget base class.</remarks>
        public unsafe SubclassOf<UserWidget> EntryWidgetClass {
            get {return DynamicEntryBox_ptr->EntryWidgetClass;}
        }
        static DynamicEntryBox() {
            StaticClass = Main.GetClass("DynamicEntryBox");
        }
        internal unsafe DynamicEntryBox_fields* DynamicEntryBox_ptr => (DynamicEntryBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DynamicEntryBox(IntPtr p) => UObject.Make<DynamicEntryBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DynamicEntryBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DynamicEntryBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
