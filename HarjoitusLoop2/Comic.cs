using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusLoop2
{
    class Comic
    {
        public string name;
        public int price;
        public string publisher;
        public int issueNumber;

        public Comic()
        {

        }

        public Comic(string nname, int pprice, string ppublisher, int iissueNumber)
        {
            this.name = nname;
            this.price = pprice;
            this.publisher = ppublisher;
            this.issueNumber = iissueNumber;
        }

    }
}
