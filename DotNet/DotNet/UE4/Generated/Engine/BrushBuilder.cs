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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Base class of UnrealEd brush builders.</summary>
    ///<remarks>
    ///Tips for writing brush builders:
    ///
    ///- Always validate the user-specified and call BadParameters function
    ///  if anything is wrong, instead of actually building geometry.
    ///  If you build an invalid brush due to bad user parameters, you'll
    ///  cause an extraordinary amount of pain for the poor user.
    ///
    ///- When generating polygons with more than 3 vertices, BE SURE all the
    ///  polygon's vertices are coplanar!  Out-of-plane polygons will cause
    ///  geometry to be corrupted.
    ///</remarks>
    public unsafe partial class BrushBuilder : UObject  {
         //TODO: string FString BitmapFilename
         //TODO: string FString ToolTip
        public bool NotifyBadParams {
            get {return Main.GetGetBoolPropertyByName(this, "NotifyBadParams"); }
            set {Main.SetGetBoolPropertyByName(this, "NotifyBadParams", value); }
        }
         //TODO: array not UObject TArray Vertices
         //TODO: array not UObject TArray Polys
        ///<summary>Layer</summary>
        public unsafe Name Layer {
            get {return BrushBuilder_ptr->Layer;}
            set {BrushBuilder_ptr->Layer = value;}
        }
        public bool MergeCoplanars {
            get {return Main.GetGetBoolPropertyByName(this, "MergeCoplanars"); }
            set {Main.SetGetBoolPropertyByName(this, "MergeCoplanars", value); }
        }
        static BrushBuilder() {
            StaticClass = Main.GetClass("BrushBuilder");
        }
        internal unsafe BrushBuilder_fields* BrushBuilder_ptr => (BrushBuilder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BrushBuilder(IntPtr p) => UObject.Make<BrushBuilder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BrushBuilder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BrushBuilder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
