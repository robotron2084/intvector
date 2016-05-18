[System.Serializable]
public struct IntVector2
{

  public static IntVector2 zero = new IntVector2(0,0);
  public static IntVector2 neg1 = new IntVector2(-1,-1);
  public static IntVector2 one = new IntVector2(1,1);

  public int x;
  public int y;

  public IntVector2(int x1, int y1)
  {
    x = x1;
    y = y1;
  }

  public IntVector2 Right()
  {
    return new IntVector2(x+1, y);
  }

  public IntVector2 Left()
  {
    return new IntVector2(x-1, y);
  }

  public IntVector2 Up()
  {
    return new IntVector2(x, y+1);
  }

  public IntVector2 Down()
  {
    return new IntVector2(x, y-1);
  }

  public IntVector2 UpRight()
  {
    return new IntVector2(x+1, y+1);
  }
  
  public IntVector2 UpLeft()
  {
    return new IntVector2(x-1, y+1);
  }

  public IntVector2 DownRight()
  {
    return new IntVector2(x+1, y-1);
  }
  
  public IntVector2 DownLeft()
  {
    return new IntVector2(x-1, y-1);
  }
  
  public override string ToString()
  {
    return "["+x+","+y+"]";
  }

  public static explicit operator IntVector2(Vector2 v)
  {
    return new IntVector2((int)v.x, (int)v.y);
  }

  public override bool Equals(object obj) 
  {
    return obj is IntVector2 && this == (IntVector2)obj;
  }

  public override int GetHashCode() 
  {
    return x.GetHashCode() ^ y.GetHashCode();
  }
  public static bool operator ==(IntVector2 a, IntVector2 b ) 
  {
    return a.x == b.x && a.y == b.y;
  }
  public static bool operator !=(IntVector2 a, IntVector2 b ) 
  {
    return !(a == b);
  }

}