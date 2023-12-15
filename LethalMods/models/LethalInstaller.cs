using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LethalMods.models
{
    internal class LethalInstaller
    {
        private string LethalRoot = @Form1.configManager.MenuConfig.STEAM_INSTALLATION_PATH + "\\Lethal Company\\";

        public void InstallLethalMods()
        {
            InstallBepIn();
            InstallPlugins();
            InstallConfigs();
        }

        public void UninstallLethalMods()
        {
            Console.WriteLine(LethalRoot);
            UninstallBepin();
            UninstallConfigs();
            UninstallPlugins();
        }

        private void InstallBepIn()
        {
            DirectoryInfo dir = new DirectoryInfo(LethalRoot);
            DirectoryInfo depDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\dependencies\\");

            EnumerateAndDuplicatedRequiredDir(depDir, dir);
            EnumerateAndDuplicate(depDir, dir);
        }

        private void UninstallBepin()
        {
            DirectoryInfo dir = new DirectoryInfo(LethalRoot + "BepInEx\\");
            DirectoryInfo coreDir = new DirectoryInfo(LethalRoot + "BepInEx\\core\\");
            DirectoryInfo confDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\BepInEx\\");

            EnumerateAndDeleteRequiredDir(confDir, dir);
            DeleteFolderContents(coreDir);
        }

        private void InstallConfigs()
        {
            DirectoryInfo dir = new DirectoryInfo(LethalRoot + "BepInEx\\config\\");
            DirectoryInfo confDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\config\\");

            EnumerateAndDuplicatedRequiredDir(confDir, dir);
            EnumerateAndDuplicate(confDir, dir);
        }

        private void UninstallConfigs()
        {
            DirectoryInfo dir = new DirectoryInfo(LethalRoot + "BepInEx\\config\\");
            DirectoryInfo confDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\config\\");

            EnumerateAndDeleteRequiredDir(confDir, dir);
        }

        private void InstallPlugins()
        {
            DirectoryInfo dir = new DirectoryInfo(LethalRoot + "BepInEx\\plugins\\");
            DirectoryInfo plugDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\plugins\\");

            EnumerateAndDuplicatedRequiredDir(plugDir, dir);
            EnumerateAndDuplicate(plugDir, dir);
        }

        private void UninstallPlugins()
        {
            DirectoryInfo dir = new DirectoryInfo(LethalRoot + "BepInEx\\plugins\\");
            DirectoryInfo plugDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\plugins\\");

            EnumerateAndDeleteRequiredDir(plugDir, dir);
        }

        private void EnumerateAndDeleteRequiredDir(DirectoryInfo root, DirectoryInfo target)
        {
            try
            {
                DeleteFolderContents(target);
                target.Refresh();
                target.Delete();
            }
            catch (Exception ignored) { }

            if (!Directory.Exists(root.FullName)) return;

            foreach (DirectoryInfo info in root.EnumerateDirectories())
            {
                DirectoryInfo targetFolder = new DirectoryInfo(target.FullName + "\\" + info.Name + "\\");

                if(Directory.Exists(targetFolder.FullName))
                {
                    try
                    {
                        targetFolder.Delete();
                    } catch(Exception ex)
                    {
                        DeleteFolderContents(targetFolder);
                        target.Refresh();
                        target.Delete();
                    }
                }
            }
        }

        private void DeleteFolderContents(DirectoryInfo targetFolder)
        {
            foreach(FileInfo info in targetFolder.EnumerateFiles())
            {
                try
                {
                    info.Delete();
                    targetFolder.Refresh();
                    targetFolder.Delete();
                } catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void EnumerateAndDuplicatedRequiredDir(DirectoryInfo root, DirectoryInfo dest)
        {
            foreach (DirectoryInfo info in root.EnumerateDirectories())
            {
                DirectoryInfo newRoot = info;
                DirectoryInfo newDestFolder = new DirectoryInfo(dest.FullName + "\\" + info.Name + "\\");

                if (!newDestFolder.Exists)
                {
                    newDestFolder.Create();
                }

                EnumerateAndDuplicatedRequiredDir(newRoot, newDestFolder);
            }
        }

        private void EnumerateAndDuplicate(DirectoryInfo root, DirectoryInfo dest)
        {
            // 5 attempts to create file and refresh cache
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    if (!dest.Exists)
                    {
                        dest.Create();
                        dest.Refresh();
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            foreach (DirectoryInfo info in root.EnumerateDirectories())
            {
                DirectoryInfo newRoot = info;
                DirectoryInfo newDestFolder = new DirectoryInfo(dest.FullName + "\\" + info.Name + "\\");

                if (!newDestFolder.Exists)
                {
                    newDestFolder.Create();
                }

                EnumerateAndDuplicate(newRoot, newDestFolder);
            }

            foreach (FileInfo info in root.EnumerateFiles())
            {
                BasicInstall install = new BasicInstall(info, dest);

                // 5 attempts
                for (int i = 0; i < 5; i++)
                {
                    if (install.ExecuteInstall() == 1)
                    {
                        break;
                    }
                }
            }
        }
    }
}
