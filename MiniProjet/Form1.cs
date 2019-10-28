using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjet
{
    public partial class Form1 : Form
    {
        string strCon;
        SqlConnection con;
        DataClasses1DataContext cl;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            strCon = "Data Source =DESKTOP-T197CIN\\SQLEXPRESS; Initial Catalog =GestionEtudiants ;Integrated Security = true";
            con = new SqlConnection(strCon);
            ListFiliere();
            cl = new DataClasses1DataContext();
            var Etudiantbd = from c in cl.etudiants
                    select c;
            foreach(etudiant etd in Etudiantbd)
            {
                listeCne.Items.Add(etd.cne);
            }

            fillReport();
            chartFill();

            timer1.Interval = 50000;
            timer1.Start();
        }

        public void ListFiliere()
        {
            dataGridView1.Rows.Clear();
            SqlCommand filieresCmd = new SqlCommand("Select * from Filiere", con);
            con.Open();
            SqlDataReader drFiliere = filieresCmd.ExecuteReader();
            while (drFiliere.Read())
            {
                dataGridView1.Rows.Add(drFiliere[0], drFiliere[1]);
            }
            con.Close();
        }

        public Etudiant selectedEtudiant()
        {
            int cneSelected = Convert.ToInt32(listeCne.SelectedItem.ToString());
            var etdSelected = (from etd in cl.etudiants
                               where etd.cne == cneSelected
                               select etd).SingleOrDefault();
            etudiant e1 = etdSelected as etudiant;
            Etudiant a = new Etudiant(e1.nom, e1.prenom, e1.date_naiss, e1.adresse, e1.telephone, e1.cne, Convert.ToInt32(e1.id_fil), Convert.ToChar(e1.sexe));
            return a;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ajouterFiliere_Click(object sender, EventArgs e)
        {
            SqlCommand insertFiliereCmd = new SqlCommand("Insert into Filiere Values(@nomFiliere)", con);
            SqlParameter nomFil = new SqlParameter("@nomFiliere", nomFiliere.Text);
            insertFiliereCmd.Parameters.Add(nomFil);
            con.Open();
            insertFiliereCmd.ExecuteNonQuery();
           /* SqlCommand filiereAddedCmd = new SqlCommand("Select * from Filiere order by id_Filiere desc limit 1", con);
            SqlDataReader addedFiliere = filiereAddedCmd.ExecuteReader();
            addedFiliere.Read();
            dataGridView1.Rows.Add(addedFiliere[0], addedFiliere[1]);*/
            con.Close();
            ListFiliere();
        }

        private void nomFiliere_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void chartFill()
        {
            
            var fils = from f in cl.Filieres
                       select f;
            foreach(Filiere f in fils)
            {
                var nbEtdParFil = from etd in cl.etudiants
                                  where etd.id_fil == f.id_Filiere
                                  select etd;
                int nbEtd = 0;
                foreach(etudiant etd in nbEtdParFil)
                {
                    nbEtd++;
                }
                chart1.Series["Nombre etudiants"].Points.AddXY(f.nom_Filiere, nbEtd);
                
            }
        }

        public void fillReport()
        {
            CrystalReport1 cr1 = new CrystalReport1();
            DataSet ds = new DataSet();
            var x = from etd in cl.etudiants
                    select etd;
            DataTable dt = new DataTable();
            dt.TableName = "etudiants";
            //dt = x as DataTable;


            SqlDataAdapter dap = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("select * from etudiant", con);

            dap.SelectCommand = cmd;
            dap.Fill(dt);
            ds.Tables.Add(dt);

            cr1.SetDataSource(ds.Tables["etudiants"]);
            crystalReportViewer1.ReportSource = cr1;
            crystalReportViewer1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
                SqlCommand updateCmd = new SqlCommand("Update Filiere set nom_Filiere = @newName where id_Filiere = @oldFiliere", con);
                SqlParameter param1 = new SqlParameter("@newName", nouveauNom.Text);
                SqlParameter param2 = new SqlParameter("@oldFiliere", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                updateCmd.Parameters.Add(param1);
                updateCmd.Parameters.Add(param2);
                con.Open();
                updateCmd.ExecuteNonQuery();
                con.Close();
                nouveauNom.Text = "";
                panel2.Visible = false;
                ListFiliere();
                
           
            
        }

        private void ModifierFiliere_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("Selectionnez une ligne!!!");
            }


        }

        private void deleteFiliere_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                String msg = "Vous voulez supprimer la filiere " + dataGridView1.SelectedRows[0].Cells[1].Value;
                var confirm = MessageBox.Show(msg, "", MessageBoxButtons.YesNo);
                if(confirm == DialogResult.Yes)
                {
                    SqlCommand deleteCmd = new SqlCommand("Delete from Filiere where  id_Filiere = @Filiere", con);
                    SqlParameter param = new SqlParameter("@Filiere", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    deleteCmd.Parameters.Add(param);
                    con.Open();
                    deleteCmd.ExecuteNonQuery();
                    con.Close();
                    ListFiliere();
                }
            }
            else
            {
                MessageBox.Show("Selectionnez une ligne!!!");
            }


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        
        private void listeCne_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* int cneSelected = Convert.ToInt32(listeCne.SelectedItem.ToString());
             var etdSelected = (from etd in cl.etudiants
                               where etd.cne == cneSelected
                               select etd).SingleOrDefault();
             etudiant a = etdSelected as etudiant;*/
            Etudiant a = selectedEtudiant();
           
                cne.Text = a.Cne.ToString();
                Nom.Text = a.Nom;
                prenom.Text = a.Prenom;
                if (a.Sexe == 'F')
                    female.Checked = true;
                else
                    male.Checked = true;
                dateN.Text = a.DateNaissance;
                adresse.Text = a.Adresse;
                telephone.Text = a.Telephone;
            var fil = (from etd in cl.etudiants
                      join f in cl.Filieres on
                      etd.id_fil equals f.id_Filiere
                      where etd.id_fil == a.Filiere
                      select f);
            foreach(Filiere f in fil)
            {
                filiere.Text = f.nom_Filiere;
                break;
            }
            
        }

        private void chargerDonnees_Click(object sender, EventArgs e)
        {
            var x = from etd in cl.etudiants
                    select etd;
            dataGridView2.DataSource = x;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void triCroissant_Click(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Ascending);
        }

        private void triDecroissant_Click(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Descending);
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
           
            var x = (from etd in cl.etudiants
                    where etd.cne == Convert.ToInt32(cne.Text)
                    select etd).SingleOrDefault();
            etudiant etdd = x as etudiant;
            if(etdd == null)
            {
                char sex = ' ';
                if (male.Checked)
                    sex = 'M';
                else
                    sex = 'F';
                Etudiant a = new Etudiant(Nom.Text, prenom.Text, dateN.Text, adresse.Text, telephone.Text, Convert.ToInt32(cne.Text), Convert.ToInt32(filiere.Text), sex);
                etudiant etd = new etudiant();
                etd.cne = a.Cne;
                etd.date_naiss = a.DateNaissance;
                etd.adresse = a.Adresse;
                etd.sexe = a.Sexe;
                etd.nom = a.Nom;
                etd.prenom = a.Prenom;
                etd.id_fil = a.Filiere;
                etd.telephone = a.Telephone;
                cl.etudiants.InsertOnSubmit(etd);
                cl.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Etudiant existe dèja");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fillReport();
            //                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       7chartFill();

        }
    }
}
