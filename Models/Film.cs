using System;
namespace TaetrProjekt
{
	public class Film:Entity
	{
		internal string Name { get; set; }
		internal string FilmDirector { get; set; }
		internal decimal Budget { get; set; }
        public override string ToString()
        {
            return $"name:{Name}\nFilmDirector:{FilmDirector}\nBudget:{Budget}";
        }
    }
}

