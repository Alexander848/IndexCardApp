using IndexCardAppModel;

namespace Model
{
    internal class IndexCardSet
    {
        public long Id { get; set; }
        public string Name { get; set; } = "No Name";
        public List<IndexCard> IndexCards { get; set; } = new();
    }
}
