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

namespace DnD
{
    public partial class DnD : Form
    {
        
        public DnD()
        {
            InitializeComponent();
        }
        public int n;
        
        private void LbIme_Click(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        public OleDbConnection cone = new OleDbConnection();
        
        private void DnD_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.ControlBox = false;
            CbEnabled();
            cbIme.Items.Clear();
           
           
            try
            {
                cone.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Dnd.mdb;
                Persist Security Info=False;";

                cone.Open();
                

            }
            catch (Exception a)
            {
                MessageBox.Show("Error "+a);
            }
            

            cbRasa.Items.Add("");
            cbPol.Items.Add("");
            cbOdredjenost.Items.Add("");
            cbKlasa.Items.Add("");
            cbPozadina.Items.Add("");
             cbIme.Enabled = false;
             cbPrezime.Enabled = false;
            cbOprema.Items.Add("");
            cbKlasa.SelectedIndex = 0;
            
            OleDbCommand cmd1, cmd2, cmd4, cmd5, cmd3,cmd6;
                
            cmd4 = cone.CreateCommand();
            cmd2 = cone.CreateCommand();   
            cmd1 = cone.CreateCommand();
            cmd3 = cone.CreateCommand();
            cmd6 = cone.CreateCommand();
            cmd5 = cone.CreateCommand();


            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.cbKlasa, "Od klase zavise koja ce saving throws polja biti otkacena i koje skilove mozete da izaberete\nBirajte pazljivo");
            toolTip1.SetToolTip(this.cbPozadina, "U zavisnosti od pozadine,imacete neke skilove otkacene(uglavnom 2)");
            toolTip1.SetToolTip(this.tbTemporaryHitPoints, "Ukoliko ostavite prazno,ovo polje ce dobiti\n vrednost od Current Hit Points");
            toolTip1.SetToolTip(this.cbRasa,"U zavisnosti od rase,imacete ponudjene \n razne opcije za ime i prezime Karaktera i automatski popuni polje \n brzine za tu rasu");
            toolTip1.SetToolTip(this.cbPol, "U zavisnosti od pola birate izmedju muskih i zenskih imena za tu rasu");
            if (tbXP.Text !="")
            {
               
            }
            else
            {
                toolTip1.SetToolTip(this.tbSnagam, "Unesite XP prvo");
            }

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
            
           
            foreach(DataRow dr6 in dt6.Rows)
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
            
            

