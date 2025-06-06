using System.Collections.Generic;

namespace Program1
{
  public class Video
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }

    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
      Title = title;
      Author = author;
      Length = length;
      Comments = new List<Comment>();
    }

    public int GetCommentCount()
    {
      return Comments.Count;
    }
  }
}
