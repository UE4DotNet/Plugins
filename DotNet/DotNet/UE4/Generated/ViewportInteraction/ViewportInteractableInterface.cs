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

namespace UE4.ViewportInteraction {
    ///<summary>Viewport Interactable Interface</summary>
    public unsafe partial class ViewportInteractableInterface : Interface  {
        static ViewportInteractableInterface() {
            StaticClass = Main.GetClass("ViewportInteractableInterface");
        }
        internal unsafe ViewportInteractableInterface_fields* ViewportInteractableInterface_ptr => (ViewportInteractableInterface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ViewportInteractableInterface(IntPtr p) => UObject.Make<ViewportInteractableInterface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ViewportInteractableInterface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ViewportInteractableInterface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
