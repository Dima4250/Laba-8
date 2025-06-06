
using Laba_8.Models;
using Laba_8.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly DirectorySyncModel _model;
        private List<FileDifference> _currentDifferences;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _model = new DirectorySyncModel();
            _currentDifferences = new List<FileDifference>();
        }

        public void CompareDirectories()
        {
            _currentDifferences = _model.GetDifferences(_view.Directory1, _view.Directory2);
            _view.SetDifferences(_currentDifferences);
        }

        public void SynchronizeDirectories()
        {
            if (_currentDifferences.Count == 0)
            {
                _view.ShowMessage("Нет различий для синхронизации");
                return;
            }

            _model.SynchronizeDirectories(_currentDifferences);
            _view.ShowMessage("Синхронизация завершена");
            CompareDirectories(); // Обновляем список различий после синхронизации
        }
    }
}
