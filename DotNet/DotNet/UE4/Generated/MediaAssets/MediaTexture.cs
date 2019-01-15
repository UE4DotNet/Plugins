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
using UE4.MediaAssets.Native;
using UE4.Engine;

namespace UE4.MediaAssets {
    ///<summary>Implements a texture asset for rendering video tracks from UMediaPlayer assets.</summary>
    public unsafe partial class MediaTexture : Texture  {

        ///<summary>Gets the current aspect ratio of the texture.</summary>
        ///<remarks>
        ///@return Texture aspect ratio.
        ///@see GetHeight, GetWidth
        ///</remarks>
        public float GetAspectRatio()  => 
            MediaTexture_methods.GetAspectRatio_method.Invoke(ObjPointer);

        ///<summary>Gets the current height of the texture.</summary>
        ///<remarks>
        ///@return Texture height (in pixels).
        ///@see GetAspectRatio, GetWidth
        ///</remarks>
        public int GetHeight()  => 
            MediaTexture_methods.GetHeight_method.Invoke(ObjPointer);

        ///<summary>Get the media player that provides the video samples.</summary>
        ///<remarks>
        ///@return The texture's media player, or nullptr if not set.
        ///@see SetMediaPlayer
        ///</remarks>
        public MediaPlayer GetMediaPlayer()  => 
            MediaTexture_methods.GetMediaPlayer_method.Invoke(ObjPointer);

        ///<summary>Gets the current width of the texture.</summary>
        ///<remarks>
        ///@return Texture width (in pixels).
        ///@see GetAspectRatio, GetHeight
        ///</remarks>
        public int GetWidth()  => 
            MediaTexture_methods.GetWidth_method.Invoke(ObjPointer);

        ///<summary>Set the media player that provides the video samples.</summary>
        ///<remarks>
        ///@param NewMediaPlayer The player to set.
        ///@see GetMediaPlayer
        ///</remarks>
        public void SetMediaPlayer(MediaPlayer NewMediaPlayer)  => 
            MediaTexture_methods.SetMediaPlayer_method.Invoke(ObjPointer, NewMediaPlayer);
        ///<summary>The addressing mode to use for the X axis.</summary>
        public unsafe byte AddressX {
            get {return MediaTexture_ptr->AddressX;}
            set {MediaTexture_ptr->AddressX = value;}
        }
        ///<summary>The addressing mode to use for the Y axis.</summary>
        public unsafe byte AddressY {
            get {return MediaTexture_ptr->AddressY;}
            set {MediaTexture_ptr->AddressY = value;}
        }
        public bool AutoClear {
            get {return Main.GetGetBoolPropertyByName(this, "AutoClear"); }
            set {Main.SetGetBoolPropertyByName(this, "AutoClear", value); }
        }
        ///<summary>The color used to clear the texture if AutoClear is enabled (default = black).</summary>
        public unsafe LinearColor ClearColor {
            get {return MediaTexture_ptr->ClearColor;}
            set {MediaTexture_ptr->ClearColor = value;}
        }
        ///<summary>The media player asset associated with this texture.</summary>
        ///<remarks>
        ///This property is meant for design-time convenience. To change the
        ///associated media player at run-time, use the SetMediaPlayer method.
        ///
        ///@see SetMediaPlayer
        ///</remarks>
        public unsafe MediaPlayer MediaPlayer {
            get {return MediaTexture_ptr->MediaPlayer;}
            set {MediaTexture_ptr->MediaPlayer = value;}
        }
        static MediaTexture() {
            StaticClass = Main.GetClass("MediaTexture");
        }
        internal unsafe MediaTexture_fields* MediaTexture_ptr => (MediaTexture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MediaTexture(IntPtr p) => UObject.Make<MediaTexture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MediaTexture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MediaTexture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
