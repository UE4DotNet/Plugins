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
using UE4.MovieSceneCapture.Native;
using UE4.Engine;

namespace UE4.MovieSceneCapture {
    ///<summary>Composition Graph Capture Protocol</summary>
    public unsafe partial class CompositionGraphCaptureProtocol : MovieSceneImageCaptureProtocolBase  {
        ///<summary>A list of render passes to include in the capture. Leave empty to export all available passes.</summary>
        public unsafe CompositionGraphCapturePasses IncludeRenderPasses {
            get {return CompositionGraphCaptureProtocol_ptr->IncludeRenderPasses;}
            set {CompositionGraphCaptureProtocol_ptr->IncludeRenderPasses = value;}
        }
        public bool bCaptureFramesInHDR {
            get {return Main.GetGetBoolPropertyByName(this, "bCaptureFramesInHDR"); }
            set {Main.SetGetBoolPropertyByName(this, "bCaptureFramesInHDR", value); }
        }
        ///<summary>Compression Quality for HDR Frames (0 for no compression, 1 for default compression which can be slow)</summary>
        public unsafe int HDRCompressionQuality {
            get {return CompositionGraphCaptureProtocol_ptr->HDRCompressionQuality;}
            set {CompositionGraphCaptureProtocol_ptr->HDRCompressionQuality = value;}
        }
        ///<summary>The color gamut to use when storing HDR captured data. The gamut depends on whether the bCaptureFramesInHDR option is enabled.</summary>
        public unsafe byte CaptureGamut {
            get {return CompositionGraphCaptureProtocol_ptr->CaptureGamut;}
            set {CompositionGraphCaptureProtocol_ptr->CaptureGamut = value;}
        }
        ///<summary>Custom post processing material to use for rendering</summary>
        public unsafe SoftObjectPath PostProcessingMaterial {
            get {return CompositionGraphCaptureProtocol_ptr->PostProcessingMaterial;}
            set {CompositionGraphCaptureProtocol_ptr->PostProcessingMaterial = value;}
        }
        public bool bDisableScreenPercentage {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableScreenPercentage"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableScreenPercentage", value); }
        }
        ///<summary>Post Processing Material Ptr</summary>
        public unsafe MaterialInterface PostProcessingMaterialPtr {
            get {return CompositionGraphCaptureProtocol_ptr->PostProcessingMaterialPtr;}
            set {CompositionGraphCaptureProtocol_ptr->PostProcessingMaterialPtr = value;}
        }
        static CompositionGraphCaptureProtocol() {
            StaticClass = Main.GetClass("CompositionGraphCaptureProtocol");
        }
        internal unsafe CompositionGraphCaptureProtocol_fields* CompositionGraphCaptureProtocol_ptr => (CompositionGraphCaptureProtocol_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CompositionGraphCaptureProtocol(IntPtr p) => UObject.Make<CompositionGraphCaptureProtocol>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CompositionGraphCaptureProtocol DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CompositionGraphCaptureProtocol New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
