using HtmlIndexer.Data;
using HtmlIndexer.Data.Structures;

namespace HtmlIndexer.Writers;

public abstract class IndexWriter : IAsyncDisposable
{
  protected Stream Stream { get; }

  protected TreeNode<TreeStorableFile> Context { get; }

  public long MessagesWritten { get; private set; }

  public long BytesWritten => Stream.Length;

  protected IndexWriter(Stream stream, TreeNode<TreeStorableFile> context)
  {
    Stream = stream;
    Context = context;
  }

  internal virtual ValueTask WritePreambleAsync(CancellationToken cancellationToken = default) => default;

  internal virtual ValueTask WriteFileTreeAsync(CancellationToken cancellationToken = default) => default;

  internal virtual ValueTask WritePostambleAsync(CancellationToken cancellationToken = default) => default;

  public virtual async ValueTask DisposeAsync() 
  {
    await Stream.DisposeAsync(); 
  }

  public virtual async ValueTask GenerateIndex(CancellationToken cancellationToken = default)
  {
    await WritePostambleAsync();
    await WriteFileTreeAsync();
    await WritePostambleAsync();
  }
}
