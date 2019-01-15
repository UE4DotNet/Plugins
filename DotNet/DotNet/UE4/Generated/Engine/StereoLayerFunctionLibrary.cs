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
    ///<summary>StereoLayer Extensions Function Library</summary>
    public unsafe partial class StereoLayerFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Enables/disables splash screen to be automatically shown when LoadMap is called.</summary>
        ///<remarks>
        ///@param       bAutoShowEnabled        (in)    True, if automatic showing of splash screens is enabled when map is being loaded.
        ///</remarks>
        public static void EnableAutoLoadingSplashScreen(bool InAutoShowEnabled)  => 
            StereoLayerFunctionLibrary_methods.EnableAutoLoadingSplashScreen_method.Invoke(InAutoShowEnabled);

        ///<summary>Hide the splash screen and return to normal display.</summary>
        public static void HideSplashScreen()  => 
            StereoLayerFunctionLibrary_methods.HideSplashScreen_method.Invoke();

        ///<summary>
        ///Set splash screen attributes
        ///@
        ///</summary>
        ///<remarks>
        ///param Texture                        (in) A texture to be used for the splash. B8R8G8A8 format.
        ///@param Scale                          (in) Scale of the texture.
        ///@param Offset                         (in) Position from which to start rendering the texture.
        ///@param ShowLoadingMovie       (in) Whether the splash screen presents loading movies.
        ///</remarks>
        public static void SetSplashScreen(Texture Texture, Vector2D Scale, Vector2D Offset, bool bShowLoadingMovie, bool bShowOnSet)  => 
            StereoLayerFunctionLibrary_methods.SetSplashScreen_method.Invoke(Texture, Scale, Offset, bShowLoadingMovie, bShowOnSet);

        ///<summary>Show the splash screen and override the VR display</summary>
        public static void ShowSplashScreen()  => 
            StereoLayerFunctionLibrary_methods.ShowSplashScreen_method.Invoke();
        static StereoLayerFunctionLibrary() {
            StaticClass = Main.GetClass("StereoLayerFunctionLibrary");
        }
        internal unsafe StereoLayerFunctionLibrary_fields* StereoLayerFunctionLibrary_ptr => (StereoLayerFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator StereoLayerFunctionLibrary(IntPtr p) => UObject.Make<StereoLayerFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static StereoLayerFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static StereoLayerFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
