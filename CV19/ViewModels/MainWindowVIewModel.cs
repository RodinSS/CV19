using CV19.Infrastructure.Commands;
using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CV19.ViewModels
{
    internal class MainWindowVIewModel : ViewModel
    {
        #region ЗаголовокОкна
        private string _Title = "Анализ статистики CV19";
        
        ///<summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title; set => Set(ref _Title, value);
            //{
            //    //if (Equals(_Title, value)) return;
            //    //_Title = value;
            //    //OnProperyChanged();
            //    Set(ref _Title, value);
            //}
        }
        #endregion
        #region СтатусПрограммы
        private string _Status = "Готово";

        ///<summary>СтатусПрограммы</summary>
        public string Status
        {
            get => _Status; set => Set(ref _Status, value);
        }
        #endregion

        #region Команды
        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p) 
        { 
            Application.Current.Shutdown();
        } 
        #endregion
        #endregion
        public MainWindowVIewModel()
        {
            #region Команды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion
        }
    }
}
