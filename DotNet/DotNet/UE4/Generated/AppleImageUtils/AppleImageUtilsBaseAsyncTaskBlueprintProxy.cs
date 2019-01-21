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
using UE4.AppleImageUtils.Native;
using UE4.Engine;

namespace UE4.AppleImageUtils {
    ///<summary>Apple Image Utils Base Async Task Blueprint Proxy</summary>
    public unsafe partial class AppleImageUtilsBaseAsyncTaskBlueprintProxy : UObject  {

        ///<summary>
        ///Converts a image to an array of HEIF data in a background task
        ///@
        ///</summary>
        ///<remarks>
        ///param SourceImage the image to compress
        ///@param Quality the quality level to compress to
        ///@param bWantColor whether the HEIF is color (true) or monochrome (false)
        ///@param bUseGpu whether to use the GPU (true) or the CPU (false) to compress
        ///@param Scale whether to scale the image before conversion, defaults to no scaling
        ///@param Rotate a direction to rotate the image in during conversion, defaults to none
        ///</remarks>
        public static AppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToHEIF(Texture SourceImage, int Quality, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate)  => 
            AppleImageUtilsBaseAsyncTaskBlueprintProxy_methods.CreateProxyObjectForConvertToHEIF_method.Invoke(SourceImage, Quality, bWantColor, bUseGpu, Scale, Rotate);

        ///<summary>
        ///Converts a image to an array of JPEG data in a background task
        ///@
        ///</summary>
        ///<remarks>
        ///param SourceImage the image to compress
        ///@param Quality the quality level to compress to
        ///@param bWantColor whether the JPEG is color (true) or monochrome (false)
        ///@param bUseGpu whether to use the GPU (true) or the CPU (false) to compress
        ///@param Scale whether to scale the image before conversion, defaults to no scaling
        ///@param Rotate a direction to rotate the image in during conversion, defaults to none
        ///</remarks>
        public static AppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToJPEG(Texture SourceImage, int Quality, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate)  => 
            AppleImageUtilsBaseAsyncTaskBlueprintProxy_methods.CreateProxyObjectForConvertToJPEG_method.Invoke(SourceImage, Quality, bWantColor, bUseGpu, Scale, Rotate);

        ///<summary>
        ///Converts a image to an array of TIFF data in a background task
        ///@
        ///</summary>
        ///<remarks>
        ///param SourceImage the image to compress
        ///@param Quality the quality level to compress to
        ///@param bWantColor whether the PNG is color (true) or monochrome (false)
        ///@param bUseGpu whether to use the GPU (true) or the CPU (false) to compress
        ///@param Scale whether to scale the image before conversion, defaults to no scaling
        ///@param Rotate a direction to rotate the image in during conversion, defaults to none
        ///</remarks>
        public static AppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToPNG(Texture SourceImage, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate)  => 
            AppleImageUtilsBaseAsyncTaskBlueprintProxy_methods.CreateProxyObjectForConvertToPNG_method.Invoke(SourceImage, bWantColor, bUseGpu, Scale, Rotate);

        ///<summary>
        ///Converts a image to an array of TIFF data in a background task
        ///@
        ///</summary>
        ///<remarks>
        ///param SourceImage the image to compress
        ///@param Quality the quality level to compress to
        ///@param bWantColor whether the TIFF is color (true) or monochrome (false)
        ///@param bUseGpu whether to use the GPU (true) or the CPU (false) to compress
        ///@param Scale whether to scale the image before conversion, defaults to no scaling
        ///@param Rotate a direction to rotate the image in during conversion, defaults to none
        ///</remarks>
        public static AppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToTIFF(Texture SourceImage, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate)  => 
            AppleImageUtilsBaseAsyncTaskBlueprintProxy_methods.CreateProxyObjectForConvertToTIFF_method.Invoke(SourceImage, bWantColor, bUseGpu, Scale, Rotate);
         //TODO: multicast delegate FAppleImageConversionDelegate OnSuccess
         //TODO: multicast delegate FAppleImageConversionDelegate OnFailure
        ///<summary>Conversion Result</summary>
        public unsafe AppleImageUtilsImageConversionResult ConversionResult {
            get {return AppleImageUtilsBaseAsyncTaskBlueprintProxy_ptr->ConversionResult;}
        }
        static AppleImageUtilsBaseAsyncTaskBlueprintProxy() {
            StaticClass = Main.GetClass("AppleImageUtilsBaseAsyncTaskBlueprintProxy");
        }
        internal unsafe AppleImageUtilsBaseAsyncTaskBlueprintProxy_fields* AppleImageUtilsBaseAsyncTaskBlueprintProxy_ptr => (AppleImageUtilsBaseAsyncTaskBlueprintProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AppleImageUtilsBaseAsyncTaskBlueprintProxy(IntPtr p) => UObject.Make<AppleImageUtilsBaseAsyncTaskBlueprintProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AppleImageUtilsBaseAsyncTaskBlueprintProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AppleImageUtilsBaseAsyncTaskBlueprintProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
