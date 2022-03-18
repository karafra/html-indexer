using utils = HtmlIndexer.Utilities.File;
using HtmlIndexer.Data;
using HtmlIndexer.Data.Structures;

namespace HtmlIndexer;
public class IndexContext
{
  public readonly TreeNode<TreeStorableFile> IndexDirTree;

  public readonly string OutputFilePath;

  protected IndexContext(TreeNode<TreeStorableFile> indexDirTree, string outputFilePath = "index.html")
  {
    IndexDirTree = indexDirTree;
    OutputFilePath = outputFilePath;
  } 

  public IndexContext(string indexDirPath, string outputFilePath) : this(utils.Utilities.FolderToTree(indexDirPath))
  { }
}