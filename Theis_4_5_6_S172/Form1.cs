namespace Theis_4_5_6_S172
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double a = 4.5, b = 7.2, c = 10.3, d= 9.2;
                        
            LblInput.Text = "a = " + a + "\nb = " + b + "\nc = " + c + "\nd = " + d;
            LblAnzeige.Text="Ergebnis = "+ Mittelwert(a, b, c, d);
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double a=4.5,b=7.2;

            LblInput.Text = "a = " + a + "\nb = " + b;
            LblAnzeige.Text = "Ergebnis = " + Mittelwert(a, b);
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            LblInput.Text = "";
            LblAnzeige.Text = "Ergebnis = " + Mittelwert();
        }

        private double Mittelwert(params double[] x)
        {
            double summe = 0;

            if (x.Length == 0)
                return 0;

            foreach (double z in x)
                summe += z;
            return summe / x.Length;

        }
    }
}