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
    ///<summary>Represents the interactor in the world</summary>
    public unsafe partial class ViewportInteractor : UObject  {
        ///<summary>The owning world interaction</summary>
        public unsafe ViewportWorldInteraction WorldInteraction {
            get {return ViewportInteractor_ptr->WorldInteraction;}
            set {ViewportInteractor_ptr->WorldInteraction = value;}
        }
        ///<summary>The paired interactor by the world interaction</summary>
        public unsafe ViewportInteractor OtherInteractor {
            get {return ViewportInteractor_ptr->OtherInteractor;}
            set {ViewportInteractor_ptr->OtherInteractor = value;}
        }
        static ViewportInteractor() {
            StaticClass = Main.GetClass("ViewportInteractor");
        }
        internal unsafe ViewportInteractor_fields* ViewportInteractor_ptr => (ViewportInteractor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ViewportInteractor(IntPtr p) => UObject.Make<ViewportInteractor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ViewportInteractor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ViewportInteractor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
