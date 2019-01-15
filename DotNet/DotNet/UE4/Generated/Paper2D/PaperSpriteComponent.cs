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
    ///<summary>A component that handles rendering and collision for a single instance of a UPaperSprite asset.</summary>
    ///<remarks>
    ///This component is created when you drag a sprite asset from the content browser into a Blueprint, or
    ///contained inside of the actor created when you drag one into the level.
    ///
    ///@see UPrimitiveComponent, UPaperSprite
    ///</remarks>
    public unsafe partial class PaperSpriteComponent : MeshComponent  {

        ///<summary>Gets the PaperSprite used by this instance.</summary>
        public PaperSprite GetSprite()  => 
            PaperSpriteComponent_methods.GetSprite_method.Invoke(ObjPointer);

        ///<summary>Change the PaperSprite used by this instance.</summary>
        public bool SetSprite(PaperSprite NewSprite)  => 
            PaperSpriteComponent_methods.SetSprite_method.Invoke(ObjPointer, NewSprite);

        ///<summary>Set color of the sprite</summary>
        public void SetSpriteColor(LinearColor NewColor)  => 
            PaperSpriteComponent_methods.SetSpriteColor_method.Invoke(ObjPointer, NewColor);
        ///<summary>The sprite asset used by this component</summary>
        public unsafe PaperSprite SourceSprite {
            get {return PaperSpriteComponent_ptr->SourceSprite;}
        }
        ///<summary>The color of the sprite (passed to the sprite material as a vertex color)</summary>
        public unsafe LinearColor SpriteColor {
            get {return PaperSpriteComponent_ptr->SpriteColor;}
        }
        static PaperSpriteComponent() {
            StaticClass = Main.GetClass("PaperSpriteComponent");
        }
        internal unsafe PaperSpriteComponent_fields* PaperSpriteComponent_ptr => (PaperSpriteComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperSpriteComponent(IntPtr p) => UObject.Make<PaperSpriteComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperSpriteComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperSpriteComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
