namespace Example
{
  public static class DisplayHelper
  {
    public static void Display(
      this string text
    )
    {
      HttpContext.Current.Write($"'{text}'");
    }
  }
}
