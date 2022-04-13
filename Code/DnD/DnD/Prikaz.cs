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
using System.Drawing.Imaging;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Text;

namespace DnD
{
    public partial class Prikaz : Form
    {
        public Prikaz()
        {
            InitializeComponent();

        }
        Pocetna p = new Pocetna();
        
        public void imeIgraca(string ime)
        {

            tbImeIgraca.Text = ime;

            
        }
        public void prezimeIgraca(string prezime)
        {
            tbPrezimeIgraca.Text = prezime;
        }

        private void PozadinaTrue()
        {

            if (cbPozadina.SelectedIndex == 1 || cbPozadina.SelectedIndex == 2)
            {
                cbReligion.Checked = true;
                cbInsight.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 3 || cbPozadina.SelectedIndex == 18)
            {
                cbHist.Checked = true;
                cbSurvival.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 4)
            {
                cbInsight.Checked = true;
                cbIntimid.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 5 || cbPozadina.SelectedIndex == 59)
            {
                cbAthle.Checked = true;
                cbIntimid.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 6)
            {
                cbPerception.Checked = true;
                cbPerfomance.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 7)
            {
                cbDecept.Checked = true;
                cbSleighOfHand.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 8)
            {
                cbHist.Checked = true;
                cbInsight.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 9)
            {
                cbHist.Checked = true;
                cbArcana.Checked = true;
                cbNature.Checked = true;
                cbReligion.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 10 || cbPozadina.SelectedIndex == 24)
            {
                cbInsight.Checked = true;
                cbPersuation.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 11 || cbPozadina.SelectedIndex == 12)
            {
                cbDecept.Checked = true;
                cbStealth.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 5 || cbPozadina.SelectedIndex == 59)
            {
                cbAthle.Checked = true;
                cbIntimid.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 13 || cbPozadina.SelectedIndex == 21 || cbPozadina.SelectedIndex == 51)
            {
                cbAcrob.Checked = true;
                cbPerfomance.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 14)
            {
                cbDecept.Checked = true;
                cbIntimid.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 15)
            {
                cbInsight.Checked = true;
                cbHist.Checked = true;
                cbArcana.Checked = true;
                cbInvestig.Checked = true;
                cbNature.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 16 || (cbPozadina.SelectedIndex >= 27 && cbPozadina.SelectedIndex <= 39))
            {
                cbInvestig.Checked = true;
                cbPersuation.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 17)
            {
                cbInsight.Checked = true;
                cbPerception.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 19)
            {
                cbAnimal.Checked = true;
                cbSurvival.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 20)
            {
                cbDecept.Checked = true;
                cbInsight.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 22)
            {
                cbNature.Checked = true;
                cbSurvival.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 23)
            {
                cbAnimal.Checked = true;
                cbAthle.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 25)
            {
                cbArcana.Checked = true;
                cbInvestig.Checked = true;
                cbReligion.Checked = true;
                cbSurvival.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 26)
            {
                cbMedicine.Checked = true;
                cbReligion.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 40)
            {
                cbSurvival.Checked = true;
                cbArcana.Checked = true;
                cbHist.Checked = true;
                cbReligion.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 41)
            {
                cbArcana.Checked = true;
                cbInvestig.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 42 || cbPozadina.SelectedIndex == 46 || cbPozadina.SelectedIndex == 63)
            {
                cbHist.Checked = true;
                cbPersuation.Checked = true;

            }
            else if (cbPozadina.SelectedIndex == 43)
            {
                cbPersuation.Checked = true;
                cbArcana.Checked = true;
                cbHist.Checked = true;
                cbNature.Checked = true;
                cbReligion.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 44 || cbPozadina.SelectedIndex == 48 || cbPozadina.SelectedIndex == 62)
            {
                cbAthle.Checked = true;
                cbSurvival.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 45)
            {
                cbAthle.Checked = true;
                cbPersuation.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 47)
            {
                cbIntimid.Checked = true;
                cbReligion.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 49 || cbPozadina.SelectedIndex == 54)
            {
                cbAthle.Checked = true;
                cbPerception.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 50)
            {
                cbMedicine.Checked = true;
                cbPersuation.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 52)
            {
                cbHist.Checked = true;
                cbInvestig.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 55)
            {
                cbNature.Checked = true;
                cbPersuation.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 56)
            {
                cbHist.Checked = true;
                cbPerception.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 57)
            {
                cbArcana.Checked = true;
                cbMedicine.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 58)
            {
                cbAthle.Checked = true;
                cbDecept.Checked = true;
            }
            else if (cbPozadina.SelectedIndex == 60)
            {
                cbStealth.Checked = true;
                cbPersuation.Checked = true;
                cbInvestig.Checked = true;
                cbDecept.Checked = true;

            }
            else if (cbPozadina.SelectedIndex == 61)
            {
                cbSleighOfHand.Checked = true;
                cbStealth.Checked = true;
            }
        }
        private void LbIme_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        public bool btnKliknuo=false;
        public OleDbConnection cone = new OleDbConnection();
        private void DnD_Load(object sender, EventArgs e)
        {
            
            this.Hide();
            this.ControlBox = false;
            lbOprema.Items.Clear();
            ToolTip toolTip1 = new ToolTip();
            
            toolTip1.SetToolTip(this.tbXP, "Ukoliko zelite da promenite vrednost XP-a,zapisite prethodno unete vrednosti za strenght,dexterity...");
            toolTip1.SetToolTip(this.btnPrint, "Ovo dugme kreira Sheet u PDF formatu kako bi se mogao stampati");

            try
            {

                cone.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Dnd.mdb;
            Persist Security Info=False;";
                cone.Open();


            }
            catch (Exception a)
            {
                MessageBox.Show("Error " + a);
            }
            
            cbRasa.Items.Add("");
            cbPol.Items.Add("");
            cbOdredjenost.Items.Add("");
            cbKlasa.Items.Add("");
            cbPozadina.Items.Add("");

            cbOprema.Items.Add("");
            cbKlasa.Enabled = false;
            cbRasa.Enabled = false;
            tbImeIgraca.Enabled = false;
            tbPrezimeIgraca.Enabled = false;
            cbPol.Enabled = false;
            cbOdredjenost.Enabled = false;
            cbPozadina.Enabled = false;
            cbIme.Enabled = false;
            cbPrezime.Enabled = false;

            OleDbCommand cmd1, cmd2, cmd4, cmd5, cmd3, cmd6;
            OleDbCommand c1, c2, c3, c4;
            c1 = cone.CreateCommand();
            c2 = cone.CreateCommand();
            c3 = cone.CreateCommand();
            c4 = cone.CreateCommand();



            cmd4 = cone.CreateCommand();
            cmd2 = cone.CreateCommand();
            cmd1 = cone.CreateCommand();
            cmd3 = cone.CreateCommand();
            cmd6 = cone.CreateCommand();
            cmd5 = cone.CreateCommand();

            c1.CommandType = CommandType.Text;
            c2.CommandType = CommandType.Text;
            c3.CommandType = CommandType.Text;
            c4.CommandType = CommandType.Text;


            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Select Prezime from PrezimeKaraktera";
            cmd1.ExecuteNonQuery();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "Select imeKlase from Klasa";
            cmd2.ExecuteNonQuery();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "Select imeRase from Rasa";
            cmd3.ExecuteNonQuery();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "SELECT Opredeljenost from opredeljenost";
            cmd4.ExecuteNonQuery();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "SELECT imePola from Pol";
            cmd5.ExecuteNonQuery();

            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "Select Pozadina from Pozadina";

            DataTable dt6 = new DataTable();
            OleDbDataAdapter da6 = new OleDbDataAdapter(cmd6);
            da6.Fill(dt6);
            DataTable dt1 = new DataTable();
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
            da1.Fill(dt1);


            DataTable dt2 = new DataTable();
            OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
            da2.Fill(dt2);
            DataTable dt3 = new DataTable();
            OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
            da3.Fill(dt3);



            DataTable dt4 = new DataTable();
            OleDbDataAdapter da4 = new OleDbDataAdapter(cmd4);
            da4.Fill(dt4);

            DataTable dt5 = new DataTable();
            OleDbDataAdapter da5 = new OleDbDataAdapter(cmd5);
            da5.Fill(dt5);


            foreach (DataRow dr6 in dt6.Rows)
            {
                cbPozadina.Items.Add(dr6["Pozadina"].ToString());

            }
            foreach (DataRow dr1 in dt1.Rows)
            {

                cbPrezime.Items.Add(dr1["Prezime"].ToString());

            }
            foreach (DataRow dr2 in dt2.Rows)
            {
                cbKlasa.Items.Add(dr2["ImeKlase"].ToString());
            }
            foreach (DataRow dr3 in dt3.Rows)
            {
                cbRasa.Items.Add(dr3["ImeRase"].ToString());
            }

            foreach (DataRow dr4 in dt4.Rows)
            {
                cbOdredjenost.Items.Add(dr4["Opredeljenost"].ToString());
            }

            foreach (DataRow dr5 in dt5.Rows)
            {
                cbPol.Items.Add(dr5["ImePola"].ToString());

            }
            OleDbDataReader dar1, dar2, dar3, dar4, dar5;
            string imeRase1, imePola1;
            int idPola1;
            OleDbCommand c5, c6, c7;

            c5 = cone.CreateCommand();
            c5.CommandType = CommandType.Text;
            int idIgraca1, idKaraktera1, XP1, idRase1;
            c2.CommandText = "select idIgraca from Igrac where imeIgraca='" + tbImeIgraca.Text + "' and prezimeIgraca='" + tbPrezimeIgraca.Text + "';";
            dar1 = c2.ExecuteReader();
            dar1.Read();
            idIgraca1 = Convert.ToInt32(dar1[0].ToString());
            //XP
            c1.CommandText = "select idKaraktera from Igrac where idIgraca=" + idIgraca1 + ";";
            dar2 = c1.ExecuteReader();
            dar2.Read();
            idKaraktera1 = Convert.ToInt32(dar2[0].ToString());

           

            c3.CommandText = "select XP from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar3 = c3.ExecuteReader();
            dar3.Read();
            XP1 = Convert.ToInt32(dar3[0].ToString());
            tbXP.Text = Convert.ToString(XP1);
            //Rasa
            c4.CommandText = "select idRase from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar4 = c4.ExecuteReader();
            dar4.Read();
            idRase1 = Convert.ToInt32(dar4[0].ToString());

            c5.CommandText = "select imeRase from Rasa where idRase=" + idRase1 + ";";
            dar5 = c5.ExecuteReader();
            dar5.Read();
            imeRase1 = Convert.ToString(dar5[0].ToString());
            cbRasa.Text = Convert.ToString(imeRase1);
            OleDbCommand c8, c9, c10, c11;
            c8 = cone.CreateCommand();
            c9 = cone.CreateCommand();
            c10 = cone.CreateCommand();
            c10.CommandType = CommandType.Text;
            c8.CommandType = CommandType.Text;
            c9.CommandType = CommandType.Text;
            OleDbDataReader dar8, dar9, dar10, dar11, dar12;
            int idImena1, idImena2;
            int idPola2;
            //Pol 
            c11 = cone.CreateCommand();
            c11.CommandType = CommandType.Text;
            c6 = cone.CreateCommand();
            c6.CommandType = CommandType.Text;
            c7 = cone.CreateCommand();
            c7.CommandType = CommandType.Text;
            c8.CommandText = "select idImena from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar8 = c8.ExecuteReader();
            dar8.Read();
            idImena1 = Convert.ToInt32(dar8[0].ToString());
            c9.CommandText = "select idImena from imeKaraktera where idImena=" + idImena1 + ";";
            dar9 = c9.ExecuteReader();
            dar9.Read();
            idImena2 = Convert.ToInt32(dar9[0].ToString());
            c10.CommandText = "select idPola from ImeKaraktera where idImena=" + idImena2 + ";";
            dar10 = c10.ExecuteReader();
            dar10.Read();
            idPola1 = Convert.ToInt32(dar10[0].ToString());
            c6.CommandText = "select idPola from Pol where idPola=" + idPola1 + ";";
            dar11 = c6.ExecuteReader();
            dar11.Read();
            idPola2 = Convert.ToInt32(dar11[0].ToString());
            c11.CommandText = "select imePola from Pol where idPola=" + idPola2 + ";";
            dar12 = c11.ExecuteReader();
            dar12.Read();
            imePola1 = Convert.ToString(dar12[0].ToString());

            cbPol.Text = Convert.ToString(imePola1);

            //Klasa
            OleDbCommand c14, c13;
            OleDbDataReader dar14, dar13;
            int idKlase1;
            string ImeKlase1;
            c14 = cone.CreateCommand();
            c14.CommandType = CommandType.Text;
            c13 = cone.CreateCommand();
            c13.CommandType = CommandType.Text;

            c13.CommandText = "select idKlase from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar13 = c13.ExecuteReader();
            dar13.Read();
            idKlase1 = Convert.ToInt32(dar13[0].ToString());

            c14.CommandText = "select imeKlase from Klasa where idKlase=" + idKlase1 + ";";
            dar14 = c14.ExecuteReader();
            dar14.Read();
            ImeKlase1 = Convert.ToString(dar14[0].ToString());
            cbKlasa.Text = Convert.ToString(ImeKlase1);

            // Aligment
            OleDbCommand c15, c16;
            OleDbDataReader dar15, dar16;
            int idOpredeljenosti1;
            string ImeOpredeljenosti1;
            c15 = cone.CreateCommand();
            c15.CommandType = CommandType.Text;
            c16 = cone.CreateCommand();
            c16.CommandType = CommandType.Text;

            c15.CommandText = "select idOpredeljenosti from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar15 = c15.ExecuteReader();
            dar15.Read();
            idOpredeljenosti1 = Convert.ToInt32(dar15[0].ToString());

            c16.CommandText = "select Opredeljenost from opredeljenost where idOpredeljenosti=" + idOpredeljenosti1 + ";";
            dar16 = c16.ExecuteReader();
            dar16.Read();
            ImeOpredeljenosti1 = Convert.ToString(dar16[0].ToString());
            cbOdredjenost.Text = Convert.ToString(ImeOpredeljenosti1);
            //Background
            OleDbCommand c17, c18;
            OleDbDataReader dar17, dar18;
            int idPozadine1;
            string ImePozadine1;
            c17 = cone.CreateCommand();
            c17.CommandType = CommandType.Text;
            c18 = cone.CreateCommand();
            c18.CommandType = CommandType.Text;

            c17.CommandText = "select idPozadine from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar17 = c17.ExecuteReader();
            dar17.Read();
            idPozadine1 = Convert.ToInt32(dar17[0].ToString());

            c18.CommandText = "select Pozadina from Pozadina where  idPozadine=" + idPozadine1 + ";";
            dar18 = c18.ExecuteReader();
            dar18.Read();
            ImePozadine1 = Convert.ToString(dar18[0].ToString());
            cbPozadina.Text = Convert.ToString(ImePozadine1);

            //ImeKar
            OleDbCommand c19, c20, c01;
            OleDbDataReader dar19, dar20, dar01;
            int idImenakar1, idPola3;
            string ImeKar1;
            c01 = cone.CreateCommand();
            c01.CommandType = CommandType.Text;

            c19 = cone.CreateCommand();
            c19.CommandType = CommandType.Text;
            c20 = cone.CreateCommand();
            c20.CommandType = CommandType.Text;

            c19.CommandText = "select idImena from Karakter where idKaraktera=" + idKaraktera1 + ";";
            c01.CommandText = "select idPola from Pol where imePola='" + cbPol.Text + "';";

            dar01 = c01.ExecuteReader();
            dar01.Read();
            idPola3 = Convert.ToInt32(dar01[0].ToString());
            dar19 = c19.ExecuteReader();
            dar19.Read();
            idImenakar1 = Convert.ToInt32(dar19[0].ToString());
            c20.CommandText = "select Ime from ImeKaraktera where idImena=" + idImenakar1 + " and IdPola=" + idPola3 + ";";
            dar20 = c20.ExecuteReader();
            dar20.Read();
            ImeKar1 = Convert.ToString(dar20[0].ToString());

            cbIme.Text = Convert.ToString(ImeKar1);

            //PrezimeKar
            OleDbCommand c21, c22;
            OleDbDataReader dar21, dar22;
            int idPrezimenakar1;
            string PrezimeKar1;
            c21 = cone.CreateCommand();
            c21.CommandType = CommandType.Text;
            c22 = cone.CreateCommand();
            c22.CommandType = CommandType.Text;

            c21.CommandText = "select idPrezimena from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar21 = c21.ExecuteReader();
            dar21.Read();
            idPrezimenakar1 = Convert.ToInt32(dar21[0].ToString());
            c22.CommandText = "select Prezime from Prezimekaraktera where idPrezimena=" + idPrezimenakar1 + ";";
            dar22 = c22.ExecuteReader();
            dar22.Read();
            PrezimeKar1 = Convert.ToString(dar22[0].ToString());
            cbPrezime.Text = Convert.ToString(PrezimeKar1);

            //speed
            OleDbCommand c23;
            OleDbDataReader dar23;
            string speed1;
            c23 = cone.CreateCommand();
            c23.CommandType = CommandType.Text;
            c23.CommandText = "select Speed from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar23 = c23.ExecuteReader();
            dar23.Read();
            speed1 = Convert.ToString(dar23[0].ToString());
            tbSpeed.Text = Convert.ToString(speed1);
            //Hp
            OleDbCommand c24, c25;
            OleDbDataReader dar24, dar25;
            string hp1, hp2;
            //trenutni
            c24 = cone.CreateCommand();
            c24.CommandType = CommandType.Text;
            c24.CommandText = "select CurrentHitPoints from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar24 = c24.ExecuteReader();
            dar24.Read();
            hp1 = Convert.ToString(dar24[0].ToString());

            tbCurrentHitPoints.Text = Convert.ToString(hp1);

            //privremeni
            c25 = cone.CreateCommand();
            c25.CommandType = CommandType.Text;
            c25.CommandText = "select TemporaryHitPoints from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar25 = c25.ExecuteReader();
            dar25.Read();
            hp2 = Convert.ToString(dar25[0].ToString());
            tbTemporaryHitPoints.Text = Convert.ToString(hp2);

            //snaga
            OleDbCommand c26;
            OleDbDataReader dar26;
            string snaga1;
            c26 = cone.CreateCommand();
            c26.CommandType = CommandType.Text;
            c26.CommandText = "select snagamax from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar26 = c26.ExecuteReader();
            dar26.Read();
            snaga1 = Convert.ToString(dar26[0].ToString());
            tbSnagam.Text = Convert.ToString(snaga1);

            //dexterity
            OleDbCommand c27;
            OleDbDataReader dar27;
            string dexterity1;
            c27 = cone.CreateCommand();
            c27.CommandType = CommandType.Text;
            c27.CommandText = "select dexterityMax from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar27 = c27.ExecuteReader();
            dar27.Read();
            dexterity1 = Convert.ToString(dar27[0].ToString());
            tbSpremnostm.Text = Convert.ToString(dexterity1);

            //constitution
            OleDbCommand c28;
            OleDbDataReader dar28;
            string constitution1;
            c28 = cone.CreateCommand();
            c28.CommandType = CommandType.Text;
            c28.CommandText = "select constitutionMax from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar28 = c28.ExecuteReader();
            dar28.Read();
            constitution1 = Convert.ToString(dar28[0].ToString());
            tbKonstitucijam.Text = Convert.ToString(constitution1);

            //intelligence
            OleDbCommand c29;
            OleDbDataReader dar29;
            string intelligence1;
            c29 = cone.CreateCommand();
            c29.CommandType = CommandType.Text;
            c29.CommandText = "select intelligenceMax from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar29 = c29.ExecuteReader();
            dar29.Read();
            intelligence1 = Convert.ToString(dar29[0].ToString());
            tbInteligencijam.Text = Convert.ToString(intelligence1);

            //wisdom
            OleDbCommand c30;
            OleDbDataReader dar30;
            string wisdom1;
            c30 = cone.CreateCommand();
            c30.CommandType = CommandType.Text;
            c30.CommandText = "select wisdomMax from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar30 = c30.ExecuteReader();
            dar30.Read();
            wisdom1 = Convert.ToString(dar30[0].ToString());
            tbMudrostm.Text = Convert.ToString(wisdom1);

            //charisma
            OleDbCommand c31;
            OleDbDataReader dar31;
            string charisma1;
            c31 = cone.CreateCommand();
            c31.CommandType = CommandType.Text;
            c31.CommandText = "select charismaMax from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar31 = c31.ExecuteReader();
            dar31.Read();
            charisma1 = Convert.ToString(dar31[0].ToString());
            tbHarizmam.Text = Convert.ToString(charisma1);


           

            //cp
            OleDbCommand c32;
            OleDbDataReader dar32;
            int cp1;
            c32 = cone.CreateCommand();
            c32.CommandType = CommandType.Text;
            c32.CommandText = "select cp from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar32 = c32.ExecuteReader();
            dar32.Read();
            cp1 = Convert.ToInt32(dar32[0].ToString());
            tbCP.Text = Convert.ToString(cp1);

            //sp
            OleDbCommand c33;
            OleDbDataReader dar33;
            int sp1;
            c33 = cone.CreateCommand();
            c33.CommandType = CommandType.Text;
            c33.CommandText = "select sp from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar33 = c33.ExecuteReader();
            dar33.Read();
            sp1 = Convert.ToInt32(dar33[0].ToString());
            tbSP.Text = Convert.ToString(sp1);

            //Ep
            OleDbCommand c34;
            OleDbDataReader dar34;
            int ep1;
            c34 = cone.CreateCommand();
            c34.CommandType = CommandType.Text;
            c34.CommandText = "select ep from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar34 = c34.ExecuteReader();
            dar34.Read();
            ep1 = Convert.ToInt32(dar34[0].ToString());
            tbEP.Text = Convert.ToString(ep1);

            //gp
            OleDbCommand c35;
            OleDbDataReader dar35;
            int gp1;
            c35 = cone.CreateCommand();
            c35.CommandType = CommandType.Text;
            c35.CommandText = "select gp from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar35 = c35.ExecuteReader();
            dar35.Read();
            gp1 = Convert.ToInt32(dar35[0].ToString());
            tbGP.Text = Convert.ToString(gp1);

            //pp
            OleDbCommand c36;
            OleDbDataReader dar36;
            int pp1;
            c36 = cone.CreateCommand();
            c36.CommandType = CommandType.Text;
            c36.CommandText = "select pp from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar36 = c36.ExecuteReader();
            dar36.Read();
            pp1 = Convert.ToInt32(dar36[0].ToString());
            tbPP.Text = Convert.ToString(pp1);

            //ITEMS
            OleDbCommand c002,c003;
            OleDbDataReader d2,d3;
            string imeOpreme;
            
            c002 = cone.CreateCommand();
            c002.CommandType = CommandType.Text;
            c002.CommandText = "select idOpreme from ImaOpremu where idKaraktera="+idKaraktera1+";";
            d2 = c002.ExecuteReader();
            c003 = cone.CreateCommand();
            c003.CommandType = CommandType.Text;
            int IdOpreme;
            while (d2.Read())
            {
                IdOpreme = Convert.ToInt32(d2[0].ToString());

                c003.CommandText = "select imeOpreme from Oprema where idOpreme=" + IdOpreme + ";";
                d3 = c003.ExecuteReader();
                while (d3.Read())
                {
                    imeOpreme = Convert.ToString(d3[0].ToString());
                    lbOprema.Items.Add(imeOpreme);
                }
                d3.Close();

            }

            d2.Close();


            //personality
            OleDbCommand c40;
            OleDbDataReader dar40;
            string personality1;
            c40 = cone.CreateCommand();
            c40.CommandType = CommandType.Text;
            c40.CommandText = "select PersonalityTraits from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar40 = c40.ExecuteReader();
            dar40.Read();
            personality1 = Convert.ToString(dar40[0].ToString());
            tbPersonalityTraits.Text = Convert.ToString(personality1);

            //ideals
            OleDbCommand c41;
            OleDbDataReader dar41;
            string ideals1;
            c41 = cone.CreateCommand();
            c41.CommandType = CommandType.Text;
            c41.CommandText = "select Ideals from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar41 = c41.ExecuteReader();
            dar41.Read();
            ideals1 = Convert.ToString(dar41[0].ToString());
            tbIdeals.Text = Convert.ToString(ideals1);

            //Bonds
            OleDbCommand c42;
            OleDbDataReader dar42;
            string Bonds1;
            c42 = cone.CreateCommand();
            c42.CommandType = CommandType.Text;
            c42.CommandText = "select Bonds from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar42 = c42.ExecuteReader();
            dar42.Read();
            Bonds1 = Convert.ToString(dar42[0].ToString());
            tbBonds.Text = Convert.ToString(Bonds1);

            //Flaws
            OleDbCommand c43;
            OleDbDataReader dar43;
            string Flaws1;
            c43 = cone.CreateCommand();
            c43.CommandType = CommandType.Text;
            c43.CommandText = "select Flaws from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar43 = c43.ExecuteReader();
            dar43.Read();
            Flaws1 = Convert.ToString(dar43[0].ToString());
            tbFlaws.Text = Convert.ToString(Flaws1);

            //Hit Dice
            OleDbCommand c44;
            OleDbDataReader dar44;
            string dice1;
            c44 = cone.CreateCommand();
            c44.CommandType = CommandType.Text;
            c44.CommandText = "select [Hit Dice] from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar44 = c44.ExecuteReader();
            dar44.Read();
            dice1 = Convert.ToString(dar44[0].ToString());
            tbHitDice.Text = Convert.ToString(dice1);

            //Other prof
            OleDbCommand c45;
            OleDbDataReader dar45;
            string prof1;
            c45 = cone.CreateCommand();
            c45.CommandType = CommandType.Text;
            c45.CommandText = "select OtherProficencies from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar45 = c45.ExecuteReader();
            dar45.Read();
            prof1 = Convert.ToString(dar45[0].ToString());
            tbOtherProf.Text = Convert.ToString(prof1);

            //Lang
            OleDbCommand c46;
            OleDbDataReader dar46;
            string lang1;
            c46 = cone.CreateCommand();
            c46.CommandType = CommandType.Text;
            c46.CommandText = "select Languages from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar46 = c46.ExecuteReader();
            dar46.Read();
            lang1 = Convert.ToString(dar46[0].ToString());
            tbLanguages.Text = Convert.ToString(lang1);

            
            //FeaturesAndTraits
            OleDbCommand c47;
            OleDbDataReader dar47;
            string fnt1;
            c47 = cone.CreateCommand();
            c47.CommandType = CommandType.Text;
            c47.CommandText = "select FeaturesAndTraits from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar47 = c47.ExecuteReader();
            dar47.Read();
            fnt1 = Convert.ToString(dar47[0].ToString());
            tbFeaturesAndTraits.Text = Convert.ToString(fnt1);
            

            //attandSpell
            OleDbCommand c48;
            OleDbDataReader dar48;
            string attandspell1;
            c48 = cone.CreateCommand();
            c48.CommandType = CommandType.Text;
            c48.CommandText = "select attandspell from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar48 = c48.ExecuteReader();
            dar48.Read();
            attandspell1 = Convert.ToString(dar48[0].ToString());
            tbAttakAndSpellCast.Text = Convert.ToString(attandspell1);

            //attandspellname1
            OleDbCommand c49;
            OleDbDataReader dar49;
            string attandspelln1;
            c49 = cone.CreateCommand();
            c49.CommandType = CommandType.Text;
            c49.CommandText = "select attandspellname1 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar49 = c49.ExecuteReader();
            dar49.Read();
            attandspelln1 = Convert.ToString(dar49[0].ToString());
            tbatandSpelName1.Text = Convert.ToString(attandspelln1);

            //attandspellname2
            OleDbCommand c50;
            OleDbDataReader dar50;
            string attandspelln2;
            c50 = cone.CreateCommand();
            c50.CommandType = CommandType.Text;
            c50.CommandText = "select attandspellname2 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar50 = c50.ExecuteReader();
            dar50.Read();
            attandspelln2 = Convert.ToString(dar50[0].ToString());
            tbatandSpelName2.Text = Convert.ToString(attandspelln2);

            //attandspellname3
            OleDbCommand c51;
            OleDbDataReader dar51;
            string attandspelln3;
            c51 = cone.CreateCommand();
            c51.CommandType = CommandType.Text;
            c51.CommandText = "select attandspellname3 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar51 = c51.ExecuteReader();
            dar51.Read();
            attandspelln3 = Convert.ToString(dar51[0].ToString());
            tbatandSpelName3.Text = Convert.ToString(attandspelln3);

            //attandspellname4
            OleDbCommand c52;
            OleDbDataReader dar52;
            string attandspelln4;
            c52 = cone.CreateCommand();
            c52.CommandType = CommandType.Text;
            c52.CommandText = "select attandspellname4 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar52 = c52.ExecuteReader();
            dar52.Read();
            attandspelln4 = Convert.ToString(dar52[0].ToString());
            tbatandSpelName4.Text = Convert.ToString(attandspelln4);

            //atkbonus1
            OleDbCommand c53;
            OleDbDataReader dar53;
            string atkb1;
            c53 = cone.CreateCommand();
            c53.CommandType = CommandType.Text;
            c53.CommandText = "select atkbonus1 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar53 = c53.ExecuteReader();
            dar53.Read();
            atkb1 = Convert.ToString(dar53[0].ToString());
            tbAtkBonus1.Text = Convert.ToString(atkb1);

            //atkbonus2
            OleDbCommand c54;
            OleDbDataReader dar54;
            string atkb2;
            c54 = cone.CreateCommand();
            c54.CommandType = CommandType.Text;
            c54.CommandText = "select atkbonus2 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar54 = c54.ExecuteReader();
            dar54.Read();
            atkb2 = Convert.ToString(dar54[0].ToString());
            tbAtkBonus2.Text = Convert.ToString(atkb2);

            //atkbonus3
            OleDbCommand c55;
            OleDbDataReader dar55;
            string atkb3;
            c55 = cone.CreateCommand();
            c55.CommandType = CommandType.Text;
            c55.CommandText = "select atkbonus3 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar55 = c55.ExecuteReader();
            dar55.Read();
            atkb3 = Convert.ToString(dar55[0].ToString());
            tbAtkBonus3.Text = Convert.ToString(atkb3);

            //atkbonus24
            OleDbCommand c56;
            OleDbDataReader dar56;
            string atkb4;
            c56 = cone.CreateCommand();
            c56.CommandType = CommandType.Text;
            c56.CommandText = "select atkbonus4 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar56 = c56.ExecuteReader();
            dar56.Read();
            atkb4 = Convert.ToString(dar56[0].ToString());
            tbAtkBonus4.Text = Convert.ToString(atkb4);

            //damagetype1
            OleDbCommand c57;
            OleDbDataReader dar57;
            string dt01;
            c57 = cone.CreateCommand();
            c57.CommandType = CommandType.Text;
            c57.CommandText = "select damagetype1 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar57 = c57.ExecuteReader();
            dar57.Read();
            dt01 = Convert.ToString(dar57[0].ToString());
            tbDamageType1.Text = Convert.ToString(dt01);

            //damagetype2
            OleDbCommand c58;
            OleDbDataReader dar58;
            string dt02;
            c58 = cone.CreateCommand();
            c58.CommandType = CommandType.Text;
            c58.CommandText = "select damagetype2 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar58 = c58.ExecuteReader();
            dar58.Read();
            dt02 = Convert.ToString(dar58[0].ToString());
            tbDamageType2.Text = Convert.ToString(dt02);

            //damagetype3
            OleDbCommand c59;
            OleDbDataReader dar59;
            string dt03;
            c59 = cone.CreateCommand();
            c59.CommandType = CommandType.Text;
            c59.CommandText = "select damagetype3 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar59 = c59.ExecuteReader();
            dar59.Read();
            dt03 = Convert.ToString(dar59[0].ToString());
            tbDamageType3.Text = Convert.ToString(dt03);

            //damagetype4
            OleDbCommand c60;
            OleDbDataReader dar60;
            string dt04;
            c60 = cone.CreateCommand();
            c60.CommandType = CommandType.Text;
            c60.CommandText = "select damagetype4 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar60 = c60.ExecuteReader();
            dar60.Read();
            dt04 = Convert.ToString(dar60[0].ToString());
            tbDamageType4.Text = Convert.ToString(dt04);

            //attackandspell
            OleDbCommand c61;
            OleDbDataReader dar61;
            string dt05;
            c61 = cone.CreateCommand();
            c61.CommandType = CommandType.Text;
            c61.CommandText = "select attacksAndSpellcasting from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dar61 = c61.ExecuteReader();
            dar61.Read();
            dt05 = Convert.ToString(dar61[0].ToString());
            tbAttakAndSpellCast.Text = Convert.ToString(dt05);

            OleDbCommand k1,k2,k3,k4,k5,k6,k7,k8,k9,k10,k11,k12,k13,k14,k15,k16,k17,k18;
            k1 = cone.CreateCommand();
            k1.CommandType = CommandType.Text;
            k2 = cone.CreateCommand();
            k2.CommandType = CommandType.Text;
            k3 = cone.CreateCommand();
            k3.CommandType = CommandType.Text;
            k4 = cone.CreateCommand();
            k4.CommandType = CommandType.Text;
            k5 = cone.CreateCommand();
            k5.CommandType = CommandType.Text;
            k6 = cone.CreateCommand();
            k6.CommandType = CommandType.Text;
            k7 = cone.CreateCommand();
            k7.CommandType = CommandType.Text;
            k8 = cone.CreateCommand();
            k8.CommandType = CommandType.Text;
            k9 = cone.CreateCommand();
            k9.CommandType = CommandType.Text;
            k10 = cone.CreateCommand();
            k10.CommandType = CommandType.Text;
            k11 = cone.CreateCommand();
            k11.CommandType = CommandType.Text;
            k12 = cone.CreateCommand();
            k12.CommandType = CommandType.Text;
            k13 = cone.CreateCommand();
            k13.CommandType = CommandType.Text;
            k14 = cone.CreateCommand();
            k14.CommandType = CommandType.Text;
            k15 = cone.CreateCommand();
            k15.CommandType = CommandType.Text;
            k16 = cone.CreateCommand();
            k16.CommandType = CommandType.Text;
            k17 = cone.CreateCommand();
            k17.CommandType = CommandType.Text;
            k18 = cone.CreateCommand();
            k18.CommandType = CommandType.Text;
            int q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15,q16,q17,q18;
            OleDbDataReader dd1,dd2,dd3,dd4,dd5,dd6,dd7,dd8,dd9,dd10,dd11,dd12,dd13,dd14,dd15,dd16,dd17,dd18;
            OleDbCommand qq1, qq2, qq3, qq4, qq5, qq6;
            int qd1, qd2, qd3, qd4, qd5, qd6;
            OleDbDataReader rr1, rr2, rr3, rr4, rr5, rr6;
            qq1 = cone.CreateCommand();
            qq1.CommandType = CommandType.Text;
            qq1.CommandText = "select cbdsfails1 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            rr1 = qq1.ExecuteReader();
            rr1.Read();
            qd1 = Convert.ToInt32(rr1[0].ToString());
            if (qd1 == 1)
            {
                cbdeathfail1.Checked = true;
            }
            else
            {
                cbdeathfail1.Checked = false;
            }
            qq2 = cone.CreateCommand();
            qq2.CommandType = CommandType.Text;
            qq2.CommandText = "select cbdsfails2 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            rr2 = qq2.ExecuteReader();
            rr2.Read();
            qd2 = Convert.ToInt32(rr2[0].ToString());
            if (qd2 == 1)
            {
                cbdeathfail2.Checked = true;
            }
            else
            {
                cbdeathfail2.Checked = false;
            }
            qq3 = cone.CreateCommand();
            qq3.CommandType = CommandType.Text;
            qq3.CommandText = "select cbdsfails3 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            rr3 = qq3.ExecuteReader();
            rr3.Read();
            qd3 = Convert.ToInt32(rr3[0].ToString());
            if (qd3 == 1)
            {
                cbdeathfail3.Checked = true;
            }
            else
            {
                cbdeathfail3.Checked = false;
            }
            qq4 = cone.CreateCommand();
            qq4.CommandType = CommandType.Text;
            qq4.CommandText = "select cbdswins1 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            rr4 = qq4.ExecuteReader();
            rr4.Read();
            qd4 = Convert.ToInt32(rr4[0].ToString());
            if (qd4 == 1)
            {
                cbdeathsuces1.Checked = true;
            }
            else
            {
                cbdeathsuces1.Checked = false;
            }
            qq5 = cone.CreateCommand();
            qq5.CommandType = CommandType.Text;
            qq5.CommandText = "select cbdswins2 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            rr5 = qq5.ExecuteReader();
            rr5.Read();
            qd5 = Convert.ToInt32(rr5[0].ToString());
            if (qd5 == 1)
            {
                cbdeathsuces2.Checked = true;
            }
            else
            {
                cbdeathsuces2.Checked = false;
            }

            qq6 = cone.CreateCommand();
            qq6.CommandType = CommandType.Text;
            qq6.CommandText = "select cbdswins3 from Karakter where idKaraktera=" + idKaraktera1 + ";";
            rr6 = qq6.ExecuteReader();
            rr6.Read();
            qd6 = Convert.ToInt32(rr6[0].ToString());
            if (qd6 == 1)
            {
                cbdeathsuces3.Checked = true;
            }
            else
            {
                cbdeathsuces3.Checked = false;
            }


            k1.CommandText = "select cbarcana from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd1 = k1.ExecuteReader();
            dd1.Read();
            q1 = Convert.ToInt32(dd1[0].ToString());

            if (q1 == 1)
            {
                cbArcana.Checked = true;
            }
            else
            {
                cbArcana.Checked = false;
            }
            k2.CommandText = "select cbathletics from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd2 = k2.ExecuteReader();
            dd2.Read();
            q2 = Convert.ToInt32(dd2[0].ToString());

            if (q2 == 1)
            {
                cbAthle.Checked = true;
            }
            else
            {
                cbAthle.Checked = false;
            }
            k3.CommandText = "select cbdeception from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd3 = k3.ExecuteReader();
            dd3.Read();
            q3 = Convert.ToInt32(dd3[0].ToString());

            if (q3 == 1)
            {
                cbDecept.Checked = true;
            }
            else
            {
                cbDecept.Checked = false;
            }
            k4.CommandText = "select cbhistory from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd4 = k4.ExecuteReader();
            dd4.Read();
            q4 = Convert.ToInt32(dd4[0].ToString());

            if (q4 == 1)
            {
                cbHist.Checked = true;
            }
            else
            {
                cbHist.Checked = false;
            }
            k5.CommandText = "select cbinsight from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd5 = k5.ExecuteReader();
            dd5.Read();
            q5 = Convert.ToInt32(dd5[0].ToString());

            if (q5 == 1)
            {
                cbInsight.Checked = true;
            }
            else
            {
                cbInsight.Checked = false;
            }

            k6.CommandText = "select cbintimidation from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd6 = k6.ExecuteReader();
            dd6.Read();
            q6 = Convert.ToInt32(dd6[0].ToString());

            if (q6 == 1)
            {
                cbIntimid.Checked = true;
            }
            else
            {
                cbIntimid.Checked = false;
            }

            k7.CommandText = "select cbinvestigation from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd7 = k7.ExecuteReader();
            dd7.Read();
            q7 = Convert.ToInt32(dd7[0].ToString());

            if (q7 == 1)
            {
                cbInvestig.Checked = true;
            }
            else
            {
                cbInvestig.Checked = false;
            }

            k8.CommandText = "select cbmedicine from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd8 = k8.ExecuteReader();
            dd8.Read();
            q8 = Convert.ToInt32(dd8[0].ToString());

            if (q8 == 1)
            {
                cbMedicine.Checked = true;
            }
            else
            {
                cbMedicine.Checked = false;
            }
            k9.CommandText = "select cbnature from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd9 = k9.ExecuteReader();
            dd9.Read();
            q9 = Convert.ToInt32(dd9[0].ToString());

            if (q9 == 1)
            {
                cbNature.Checked = true;
            }
            else
            {
                cbNature.Checked = false;
            }
            k10.CommandText = "select cbperception from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd10 = k10.ExecuteReader();
            dd10.Read();
            q10 = Convert.ToInt32(dd10[0].ToString());

            if (q10 == 1)
            {
                cbPerception.Checked = true;
            }
            else
            {
                cbPerception.Checked = false;
            }
            k11.CommandText = "select cbperfomance from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd11 = k11.ExecuteReader();
            dd11.Read();
            q11 = Convert.ToInt32(dd11[0].ToString());

            if (q11 == 1)
            {
                cbPerfomance.Checked = true;
            }
            else
            {
                cbPerfomance.Checked = false;
            }
            k12.CommandText = "select cbpersuasion from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd12 = k12.ExecuteReader();
            dd12.Read();
            q12 = Convert.ToInt32(dd12[0].ToString());

            if (q12 == 1)
            {
                cbPersuation.Checked = true;
            }
            else
            {
                cbPersuation.Checked = false;
            }
            k13.CommandText = "select cbreligion from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd13 = k13.ExecuteReader();
            dd13.Read();
            q13 = Convert.ToInt32(dd13[0].ToString());

            if (q13 == 1)
            {
                cbReligion.Checked = true;
            }
            else
            {
                cbReligion.Checked = false;
            }

            k14.CommandText = "select cbsleighofhand from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd14 = k14.ExecuteReader();
            dd14.Read();
            q14 = Convert.ToInt32(dd14[0].ToString());

            if (q14 == 1)
            {
                cbSleighOfHand.Checked = true;
            }
            else
            {
                cbSleighOfHand.Checked = false;
            }

            k15.CommandText = "select cbsurvival from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd15 = k15.ExecuteReader();
            dd15.Read();
            q15 = Convert.ToInt32(dd15[0].ToString());

            if (q15 == 1)
            {
                cbSurvival.Checked = true;
            }
            else
            {
                cbSurvival.Checked = false;
            }

            k16.CommandText = "select cbstealth from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd16 = k16.ExecuteReader();
            dd16.Read();
            q16= Convert.ToInt32(dd16[0].ToString());

            if (q16 == 1)
            {
                cbStealth.Checked = true;
            }
            else
            {
                cbStealth.Checked = false;
            }
            k17.CommandText = "select cbacrobatics from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd17 = k17.ExecuteReader();
            dd17.Read();
            q17 = Convert.ToInt32(dd17[0].ToString());

            if (q17 == 1)
            {
                cbAcrob.Checked = true;
            }
            else
            {
                cbAcrob.Checked = false;
            }
            k18.CommandText = "select cbanimal from Karakter where idKaraktera=" + idKaraktera1 + ";";
            dd18 = k18.ExecuteReader();
            dd18.Read();
            q18 = Convert.ToInt32(dd18[0].ToString());

            if (q18 == 1)
            {
                cbAnimal.Checked = true;
            }
            else
            {
                cbAnimal.Checked = false;
            }

            cone.Close();

        }


