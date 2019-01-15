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
    ///<summary>Implements an asset that contains a set of overlay data (which includes timing, text, and position) to be displayed for any</summary>
    ///<remarks>given source (including, but not limited to, audio, dialog, and movies)</remarks>
    public unsafe partial class BasicOverlays : Overlays  {
         //TODO: array not UObject TArray Overlays
        ///<summary>The import data used to make this overlays asset</summary>
        public unsafe AssetImportData AssetImportData {
            get {return BasicOverlays_ptr->AssetImportData;}
            set {BasicOverlays_ptr->AssetImportData = value;}
        }
        static BasicOverlays() {
            StaticClass = Main.GetClass("BasicOverlays");
        }
        internal unsafe BasicOverlays_fields* BasicOverlays_ptr => (BasicOverlays_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BasicOverlays(IntPtr p) => UObject.Make<BasicOverlays>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BasicOverlays DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BasicOverlays New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
