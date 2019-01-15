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
using UE4.SlateCore;
using UE4.Engine;

namespace UE4.UMG {
    ///<summary>Slate Blueprint Library</summary>
    public unsafe partial class SlateBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>Absolute coordinates could be either desktop or window space depending on what space the root of the widget hierarchy is in.</summary>
        ///<remarks>
        ///@return Transforms AbsoluteCoordinate into the local space of this Geometry.
        ///</remarks>
        public static Vector2D AbsoluteToLocal(Geometry Geometry, Vector2D AbsoluteCoordinate)  => 
            SlateBlueprintLibrary_methods.AbsoluteToLocal_method.Invoke(Geometry, AbsoluteCoordinate);

        ///<summary>Translates absolute coordinate in desktop space of the geometry provided into local viewport coordinates.</summary>
        ///<remarks>
        ///@param PixelPosition The position in the game's viewport, usable for line traces and
        ///other uses where you need a coordinate in the space of viewport resolution units.
        ///@param ViewportPosition The position in the space of other widgets in the viewport.  Like if you wanted
        ///to add another widget to the viewport at the same position in viewport space as this location, this is
        ///what you would use.
        ///</remarks>
        public static (Vector2D, Vector2D) AbsoluteToViewport(UObject WorldContextObject, Vector2D AbsoluteDesktopCoordinate)  => 
            SlateBlueprintLibrary_methods.AbsoluteToViewport_method.Invoke(WorldContextObject, AbsoluteDesktopCoordinate);

        ///<summary>@return Whether brushes A and B are identical.</summary>
        public static bool EqualEqual_SlateBrush(SlateBrush A, SlateBrush B)  => 
            SlateBlueprintLibrary_methods.EqualEqual_SlateBrush_method.Invoke(A, B);

        ///<summary>@return the size of the geometry in absolute space.</summary>
        public static Vector2D GetAbsoluteSize(Geometry Geometry)  => 
            SlateBlueprintLibrary_methods.GetAbsoluteSize_method.Invoke(Geometry);

        ///<summary>@return the size of the geometry in local space.</summary>
        public static Vector2D GetLocalSize(Geometry Geometry)  => 
            SlateBlueprintLibrary_methods.GetLocalSize_method.Invoke(Geometry);

        ///<summary>Absolute coordinates could be either desktop or window space depending on what space the root of the widget hierarchy is in.</summary>
        ///<remarks>
        ///@return true if the provided location in absolute coordinates is within the bounds of this geometry.
        ///</remarks>
        public static bool IsUnderLocation(Geometry Geometry, Vector2D AbsoluteCoordinate)  => 
            SlateBlueprintLibrary_methods.IsUnderLocation_method.Invoke(Geometry, AbsoluteCoordinate);

        ///<summary>
        ///Translates local coordinates into absolute coordinates
        ///Absolute coordinates could be either desktop or window space depending on what space the root of the widget hierarchy is in.
        ///</summary>
        ///<remarks>
        ///@return  Absolute coordinates
        ///</remarks>
        public static Vector2D LocalToAbsolute(Geometry Geometry, Vector2D LocalCoordinate)  => 
            SlateBlueprintLibrary_methods.LocalToAbsolute_method.Invoke(Geometry, LocalCoordinate);

        ///<summary>Translates local coordinate of the geometry provided into local viewport coordinates.</summary>
        ///<remarks>
        ///@param PixelPosition The position in the game's viewport, usable for line traces and
        ///other uses where you need a coordinate in the space of viewport resolution units.
        ///@param ViewportPosition The position in the space of other widgets in the viewport.  Like if you wanted
        ///to add another widget to the viewport at the same position in viewport space as this location, this is
        ///what you would use.
        ///</remarks>
        public static (Vector2D, Vector2D) LocalToViewport(UObject WorldContextObject, Geometry Geometry, Vector2D LocalCoordinate)  => 
            SlateBlueprintLibrary_methods.LocalToViewport_method.Invoke(WorldContextObject, Geometry, LocalCoordinate);
        static SlateBlueprintLibrary() {
            StaticClass = Main.GetClass("SlateBlueprintLibrary");
        }
        internal unsafe SlateBlueprintLibrary_fields* SlateBlueprintLibrary_ptr => (SlateBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SlateBlueprintLibrary(IntPtr p) => UObject.Make<SlateBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SlateBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SlateBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
