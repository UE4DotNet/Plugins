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
    ///<summary>A light component which emits light from a rectangle.</summary>
    public unsafe partial class RectLightComponent : LocalLightComponent  {

        ///<summary>Set Source Height</summary>
        public void SetSourceHeight(float NewValue)  => 
            RectLightComponent_methods.SetSourceHeight_method.Invoke(ObjPointer, NewValue);

        ///<summary>Texture mapped to the light source rectangle //UPROPERTY(EditAnywhere, BlueprintReadWrite, AdvancedDisplay, Category=Light, AdvancedDisplay)</summary>
        ///<remarks>//class UTexture* SourceTexture;</remarks>
        public void SetSourceWidth(float bNewValue)  => 
            RectLightComponent_methods.SetSourceWidth_method.Invoke(ObjPointer, bNewValue);
        ///<summary>Width of light source rect.</summary>
        ///<remarks>Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts.</remarks>
        public unsafe float SourceWidth {
            get {return RectLightComponent_ptr->SourceWidth;}
        }
        ///<summary>Height of light source rect.</summary>
        ///<remarks>Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts.</remarks>
        public unsafe float SourceHeight {
            get {return RectLightComponent_ptr->SourceHeight;}
        }
        static RectLightComponent() {
            StaticClass = Main.GetClass("RectLightComponent");
        }
        internal unsafe RectLightComponent_fields* RectLightComponent_ptr => (RectLightComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RectLightComponent(IntPtr p) => UObject.Make<RectLightComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RectLightComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RectLightComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