        public void CheckedFalse()
        {
            cbAnimal.Checked = false;
            cbAthle.Checked = false;
            cbIntimid.Checked = false;
            cbNature.Checked = false;
            cbPerception.Checked = false;
            cbSurvival.Checked = false;
            cbAcrob.Checked = false;
            cbArcana.Checked = false;
            cbDecept.Checked = false;
            cbHist.Checked = false;
            cbInsight.Checked = false;
            cbInvestig.Checked = false;
            cbMedicine.Checked = false;
            cbPerfomance.Checked = false;
            cbPersuation.Checked = false;
            cbReligion.Checked = false;
            cbSleighOfHand.Checked = false;
            cbStealth.Checked = false;
        }
        public void CbEnabled()
        {
            cbSnaga.Enabled = false;
            cbKonstitucija.Enabled = false;
            cbSpremnost.Enabled = false;
            cbInteligencija.Enabled = false;
            cbMudrost.Enabled = false;
            cbHarizma.Enabled = false;
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            CbEnabled();
            if (cbKlasa.SelectedIndex == 0)
            {

                cbSnaga.Checked = false;
                cbKonstitucija.Checked = false;
                cbSpremnost.Checked = false;
                cbInteligencija.Checked = false;
                cbMudrost.Checked = false;
                cbHarizma.Checked = false;



                cbAnimal.Enabled = false;
                cbAthle.Enabled = false;
                cbIntimid.Enabled = false;
                cbNature.Enabled = false;
                cbPerception.Enabled = false;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = false;
                cbDecept.Enabled = false;
                cbHist.Enabled = false;
                cbInsight.Enabled = false;
                cbInvestig.Enabled = false;
                cbMedicine.Enabled = false;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = false;
                cbReligion.Enabled = false;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = false;

                CheckedFalse();

            }
            if (cbKlasa.SelectedIndex == 1)
            {

                cbSnaga.Checked = true;
                cbKonstitucija.Checked = true;
                cbSpremnost.Checked = false;
                cbInteligencija.Checked = false;
                cbMudrost.Checked = false;
                cbHarizma.Checked = false;


                //bira 2
                cbAnimal.Enabled = true;
                cbAthle.Enabled = true;
                cbIntimid.Enabled = true;
                cbNature.Enabled = true;
                cbPerception.Enabled = true;
                cbSurvival.Enabled = true;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = false;
                cbDecept.Enabled = false;
                cbHist.Enabled = false;
                cbInsight.Enabled = false;
                cbInvestig.Enabled = false;
                cbMedicine.Enabled = false;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = false;
                cbReligion.Enabled = false;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = false;

                CheckedFalse();

            }
            else if (cbKlasa.SelectedIndex == 2)
            {

                cbSpremnost.Checked = true;
                cbHarizma.Checked = true;
                cbInteligencija.Checked = false;
                cbMudrost.Checked = false;
                cbSnaga.Checked = false;
                cbKonstitucija.Checked = false;

                //bira 3 od svih 

                cbAnimal.Enabled = true;
                cbAthle.Enabled = true;
                cbIntimid.Enabled = true;
                cbNature.Enabled = true;
                cbPerception.Enabled = true;
                cbSurvival.Enabled = true;
                cbAcrob.Enabled = true;
                cbArcana.Enabled = true;
                cbDecept.Enabled = true;
                cbHist.Enabled = true;
                cbInsight.Enabled = true;
                cbInvestig.Enabled = true;
                cbMedicine.Enabled = true;
                cbPerfomance.Enabled = true;
                cbPersuation.Enabled = true;
                cbReligion.Enabled = true;
                cbSleighOfHand.Enabled = true;
                cbStealth.Enabled = true;
                CheckedFalse();
            }
            else if (cbKlasa.SelectedIndex == 3)
            {

                cbMudrost.Checked = true;
                cbHarizma.Checked = true;
                cbSpremnost.Checked = false;
                cbInteligencija.Checked = false;
                cbSnaga.Checked = false;
                cbKonstitucija.Checked = false;
                //bira 2
                cbAnimal.Enabled = false;
                cbAthle.Enabled = false;
                cbIntimid.Enabled = false;
                cbNature.Enabled = false;
                cbPerception.Enabled = false;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = false;
                cbDecept.Enabled = false;
                cbHist.Enabled = true;
                cbInsight.Enabled = true;
                cbInvestig.Enabled = false;
                cbMedicine.Enabled = true;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = true;
                cbReligion.Enabled = true;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = false;
                CheckedFalse();
            }
            else if (cbKlasa.SelectedIndex == 4)
            {

                cbInteligencija.Checked = true;
                cbMudrost.Checked = true;
                cbSnaga.Checked = false;
                cbKonstitucija.Checked = false;
                cbSpremnost.Checked = false;
                cbHarizma.Checked = false;
                //bira 3
                cbAnimal.Enabled = true;
                cbAthle.Enabled = false;
                cbIntimid.Enabled = false;
                cbNature.Enabled = true;
                cbPerception.Enabled = true;
                cbSurvival.Enabled = true;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = true;
                cbDecept.Enabled = false;
                cbHist.Enabled = false;
                cbInsight.Enabled = true;
                cbInvestig.Enabled = false;
                cbMedicine.Enabled = true;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = false;
                cbReligion.Enabled = true;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = false;
                CheckedFalse();
            }
            else if (cbKlasa.SelectedIndex == 5)
            {

                cbSnaga.Checked = true;
                cbKonstitucija.Checked = true;
                cbMudrost.Checked = false;
                cbHarizma.Checked = false;
                cbSpremnost.Checked = false;
                cbInteligencija.Checked = false;
                //bira 2
                cbAnimal.Enabled = true;
                cbAthle.Enabled = true;
                cbIntimid.Enabled = true;
                cbNature.Enabled = false;
                cbPerception.Enabled = true;
                cbSurvival.Enabled = true;
                cbAcrob.Enabled = true;
                cbArcana.Enabled = false;
                cbDecept.Enabled = false;
                cbHist.Enabled = true;
                cbInsight.Enabled = true;
                cbInvestig.Enabled = false;
                cbMedicine.Enabled = false;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = false;
                cbReligion.Enabled = false;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = false;
                CheckedFalse();
            }
            else if (cbKlasa.SelectedIndex == 6)
            {

                cbSnaga.Checked = true;
                cbSpremnost.Checked = true;
                cbMudrost.Checked = false;
                cbHarizma.Checked = false;
                cbInteligencija.Checked = false;
                cbKonstitucija.Checked = false;
                //bira 2
                cbAnimal.Enabled = false;
                cbAthle.Enabled = true;
                cbIntimid.Enabled = false;
                cbNature.Enabled = false;
                cbPerception.Enabled = false;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = true;
                cbArcana.Enabled = false;
                cbDecept.Enabled = false;
                cbHist.Enabled = true;
                cbInsight.Enabled = true;
                cbInvestig.Enabled = false;
                cbMedicine.Enabled = false;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = false;
                cbReligion.Enabled = true;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = true;
                CheckedFalse();
            }
            else if (cbKlasa.SelectedIndex == 7)
            {

                cbSnaga.Checked = false;
                cbSpremnost.Checked = false;
                cbMudrost.Checked = true;
                cbHarizma.Checked = true;
                cbInteligencija.Checked = false;
                cbKonstitucija.Checked = false;

                //bira 2
                cbAnimal.Enabled = false;
                cbAthle.Enabled = true;
                cbIntimid.Enabled = true;
                cbNature.Enabled = false;
                cbPerception.Enabled = false;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = false;
                cbDecept.Enabled = false;
                cbHist.Enabled = false;
                cbInsight.Enabled = true;
                cbInvestig.Enabled = false;
                cbMedicine.Enabled = true;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = true;
                cbReligion.Enabled = true;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = false;
                CheckedFalse();
            }

            else if (cbKlasa.SelectedIndex == 8)
            {

                cbSnaga.Checked = true;
                cbSpremnost.Checked = true;
                cbMudrost.Checked = false;
                cbHarizma.Checked = false;
                cbInteligencija.Checked = false;
                cbKonstitucija.Checked = false;

                //bira 3
                cbAnimal.Enabled = true;
                cbAthle.Enabled = true;
                cbIntimid.Enabled = false;
                cbNature.Enabled = true;
                cbPerception.Enabled = true;
                cbSurvival.Enabled = true;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = false;
                cbDecept.Enabled = false;
                cbHist.Enabled = false;
                cbInsight.Enabled = true;
                cbInvestig.Enabled = true;
                cbMedicine.Enabled = false;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = false;
                cbReligion.Enabled = false;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = true;
                CheckedFalse();
            }

            else if (cbKlasa.SelectedIndex == 9)
            {

                cbSpremnost.Checked = true;
                cbInteligencija.Checked = true;
                cbSnaga.Checked = false;
                cbKonstitucija.Checked = false;
                cbMudrost.Checked = false;
                cbHarizma.Checked = false;

                //bira 4
                cbAnimal.Enabled = false;
                cbAthle.Enabled = true;
                cbIntimid.Enabled = true;
                cbNature.Enabled = false;
                cbPerception.Enabled = true;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = true;
                cbArcana.Enabled = false;
                cbDecept.Enabled = true;
                cbHist.Enabled = false;
                cbInsight.Enabled = true;
                cbInvestig.Enabled = true;
                cbMedicine.Enabled = false;
                cbPerfomance.Enabled = true;
                cbPersuation.Enabled = true;
                cbReligion.Enabled = false;
                cbSleighOfHand.Enabled = true;
                cbStealth.Enabled = true;
                CheckedFalse();
            }
            else if (cbKlasa.SelectedIndex == 10)
            {

                cbSnaga.Checked = false;
                cbSpremnost.Checked = false;
                cbMudrost.Checked = false;
                cbHarizma.Checked = true;
                cbInteligencija.Checked = false;
                cbKonstitucija.Checked = true;

                //bira 2

                cbAnimal.Enabled = false;
                cbAthle.Enabled = false;
                cbIntimid.Enabled = true;
                cbNature.Enabled = false;
                cbPerception.Enabled = false;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = true;
                cbDecept.Enabled = true;
                cbHist.Enabled = false;
                cbInsight.Enabled = true;
                cbInvestig.Enabled = false;
                cbMedicine.Enabled = false;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = true;
                cbReligion.Enabled = true;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = false;
                CheckedFalse();


            }
            else if (cbKlasa.SelectedIndex == 11)
            {

                cbSnaga.Checked = false;
                cbSpremnost.Checked = false;
                cbMudrost.Checked = true;
                cbHarizma.Checked = true;
                cbInteligencija.Checked = false;
                cbKonstitucija.Checked = false;

                //bira 2
                cbAnimal.Enabled = false;
                cbAthle.Enabled = false;
                cbIntimid.Enabled = true;
                cbNature.Enabled = true;
                cbPerception.Enabled = false;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = true;
                cbDecept.Enabled = true;
                cbHist.Enabled = true;
                cbInsight.Enabled = false;
                cbInvestig.Enabled = true;
                cbMedicine.Enabled = false;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = false;
                cbReligion.Enabled = true;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = false;
                CheckedFalse();
            }
            else if (cbKlasa.SelectedIndex == 12)
            {

                cbSnaga.Checked = false;
                cbSpremnost.Checked = false;
                cbMudrost.Checked = true;
                cbHarizma.Checked = false;
                cbInteligencija.Checked = true;
                cbKonstitucija.Checked = false;

                //bira 2
                cbAnimal.Enabled = false;
                cbAthle.Enabled = false;
                cbIntimid.Enabled = false;
                cbNature.Enabled = false;
                cbPerception.Enabled = false;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = true;
                cbDecept.Enabled = false;
                cbHist.Enabled = true;
                cbInsight.Enabled = true;
                cbInvestig.Enabled = true;
                cbMedicine.Enabled = true;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = false;
                cbReligion.Enabled = true;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = false;
                CheckedFalse();
            }
            else if (cbKlasa.SelectedIndex == 13)
            {

                cbSnaga.Checked = false;
                cbSpremnost.Checked = false;
                cbMudrost.Checked = false;
                cbHarizma.Checked = false;
                cbInteligencija.Checked = true;
                cbKonstitucija.Checked = true;

                //bira 2
                cbAnimal.Enabled = false;
                cbAthle.Enabled = false;
                cbIntimid.Enabled = false;
                cbNature.Enabled = true;
                cbPerception.Enabled = true;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = true;
                cbDecept.Enabled = false;
                cbHist.Enabled = true;
                cbInsight.Enabled = false;
                cbInvestig.Enabled = true;
                cbMedicine.Enabled = true;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = false;
                cbReligion.Enabled = false;
                cbSleighOfHand.Enabled = true;
                cbStealth.Enabled = false;
                CheckedFalse();
            }
            else if (cbKlasa.SelectedIndex == 14)
            {

                cbSnaga.Checked = true;
                cbSpremnost.Checked = false;
                cbMudrost.Checked = true;
                cbHarizma.Checked = false;
                cbInteligencija.Checked = false;
                cbKonstitucija.Checked = false;

                //bira 2
                cbAnimal.Enabled = false;
                cbAthle.Enabled = true;
                cbIntimid.Enabled = false;
                cbNature.Enabled = false;
                cbPerception.Enabled = false;
                cbSurvival.Enabled = true;
                cbAcrob.Enabled = true;
                cbArcana.Enabled = true;
                cbDecept.Enabled = false;
                cbHist.Enabled = false;
                cbInsight.Enabled = true;
                cbInvestig.Enabled = true;
                cbMedicine.Enabled = false;
                cbPerfomance.Enabled = false;
                cbPersuation.Enabled = false;
                cbReligion.Enabled = false;
                cbSleighOfHand.Enabled = false;
                cbStealth.Enabled = false;
                CheckedFalse();
            }

        }

