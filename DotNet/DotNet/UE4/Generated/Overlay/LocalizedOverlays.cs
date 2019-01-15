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
using UE4.Overlay.Native;
using UE4.Engine;

namespace UE4.Overlay {
    ///<summary>Implements an asset that contains a set of Basic Overlays that will be displayed in accordance with</summary>
    ///<remarks>the current locale, or a default set if an appropriate locale is not found</remarks>
    public unsafe partial class LocalizedOverlays : Overlays  {
        ///<summary>The overlays to use if no overlays are found for the current culture</summary>
        public unsafe BasicOverlays DefaultOverlays {
            get {return LocalizedOverlays_ptr->DefaultOverlays;}
            set {LocalizedOverlays_ptr->DefaultOverlays = value;}
        }
         //TODO: map TMap LocaleToOverlaysMap
        ///<summary>The import data used to make this overlays asset</summary>
        public unsafe AssetImportData AssetImportData {
            get {return LocalizedOverlays_ptr->AssetImportData;}
            set {LocalizedOverlays_ptr->AssetImportData = value;}
        }
        static LocalizedOverlays() {
            StaticClass = Main.GetClass("LocalizedOverlays");
        }
        internal unsafe LocalizedOverlays_fields* LocalizedOverlays_ptr => (LocalizedOverlays_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LocalizedOverlays(IntPtr p) => UObject.Make<LocalizedOverlays>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LocalizedOverlays DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LocalizedOverlays New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
