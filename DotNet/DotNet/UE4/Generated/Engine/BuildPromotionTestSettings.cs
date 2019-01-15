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
        ///<summary>Holds settings for the editor build promotion test</summary>
        [StructLayout( LayoutKind.Explicit, Size=496 )]
        public unsafe struct BuildPromotionTestSettings {
            ///<summary>Default static mesh asset to apply materials to *</summary>
            [FieldOffset(0)] FilePath DefaultStaticMeshAsset;

            ///<summary>Import workflow settings *</summary>
            [FieldOffset(16)] BuildPromotionImportWorkflowSettings ImportWorkflow;

            ///<summary>Open assets settings *</summary>
            [FieldOffset(352)] BuildPromotionOpenAssetSettings OpenAssets;

            ///<summary>New project settings *</summary>
            [FieldOffset(448)] BuildPromotionNewProjectSettings NewProjectSettings;

            ///<summary>Material to modify for the content browser step *</summary>
            [FieldOffset(480)] FilePath SourceControlMaterial;

        }
}
