using MetroApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;

namespace MetroApp.Controls
{
    [TemplatePart(Name = PART_AxisAngleRotation3D, Type = typeof(AxisAngleRotation3D))]

    public class FipperView : Control
    {
        private const string PART_AxisAngleRotation3D = "PART_AxisAngleRotation3D";

        static FipperView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FipperView), new FrameworkPropertyMetadata(typeof(FipperView)));
        }

        public static readonly DependencyProperty FirstViewProperty =
            DependencyProperty.Register("FirstView", typeof(object), typeof(FipperView), new PropertyMetadata(null, OnFirstViewPropertyChanged));

        private static void OnFirstViewPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            FipperView view = d as FipperView;
            view.CurrentView = e.NewValue;
        }

        public object FirstView
        {
            get { return this.GetValue(FirstViewProperty); }
            set { this.SetValue(FirstViewProperty, value); }
        }

        public static readonly DependencyProperty SecondViewProperty =
            DependencyProperty.Register("SecondView", typeof(object), typeof(FipperView));

        public object SecondView
        {
            get { return this.GetValue(SecondViewProperty); }
            set { this.SetValue(SecondViewProperty, value); }
        }

        public ICommand FipCommand
        {
            get
            {
                return new Command((p) =>
                {
                    this.Fip();
                });
            }
        }

        public object CurrentView
        {
            get;
            private set;
        }

        AxisAngleRotation3D rotation;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.rotation = this.GetTemplateChild(PART_AxisAngleRotation3D) as AxisAngleRotation3D;
        }

        public void Fip()
        {
            if(this.FirstView != null && this.SecondView != null)
                this.rotation.BeginAnimation(AxisAngleRotation3D.AngleProperty, GenerateAnimation());
        }

        DoubleAnimation GenerateAnimation()
        {
            DoubleAnimation da = new DoubleAnimation();
            da.Duration = new Duration(TimeSpan.FromSeconds(.2));
            if (this.CurrentView == FirstView)
            {
                da.To = 180d;
                this.CurrentView = SecondView;
            }
            else
            {
                da.To = 0;
                this.CurrentView = FirstView;
            }
            return da;
        }
    }
}
