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
    ///<summary>A virtualized list that allows up to thousands of items to be displayed.</summary>
    ///<remarks>
    ///An important distinction to keep in mind here is "Item" vs. "Entry"
    ///The list itself is based on a list of n items, but only creates as many entry widgets as can fit on screen.
    ///For example, a scrolling ListView of 200 items with 5 currently visible will only have created 5 entry widgets.
    ///
    ///To make a widget usable an an entry in a ListView, it must inherit from the IUserObjectListEntry interface.
    ///</remarks>
    public unsafe partial class ListView : ListViewBase  {

        ///<summary>Adds an the item to the list</summary>
        public void AddItem(UObject Item)  => 
            ListView_methods.AddItem_method.Invoke(ObjPointer, Item);

        ///<summary>Cancels a previous request to scroll and item into view.</summary>
        public void BP_CancelScrollIntoView()  => 
            ListView_methods.BP_CancelScrollIntoView_method.Invoke(ObjPointer);

        ///<summary>Clear selection</summary>
        public void BP_ClearSelection()  => 
            ListView_methods.BP_ClearSelection_method.Invoke(ObjPointer);

        ///<summary>Gets the number of items currently selected in the list</summary>
        public int BP_GetNumItemsSelected()  => 
            ListView_methods.BP_GetNumItemsSelected_method.Invoke(ObjPointer);

        ///<summary>Gets the first selected item, if any; recommended that you only use this for single selection lists.</summary>
        public UObject BP_GetSelectedItem()  => 
            ListView_methods.BP_GetSelectedItem_method.Invoke(ObjPointer);

        ///<summary>Gets a list of all the currently selected items</summary>
        public (IReadOnlyCollection<UObject>, bool) BP_GetSelectedItems()  => 
            ListView_methods.BP_GetSelectedItems_method.Invoke(ObjPointer);

        ///<summary>Gets whether the entry for the given object is currently visible in the list</summary>
        public bool BP_IsItemVisible(UObject Item)  => 
            ListView_methods.BP_IsItemVisible_method.Invoke(ObjPointer, Item);

        ///<summary>Requests that the given item is navigated to, scrolling it into view if needed.</summary>
        public void BP_NavigateToItem(UObject Item)  => 
            ListView_methods.BP_NavigateToItem_method.Invoke(ObjPointer, Item);

        ///<summary>Requests that the given item is scrolled into view</summary>
        public void BP_ScrollItemIntoView(UObject Item)  => 
            ListView_methods.BP_ScrollItemIntoView_method.Invoke(ObjPointer, Item);

        ///<summary>Sets whether the given item is selected.</summary>
        public void BP_SetItemSelection(UObject Item, bool bSelected)  => 
            ListView_methods.BP_SetItemSelection_method.Invoke(ObjPointer, Item, bSelected);

        ///<summary>Sets the array of objects to display rows for in the list</summary>
        public void BP_SetListItems(byte InListItems /*TODO: array TArray */)  => 
            ListView_methods.BP_SetListItems_method.Invoke(ObjPointer, InListItems);

        ///<summary>Sets the given item as the sole selected item.</summary>
        public void BP_SetSelectedItem(UObject Item)  => 
            ListView_methods.BP_SetSelectedItem_method.Invoke(ObjPointer, Item);

        ///<summary>Removes all items from the list</summary>
        public void ClearListItems()  => 
            ListView_methods.ClearListItems_method.Invoke(ObjPointer);

        ///<summary>Returns the index that the specified item is at. Will return the first found, or -1 for not found</summary>
        public int GetIndexForItem(UObject Item)  => 
            ListView_methods.GetIndexForItem_method.Invoke(ObjPointer, Item);

        ///<summary>Returns the item at the given index</summary>
        public UObject GetItemAt(int Index)  => 
            ListView_methods.GetItemAt_method.Invoke(ObjPointer, Index);

        ///<summary>Gets the list of all items in the list.</summary>
        ///<remarks>Note that each of these items only has a corresponding entry widget when visible. Use GetDisplayedEntryWidgets to get the currently displayed widgets.</remarks>
        public void GetListItems(byte ReturnValue /*TODO: array TArray */)  => 
            ListView_methods.GetListItems_method.Invoke(ObjPointer, ReturnValue);

        ///<summary>Returns the total number of items</summary>
        public int GetNumItems()  => 
            ListView_methods.GetNumItems_method.Invoke(ObjPointer);

        ///<summary>@return True if a refresh is pending and the list will be rebuilt on the next tick</summary>
        public bool IsRefreshPending()  => 
            ListView_methods.IsRefreshPending_method.Invoke(ObjPointer);

        ///<summary>Requests that the item at the given index navigated to, scrolling it into view if needed.</summary>
        public void NavigateToIndex(int Index)  => 
            ListView_methods.NavigateToIndex_method.Invoke(ObjPointer, Index);

        ///<summary>Requests that the item at the given index is scrolled into view</summary>
        public void ScrollIndexIntoView(int Index)  => 
            ListView_methods.ScrollIndexIntoView_method.Invoke(ObjPointer, Index);

        ///<summary>Sets the item at the given index as the sole selected item.</summary>
        public void SetSelectedIndex(int Index)  => 
            ListView_methods.SetSelectedIndex_method.Invoke(ObjPointer, Index);

        ///<summary>Sets the new selection mode, preserving the current selection where possible.</summary>
        public void SetSelectionMode(byte SelectionMode)  => 
            ListView_methods.SetSelectionMode_method.Invoke(ObjPointer, SelectionMode);
        ///<summary>Selection Mode</summary>
        public unsafe byte SelectionMode {
            get {return ListView_ptr->SelectionMode;}
        }
         //TODO: enum EConsumeMouseWheel ConsumeMouseWheel
        public bool bClearSelectionOnClick {
            get {return Main.GetGetBoolPropertyByName(this, "bClearSelectionOnClick"); }
        }
        ///<summary>Entry Spacing</summary>
        public unsafe float EntrySpacing {
            get {return ListView_ptr->EntrySpacing;}
            set {ListView_ptr->EntrySpacing = value;}
        }
        ///<summary>List Items</summary>
        public ObjectArrayField<UObject> ListItems{ get {
            if(ListItems_store == null) ListItems_store = new ObjectArrayField<UObject> (&ListView_ptr->ListItems);
            return ListItems_store;
        } }
        private ObjectArrayField<UObject> ListItems_store;

         //TODO: multicast delegate FSimpleListItemEventDynamic BP_OnItemClicked
         //TODO: multicast delegate FSimpleListItemEventDynamic BP_OnItemDoubleClicked
         //TODO: multicast delegate FOnItemIsHoveredChangedDynamic BP_OnItemIsHoveredChanged
         //TODO: multicast delegate FOnListItemSelectionChangedDynamic BP_OnItemSelectionChanged
         //TODO: multicast delegate FOnListItemScrolledIntoViewDynamic BP_OnItemScrolledIntoView
        static ListView() {
            StaticClass = Main.GetClass("ListView");
        }
        internal unsafe ListView_fields* ListView_ptr => (ListView_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ListView(IntPtr p) => UObject.Make<ListView>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ListView DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ListView New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
