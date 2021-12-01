using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._02
{
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                releaseDate = value;
            }
        }
    }
}