        private void GpStrenght_Enter(object sender, EventArgs e)
        {
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void CbPrezime_SelectedIndexChanged(object sender, EventArgs e)
        {      }

        private void CbRasa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void CbPol_SelectedIndexChanged(object sender, EventArgs e)
        {
            
      
        }
        public void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            DnD d = new DnD();
            
            int idKlase1, idRase1, idOpredeljenosti1, idImenaKaraktera1, idPrezimenaKaraktera1, idKaraktera1, idPozadine1;
            OleDbDataReader dr1, dr2, dr3, dr4, dr5, dr6, dr8;
        
            if (tbCurrentHitPoints.Text == "" || tbXP.Text == "" || tbSnagam.Text == "" || tbKonstitucijam.Text == "" || tbHarizmam.Text == "" || tbMudrostm.Text == "" || tbSpremnostm.Text == "" || tbInteligencijam.Text == "")
            {
                MessageBox.Show("Popunite osnovna polja svetlo sive boje");
            }

            else
            {
                cone.Open();
                OleDbCommand komanda = new OleDbCommand();
                OleDbCommand komanda1 = new OleDbCommand();
                OleDbCommand komanda2 = new OleDbCommand();
                OleDbCommand komanda3 = new OleDbCommand();
                OleDbCommand komanda4 = new OleDbCommand();
                komanda2.Connection = cone;
                komanda3.Connection = cone;
                komanda4.Connection = cone;
                komanda2.CommandType = CommandType.Text;
                komanda3.CommandType = CommandType.Text;
                komanda4.CommandType = CommandType.Text;
                OleDbCommand kom8 = new OleDbCommand();
                komanda1.Connection = cone;
                komanda.Connection = cone;
                OleDbCommand kom1 = new OleDbCommand();
                OleDbCommand kom2 = new OleDbCommand();
                OleDbCommand kom7 = new OleDbCommand();

                OleDbCommand kom4 = new OleDbCommand();
                OleDbCommand kom5 = new OleDbCommand();
                OleDbCommand kom6 = new OleDbCommand();

                kom1.CommandType = CommandType.Text;
                kom2.CommandType = CommandType.Text;
                kom7.CommandType = CommandType.Text;
                kom4.CommandType = CommandType.Text;
                kom5.CommandType = CommandType.Text;
                kom6.CommandType = CommandType.Text;
                kom8.CommandType = CommandType.Text;
                kom8.Connection = cone;
                kom1.Connection = cone;
                kom2.Connection = cone;
                kom7.Connection = cone;
                kom4.Connection = cone;
                kom5.Connection = cone;
                kom6.Connection = cone;
                komanda.CommandType = CommandType.Text;
                komanda1.CommandType = CommandType.Text;

                kom8.CommandText = "Select idPozadine from Pozadina where Pozadina='" + cbPozadina.Text + "';";
                dr8 = kom8.ExecuteReader();
                dr8.Read();
                idPozadine1 = Convert.ToInt32(dr8[0].ToString());
                kom1.CommandText = "select idKlase from Klasa where imeKlase='" + cbKlasa.Text + "';";
                dr1 = kom1.ExecuteReader();
                dr1.Read();
                idKlase1 = Convert.ToInt32(dr1[0].ToString());

                kom2.CommandText = "select idRase from Rasa where imeRase='" + cbRasa.Text + "';";

                dr2 = kom2.ExecuteReader();
                dr2.Read();

                idRase1 = Convert.ToInt32(dr2[0].ToString());


                kom4.CommandText = "select idOpredeljenosti from opredeljenost where Opredeljenost='" + cbOdredjenost.Text + "';";
                dr3 = kom4.ExecuteReader();
                dr3.Read();
                idOpredeljenosti1 = Convert.ToInt32(dr3[0].ToString());


                kom5.CommandText = "select idImena from imeKaraktera where ime='" + cbIme.Text + "';";
                dr4 = kom5.ExecuteReader();
                dr4.Read();
                idImenaKaraktera1 = Convert.ToInt32(dr4[0].ToString());

                kom6.CommandText = "select idPrezimena from PrezimeKaraktera where Prezime='" + cbPrezime.Text + "';";
                dr5 = kom6.ExecuteReader();
                dr5.Read();
                idPrezimenaKaraktera1 = Convert.ToInt32(dr5[0].ToString());
                int z;
                if (tbTemporaryHitPoints.Text == "")
                {
                    tbTemporaryHitPoints.Text = tbCurrentHitPoints.Text;

                }
                z = Convert.ToInt32(tbTemporaryHitPoints.Text);
                int cp, sp, ep, gp, pp;
                if (tbCP.Text == "")
                {
                    tbCP.Text = "0";
                }
                cp = Convert.ToInt32(tbCP.Text);
                if (tbSP.Text == "")
                {
                    tbSP.Text = "0";
                }
                sp = Convert.ToInt32(tbSP.Text);
                if (tbEP.Text == "")
                {
                    tbEP.Text = "0";
                }
                ep = Convert.ToInt32(tbEP.Text);
                if (tbGP.Text == "")
                {
                    tbGP.Text = "0";
                }
                gp = Convert.ToInt32(tbGP.Text);
                if (tbPP.Text == "")
                {
                    tbPP.Text = "0";
                }

                int strengthV, dexterityV, constitutionV, intelligenceV, wisdomV, charismaV;
                strengthV = Convert.ToInt32(tbSnaga.Text);
                dexterityV = Convert.ToInt32(TbSpremnost.Text);
                constitutionV = Convert.ToInt32(tbKonstitucija.Text);
                intelligenceV = Convert.ToInt32(tbInteligencija.Text);
                wisdomV = Convert.ToInt32(tbMudrost.Text);
                charismaV = Convert.ToInt32(tbHarizma.Text);

                int strengthp, dexterityp, constitutionp, intelligencep, wisdomp, charismap;

                int strengthm, dexteritym, constitutionm, intelligencem, wisdomm, charismam;
                int acrobatics, animalh, arcana, athlet, decep, hist, insig, intim, invest;
                int medic, nature, percep, perfom, persua, relig, sleighOfH, stealth, survival;
                acrobatics = Convert.ToInt32(tbAcrobatics.Text);
                animalh = Convert.ToInt32(TbAnimalHandling.Text);
                arcana = Convert.ToInt32(tbArcana.Text);
                athlet = Convert.ToInt32(tbAthletics.Text);
                decep = Convert.ToInt32(tbDeception.Text);
                hist = Convert.ToInt32(tbHistory.Text);
                insig = Convert.ToInt32(tbInsight.Text);
                intim = Convert.ToInt32(tbIntimidation.Text);
                invest = Convert.ToInt32(tbInvestigation.Text);
                medic = Convert.ToInt32(tbMedicine.Text);
                nature = Convert.ToInt32(tbNature.Text);
                percep = Convert.ToInt32(tbPerception.Text);
                perfom = Convert.ToInt32(tbPerfomance.Text);
                persua = Convert.ToInt32(tbPersuation.Text);
                relig = Convert.ToInt32(tbReligion.Text);
                sleighOfH = Convert.ToInt32(tbSleighOfHand.Text);
                stealth = Convert.ToInt32(tbStealth.Text);
                survival = Convert.ToInt32(tbSurvival.Text);

                strengthp = Convert.ToInt32(tbSnaga1.Text);
                dexterityp = Convert.ToInt32(tbSpremnost1.Text);
                constitutionp = Convert.ToInt32(tbKonstitucija1.Text);
                intelligencep = Convert.ToInt32(tbInteligencija1.Text);
                wisdomp = Convert.ToInt32(tbMudrost1.Text);
                charismap = Convert.ToInt32(tbHarizma1.Text);

                strengthm = Convert.ToInt32(tbSnagam.Text);
                dexteritym = Convert.ToInt32(tbSpremnostm.Text);
                constitutionm = Convert.ToInt32(tbKonstitucijam.Text);
                intelligencem = Convert.ToInt32(tbInteligencijam.Text);
                wisdomm = Convert.ToInt32(tbMudrostm.Text);
                charismam = Convert.ToInt32(tbHarizmam.Text);

                pp = Convert.ToInt32(tbPP.Text);
                kom7.CommandText = "select idKaraktera from Igrac where imeIgraca='" + tbImeIgraca.Text + "' and prezimeIgraca='" + tbPrezimeIgraca.Text + "';";
                dr6 = kom7.ExecuteReader();
                dr6.Read();
                idKaraktera1 = Convert.ToInt32(dr6[0].ToString());

                short arc1, athl1, hist1, acrob1, animal1, decept1, insih1, intim1, investi1;
                short medic1, natur1, perce1, perfo1, persuas1, relig1, slei1, stealt1, survi1;
                int fail1, fail2, fail3, win1, win2, win3;
                if (cbdeathsuces1.Checked == true)
                {
                    win1 = 1;
                }
                else
                {
                    win1 = 0;
                }
                if (cbdeathsuces2.Checked == true)
                {
                    win2 = 1;
                }
                else
                {
                    win2 = 0;
                }
                if (cbdeathsuces3.Checked == true)
                {
                    win3 = 1;
                }
                else
                {
                    win3 = 0;
                }
                if (cbdeathfail1.Checked == true)
                {
                    fail1 = 1;
                }
                else
                {
                    fail1 = 0;
                }
                if (cbdeathfail2.Checked == true)
                {
                    fail2 = 1;
                }
                else
                {
                    fail2 = 0;
                }
                if (cbdeathfail3.Checked == true)
                {
                    fail3 = 1;
                }
                else
                {
                    fail3 = 0;
                }



                if (cbStealth.Checked == true)
                {
                    stealt1 = 1;

                }
                else
                {
                    stealt1 = 0;
                }
                if (cbSurvival.Checked == true)
                {
                    survi1 = 1;

                }
                else
                {
                    survi1 = 0;
                }
                if (cbSleighOfHand.Checked == true)
                {
                    slei1 = 1;

                }
                else
                {
                    slei1 = 0;
                }
                if (cbReligion.Checked == true)
                {
                    relig1 = 1;

                }
                else
                {
                    relig1 = 0;
                }
                if (cbPersuation.Checked == true)
                {
                    persuas1 = 1;

                }
                else
                {
                    persuas1 = 0;
                }
                if (cbPerfomance.Checked == true)
                {
                    perfo1 = 1;

                }
                else
                {
                    perfo1 = 0;
                }
                if (cbPerception.Checked == true)
                {
                    perce1 = 1;

                }
                else
                {
                    perce1 = 0;
                }
                if (cbNature.Checked == true)
                {
                    natur1 = 1;

                }
                else
                {
                    natur1 = 0;
                }
                if (cbMedicine.Checked == true)
                {
                    medic1 = 1;

                }
                else
                {
                    medic1 = 0;
                }
                if (cbInvestig.Checked == true)
                {
                    investi1 = 1;

                }
                else
                {
                    investi1 = 0;
                }
                if (cbIntimid.Checked == true)
                {
                    intim1 = 1;

                }
                else
                {
                    intim1 = 0;
                }
                if (cbInsight.Checked == true)
                {
                    insih1 = 1;

                }
                else
                {
                    insih1 = 0;
                }
                if (cbDecept.Checked == true)
                {
                    decept1 = 1;

                }
                else
                {
                    decept1 = 0;
                }
                if (cbAnimal.Checked == true)
                {
                    animal1 = 1;

                }
                else
                {
                    animal1 = 0;
                }
                if (cbAcrob.Checked == true)
                {
                    acrob1 = 1;

                }
                else
                {
                    acrob1 = 0;
                }
                if (cbHist.Checked == true)
                {
                    hist1 = 1;

                }
                else
                {
                    hist1 = 0;
                }


                if (cbArcana.Checked == true)
                {
                    arc1 = 1;

                }
                else
                {
                    arc1 = 0;
                }
                if (cbAthle.Checked == true)
                {
                    athl1 = 1;

                }
                else
                {
                    athl1 = 0;
                }


                komanda.CommandText = "update Karakter  set XP='" + tbXP.Text + "',[level]='" + tbLevel.Text + "',ProficencyBonus='" + lbProfBonus.Text + "',armor='" + tbArmorClass.Text + "',initiative='" + tbInitiative.Text + "',Speed='" + tbSpeed.Text + "',CurrentHitPoints='" + tbCurrentHitPoints.Text + "',TemporaryHitPoints='" + tbTemporaryHitPoints.Text + "',cp='" + cp + "',sp='" + sp + "',ep='" + ep + "',gp='" + gp + "',pp='" + pp + "',strength='" + strengthV + "',dexterity='" + dexterityV + "',constitution='" + constitutionV + "',intelligence='" + intelligenceV + "',wisdom='" + wisdomV + "',charisma='" + charismaV + "',snagamax='" + strengthm + "',dexterityMax='" + dexteritym + "',constitutionMax='" + constitutionm + "',intelligenceMax='" + intelligencem + "',wisdomMax='" + wisdomm + "',CharismaMax='" + charismam + "',snagaProf='" + strengthp + "',dexterityProf='" + dexterityp + "',constitutionProf='" + constitutionp + "',intelligenceProf='" + intelligencep + "',wisdomProf='" + wisdomp + "',CharismaProf='" + charismap + "',acrobatics='" + acrobatics + "',animalHandling='" + animalh + "',arcana='" + arcana + "',athletics='" + athlet + "',deception='" + decep + "',history='" + hist + "',insight='" + insig + "',intimidation='" + intim + "',investigation='" + invest + "',medicine='" + medic + "',nature='" + nature + "',perception='" + percep + "',perfomance='" + perfom + "',persuasion='" + persua + "',religion='" + relig + "',sleighOfHand='" + sleighOfH + "',Stealth='" + stealth + "',survival='" + survival + "',[Hit Dice]='" + tbHitDice.Text + "',[PersonalityTraits]='" + tbPersonalityTraits.Text + "',Ideals='" + tbIdeals.Text + "',Bonds='" + tbBonds.Text + "',Flaws='" + tbFlaws.Text + "',PassiveWisdom='" + tbPassiveWisdom.Text + "',OtherProficencies='" + tbOtherProf.Text + "',Languages='" + tbLanguages.Text + "',attacksAndSpellcasting='" + tbAttakAndSpellCast.Text + "',FeaturesAndTraits='" + tbFeaturesAndTraits.Text + "',attandspellname1='" + tbatandSpelName1.Text + "',attandspellname2='" + tbatandSpelName2.Text + "',attandspellname3='" + tbatandSpelName3.Text + "',attandspellname4='" + tbatandSpelName4.Text + "',atkbonus1='" + tbAtkBonus1.Text + "',atkbonus2='" + tbAtkBonus2.Text + "',atkbonus3='" + tbAtkBonus3.Text + "',atkbonus4='" + tbAtkBonus4.Text + "',damagetype1='" + tbDamageType1.Text + "',damagetype2='" + tbDamageType2.Text + "',damagetype3='" + tbDamageType3.Text + "',damagetype4='" + tbDamageType4.Text + "',cbarcana=" + arc1 + ",cbathletics=" + athl1 + ",cbdeception=" + decept1 + ",cbhistory=" + hist1 + ",cbinsight=" + insih1 + ",cbintimidation=" + intim1 + ",cbinvestigation=" + investi1 + ",cbmedicine=" + medic1 + ",cbnature=" + natur1 + ",cbperception=" + perce1 + ",cbperfomance=" + perfo1 + ",cbpersuasion=" + persuas1 + ",cbreligion=" + relig1 + ",cbsleighofhand=" + slei1 + ",cbstealth=" + stealt1 + ",cbacrobatics=" + acrob1 + ",cbsurvival=" + survi1 + ",cbanimal=" + animal1 + ",cbdsfails1=" + fail1 + ",cbdsfails2=" + fail2 + ",cbdsfails3=" + fail3 + ",cbdswins1=" + win1 + ",cbdswins2=" + win2 + ",cbdswins3=" + win3 + " where idKaraktera=" + idKaraktera1 + ";";


                komanda.ExecuteNonQuery();



                OleDbCommand kom9 = new OleDbCommand();
                kom9.Connection = cone;
                kom9.CommandType = CommandType.Text;
                kom9.CommandText = "select idKaraktera from Igrac where imeIgraca='" + tbImeIgraca.Text + "' and prezimeIgraca='" + tbPrezimeIgraca.Text + "';";
                OleDbCommand kom10 = new OleDbCommand();
                kom10.Connection = cone;
                kom10.CommandType = CommandType.Text;


                OleDbDataReader dr9 = kom9.ExecuteReader();

                dr9.Read();
                int idKaraktera2;
                idKaraktera2 = Convert.ToInt32(dr9[0].ToString());
               

                cone.Close();
                cone.Dispose();
                MessageBox.Show("Podaci su Uspesno Azurirani");
                Pocetna p = new Pocetna();
                this.Hide();
                p.ShowDialog();
            }
            


        }

