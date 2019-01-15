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
using UE4.Paper2D.Native;
using UE4.Engine;

namespace UE4.Paper2D {
    ///<summary>An instance of a UPaperFlipbook in a level.</summary>
    ///<remarks>
    ///This actor is created when you drag a flipbook asset from the content browser into the level, and
    ///it is just a thin wrapper around a UPaperFlipbookComponent that actually references the asset.
    ///</remarks>
    public unsafe partial class PaperFlipbookActor : Actor  {
        ///<summary>Render Component</summary>
        public unsafe PaperFlipbookComponent RenderComponent {
            get {return PaperFlipbookActor_ptr->RenderComponent;}
        }
        static PaperFlipbookActor() {
            StaticClass = Main.GetClass("PaperFlipbookActor");
        }
        internal unsafe PaperFlipbookActor_fields* PaperFlipbookActor_ptr => (PaperFlipbookActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperFlipbookActor(IntPtr p) => UObject.Make<PaperFlipbookActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperFlipbookActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperFlipbookActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
