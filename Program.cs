namespace session4assiment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Book book = new Book();
           // Console.WriteLine(book.password); //exeption because password can not accesssable out side its class
            #endregion

            #region Q2
            Console.WriteLine(book.copiesInStock); // copiesInStock can be accessable in the same project
            #endregion

            #region Q3
            book.Title = "clean code";
            Console.WriteLine(book.Title);
            #endregion

            #region Q4
            book.Genre = Genre.Science;
            Console.WriteLine(book.Genre);
            #endregion

            #region Q5
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion

            #region Q6
            int genreNumber = 1;
            Genre genre = (Genre)genreNumber;
            Console.WriteLine(genre);
            #endregion

            #region Q7
            Genre genre1 = Genre.Fiction;
            string result=genre1.ToString();
            Console.WriteLine(result);
            #endregion

            #region Q8
            /*string genreText = "Science";

            Genre genre2 = (Genre)Enum.Parse(typeof(Genre), genreText);

            Console.WriteLine(genre2);*/
            #endregion

            #region Q9
            string genreText = "Mystery";
            Genre genre3;
            bool isParsed= Enum.TryParse<Genre>(genreText, out genre3);
            Console.WriteLine(isParsed);
           if(!isParsed)
            {
                Console.WriteLine("Unknown genre");
            }
            else
            {
                Console.WriteLine(genre3);
            }

            #endregion
        }
    }
}
