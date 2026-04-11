using Composite;

using File = Composite.File;

var root = new Folder("Root");
root.Add(new File("file1.txt"));
root.Add(new File("file2.txt"));

var subFolder = new Folder("SubFolder");
subFolder.Add(new File("file3.txt"));

root.Add(subFolder);

root.Display(1);