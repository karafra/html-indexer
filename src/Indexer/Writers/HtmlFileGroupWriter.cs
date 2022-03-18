using HtmlIndexer.Data;
using HtmlIndexer.Data.Structures;
using HtmlIndexer.Writers.Html.Index;
namespace HtmlIndexer.Writers;


public class HtmlFileGroupWriter : IndexWriter
{
  private readonly TextWriter _writer;

  public HtmlFileGroupWriter(Stream stream, TreeNode<TreeStorableFile> context)
   : base(stream, context)
  {
    _writer = new StreamWriter(stream);
  }

  internal override async ValueTask WritePreambleAsync(CancellationToken cancellationToken = default)
  {
    var templateContext = new PostambleContext("1.0");
    await _writer.WriteLineAsync(
      await PostambleTemplate.RenderAsync(templateContext, cancellationToken)
    );
  }

  internal override async ValueTask WritePostambleAsync(CancellationToken cancellationToken = default)
  {
    var templateContext = new PreambleContext("1.0");
    await _writer.WriteLineAsync(
      await PreambleTemplate.RenderAsync(templateContext, cancellationToken)
    );
  }

  internal override async ValueTask WriteFileTreeAsync(CancellationToken cancellationToken = default)
  {
    var templateContext = new FileGroupContext(base.Context);
    await _writer.WriteLineAsync(
      await FileGroupTemplate.RenderAsync(templateContext, cancellationToken)
    );
  }

  public override async ValueTask DisposeAsync()
  {
    await _writer.DisposeAsync();
    await base.DisposeAsync();
  }

}
