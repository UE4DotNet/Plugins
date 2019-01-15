using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UE4.Core;
using UE4.Native;

using IO = System.IO;

namespace UE4 {
    internal class Editor {
        private readonly static string DotNetExe = "dotnet";

        private static string Combine( params string[] frags ) =>
            System.IO.Path.Combine( frags );

        private static string GameDir =>
             Combine( Path.ProjectDir, "DotNet/Game" ).Replace( '/', IO.Path.DirectorySeparatorChar );

        public static void NewGame() {

            var version = Version();
            if (version.StartsWith( "Exception" )) return;
            var templ = Combine( Path.UE4DotNetTemplate, "Game");
            var result = DotNet( $"new -i {templ}" );
            if (result.StartsWith( "Exception" )) return;

            var gameDir = GameDir;
            if (!IO.Directory.Exists( gameDir ))
                IO.Directory.CreateDirectory( gameDir );

            result = DotNet( $"new dotnetgame -o \"{gameDir}\" -n Game" );
        }

        public static void BuildGame() {
            var version = Version();
            if (version.StartsWith( "Exception" )) return;

            var gameDir = GameDir;
            if (!IO.Directory.Exists( gameDir )) {
                Log.Fatal( $"No Game exists.  Use New Game to make a C# game" );
                return;
            }

            var currentDirectory = Environment.CurrentDirectory;
            Environment.CurrentDirectory = gameDir;
            try {
                var result = DotNet($"build -c Debug");
                //result = DotNet( "$build -c Release" );
                Log.Display( result );
            } finally {
                Environment.CurrentDirectory = currentDirectory;
            }

        }

        private static string Version() {
            return DotNet("--version").Trim();
        }

        private static string DotNet(params string[] args) {
            try {
                var process = Process.Start( new ProcessStartInfo {
                    CreateNoWindow = true,
                    ErrorDialog = false,
                    FileName = DotNetExe,
                    Arguments = string.Join(" ", args),
                    RedirectStandardOutput = true,
                    UseShellExecute = false
                } );
                string output = "";
                while (!process.StandardOutput.EndOfStream)
                    output += process.StandardOutput.ReadLine() + '\n';
                return output;
            } catch(System.ComponentModel.Win32Exception ex) {
                Log.Fatal( "DotNet SDK not installed or dotnet is not on system PATH" );
                return $"Exception: {ex.Message}";
            } catch (Exception ex) {
                Log.Fatal( $"DotNet failed: {ex.Message}" );
                return $"Exception: {ex.Message}";
            }
        }
    }
}
