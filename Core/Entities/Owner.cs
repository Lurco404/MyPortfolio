namespace Core.Entities
{
    public class Owner :EntityBase
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Profil { get; set; }
        public Adress? Adress { get; set; }
    }
}
