using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1T3
{
    internal class Book(Author author, Content content, Title title)
    {
        // Поля
        Author _author => author;
        Content _content => content;
        Title _title => title;

        public void Show()
        {
            this._author.Show();
            this._content.Show();
            this._title.Show();
        }

    }
}
