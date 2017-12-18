﻿using System;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Book b1 = new Book() { Title = "Bad Dad", Price = 5, Pages = 300 };
            Book b2 = new Book() { Title = "The Worlds Worst Children", Price = 5.99, Pages = 349 };
            Book b3 = new Book() { Title = "The Midnight Gang", Price = 5.49, Pages = 288 };
            Book[] booklist1 = { b1, b2, b3 };

            Book b4 = new Book() { Title = "Georges Marvellous Medicine", Price = 4.99, Pages = 292 };
            Book b5 = new Book() { Title = "The Enormous Crocodile", Price = 4.49, Pages = 265 };
            Book b6 = new Book() { Title = "The Twits", Price = 3.5, Pages = 245 };
            Book[] booklist2 = { b4, b5, b6 };

            Book b7 = new Book() { Title = "Fantastic Beasts and Where to Find Them", Price = 12, Pages = 459 };
            Book b8 = new Book() { Title = "Harry Potter and the Prizoner of Azkaban", Price = 9.99, Pages = 564 };
            Book b9 = new Book() { Title = "Harry Potter and the Philospohers Stone", Price = 3.72, Pages = 654 };
            Book[] booklist3 = { b7, b8, b9 };

            Author a1 = new Author() { FirstName = "David", LastName = "Walliams", Books = booklist1 };
            Author a2 = new Author() { FirstName = "Roald", LastName = "Dahl", Books = booklist2 };
            Author a3 = new Author() { FirstName = "JK", LastName = "Rowling", Books = booklist3 };
            Author[] authors = { a1, a2, a3 };
        }
    }
    class Author : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Book[] Books { get; set; }

        public int CompareTo(object obj)
        {
            Author temp = (Author)obj;
            return String.Compare(this.LastName, temp.LastName);
        }
    }
    class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int Pages { get; set; }
    }
}
