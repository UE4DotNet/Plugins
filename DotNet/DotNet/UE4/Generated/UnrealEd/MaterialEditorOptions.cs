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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Material Editor Options</summary>
    public unsafe partial class MaterialEditorOptions : UObject  {
        public bool bShowGrid {
            get {return Main.GetGetBoolPropertyByName(this, "bShowGrid"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowGrid", value); }
        }
        public bool bHideUnusedConnectors {
            get {return Main.GetGetBoolPropertyByName(this, "bHideUnusedConnectors"); }
            set {Main.SetGetBoolPropertyByName(this, "bHideUnusedConnectors", value); }
        }
        public bool bRealtimeMaterialViewport {
            get {return Main.GetGetBoolPropertyByName(this, "bRealtimeMaterialViewport"); }
            set {Main.SetGetBoolPropertyByName(this, "bRealtimeMaterialViewport", value); }
        }
        public bool bRealtimeExpressionViewport {
            get {return Main.GetGetBoolPropertyByName(this, "bRealtimeExpressionViewport"); }
            set {Main.SetGetBoolPropertyByName(this, "bRealtimeExpressionViewport", value); }
        }
        public bool bLivePreviewUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bLivePreviewUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bLivePreviewUpdate", value); }
        }
        public bool bAlwaysRefreshAllPreviews {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysRefreshAllPreviews"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlwaysRefreshAllPreviews", value); }
        }
        public bool bUseUnsortedMenus {
            get {return Main.GetGetBoolPropertyByName(this, "bUseUnsortedMenus"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseUnsortedMenus", value); }
        }
         //TODO: array not UObject TArray FavoriteExpressions
        static MaterialEditorOptions() {
            StaticClass = Main.GetClass("MaterialEditorOptions");
        }
        internal unsafe MaterialEditorOptions_fields* MaterialEditorOptions_ptr => (MaterialEditorOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialEditorOptions(IntPtr p) => UObject.Make<MaterialEditorOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialEditorOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialEditorOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
