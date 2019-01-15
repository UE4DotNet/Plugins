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
using UE4.Engine;
using UE4.UMG;

namespace UE4.UMGEditor {
    ///<summary>The widget blueprint enables extending UUserWidget the user extensible UWidget.</summary>
    public unsafe partial class WidgetBlueprint : Blueprint  {
        ///<summary>A tree of the widget templates to be created</summary>
        public unsafe WidgetTree WidgetTree {
            get {return WidgetBlueprint_ptr->WidgetTree;}
            set {WidgetBlueprint_ptr->WidgetTree = value;}
        }
         //TODO: array not UObject TArray Bindings
        ///<summary>Animations</summary>
        public ObjectArrayField<WidgetAnimation> Animations{ get {
            if(Animations_store == null) Animations_store = new ObjectArrayField<WidgetAnimation> (&WidgetBlueprint_ptr->Animations);
            return Animations_store;
        } }
        private ObjectArrayField<WidgetAnimation> Animations_store;

         //TODO: string FString PaletteCategory
        public bool bForceSlowConstructionPath {
            get {return Main.GetGetBoolPropertyByName(this, "bForceSlowConstructionPath"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceSlowConstructionPath", value); }
        }
        ///<summary>The total number of widgets this widget contains.  This is a good way to find the "largest" widgets.</summary>
        public unsafe int InclusiveWidgets {
            get {return WidgetBlueprint_ptr->InclusiveWidgets;}
            set {WidgetBlueprint_ptr->InclusiveWidgets = value;}
        }
         //TODO: enum EWidgetTickFrequency TickFrequency
         //TODO: enum EWidgetCompileTimeTickPrediction TickPrediction
         //TODO: string FString TickPredictionReason
         //TODO: enum EWidgetSupportsDynamicCreation SupportDynamicCreation
        ///<summary>The total number of property bindings.  Consider this as a performance warning.</summary>
        public unsafe int PropertyBindings {
            get {return WidgetBlueprint_ptr->PropertyBindings;}
            set {WidgetBlueprint_ptr->PropertyBindings = value;}
        }
        static WidgetBlueprint() {
            StaticClass = Main.GetClass("WidgetBlueprint");
        }
        internal unsafe WidgetBlueprint_fields* WidgetBlueprint_ptr => (WidgetBlueprint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetBlueprint(IntPtr p) => UObject.Make<WidgetBlueprint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetBlueprint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetBlueprint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
