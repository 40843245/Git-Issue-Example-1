$document.ready(
    let editableItems = GetEditableItems();
);

function GetEditableItems()
{
  let editableItems = [];
  $(".items").on("selected",function(){
      editableItems.add($(this));
  })
  return editableItems;
}
