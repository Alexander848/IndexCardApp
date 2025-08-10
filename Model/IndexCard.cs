namespace IndexCardAppModel
{
    public class IndexCard
    {
        public long Id { get; set; }
        public long SetId { get; set; }
        public string Name { get; set; } = "No Name";
        public string Question { get; set; } = "No Question";
        public string Answer { get; set; } = "No Answer";
        public int AlreadyAnsweredCount { get; set; }
    }
}
