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
    ///<summary>Text Render Actor</summary>
    public unsafe partial class TextRenderActor : Actor  {
        ///<summary>Component to render a text in 3d with a font</summary>
        public unsafe TextRenderComponent TextRender {
            get {return TextRenderActor_ptr->TextRender;}
        }
        ///<summary>Reference to the billboard component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return TextRenderActor_ptr->SpriteComponent;}
            set {TextRenderActor_ptr->SpriteComponent = value;}
        }
        static TextRenderActor() {
            StaticClass = Main.GetClass("TextRenderActor");
        }
        internal unsafe TextRenderActor_fields* TextRenderActor_ptr => (TextRenderActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextRenderActor(IntPtr p) => UObject.Make<TextRenderActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextRenderActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextRenderActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
