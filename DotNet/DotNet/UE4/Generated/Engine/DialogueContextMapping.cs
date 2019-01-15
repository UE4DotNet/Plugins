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


namespace UE4.Engine{
        ///<summary>Dialogue Context Mapping</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct DialogueContextMapping {
            ///<summary>The context of the dialogue.</summary>
            [FieldOffset(0)] DialogueContext Context;

            [FieldOffset(24)] 
            private IntPtr  SoundWave_field;
            ///<summary>The soundwave to play for this dialogue.</summary>
            public SoundWave SoundWave {
                get {return SoundWave_field;}
                set {SoundWave_field = value;}
            }

            [FieldOffset(32)] byte LocalizationKeyFormat; //TODO: string FString LocalizationKeyFormat

            [FieldOffset(48)] 
            private IntPtr  Proxy_field;
            ///<summary>Cached object for playing the soundwave with subtitle information included.</summary>
            public DialogueSoundWaveProxy Proxy {
                get {return Proxy_field;}
                set {Proxy_field = value;}
            }

        }
}
