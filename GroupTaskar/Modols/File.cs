using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IWshRuntimeLibrary;
using System.Windows.Shapes;


namespace GroupTaskar.Modols
{
    public class File
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public string Args { get; set; }


        public string Dir { get; set; }


        public string? Icon { get; set; }

        public int WindowStyle { get; set; }

        public static Icon? GetFileIcon(string path)
        {
            return System.Drawing.Icon.ExtractAssociatedIcon(path);
        }

        public static File LoadFileInfo(string path)
        {
            FileInfo oFileInfo = new FileInfo(path);
            File file = new File();
            if (oFileInfo.LinkTarget != null)
                path = oFileInfo.LinkTarget;
            if (oFileInfo.Exists && path.EndsWith(".lnk"))
            {
                WshShell shell = new WshShell(); //Create a new WshShell Interface
                IWshShortcut link = (IWshShortcut)shell.CreateShortcut(path); //Link the interface to our shortcut
                file.Path = link.TargetPath;
                file.Args = link.Arguments;
                file.Dir = link.WorkingDirectory;
                file.Name = link.FullName;
                file.Icon = link.IconLocation;
                file.WindowStyle = link.WindowStyle;
            }
            else if (oFileInfo.Exists)
            {
                file.Path = path;
                file.Name = oFileInfo.Name;
            }

            return file;

        }
    }
}
