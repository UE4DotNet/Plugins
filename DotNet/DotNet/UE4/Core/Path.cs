using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

using UE4.CoreUObject;
using UE4.Native;

namespace UE4.Core {
    internal unsafe delegate char* GetPathDelegate();

    public static class Path {
        private unsafe static IntPtr LoadInterface() {
            var i = Interfaces.Get("Paths");
            var paths = (PathInteface*) i.ToPointer();
            paths->Validate();
            return i;
        }
        private static Lazy<IntPtr> PathIntefacePointer = new Lazy<IntPtr>(LoadInterface);
        private static unsafe PathInteface* Paths => (PathInteface*) PathIntefacePointer.Value.ToPointer();

        public static string UE4DotNetPath => System.IO.Path.Combine( ProjectPluginsDir, "DotNet" );
        public static string UE4DotNetEditorPath = System.IO.Path.Combine( ProjectPluginsDir, "UE4DotNetEditor" );
        public static string UE4DotNetTemplate = System.IO.Path.Combine(UE4DotNetEditorPath, "Templates");

        public unsafe static string LaunchDir => GetString( Paths->LaunchDirFunction );
        public unsafe static string EngineDir => GetString( Paths->EngineDirFunction );
        public unsafe static string EngineUserDir => GetString( Paths->EngineUserDirFunction );
        public unsafe static string EngineVersionAgnosticUserDir => GetString( Paths->EngineVersionAgnosticUserDirFunction );
        public unsafe static string EngineContentDir => GetString( Paths->EngineContentDirFunction );
        public unsafe static string EngineConfigDir => GetString( Paths->EngineConfigDirFunction );
        public unsafe static string EngineIntermediateDir => GetString( Paths->EngineIntermediateDirFunction );
        public unsafe static string EngineSavedDir => GetString( Paths->EngineSavedDirFunction );
        public unsafe static string EnginePluginsDir => GetString( Paths->EnginePluginsDirFunction );
        public unsafe static string EnterpriseDir => GetString( Paths->EnterpriseDirFunction );
        public unsafe static string EnterprisePluginsDir => GetString( Paths->EnterprisePluginsDirFunction );
        public unsafe static string EnterpriseFeaturePackDir => GetString( Paths->EnterpriseFeaturePackDirFunction );
        public unsafe static string RootDir => GetString( Paths->RootDirFunction );
        public unsafe static string ProjectDir => GetString( Paths->ProjectDirFunction );
        public unsafe static string ProjectUserDir => GetString( Paths->ProjectUserDirFunction );
        public unsafe static string ProjectContentDir => GetString( Paths->ProjectContentDirFunction );
        public unsafe static string ProjectConfigDir => GetString( Paths->ProjectConfigDirFunction );
        public unsafe static string ProjectSavedDir => GetString( Paths->ProjectSavedDirFunction );
        public unsafe static string ProjectIntermediateDir => GetString( Paths->ProjectIntermediateDirFunction );
        public unsafe static string ShaderWorkingDir => GetString( Paths->ShaderWorkingDirFunction );
        public unsafe static string ProjectPluginsDir => GetString( Paths->ProjectPluginsDirFunction );
        public unsafe static string ProjectModsDir => GetString( Paths->ProjectModsDirFunction );
        public unsafe static string ProjectPersistentDownloadDir => GetString( Paths->ProjectPersistentDownloadDirFunction );
        public unsafe static string SourceConfigDir => GetString( Paths->SourceConfigDirFunction );
        public unsafe static string GeneratedConfigDir => GetString( Paths->GeneratedConfigDirFunction );
        public unsafe static string SandboxesDir => GetString( Paths->SandboxesDirFunction );
        public unsafe static string ProfilingDir => GetString( Paths->ProfilingDirFunction );
        public unsafe static string ScreenShotDir => GetString( Paths->ScreenShotDirFunction );
        public unsafe static string BugItDir => GetString( Paths->BugItDirFunction );
        public unsafe static string VideoCaptureDir => GetString( Paths->VideoCaptureDirFunction );
        public unsafe static string ProjectLogDir => GetString( Paths->ProjectLogDirFunction );
        public unsafe static string AutomationDir => GetString( Paths->AutomationDirFunction );
        public unsafe static string AutomationTransientDir => GetString( Paths->AutomationTransientDirFunction );
        public unsafe static string AutomationLogDir => GetString( Paths->AutomationLogDirFunction );
        public unsafe static string CloudDir => GetString( Paths->CloudDirFunction );
        public unsafe static string GameDevelopersDir => GetString( Paths->GameDevelopersDirFunction );
        public unsafe static string GameUserDeveloperDir => GetString( Paths->GameUserDeveloperDirFunction );
        public unsafe static string DiffDir => GetString( Paths->DiffDirFunction );
        public unsafe static string GameAgnosticSavedDir => GetString( Paths->GameAgnosticSavedDirFunction );
        public unsafe static string EngineSourceDir => GetString( Paths->EngineSourceDirFunction );
        public unsafe static string GameSourceDir => GetString( Paths->GameSourceDirFunction );
        public unsafe static string FeaturePackDir => GetString( Paths->FeaturePackDirFunction );
        public unsafe static string GetProjectFilePath => GetString( Paths->GetProjectFilePathFunction );

