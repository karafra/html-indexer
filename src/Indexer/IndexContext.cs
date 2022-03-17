using Core.Data;
using Core.Data.Structures;

namespace Core;
public class IndexContext
{
  public readonly string IndexDirPath;

  public readonly TreeNode<TreeStorableFile> IndexDirTree;

  public readonly string OutputFilePath;

  public IndexContext(string indexDirPath, TreeNode<TreeStorableFile> indexDirTree, string outputFilePath = "index.html")
  {
    IndexDirPath = indexDirPath;
    IndexDirTree = indexDirTree;
    OutputFilePath = outputFilePath;
  } 
}