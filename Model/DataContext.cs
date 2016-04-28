using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DataContext : IContext
    {
        #region IContext Implementation

        public DataContext()
        {
            Items = new List<Recipe>();
        }
        public List<Recipe> Items { get; set; }
        public void LoadItems()
        {
            Parser parser = new Parser("data.xml");
            foreach(Recipe r in parser.getRecipe())
            {
                Items.Add(r);
            }
        }

        #endregion 
    }
}
