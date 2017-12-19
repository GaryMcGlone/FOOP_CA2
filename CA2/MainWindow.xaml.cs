using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CA2
{
     /*
     * MainWindow.xaml.cs should on contain only UI Methods/Event Handlers
     * Keep classes in separate .cs files
     */
    public partial class MainWindow : Window
    {
        //Keep your arrays at class level so they're accessable throughout the entire program
        Author[] authors = new Author[3];
        Book[] booklist1 = new Book[3];
        Book[] booklist2 = new Book[3];
        Book[] booklist3 = new Book[3];

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Initializing 3 books with properties of Title, Price & Pages
            //These 3 books are stored inside the first book list
            Book b1 = new Book() { Title = "Bad Dad", Price = 5, Pages = 300 };
            Book b2 = new Book() { Title = "The Worlds Worst Children", Price = 5.99, Pages = 349 };
            Book b3 = new Book() { Title = "The Midnight Gang", Price = 5.49, Pages = 288 };
            //Make sure to fill the array
            booklist1[0] = b1;
            booklist1[1] = b2;
            booklist1[2] = b3;

            //These 3 books are stored in book list 2
            Book b4 = new Book() { Title = "Georges Marvellous Medicine", Price = 4.99, Pages = 292 };
            Book b5 = new Book() { Title = "The Enormous Crocodile", Price = 4.49, Pages = 265 };
            Book b6 = new Book() { Title = "The Twits", Price = 3.5, Pages = 245 };
            //Make sure to fill the array
            booklist2[0] = b4;
            booklist2[1] = b5;
            booklist2[2] = b6;

            //These three books are stored inside booklist 3
            Book b7 = new Book() { Title = "Fantastic Beasts and Where to Find Them", Price = 12, Pages = 459 };
            Book b8 = new Book() { Title = "Harry Potter and the Prizoner of Azkaban", Price = 9.99, Pages = 564 };
            Book b9 = new Book() { Title = "Harry Potter and the Philospohers Stone", Price = 3.72, Pages = 654 };
            //Make sure to fill the array
            booklist3[0] = b7;
            booklist3[1] = b8;
            booklist3[2] = b9;

            //Initializing 3 authors with properties for First/Last Name
            //And each author has a list of books associated with them 
            //Which is done by storing an array of Books inside the Authors class
            Author a1 = new Author() { FirstName = "David", LastName = "Walliams", Books = booklist1 };
            Author a2 = new Author() { FirstName = "Roald", LastName = "Dahl", Books = booklist2 };
            Author a3 = new Author() { FirstName = "JK", LastName = "Rowling", Books = booklist3 };
            //Make sure to fill the array
            authors[0] = a1;
            authors[1] = a2;
            authors[2] = a3;

            //Make sure to set the listbox of authors to the authors array
            listboxAuthors.ItemsSource = authors;
        }
        //Method to sort the authors by last name (See IComparable inside the Author Class)
        private void buttonSortAZ_Click(object sender, RoutedEventArgs e)
        {
            //Sort the array in ascending order ( A - Z )
            Array.Sort(authors);
            //Clear out the listbox
            listboxAuthors.ItemsSource = null;
            //set the listbox items to the now sorted array
            listboxAuthors.ItemsSource = authors;
        }
        //Method to sort the authors in descending order ( Z - A )
        private void buttonSortZA_Click(object sender, RoutedEventArgs e)
        {
            //Sorts the array in ascending order
            Array.Sort(authors);
            //Then reverse the array so it's in descending order
            Array.Reverse(authors);
            //clear out the listbox
            listboxAuthors.ItemsSource = null;
            //and display the new sorted array
            listboxAuthors.ItemsSource = authors;
        }
        //This method will check which author has been selected then display the books associated with that author in the adjacent listbox
        private void listboxAuthors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Creating a selected object which is the selected item in the listbox (casting it to an Author object)
            Author selected = listboxAuthors.SelectedItem as Author;

            //Check to see that you haven't click an empty area of the listbox
            if (selected != null)
            {
                //setting the books listbox equal to the selected item.Books which will be the correct booklist
                //of the author you have selected
                listboxBooks.ItemsSource = selected.Books;
            }
        }
        private void Searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Search term being the text inside the searchbox, convert to upper to ingnore case sensitive
            string searchTerm = Searchbox.Text.ToUpper();

            //if the searchterm is eqaul to an authors first or last name
            if (searchTerm != "" && searchTerm != null)
            {
                //This line will dynamically search the authors array based on first or last name using the list function Where
                listboxAuthors.ItemsSource = authors.Where(a => a.FirstName.ToUpper().Contains(searchTerm) || a.LastName.ToUpper().Contains(searchTerm));
            }
            else
            {
                // if you search something then delete that search the all authors will reappear
                listboxAuthors.ItemsSource = authors;
            }
        }
        //click search to search but it will dynamically search anyway
        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = Searchbox.Text.ToUpper();

            //if the searchterm is eqaul to an authors first or last name
            if (searchTerm != "" && searchTerm != null)
            {
                //This line will dynamically search the authors array based on first or last name using a list function Where
                listboxAuthors.ItemsSource = authors.Where(a => a.FirstName.ToUpper().Contains(searchTerm) || a.LastName.ToUpper().Contains(searchTerm));
            }
        }
    }
}