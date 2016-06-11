public class IntVector2Util
{

  /**
   * Takes the given array of vectors and adds the given offest to them.
   * This is useful if you have a set of points, say a movement path, but
   * need to apply it to the current unit's position.
   */
  public static IntVector2[] Offset(IntVector2[] input, IntVector2 offset)
  {
    IntVector2[] retval = new IntVector2[input.Length];
    for(int i=0;i < input.Length; i++)
    {
      IntVector2 pos = input[i];
      retval[i] = new IntVector2(offset.x + pos.x, offset.y + pos.y);
    }
    return retval;
  }

  public static IntVector2 Offset(IntVector2 pos, IntVector2 offset)
  {
    return new IntVector2(pos.x + offset.x, pos.y + offset.y);
  }

  public static IntVector2 xRot0 = new IntVector2(1,0);
  public static IntVector2 yRot0 = new IntVector2(0,1);

  public static IntVector2 xRot90 = new IntVector2(0,-1);
  public static IntVector2 yRot90 = new IntVector2(1,0);

  public static IntVector2 xRot180 = new IntVector2(-1,0);
  public static IntVector2 yRot180 = new IntVector2(0,-1);

  public static IntVector2 xRot270 = new IntVector2(0,1);
  public static IntVector2 yRot270 = new IntVector2(-1,0);

  /**
   * Rotates in 90 degree increments and then translates the points with the 
   * given offset.
     */
  public static IntVector2[] Rotate(IntVector2[] input, int rotation, IntVector2 offset)
  {
    IntVector2 xRot = xRot0;
    IntVector2 yRot = yRot0;
    switch(rotation)
    {
      case 0:
      //default
      break;
      case 90:
      case -270:
      xRot = xRot90;
      yRot = yRot90;
      break;
      case 180:
      xRot = xRot180;
      yRot = yRot180;
      break;
      case 270:
      case -90:
      xRot = xRot270;
      yRot = yRot270;
      break;
      default:
      throw new System.Exception("Rotate() requires 90 degree rotations.");
    }

    IntVector2[] retval = new IntVector2[input.Length];
    for(int i=0;i < input.Length; i++)
    {
      IntVector2 pos = input[i];
      int x = pos.x * xRot.x + pos.y * xRot.y;
      int y = pos.x * yRot.x + pos.y * yRot.y;
      retval[i] = new IntVector2(x  + offset.x, y + offset.y);
    }
    return retval;
  }

  public static IntVector2 GetDirection(IntVector2 start, IntVector2 end)
  {
    if(start.x == end.x)
    {
      //no east/west
      if(start.y == end.y)
      {
        return IntVector2.zero;
      }else if(start.y < end.y)
      {
        return IntVector2.north;
      }else{
        return IntVector2.south;
      }

    }else if(start.x < end.x)
    {
      //east
      if(start.y == end.y)
      {
        return IntVector2.east;
      }else if(start.y < end.y)
      {
        return IntVector2.northeast;
      }else{
        return IntVector2.southeast;
      }

    }else
    {
      //west
      if(start.y == end.y)
      {
        return IntVector2.west;
      }else if(start.y < end.y)
      {
        return IntVector2.northwest;
      }else{
        return IntVector2.southwest;
      }
    }
  }

}