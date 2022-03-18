using System.Collections;
using HtmlIndexer.Data.Contracts;
namespace HtmlIndexer.Data.Structures;
public partial class TreeNode<T> : IEnumerable<TreeNode<T>> where T : ITReeStorable
{
  public int ChildCount => _children.Count;
  public bool IsLeaf => _children.Count is 0;
  private readonly Dictionary<string, TreeNode<T>> _children =
                                        new Dictionary<string, TreeNode<T>>();

  public readonly T Payload;
  public TreeNode<T>? Parent { get; private set; }

  public TreeNode(T value)
  {
    Payload = value;
  }

  public TreeNode<T> GetChild(string id)
  {
    return this._children[id];
  }

  public TreeNode<T> GetChild(int i)
  {
    var key = this._children.Keys.ToList()[i];
    return GetChild(key);
  }

  public TreeNode<T> Add(TreeNode<T> item)
  {
    if (item.Parent != null)
    {
      item.Parent._children.Remove(item.Payload.Id);
    }
    item.Parent = this;
    this._children.Add(item.Payload.Id, item);
    return item;
  }

  public TreeNode<T> Add(T value)
  {
    return Add(new TreeNode<T>(value));
  }

  public IEnumerator<TreeNode<T>> GetEnumerator()
  {
    return this._children.Values.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }

  public override string ToString()
  {
    var output = "";
    ToString("", ref output);
    return output;
  }

  private void ToString(string indent, ref string output)
  {
    output += $"{indent}├─{Payload} (Id: {Payload.Id})\n";
    indent += IsLeaf ? "   " : "│  ";
    foreach (var child in _children)
    {
      child.Value.ToString(indent, ref output);
    }
  }
}

public partial class TreeNode<T> where T : ITReeStorable
{
  private void ToHtmlString(string indent, ref string output)
  {
    output += $"{indent}├─<a href='{Payload}'> </a>\n";
    indent += IsLeaf ? "   " : "│  ";
    foreach (var child in _children)
    {
      child.Value.ToString(indent, ref output);
    }
  }

  public string ToHtmlString()
  {
    var output = "";
    ToString("", ref output);
    return output;
  }
}