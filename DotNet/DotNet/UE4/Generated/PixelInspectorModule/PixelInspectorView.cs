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
using UE4.PixelInspectorModule.Native;

namespace UE4.PixelInspectorModule {
    ///<summary>Pixel Inspector View</summary>
    public unsafe partial class PixelInspectorView : UObject  {
        ///<summary>Final RGBA 8bits Color after tone mapping, default value is black.</summary>
        public unsafe LinearColor FinalColor {
            get {return PixelInspectorView_ptr->FinalColor;}
            set {PixelInspectorView_ptr->FinalColor = value;}
        }
        ///<summary>HDR RGB Color.</summary>
        public unsafe LinearColor SceneColor {
            get {return PixelInspectorView_ptr->SceneColor;}
            set {PixelInspectorView_ptr->SceneColor = value;}
        }
        ///<summary>HDR Luminance.</summary>
        public unsafe float Luminance {
            get {return PixelInspectorView_ptr->Luminance;}
            set {PixelInspectorView_ptr->Luminance = value;}
        }
        ///<summary>HDR RGB Color.</summary>
        public unsafe LinearColor HdrColor {
            get {return PixelInspectorView_ptr->HdrColor;}
            set {PixelInspectorView_ptr->HdrColor = value;}
        }
        ///<summary>From the GBufferA RGB Channels.</summary>
        public unsafe Vector Normal {
            get {return PixelInspectorView_ptr->Normal;}
            set {PixelInspectorView_ptr->Normal = value;}
        }
        ///<summary>From the GBufferA A Channel.</summary>
        public unsafe float PerObjectGBufferData {
            get {return PixelInspectorView_ptr->PerObjectGBufferData;}
            set {PixelInspectorView_ptr->PerObjectGBufferData = value;}
        }
        ///<summary>From the GBufferB R Channel.</summary>
        public unsafe float Metallic {
            get {return PixelInspectorView_ptr->Metallic;}
            set {PixelInspectorView_ptr->Metallic = value;}
        }
        ///<summary>From the GBufferB G Channel.</summary>
        public unsafe float Specular {
            get {return PixelInspectorView_ptr->Specular;}
            set {PixelInspectorView_ptr->Specular = value;}
        }
        ///<summary>From the GBufferB B Channel.</summary>
        public unsafe float Roughness {
            get {return PixelInspectorView_ptr->Roughness;}
            set {PixelInspectorView_ptr->Roughness = value;}
        }
        ///<summary>From the GBufferB A Channel encoded with SelectiveOutputMask.</summary>
        public unsafe byte MaterialShadingModel {
            get {return PixelInspectorView_ptr->MaterialShadingModel;}
            set {PixelInspectorView_ptr->MaterialShadingModel = value;}
        }
        ///<summary>From the GBufferB A Channel encoded with ShadingModel.</summary>
        public unsafe int SelectiveOutputMask {
            get {return PixelInspectorView_ptr->SelectiveOutputMask;}
            set {PixelInspectorView_ptr->SelectiveOutputMask = value;}
        }
        ///<summary>From the GBufferC RGB Channels.</summary>
        public unsafe LinearColor BaseColor {
            get {return PixelInspectorView_ptr->BaseColor;}
            set {PixelInspectorView_ptr->BaseColor = value;}
        }
        ///<summary>From the GBufferC A Channel encoded with AmbientOcclusion.</summary>
        public unsafe float IndirectIrradiance {
            get {return PixelInspectorView_ptr->IndirectIrradiance;}
            set {PixelInspectorView_ptr->IndirectIrradiance = value;}
        }
        ///<summary>From the GBufferC A Channel encoded with IndirectIrradiance.</summary>
        public unsafe float AmbientOcclusion {
            get {return PixelInspectorView_ptr->AmbientOcclusion;}
            set {PixelInspectorView_ptr->AmbientOcclusion = value;}
        }
        ///<summary>From the GBufferD RGB Channels.</summary>
        public unsafe LinearColor SubSurfaceColor {
            get {return PixelInspectorView_ptr->SubSurfaceColor;}
            set {PixelInspectorView_ptr->SubSurfaceColor = value;}
        }
        ///<summary>From the GBufferD RGB Channels.</summary>
        public unsafe Vector SubsurfaceProfile {
            get {return PixelInspectorView_ptr->SubsurfaceProfile;}
            set {PixelInspectorView_ptr->SubsurfaceProfile = value;}
        }
        ///<summary>From the GBufferD A Channel.</summary>
        public unsafe float Opacity {
            get {return PixelInspectorView_ptr->Opacity;}
            set {PixelInspectorView_ptr->Opacity = value;}
        }
        ///<summary>From the GBufferD R Channel.</summary>
        public unsafe float ClearCoat {
            get {return PixelInspectorView_ptr->ClearCoat;}
            set {PixelInspectorView_ptr->ClearCoat = value;}
        }
        ///<summary>From the GBufferD G Channel.</summary>
        public unsafe float ClearCoatRoughness {
            get {return PixelInspectorView_ptr->ClearCoatRoughness;}
            set {PixelInspectorView_ptr->ClearCoatRoughness = value;}
        }
        ///<summary>From the GBufferD RG Channels.</summary>
        public unsafe Vector WorldNormal {
            get {return PixelInspectorView_ptr->WorldNormal;}
            set {PixelInspectorView_ptr->WorldNormal = value;}
        }
        ///<summary>From the GBufferD B Channel.</summary>
        public unsafe float BackLit {
            get {return PixelInspectorView_ptr->BackLit;}
            set {PixelInspectorView_ptr->BackLit = value;}
        }
        ///<summary>From the GBufferD A Channel.</summary>
        public unsafe float Cloth {
            get {return PixelInspectorView_ptr->Cloth;}
            set {PixelInspectorView_ptr->Cloth = value;}
        }
        ///<summary>From the GBufferD RG Channels.</summary>
        public unsafe Vector EyeTangent {
            get {return PixelInspectorView_ptr->EyeTangent;}
            set {PixelInspectorView_ptr->EyeTangent = value;}
        }
        ///<summary>From the GBufferD B Channel.</summary>
        public unsafe float IrisMask {
            get {return PixelInspectorView_ptr->IrisMask;}
            set {PixelInspectorView_ptr->IrisMask = value;}
        }
        ///<summary>From the GBufferD A Channel.</summary>
        public unsafe float IrisDistance {
            get {return PixelInspectorView_ptr->IrisDistance;}
            set {PixelInspectorView_ptr->IrisDistance = value;}
        }
        static PixelInspectorView() {
            StaticClass = Main.GetClass("PixelInspectorView");
        }
        internal unsafe PixelInspectorView_fields* PixelInspectorView_ptr => (PixelInspectorView_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PixelInspectorView(IntPtr p) => UObject.Make<PixelInspectorView>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PixelInspectorView DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PixelInspectorView New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
