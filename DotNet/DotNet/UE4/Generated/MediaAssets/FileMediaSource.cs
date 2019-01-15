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

namespace UE4.MediaAssets {
    ///<summary>File Media Source</summary>
    public unsafe partial class FileMediaSource : BaseMediaSource  {

        ///<summary>Set the path to the media file that this source represents.</summary>
        ///<remarks>
        ///Automatically converts full paths to media sources that reside in the
        ///Engine's or project's /Content/Movies directory into relative paths.
        ///
        ///@param Path The path to set.
        ///@see FilePath, GetFilePath
        ///</remarks>
        public void SetFilePath(string Path)  => 
            FileMediaSource_methods.SetFilePath_method.Invoke(ObjPointer, Path);
         //TODO: string FString FilePath
        public bool PrecacheFile {
            get {return Main.GetGetBoolPropertyByName(this, "PrecacheFile"); }
            set {Main.SetGetBoolPropertyByName(this, "PrecacheFile", value); }
        }
        static FileMediaSource() {
            StaticClass = Main.GetClass("FileMediaSource");
        }
        internal unsafe FileMediaSource_fields* FileMediaSource_ptr => (FileMediaSource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FileMediaSource(IntPtr p) => UObject.Make<FileMediaSource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FileMediaSource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FileMediaSource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
