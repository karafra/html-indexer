using Core.Data;
using Core.Data.Structures;

namespace Core.Utilities.File;

internal static partial class Utilities
{
  public static TreeNode<TreeStorableFile> FolderToTree(string pathLike)
  {
    // Convert to absolute path
    var path = Path.GetFullPath(pathLike);
    var output = new TreeNode<TreeStorableFile>(new TreeStorableFile(path));
    // Create queue for traversing direcotry 
    Queue<string> queue = new();
    // Initialize empty output tree
    TreeNode<TreeStorableFile>? currentDirNode = null;
    queue.Enqueue(path);
    while (queue.Count > 0)
    {
      // Get path
      var currentPath = queue.Dequeue();
      // If this is root direcotry
      if (currentDirNode is null)
      {
        currentDirNode = output;
      }
      // If this is subdir
      else
      {
        currentDirNode = currentDirNode.Add(
          new TreeStorableFile(currentPath)
        );
      }
      // Add directories to queue for further processing
      foreach (var subdir in Directory.GetDirectories(currentPath))
      {
        queue.Enqueue(subdir);
      }
      // Traverse current direcotry
      foreach (var file in Directory.GetFiles(currentPath))
      {
        // Add files to directory node
        currentDirNode.Add(new TreeStorableFile(file));
      }
    }
    return output;
  }
}
