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
    ///<summary>Allows you to place content with a desired size and have it scale to meet the constraints placed on this box's alloted area.</summary>
    ///<remarks>
    ///If
    ///you needed to have a background image scale to fill an area but not become distorted with different aspect ratios, or if you need
    ///to auto fit some text to an area, this is the control for you.
    ///
    ///* Single Child
    ///* Aspect Ratio
    ///</remarks>
    public unsafe partial class ScaleBox : ContentWidget  {

        ///<summary>Set Ignore Inherited Scale</summary>
        public void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale)  => 
            ScaleBox_methods.SetIgnoreInheritedScale_method.Invoke(ObjPointer, bInIgnoreInheritedScale);

        ///<summary>Set Stretch</summary>
        public void SetStretch(byte InStretch)  => 
            ScaleBox_methods.SetStretch_method.Invoke(ObjPointer, InStretch);

        ///<summary>Set Stretch Direction</summary>
        public void SetStretchDirection(byte InStretchDirection)  => 
            ScaleBox_methods.SetStretchDirection_method.Invoke(ObjPointer, InStretchDirection);

        ///<summary>Set User Specified Scale</summary>
        public void SetUserSpecifiedScale(float InUserSpecifiedScale)  => 
            ScaleBox_methods.SetUserSpecifiedScale_method.Invoke(ObjPointer, InUserSpecifiedScale);
        ///<summary>The stretching rule to apply when content is stretched</summary>
        public unsafe byte Stretch {
            get {return ScaleBox_ptr->Stretch;}
        }
        ///<summary>Controls in what direction content can be scaled</summary>
        public unsafe byte StretchDirection {
            get {return ScaleBox_ptr->StretchDirection;}
        }
        ///<summary>Optional scale that can be specified by the User. Used only for UserSpecified stretching.</summary>
        public unsafe float UserSpecifiedScale {
            get {return ScaleBox_ptr->UserSpecifiedScale;}
        }
        public bool IgnoreInheritedScale {
            get {return Main.GetGetBoolPropertyByName(this, "IgnoreInheritedScale"); }
        }
        public bool bSingleLayoutPass {
            get {return Main.GetGetBoolPropertyByName(this, "bSingleLayoutPass"); }
        }
        static ScaleBox() {
            StaticClass = Main.GetClass("ScaleBox");
        }
        internal unsafe ScaleBox_fields* ScaleBox_ptr => (ScaleBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ScaleBox(IntPtr p) => UObject.Make<ScaleBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ScaleBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ScaleBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
