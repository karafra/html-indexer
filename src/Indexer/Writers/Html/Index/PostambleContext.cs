namespace Core.Writers.Html.Index;

internal class PostambleContext
{
  public string Version { get; }

  public PostambleContext(
    string version
  )
  {
    Version = version;
  }
}