            cone.Close();
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

        }
        void ResetCbDonji()
        {
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
            if (cbKlasa.SelectedIndex > 0)
            {
                cbPozadina.Enabled = true;
            }
            else 
            {
                cbPozadina.Enabled = false;
            }
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
            if (cbKlasa.SelectedIndex ==1)
            {
                   
                cbSnaga.Checked = true;
                cbKonstitucija.Checked = true;
                cbSpremnost.Checked = false;
                cbInteligencija.Checked = false;
                cbMudrost.Checked = false;
                cbHarizma.Checked = false;

                
                
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
                
                cbAnimal.Enabled = false;
                cbAthle.Enabled = false;
                cbIntimid.Enabled = false;
                cbNature.Enabled = false;
                cbPerception.Enabled = false;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = false;
                cbDecept.Enabled = false;
                cbHist.Enabled =true;
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
                
                cbAnimal.Enabled = false;
                cbAthle.Enabled = true;
                cbIntimid.Enabled = false;
                cbNature.Enabled = false;
                cbPerception.Enabled = false;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = true;
                cbArcana.Enabled = false;
                cbDecept.Enabled = false;
                cbHist.Enabled =true;
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
            else if (cbKlasa.SelectedIndex ==7)
            {
               
                cbSnaga.Checked = false;
                cbSpremnost.Checked = false;
                cbMudrost.Checked = true;
                cbHarizma.Checked = true;
                cbInteligencija.Checked = false;
                cbKonstitucija.Checked = false;

                
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
                cbHarizma.Checked = true ;
                cbInteligencija.Checked = false;
                cbKonstitucija.Checked = true;

                

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

                
                cbAnimal.Enabled = false;
                cbAthle.Enabled = false;
                cbIntimid.Enabled =true;
                cbNature.Enabled = true;
                cbPerception.Enabled = false;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = true;
                cbDecept.Enabled = true;
                cbHist.Enabled = true;
                cbInsight.Enabled = false;
                cbInvestig.Enabled =true;
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

                
                cbAnimal.Enabled = false;
                cbAthle.Enabled = false;
                cbIntimid.Enabled = false;
                cbNature.Enabled = true;
                cbPerception.Enabled =true;
                cbSurvival.Enabled = false;
                cbAcrob.Enabled = false;
                cbArcana.Enabled = true;
                cbDecept.Enabled = false;
                cbHist.Enabled =true;
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
            if (cbRasa.SelectedIndex > 0)
            {
                cbPol.Enabled = true;
            }
            else
            {
                cbPol.Enabled = false;
            }
            if (!(cbPol.SelectedIndex == -1 || cbPol.SelectedItem == null) && !(cbRasa.SelectedIndex == -1 || cbRasa.SelectedItem == null))
                {
                    cbIme.Enabled = true;
                    cbPrezime.Enabled = true;

                }

                if (!(cbRasa.SelectedIndex > 0) || !(cbPol.SelectedIndex > 0))
                {
                    cbIme.Enabled = false;
                    cbPrezime.Enabled = false;
                    cbIme.Text = "";
                    cbPrezime.Text = "";
                }
                cone.Open();
                OleDbCommand cmd3;
                cmd3 = cone.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                OleDbCommand cmd4;
                cmd4 = cone.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                if (cbRasa.SelectedIndex == 1)
                {
                    cbPrezime.Items.Clear();
                    
                    cmd3.CommandText = "select Prezime from Prezimekaraktera where idRase=1;";
                    cmd3.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                    da.Fill(dt);
                  
               
                    foreach (DataRow dr in dt.Rows)
                    {

                        cbPrezime.Items.Add(dr["Prezime"].ToString());
                    }
                
                    }
                else if (cbRasa.SelectedIndex == 2)
                {
                    cbPrezime.Items.Clear();
                    
                    cmd3.CommandText = "select Prezime from Prezimekaraktera where idRase=2;";
                    cmd3.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {

                        cbPrezime.Items.Add(dr["Prezime"].ToString());
                    }

                }
                else if (cbRasa.SelectedIndex == 3)
                {
                    cbPrezime.Items.Clear();

                    cmd3.CommandText = "select Prezime from Prezimekaraktera where idRase=3;";
                    cmd3.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {

                        cbPrezime.Items.Add(dr["Prezime"].ToString());
                    }
                }
                else if (cbRasa.SelectedIndex == 4)
                {
                    cbPrezime.Items.Clear();

                    cmd3.CommandText = "select Prezime from Prezimekaraktera where idRase=4;";
                    cmd3.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {

                        cbPrezime.Items.Add(dr["Prezime"].ToString());
                    }
                }
                else if (cbRasa.SelectedIndex == 5)
                {
                    cbPrezime.Items.Clear();

                    cmd3.CommandText = "select Prezime from Prezimekaraktera where idRase=5;";
                    cmd3.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {

                        cbPrezime.Items.Add(dr["Prezime"].ToString());
                    }
                }
                else if (cbRasa.SelectedIndex == 6)
                {
                    cbPrezime.Items.Clear();

                    cmd3.CommandText = "select Prezime from Prezimekaraktera where idRase=6;";
                    cmd3.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {

                        cbPrezime.Items.Add(dr["Prezime"].ToString());
                    }
                }
                else if (cbRasa.SelectedIndex == 7)
                {
                    cbPrezime.Items.Clear();

                    cmd3.CommandText = "select Prezime from Prezimekaraktera where idRase=7;";
                    cmd3.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {

                        cbPrezime.Items.Add(dr["Prezime"].ToString());
                    }
                }
                else if (cbRasa.SelectedIndex == 8)
                {
                    cbPrezime.Items.Clear();

                    cmd3.CommandText = "select Prezime from Prezimekaraktera where idRase=8;";
                    cmd3.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {

                        cbPrezime.Items.Add(dr["Prezime"].ToString());
                    }
                }
                else if (cbRasa.SelectedIndex == 9)
                {
                    cbPrezime.Items.Clear();

                    cmd3.CommandText = "select Prezime from Prezimekaraktera where idRase=9;";
                    cmd3.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {

                        cbPrezime.Items.Add(dr["Prezime"].ToString());
                    }
                }


                if (cbRasa.SelectedIndex == 1 || cbRasa.SelectedIndex == 3 || cbRasa.SelectedIndex == 5 || cbRasa.SelectedIndex == 7 || cbRasa.SelectedIndex == 8 || cbRasa.SelectedIndex == 9)
                {

                    tbSpeed.Text = "30 feet";
                }
                else if (cbRasa.SelectedIndex == 2 || cbRasa.SelectedIndex == 4 || cbRasa.SelectedIndex == 6)
                {

                    tbSpeed.Text = "25 feet";
                }
                else if (cbRasa.SelectedIndex == 0)
                {

                    tbSpeed.Text = "";
                }
            cbIme.Items.Clear();
                
            OleDbCommand cmd;
            cmd = cone.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (cbPol.SelectedIndex == 1)
            {

                if (cbRasa.SelectedIndex == 1)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=1;";


                }
                else if (cbRasa.SelectedIndex == 2)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=2;";
                }
                else if (cbRasa.SelectedIndex == 3)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=3;";
                }
                else if (cbRasa.SelectedIndex == 4)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=4;";
                }
                else if (cbRasa.SelectedIndex == 5)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=5;";
                }
                else if (cbRasa.SelectedIndex == 6)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=6;";
                }
                else if (cbRasa.SelectedIndex == 7)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=7;";
                }
                else if (cbRasa.SelectedIndex == 8)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=8;";
                }
                else if (cbRasa.SelectedIndex == 9)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=9;";
                }
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    cbIme.Items.Add(dr["Ime"].ToString());
                }


            }
            else if (cbPol.SelectedIndex == 2)
            {

                if (cbRasa.SelectedIndex == 1)
                {

                    cmd.CommandText = "select ime from ImeKaraktera where idPola=2 and  idRase=1;";

                }
                else if (cbRasa.SelectedIndex == 2)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=2;";
                }
                else if (cbRasa.SelectedIndex == 3)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=3;";
                }
                else if (cbRasa.SelectedIndex == 4)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=4;";
                }
                else if (cbRasa.SelectedIndex == 5)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=5;";
                }
                else if (cbRasa.SelectedIndex == 6)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=6;";
                }
                else if (cbRasa.SelectedIndex == 7)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=7;";
                }
                else if (cbRasa.SelectedIndex == 8)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=8;";
                }
                else if (cbRasa.SelectedIndex == 9)
                {

                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=9;";
                }
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    cbIme.Items.Add(dr["Ime"].ToString());
                }

            }
            cone.Close();

        }

        private void BrisiIme()
        {
           
            
            cbIme.Text = "";
            cbPrezime.Text = "";
        }

        private void CbPol_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIme.Items.Clear();
            if (cbPol.SelectedIndex >0)
            {
                cbRasa.Enabled = false;
            }
            else
            {
                cbRasa.Enabled = true;
            }
            if (!(cbPol.SelectedIndex == -1 || cbPol.SelectedItem == null) && !(cbRasa.SelectedIndex == -1 || cbRasa.SelectedItem == null))
            {
                cbIme.Enabled = true;
                cbPrezime.Enabled = true;
            }
          
            if (!(cbRasa.SelectedIndex > 0) || !(cbPol.SelectedIndex > 0))
            {
                cbIme.Enabled = false;
                cbPrezime.Enabled = false;
                cbIme.Text = "";
                cbPrezime.Text = "";
            }

            cone.Open();
            OleDbCommand cmd;
            cmd = cone.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            
            if (cbPol.SelectedIndex == 1 )
            {
                
                if (cbRasa.SelectedIndex == 1)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=1;";
                   
                    
                }
                else if (cbRasa.SelectedIndex == 2)
                {
                   
                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=2;";
                }
                else if (cbRasa.SelectedIndex ==3)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=3;";
                }
                else if (cbRasa.SelectedIndex == 4)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=4;";
                }
                else if (cbRasa.SelectedIndex == 5)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=5;";
                }
                else if (cbRasa.SelectedIndex == 6)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=6;";
                }
                else if (cbRasa.SelectedIndex == 7)
                {
                   
                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=7;";
                }
                else if (cbRasa.SelectedIndex == 8)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=8;";
                }
                else if (cbRasa.SelectedIndex == 9)
                {
                   
                    cmd.CommandText = "select ime from imeKaraktera where idPola=1 and idRase=9;";
                }
                cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {

                        cbIme.Items.Add(dr["Ime"].ToString());
                    }
                
                
            }
           else  if (cbPol.SelectedIndex == 2)
            {
                
                if (cbRasa.SelectedIndex == 1)
                {
                    
                    cmd.CommandText = "select ime from ImeKaraktera where idPola=2 and  idRase=1;";

                }
                else if (cbRasa.SelectedIndex == 2)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=2;";
                }
                else if (cbRasa.SelectedIndex == 3)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=3;";
                }
                else if (cbRasa.SelectedIndex == 4)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=4;";
                }
                else if (cbRasa.SelectedIndex == 5)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=5;";
                }
                else if (cbRasa.SelectedIndex == 6)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=6;";
                }
                else if (cbRasa.SelectedIndex == 7)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=7;";
                }
                else if (cbRasa.SelectedIndex == 8)
                {
                    
                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=8;";
                }
                else if (cbRasa.SelectedIndex == 9)
                {
                   
                    cmd.CommandText = "select ime from imeKaraktera where idPola=2 and idRase=9;";
                }
                cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {

                        cbIme.Items.Add(dr["Ime"].ToString());
                    }             
                
            }
            cone.Close();
      
        }
        public void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cbKlasa.SelectedItem == null || cbRasa.SelectedItem == null || cbPozadina.SelectedItem == null || cbIme.SelectedItem == null || cbPrezime.SelectedItem == null || cbPol.SelectedItem == null || cbOdredjenost.SelectedItem == null || tbImeIgraca.Text == null || tbPrezimeIgraca.Text == null)
            {
              
                MessageBox.Show("Molim vas popunite sva osnovna polja ");

            }
            else if (tbCurrentHitPoints.Text == "" || tbSnagam.Text == "" || tbHarizmam.Text == "" || tbKonstitucijam.Text == "" || tbMudrostm.Text == "" || tbSpremnostm.Text == "" || tbInteligencijam.Text == "")
            {

                MessageBox.Show("Molim vas popunite sva osnovna polja svetlo sive boje");

            }
            else if(cbKlasa.SelectedIndex ==0 || cbRasa.SelectedIndex == 0 || cbPozadina.SelectedIndex == 0 || cbIme.SelectedIndex == 0 || cbPrezime.SelectedIndex == 0 || cbPol.SelectedIndex == 0 || cbOdredjenost.SelectedIndex == 0  )
            {

                MessageBox.Show("Molim vas popunite sva osnovna polja");

            }


            else
            {
                int idKlase1, idRase1, idOpredeljenosti1, idImenaKaraktera1, idPrezimenaKaraktera1, idKaraktera1, idPozadine1;
                OleDbDataReader dr1, dr2, dr3, dr4, dr5, dr6, dr8;


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
                short arc1, athl1, hist1, acrob1, animal1, decept1, insih1, intim1, investi1;
                short medic1, natur1, perce1, perfo1, persuas1, relig1, slei1, stealt1, survi1;
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
                pp = Convert.ToInt32(tbPP.Text);
                komanda.CommandText = "insert into Karakter(idKlase,idRase,idOpredeljenosti,idImena,idPrezimena,XP,[level]," +
                    "ProficencyBonus,armor,initiative,Speed,CurrentHitPoints,TemporaryHitPoints,cp,sp,ep,gp,pp,idPozadine,strength," +
                    "dexterity,constitution,intelligence,wisdom,charisma,snagamax,dexterityMax,constitutionMax,intelligenceMax,wisdomMax," +
                    "CharismaMax,snagaProf,dexterityProf,constitutionProf,intelligenceProf,wisdomProf,CharismaProf,acrobatics,animalHandling," +
                    "arcana,athletics,deception,history,insight,intimidation,investigation,medicine,nature,perception,perfomance,persuasion,religion," +
                    "sleighOfHand,Stealth,survival,[Hit Dice],[PersonalityTraits],Ideals,Bonds,Flaws,PassiveWisdom,OtherProficencies,Languages," +
                    "attacksAndSpellcasting,FeaturesAndTraits,attandspellname1,attandspellname2,attandspellname3,attandspellname4,atkbonus1,atkbonus2," +
                    "atkbonus3,atkbonus4,damagetype1,damagetype2,damagetype3,damagetype4,cbarcana,cbathletics,cbdeception,cbhistory,cbinsight,cbintimidation," +
                    "cbinvestigation,cbmedicine,cbnature,cbperception,cbperfomance,cbpersuasion,cbreligion,cbsleighofhand,cbstealth,cbsurvival,cbacrobatics," +
                    "cbanimal,cbdsfails1,cbdsfails2,cbdsfails3,cbdswins1,cbdswins2,cbdswins3) values('" + idKlase1 + "','" + idRase1 + "','" + idOpredeljenosti1 + "','" + idImenaKaraktera1 + "','" + idPrezimenaKaraktera1 + "','" + tbXP.Text + "','" + tbLevel.Text + "','" + lbProfBonus.Text + "','" + tbArmorClass.Text + "','" + tbInitiative.Text + "','" + tbSpeed.Text + "','" + tbCurrentHitPoints.Text + "','" + z + "','" + cp + "','" + sp + "','" + ep + "','" + gp + "','" + pp + "','" + idPozadine1 + "','" + strengthV + "','" + dexterityV + "','" + constitutionV + "','" + intelligenceV + "','" + wisdomV + "','" + charismaV + "','" + strengthm + "','" + dexteritym + "','" + constitutionm + "','" + intelligencem + "','" + wisdomm + "','" + charismam + "','" + strengthp + "','" + dexterityp + "','" + constitutionp + "','" + intelligencep + "','" + wisdomp + "','" + charismap +
                   "','" + acrobatics + "','" + animalh + "','" + arcana + "','" + athlet + "','" + decep + "','" + hist + "','" + insig + "','" + intim + "','" + invest + "','" + medic + "','" + nature + "','" + percep + "','" + perfom + "','" + persua + "','" + relig + "','" + sleighOfH + "','" + stealth + "','" + survival + "','" + tbHitDice.Text + "','" + tbPersonalityTraits.Text + "','" + tbIdeals.Text + "','" + tbBonds.Text + "','" + tbFlaws.Text + "','" + tbPassiveWisdom.Text + "','" + tbOtherProf.Text + "','" + tbLanguages.Text + "','" + tbAttakAndSpellCast.Text + "','" + tbFeaturesAndTraits.Text + "','" + tbatandSpelName1.Text + "','" + tbatandSpelName2.Text + "','" + tbatandSpelName3.Text + "','" + tbatandSpelName4.Text + "','" + tbAtkBonus1.Text + "','" + tbAtkBonus2.Text + "','" + tbAtkBonus3.Text + "','" + tbAtkBonus4.Text + "','" + tbDamageType1.Text + "','" + tbDamageType2.Text + "','" + tbDamageType3.Text + "','" + tbDamageType4.Text + "','" + arc1 + "','" + athl1 + "','" + decept1 + "','" + hist1 + "','" + insih1 + "','" + intim1 + "','" + investi1 + "','" + medic1 + "','" + natur1 + "','" + perce1 + "','" + perfo1 + "','" + persuas1 + "','" + relig1 + "','" + slei1 + "','" + stealt1 + "','" + survi1 + "','" + acrob1 + "','" + animal1 + "','" + fail1 + "','" + fail2 + "','" + fail3 + "','" + win1 + "','" + win2 + "','" + win3 + "'); ";

                komanda.ExecuteNonQuery();
                kom7.CommandText = "select idKaraktera from Karakter order by idKaraktera desc;";
                dr6 = kom7.ExecuteReader();
                dr6.Read();
                idKaraktera1 = Convert.ToInt32(dr6[0].ToString());

                OleDbCommand kom9 = new OleDbCommand();
                kom9.Connection = cone;
                kom9.CommandType = CommandType.Text;
                kom9.CommandText = "select idKaraktera from Karakter order by idKaraktera desc;";
                OleDbCommand kom10 = new OleDbCommand();
                kom10.Connection = cone;
                kom10.CommandType = CommandType.Text;


                OleDbDataReader dr9 = kom9.ExecuteReader();

                dr9.Read();
                int idKaraktera2;
                idKaraktera2 = Convert.ToInt32(dr9[0].ToString());
                int[] idOpreme1 = new int[lbOprema.Items.Count];
                n = lbOprema.Items.Count;
                for (int i = 0; i < n; i++)
                {
                    kom10.CommandText = "Select idOpreme From Oprema Where imeOpreme='" + lbOprema.Items[i] + "';";
                    OleDbDataReader dr10 = kom10.ExecuteReader();
                    dr10.Read();
                    idOpreme1[i] = Convert.ToInt32(dr10[0].ToString());
                    dr10.Close();
                }

                komanda1.CommandText = "insert into Igrac(imeIgraca,PrezimeIgraca,idKaraktera) values('" + tbImeIgraca.Text + "','" + tbPrezimeIgraca.Text + "','" + idKaraktera1 + "');";
                komanda1.ExecuteNonQuery();
                for (int i = 0; i < lbOprema.Items.Count; i++)
                {
                    komanda3.CommandText = "insert into ImaOpremu(idKaraktera,idOpreme) values ('" + idKaraktera2 + "','" + idOpreme1[i] + "');";
                    komanda3.ExecuteNonQuery();
                }



                MessageBox.Show("Podaci su snimljeni");
                Pocetna p = new Pocetna();
                this.Hide();
                p.ShowDialog();

                cone.Close();
                cone.Dispose();
            }
            

        }

        private void CbIme_SelectedIndexChanged(object sender, EventArgs e)
        {}

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
                cbPozadina.Enabled = false;
                PozadinaTrue();
                tbXP.Enabled = false;

            }


            else
            {
                cbPozadina.Enabled = true;
                ResetCbDonji();
                tbXP.Enabled = true;
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
            if (tbAcrobatics.Text != "")
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
            if (tbSleighOfHand.Text != "")
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
            if (tbStealth.Text != "")
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
           if (tbAthletics.Text != "")
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
            if (tbArcana.Text != "")
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
            if (tbHistory.Text != "")
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
            if (tbInvestigation.Text != "")
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
            if (tbNature.Text != "")
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
            if (tbReligion.Text != "")
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
            if (TbAnimalHandling.Text != "")
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
           
            if (tbInsight.Text != "")
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
            if (tbMedicine.Text != "")
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
            if (tbPerception.Text != "")
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
            if (tbSurvival.Text != "")
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
            if (tbDeception.Text != "")
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
            if (tbIntimidation.Text != "")
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
            if (tbPerfomance.Text != "")
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
            if (tbPersuation.Text != "")
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
            if(tbSnagam.Text != "" && tbKonstitucijam.Text != "" && tbSpremnostm.Text != "" && tbHarizmam.Text != "" && tbMudrostm.Text != "" && tbInteligencijam.Text != "")
            {
                cbPozadina.Enabled = false;
                PozadinaTrue();
                tbXP.Enabled = false;
                
            }
            

            else
            {
                cbPozadina.Enabled = true;
                ResetCbDonji();
                tbXP.Enabled = true;
            }

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
            else if (cbPozadina.SelectedIndex == 53)
            {
                cbArcana.Checked = true;
                cbHist.Checked = true;
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
                cbPozadina.Enabled = false;
                PozadinaTrue();
                tbXP.Enabled = false;


            }


            else
            {
                cbPozadina.Enabled = true;
                ResetCbDonji();
                tbXP.Enabled = true;
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
                cbPozadina.Enabled = false;
                PozadinaTrue();
                tbXP.Enabled = false;

            }


            else
            {
                cbPozadina.Enabled = true;
                tbXP.Enabled = true;
                ResetCbDonji();
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
                cbPozadina.Enabled = false;
                PozadinaTrue();
                tbXP.Enabled = false;

            }


            else
            {
                tbXP.Enabled = true;
                cbPozadina.Enabled = true;
                ResetCbDonji();
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
                cbPozadina.Enabled = false;
                PozadinaTrue();
                tbXP.Enabled = false;

            }


            else
            {
                tbXP.Enabled = true;
                cbPozadina.Enabled = true;
                ResetCbDonji();
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
   
        private void TbPerception_TextChanged(object sender, EventArgs e)
        {
            int z, k;
            if (tbPerception.Text != "")
            {
                z = Convert.ToInt32(tbPerception.Text);
                k = 10 + z;
                tbPassiveWisdom.Text = Convert.ToString(k);
            }
        }
        
        private void CbPozadina_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbXP.Text = "";
            ResetCbDonji();
            if (cbPozadina.SelectedIndex > 0)
            {
                tbXP.Enabled = true;
            }
            else
            {
                tbXP.Enabled = false;
            }
           
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
            if (rbAlati.Checked == false && rbArmor.Checked == false && rbOruzje.Checked == false)
            {
                MessageBox.Show("Molim vas izaberite Item koji zelite da dodate");
            }
            else if ((rbAlati.Checked == true || rbOruzje.Checked == true || rbArmor.Checked == true) && cbOprema.SelectedItem == null)
            {
                MessageBox.Show("Selektujte opremu");
            }
            else if (cbOprema.SelectedIndex == 0)
            {
                MessageBox.Show("Selektujte opremu");
            }
            else
            {
                
                lbOprema.Items.Add(cbOprema.SelectedItem);
                
            }
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
                k2.CommandText = "select idKaraktera from Karakter order by idKaraktera desc;";
                dr6 = k2.ExecuteReader();
                dr6.Read();
                idKar = Convert.ToInt32(dr6[0].ToString());
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?", "Izbrisati?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    k3.CommandText = "delete from ImaOpremu where idKaraktera=" + idKar + " and idOpreme=" + idOpreme + ";";
                    k3.ExecuteNonQuery();
                    lbOprema.Items.RemoveAt(sel);
                }
                else if (dialogResult == DialogResult.No) { }
            }
            cone.Close();
        }

        private void TbXP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if(!char.IsDigit(chr)&& chr != 8)
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

      

        private void TbEP_TextChanged(object sender, EventArgs e)
        {
        }

        private void TbSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbCP_TextChanged(object sender, EventArgs e)
        {

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

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void DnD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
