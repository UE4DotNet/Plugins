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
    ///<summary>Mobile Installed Content</summary>
    public unsafe partial class MobileInstalledContent : UObject  {

        ///<summary>Get the disk free space in megabytes where content is installed</summary>
        public float GetDiskFreeSpace()  => 
            MobileInstalledContent_methods.GetDiskFreeSpace_method.Invoke(ObjPointer);

        ///<summary>Get the installed content size in megabytes</summary>
        public float GetInstalledContentSize()  => 
            MobileInstalledContent_methods.GetInstalledContentSize_method.Invoke(ObjPointer);

        ///<summary>
        ///Mount installed content
        ///@
        ///</summary>
        ///<remarks>
        ///param       PakOrder : Content pak priority
        ///@param       MountPoint : Path to mount the pak at
        ///</remarks>
        public bool Mount(int PakOrder, string MountPoint)  => 
            MobileInstalledContent_methods.Mount_method.Invoke(ObjPointer, PakOrder, MountPoint);
        static MobileInstalledContent() {
            StaticClass = Main.GetClass("MobileInstalledContent");
        }
        internal unsafe MobileInstalledContent_fields* MobileInstalledContent_ptr => (MobileInstalledContent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MobileInstalledContent(IntPtr p) => UObject.Make<MobileInstalledContent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MobileInstalledContent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MobileInstalledContent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
