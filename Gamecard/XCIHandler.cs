using System;
using System.IO;

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
                Console.Error.WriteLine("[xci] [error]: The path provided doesn't exist!");
                return false;
            }

            using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            if (fs.Length < 0x104)
            {
                Console.Error.WriteLine("[xci] [error]: The file provided isn't large enough to have a header!");
                return false;
            }

            fs.Seek(0x100, SeekOrigin.Begin);
    
            byte[] magic = new byte[4];
            fs.ReadExactly(magic, 0, 4);

            return magic[0] == 'H' && magic[1] == 'E' && magic[2] == 'A' && magic[3] == 'D';
        }
    }
}