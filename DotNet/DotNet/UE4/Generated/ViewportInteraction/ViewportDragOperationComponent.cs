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
using UE4.ViewportInteraction.Native;
using UE4.Engine;

namespace UE4.ViewportInteraction {
    ///<summary>Container component for UViewportDragOperation that can be used by objects in the world that are draggable and implement the ViewportInteractableInterface</summary>
    public unsafe partial class ViewportDragOperationComponent : ActorComponent  {
        ///<summary>The actual dragging implementation</summary>
        public unsafe ViewportDragOperation DragOperation {
            get {return ViewportDragOperationComponent_ptr->DragOperation;}
            set {ViewportDragOperationComponent_ptr->DragOperation = value;}
        }
        ///<summary>The next class that will be used as drag operation</summary>
        public unsafe SubclassOf<ViewportDragOperation> DragOperationSubclass {
            get {return ViewportDragOperationComponent_ptr->DragOperationSubclass;}
            set {ViewportDragOperationComponent_ptr->DragOperationSubclass = value;}
        }
        static ViewportDragOperationComponent() {
            StaticClass = Main.GetClass("ViewportDragOperationComponent");
        }
        internal unsafe ViewportDragOperationComponent_fields* ViewportDragOperationComponent_ptr => (ViewportDragOperationComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ViewportDragOperationComponent(IntPtr p) => UObject.Make<ViewportDragOperationComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ViewportDragOperationComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ViewportDragOperationComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
