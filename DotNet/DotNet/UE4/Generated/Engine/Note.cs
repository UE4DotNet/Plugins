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
    ///<summary>Note</summary>
    public unsafe partial class Note : Actor  {
         //TODO: string FString Text
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return Note_ptr->SpriteComponent;}
            set {Note_ptr->SpriteComponent = value;}
        }
        ///<summary>Reference to arrow visualization component</summary>
        public unsafe ArrowComponent ArrowComponent {
            get {return Note_ptr->ArrowComponent;}
            set {Note_ptr->ArrowComponent = value;}
        }
        static Note() {
            StaticClass = Main.GetClass("Note");
        }
        internal unsafe Note_fields* Note_ptr => (Note_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Note(IntPtr p) => UObject.Make<Note>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Note DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Note New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
