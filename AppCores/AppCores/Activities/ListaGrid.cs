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
using Java.Lang;
using Android.Support.Design.Widget;

namespace AppCores.Activities
{
    [Activity(Label = "ListaGrid")]
    public class ListaGrid : BaseActivity
    {
        protected override int LayoutResource
        {
            get
            {
                return Resource.Layout.ListaGrid;
            }
        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var gridView1 = FindViewById<GridView>(Resource.Id.gridView1);

            int[] lista = new int[] { Resource.Drawable.ic_home_1, Resource.Drawable.ic_home_1,
                                       Resource.Drawable.ic_home_1, Resource.Drawable.ic_home_1,
                                        Resource.Drawable.ic_home_1, Resource.Drawable.ic_home_1};

            var adapter = new GridAdaptador(this, lista);

            gridView1.Adapter = adapter;

            gridView1.ItemClick += GridView1_ItemClick;

        }

        private void GridView1_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //Imprime a posição
            Snackbar.Make(e.View , string.Format( "Você clicou na imagem: {0}" , (e.Position + 1)), Snackbar.LengthLong)
                .Show();

        }
    }


    public class GridAdaptador : BaseAdapter
    {
        private Context _context;
        private int[] _lista;

        public GridAdaptador(Context context, int[] lista)
        {
            _context = context;
            _lista = lista;
        }
        public override int Count
        {
            get
            {
               return _lista.Count();
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return _lista[position];
        }

        public override long GetItemId(int position)
        {
            return _lista.ElementAt(position);
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imgView = new ImageView(_context);
            imgView.SetImageResource(_lista[position]);
            imgView.SetAdjustViewBounds(true);

            return imgView;
        }
    }
    
}