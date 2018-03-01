
namespace Fradogmi2018.Entities {

  public class Ride {
    public int Id;

    public int BestStart;
    public int MaxEnd;
    public int StartX;
    public int StartY;
    public int EndX;
    public int EndY;

    public Ride(int id, int bestStart, int maxEnd, int startX, int startY, int endX, int endY) {
      Id = id;
      BestStart = bestStart;
      MaxEnd = maxEnd;
      StartX = startX;
      StartY = startY;
      EndX = endX;
      EndY = endY;
    }

  }

}