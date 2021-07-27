using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileManager {
    internal class FileManager {
        public string FolderPath { get; set; }
        public int FileCount { get; }
        public List<string> Files { get; }

        public FileManager() {
            if (Directory.Exists(FolderPath)) {
                Files = Directory.EnumerateFiles(FolderPath).ToList();
                FileCount = Files.Count;
            }
        }
    }
}
