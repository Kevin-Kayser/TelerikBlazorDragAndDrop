namespace BlazorDragAndDrop.Data
{
    public class ItemModel
    {
        public int Id { get; set; }
        public ItemStatuses Status { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}