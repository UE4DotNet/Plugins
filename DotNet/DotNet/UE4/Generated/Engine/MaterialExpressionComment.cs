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
    ///<summary>Material Expression Comment</summary>
    public unsafe partial class MaterialExpressionComment : MaterialExpression  {
        ///<summary>Size X</summary>
        public unsafe int SizeX {
            get {return MaterialExpressionComment_ptr->SizeX;}
            set {MaterialExpressionComment_ptr->SizeX = value;}
        }
        ///<summary>Size Y</summary>
        public unsafe int SizeY {
            get {return MaterialExpressionComment_ptr->SizeY;}
            set {MaterialExpressionComment_ptr->SizeY = value;}
        }
         //TODO: string FString Text
        ///<summary>Color to style comment with</summary>
        public unsafe LinearColor CommentColor {
            get {return MaterialExpressionComment_ptr->CommentColor;}
            set {MaterialExpressionComment_ptr->CommentColor = value;}
        }
        ///<summary>Size of the text in the comment box</summary>
        public unsafe int FontSize {
            get {return MaterialExpressionComment_ptr->FontSize;}
            set {MaterialExpressionComment_ptr->FontSize = value;}
        }
        static MaterialExpressionComment() {
            StaticClass = Main.GetClass("MaterialExpressionComment");
        }
        internal unsafe MaterialExpressionComment_fields* MaterialExpressionComment_ptr => (MaterialExpressionComment_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionComment(IntPtr p) => UObject.Make<MaterialExpressionComment>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionComment DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionComment New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
