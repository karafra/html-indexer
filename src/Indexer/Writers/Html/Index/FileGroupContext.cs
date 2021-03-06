using HtmlIndexer.Data;
using HtmlIndexer.Data.Structures;

namespace HtmlIndexer.Writers.Html.Index;

internal class FileGroupContext
{
  public TreeNode<TreeStorableFile> DirectoryTree { get; }

  public string Title { get; }

  public FileGroupContext(
    TreeNode<TreeStorableFile> root,
    string title
    )
  {
    Title = title;
    DirectoryTree = root;
  }

  public FileGroupContext(
    TreeNode<TreeStorableFile> root
  )
  : this(root, "")
  { }

}