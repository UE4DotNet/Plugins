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
using UE4.SlateCore;

namespace UE4.UMG {
    ///<summary>A Throbber widget that shows several zooming circles in a row.</summary>
    public unsafe partial class Throbber : Widget  {

        ///<summary>Sets whether the pieces animate horizontally.</summary>
        public void SetAnimateHorizontally(bool bInAnimateHorizontally)  => 
            Throbber_methods.SetAnimateHorizontally_method.Invoke(ObjPointer, bInAnimateHorizontally);

        ///<summary>Sets whether the pieces animate their opacity.</summary>
        public void SetAnimateOpacity(bool bInAnimateOpacity)  => 
            Throbber_methods.SetAnimateOpacity_method.Invoke(ObjPointer, bInAnimateOpacity);

        ///<summary>Sets whether the pieces animate vertically.</summary>
        public void SetAnimateVertically(bool bInAnimateVertically)  => 
            Throbber_methods.SetAnimateVertically_method.Invoke(ObjPointer, bInAnimateVertically);

        ///<summary>Sets how many pieces there are</summary>
        public void SetNumberOfPieces(int InNumberOfPieces)  => 
            Throbber_methods.SetNumberOfPieces_method.Invoke(ObjPointer, InNumberOfPieces);
        ///<summary>How many pieces there are</summary>
        public unsafe int NumberOfPieces {
            get {return Throbber_ptr->NumberOfPieces;}
        }
        public bool bAnimateHorizontally {
            get {return Main.GetGetBoolPropertyByName(this, "bAnimateHorizontally"); }
        }
        public bool bAnimateVertically {
            get {return Main.GetGetBoolPropertyByName(this, "bAnimateVertically"); }
        }
        public bool bAnimateOpacity {
            get {return Main.GetGetBoolPropertyByName(this, "bAnimateOpacity"); }
        }
        ///<summary>Image</summary>
        public unsafe SlateBrush Image {
            get {return Throbber_ptr->Image;}
        }
        static Throbber() {
            StaticClass = Main.GetClass("Throbber");
        }
        internal unsafe Throbber_fields* Throbber_ptr => (Throbber_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Throbber(IntPtr p) => UObject.Make<Throbber>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Throbber DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Throbber New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
