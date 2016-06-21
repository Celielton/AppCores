using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppCores.Activities
{
    [Activity(Label = "ListaFake")]
    public class ListaFake : BaseActivity
    {
        protected override int LayoutResource
        {
            get
            {
                return Resource.Layout.ListaFake;
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //var grid = FindViewById<GridLayout>(Resource.Id.gridTeste);
            var grid = new GridLayout(this);

            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    GridLayout.Spec linha = GridLayout.InvokeSpec(i);
                    GridLayout.Spec coluna = GridLayout.InvokeSpec(j);
                    GridLayout.LayoutParams lp = new GridLayout.LayoutParams(linha, coluna);

                    lp.Height = 50;
                    lp.Width = 50;

                    ImageView iv = new ImageView(this);
                    iv.SetImageResource(Resource.Drawable.ic_home_1);

                    iv.Click += OnClickItem;
                    grid.AddView(iv, lp);
                }
            }

            SetContentView(grid);
        }
        protected void OnClickItem(object sender, EventArgs e)
        {

        }
    }
}