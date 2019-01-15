#include "PathsInterface.h"
#include "CLRHost.h"
#include "Paths.h"

//TODO: Missing Is functions from FPaths

using GetPathFunction = const TCHAR * (*)();
using GetFStringFunction = FString(__cdecl *)();

static FString PathsResult;

struct PathsInterface {
	GetPathFunction LaunchDirFunction;
	GetPathFunction EngineDirFunction;
	GetPathFunction EngineUserDirFunction;
	GetPathFunction EngineVersionAgnosticUserDirFunction;
	GetPathFunction EngineContentDirFunction;
	GetPathFunction EngineConfigDirFunction;
	GetPathFunction EngineIntermediateDirFunction;
	GetPathFunction EngineSavedDirFunction;
	GetPathFunction EnginePluginsDirFunction;
	GetPathFunction EnterpriseDirFunction;
	GetPathFunction EnterprisePluginsDirFunction;
	GetPathFunction EnterpriseFeaturePackDirFunction;
	GetPathFunction RootDirFunction;
	GetPathFunction ProjectDirFunction;
	GetPathFunction ProjectUserDirFunction;
	GetPathFunction ProjectContentDirFunction;
	GetPathFunction ProjectConfigDirFunction;
	GetPathFunction ProjectSavedDirFunction;
	GetPathFunction ProjectIntermediateDirFunction;
	GetPathFunction ShaderWorkingDirFunction;
	GetPathFunction ProjectPluginsDirFunction;
	GetPathFunction ProjectModsDirFunction;
	GetPathFunction ProjectPersistentDownloadDirFunction;
	GetPathFunction SourceConfigDirFunction;
	GetPathFunction GeneratedConfigDirFunction;
	GetPathFunction SandboxesDirFunction;
	GetPathFunction ProfilingDirFunction;
	GetPathFunction ScreenShotDirFunction;
	GetPathFunction BugItDirFunction;
	GetPathFunction VideoCaptureDirFunction;
	GetPathFunction ProjectLogDirFunction;
	GetPathFunction AutomationDirFunction;
	GetPathFunction AutomationTransientDirFunction;
	GetPathFunction AutomationLogDirFunction;
	GetPathFunction CloudDirFunction;
	GetPathFunction GameDevelopersDirFunction;
	GetPathFunction GameUserDeveloperDirFunction;
	GetPathFunction DiffDirFunction;
	GetPathFunction GameAgnosticSavedDirFunction;
	GetPathFunction EngineSourceDirFunction;
	GetPathFunction GameSourceDirFunction;
	GetPathFunction FeaturePackDirFunction;
	GetPathFunction GetProjectFilePathFunction;

	static auto CopyToPathsResult(GetFStringFunction fn) {
		PathsResult = fn();
		return *PathsResult;
	}

	PathsInterface() {
#define MakeLambda(fn) []() { return CopyToPathsResult(fn); };
		LaunchDirFunction = MakeLambda(FPaths::LaunchDir);
		EngineDirFunction = MakeLambda(FPaths::EngineDir);
		EngineUserDirFunction = MakeLambda(FPaths::EngineUserDir);
		EngineVersionAgnosticUserDirFunction = MakeLambda(FPaths::EngineVersionAgnosticUserDir);
		EngineContentDirFunction = MakeLambda(FPaths::EngineContentDir);
		EngineConfigDirFunction = MakeLambda(FPaths::EngineConfigDir);
		EngineIntermediateDirFunction = MakeLambda(FPaths::EngineIntermediateDir);
		EngineSavedDirFunction = MakeLambda(FPaths::EngineSavedDir);
		EnginePluginsDirFunction = MakeLambda(FPaths::EnginePluginsDir);
		EnterpriseDirFunction = MakeLambda(FPaths::EnterpriseDir);
		EnterprisePluginsDirFunction = MakeLambda(FPaths::EnterprisePluginsDir);
		EnterpriseFeaturePackDirFunction = MakeLambda(FPaths::EnterpriseFeaturePackDir);
		RootDirFunction = MakeLambda(FPaths::RootDir);
		ProjectDirFunction = MakeLambda(FPaths::ProjectDir);
		ProjectUserDirFunction = MakeLambda(FPaths::ProjectUserDir);
		ProjectContentDirFunction = MakeLambda(FPaths::ProjectContentDir);
		ProjectConfigDirFunction = MakeLambda(FPaths::ProjectConfigDir);
		ProjectSavedDirFunction = MakeLambda(FPaths::ProjectSavedDir);
		ProjectIntermediateDirFunction = MakeLambda(FPaths::ProjectIntermediateDir);
		ShaderWorkingDirFunction = MakeLambda(FPaths::ShaderWorkingDir);
		ProjectPluginsDirFunction = MakeLambda(FPaths::ProjectPluginsDir);
		ProjectModsDirFunction = MakeLambda(FPaths::ProjectModsDir);
		ProjectPersistentDownloadDirFunction = MakeLambda(FPaths::ProjectPersistentDownloadDir);
		SourceConfigDirFunction = MakeLambda(FPaths::SourceConfigDir);
		GeneratedConfigDirFunction = MakeLambda(FPaths::GeneratedConfigDir);
		SandboxesDirFunction = MakeLambda(FPaths::SandboxesDir);
		ProfilingDirFunction = MakeLambda(FPaths::ProfilingDir);
		ScreenShotDirFunction = MakeLambda(FPaths::ScreenShotDir);
		BugItDirFunction = MakeLambda(FPaths::BugItDir);
		VideoCaptureDirFunction = MakeLambda(FPaths::VideoCaptureDir);
		ProjectLogDirFunction = MakeLambda(FPaths::ProjectLogDir);
		AutomationDirFunction = MakeLambda(FPaths::AutomationDir);
		AutomationTransientDirFunction = MakeLambda(FPaths::AutomationTransientDir);
		AutomationLogDirFunction = MakeLambda(FPaths::AutomationLogDir);
		CloudDirFunction = MakeLambda(FPaths::CloudDir);
		GameDevelopersDirFunction = MakeLambda(FPaths::GameDevelopersDir);
		GameUserDeveloperDirFunction = MakeLambda(FPaths::GameUserDeveloperDir);
		DiffDirFunction = MakeLambda(FPaths::DiffDir);
		GameAgnosticSavedDirFunction = MakeLambda(FPaths::GameAgnosticSavedDir);
		EngineSourceDirFunction = MakeLambda(FPaths::EngineSourceDir);
		GameSourceDirFunction = MakeLambda(FPaths::GameSourceDir);
		FeaturePackDirFunction = MakeLambda(FPaths::FeaturePackDir);
		GetProjectFilePathFunction = MakeLambda(FPaths::GetProjectFilePath);
#undef MakeLambda
	}
};
static const FName PathsName("Paths");

static DotNetInterface<PathsInterface> Paths(PathsName);

void PushPathsInterface(CLRHost& clrHost) {
	clrHost.PushInteface(PathsName, &Paths);
}
