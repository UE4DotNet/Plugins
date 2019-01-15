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


namespace UE4.AssetTools{
        ///<summary>Asset Rename Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct AssetRenameData {
            [FieldOffset(0)] byte Asset; //TODO: weak object TWeakObjectPtr<UObject> Asset

            [FieldOffset(8)] byte NewPackagePath; //TODO: string FString NewPackagePath

            [FieldOffset(24)] byte NewName; //TODO: string FString NewName

            ///<summary>Full path to old name, in form /Game/SubDirectory/OldName.OldName:SubPath</summary>
            [FieldOffset(40)] SoftObjectPath OldObjectPath;

            ///<summary>New full path, may be a SubObject</summary>
            [FieldOffset(72)] SoftObjectPath NewObjectPath;

            [FieldOffset(104)] public bool bOnlyFixSoftReferences;

        }
}
