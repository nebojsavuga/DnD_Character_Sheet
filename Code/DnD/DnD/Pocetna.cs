using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
namespace DnD
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {

            InitializeComponent();
                
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            DnD d = new DnD();
            this.Hide();
            d.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li zelite da Izadjete?", "Exit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cone.Close();
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

       
        public OleDbConnection cone = new OleDbConnection();
        private void Pocetna_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {

                cone.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Dnd.mdb;
                Persist Security Info=False;";
                cone.Open();


            }
            catch (Exception a)
            {
                MessageBox.Show("Verovatno nemate instaliran dodatak \n potreban za pokretanje baze." +
                    "\nInstalacija se nalazi u folderu instalacije.\nIme fajla: accessruntime_4288-1001_x64_en-us/x86");
                
            }
            OleDbCommand cmd1;
            cmd1=cone.CreateCommand();
            cmd1.CommandType = CommandType.Text;         
            cmd1.CommandText = "select imeIgraca,prezimeIgraca from Igrac";          
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
            da1.Fill(dt1);

            foreach (DataRow dr1 in dt1.Rows)
            {
                lbIgraci.Items.Add(dr1["imeIgraca"].ToString()+" "+dr1["prezimeIgraca"].ToString());            
            }
            cone.Close();
        }
    

        private void BtnView_Click(object sender, EventArgs e)
        {
            
            cone.Open();
            if (lbIgraci.SelectedItem == null)
            {
                MessageBox.Show("Selektujte igraca Prvo!");
            }
            else
            {
                string s = lbIgraci.SelectedItem.ToString();
                string ime, prezime;
                int spejs;

                spejs = s.IndexOf(" ");
                ime = s.Substring(0, spejs);
                prezime = s.Substring(spejs + 1);
                OleDbCommand cmd3;

                cmd3 = cone.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select idIgraca from Igrac where imeIgraca='" + ime + "' and prezimeIgraca='" + prezime + "';";
                cmd3.ExecuteNonQuery();
                this.Hide();
                Prikaz p = new Prikaz();
                p.imeIgraca(ime);
                p.prezimeIgraca(prezime);
                p.ShowDialog();
                
            }

            cone.Close();

        }

        private void LbIgraci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnIzbrisi_Click(object sender, EventArgs e)
        {
            cone.Open();
            if (lbIgraci.SelectedItem == null)
            {
                MessageBox.Show("Selektujte igraca");
            }
            else
            {
               
                OleDbCommand cmd3, cmd1;
                string s = lbIgraci.SelectedItem.ToString();
                string ime, prezime;
                int spejs;

                spejs = s.IndexOf(" ");
                ime = s.Substring(0, spejs);
                prezime = s.Substring(spejs + 1);
                cmd3 = cone.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select idIgraca from Igrac where imeIgraca='" + ime + "' and prezimeIgraca='" + prezime + "';";
                cmd1 = cone.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select idKaraktera from Igrac where imeIgraca='" + ime + "' and prezimeIgraca='" + prezime + "'order by idKaraktera desc;";
                OleDbDataReader dr1, dr2;
                dr2 = cmd1.ExecuteReader();
                dr2.Read();
                int idKar = Convert.ToInt32(dr2[0].ToString());
                dr1 = cmd3.ExecuteReader();
                dr1.Read();
                int id = Convert.ToInt32(dr1[0].ToString());
                OleDbCommand k1 = new OleDbCommand();
                OleDbCommand k2 = new OleDbCommand();
                OleDbCommand k3 = new OleDbCommand();
                k2 = cone.CreateCommand();
                k3 = cone.CreateCommand();
                k2.CommandType = CommandType.Text;
                k3.CommandType = CommandType.Text;
                k1 = cone.CreateCommand();
                k1.CommandType = CommandType.Text;
                k1.CommandText = "delete  from Igrac where idIgraca=" + id + ";";
                k2.CommandText = "delete from Karakter where idKaraktera=" + idKar + ";";
                k3.CommandText = "delete from ImaOpremu where idKaraktera=" + idKar + ";";

                int ind = lbIgraci.SelectedIndex;
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?", "Izbrisati?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    lbIgraci.Items.RemoveAt(ind);


                    MessageBox.Show("Uspesno ste obrisali igraca");


                    k1.ExecuteNonQuery();
                    k2.ExecuteNonQuery();
                    k3.ExecuteNonQuery();
                }
                else if (dialogResult == DialogResult.No) {
                    lbIgraci.SelectedItem = null;
                }


            }
            cone.Close();
        }
    }
}
