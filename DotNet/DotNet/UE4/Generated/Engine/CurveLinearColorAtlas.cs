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
    ///<summary>Manages gradient LUT textures for registered actors and assigns them to the corresponding materials on the actor</summary>
    public unsafe partial class CurveLinearColorAtlas : Texture2D  {

        ///<summary>Get Curve Position</summary>
        public (float, bool) GetCurvePosition(CurveLinearColor InCurve)  => 
            CurveLinearColorAtlas_methods.GetCurvePosition_method.Invoke(ObjPointer, InCurve);
        public bool bIsDirty {
            get {return Main.GetGetBoolPropertyByName(this, "bIsDirty"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsDirty", value); }
        }
         //TODO: numeric uint32 TextureSize
         //TODO: numeric uint32 GradientPixelSize
        ///<summary>How many pixels tall is any gradient slot</summary>
        public ObjectArrayField<CurveLinearColor> GradientCurves{ get {
            if(GradientCurves_store == null) GradientCurves_store = new ObjectArrayField<CurveLinearColor> (&CurveLinearColorAtlas_ptr->GradientCurves);
            return GradientCurves_store;
        } }
        private ObjectArrayField<CurveLinearColor> GradientCurves_store;

        static CurveLinearColorAtlas() {
            StaticClass = Main.GetClass("CurveLinearColorAtlas");
        }
        internal unsafe CurveLinearColorAtlas_fields* CurveLinearColorAtlas_ptr => (CurveLinearColorAtlas_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurveLinearColorAtlas(IntPtr p) => UObject.Make<CurveLinearColorAtlas>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurveLinearColorAtlas DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurveLinearColorAtlas New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
