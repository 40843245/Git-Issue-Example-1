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

    private void SetStatusOfItems(HttpContext context)
    {
      // complete task #5
      // sort the list when searching
      var selectedIndex = this.Items.SelectedIndex;
      var unitModelList = new Unit().queryUnitByUnitId(context);
      var selectedItems = unitModelList.GetSelectedItems(selectedIndex); 
      this.Items.Where(item=>item.SelectedIndex == selectedIndex).Selected = true;
    }
  }








}
