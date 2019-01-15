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
        ///<summary>Holds settings for the import workflow stage of the build promotion test</summary>
        [StructLayout( LayoutKind.Explicit, Size=336 )]
        public unsafe struct BuildPromotionImportWorkflowSettings {
            ///<summary>Import settings for the Diffuse texture</summary>
            [FieldOffset(0)] EditorImportWorkflowDefinition Diffuse;

            ///<summary>Import settings for the Normalmap texture</summary>
            [FieldOffset(32)] EditorImportWorkflowDefinition Normal;

            ///<summary>Import settings for the static mesh</summary>
            [FieldOffset(64)] EditorImportWorkflowDefinition StaticMesh;

            ///<summary>Import settings for the static mesh to re-import</summary>
            [FieldOffset(96)] EditorImportWorkflowDefinition ReimportStaticMesh;

            ///<summary>Import settings for the blend shape</summary>
            [FieldOffset(128)] EditorImportWorkflowDefinition BlendShapeMesh;

            ///<summary>Import settings for the morph mesh</summary>
            [FieldOffset(160)] EditorImportWorkflowDefinition MorphMesh;

            ///<summary>Import settings for the skeletal mesh</summary>
            [FieldOffset(192)] EditorImportWorkflowDefinition SkeletalMesh;

            ///<summary>Import settings for the animation asset.  (Will automatically use the skeleton of the skeletal mesh above)</summary>
            [FieldOffset(224)] EditorImportWorkflowDefinition Animation;

            ///<summary>Import settings for the sound</summary>
            [FieldOffset(256)] EditorImportWorkflowDefinition Sound;

            ///<summary>Import settings for the surround sound (Select any of the channels.  It will auto import the rest)</summary>
            [FieldOffset(288)] EditorImportWorkflowDefinition SurroundSound;

            [FieldOffset(320)] byte OtherAssetsToImport; //TODO: array TArray OtherAssetsToImport

        }
}
