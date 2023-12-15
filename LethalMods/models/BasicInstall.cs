using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LethalMods.models
{
    internal class BasicInstall
    {
        public FileInfo OriginalFile { get; set; }
        public DirectoryInfo CopyDirectory { get; set; }

        public BasicInstall(FileInfo OriginalFile, DirectoryInfo NewDirectory)
        {
            this.OriginalFile = OriginalFile;
            this.CopyDirectory = NewDirectory;
        }

        public int ExecuteInstall()
        {
            if (OriginalFile.Exists)
            {
                if (CopyDirectory.Exists)
                {
                    try
                    {
                        File.Copy(OriginalFile.FullName, CopyDirectory.FullName + "\\" + OriginalFile.Name);
                    }
                    catch (Exception ignored) { }
                    return 1;
                } else
                {
                   try
                    {
                        CopyDirectory.Create();
                    } catch(Exception ignored) { }
                }
            }
            return -1;
        }
    }
}