        private unsafe static string GetString( IntPtr ue4Func ) {
            var func = Marshal.GetDelegateForFunctionPointer<GetPathDelegate>(ue4Func);
            return new string( func() );
        }

        [StructLayout( LayoutKind.Sequential, Pack = 0 )]
        internal struct PathInteface {
            uint StartGuardian;
            uint SizeOfShared;
            int FNameID;

            internal IntPtr LaunchDirFunction;
            internal IntPtr EngineDirFunction;
            internal IntPtr EngineUserDirFunction;
            internal IntPtr EngineVersionAgnosticUserDirFunction;
            internal IntPtr EngineContentDirFunction;
            internal IntPtr EngineConfigDirFunction;
            internal IntPtr EngineIntermediateDirFunction;
            internal IntPtr EngineSavedDirFunction;
            internal IntPtr EnginePluginsDirFunction;
            internal IntPtr EnterpriseDirFunction;
            internal IntPtr EnterprisePluginsDirFunction;
            internal IntPtr EnterpriseFeaturePackDirFunction;
            internal IntPtr RootDirFunction;
            internal IntPtr ProjectDirFunction;
            internal IntPtr ProjectUserDirFunction;
            internal IntPtr ProjectContentDirFunction;
            internal IntPtr ProjectConfigDirFunction;
            internal IntPtr ProjectSavedDirFunction;
            internal IntPtr ProjectIntermediateDirFunction;
            internal IntPtr ShaderWorkingDirFunction;
            internal IntPtr ProjectPluginsDirFunction;
            internal IntPtr ProjectModsDirFunction;
            internal IntPtr ProjectPersistentDownloadDirFunction;
            internal IntPtr SourceConfigDirFunction;
            internal IntPtr GeneratedConfigDirFunction;
            internal IntPtr SandboxesDirFunction;
            internal IntPtr ProfilingDirFunction;
            internal IntPtr ScreenShotDirFunction;
            internal IntPtr BugItDirFunction;
            internal IntPtr VideoCaptureDirFunction;
            internal IntPtr ProjectLogDirFunction;
            internal IntPtr AutomationDirFunction;
            internal IntPtr AutomationTransientDirFunction;
            internal IntPtr AutomationLogDirFunction;
            internal IntPtr CloudDirFunction;
            internal IntPtr GameDevelopersDirFunction;
            internal IntPtr GameUserDeveloperDirFunction;
            internal IntPtr DiffDirFunction;
            internal IntPtr GameAgnosticSavedDirFunction;
            internal IntPtr EngineSourceDirFunction;
            internal IntPtr GameSourceDirFunction;
            internal IntPtr FeaturePackDirFunction;
            internal IntPtr GetProjectFilePathFunction;

            uint EndGuardian;

            public void Validate() {
                var size = Marshal.SizeOf<PathInteface>();
                Debug.Assert( StartGuardian == 0x12345678 &&
                    EndGuardian == 0x87654321 &&
                    SizeOfShared == size
                    );
            }
        }

    }
}
