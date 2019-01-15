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
using UE4.Paper2D.Native;
using UE4.Engine;

namespace UE4.Paper2D {
    ///<summary>APaperCharacter behaves like ACharacter, but uses a UPaperFlipbookComponent instead of a USkeletalMeshComponent as a visual representation</summary>
    ///<remarks>Note: The variable named Mesh will not be set up on this actor!</remarks>
    public unsafe partial class PaperCharacter : Character  {
        ///<summary>The main skeletal mesh associated with this Character (optional sub-object).</summary>
        public unsafe PaperFlipbookComponent Sprite {
            get {return PaperCharacter_ptr->Sprite;}
        }
        static PaperCharacter() {
            StaticClass = Main.GetClass("PaperCharacter");
        }
        internal unsafe PaperCharacter_fields* PaperCharacter_ptr => (PaperCharacter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperCharacter(IntPtr p) => UObject.Make<PaperCharacter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperCharacter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperCharacter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
