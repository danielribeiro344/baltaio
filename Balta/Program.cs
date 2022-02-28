using Balta.ContentContext;


namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo 01", "orientacao-objeto 1"));
            articles.Add(new Article("Artigo 02", "orientacao-objeto 2"));
            articles.Add(new Article("Artigo 03", "orientacao-objeto 3"));
            articles.Add(new Article("Artigo 04", "orientacao-objeto 4"));
            foreach (var percorreItens in articles)
            {
                Console.WriteLine(percorreItens.Id);
                Console.WriteLine(percorreItens.Title);
                Console.WriteLine(percorreItens.Url);
            }

            var courses = new List<Course>();
            var course01 = new Course("Curso 01","curso-01");
            var course02 = new Course("Curso 02", "curso-02");
            var course03 = new Course("Curso 03", "curso-03");

            courses.Add(course01);
            courses.Add(course02);
            courses.Add(course03);

            var careers = new List<Career>();
            var career01 = new Career("Carreira 01","Carreira 02");
            var careerItem = new CareerItem(1 , "Titulo 01" ,"Descricao 01" , null );
            career01.Items.Add(careerItem);
            careers.Add(career01);

            foreach (var carrer in careers)
            {
                Console.WriteLine(carrer.Title);

                foreach (var item in carrer.Items)
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
                

            }



        }

    }

}