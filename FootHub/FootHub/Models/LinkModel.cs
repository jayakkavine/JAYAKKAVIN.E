namespace FootHub.Models
{
    public class LinkModel
    {
        public int PId { get; set; }

        public string PName { get; set; } = null!;

        public string PDisc { get; set; } = null!;

        public int Size { get; set; }

        public int Price { get; set; }

        public int TotalStock { get; set; }

        public string PImage { get; set; } = null!;

        public string TName { get;set; }
        public string OName { get; set; }
        public string BName { get; set; }


    }
}
