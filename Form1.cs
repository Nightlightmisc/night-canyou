using System.Runtime.InteropServices;

namespace canyou
{
    public partial class Form1 : Form
    {
        /*
         
          * Some apps need this. Make it look more fluent. Obviously...
            But I swear this is not the first thing we should write. WE may be write other things than this one.
            However, you can continue your work.

         */

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
