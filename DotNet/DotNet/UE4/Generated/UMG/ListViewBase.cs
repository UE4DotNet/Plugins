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
    ///<summary>Bare-bones base class to make creating custom UListView widgets easier.</summary>
    ///<remarks>
    ///Child classes should also inherit from ITypedUMGListView<T> to get a basic public ListView API for free.
    ///
    ///Child classes will own the actual SListView<T> widgets, but this provides some boilerplate functionality for generating entries.
    ///To generate a row for the child list, use GenerateTypedRow with the appropriate SObjectTableRow<T> type for your list
    ///
    ///Additionally, the entry widget class can be filtered for a particular class and interface with the EntryClass and EntryInterface metadata arguments
    ///This can be specified either on the class directly (see below) or on any BindWidget UProperty
    ///
    ///Example:
    ///class UMyUserWidget : public UUserWidget
    ///{
    ///            UPROPERTY(BindWidget, meta = (EntryClass = MyListEntryWidget))
    ///            UListView* ListView_InventoryItems;
    ///}
    ///</remarks>
    public unsafe partial class ListViewBase : Widget  {

        ///<summary>Gets all of the list entry widgets currently being displayed by the list</summary>
        public void GetDisplayedEntryWidgets(byte ReturnValue /*TODO: array TArray */)  => 
            ListViewBase_methods.GetDisplayedEntryWidgets_method.Invoke(ObjPointer, ReturnValue);

        ///<summary>Full regeneration of all entries in the list.</summary>
        ///<remarks>
        ///Note that the entry UWidget instances will not be destroyed, but they will be released and re-generated.
        ///In other words, entry widgets will not receive Destruct/Construct events. They will receive OnEntryReleased and IUserObjectListEntry implementations will receive OnListItemObjectSet.
        ///</remarks>
        public void RegenerateAllEntries()  => 
            ListViewBase_methods.RegenerateAllEntries_method.Invoke(ObjPointer);

        ///<summary>Scroll the entire list down to the bottom-most item</summary>
        public void ScrollToBottom()  => 
            ListViewBase_methods.ScrollToBottom_method.Invoke(ObjPointer);

        ///<summary>Scroll the entire list up to the first item</summary>
        public void ScrollToTop()  => 
            ListViewBase_methods.ScrollToTop_method.Invoke(ObjPointer);
        ///<summary>The type of widget to create for each entry displayed in the list.</summary>
        public unsafe SubclassOf<UserWidget> EntryWidgetClass {
            get {return ListViewBase_ptr->EntryWidgetClass;}
        }
         //TODO: multicast delegate FOnListEntryGeneratedDynamic BP_OnEntryGenerated
         //TODO: multicast delegate FOnListEntryReleasedDynamic BP_OnEntryReleased
        ///<summary>The number of dummy item entry widgets to preview in the widget designer</summary>
        public unsafe int NumDesignerPreviewEntries {
            get {return ListViewBase_ptr->NumDesignerPreviewEntries;}
            set {ListViewBase_ptr->NumDesignerPreviewEntries = value;}
        }
        static ListViewBase() {
            StaticClass = Main.GetClass("ListViewBase");
        }
        internal unsafe ListViewBase_fields* ListViewBase_ptr => (ListViewBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ListViewBase(IntPtr p) => UObject.Make<ListViewBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ListViewBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ListViewBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
