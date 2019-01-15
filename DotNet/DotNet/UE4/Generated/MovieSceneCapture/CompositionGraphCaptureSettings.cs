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

namespace UE4.MovieSceneCapture {
    ///<summary>Composition Graph Capture Settings</summary>
    public unsafe partial class CompositionGraphCaptureSettings : MovieSceneCaptureProtocolSettings  {
        ///<summary>A list of render passes to include in the capture. Leave empty to export all available passes.</summary>
        public unsafe CompositionGraphCapturePasses IncludeRenderPasses {
            get {return CompositionGraphCaptureSettings_ptr->IncludeRenderPasses;}
            set {CompositionGraphCaptureSettings_ptr->IncludeRenderPasses = value;}
        }
        public bool bCaptureFramesInHDR {
            get {return Main.GetGetBoolPropertyByName(this, "bCaptureFramesInHDR"); }
            set {Main.SetGetBoolPropertyByName(this, "bCaptureFramesInHDR", value); }
        }
        ///<summary>Compression Quality for HDR Frames (0 for no compression, 1 for default compression which can be slow)</summary>
        public unsafe int HDRCompressionQuality {
            get {return CompositionGraphCaptureSettings_ptr->HDRCompressionQuality;}
            set {CompositionGraphCaptureSettings_ptr->HDRCompressionQuality = value;}
        }
        ///<summary>The color gamut to use when storing HDR captured data. The gamut depends on whether the bCaptureFramesInHDR option is enabled.</summary>
        public unsafe byte CaptureGamut {
            get {return CompositionGraphCaptureSettings_ptr->CaptureGamut;}
            set {CompositionGraphCaptureSettings_ptr->CaptureGamut = value;}
        }
        ///<summary>Custom post processing material to use for rendering</summary>
        public unsafe SoftObjectPath PostProcessingMaterial {
            get {return CompositionGraphCaptureSettings_ptr->PostProcessingMaterial;}
            set {CompositionGraphCaptureSettings_ptr->PostProcessingMaterial = value;}
        }
        public bool bDisableScreenPercentage {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableScreenPercentage"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableScreenPercentage", value); }
        }
        static CompositionGraphCaptureSettings() {
            StaticClass = Main.GetClass("CompositionGraphCaptureSettings");
        }
        internal unsafe CompositionGraphCaptureSettings_fields* CompositionGraphCaptureSettings_ptr => (CompositionGraphCaptureSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CompositionGraphCaptureSettings(IntPtr p) => UObject.Make<CompositionGraphCaptureSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CompositionGraphCaptureSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CompositionGraphCaptureSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
