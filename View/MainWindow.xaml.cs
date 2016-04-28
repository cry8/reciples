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
namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region IView Implementation

        public event EventHandler RecipeDC;
        public void addElement(object obj)
        {
            this.ReciplesBox.Items.Add(obj);
        }
        public void Start()
        {
            this.Show();
        }
        public void setTitle(string text)
        {
            this.rTitle.Text = text;
        }
        public void setImage(string path)
        {
            this.Photo.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory+path)); 
        }
        public void setIngredients(string text)
        {
            this.Ingredients.Text = text;
        }
        public void setText(string text)
        {
            rText.Inlines.Clear();
            rText.Inlines.Add(text);
        }
        #endregion

        private void ReciplesBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(RecipeDC!=null && ReciplesBox.SelectedIndex!=-1)
                RecipeDC(ReciplesBox.SelectedIndex, EventArgs.Empty);
        }
    }
}
