using Core.Data;
using Core.Data.Structures;

namespace Core.Writers;

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

  public virtual ValueTask WritePreambleAsync(CancellationToken cancellationToken = default) => default;

  public virtual ValueTask WriteFileTreeAsync(CancellationToken cancellationToken = default) => default;

  public virtual ValueTask WritePostambleAsync(CancellationToken cancellationToken = default) => default;

  public virtual async ValueTask DisposeAsync() 
  {
    await Stream.DisposeAsync(); 
  }
}
