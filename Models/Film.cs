using System;
namespace TaetrProjekt
{
    public class Film : Entity
    {
        internal string Name { get; set; }
        internal string FilmDirector { get; set; }
        internal decimal Budget { get; set; }
        public override string ToString()
        {
            return $"-----------------\nId:{Id}\n{"Name:",-7}{Name}\n{"FilmDirector:",-7}{FilmDirector}\n{"Budget:",-7}{Budget}\n-----------------\n";
        }
    }
}

