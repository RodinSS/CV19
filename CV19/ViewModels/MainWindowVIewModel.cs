using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV19.ViewModels
{
    internal class MainWindowVIewModel : ViewModel
    {
        #region ЗаголовокОкна
        private string _Title = "Анализ статистики CV19";
        
        ///<summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title;
            set
            {
                //if (Equals(_Title, value)) return;
                //_Title = value;
                //OnProperyChanged();
                Set(ref _Title, value);
            }
        } 
        #endregion
    }
}
