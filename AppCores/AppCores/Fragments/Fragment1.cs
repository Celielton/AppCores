using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace AppCores.Fragments
{
    public class Fragment1 : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public static Fragment1 NewInstance()
        {
            var frag1 = new Fragment1 { Arguments = new Bundle() };
            return frag1;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.fragment1, null);

            var btnVermelho = view.FindViewById(Resource.Id.buttonVermelho);

            btnVermelho.Click += BtnVermelho_Click;

            return view;
        }

        private void BtnVermelho_Click(object sender, System.EventArgs e)
        {
            var btn = sender as Button;

            btn.SetBackgroundColor(Android.Graphics.Color.White);

            
        }

    }
}