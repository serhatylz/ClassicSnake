namespace Yılanoyunu
{
    public partial class YılanOyunu : Form
    {
        public YılanOyunu()
        {
            InitializeComponent();
            label3.Visible = false; // Form açıldığında görünmesin
        }

        Panel parca;
        Panel elma = new Panel();
        List<Panel> yilan = new List<Panel>();
        string yon = "sağ";

        private void label1_Click(object sender, EventArgs e) { }

        private void lb_basla_Click(object sender, EventArgs e)
        {
            lb_sıfır.Text = "0";
            PanelTemizle();

            

            parca = new Panel();
            parca.Location = new Point(200, 200);
            parca.Size = new Size(20, 20);
            parca.BackColor = Color.Gray;

            yilan.Add(parca);
            pn_panel.Controls.Add(yilan[0]);

            timer1.Start();
            elmaOlustur();
        }

        void CasrpismaKontrol()
        {
            for (int i = 2; i < yilan.Count; i++)
            {
                if (yilan[0].Location == yilan[i].Location)
                {
                    label3.Visible = true;
                    label3.Text = "KAYBETTİNİZ";
                    timer1.Stop();
                }
            }
        }


        void PanelTemizle()
        {
            pn_panel.Controls.Clear();
            yilan.Clear();
            label3.Visible = false;
        }
        void PuanKontrol()
        {
            int puan = int.Parse(lb_sıfır.Text);
            if (puan > 500)
            {
                label3.Text = "KAZANDINIZ";
                label3.Visible = true;
                timer1.Stop();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int locX = yilan[0].Location.X;
            int locY = yilan[0].Location.Y;

            elmaYedimi();
            Hareket();
            CasrpismaKontrol();
            PuanKontrol();

            if (yon == "sağ")
            {
                if (locX < 580) locX += 20;
                else locX = 0;
            }
            if (yon == "sol")
            {
                if (locX > 0) locX -= 20;
                else locX = 580;
            }
            if (yon == "aşağı")
            {
                if (locY < 580) locY += 20;
                else locY = 0;
            }
            if (yon == "yukarı")
            {
                if (locY > 0) locY -= 20;
                else locY = 580;
            }

            yilan[0].Location = new Point(locX, locY);
        }

        private void YılanOyunu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && yon != "sol")
                yon = "sağ";
            if (e.KeyCode == Keys.Left && yon != "sağ")
                yon = "sol";
            if (e.KeyCode == Keys.Up && yon != "aşağı")
                yon = "yukarı";
            if (e.KeyCode == Keys.Down && yon != "yukarı")
                yon = "aşağı";
        }

        void elmaOlustur()
        {
            Random rnd = new Random();
            int elmaX = rnd.Next(580);
            int elmaY = rnd.Next(580);

            elmaX -= elmaX % 20;
            elmaY -= elmaY % 20;

            elma.Size = new Size(20, 20);
            elma.BackColor = Color.Red;
            elma.Location = new Point(elmaX, elmaY);
            pn_panel.Controls.Add(elma);
        }

        void elmaYedimi()
        {
            int puan = int.Parse(lb_sıfır.Text);
            if (yilan[0].Location == elma.Location)
            {
                pn_panel.Controls.Remove(elma);
                puan += 50;
                lb_sıfır.Text = puan.ToString();
                elmaOlustur();
                ParcaEkle();
            }
        }

        void ParcaEkle()
        {
            Panel EkParca = new Panel();
            EkParca.Size = new Size(20, 20);
            EkParca.BackColor = Color.Gray;
            yilan.Add(EkParca);
            pn_panel.Controls.Add(EkParca);
        }

        void Hareket()
        {
            for (int i = yilan.Count - 1; i > 0; i--)
            {
                yilan[i].Location = yilan[i - 1].Location;
            }
        }

        private void label3_Click(object sender, EventArgs e) { }
    }
}
