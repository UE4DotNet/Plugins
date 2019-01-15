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
    ///<summary>This class is the base drag drop operation for UMG, extend it to add additional data and add new functionality.</summary>
    public unsafe partial class DragDropOperation : UObject  {

        ///<summary>Drag Cancelled</summary>
        public event DragCancelled_delegate DragCancelled;
        public delegate PointerEvent DragCancelled_delegate(PointerEvent PointerEvent);
        internal PointerEvent on_DragCancelled(PointerEvent PointerEvent) =>
            DragCancelled != null ? DragCancelled(PointerEvent) : PointerEvent;


        ///<summary>Dragged</summary>
        public event Dragged_delegate Dragged;
        public delegate PointerEvent Dragged_delegate(PointerEvent PointerEvent);
        internal PointerEvent on_Dragged(PointerEvent PointerEvent) =>
            Dragged != null ? Dragged(PointerEvent) : PointerEvent;


        ///<summary>Drop</summary>
        public event Drop_delegate Drop;
        public delegate PointerEvent Drop_delegate(PointerEvent PointerEvent);
        internal PointerEvent on_Drop(PointerEvent PointerEvent) =>
            Drop != null ? Drop(PointerEvent) : PointerEvent;

         //TODO: string FString Tag
        ///<summary>The payload of the drag operation.</summary>
        ///<remarks>
        ///This can be any UObject that you want to pass along as dragged data.  If you
        ///were building an inventory screen this would be the UObject representing the item being moved to another slot.
        ///</remarks>
        public unsafe UObject Payload {
            get {return DragDropOperation_ptr->Payload;}
            set {DragDropOperation_ptr->Payload = value;}
        }
        ///<summary>The Drag Visual is the widget to display when dragging the item.</summary>
        ///<remarks>
        ///Normally people create a new widget to represent the
        ///temporary drag.
        ///</remarks>
        public unsafe Widget DefaultDragVisual {
            get {return DragDropOperation_ptr->DefaultDragVisual;}
        }
         //TODO: enum EDragPivot Pivot
        ///<summary>A percentage offset (-1..+1) from the Pivot location, the percentage is of the desired size of the dragged visual.</summary>
        public unsafe Vector2D Offset {
            get {return DragDropOperation_ptr->Offset;}
            set {DragDropOperation_ptr->Offset = value;}
        }
         //TODO: multicast delegate FOnDragDropMulticast OnDrop
         //TODO: multicast delegate FOnDragDropMulticast OnDragCancelled
         //TODO: multicast delegate FOnDragDropMulticast OnDragged
        static DragDropOperation() {
            StaticClass = Main.GetClass("DragDropOperation");
            DragDropOperation_events.DragCancelled_event.Setup();
            DragDropOperation_events.Dragged_event.Setup();
            DragDropOperation_events.Drop_event.Setup();
        }
        internal unsafe DragDropOperation_fields* DragDropOperation_ptr => (DragDropOperation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DragDropOperation(IntPtr p) => UObject.Make<DragDropOperation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DragDropOperation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DragDropOperation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
