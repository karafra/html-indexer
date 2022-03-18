namespace HtmlIndexer.Writers.Html.Index;

internal class PreambleContext
{
  public string Version { get; }

  public string Title { get; }

  public PreambleContext(
    string version,
    string title
  )
  {
    Version = version;
    Title = title;
  }

  public PreambleContext(
    string version
  )
  :
  this(version, "")
  { }
}