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
using UE4.PIEPreviewDeviceSpecification.Native;

namespace UE4.PIEPreviewDeviceSpecification {
    ///<summary>PIEPreview Device Specification</summary>
    public unsafe partial class PIEPreviewDeviceSpecification : UObject  {
         //TODO: enum EPIEPreviewDeviceType PreviewDeviceType
         //TODO: string FString GPUFamily
         //TODO: string FString GLVersion
         //TODO: string FString VulkanVersion
         //TODO: string FString AndroidVersion
         //TODO: string FString DeviceMake
         //TODO: string FString DeviceModel
         //TODO: string FString DeviceBuildNumber
        public bool UsingHoudini {
            get {return Main.GetGetBoolPropertyByName(this, "UsingHoudini"); }
            set {Main.SetGetBoolPropertyByName(this, "UsingHoudini", value); }
        }
        static PIEPreviewDeviceSpecification() {
            StaticClass = Main.GetClass("PIEPreviewDeviceSpecification");
        }
        internal unsafe PIEPreviewDeviceSpecification_fields* PIEPreviewDeviceSpecification_ptr => (PIEPreviewDeviceSpecification_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PIEPreviewDeviceSpecification(IntPtr p) => UObject.Make<PIEPreviewDeviceSpecification>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PIEPreviewDeviceSpecification DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PIEPreviewDeviceSpecification New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
