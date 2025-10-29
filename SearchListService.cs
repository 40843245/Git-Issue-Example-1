namespace Example
{
  public partial class SearchListService
  {
    public void ProcessRequest(HttpContext context)
    {
      
    }

    private void SearchList(HttpContext context)
    {
      // fix bug #1
      // sort the list when searching
      var unitModelList = new Unit().queryUnitByUnitId(context);
      unitModeList.sort();
    }
  }








}
