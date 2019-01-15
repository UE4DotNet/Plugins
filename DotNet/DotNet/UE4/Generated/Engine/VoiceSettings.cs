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
        ///<summary>Voice Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct VoiceSettings {
            [FieldOffset(0)] 
            private IntPtr  ComponentToAttachTo_field;
            ///<summary>
            ///Optionally attach the voice source to a Scene Component to give the appearance
            ///that the voice is coming from that scene component.
            ///</summary>
            ///<remarks>If this is not set, the voice will not be spatialized.</remarks>
            public SceneComponent ComponentToAttachTo {
                get {return ComponentToAttachTo_field;}
                set {ComponentToAttachTo_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  AttenuationSettings_field;
            ///<summary>Optional attenuation settings to attach to this player's voice.</summary>
            ///<remarks>This should only be used when ComponentToAttachTo is set.</remarks>
            public SoundAttenuation AttenuationSettings {
                get {return AttenuationSettings_field;}
                set {AttenuationSettings_field = value;}
            }

            [FieldOffset(16)] 
            private IntPtr  SourceEffectChain_field;
            ///<summary>Optional audio effects to apply to this player's voice.</summary>
            public SoundEffectSourcePresetChain SourceEffectChain {
                get {return SourceEffectChain_field;}
                set {SourceEffectChain_field = value;}
            }

        }
}
