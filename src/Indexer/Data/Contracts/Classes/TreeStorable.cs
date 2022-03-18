
namespace HtmlIndexer.Data.Contracts;
public abstract class TreeStorable<T> : ITReeStorable
{
  public string Id { get; }
  public T Value { get; set; }

  public TreeStorable(string id, T value)
  {
    Id = id;
    Value = value;
  }

  public TreeStorable(T value) : this(Guid.NewGuid().ToString(), value)
  { }

  public abstract override string ToString();

}