        private void CbIme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbSnaga1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public int prof = 2;
        private void TbSnaga_TextChanged(object sender, EventArgs e)
        {
            int a, b;
            if (tbSnaga.Text != "")
            {
                a = Convert.ToInt32(tbSnaga.Text);
                if (cbSnaga.Checked && cbKonstitucija.Checked)
                {

                    b = a + prof;
                    tbSnaga1.Text = Convert.ToString(b);
                }

                else if (cbSnaga.Checked && cbSpremnost.Checked)
                {
                    b = a + prof;
                    tbSnaga1.Text = Convert.ToString(b);
                }
                else if (cbSnaga.Checked && cbMudrost.Checked)
                {
                    b = a + prof;
                    tbSnaga1.Text = Convert.ToString(b);
                }
                else
                {
                    tbSnaga1.Text = Convert.ToString(a);
                }
                tbAthletics.Text = tbSnaga.Text;

                if (tbAthletics.Text != "")
                {
                    int k = Convert.ToInt32(tbSnaga.Text);
                    int g;
                    tbAthletics.Text = Convert.ToString(k);
                    if (cbAthle.Checked)
                    {

                        g = k + prof;
                        tbAthletics.Text = Convert.ToString(g);
                    }
                }
            }

        }

        private void TbSpremnost_TextChanged(object sender, EventArgs e)
        {
            int a, b;
            if (TbSpremnost.Text != "")
            {
                a = Convert.ToInt32(TbSpremnost.Text);
                if (cbSpremnost.Checked && cbInteligencija.Checked)
                {
                    b = a + prof;
                    tbSpremnost1.Text = Convert.ToString(b);
                }
                else if (cbSpremnost.Checked && cbHarizma.Checked)
                {
                    b = a + prof;
                    tbSpremnost1.Text = Convert.ToString(b);
                }
                else if (cbSpremnost.Checked && cbSnaga.Checked)
                {
                    b = a + prof;
                    tbSpremnost1.Text = Convert.ToString(b);
                }

                else
                {
                    tbSpremnost1.Text = Convert.ToString(a);
                }
                tbInitiative.Text = TbSpremnost.Text;
                tbAcrobatics.Text = TbSpremnost.Text;
                tbSleighOfHand.Text = TbSpremnost.Text;
                tbStealth.Text = TbSpremnost.Text;
                int z;
                z = a + 10;
                tbArmorClass.Text = Convert.ToString(z);
                if (tbAcrobatics.Text != "")
                {
                    int k = Convert.ToInt32(TbSpremnost.Text);
                    int g;
                    tbAcrobatics.Text = Convert.ToString(k);
                    if (cbAcrob.Checked)
                    {

                        g = k + prof;
                        tbAcrobatics.Text = Convert.ToString(g);
                    }
                }
                if (tbSleighOfHand.Text != "")
                {
                    int m = Convert.ToInt32(TbSpremnost.Text);
                    int n;
                    tbSleighOfHand.Text = Convert.ToString(m);
                    if (cbSleighOfHand.Checked)
                    {

                        n = m + prof;
                        tbSleighOfHand.Text = Convert.ToString(n);
                    }
                }
                if (tbStealth.Text != "")
                {
                    int i = Convert.ToInt32(TbSpremnost.Text);
                    int t;
                    tbStealth.Text = Convert.ToString(i);
                    if (cbStealth.Checked)
                    {

                        t = i + prof;
                        tbStealth.Text = Convert.ToString(t);
                    }
                }
            }

        }

