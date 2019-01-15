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


namespace UE4.PluginBrowser.Native {
    [StructLayout( LayoutKind.Explicit, Size=232 )]
    internal unsafe struct PluginMetadataObject_fields {
        [FieldOffset(72)] public int Version;
        [FieldOffset(80)] byte VersionName; //TODO: string FString VersionName
        [FieldOffset(96)] byte FriendlyName; //TODO: string FString FriendlyName
        [FieldOffset(112)] byte Description; //TODO: string FString Description
        [FieldOffset(128)] byte Category; //TODO: string FString Category
        [FieldOffset(144)] byte CreatedBy; //TODO: string FString CreatedBy
        [FieldOffset(160)] byte CreatedByURL; //TODO: string FString CreatedByURL
        [FieldOffset(176)] byte DocsURL; //TODO: string FString DocsURL
        [FieldOffset(192)] byte MarketplaceURL; //TODO: string FString MarketplaceURL
        [FieldOffset(208)] byte SupportURL; //TODO: string FString SupportURL
        [FieldOffset(224)] public bool bCanContainContent;
        [FieldOffset(225)] public bool bIsBetaVersion;
    }
    internal unsafe struct PluginMetadataObject_methods {
    }
    internal unsafe struct PluginMetadataObject_events {
    }
}
