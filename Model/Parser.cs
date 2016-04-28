using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Model
{
    class Parser
    {
        private XmlDocument xDoc;
        public Parser(string filename)
        {
            xDoc = new XmlDocument();
            xDoc.Load(filename);
        }

        public IEnumerable<object> getRecipe()
        {
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                Recipe rec = new Recipe();
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    switch(childnode.Name)
                    {
                        case "name":
                            rec.Title = childnode.InnerText;
                            break;
                        case "photo":
                            rec.Photo = childnode.InnerText;
                            break;
                        case "ingredients":
                            rec.Ingredients = childnode.InnerText;
                            break;
                        case "text":
                            rec.Text = childnode.InnerText;
                            break;
                    }
                }
                yield return rec;
            }
        }
    }
}