        private void TbKonstitucija_TextChanged(object sender, EventArgs e)
        {
            int a, b;
            if (tbKonstitucija.Text != "")
            {
                a = Convert.ToInt32(tbKonstitucija.Text);
                if (cbSnaga.Checked && cbKonstitucija.Checked)
                {
                    b = a + prof;
                    tbKonstitucija1.Text = Convert.ToString(b);
                }
                else if (cbKonstitucija.Checked && cbHarizma.Checked)
                {
                    b = a + prof;
                    tbKonstitucija1.Text = Convert.ToString(b);
                }
                else if (cbKonstitucija.Checked && cbInteligencija.Checked)
                {
                    b = a + prof;
                    tbKonstitucija1.Text = Convert.ToString(b);
                }
                else
                {
                    tbKonstitucija1.Text = Convert.ToString(a);
                }
            }

        }

        private void TbMudrost_TextChanged(object sender, EventArgs e)
        {
            int a, b;
            if (tbMudrost.Text != "")
            {
                a = Convert.ToInt32(tbMudrost.Text);
                if (cbHarizma.Checked && cbMudrost.Checked)
                {
                    b = a + prof;
                    tbMudrost1.Text = Convert.ToString(b);
                }
                else if (cbInteligencija.Checked && cbMudrost.Checked)
                {
                    b = a + prof;
                    tbMudrost1.Text = Convert.ToString(b);
                }
                else if (cbSnaga.Checked && cbMudrost.Checked)
                {
                    b = a + prof;
                    tbMudrost1.Text = Convert.ToString(b);
                }
                else
                {
                    tbMudrost1.Text = Convert.ToString(a);
                }
                TbAnimalHandling.Text = tbMudrost.Text;
                tbInsight.Text = tbMudrost.Text;
                tbMedicine.Text = tbMudrost.Text;
                tbPerception.Text = tbMudrost.Text;
                tbSurvival.Text = tbMudrost.Text;
                if (TbAnimalHandling.Text != "")
                {
                    int k = Convert.ToInt32(tbMudrost.Text);
                    int g;
                    TbAnimalHandling.Text = Convert.ToString(k);
                    if (cbAnimal.Checked)
                    {

                        g = k + prof;
                        TbAnimalHandling.Text = Convert.ToString(g);
                    }
                }
                if (tbInsight.Text != "")
                {
                    int l = Convert.ToInt32(tbMudrost.Text);
                    int z;

                    tbInsight.Text = Convert.ToString(l);

                    if (cbInsight.Checked)
                    {

                        z = l + prof;
                        tbInsight.Text = Convert.ToString(z);
                    }
                }
                if (tbMedicine.Text != "")
                {
                    int h = Convert.ToInt32(tbMudrost.Text);
                    int t;
                    tbMedicine.Text = Convert.ToString(h);
                    if (cbMedicine.Checked)
                    {

                        t = h + prof;
                        tbMedicine.Text = Convert.ToString(t);
                    }
                }
                if (tbPerception.Text != "")
                {
                    int n = Convert.ToInt32(tbMudrost.Text);
                    int m;
                    tbPerception.Text = Convert.ToString(n);
                    if (cbPerception.Checked)
                    {

                        m = n + prof;
                        tbPerception.Text = Convert.ToString(m);
                    }
                }
                if (tbSurvival.Text != "")
                {
                    int q = Convert.ToInt32(tbMudrost.Text);
                    int w;
                    tbSurvival.Text = Convert.ToString(q);
                    if (cbSurvival.Checked)
                    {

                        w = q + prof;
                        tbSurvival.Text = Convert.ToString(w);
                    }
                }
            }
            
        }

