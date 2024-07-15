
                            //Class of Book
class Book
{
   public string TitleofBook;
   public string AuthorofBook;
   public int BookID;

    public Book(string Booktitle, string Bookauthor, int bookID)
    {
        TitleofBook = Booktitle;
        AuthorofBook = Bookauthor;
        BookID = bookID;
    }
       public override string ToString()
    {
        return $"Title: {TitleofBook}, Author: {AuthorofBook}, BookID: {BookID}";
    }

                             // Class of Person
    class Person
    {
       public string PersonName;
       public  int PersonAge;
       public  int PersonID;

        public Person(string name, int age, int ID)
        {
            PersonName = name;
            PersonAge = age;
            PersonID = ID;
        }

        public override string ToString()
        {
            return $"Person: {PersonName}, Age: {PersonAge}, ID: {PersonID}";

        }
    }

                            // Class of Librarian
    class Librarian : Person
    {
        int EmployeeID;
        public Librarian(string name, int age, int ID, int employee_id): base(name,age, ID) 
        {
            EmployeeID = employee_id;
        }

        public void bookissue(Book book,Person person)
        {
            Console.WriteLine($"{book.TitleofBook} issued to {person.PersonName}");
            List<Book> issuebooks = new List<Book>();
            foreach(Book i in issuebooks)
            {
                issuebooks.Add(i);
            }
        }
        public void bookreturn(Book book, Person person)
        {
            Console.WriteLine($"{book.TitleofBook} returned by {person.PersonName}");
        }

    }
                            // Class of library
    class Library
    {
       public string LibraryName;
        public int LibraryID;
        List<Book> BookList = new List<Book>();
        Librarian librarian = new Librarian("Wahab", 30, 05, 220);
        public Library(string name_library, int ID)
        {
            LibraryName = name_library;
            LibraryID = ID;
           
        }
        public void addbook(Book book)
        {
            BookList.Add(book);
        }
        public void removebook(int ID)
        {
            Book removingbook = BookList.Find(book => ID == book.BookID);
            BookList.Remove(removingbook);
        }
        public void viewbook()
        {
            foreach (Book book in BookList)
            {
                Console.WriteLine(book.ToString());
            }
        }
        public void searchbook(string title)
        {
            List<Book> searchfind = BookList.FindAll(book => book.TitleofBook.Contains(title));
            foreach (Book book in searchfind)
            {
                Console.WriteLine(book);
            }
        }

    }

    class Program
    {
        static void Main()
        {

            //Creating instance of Library
            Library library1 = new Library("National Library", 01);

            // Creating instance of Librarian
            Librarian librarian1 = new Librarian("Ali", 25, 01, 210);

            // Creating instances for user
            Person person1 = new Person("Ahmad", 30, 1);
            Person person2 = new Person("Hasan", 28, 2);
            Person person3 = new Person("Murtaza", 26, 3);


            // Creating instances of Book
            Book first_book = new Book("Fluid Mechanics", "Frank White", 1);
            Book second_book = new Book("Thermodynamics", "Moran Shapiro", 2);
            Book third_book = new Book("Statics", "Hibbler", 3);
            Book fourth_book = new Book("Heat Transfer", "JP Morgan", 4);

            //Issuing book to user
            librarian1.bookissue(first_book, person2);
            librarian1.bookissue(fourth_book, person1);

            // Return of book by user
            librarian1.bookreturn(fourth_book, person1);

            // Adding Book to library

            library1.addbook(first_book);
            library1.addbook(second_book);
            library1.addbook(third_book);
            library1.addbook(fourth_book);
            library1.viewbook();

            // Removing book from library

            library1.removebook(2);

            // Viewing Final list after removal of book
            library1.viewbook();

            // Searching book
            library1.searchbook("Statics");


        }
    }
}