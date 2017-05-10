using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPDemo.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        internal class ListItem
        {
            public ListItem() : this(null, null) { }
            public ListItem(string ope, Func<decimal?, decimal?, decimal?> formula) => (Operator, Formula) = (ope ?? "", formula ?? ((x, y) => null));

            public string Operator { get; }
            public Func<decimal?, decimal?, decimal?> Formula { get; }
        }

        public IReadOnlyList<ListItem> List { get; } =
            new[]
            {
                new ListItem("＋", (l, r) => l + r),
                new ListItem("ー", (l, r) => l - r),
                new ListItem("×", (l, r) => l * r),
                new ListItem("÷", (l, r) => r.HasValue && r == 0 ? null : l / r)
            };

        decimal? _LeftSideValue;
        public decimal? LeftSideValue
        {
            get => _LeftSideValue;
            set
            {
                if(_LeftSideValue == value) return;
                _LeftSideValue = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(Answer));
            }
        }

        decimal? _RightSideValue;
        public decimal? RightSideValue
        {
            get => _RightSideValue;
            set
            {
                if(_RightSideValue == value) return;
                _RightSideValue = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(Answer));
            }
        }

        ListItem _SelectedItem;
        public ListItem SelectedItem {
            get => _SelectedItem;
            set
            {
                if(ReferenceEquals(_SelectedItem, value) || _SelectedItem?.Operator == value?.Operator) return;
                _SelectedItem = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(Answer));

            }
        }
        public string Answer => (_SelectedItem?.Formula?.Invoke(LeftSideValue, RightSideValue))?.ToString() ?? "未定義";

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        #endregion
    }
}
