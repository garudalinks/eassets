using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class FileSystem
{
    public int Id { get; set; }

    public string FullPath { get; set; }

    public string Filename { get; set; }

    public string Extension { get; set; }

    public int Size { get; set; }

    public bool IsDirectory { get; set; }

    public string ParentPath { get; set; }

    public string Metadata { get; set; }

    public byte[] Contents { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime LastWriteTime { get; set; }

    public virtual ICollection<FileSystem> InverseParentPathNavigation { get; set; } = new List<FileSystem>();

    public virtual FileSystem ParentPathNavigation { get; set; }
}
