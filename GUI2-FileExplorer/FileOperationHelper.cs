using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI2_FileExplorer
{
    class FileOperationHelper
    {
        public static void OpenFile(string _path)
        {
            try
            {
                Process.Start(_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static bool Rename(string _oldName, string _newName)
        {
            bool success = true;
            try
            {
                File.Move(_oldName, _newName);
            }
            catch
            {
                success = false;
                try
                {
                    Directory.Move(_oldName, _newName);
                    success = true;
                }
                catch
                {
                    success = false;
                }
            }
            return success;
        }
        public static bool Copy(string _oldName, string _newName)
        {
            bool success = true;
            try
            {
                File.Copy(_oldName, _newName);
            }
            catch
            {
                success = false;
                try
                {
                    DirectoryCopy(_oldName, _newName, true);
                    success = true;
                }
                catch
                {
                    success = false;
                }
            }
            return success;
        }
        public static string UpFolder(string _path)
        {
            if (string.IsNullOrEmpty(_path))
                return _path;
            if (_path[_path.Length - 1] == '\\')
                _path = _path.Remove(_path.Length - 1);
            string[] partPath = _path.Split('\\');
            if (_path.Substring(_path.Length - 1, 1) == ":")
                _path += Path.DirectorySeparatorChar;
            if (partPath.Length < 2 || !_path.Contains(@"\"))
                return _path;
            if (partPath[partPath.Length - 1].Length > 0)
                _path = _path.Remove(_path.Length - partPath[partPath.Length - 1].Length);
            return _path;

        }
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }
    }
}