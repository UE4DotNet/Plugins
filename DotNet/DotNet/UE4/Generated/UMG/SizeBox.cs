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
using UE4.UMG.Native;

namespace UE4.UMG {
    ///<summary>A widget that allows you to specify the size it reports to have and desire.</summary>
    ///<remarks>
    ///Not all widgets report a desired size
    ///that you actually desire.  Wrapping them in a SizeBox lets you have the Size Box force them to be a particular size.
    ///
    ///* Single Child
    ///* Fixed Size
    ///</remarks>
    public unsafe partial class SizeBox : ContentWidget  {

        ///<summary>Clear Height Override</summary>
        public void ClearHeightOverride()  => 
            SizeBox_methods.ClearHeightOverride_method.Invoke(ObjPointer);

        ///<summary>Clear Max Aspect Ratio</summary>
        public void ClearMaxAspectRatio()  => 
            SizeBox_methods.ClearMaxAspectRatio_method.Invoke(ObjPointer);

        ///<summary>Clear Max Desired Height</summary>
        public void ClearMaxDesiredHeight()  => 
            SizeBox_methods.ClearMaxDesiredHeight_method.Invoke(ObjPointer);

        ///<summary>Clear Max Desired Width</summary>
        public void ClearMaxDesiredWidth()  => 
            SizeBox_methods.ClearMaxDesiredWidth_method.Invoke(ObjPointer);

        ///<summary>Clear Min Desired Height</summary>
        public void ClearMinDesiredHeight()  => 
            SizeBox_methods.ClearMinDesiredHeight_method.Invoke(ObjPointer);

        ///<summary>Clear Min Desired Width</summary>
        public void ClearMinDesiredWidth()  => 
            SizeBox_methods.ClearMinDesiredWidth_method.Invoke(ObjPointer);

        ///<summary>Clear Width Override</summary>
        public void ClearWidthOverride()  => 
            SizeBox_methods.ClearWidthOverride_method.Invoke(ObjPointer);

        ///<summary>When specified, ignore the content's desired size and report the HeightOverride as the Box's desired height.</summary>
        public void SetHeightOverride(float InHeightOverride)  => 
            SizeBox_methods.SetHeightOverride_method.Invoke(ObjPointer, InHeightOverride);

        ///<summary>Set Max Aspect Ratio</summary>
        public void SetMaxAspectRatio(float InMaxAspectRatio)  => 
            SizeBox_methods.SetMaxAspectRatio_method.Invoke(ObjPointer, InMaxAspectRatio);

        ///<summary>When specified, will report the MaxDesiredHeight if smaller than the content's desired height.</summary>
        public void SetMaxDesiredHeight(float InMaxDesiredHeight)  => 
            SizeBox_methods.SetMaxDesiredHeight_method.Invoke(ObjPointer, InMaxDesiredHeight);

        ///<summary>When specified, will report the MaxDesiredWidth if smaller than the content's desired width.</summary>
        public void SetMaxDesiredWidth(float InMaxDesiredWidth)  => 
            SizeBox_methods.SetMaxDesiredWidth_method.Invoke(ObjPointer, InMaxDesiredWidth);

        ///<summary>When specified, will report the MinDesiredHeight if larger than the content's desired height.</summary>
        public void SetMinDesiredHeight(float InMinDesiredHeight)  => 
            SizeBox_methods.SetMinDesiredHeight_method.Invoke(ObjPointer, InMinDesiredHeight);

        ///<summary>When specified, will report the MinDesiredWidth if larger than the content's desired width.</summary>
        public void SetMinDesiredWidth(float InMinDesiredWidth)  => 
            SizeBox_methods.SetMinDesiredWidth_method.Invoke(ObjPointer, InMinDesiredWidth);

        ///<summary>When specified, ignore the content's desired size and report the WidthOverride as the Box's desired width.</summary>
        public void SetWidthOverride(float InWidthOverride)  => 
            SizeBox_methods.SetWidthOverride_method.Invoke(ObjPointer, InWidthOverride);
        public bool bOverride_WidthOverride {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_WidthOverride"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_WidthOverride", value); }
        }
        public bool bOverride_HeightOverride {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_HeightOverride"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_HeightOverride", value); }
        }
        public bool bOverride_MinDesiredWidth {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_MinDesiredWidth"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_MinDesiredWidth", value); }
        }
        public bool bOverride_MinDesiredHeight {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_MinDesiredHeight"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_MinDesiredHeight", value); }
        }
        public bool bOverride_MaxDesiredWidth {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_MaxDesiredWidth"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_MaxDesiredWidth", value); }
        }
        public bool bOverride_MaxDesiredHeight {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_MaxDesiredHeight"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_MaxDesiredHeight", value); }
        }
        public bool bOverride_MaxAspectRatio {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_MaxAspectRatio"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_MaxAspectRatio", value); }
        }
        ///<summary>When specified, ignore the content's desired size and report the WidthOverride as the Box's desired width.</summary>
        public unsafe float WidthOverride {
            get {return SizeBox_ptr->WidthOverride;}
        }
        ///<summary>When specified, ignore the content's desired size and report the HeightOverride as the Box's desired height.</summary>
        public unsafe float HeightOverride {
            get {return SizeBox_ptr->HeightOverride;}
        }
        ///<summary>When specified, will report the MinDesiredWidth if larger than the content's desired width.</summary>
        public unsafe float MinDesiredWidth {
            get {return SizeBox_ptr->MinDesiredWidth;}
        }
        ///<summary>When specified, will report the MinDesiredHeight if larger than the content's desired height.</summary>
        public unsafe float MinDesiredHeight {
            get {return SizeBox_ptr->MinDesiredHeight;}
        }
        ///<summary>When specified, will report the MaxDesiredWidth if smaller than the content's desired width.</summary>
        public unsafe float MaxDesiredWidth {
            get {return SizeBox_ptr->MaxDesiredWidth;}
        }
        ///<summary>When specified, will report the MaxDesiredHeight if smaller than the content's desired height.</summary>
        public unsafe float MaxDesiredHeight {
            get {return SizeBox_ptr->MaxDesiredHeight;}
        }
        ///<summary>Max Aspect Ratio</summary>
        public unsafe float MaxAspectRatio {
            get {return SizeBox_ptr->MaxAspectRatio;}
        }
        static SizeBox() {
            StaticClass = Main.GetClass("SizeBox");
        }
        internal unsafe SizeBox_fields* SizeBox_ptr => (SizeBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SizeBox(IntPtr p) => UObject.Make<SizeBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SizeBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SizeBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