        private void TbHarizma_TextChanged(object sender, EventArgs e)
        {
            int a, b;
            if (tbHarizma.Text != "")
            {
                a = Convert.ToInt32(tbHarizma.Text);
                if (cbHarizma.Checked && cbMudrost.Checked)
                {
                    b = a + prof;
                    tbHarizma1.Text = Convert.ToString(b);
                }
                else if (cbHarizma.Checked && cbKonstitucija.Checked)
                {
                    b = a + prof;
                    tbHarizma1.Text = Convert.ToString(b);
                }
                else if (cbHarizma.Checked && cbSpremnost.Checked)
                {
                    b = a + prof;
                    tbHarizma1.Text = Convert.ToString(b);
                }
                else
                {
                    tbHarizma1.Text = Convert.ToString(a);
                }
                tbDeception.Text = tbHarizma.Text;
                tbIntimidation.Text = tbHarizma.Text;
                tbPerfomance.Text = tbHarizma.Text;
                tbPersuation.Text = tbHarizma.Text;
                if (tbDeception.Text != "")
                {
                    int l = Convert.ToInt32(tbHarizma.Text);
                    int g;
                    tbDeception.Text = Convert.ToString(l);
                    if (cbDecept.Checked)
                    {

                        g = l + prof;
                        tbDeception.Text = Convert.ToString(g);
                    }
                }
                if (tbIntimidation.Text != "")
                {
                    int y = Convert.ToInt32(tbHarizma.Text);
                    int u;
                    tbIntimidation.Text = Convert.ToString(y);
                    if (cbIntimid.Checked)
                    {

                        u = y + prof;
                        tbIntimidation.Text = Convert.ToString(u);
                    }
                }
                if (tbPerfomance.Text != "")
                {
                    int m = Convert.ToInt32(tbHarizma.Text);
                    int n;
                    tbPerfomance.Text = Convert.ToString(m);
                    if (cbPerfomance.Checked)
                    {

                        n = m + prof;
                        tbPerfomance.Text = Convert.ToString(n);
                    }
                }
                if (tbPersuation.Text != "")
                {
                    int f = Convert.ToInt32(tbHarizma.Text);
                    int d;
                    tbPersuation.Text = Convert.ToString(f);
                    if (cbPersuation.Checked)
                    {

                        d = f + prof;
                        tbPersuation.Text = Convert.ToString(d);
                    }
                }
            }
        }

        private void TbSpremnostm_TextChanged(object sender, EventArgs e)
        {
            int z, k;
            if (tbSpremnostm.Text != "")
            {
                z = Convert.ToInt32(tbSpremnostm.Text);
                k = (z - 10) / 2;
                TbSpremnost.Text = Convert.ToString(k);
            }
            if (tbSnagam.Text != "" && tbKonstitucijam.Text != "" && tbSpremnostm.Text != "" && tbHarizmam.Text != "" && tbMudrostm.Text != "" && tbInteligencijam.Text != "")
             {

                 PozadinaTrue();
                // tbXP.Enabled = false;

             }
             else
             {
                 //tbXP.Enabled = true;

             }
        }

        private void TbInteligencija_TextChanged(object sender, EventArgs e)
        {
            int a, b;
            if (tbInteligencija.Text != "")
            {
                a = Convert.ToInt32(tbInteligencija.Text);
                if (cbSpremnost.Checked && cbInteligencija.Checked)
                {
                    b = a + prof;
                    tbInteligencija1.Text = Convert.ToString(b);
                }
                else if (cbMudrost.Checked && cbInteligencija.Checked)
                {
                    b = a + prof;
                    tbInteligencija1.Text = Convert.ToString(b);
                }
                else if (cbKonstitucija.Checked && cbInteligencija.Checked)
                {
                    b = a + prof;
                    tbInteligencija1.Text = Convert.ToString(b);
                }

                else
                {
                    tbInteligencija1.Text = Convert.ToString(a);
                }
                tbArcana.Text = tbInteligencija.Text;
                tbHistory.Text = tbInteligencija.Text;
                tbInvestigation.Text = tbInteligencija.Text;
                tbNature.Text = tbInteligencija.Text;
                tbReligion.Text = tbInteligencija.Text;
                if (tbArcana.Text != "")
                {
                    int k = Convert.ToInt32(tbInteligencija.Text);
                    int g;

                    tbArcana.Text = Convert.ToString(k);
                    if (cbArcana.Checked)
                    {

                        g = k + prof;
                        tbArcana.Text = Convert.ToString(g);
                    }
                }
                if (tbHistory.Text != "")
                {
                    int l = Convert.ToInt32(tbInteligencija.Text);
                    int h;
                    tbHistory.Text = Convert.ToString(l);
                    if (cbHist.Checked)
                    {

                        h = l + prof;
                        tbHistory.Text = Convert.ToString(h);
                    }
                }
                if (tbInvestigation.Text != "")
                {
                    int u = Convert.ToInt32(tbInteligencija.Text);
                    int y;
                    tbInvestigation.Text = Convert.ToString(u);
                    if (cbInvestig.Checked)
                    {

                        y = u + prof;
                        tbInvestigation.Text = Convert.ToString(y);
                    }
                }
                if (tbNature.Text != "")
                {
                    int o = Convert.ToInt32(tbInteligencija.Text);
                    int p;
                    tbNature.Text = Convert.ToString(o);
                    if (cbNature.Checked)
                    {

                        p = o + prof;
                        tbNature.Text = Convert.ToString(p);
                    }
                }
                if (tbReligion.Text != "")
                {
                    int q = Convert.ToInt32(tbInteligencija.Text);
                    int w;
                    tbReligion.Text = Convert.ToString(q);
                    if (cbReligion.Checked)
                    {

                        w = q + prof;
                        tbReligion.Text = Convert.ToString(w);
                    }
                }
            }
            
        }

        private void Label14_Click(object sender, EventArgs e)
        {        }

        private void LbProfBonus_Click(object sender, EventArgs e)
        {
           
        }

        private void TbLevel_TextChanged(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(tbLevel.Text) == 1) || (Convert.ToInt32(tbLevel.Text)==2) || (Convert.ToInt32(tbLevel.Text)==3) || (Convert.ToInt32(tbLevel.Text) == 4))
            {
                prof = 2;
                
            }
            else if ((Convert.ToInt32(tbLevel.Text) == 5) || (Convert.ToInt32(tbLevel.Text) == 6) || (Convert.ToInt32(tbLevel.Text) == 7) || (Convert.ToInt32(tbLevel.Text) == 8))
            {
                prof = 3;
            }
            else if ((Convert.ToInt32(tbLevel.Text) == 9) || (Convert.ToInt32(tbLevel.Text) == 10) || (Convert.ToInt32(tbLevel.Text) == 11) || (Convert.ToInt32(tbLevel.Text) == 12))
            {
                prof =4;
            }
            else if ((Convert.ToInt32(tbLevel.Text) == 13) || (Convert.ToInt32(tbLevel.Text) == 14) || (Convert.ToInt32(tbLevel.Text) == 15) || (Convert.ToInt32(tbLevel.Text) == 16))
            {
                prof =5;
            }
            else if ((Convert.ToInt32(tbLevel.Text) == 17) || (Convert.ToInt32(tbLevel.Text) == 18) || (Convert.ToInt32(tbLevel.Text) == 19) || (Convert.ToInt32(tbLevel.Text) == 20))
            {
                prof = 6;
            }
            lbProfBonus.Text= " " + Convert.ToString(prof);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnResetOsnovne_Click(object sender, EventArgs e)
        {
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label35_Click(object sender, EventArgs e)
        {

        }

        private void TbInitiative_TextChanged(object sender, EventArgs e)
        {
            tbInitiative.Text = TbSpremnost.Text;
        }

        private void TbAcrobatics_TextChanged(object sender, EventArgs e)
        {


            
        }

        private void CbAcrob_CheckedChanged(object sender, EventArgs e)
        {
            if (TbSpremnost.Text != "")
            {
                int a = Convert.ToInt32(TbSpremnost.Text);
                int g;
                tbAcrobatics.Text = Convert.ToString(a);
                if (cbAcrob.Checked)
                {

                    g = a + prof;
                    tbAcrobatics.Text = Convert.ToString(g);
                }
            }
        }

        private void CbSleighOfHand_CheckedChanged(object sender, EventArgs e)
        {
            if (TbSpremnost.Text != "")
            {
                int a = Convert.ToInt32(TbSpremnost.Text);
                int g;
                tbSleighOfHand.Text = Convert.ToString(a);
                if (cbSleighOfHand.Checked)
                {

                    g = a + prof;
                    tbSleighOfHand.Text = Convert.ToString(g);
                }
            }
        }
        private void CbStealth_CheckedChanged(object sender, EventArgs e)
        {
            if (TbSpremnost.Text != "")
            {
                int a = Convert.ToInt32(TbSpremnost.Text);
                int g;
                tbStealth.Text = Convert.ToString(a);
                if (cbStealth.Checked)
                {

                    g = a + prof;
                    tbStealth.Text = Convert.ToString(g);
                }
            }
        }

        private void CbAthle_CheckedChanged(object sender, EventArgs e)
        {
            if (tbSnaga.Text != "")
            {
                int a = Convert.ToInt32(tbSnaga.Text);
                int g;
                tbAthletics.Text = Convert.ToString(a);
                if (cbAthle.Checked)
                {

                    g = a + prof;
                    tbAthletics.Text = Convert.ToString(g);
                }
            }
        }

        private void CbArcana_CheckedChanged(object sender, EventArgs e)
        {
            if (tbInteligencija.Text != "")
            {
                int a = Convert.ToInt32(tbInteligencija.Text);
                int g;

                tbArcana.Text = Convert.ToString(a);
                if (cbArcana.Checked)
                {

                    g = a + prof;
                    tbArcana.Text = Convert.ToString(g);
                }
            }

        }

        private void CbHist_CheckedChanged(object sender, EventArgs e)
        {
            if (tbInteligencija.Text != "")
            {
                int a = Convert.ToInt32(tbInteligencija.Text);
                int g;
                tbHistory.Text = Convert.ToString(a);
                if (cbHist.Checked)
                {

                    g = a + prof;
                    tbHistory.Text = Convert.ToString(g);
                }
            }
        }

        private void CbInvestig_CheckedChanged(object sender, EventArgs e)
        {
            if (tbInteligencija.Text != "")
            {
                int a = Convert.ToInt32(tbInteligencija.Text);
                int g;
                tbInvestigation.Text = Convert.ToString(a);
                if (cbInvestig.Checked)
                {

                    g = a + prof;
                    tbInvestigation.Text = Convert.ToString(g);
                }
            }
        }
        private void CbNature_CheckedChanged(object sender, EventArgs e)
        {
            if (tbInteligencija.Text != "")
            {
                int a = Convert.ToInt32(tbInteligencija.Text);
                int g;
                tbNature.Text = Convert.ToString(a);
                if (cbNature.Checked)
                {

                    g = a + prof;
                    tbNature.Text = Convert.ToString(g);
                }
            }
        }

        private void CbReligion_CheckedChanged(object sender, EventArgs e)
        {
            if (tbInteligencija.Text != "")
            {
                int a = Convert.ToInt32(tbInteligencija.Text);
                int g;
                tbReligion.Text = Convert.ToString(a);
                if (cbReligion.Checked)
                {

                    g = a + prof;
                    tbReligion.Text = Convert.ToString(g);
                }

            }
        }

        private void CbAnimal_CheckedChanged(object sender, EventArgs e)
        {
            if (tbMudrost.Text != "")
            {
                int a = Convert.ToInt32(tbMudrost.Text);
                int g;
                TbAnimalHandling.Text = Convert.ToString(a);
                if (cbAnimal.Checked)
                {

                    g = a + prof;
                    TbAnimalHandling.Text = Convert.ToString(g);
                }
            }
        }
        private void CbInsight_CheckedChanged(object sender, EventArgs e)
        {
            if (tbMudrost.Text != "")
            {
                int a = Convert.ToInt32(tbMudrost.Text);
                int g;
                tbInsight.Text = Convert.ToString(a);

                if (cbInsight.Checked)
                {

                    g = a + prof;
                    tbInsight.Text = Convert.ToString(g);
                }


            }
        }

        private void CbMedicine_CheckedChanged(object sender, EventArgs e)
        {
            if (tbMudrost.Text != "")
            {
                int a = Convert.ToInt32(tbMudrost.Text);
                int g;
                tbMedicine.Text = Convert.ToString(a);
                if (cbMedicine.Checked)
                {

                    g = a + prof;
                    tbMedicine.Text = Convert.ToString(g);
                }
            }
        }

        private void CbPerception_CheckedChanged(object sender, EventArgs e)
        {
            if (tbMudrost.Text != "")
            {
                int a = Convert.ToInt32(tbMudrost.Text);
                int g;
                tbPerception.Text = Convert.ToString(a);
                if (cbPerception.Checked)
                {

                    g = a + prof;
                    tbPerception.Text = Convert.ToString(g);
                }
            }
        }

        private void CbSurvival_CheckedChanged(object sender, EventArgs e)
        {
            if (tbMudrost.Text != "")
            {
                int a = Convert.ToInt32(tbMudrost.Text);
                int g;
                tbSurvival.Text = Convert.ToString(a);
                if (cbSurvival.Checked)
                {

                    g = a + prof;
                    tbSurvival.Text = Convert.ToString(g);
                }
            }
        }
        private void CbDecept_CheckedChanged(object sender, EventArgs e)
        {
            if (tbHarizma.Text != "")
            {

                int a = Convert.ToInt32(tbHarizma.Text);
                int g;
                tbDeception.Text = Convert.ToString(a);
                if (cbDecept.Checked)
                {

                    g = a + prof;
                    tbDeception.Text = Convert.ToString(g);
                }
            }
        }

        private void CbIntimid_CheckedChanged(object sender, EventArgs e)
        {
            if (tbHarizma.Text != "")
            {
                int a = Convert.ToInt32(tbHarizma.Text);
                int g;
                tbIntimidation.Text = Convert.ToString(a);
                if (cbIntimid.Checked)
                {

                    g = a + prof;
                    tbIntimidation.Text = Convert.ToString(g);
                }
            }
        }

        private void CbPerfomance_CheckedChanged(object sender, EventArgs e)
        {
            if (tbHarizma.Text != "")
            {
                int a = Convert.ToInt32(tbHarizma.Text);
                int g;
                tbPerfomance.Text = Convert.ToString(a);
                if (cbPerfomance.Checked)
                {

                    g = a + prof;
                    tbPerfomance.Text = Convert.ToString(g);
                }
            }
        }

        private void CbPersuation_CheckedChanged(object sender, EventArgs e)
        {
            if (tbHarizma.Text != "")
            {
                int a = Convert.ToInt32(tbHarizma.Text);
                int g;
                tbPersuation.Text = Convert.ToString(a);
                if (cbPersuation.Checked)
                {

                    g = a + prof;
                    tbPersuation.Text = Convert.ToString(g);
                }
            }
        }
        private void TbSnagam_TextChanged(object sender, EventArgs e)
        {
            int z, k;
            if (tbSnagam.Text != "")
            {
                z = Convert.ToInt32(tbSnagam.Text);
                k = (z - 10) / 2;
                
                tbSnaga.Text = Convert.ToString(k);
               

            }
            if (tbSnagam.Text != "" && tbKonstitucijam.Text != "" && tbSpremnostm.Text != "" && tbHarizmam.Text != "" && tbMudrostm.Text != "" && tbInteligencijam.Text != "")
             {

                 PozadinaTrue();
                // tbXP.Enabled = false;

             }
             else
             {
                 //tbXP.Enabled = true;

             }
        }

        private void TbKonstitucijam_TextChanged(object sender, EventArgs e)
        {
            int z, k;
            if (tbKonstitucijam.Text != "")
            {
                z = Convert.ToInt32(tbKonstitucijam.Text);
                k = (z - 10) / 2;
                tbKonstitucija.Text = Convert.ToString(k);
            }
            if (tbSnagam.Text != "" && tbKonstitucijam.Text != "" && tbSpremnostm.Text != "" && tbHarizmam.Text != "" && tbMudrostm.Text != "" && tbInteligencijam.Text != "")
            {

                PozadinaTrue();
               // tbXP.Enabled = false;

            }
            else
            {
               // tbXP.Enabled = true;

            }
        }

        private void TbInteligencijam_TextChanged(object sender, EventArgs e)
        {
            int z, k;
            if (tbInteligencijam.Text != "")
            {
                z = Convert.ToInt32(tbInteligencijam.Text);
                k = (z - 10) / 2;
                tbInteligencija.Text = Convert.ToString(k);
            }
            if (tbSnagam.Text != "" && tbKonstitucijam.Text != "" && tbSpremnostm.Text != "" && tbHarizmam.Text != "" && tbMudrostm.Text != "" && tbInteligencijam.Text != "")
            {

                PozadinaTrue();
                //tbXP.Enabled = false;

            }
            else
            {
               // tbXP.Enabled = true;

            }
        }

        private void TbMudrostm_TextChanged(object sender, EventArgs e)
        {
            int z, k;
            if (tbMudrostm.Text != "")
            {
                z = Convert.ToInt32(tbMudrostm.Text);
                k = (z - 10) / 2;
                tbMudrost.Text = Convert.ToString(k);
            }
            if (tbSnagam.Text != "" && tbKonstitucijam.Text != "" && tbSpremnostm.Text != "" && tbHarizmam.Text != "" && tbMudrostm.Text != "" && tbInteligencijam.Text != "")
            {

                PozadinaTrue();
               // tbXP.Enabled = false;

            }
            else
            {
                //tbXP.Enabled = true;

            }
        }

        private void TbHarizmam_TextChanged(object sender, EventArgs e)
        {
            int z, k;
            if (tbHarizmam.Text != "")
            {
                z = Convert.ToInt32(tbHarizmam.Text);
                k = (z - 10) / 2;
                tbHarizma.Text = Convert.ToString(k);
            }
            if (tbSnagam.Text != "" && tbKonstitucijam.Text != "" && tbSpremnostm.Text != "" && tbHarizmam.Text != "" && tbMudrostm.Text != "" && tbInteligencijam.Text != "")
             {

                 PozadinaTrue();
                // tbXP.Enabled = false;

             }
             else
             {
                // tbXP.Enabled = true;

             }
        }

        private void TbArmorClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbOdredjenost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TbPerception_TextChanged(object sender, EventArgs e)
        {
            int z, k;
            if (tbPerception.Text !="") {
                z = Convert.ToInt32(tbPerception.Text);
                k = 10 + z;
                tbPassiveWisdom.Text = Convert.ToString(k);
            }
        }

        private void CbPozadina_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void CbOprema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RbArmor_CheckedChanged(object sender, EventArgs e)
        {
            cone.Open();
            cbOprema.Items.Clear();
            cbOprema.Items.Add("");
            if (rbArmor.Checked)
            {
                cbOprema.Enabled = true;
                OleDbCommand cmd1;
                cmd1 = cone.CreateCommand();
                cmd1.CommandType = CommandType.Text;
               
                cmd1.CommandText = "Select ImeOpreme from Oprema where idOpreme<=18;";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);


                foreach (DataRow dr1 in dt1.Rows)
                {
                    cbOprema.Items.Add(dr1["ImeOpreme"].ToString());
                }
            }
            cone.Close();
        }

