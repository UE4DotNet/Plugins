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


namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=960 )]
    internal unsafe struct ListView_fields {
        [FieldOffset(840)] public byte SelectionMode;
        [FieldOffset(841)] byte ConsumeMouseWheel; //TODO: enum EConsumeMouseWheel ConsumeMouseWheel
        [FieldOffset(842)] public bool bClearSelectionOnClick;
        [FieldOffset(844)] public float EntrySpacing;
        [FieldOffset(848)] public NativeArray ListItems;
        [FieldOffset(880)] byte BP_OnItemClicked; //TODO: multicast delegate FSimpleListItemEventDynamic BP_OnItemClicked
        [FieldOffset(896)] byte BP_OnItemDoubleClicked; //TODO: multicast delegate FSimpleListItemEventDynamic BP_OnItemDoubleClicked
        [FieldOffset(912)] byte BP_OnItemIsHoveredChanged; //TODO: multicast delegate FOnItemIsHoveredChangedDynamic BP_OnItemIsHoveredChanged
        [FieldOffset(928)] byte BP_OnItemSelectionChanged; //TODO: multicast delegate FOnListItemSelectionChangedDynamic BP_OnItemSelectionChanged
        [FieldOffset(944)] byte BP_OnItemScrolledIntoView; //TODO: multicast delegate FOnListItemScrolledIntoViewDynamic BP_OnItemScrolledIntoView
    }
    internal unsafe struct ListView_methods {
        internal struct AddItem_method {
            static internal IntPtr AddItem_ptr;
            static AddItem_method() {
                AddItem_ptr = Main.GetMethodUFunction(ListView.StaticClass, "AddItem");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject Item) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Item;
                Main.GetProcessEvent(obj, AddItem_ptr, new IntPtr(p)); ;
            }
        }
        internal struct BP_CancelScrollIntoView_method {
            static internal IntPtr BP_CancelScrollIntoView_ptr;
            static BP_CancelScrollIntoView_method() {
                BP_CancelScrollIntoView_ptr = Main.GetMethodUFunction(ListView.StaticClass, "BP_CancelScrollIntoView");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, BP_CancelScrollIntoView_ptr, new IntPtr(p)); ;
            }
        }
        internal struct BP_ClearSelection_method {
            static internal IntPtr BP_ClearSelection_ptr;
            static BP_ClearSelection_method() {
                BP_ClearSelection_ptr = Main.GetMethodUFunction(ListView.StaticClass, "BP_ClearSelection");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, BP_ClearSelection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct BP_GetNumItemsSelected_method {
            static internal IntPtr BP_GetNumItemsSelected_ptr;
            static BP_GetNumItemsSelected_method() {
                BP_GetNumItemsSelected_ptr = Main.GetMethodUFunction(ListView.StaticClass, "BP_GetNumItemsSelected");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, BP_GetNumItemsSelected_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct BP_GetSelectedItem_method {
            static internal IntPtr BP_GetSelectedItem_ptr;
            static BP_GetSelectedItem_method() {
                BP_GetSelectedItem_ptr = Main.GetMethodUFunction(ListView.StaticClass, "BP_GetSelectedItem");
            }

            internal static unsafe UObject Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, BP_GetSelectedItem_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct BP_GetSelectedItems_method {
            static internal IntPtr BP_GetSelectedItems_ptr;
            static BP_GetSelectedItems_method() {
                BP_GetSelectedItems_ptr = Main.GetMethodUFunction(ListView.StaticClass, "BP_GetSelectedItems");
            }

            internal static unsafe (IReadOnlyCollection<UObject>, bool) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, BP_GetSelectedItems_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Items
                return (UObject.ToUObjectCollection<UObject>(b+0),*((bool*)(b+16)));
            }
        }
        internal struct BP_IsItemVisible_method {
            static internal IntPtr BP_IsItemVisible_ptr;
            static BP_IsItemVisible_method() {
                BP_IsItemVisible_ptr = Main.GetMethodUFunction(ListView.StaticClass, "BP_IsItemVisible");
            }

            internal static unsafe bool Invoke(IntPtr obj, UObject Item) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Item;
                Main.GetProcessEvent(obj, BP_IsItemVisible_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct BP_NavigateToItem_method {
            static internal IntPtr BP_NavigateToItem_ptr;
            static BP_NavigateToItem_method() {
                BP_NavigateToItem_ptr = Main.GetMethodUFunction(ListView.StaticClass, "BP_NavigateToItem");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject Item) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Item;
                Main.GetProcessEvent(obj, BP_NavigateToItem_ptr, new IntPtr(p)); ;
            }
        }
        internal struct BP_ScrollItemIntoView_method {
            static internal IntPtr BP_ScrollItemIntoView_ptr;
            static BP_ScrollItemIntoView_method() {
                BP_ScrollItemIntoView_ptr = Main.GetMethodUFunction(ListView.StaticClass, "BP_ScrollItemIntoView");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject Item) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Item;
                Main.GetProcessEvent(obj, BP_ScrollItemIntoView_ptr, new IntPtr(p)); ;
            }
        }
        internal struct BP_SetItemSelection_method {
            static internal IntPtr BP_SetItemSelection_ptr;
            static BP_SetItemSelection_method() {
                BP_SetItemSelection_ptr = Main.GetMethodUFunction(ListView.StaticClass, "BP_SetItemSelection");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject Item, bool bSelected) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Item;
                *((bool*)(b+8)) = bSelected;
                Main.GetProcessEvent(obj, BP_SetItemSelection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct BP_SetListItems_method {
            static internal IntPtr BP_SetListItems_ptr;
            static BP_SetListItems_method() {
                BP_SetListItems_ptr = Main.GetMethodUFunction(ListView.StaticClass, "BP_SetListItems");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InListItems /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray InListItems
                Main.GetProcessEvent(obj, BP_SetListItems_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InListItems
            }
        }
        internal struct BP_SetSelectedItem_method {
            static internal IntPtr BP_SetSelectedItem_ptr;
            static BP_SetSelectedItem_method() {
                BP_SetSelectedItem_ptr = Main.GetMethodUFunction(ListView.StaticClass, "BP_SetSelectedItem");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject Item) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Item;
                Main.GetProcessEvent(obj, BP_SetSelectedItem_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearListItems_method {
            static internal IntPtr ClearListItems_ptr;
            static ClearListItems_method() {
                ClearListItems_ptr = Main.GetMethodUFunction(ListView.StaticClass, "ClearListItems");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearListItems_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetIndexForItem_method {
            static internal IntPtr GetIndexForItem_ptr;
            static GetIndexForItem_method() {
                GetIndexForItem_ptr = Main.GetMethodUFunction(ListView.StaticClass, "GetIndexForItem");
            }

            internal static unsafe int Invoke(IntPtr obj, UObject Item) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Item;
                Main.GetProcessEvent(obj, GetIndexForItem_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetItemAt_method {
            static internal IntPtr GetItemAt_ptr;
            static GetItemAt_method() {
                GetItemAt_ptr = Main.GetMethodUFunction(ListView.StaticClass, "GetItemAt");
            }

            internal static unsafe UObject Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, GetItemAt_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetListItems_method {
            static internal IntPtr GetListItems_ptr;
            static GetListItems_method() {
                GetListItems_ptr = Main.GetMethodUFunction(ListView.StaticClass, "GetListItems");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ReturnValue /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ReturnValue
                Main.GetProcessEvent(obj, GetListItems_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
            }
        }
        internal struct GetNumItems_method {
            static internal IntPtr GetNumItems_ptr;
            static GetNumItems_method() {
                GetNumItems_ptr = Main.GetMethodUFunction(ListView.StaticClass, "GetNumItems");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumItems_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct IsRefreshPending_method {
            static internal IntPtr IsRefreshPending_ptr;
            static IsRefreshPending_method() {
                IsRefreshPending_ptr = Main.GetMethodUFunction(ListView.StaticClass, "IsRefreshPending");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsRefreshPending_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct NavigateToIndex_method {
            static internal IntPtr NavigateToIndex_ptr;
            static NavigateToIndex_method() {
                NavigateToIndex_ptr = Main.GetMethodUFunction(ListView.StaticClass, "NavigateToIndex");
            }

            internal static unsafe void Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, NavigateToIndex_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ScrollIndexIntoView_method {
            static internal IntPtr ScrollIndexIntoView_ptr;
            static ScrollIndexIntoView_method() {
                ScrollIndexIntoView_ptr = Main.GetMethodUFunction(ListView.StaticClass, "ScrollIndexIntoView");
            }

            internal static unsafe void Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, ScrollIndexIntoView_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSelectedIndex_method {
            static internal IntPtr SetSelectedIndex_ptr;
            static SetSelectedIndex_method() {
                SetSelectedIndex_ptr = Main.GetMethodUFunction(ListView.StaticClass, "SetSelectedIndex");
            }

            internal static unsafe void Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, SetSelectedIndex_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSelectionMode_method {
            static internal IntPtr SetSelectionMode_ptr;
            static SetSelectionMode_method() {
                SetSelectionMode_ptr = Main.GetMethodUFunction(ListView.StaticClass, "SetSelectionMode");
            }

            internal static unsafe void Invoke(IntPtr obj, byte SelectionMode) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = SelectionMode;
                Main.GetProcessEvent(obj, SetSelectionMode_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ListView_events {
    }
}
