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
using UE4.Engine;

namespace UE4.UMG {
    ///<summary>The widget blueprint generated class allows us to create blueprint-able widgets for UMG at runtime.</summary>
    ///<remarks>
    ///All WBPGC's are of UUserWidget classes, and they perform special post initialization using this class
    ///to give themselves many of the same capabilities as AActor blueprints, like dynamic delegate binding for
    ///widgets.
    ///</remarks>
    public unsafe partial class WidgetBlueprintGeneratedClass : BlueprintGeneratedClass  {
        ///<summary>A tree of the widget templates to be created</summary>
        public unsafe WidgetTree WidgetTree {
            get {return WidgetBlueprintGeneratedClass_ptr->WidgetTree;}
            set {WidgetBlueprintGeneratedClass_ptr->WidgetTree = value;}
        }
        public bool bCookSlowConstructionWidgetTree {
            get {return Main.GetGetBoolPropertyByName(this, "bCookSlowConstructionWidgetTree"); }
            set {Main.SetGetBoolPropertyByName(this, "bCookSlowConstructionWidgetTree", value); }
        }
        public bool bAllowTemplate {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowTemplate"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowTemplate", value); }
        }
        public bool bAllowDynamicCreation {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowDynamicCreation"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowDynamicCreation", value); }
        }
        public bool bValidTemplate {
            get {return Main.GetGetBoolPropertyByName(this, "bValidTemplate"); }
            set {Main.SetGetBoolPropertyByName(this, "bValidTemplate", value); }
        }
        public bool bTemplateInitialized {
            get {return Main.GetGetBoolPropertyByName(this, "bTemplateInitialized"); }
            set {Main.SetGetBoolPropertyByName(this, "bTemplateInitialized", value); }
        }
        public bool bCookedTemplate {
            get {return Main.GetGetBoolPropertyByName(this, "bCookedTemplate"); }
            set {Main.SetGetBoolPropertyByName(this, "bCookedTemplate", value); }
        }
        public bool bClassRequiresNativeTick {
            get {return Main.GetGetBoolPropertyByName(this, "bClassRequiresNativeTick"); }
            set {Main.SetGetBoolPropertyByName(this, "bClassRequiresNativeTick", value); }
        }
         //TODO: array not UObject TArray Bindings
        ///<summary>Animations</summary>
        public ObjectArrayField<WidgetAnimation> Animations{ get {
            if(Animations_store == null) Animations_store = new ObjectArrayField<WidgetAnimation> (&WidgetBlueprintGeneratedClass_ptr->Animations);
            return Animations_store;
        } }
        private ObjectArrayField<WidgetAnimation> Animations_store;

         //TODO: array not UObject TArray NamedSlots
         //TODO: soft object TSoftObjectPtr<UUserWidget> TemplateAsset
        ///<summary>Template</summary>
        public unsafe UserWidget Template {
            get {return WidgetBlueprintGeneratedClass_ptr->Template;}
            set {WidgetBlueprintGeneratedClass_ptr->Template = value;}
        }
        ///<summary>Editor Template</summary>
        public unsafe UserWidget EditorTemplate {
            get {return WidgetBlueprintGeneratedClass_ptr->EditorTemplate;}
            set {WidgetBlueprintGeneratedClass_ptr->EditorTemplate = value;}
        }
        static WidgetBlueprintGeneratedClass() {
            StaticClass = Main.GetClass("WidgetBlueprintGeneratedClass");
        }
        internal unsafe WidgetBlueprintGeneratedClass_fields* WidgetBlueprintGeneratedClass_ptr => (WidgetBlueprintGeneratedClass_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetBlueprintGeneratedClass(IntPtr p) => UObject.Make<WidgetBlueprintGeneratedClass>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetBlueprintGeneratedClass DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetBlueprintGeneratedClass New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
