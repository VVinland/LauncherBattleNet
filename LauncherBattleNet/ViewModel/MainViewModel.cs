using GalaSoft.MvvmLight.Command;
using LauncherBattleNet.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace LauncherBattleNet.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private Page Wow = new WowPage();
        private Page HS = new HsPage();
        private Page OverW = new OverWPage();
        private Page HOTS = new HOTSPage();
        private Page D3 = new Diablo3();
        private Page SC = new SC();
        private Page SC2 = new SCII();
        private Page Wow3 = new Wow3Page();
        private Page _CurPage = new WowPage();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        public ICommand OpenHSPage
        {
            get
            {
                return new RelayCommand(() => CurPage = HS);
            }
        }
        public ICommand OpenWowPage
        {
            get
            {
                return new RelayCommand(() => CurPage =Wow);
            }
        }
        public ICommand OpenOverWPage
        {
            get
            {
                return new RelayCommand(() => CurPage = OverW);
            }
        }
        public ICommand OpenHOTSWPage
        {
            get
            {
                return new RelayCommand(() => CurPage = HOTS);
            }
        }
        public ICommand OpenD3WPage
        {
            get
            {
                return new RelayCommand(() => CurPage = D3);
            }
        }
        public ICommand OpenSCPage
        {
            get
            {
                return new RelayCommand(() => CurPage = SC);
            }
        }
        public ICommand OpenSC2WPage
        {
            get
            {
                return new RelayCommand(() => CurPage = SC2);
            }
        }
        public ICommand OpenWow3Page
        {
            get
            {
                return new RelayCommand(() => CurPage = Wow3);
            }
        }
    }

}
