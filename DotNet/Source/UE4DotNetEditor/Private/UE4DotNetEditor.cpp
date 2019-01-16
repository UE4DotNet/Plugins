// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#include "UE4DotNetEditor.h"
#include "UE4DotNetEditorStyle.h"
#include "UE4DotNetEditorCommands.h"
#include "Slate.h"
#include "Misc/MessageDialog.h"
#include "Framework/MultiBox/MultiBoxBuilder.h"
#include "DotNet.h"

#include "LevelEditor.h"

static const FName UE4DotNetEditorTabName("UE4DotNetEditor");

#define LOCTEXT_NAMESPACE "FUE4DotNetEditorModule"

void FUE4DotNetEditorModule::StartupModule()
{
	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module
	
	FUE4DotNetEditorStyle::Initialize();
	FUE4DotNetEditorStyle::ReloadTextures();

	FUE4DotNetEditorCommands::Register();
	

	PluginCommands = MakeShareable(new FUICommandList);

	PluginCommands->MapAction(
		FUE4DotNetEditorCommands::Get().NewGameAction,
		FExecuteAction::CreateRaw(this, &FUE4DotNetEditorModule::NewGame)
		);

	PluginCommands->MapAction(
		FUE4DotNetEditorCommands::Get().NewClassAction,
		FExecuteAction::CreateRaw(this, &FUE4DotNetEditorModule::NewClass),
		FCanExecuteAction());

	PluginCommands->MapAction(
		FUE4DotNetEditorCommands::Get().BuildGameAction,
		FExecuteAction::CreateRaw(this, &FUE4DotNetEditorModule::BuildGame),
		FCanExecuteAction());

	PluginCommands->MapAction(
		FUE4DotNetEditorCommands::Get().PlayGameAction,
		FExecuteAction::CreateRaw(this, &FUE4DotNetEditorModule::PlayGame),
		FCanExecuteAction());

	PluginCommands->MapAction(
		FUE4DotNetEditorCommands::Get().DebugGameAction,
		FExecuteAction::CreateRaw(this, &FUE4DotNetEditorModule::DebugGame),
		FCanExecuteAction());

	FLevelEditorModule& LevelEditorModule = FModuleManager::LoadModuleChecked<FLevelEditorModule>("LevelEditor");
	
	{
		TSharedPtr<FExtender> ToolbarExtender = MakeShareable(new FExtender);
		ToolbarExtender->AddToolBarExtension("Settings", EExtensionHook::After, PluginCommands, FToolBarExtensionDelegate::CreateRaw(this, &FUE4DotNetEditorModule::AddToolbarExtension));
		
		LevelEditorModule.GetToolBarExtensibilityManager()->AddExtender(ToolbarExtender);
	}
}

void FUE4DotNetEditorModule::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
	FUE4DotNetEditorStyle::Shutdown();

	FUE4DotNetEditorCommands::Unregister();
}

void FUE4DotNetEditorModule::NewGame()
{
	FDotNetModule::GetModule()->NewGame();
}

void FUE4DotNetEditorModule::NewClass()
{
	FDotNetModule::GetModule()->NewClass();
}

void FUE4DotNetEditorModule::BuildGame()
{
	FDotNetModule::GetModule()->BuildGame();
}

void FUE4DotNetEditorModule::PlayGame()
{
	FDotNetModule::GetModule()->PlayGame();
}

void FUE4DotNetEditorModule::DebugGame()
{
	FDotNetModule::GetModule()->DebugGame();
}

void FUE4DotNetEditorModule::PluginButtonClicked()
{
	FText DialogText = FText::Format(
							LOCTEXT("PluginButtonDialogText", "Add code to {0} in {1} to override this button's actions"),
							FText::FromString(TEXT("FUE4DotNetEditorModule::PluginButtonClicked()")),
							FText::FromString(TEXT("UE4DotNetEditor.cpp"))
					   );
	FMessageDialog::Open(EAppMsgType::Ok, DialogText);
}

void FUE4DotNetEditorModule::AddToolbarExtension(FToolBarBuilder& Builder)
{	
	Builder.AddComboButton(
		FUIAction(),
		FOnGetContent::CreateRaw(this, &FUE4DotNetEditorModule::GenerateDotNettMenu, PluginCommands),
		LOCTEXT("DotNet_Label", "DotNet"),
		LOCTEXT("DotNet_ToolTip", "DotNet Commands"),
		FSlateIcon(FUE4DotNetEditorStyle::GetStyleSetName(), "UE4DotNetEditor.PluginAction")
	);
}

TSharedRef< SWidget > FUE4DotNetEditorModule::GenerateDotNettMenu(TSharedPtr<class FUICommandList> Commands) const
{
	FMenuBuilder MenuBuilder(true, Commands);

	MenuBuilder.BeginSection("CustomMenu", TAttribute<FText>(FText::FromString("DotNet")));
	MenuBuilder.AddMenuEntry(FUE4DotNetEditorCommands::Get().DebugGameAction);
	//MenuBuilder.AddMenuEntry(FUE4DotNetEditorCommands::Get().PlayGameAction);
	MenuBuilder.AddMenuEntry(FUE4DotNetEditorCommands::Get().BuildGameAction);
	MenuBuilder.AddMenuSeparator();
	//TODO: Add New Class menu item
	//MenuBuilder.AddMenuEntry(FUE4DotNetEditorCommands::Get().NewClassAction);
	MenuBuilder.AddMenuEntry(FUE4DotNetEditorCommands::Get().NewGameAction);
	MenuBuilder.EndSection();

	return MenuBuilder.MakeWidget();
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FUE4DotNetEditorModule, UE4DotNetEditor)