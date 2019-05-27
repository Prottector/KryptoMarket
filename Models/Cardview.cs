using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Krryp.Models
{
    public class Cardview : ContentView 
    {
#pragma warning disable CS0618 // Type or member is obsolete
        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create<Cardview, float>(p => p.CornerRadius, 3.0F);
#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning disable CS0618 // Type or member is obsolete
        public new static readonly BindableProperty BackgroundColorProperty = BindableProperty.Create<Cardview, Color>(p => p.BackgroundColor, Color.White);
#pragma warning restore CS0618 // Type or member is obsolete

        public float CornerRadius
        {
            get { return (float)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public new Color BackgroundColor
        {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

#pragma warning disable CS0672 // Składowa przesłania przestarzałą składową
        protected override SizeRequest OnSizeRequest(double widthConstraint, double heightConstraint)
#pragma warning restore CS0672 // Składowa przesłania przestarzałą składową
        {
            if (Content == null)
                return new SizeRequest(new Size(100, 100));

#pragma warning disable CS0618 // Typ lub składowa jest przestarzała
            return Content.GetSizeRequest(widthConstraint, heightConstraint);
#pragma warning restore CS0618 // Typ lub składowa jest przestarzała
        }
    }
}
