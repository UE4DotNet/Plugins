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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Sheet Builder</summary>
    public unsafe partial class SheetBuilder : EditorBrushBuilder  {
        ///<summary>X</summary>
        public unsafe int X {
            get {return SheetBuilder_ptr->X;}
            set {SheetBuilder_ptr->X = value;}
        }
        ///<summary>Y</summary>
        public unsafe int Y {
            get {return SheetBuilder_ptr->Y;}
            set {SheetBuilder_ptr->Y = value;}
        }
        ///<summary>XSegments</summary>
        public unsafe int XSegments {
            get {return SheetBuilder_ptr->XSegments;}
            set {SheetBuilder_ptr->XSegments = value;}
        }
        ///<summary>YSegments</summary>
        public unsafe int YSegments {
            get {return SheetBuilder_ptr->YSegments;}
            set {SheetBuilder_ptr->YSegments = value;}
        }
        ///<summary>Axis</summary>
        public unsafe byte Axis {
            get {return SheetBuilder_ptr->Axis;}
            set {SheetBuilder_ptr->Axis = value;}
        }
        ///<summary>Group Name</summary>
        public unsafe Name GroupName {
            get {return SheetBuilder_ptr->GroupName;}
            set {SheetBuilder_ptr->GroupName = value;}
        }
        static SheetBuilder() {
            StaticClass = Main.GetClass("SheetBuilder");
        }
        internal unsafe SheetBuilder_fields* SheetBuilder_ptr => (SheetBuilder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SheetBuilder(IntPtr p) => UObject.Make<SheetBuilder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SheetBuilder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SheetBuilder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
