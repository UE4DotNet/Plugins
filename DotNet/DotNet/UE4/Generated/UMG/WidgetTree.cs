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
    ///<summary>The widget tree manages the collection of widgets in a blueprint widget.</summary>
    public unsafe partial class WidgetTree : UObject  {
        ///<summary>The root widget of the tree</summary>
        public unsafe Widget RootWidget {
            get {return WidgetTree_ptr->RootWidget;}
            set {WidgetTree_ptr->RootWidget = value;}
        }
        ///<summary>All Widgets</summary>
        public ObjectArrayField<Widget> AllWidgets{ get {
            if(AllWidgets_store == null) AllWidgets_store = new ObjectArrayField<Widget> (&WidgetTree_ptr->AllWidgets);
            return AllWidgets_store;
        } }
        private ObjectArrayField<Widget> AllWidgets_store;

        static WidgetTree() {
            StaticClass = Main.GetClass("WidgetTree");
        }
        internal unsafe WidgetTree_fields* WidgetTree_ptr => (WidgetTree_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetTree(IntPtr p) => UObject.Make<WidgetTree>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetTree DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetTree New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
