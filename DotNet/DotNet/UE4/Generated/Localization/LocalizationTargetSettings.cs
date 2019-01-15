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


namespace UE4.Localization{
        ///<summary>Localization Target Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        public unsafe struct LocalizationTargetSettings {
            [FieldOffset(0)] byte Name; //TODO: string FString Name

            ///<summary>Guid</summary>
            [FieldOffset(16)] FGuid FGuid;

            [FieldOffset(32)] byte ConflictStatus; //TODO: enum ELocalizationTargetConflictStatus ConflictStatus

            [FieldOffset(40)] byte TargetDependencies; //TODO: array TArray TargetDependencies

            [FieldOffset(56)] byte AdditionalManifestDependencies; //TODO: array TArray AdditionalManifestDependencies

            [FieldOffset(72)] byte RequiredModuleNames; //TODO: array TArray RequiredModuleNames

            ///<summary>Parameters for defining what text is gathered from text files and how.</summary>
            [FieldOffset(88)] GatherTextFromTextFilesConfiguration GatherFromTextFiles;

            ///<summary>Parameters for defining what text is gathered from packages and how.</summary>
            [FieldOffset(152)] GatherTextFromPackagesConfiguration GatherFromPackages;

            ///<summary>Parameters for defining what text is gathered from metadata and how.</summary>
            [FieldOffset(232)] GatherTextFromMetaDataConfiguration GatherFromMetaData;

            ///<summary>Settings for exporting translations.</summary>
            [FieldOffset(296)] LocalizationExportingSettings ExportSettings;

            ///<summary>Settings for compiling translations.</summary>
            [FieldOffset(299)] LocalizationCompilationSettings CompileSettings;

            ///<summary>Settings for importing dialogue from WAV files.</summary>
            [FieldOffset(304)] LocalizationImportDialogueSettings ImportDialogueSettings;

            [FieldOffset(344)] public int NativeCultureIndex;

            [FieldOffset(352)] byte SupportedCulturesStatistics; //TODO: array TArray SupportedCulturesStatistics

        }
}
