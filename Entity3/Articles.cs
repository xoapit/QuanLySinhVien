using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity3
{
    class Articles
    {
        private string articleId;
        private string name;
        private string authorId;

        public string AuthorId
        {
            get
            {
                return authorId;
            }

            set
            {
                authorId = value;
            }
        }

        public string ArticleId
        {
            get
            {
                return articleId;
            }

            set
            {
                articleId = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }


}
