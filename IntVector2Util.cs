public class IntVector2Util
{

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

  public static IntVector2[] Translate(IntVector2[] input, IntVector2 vector, IntVector2 offset)
  {
    IntVector2[] retval = new IntVector2[input.Length];
    for(int i=0;i < input.Length; i++)
    {
      IntVector2 pos = input[i];
      retval[i] = new IntVector2((vector.x * pos.x) + offset.x, (vector.y * pos.y) + offset.y);
    }
    return retval;
  }

  public static int Distance(IntVector2 a, IntVector2 b)
  {
    
  }

}