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
using UE4.UMGEditor.Native;
using UE4.UnrealEd;
using UE4.UMG;

namespace UE4.UMGEditor {
    ///<summary>Widget Blueprint Factory</summary>
    public unsafe partial class WidgetBlueprintFactory : Factory  {
        ///<summary>The type of blueprint that will be created</summary>
        public unsafe byte BlueprintType {
            get {return WidgetBlueprintFactory_ptr->BlueprintType;}
            set {WidgetBlueprintFactory_ptr->BlueprintType = value;}
        }
        ///<summary>The parent class of the created blueprint</summary>
        public unsafe SubclassOf<UserWidget> ParentClass {
            get {return WidgetBlueprintFactory_ptr->ParentClass;}
            set {WidgetBlueprintFactory_ptr->ParentClass = value;}
        }
        static WidgetBlueprintFactory() {
            StaticClass = Main.GetClass("WidgetBlueprintFactory");
        }
        internal unsafe WidgetBlueprintFactory_fields* WidgetBlueprintFactory_ptr => (WidgetBlueprintFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetBlueprintFactory(IntPtr p) => UObject.Make<WidgetBlueprintFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetBlueprintFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetBlueprintFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
