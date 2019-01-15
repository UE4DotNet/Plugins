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
    ///<summary>Material Expression Depth Fade</summary>
    public unsafe partial class MaterialExpressionDepthFade : MaterialExpression  {
        ///<summary>Defaults to 'OpacityDefault' if not specified</summary>
        public unsafe ExpressionInput InOpacity {
            get {return MaterialExpressionDepthFade_ptr->InOpacity;}
            set {MaterialExpressionDepthFade_ptr->InOpacity = value;}
        }
        ///<summary>Defaults to 'FadeDistanceDefault' if not specified</summary>
        public unsafe ExpressionInput FadeDistance {
            get {return MaterialExpressionDepthFade_ptr->FadeDistance;}
            set {MaterialExpressionDepthFade_ptr->FadeDistance = value;}
        }
        ///<summary>Opacity which will be scaled by the result of the fade.  This is used when InOpacity is unconnected.</summary>
        public unsafe float OpacityDefault {
            get {return MaterialExpressionDepthFade_ptr->OpacityDefault;}
            set {MaterialExpressionDepthFade_ptr->OpacityDefault = value;}
        }
        ///<summary>World space distance over which the fade should take place.  This is used when FadeDistance is unconnected.</summary>
        public unsafe float FadeDistanceDefault {
            get {return MaterialExpressionDepthFade_ptr->FadeDistanceDefault;}
            set {MaterialExpressionDepthFade_ptr->FadeDistanceDefault = value;}
        }
        static MaterialExpressionDepthFade() {
            StaticClass = Main.GetClass("MaterialExpressionDepthFade");
        }
        internal unsafe MaterialExpressionDepthFade_fields* MaterialExpressionDepthFade_ptr => (MaterialExpressionDepthFade_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionDepthFade(IntPtr p) => UObject.Make<MaterialExpressionDepthFade>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionDepthFade DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionDepthFade New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
