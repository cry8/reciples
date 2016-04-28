using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using View;

namespace Presenter
{
    public class MainPresenter
    {
        private IContext _model;
        private IView _view;
        public MainPresenter(IContext model, IView view)
        {
            this._model = model;
            this._view = view;
            this._view.RecipeDC += _view_RecipeDC;
        }

        void _view_RecipeDC(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(sender);
            _view.setImage(_model.Items[index].Photo);
            _view.setIngredients(_model.Items[index].Ingredients);
            _view.setText(_model.Items[index].Text);
            _view.setTitle(_model.Items[index].Title);
        } 

        public void Show()
        {
            foreach (Recipe r in _model.Items)
                _view.addElement(r.Title);
            _view.Start(); 
        }
    }
}
