﻿using System;
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
using System.Reactive.Disposables;
using RP2.Extensions;

namespace RP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbOperator.Items.AddRange(new[]
            {
                new ListItem("＋", (l, r) => l + r),
                new ListItem("ー", (l, r) => l - r),
                new ListItem("×", (l, r) => l * r),
                new ListItem("÷", (l, r) => r.HasValue && r == 0 ? null : l / r)
            });
        }

        protected override void OnHandleCreated(EventArgs ev)
        {
            base.OnHandleCreated(ev);

            var down = this.MouseDownAsObservable()
                .Where(e => e.Button == MouseButtons.Left);

            var up = this.MouseUpAsObservable()
                .Where(e => e.Button == MouseButtons.Left);

            var move = this.MouseMoveAsObservable();

            down.SelectMany(move.TakeUntil(up))
                .ObserveOn(this)
                .Subscribe(e => label2.Text = e.Location.ToString());

            Observable
                .Timer(TimeSpan.Zero, TimeSpan.FromMilliseconds(250))
                .Select(_ => $"{DateTime.Now:yyyy年MM月dd日(ddd) HH:mm:ss}")
                .DistinctUntilChanged()
                .ObserveOn(this)
                .Subscribe(d => label1.Text = d);

            var upClick = button1.MouseClickAsObservable()
                .Where(e => e.Button == MouseButtons.Left)
                .Select((_, i) => 1);

            var downClick = button2.MouseClickAsObservable()
                .Where(e => e.Button == MouseButtons.Left)
                .Select((_, i) => -1);

            upClick
                .Merge(downClick)
                .Scan(0, (acc, current) => acc + current)
                .ObserveOn(this)
                .Subscribe(i => label3.Text = i.ToString());

            void setAnswer(EventArgs e) =>
                lbAnswer.Text = (cbOperator.SelectedItem as ListItem)?.
                Formula?.Invoke(decimal.TryParse(tbLeft.Text, out var left) ? left 
                : default(decimal?), decimal.TryParse(tbRight.Text, out var right) ? right : default(decimal?))?.ToString() ?? "未定義";

            Observable
                .Merge(
                    tbLeft.TextChangedAsObservable(),
                    tbRight.TextChangedAsObservable(),
                    cbOperator.SelectedIndexChangedAsObservable()).ObserveOn(this)
                .Subscribe(setAnswer);


        }


    }
    internal class ListItem
    {
        public ListItem() : this(null, null) { }
        public ListItem(string ope, Func<decimal?, decimal?, decimal?> formula) => (Operator, Formula) = (ope ?? "", formula ?? ((x, y) => null));

        public string Operator { get; }
        public Func<decimal?, decimal?, decimal?> Formula { get; }

        public override string ToString() => Operator;

    }

    namespace Extensions
    {
        internal static class ControlExtensions
        {
            internal static IObservable<MouseEventArgs> MouseDownAsObservable(this Control ctl) => ctl == null
                ? throw new ArgumentNullException(nameof(ctl))
                : Observable
                .FromEvent<MouseEventHandler, MouseEventArgs>(h => (sender, e) => h(e),
                    h => ctl.MouseDown += h,
                    h => ctl.MouseDown -= h);

            internal static IObservable<MouseEventArgs> MouseUpAsObservable(this Control ctl) => ctl == null
                ? throw new ArgumentNullException(nameof(ctl))
                : Observable.FromEvent<MouseEventHandler, MouseEventArgs>(h => (sender, e) => h(e), h => ctl.MouseUp += h, h => ctl.MouseUp -= h);

            internal static IObservable<MouseEventArgs> MouseMoveAsObservable(this Control ctl) => ctl == null
                ? throw new ArgumentNullException(nameof(ctl))
                : Observable.FromEvent<MouseEventHandler, MouseEventArgs>(h => (sender, e) => h(e), h => ctl.MouseMove += h, h => ctl.MouseMove -= h);

            internal static IObservable<MouseEventArgs> MouseClickAsObservable(this Control ctl) => ctl == null 
                ? throw new ArgumentNullException(nameof(ctl)) 
                : Observable.FromEvent<MouseEventHandler, MouseEventArgs>(h => (sender, e) => h(e), h => ctl.MouseClick += h, h => ctl.MouseClick -= h);

            internal static IObservable<EventArgs> TextChangedAsObservable(this TextBoxBase tb) => tb == null 
                ? throw new ArgumentNullException(nameof(tb)) 
                : Observable.FromEvent<EventHandler, EventArgs>(h => (sender, e) => h(e), h => tb.TextChanged += h, h => tb.TextChanged -= h);
            internal static IObservable<EventArgs> SelectedIndexChangedAsObservable(this ComboBox cb) => cb == null
                ? throw new ArgumentNullException(nameof(cb))
                : Observable.FromEvent<EventHandler, EventArgs>(h => (sender, e) => h(e), h => cb.SelectedIndexChanged += h, h => cb.SelectedIndexChanged-= h);
        }

    }

}
