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


namespace UE4.EngineSettings.Native {
    [StructLayout( LayoutKind.Explicit, Size=296 )]
    internal unsafe struct GeneralProjectSettings_fields {
        [FieldOffset(56)] byte CompanyName; //TODO: string FString CompanyName
        [FieldOffset(72)] byte CompanyDistinguishedName; //TODO: string FString CompanyDistinguishedName
        [FieldOffset(88)] byte CopyrightNotice; //TODO: string FString CopyrightNotice
        [FieldOffset(104)] byte Description; //TODO: string FString Description
        [FieldOffset(120)] byte Homepage; //TODO: string FString Homepage
        [FieldOffset(136)] byte LicensingTerms; //TODO: string FString LicensingTerms
        [FieldOffset(152)] byte PrivacyPolicy; //TODO: string FString PrivacyPolicy
        [FieldOffset(168)] public FGuid ProjectID;
        [FieldOffset(184)] byte ProjectName; //TODO: string FString ProjectName
        [FieldOffset(200)] byte ProjectVersion; //TODO: string FString ProjectVersion
        [FieldOffset(216)] byte SupportContact; //TODO: string FString SupportContact
        [FieldOffset(232)] byte ProjectDisplayedTitle; //TODO: text FText ProjectDisplayedTitle
        [FieldOffset(256)] byte ProjectDebugTitleInfo; //TODO: text FText ProjectDebugTitleInfo
        [FieldOffset(280)] public bool bShouldWindowPreserveAspectRatio;
        [FieldOffset(281)] public bool bUseBorderlessWindow;
        [FieldOffset(282)] public bool bStartInVR;
        [FieldOffset(285)] public bool bAllowWindowResize;
        [FieldOffset(286)] public bool bAllowClose;
        [FieldOffset(287)] public bool bAllowMaximize;
        [FieldOffset(288)] public bool bAllowMinimize;
    }
    internal unsafe struct GeneralProjectSettings_methods {
    }
    internal unsafe struct GeneralProjectSettings_events {
    }
}
