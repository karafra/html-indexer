using Core.Data.Contracts;

namespace Core.Data;

public class TreeStorableFile : TreeStorable<string>
{

  public Stream FileReadStream => new FileStream(Value,
    FileMode.Open,
    FileAccess.Read
  );

  public Stream FileWriteStream => new FileStream(Value,
    FileMode.OpenOrCreate,
    FileAccess.Write
  );

  public TreeStorableFile(string filepath) : base(filepath)
  { }

  public override string ToString()
  {
    return base.Value;
  }
}
