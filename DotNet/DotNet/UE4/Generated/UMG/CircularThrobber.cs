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
    ///<summary>A throbber widget that orients images in a spinning circle.</summary>
    ///<remarks>
    ///* No Children
    ///* Spinner Progress
    ///</remarks>
    public unsafe partial class CircularThrobber : Widget  {

        ///<summary>Sets how many pieces there are.</summary>
        public void SetNumberOfPieces(int InNumberOfPieces)  => 
            CircularThrobber_methods.SetNumberOfPieces_method.Invoke(ObjPointer, InNumberOfPieces);

        ///<summary>Sets the amount of time for a full circle (in seconds).</summary>
        public void SetPeriod(float InPeriod)  => 
            CircularThrobber_methods.SetPeriod_method.Invoke(ObjPointer, InPeriod);

        ///<summary>Sets the radius of the circle.</summary>
        public void SetRadius(float InRadius)  => 
            CircularThrobber_methods.SetRadius_method.Invoke(ObjPointer, InRadius);
        ///<summary>How many pieces there are</summary>
        public unsafe int NumberOfPieces {
            get {return CircularThrobber_ptr->NumberOfPieces;}
        }
        ///<summary>The amount of time for a full circle (in seconds)</summary>
        public unsafe float Period {
            get {return CircularThrobber_ptr->Period;}
        }
        ///<summary>The radius of the circle. If the throbber is a child of Canvas Panel, the 'Size to Content' option must be enabled in order to set Radius.</summary>
        public unsafe float Radius {
            get {return CircularThrobber_ptr->Radius;}
        }
        ///<summary>Image</summary>
        public unsafe SlateBrush Image {
            get {return CircularThrobber_ptr->Image;}
        }
        public bool bEnableRadius {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableRadius"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableRadius", value); }
        }
        static CircularThrobber() {
            StaticClass = Main.GetClass("CircularThrobber");
        }
        internal unsafe CircularThrobber_fields* CircularThrobber_ptr => (CircularThrobber_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CircularThrobber(IntPtr p) => UObject.Make<CircularThrobber>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CircularThrobber DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CircularThrobber New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
