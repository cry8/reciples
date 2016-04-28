using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace View
{
    public interface IView
    {
        event EventHandler RecipeDC;
        void addElement(object obj);
        void Start();
        void setTitle(string text);
        void setImage(string path);
        void setIngredients(string text);
        void setText(string text);
    }
}
