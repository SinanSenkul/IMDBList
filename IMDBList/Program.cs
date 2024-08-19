using System;

namespace IMDBList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminate = false;
            List<Film> filmList = new List<Film>();
            do
            {
                Console.WriteLine("filmin adını giriniz:");
                string filmName = Console.ReadLine();
                Console.WriteLine("filmin puanını giriniz:");
                int filmPts = Convert.ToInt32(Console.ReadLine());
                Film newFilm = new Film(filmName, filmPts);
                filmList.Add(newFilm);
                Console.WriteLine("sonlandırmak için 's' tuşuna, devam etmek için diğer herhangi bir tuşa basınız");
                string trm = Console.ReadLine();
                if (trm == "s")
                {
                    terminate = true;
                }
            }
            while (!terminate);

            // lists all the films:
            Console.WriteLine("*** all the films ***");
            foreach (Film film in filmList)
            {
                Console.WriteLine($"{film.Name} - {film.Pts}");
            }

            // lists films with pts between 4 and 9
            List<Film> filmsPts4To5 = new List<Film>();
            for (int i = 0; i < filmList.Count; i++)
            {
                if (filmList[i].Pts > 4 && filmList[i].Pts < 9)
                {
                    filmsPts4To5.Add(filmList[i]);
                }
            }
            Console.WriteLine("*** films with scores between 4 to 9 ***");
            foreach (Film film in filmsPts4To5)
            {
                Console.WriteLine($"{film.Name} - {film.Pts}");
            }

            // lists films which start with letter 'a'
            List<Film> filmsStartWithA = new List<Film>();
            for (int i = 0; i < filmList.Count; i++)
            {
                if (filmList[i].Name.Substring(0, 1).ToUpper() == "A")
                {
                    filmsStartWithA.Add(filmList[i]);
                }
            }
            Console.WriteLine("*** films which starts with 'a' ***");
            foreach (Film film in filmsStartWithA)
            {
                Console.WriteLine($"{film.Name} - {film.Pts}");
            }
        }
    }
}