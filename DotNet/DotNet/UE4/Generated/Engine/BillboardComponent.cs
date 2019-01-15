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
    ///<summary>A 2d texture that will be rendered always facing the camera.</summary>
    public unsafe partial class BillboardComponent : PrimitiveComponent  {

        ///<summary>Change the sprite texture used by this component</summary>
        public void SetSprite(Texture2D NewSprite)  => 
            BillboardComponent_methods.SetSprite_method.Invoke(ObjPointer, NewSprite);

        ///<summary>Change the sprite texture and the UV's used by this component</summary>
        public void SetSpriteAndUV(Texture2D NewSprite, int NewU, int NewUL, int NewV, int NewVL)  => 
            BillboardComponent_methods.SetSpriteAndUV_method.Invoke(ObjPointer, NewSprite, NewU, NewUL, NewV, NewVL);

        ///<summary>Change the sprite's UVs</summary>
        public void SetUV(int NewU, int NewUL, int NewV, int NewVL)  => 
            BillboardComponent_methods.SetUV_method.Invoke(ObjPointer, NewU, NewUL, NewV, NewVL);
        ///<summary>Sprite</summary>
        public unsafe Texture2D Sprite {
            get {return BillboardComponent_ptr->Sprite;}
            set {BillboardComponent_ptr->Sprite = value;}
        }
        public bool bIsScreenSizeScaled {
            get {return Main.GetGetBoolPropertyByName(this, "bIsScreenSizeScaled"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsScreenSizeScaled", value); }
        }
        ///<summary>Screen Size</summary>
        public unsafe float ScreenSize {
            get {return BillboardComponent_ptr->ScreenSize;}
            set {BillboardComponent_ptr->ScreenSize = value;}
        }
        ///<summary>U</summary>
        public unsafe float U {
            get {return BillboardComponent_ptr->U;}
            set {BillboardComponent_ptr->U = value;}
        }
        ///<summary>UL</summary>
        public unsafe float UL {
            get {return BillboardComponent_ptr->UL;}
            set {BillboardComponent_ptr->UL = value;}
        }
        ///<summary>V</summary>
        public unsafe float V {
            get {return BillboardComponent_ptr->V;}
            set {BillboardComponent_ptr->V = value;}
        }
        ///<summary>VL</summary>
        public unsafe float VL {
            get {return BillboardComponent_ptr->VL;}
            set {BillboardComponent_ptr->VL = value;}
        }
        ///<summary>Sprite category information regarding the component</summary>
        public unsafe SpriteCategoryInfo SpriteInfo {
            get {return BillboardComponent_ptr->SpriteInfo;}
            set {BillboardComponent_ptr->SpriteInfo = value;}
        }
        public bool bUseInEditorScaling {
            get {return Main.GetGetBoolPropertyByName(this, "bUseInEditorScaling"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseInEditorScaling", value); }
        }
        static BillboardComponent() {
            StaticClass = Main.GetClass("BillboardComponent");
        }
        internal unsafe BillboardComponent_fields* BillboardComponent_ptr => (BillboardComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BillboardComponent(IntPtr p) => UObject.Make<BillboardComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BillboardComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BillboardComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
