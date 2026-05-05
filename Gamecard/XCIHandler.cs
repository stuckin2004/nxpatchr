using System;
using System.IO;
using Spectre.Console;

// XCI is the file format used to store content on a Nintendo Switch card.
// This is effectively the raw gamecard in digital form, and is the preferred
// method for NXPatcher patches! These files are pretty strange but well
// documented thankfully.
//
// - https://switchbrew.org/wiki/XCI

namespace NXPatchr
{
    public class XCIHandler
    {
        // Simple check for the 'HEAD' string in the XCI header.
        public static bool IsValidXCI(string path)
        {
            if (!File.Exists(path))
            {
                AnsiConsole.MarkupLineInterpolated($"[bold red]✗ Error:[/] The file path provided does not exist!");
                return false;
            }

            using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            if (fs.Length < 0x104)
            {
                AnsiConsole.MarkupLineInterpolated($"[bold red]✗ Error:[/] The file is too small to have a valid header!");
                return false;
            }

            fs.Seek(0x100, SeekOrigin.Begin);
    
            byte[] magic = new byte[4];
            fs.ReadExactly(magic, 0, 4);

            if (magic[0] != 'H' || magic[1] != 'E' || magic[2] != 'A' || magic[3] != 'D')
            {
                AnsiConsole.MarkupLineInterpolated($"[bold red]✗ Error:[/] 'HEAD' magic is malformed!");
                return false;
            }

            AnsiConsole.MarkupLine("[bold green]✓ OK:[/] The 'HEAD' magic is OK!");
            return true;
        }
    }
}