        private void RbOruzje_CheckedChanged(object sender, EventArgs e)
        {
            cone.Open();
            cbOprema.Items.Clear();
            cbOprema.Items.Add("");
            if (rbOruzje.Checked)
            {
                cbOprema.Enabled = true;
                OleDbCommand cmd1;
                cmd1 = cone.CreateCommand();
                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "Select ImeOpreme from Oprema where idOpreme>18 and idOpreme<=55;";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);


                foreach (DataRow dr1 in dt1.Rows)
                {
                    cbOprema.Items.Add(dr1["ImeOpreme"].ToString());

                }

            }


            cone.Close();
        }

        private void RbAlati_CheckedChanged(object sender, EventArgs e)
        {
            cone.Open();
            cbOprema.Items.Clear();
            cbOprema.Items.Add("");
            if (rbAlati.Checked)
            {
                cbOprema.Enabled = true;
                OleDbCommand cmd1;
                cmd1 = cone.CreateCommand();
                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "Select [ImeOpreme] from [Oprema] where [idOpreme]>55 and [idOpreme]<=94;";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);

                foreach (DataRow dr1 in dt1.Rows)
                {
                    cbOprema.Items.Add(dr1["ImeOpreme"].ToString());

                }

            }


            cone.Close();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            btnKliknuo = true;
            if (rbAlati.Checked == false && rbOruzje.Checked == false && rbArmor.Checked == false )
            {
                MessageBox.Show("Selektujte tip opreme koji zelite da dodate");
            }
            else if((rbAlati.Checked==true || rbOruzje.Checked==true || rbArmor.Checked==true) && cbOprema.SelectedItem==null)
            {
                MessageBox.Show("Selektujte opremu");
            }
            else if (cbOprema.SelectedIndex == 0)
            {
                MessageBox.Show("Selektujte opremu");
            }
            else
            {
                cone.Open();
                OleDbCommand c1,c2,c3,c4;
                OleDbDataReader d2, d3,d4;
                c4 = cone.CreateCommand();
                c4.CommandType = CommandType.Text;
                c4.CommandText= "select idIgraca from Igrac where imeIgraca='" + tbImeIgraca.Text + "' and prezimeIgraca='" + tbPrezimeIgraca.Text + "';";
                d4 = c4.ExecuteReader();
                d4.Read();
                int idIgr;
                idIgr = Convert.ToInt32(d4[0].ToString());
                c1 = cone.CreateCommand();
                c1.CommandType = CommandType.Text;
                c2 = cone.CreateCommand();
                c2.CommandType = CommandType.Text;
                c3 = cone.CreateCommand();
                c3.CommandType = CommandType.Text;
                c2.CommandText = "select idKaraktera from Igrac where idIgraca="+idIgr+";";
                d2 = c2.ExecuteReader();
                d2.Read();
                int idKar, idOpr;
                idKar = Convert.ToInt32(d2[0].ToString());
                
                lbOprema.Items.Add(cbOprema.SelectedItem);
                string a = cbOprema.SelectedItem.ToString();
                c3.CommandText = "select idOpreme from  Oprema where imeOpreme='"+a+"';";
                d3 = c3.ExecuteReader();
                d3.Read();
                idOpr = Convert.ToInt32(d3[0].ToString());
                c1.CommandText = "insert into ImaOpremu(idKaraktera,idOpreme) values('" + idKar + "','" + idOpr + "');";
                c1.ExecuteNonQuery();
                cone.Close();
            }
        }
        void ResetTb()
        {
            tbSnaga.Text = "";
            tbMudrost.Text = "";
            tbHarizma.Text = "";
            TbSpremnost.Text = "";
            tbInteligencija.Text = "";
            tbKonstitucija.Text = "";
            tbSnagam.Text = "";
            tbMudrostm.Text = "";
            tbHarizmam.Text = "";
            tbSpremnostm.Text = "";
            tbInteligencijam.Text = "";
            tbKonstitucijam.Text = "";
            tbSnaga1.Text = "";
            tbMudrost1.Text = "";
            tbHarizma1.Text = "";
            tbSpremnost1.Text = "";
            tbInteligencija1.Text = "";
            tbKonstitucija1.Text = "";
            tbArmorClass.Text = "";
            tbInitiative.Text = "";

            tbAcrobatics.Text = "";
            TbAnimalHandling.Text = "";
            tbArcana.Text = "";
            tbAthletics.Text = "";
            tbDeception.Text = "";
            tbHistory.Text = "";
            tbInsight.Text = "";
            tbIntimidation.Text = "";
            tbInvestigation.Text = "";
            tbMedicine.Text = "";
            tbNature.Text = "";
            tbPerception.Text = "";
            tbPerfomance.Text = "";
            tbPersuation.Text = "";
            tbReligion.Text = "";
            tbSleighOfHand.Text = "";
            tbStealth.Text = "";
            tbSurvival.Text = "";
            tbPassiveWisdom.Text = "";
             cbAcrob.Checked = false;
             cbAnimal.Checked = false;
             cbArcana.Checked = false;
             cbAthle.Checked = false;
             cbDecept.Checked = false;
             cbHist.Checked = false;
             cbInsight.Checked = false;
             cbIntimid.Checked = false;
             cbInvestig.Checked = false;
             cbMedicine.Checked = false;
             cbNature.Checked = false;
             cbPerception.Checked = false;
             cbPerfomance.Checked = false;
             cbPersuation.Checked = false;
             cbReligion.Checked = false;
             cbSleighOfHand.Checked = false;
             cbStealth.Checked = false;
             cbSurvival.Checked = false;
             



        }
        private void TbXP_TextChanged(object sender, EventArgs e)
        {
            int z;
            z = 0;
            ResetTb();
           

            if (tbXP.Text != "")
            {
                z = Convert.ToInt32(tbXP.Text);

                if (z <= 300)
                {
                    tbLevel.Text = "1";
                }
                else if (z > 300 && z <= 900)
                {
                    tbLevel.Text = "2";
                }
                else if (z > 900 && z <= 2700)
                {
                    tbLevel.Text = "3";
                }
                else if (z > 2700 && z <= 6500)
                {
                    tbLevel.Text = "4";
                }
                else if (z > 6500 && z <= 14000)
                {
                    tbLevel.Text = "5";
                }
                else if (z > 14000 && z <= 23000)
                {
                    tbLevel.Text = "6";
                }
                else if (z > 23000 && z <= 34000)
                {
                    tbLevel.Text = "7";
                }
                else if (z > 34000 && z <= 48000)
                {
                    tbLevel.Text = "8";
                }
                else if (z > 48000 && z <= 64000)
                {
                    tbLevel.Text = "9";
                }
                else if (z > 64000 && z <= 85000)
                {
                    tbLevel.Text = "10";
                }
                else if (z > 85000 && z <= 100000)
                {
                    tbLevel.Text = "11";
                }
                else if (z > 100000 && z <= 120000)
                {
                    tbLevel.Text = "12";
                }
                else if (z > 120000 && z <= 140000)
                {
                    tbLevel.Text = "13";
                }
                else if (z > 140000 && z <= 165000)
                {
                    tbLevel.Text = "14";
                }
                else if (z > 165000 && z <= 195000)
                {
                    tbLevel.Text = "15";
                }
                else if (z > 195000 && z <= 225000)
                {
                    tbLevel.Text = "16";
                }
                else if (z > 225000 && z <= 265000)
                {
                    tbLevel.Text = "17";
                }
                else if (z > 265000 && z <= 305000)
                {
                    tbLevel.Text = "18";
                }
                else if (z > 305000 && z <= 355000)
                {
                    tbLevel.Text = "19";
                }
                else
                {
                    tbLevel.Text = "20";
                }
            
            tbSnagam.Enabled = true;
            tbHarizmam.Enabled = true;
            tbKonstitucijam.Enabled = true;
            tbMudrostm.Enabled = true;
            tbSpremnostm.Enabled = true;
            tbInteligencijam.Enabled = true;

        }
            else
            {
                tbSnagam.Enabled = false;
                tbHarizmam.Enabled = false;
                tbKonstitucijam.Enabled = false;
                tbMudrostm.Enabled = false;
                tbSpremnostm.Enabled = false;
                tbInteligencijam.Enabled = false;
            }


}

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?\nSve nesacuvano ce biti izgubljeno", "Exit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Pocetna p = new Pocetna();
                p.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Da li zelite da Izadjete?", "Exit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cone.Close();
                this.Close();
                Application.Exit();
                
                
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void LbOprema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbCurrentHitPoints_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            cone.Open();
            int sel = lbOprema.SelectedIndex;
            int idKar, idOpreme;

            OleDbCommand k3 = new OleDbCommand();
            OleDbCommand k2 = new OleDbCommand();
            OleDbCommand k1 = new OleDbCommand();

            OleDbDataReader dr6, dr1;
            if (lbOprema.SelectedItem == null)
            {
                MessageBox.Show("Selektujte Item prvo!");
            }
            else
            {
                k2 = cone.CreateCommand();
                k2.CommandType = CommandType.Text;
                k1 = cone.CreateCommand();
                k1.CommandType = CommandType.Text;
                k1.CommandText = "select idOpreme from Oprema where imeOpreme='" + lbOprema.SelectedItem + "';";

                dr1 = k1.ExecuteReader();
                dr1.Read();
                idOpreme = Convert.ToInt32(dr1[0].ToString());

                k3 = cone.CreateCommand();
                k3.CommandType = CommandType.Text;
                k2.CommandText = "select idKaraktera from Igrac where imeIgraca='"+tbImeIgraca.Text+"' and prezimeIgraca='"+tbPrezimeIgraca.Text+"';";
                dr6 = k2.ExecuteReader();
                dr6.Read();
                idKar = Convert.ToInt32(dr6[0].ToString());
                OleDbCommand k4, k5;
                OleDbDataReader k04, k05;
                k4 = cone.CreateCommand();
                k4.CommandType = CommandType.Text;
                k5 = cone.CreateCommand();
                k5.CommandType = CommandType.Text;
                k4.CommandText = "select idImaOpremu from imaOpremu  where idKaraktera=" + idKar + " and idOpreme=" + idOpreme + " order by idImaOpremu desc;";


                k04 = k4.ExecuteReader();
                k04.Read();
                int idima1, idima2;
                idima1 = Convert.ToInt32(k04[0].ToString());
                k5.CommandText = "select idImaOpremu from imaOpremu where idKaraktera=" + idKar + " and idOpreme=" + idOpreme + " order by idImaOpremu asc;";
                k05 = k5.ExecuteReader();
                k05.Read();
                idima2 = Convert.ToInt32(k05[0].ToString());
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?", "Izbrisati?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (idima1 > idima2)
                    {
                        k3.CommandText = "delete from ImaOpremu where idKaraktera=" + idKar + " and idOpreme=" + idOpreme + " and idImaOpremu=" + idima2 + ";";
                        k3.ExecuteNonQuery();
                        lbOprema.Items.RemoveAt(sel);
                    }
                    else
                    {
                        k3.CommandText = "delete from ImaOpremu where idKaraktera=" + idKar + " and idOpreme=" + idOpreme + " and idImaOpremu=" + idima1 + ";";
                        k3.ExecuteNonQuery();
                        lbOprema.Items.RemoveAt(sel);
                    }

                }
                else if (dialogResult == DialogResult.No) { }
            }
            cone.Close();
        }
       
        private void BtnPrint_Click(object sender, EventArgs e)
        {
           

            Document doc = new Document(iTextSharp.text.PageSize.A4);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(tbImeIgraca.Text+" "+tbPrezimeIgraca.Text+".pdf",FileMode.Create));
            doc.Open();
             iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance("Printovanje.jpg");
            png.ScalePercent(100);
            png.SetAbsolutePosition(0, 0);
            doc.Add(png);
            PdfContentByte cb = wri.DirectContent;
            

            cb.BeginText();
            
            cb.SetTextMatrix(6, 763);
            BaseFont bf = BaseFont.CreateFont("POORICH.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            
            cb.SetFontAndSize(bf,9);          
            cb.ShowText(cbIme.Text);      
            cb.SetTextMatrix(80, 763);
            cb.ShowText(cbPrezime.Text);
            cb.SetFontAndSize(bf, 10);
            cb.SetTextMatrix(208, 810);
            cb.ShowText(cbRasa.Text);
            cb.SetTextMatrix(283, 810);
            cb.ShowText(cbPol.Text);
            cb.SetTextMatrix(350, 810);
            cb.ShowText(cbKlasa.Text);
            cb.SetTextMatrix(404, 808);
            cb.ShowText(cbOdredjenost.Text);
            cb.SetTextMatrix(484, 810);
            cb.ShowText(cbPozadina.Text);
            cb.SetTextMatrix(212, 755);
            cb.ShowText(tbImeIgraca.Text);
            cb.SetTextMatrix(283, 755);
            cb.ShowText(tbPrezimeIgraca.Text);
            cb.SetTextMatrix(350, 755);
            cb.ShowText(tbXP.Text);
            cb.SetTextMatrix(420, 755);
            cb.SetFontAndSize(bf, 10);
            cb.ShowText(tbLevel.Text);
            cb.SetTextMatrix(83, 716);
            cb.ShowText(lbProfBonus.Text);

            //VELIKE SNAGE ITD
            cb.SetFontAndSize(bf, 16);
            cb.SetTextMatrix(30, 686);
            cb.ShowText(tbSnaga.Text);
            cb.SetTextMatrix(30, 625);
            cb.ShowText(TbSpremnost.Text);
            cb.SetTextMatrix(30, 565);
            cb.ShowText(tbKonstitucija.Text);
            cb.SetTextMatrix(30, 505);
            cb.ShowText(tbInteligencija.Text);
            cb.SetTextMatrix(30, 445);
            cb.ShowText(tbMudrost.Text);
            cb.SetTextMatrix(30, 383);
            cb.ShowText(tbHarizma.Text);
            //ARMOR ITD
            
            cb.SetTextMatrix(226, 682);
            cb.ShowText(tbArmorClass.Text);
            cb.SetTextMatrix(270, 682);
            cb.ShowText(tbInitiative.Text);
            cb.SetTextMatrix(320, 682);
            cb.ShowText(tbSpeed.Text);
            //hit points
            cb.SetTextMatrix(230, 594);
            cb.ShowText(tbCurrentHitPoints.Text);
            cb.SetTextMatrix(230, 545);
            cb.ShowText(tbTemporaryHitPoints.Text);

            //MALE SNAGE ITD
            cb.SetFontAndSize(bf, 8);
            cb.SetTextMatrix(30, 671);
            cb.ShowText(tbSnagam.Text);
            cb.SetTextMatrix(30, 610);
            cb.ShowText(tbSpremnostm.Text);
            cb.SetTextMatrix(30, 550);
            cb.ShowText(tbKonstitucijam.Text);
            cb.SetTextMatrix(30, 490);
            cb.ShowText(tbInteligencijam.Text);
            cb.SetTextMatrix(30, 428);
            cb.ShowText(tbMudrostm.Text);
            cb.SetTextMatrix(30, 366);
            cb.ShowText(tbHarizmam.Text);
            //prof snage itd
            cb.SetFontAndSize(bf, 12);
            cb.SetTextMatrix(96, 658);
            cb.ShowText(tbSnaga1.Text);
            cb.SetTextMatrix(96, 632);
            cb.ShowText(tbSpremnost1.Text);
            cb.SetTextMatrix(96, 606);
            cb.ShowText(tbKonstitucija1.Text);
            cb.SetTextMatrix(96, 580);
            cb.ShowText(tbInteligencija1.Text);
            cb.SetTextMatrix(96, 554);
            cb.ShowText(tbMudrost1.Text);
            cb.SetTextMatrix(96, 528);
            cb.ShowText(tbHarizma1.Text);
            //ANIMAL ITD
            cb.SetTextMatrix(96, 483);
            cb.ShowText(tbAcrobatics.Text);
            cb.SetTextMatrix(96, 463);
            cb.ShowText(TbAnimalHandling.Text);
            cb.SetTextMatrix(96, 443);
            cb.ShowText(tbArcana.Text);
            cb.SetTextMatrix(96, 423);
            cb.ShowText(tbAthletics.Text);
            cb.SetTextMatrix(96, 403);
            cb.ShowText(tbDeception.Text);
            cb.SetTextMatrix(96, 383);
            cb.ShowText(tbHistory.Text);
            cb.SetTextMatrix(96, 363);
            cb.ShowText(tbInsight.Text);
            cb.SetTextMatrix(96, 343);
            cb.ShowText(tbIntimidation.Text);
            cb.SetTextMatrix(96, 323);
            cb.ShowText(tbInvestigation.Text);
            cb.SetTextMatrix(96, 303);
            cb.ShowText(tbMedicine.Text);
            cb.SetTextMatrix(96, 283);
            cb.ShowText(tbNature.Text);
            cb.SetTextMatrix(96, 261);
            cb.ShowText(tbPerception.Text);
            cb.SetTextMatrix(96, 241);
            cb.ShowText(tbPerfomance.Text);
            cb.SetTextMatrix(96, 221);
            cb.ShowText(tbPersuation.Text);
            cb.SetTextMatrix(96, 201);
            cb.ShowText(tbReligion.Text);
            cb.SetTextMatrix(96, 181);
            cb.ShowText(tbSleighOfHand.Text);
            cb.SetTextMatrix(96, 161);
            cb.ShowText(tbStealth.Text);
            cb.SetTextMatrix(96, 141);
            cb.ShowText(tbSurvival.Text);
            //hit dice
            cb.SetFontAndSize(bf, 10);
            cb.SetTextMatrix(227, 478);
            cb.ShowText(tbHitDice.Text);
            //attack and spellcast
            cb.SetTextMatrix(227, 417);
            cb.ShowText(tbatandSpelName1.Text);
            cb.SetTextMatrix(280, 417);
            cb.ShowText(tbAtkBonus1.Text);

            

            cb.SetTextMatrix(227, 391);
            cb.ShowText(tbatandSpelName2.Text);
            cb.SetTextMatrix(280, 391);
            cb.ShowText(tbAtkBonus2.Text);
            

            cb.SetTextMatrix(227, 360);
            cb.ShowText(tbatandSpelName3.Text);
            cb.SetTextMatrix(280, 360);
            cb.ShowText(tbAtkBonus3.Text);
           

            cb.SetTextMatrix(227, 330);
            cb.ShowText(tbatandSpelName4.Text);
            cb.SetTextMatrix(280, 330);
            cb.ShowText(tbAtkBonus4.Text);
            cb.SetFontAndSize(bf, 8);
            cb.SetTextMatrix(320, 330);
            cb.ShowText(tbDamageType4.Text);
            cb.SetTextMatrix(320, 417);
            cb.ShowText(tbDamageType1.Text);
            cb.SetTextMatrix(320, 360);
            cb.ShowText(tbDamageType3.Text);
            cb.SetTextMatrix(320, 391);
            cb.ShowText(tbDamageType2.Text);

            /////problemoemo       
            var titleFont = FontFactory.GetFont("POORICH.ttf", 9, BaseColor.BLACK);

            ColumnText ct = new ColumnText(wri.DirectContent);
            
            ct.SetSimpleColumn(new iTextSharp.text.Rectangle(227,210,385,301));
            Paragraph p1 = new Paragraph(tbAttakAndSpellCast.Text);
            p1.Font = titleFont;
            ct.AddElement(new Paragraph(p1));
            ct.Go();


            ct.SetSimpleColumn(new iTextSharp.text.Rectangle(30, 70, 180, 112));
            Paragraph p2 = new Paragraph(tbOtherProf.Text);
            
            p2.Font = titleFont;
            ct.AddElement(new Paragraph(p2));
            ct.Go();

            Paragraph p3 = new Paragraph(tbLanguages.Text);
            ct.SetSimpleColumn(new iTextSharp.text.Rectangle(30, 5, 180, 50));
           
            p3.Font = titleFont;
            ct.AddElement(new Paragraph(p3));
            ct.Go();

            Paragraph p4 = new Paragraph(tbPersonalityTraits.Text);
            p4.Font = titleFont;
            ct.SetSimpleColumn(new iTextSharp.text.Rectangle(405, 630, 580, 675));
            ct.AddElement(new Paragraph(p4));
            ct.Go();

            Paragraph p5 = new Paragraph(tbIdeals.Text);
            p5.Font = titleFont;
            ct.SetSimpleColumn(new iTextSharp.text.Rectangle(405, 530, 580, 580));
            ct.AddElement(new Paragraph(p5));
            ct.Go();

            Paragraph p6 = new Paragraph(tbBonds.Text);
            p6.Font = titleFont;
            ct.SetSimpleColumn(new iTextSharp.text.Rectangle(405, 430, 580, 480));
            ct.AddElement(new Paragraph(p6));
            ct.Go();

            Paragraph p7 = new Paragraph(tbFlaws.Text);
            p7.Font = titleFont;
            ct.SetSimpleColumn(new iTextSharp.text.Rectangle(405, 330, 580, 384));
            ct.AddElement(new Paragraph(p7));
            ct.Go();

            Paragraph p8 = new Paragraph(tbFeaturesAndTraits.Text);
            p8.Font = titleFont;
            ct.SetSimpleColumn(new iTextSharp.text.Rectangle(410, 3, 580, 276));
            ct.AddElement(new Paragraph(p8));
            ct.Go();

            string s1="";
            for(int i = 0; i < lbOprema.Items.Count; i++)
            {
                s1 += lbOprema.Items[i];
                s1 += " , ";
            }
            Paragraph p9 = new Paragraph(s1);
            p9.Font = titleFont;
            ct.SetSimpleColumn(new iTextSharp.text.Rectangle(275,25,385,140));
            ct.AddElement(new Paragraph(p9));
            ct.Go();
           

            //passive wisdom
            cb.SetFontAndSize(bf, 10);
            cb.SetTextMatrix(227, 175);
            cb.ShowText(tbPassiveWisdom.Text);
            //equipment
            cb.SetFontAndSize(bf, 9);
            cb.SetTextMatrix(238, 128);
            cb.ShowText(tbCP.Text);
            cb.SetTextMatrix(238, 98);
            cb.ShowText(tbSP.Text);
            cb.SetTextMatrix(238, 72);
            cb.ShowText(tbEP.Text);
            cb.SetTextMatrix(238, 44);
            cb.ShowText(tbGP.Text);
            cb.SetTextMatrix(238, 20);
            cb.ShowText(tbPP.Text);
            cb.EndText();

            PdfContentByte cb1 = wri.DirectContent;
            
            cb.SetColorFill(BaseColor.BLACK);
            

            //crtanje kruga na koordinate x,y i poluprecnik r
            if (cbSnaga.Checked)
            {
                cb1.Circle(81f, 663f, 3f);
                cb1.Fill();
            }
            
            if (cbSpremnost.Checked)
            {
                cb1.Circle(81f, 635f, 3f);
                cb1.Fill();
            }
             if (cbKonstitucija.Checked)
            {
                cb1.Circle(81f, 610f, 3f);
                cb1.Fill();
            }
            if (cbInteligencija.Checked)
            {
                cb1.Circle(81f, 582f, 3f);
                cb1.Fill();
            }
            if (cbMudrost.Checked)
            {
                cb1.Circle(81f, 558f, 3f);
                cb1.Fill();
            }
            if (cbHarizma.Checked)
            {
                cb1.Circle(81f, 530f, 3f);
                cb1.Fill();
            }
            //DEATHS SAVES I FEJLOVI


            if (cbdeathfail1.Checked)
            {
                cb1.Circle(333f, 481f, 3f);
                cb1.Fill();
            }
            if (cbdeathfail2.Checked)
            {
                cb1.Circle(352f, 481f, 3f);
                cb1.Fill();
            }
            if (cbdeathfail3.Checked)
            {
                cb1.Circle(369f, 481f, 3f);
                cb1.Fill();
            }
            if (cbdeathsuces1.Checked)
            {
                cb1.Circle(333f, 501f, 3f);
                cb1.Fill();
            }
            if (cbdeathsuces2.Checked)
            {
                cb1.Circle(352f, 501f, 3f);
                cb1.Fill();
            }
            if (cbdeathsuces3.Checked)
            {
                cb1.Circle(369f, 501f, 3f);
                cb1.Fill();
            }

            //cb acrob itd


            if (cbAcrob.Checked)
            {
                cb1.Circle(78f,487f, 3f);
                cb1.Fill();
            }
            if (cbAnimal.Checked)
            {
                cb1.Circle(78f, 465f, 3f);
                cb1.Fill();
            }
            if (cbArcana.Checked)
            {
                cb1.Circle(78f, 447f, 3f);
                cb1.Fill();
            }
            if (cbAthle.Checked)
            {
                cb1.Circle(78f, 427f, 3f);
                cb1.Fill();
            }
            if (cbDecept.Checked)
            {
                cb1.Circle(78f, 407f, 3f);
                cb1.Fill();
            }
            if (cbHist.Checked)
            {
                cb1.Circle(78f, 385f, 3f);
                cb1.Fill();
            }
            if (cbInsight.Checked)
            {
                cb1.Circle(78f, 365f, 3f);
                cb1.Fill();
            }
            if (cbIntimid.Checked)
            {
                cb1.Circle(78f, 343f, 3f);
                cb1.Fill();
            }
            if (cbInvestig.Checked)
            {
                cb1.Circle(78f, 323f, 3f);
                cb1.Fill();
            }
            if (cbMedicine.Checked)
            {
                cb1.Circle(78f, 305f, 3f);
                cb1.Fill();
            }
            if (cbNature.Checked)
            {
                cb1.Circle(78f, 286f, 3f);
                cb1.Fill();
            }
            if (cbPerception.Checked)
            {
                cb1.Circle(78f, 265f, 3f);
                cb1.Fill();
            }
            if (cbPerfomance.Checked)
            {
                cb1.Circle(78f,244f, 3f);
                cb1.Fill();
            }
            if (cbPersuation.Checked)
            {
                cb1.Circle(78f, 224f, 3f);
                cb1.Fill();
            }
            if (cbReligion.Checked)
            {
                cb1.Circle(78f, 204f, 3f);
                cb1.Fill();
            }
            if (cbSleighOfHand.Checked)
            {
                cb1.Circle(78f, 185f, 3f);
                cb1.Fill();
            }
            if (cbStealth.Checked)
            {
                cb1.Circle(78f, 161f, 3f);
                cb1.Fill();
            }
            if (cbSurvival.Checked)
            {
                cb1.Circle(78f, 145f, 3f);
                cb1.Fill();
            }
            doc.Close();
            string filename =tbImeIgraca.Text+" "+tbPrezimeIgraca.Text+".pdf";
            System.Diagnostics.Process.Start(filename);
            MessageBox.Show("Uspesno ste exportovali u PDF\n Ime PDFA:"+tbImeIgraca.Text+" "+tbPrezimeIgraca.Text+".pdf");
            
        }

        private void TbXP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void TbCurrentHitPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void TbTemporaryHitPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }
        private void TbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void TbSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void TbEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void TbGP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void TbPP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void TbSpremnostm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }

        }

        private void TbKonstitucijam_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void TbInteligencijam_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void TbMudrostm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void TbHarizmam_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void TbSnagam_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Unesite broj!");

            }
            else
            {

            }
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void TbXP_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Prikaz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
