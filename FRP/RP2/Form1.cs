using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reactive.Linq;
using System.Threading;

namespace RP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Observable
                .Interval(TimeSpan.FromMilliseconds(250))
                .Select(_ => $"{DateTime.Now:yyyy年MM月dd日(ddd) HH:mm:ss}")
                .ObserveOn(this)
                .Subscribe(d => label1.Text = d);

            var down = Observable
                .FromEvent<MouseEventHandler, MouseEventArgs>(h => (sender, e) => h(e), h => MouseDown += h, h => MouseDown -= h)
                .Where(e => e.Button == MouseButtons.Left);

            var up = Observable
                .FromEvent<MouseEventHandler, MouseEventArgs>(h => (sender, e) => h(e), h => MouseUp += h, h => MouseUp -= h)
                .Where(e => e.Button == MouseButtons.Left);

            var move = Observable
                .FromEvent<MouseEventHandler, MouseEventArgs>(h => (sender, e) => h(e), h => MouseMove += h, h => MouseMove -= h);

            move.SkipUntil(down).TakeUntil(up).ObserveOn(this).Finally(() => label2.Text = "").Repeat().Subscribe(e => label2.Text = e.Location.ToString());

        }
    }
}
