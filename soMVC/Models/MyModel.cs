using System.Collections.Generic;

namespace MyNamespace
{
    public class MyModel
    {
        public MyModel() { ListA = new List<ListAList>(); }
        public bool Use { get; set; }
        public string Name { get; set; }
        public int? ListAId { get; set; }
        public int? ListBId { get; set; }
        public int? ListCId { get; set; }
        public IList<ListAList> ListA { get; set; }
    }

    public class ListAList
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}