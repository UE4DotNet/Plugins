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

using UE4.Engine;

namespace UE4.Localization{
        ///<summary>Localization Import Dialogue Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct LocalizationImportDialogueSettings {
            ///<summary>Path to the folder to import the audio from. This folder is expected to contain culture sub-folders, which in turn contain the raw WAV files to import.</summary>
            [FieldOffset(0)] DirectoryPath RawAudioPath;

            [FieldOffset(16)] byte ImportedDialogueFolder; //TODO: string FString ImportedDialogueFolder

            [FieldOffset(32)] public bool bImportNativeAsSource;

        }
}
