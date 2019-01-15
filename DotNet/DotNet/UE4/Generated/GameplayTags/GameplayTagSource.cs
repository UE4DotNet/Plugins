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


namespace UE4.GameplayTags{
        ///<summary>Struct defining where gameplay tags are loaded/saved from. Mostly for the editor</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct GameplayTagSource {
            [FieldOffset(0)] public Name SourceName;

            [FieldOffset(12)] byte SourceType; //TODO: enum EGameplayTagSourceType SourceType

            [FieldOffset(16)] 
            private IntPtr  SourceTagList_field;
            ///<summary>If this is bound to an ini object for saving, this is the one</summary>
            public GameplayTagsList SourceTagList {
                get {return SourceTagList_field;}
                set {SourceTagList_field = value;}
            }

            [FieldOffset(24)] 
            private IntPtr  SourceRestrictedTagList_field;
            ///<summary>If this has restricted tags and is bound to an ini object for saving, this is the one</summary>
            public RestrictedGameplayTagsList SourceRestrictedTagList {
                get {return SourceRestrictedTagList_field;}
                set {SourceRestrictedTagList_field = value;}
            }

        }
}
