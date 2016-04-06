using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPDemo.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        internal class ListItem
        {
            public ListItem() : this(null,null) { }
            public ListItem(string ope , Func<int?,int?,int?> formula)
            {
                Operator = ope ?? "";
                Formula = formula ?? ((x,y) => null);
            }
            public string Operator { get; }
            public Func<int?,int?,int?> Formula { get; }
        }

        public IReadOnlyList<ListItem> List { get; } =
            new[]
            {
                new ListItem("＋", (l, r) => l + r),
                new ListItem("ー", (l, r) => l - r),
                new ListItem("×", (l, r) => l * r),
                new ListItem("÷", (l, r) => r.HasValue && r == 0 ? null : l / r)
            };

        int? _LeftSideValue;
        public int? LeftSideValue
        {
            get
            {
                return _LeftSideValue;
            }
            set
            {
                if(_LeftSideValue == value) return;
                _LeftSideValue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LeftSideValue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Answer)));
            }
        }

        int? _RightSideValue;
        public int? RightSideValue
        {
            get
            {
                return _RightSideValue;
            }
            set
            {
                if(_RightSideValue == value) return;
                _RightSideValue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RightSideValue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Answer)));
            }
        }

        ListItem _SelectedItem;
        public ListItem SelectedItem {
            get
            {
                return _SelectedItem;
            }
            set
            {
                if(ReferenceEquals(_SelectedItem, value) || _SelectedItem?.Operator == value?.Operator) return;
                _SelectedItem = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItem)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Answer)));

            }
        }

        public string Answer => (_SelectedItem?.Formula?.Invoke(LeftSideValue, RightSideValue))?.ToString() ?? "未定義";

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
