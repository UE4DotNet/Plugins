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
using UE4.MobilePatchingUtils.Native;

namespace UE4.MobilePatchingUtils {
    ///<summary>Mobile Pending Content</summary>
    public unsafe partial class MobilePendingContent : MobileInstalledContent  {

        ///<summary>Get the total download size for this content installation</summary>
        public float GetDownloadSize()  => 
            MobilePendingContent_methods.GetDownloadSize_method.Invoke(ObjPointer);

        ///<summary>Get the current download speed in megabytes per second. Valid during installation</summary>
        public float GetDownloadSpeed()  => 
            MobilePendingContent_methods.GetDownloadSpeed_method.Invoke(ObjPointer);

        ///<summary>Get the current installation status text. Valid during installation</summary>
        public byte /*TODO: text FText*/ GetDownloadStatusText()  => 
            MobilePendingContent_methods.GetDownloadStatusText_method.Invoke(ObjPointer);

        ///<summary>Get the current installation progress. Between 0 and 1 for known progress, or less than 0 for unknown progress</summary>
        public float GetInstallProgress()  => 
            MobilePendingContent_methods.GetInstallProgress_method.Invoke(ObjPointer);

        ///<summary>Get the required disk space in megabytes for this content installation</summary>
        public float GetRequiredDiskSpace()  => 
            MobilePendingContent_methods.GetRequiredDiskSpace_method.Invoke(ObjPointer);

        ///<summary>Get the total downloaded size in megabytes. Valid during installation</summary>
        public float GetTotalDownloadedSize()  => 
            MobilePendingContent_methods.GetTotalDownloadedSize_method.Invoke(ObjPointer);

        ///<summary>Attempt to download and install remote content.</summary>
        ///<remarks>
        ///User can choose to mount installed content into the game.
        ///@param       OnSucceeded: Callback on installation success.
        ///@param       OnFailed: Callback on installation fail. Will return error message text and error integer code
        ///</remarks>
        public void StartInstall(byte OnSucceeded /*TODO: delegate FOnContentInstallSucceeded */, byte OnFailed /*TODO: delegate FOnContentInstallFailed */)  => 
            MobilePendingContent_methods.StartInstall_method.Invoke(ObjPointer, OnSucceeded, OnFailed);
        static MobilePendingContent() {
            StaticClass = Main.GetClass("MobilePendingContent");
        }
        internal unsafe MobilePendingContent_fields* MobilePendingContent_ptr => (MobilePendingContent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MobilePendingContent(IntPtr p) => UObject.Make<MobilePendingContent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MobilePendingContent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MobilePendingContent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
