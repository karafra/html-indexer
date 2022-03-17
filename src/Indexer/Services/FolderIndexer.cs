using Core;
using Core.Writers;

namespace Core;

public partial class FolderIndexer : IAsyncDisposable
{
  private readonly IndexContext _context;
  private HtmlFileGroupWriter? _writer;

  public FolderIndexer(Stream stream, IndexContext context)
  {
    _context = context;
    _writer = new HtmlFileGroupWriter(stream, context.IndexDirTree);
  }

  private async ValueTask ResetWriter()
  {
    if (_writer is not null)
    {
      await _writer.WritePostambleAsync();
      await _writer.DisposeAsync();
      _writer = null;
    }
  }
  public async ValueTask DisposeAsync() => await ResetWriter();

  public async ValueTask<HtmlFileGroupWriter> GetWriterAsync(CancellationToken cancellationToken)
  {
    if (_writer is not null)
    {
      return _writer;
    }
    var dirTree = _context.IndexDirTree;
    string filePath = _context.OutputFilePath;
    string dirPath = _context.IndexDirPath;
    Stream stream = File.Create(filePath);
    var writer = new HtmlFileGroupWriter(stream, dirTree);
    await writer.WritePreambleAsync(cancellationToken);
    return _writer = writer;
  }

  public async ValueTask WriteDirindexAsync(CancellationToken cancellationToken)
  {
    var writer = await GetWriterAsync(cancellationToken);
    await writer.WriteFileTreeAsync();
  }
}
public partial class FolderIndexer
{
  public static HtmlFileGroupWriter CreateWriter(IndexContext context)
  {
    var stream = File.Create(context.OutputFilePath);
    return new HtmlFileGroupWriter(stream, context.IndexDirTree);
  }
}