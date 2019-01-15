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
using UE4.Engine;

namespace UE4.MobilePatchingUtils {
    ///<summary>Mobile Patching Library</summary>
    public unsafe partial class MobilePatchingLibrary : BlueprintFunctionLibrary  {

        ///<summary>Get the name of currently selected device profile name</summary>
        public static string GetActiveDeviceProfileName()  => 
            MobilePatchingLibrary_methods.GetActiveDeviceProfileName_method.Invoke();

        ///<summary>Get the installed content.</summary>
        ///<remarks>
        ///Will return non-null object if there is an installed content at specified directory
        ///User can choose to mount installed content into the game
        ///</remarks>
        public static MobileInstalledContent GetInstalledContent(string InstallDirectory)  => 
            MobilePatchingLibrary_methods.GetInstalledContent_method.Invoke(InstallDirectory);

        ///<summary>Get the list of supported platform names on this device. Example: Android_ETC2, Android_ASTC</summary>
        public static IReadOnlyCollection<string> GetSupportedPlatformNames()  => 
            MobilePatchingLibrary_methods.GetSupportedPlatformNames_method.Invoke();

        ///<summary>Whether WiFi connection is currently available</summary>
        public static bool HasActiveWiFiConnection()  => 
            MobilePatchingLibrary_methods.HasActiveWiFiConnection_method.Invoke();

        ///<summary>Attempt to download manifest file using specified manifest URL.</summary>
        ///<remarks>
        ///On success it will return an object that represents remote content. This object can be queried for additional information, like total content size, download size, etc.
        ///User can choose to download and install remote content.
        ///@param       RemoteManifestURL : URL from where manifest file can be downloaded. (http://my-server.com/awesomecontent.manifest)
        ///@param       CloudURL :  URL from where content chunk data can be downloaded. (http://my-server.com/awesomecontent/clouddir)
        ///@param       InstallDirectory: Relative directory to where downloaded content should be installed (MyContent/AwesomeContent)
        ///@param       OnSucceeded: Callback on manifest download success. Will return object that represents remote content
        ///@param       OnFailed: Callback on manifest download fail. Will return error message text and error integer code
        ///</remarks>
        public static void RequestContent(string RemoteManifestURL, string CloudURL, string InstallDirectory, byte OnSucceeded /*TODO: delegate FOnRequestContentSucceeded */, byte OnFailed /*TODO: delegate FOnRequestContentFailed */)  => 
            MobilePatchingLibrary_methods.RequestContent_method.Invoke(RemoteManifestURL, CloudURL, InstallDirectory, OnSucceeded, OnFailed);
        static MobilePatchingLibrary() {
            StaticClass = Main.GetClass("MobilePatchingLibrary");
        }
        internal unsafe MobilePatchingLibrary_fields* MobilePatchingLibrary_ptr => (MobilePatchingLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MobilePatchingLibrary(IntPtr p) => UObject.Make<MobilePatchingLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MobilePatchingLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MobilePatchingLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
