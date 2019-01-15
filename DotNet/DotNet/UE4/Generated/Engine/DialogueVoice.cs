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
    ///<summary>Dialogue Voice</summary>
    public unsafe partial class DialogueVoice : UObject  {
        ///<summary>Gender</summary>
        public unsafe byte Gender {
            get {return DialogueVoice_ptr->Gender;}
            set {DialogueVoice_ptr->Gender = value;}
        }
        ///<summary>Plurality</summary>
        public unsafe byte Plurality {
            get {return DialogueVoice_ptr->Plurality;}
            set {DialogueVoice_ptr->Plurality = value;}
        }
        ///<summary>Localization GUID</summary>
        public unsafe FGuid LocalizationGUID {
            get {return DialogueVoice_ptr->LocalizationGUID;}
            set {DialogueVoice_ptr->LocalizationGUID = value;}
        }
        static DialogueVoice() {
            StaticClass = Main.GetClass("DialogueVoice");
        }
        internal unsafe DialogueVoice_fields* DialogueVoice_ptr => (DialogueVoice_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DialogueVoice(IntPtr p) => UObject.Make<DialogueVoice>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DialogueVoice DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DialogueVoice New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
