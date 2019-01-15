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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>A basic command line console that accepts most commands.</summary>
    public unsafe partial class Console : UObject  {
        ///<summary>The player which the next console command should be executed in the context of.  If nullptr, execute in the viewport.</summary>
        public unsafe LocalPlayer ConsoleTargetPlayer {
            get {return Console_ptr->ConsoleTargetPlayer;}
            set {Console_ptr->ConsoleTargetPlayer = value;}
        }
        ///<summary>Default Texture Black</summary>
        public unsafe Texture2D DefaultTexture_Black {
            get {return Console_ptr->DefaultTexture_Black;}
            set {Console_ptr->DefaultTexture_Black = value;}
        }
        ///<summary>Default Texture White</summary>
        public unsafe Texture2D DefaultTexture_White {
            get {return Console_ptr->DefaultTexture_White;}
            set {Console_ptr->DefaultTexture_White = value;}
        }
         //TODO: array not UObject TArray HistoryBuffer
        static Console() {
            StaticClass = Main.GetClass("Console");
        }
        internal unsafe Console_fields* Console_ptr => (Console_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Console(IntPtr p) => UObject.Make<Console>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Console DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Console New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
