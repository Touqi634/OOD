using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelterManager
{
    public partial class frmShelterManager : Form
    {
        private Shelter shelter;

        public frmShelterManager()
        {
            InitializeComponent();
        }

        private void btnCreateShelter_Click(object sender, EventArgs e)
        {
            this.gbShelterDetails.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Reset
            this.tbShelterAddress.Text = "";
            this.tbShelterEmail.Text = "";
            this.tbShelterName.Text = "";
            this.tbShelterPhone.Text = "";
            this.gbShelterDetails.Visible = false;
            this.btnOpenShelter.Enabled = true;
            this.btnCreateShelter.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
            //Create shelter
            this.shelter = new Shelter(this.tbShelterName.Text, this.tbShelterAddress.Text, this.tbShelterEmail.Text, this.tbShelterPhone.Text);

            //Reset
            this.tbShelterAddress.Text = "";
            this.tbShelterEmail.Text = "";
            this.tbShelterName.Text = "";
            this.tbShelterPhone.Text = "";
            this.gbShelterDetails.Visible = false;
            this.btnOpenShelter.Enabled = true;
            this.btnCreateShelter.Enabled = true;
            this.gbManage.Visible = true;
            this.gbShelters.Visible = false;
        }

        private void CheckCreate()
        {
            if (this.tbShelterAddress.Text == "" || this.tbShelterEmail.Text == "" || this.tbShelterName.Text == "" || this.tbShelterPhone.Text == "")
            {
                this.btnConfirm.Enabled = false;
            }
            else
            {
                this.btnConfirm.Enabled = true;
            }
            
        }

        private void tbShelterName_TextChanged(object sender, EventArgs e)
        {
            this.CheckCreate();
        }

        private void tbShelterEmail_TextChanged(object sender, EventArgs e)
        {
            this.CheckCreate();
        }

        private void tbShelterPhone_TextChanged(object sender, EventArgs e)
        {
            this.CheckCreate();
        }

        private void tbShelterAddress_TextChanged(object sender, EventArgs e)
        {
            this.CheckCreate();
        }

        private void btnOpenShelter_Click(object sender, EventArgs e)
        {
            string fileName;
            FileStream fs;
            
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                try
                {
                    fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    IFormatter formatter = new BinaryFormatter();
                    this.shelter = (Shelter)formatter.Deserialize(fs);
                    fs.Close();
                    this.gbShelterDetails.Visible = false;
                    this.gbShelters.Visible = false;
                    this.gbManage.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void gbManage_VisibleChanged(object sender, EventArgs e)
        {
            if (this.gbManage.Visible && this.shelter != null)
            {
                this.lblDisplayShelterName.Text = this.shelter.GetShelterDetails();
            }
        }

        private void rbCat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbCat.Checked)
            {
                this.lblExtraInfo.Visible = true;
                this.tbExtraInfo.Text = "";
                this.tbExtraInfo.Visible = true;
            }
            else
            {
                this.lblExtraInfo.Visible = false;
                this.tbExtraInfo.Visible = false;
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            this.gbAddOwner.Visible = false;
            this.gbAddAnimal.Visible = true;
            this.dtpFoundDate.Value = DateTime.Now;
            this.tbLocation.Text = "";
            this.tbAddAnimalDescription.Text = "";
            this.tbRFID.Text = "";
            this.btnAddAnimal.Enabled = false;
            this.btnAddOwner.Enabled = true;
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.gbAddAnimal.Visible = false;
            this.btnAddAnimal.Enabled = true;
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (this.rbCat.Checked)
            {
                Cat newCat = new Cat(dtpFoundDate.Value, this.tbLocation.Text, this.tbAddAnimalDescription.Text, this.tbRFID.Text, this.tbExtraInfo.Text);
                check = shelter.AddAnimal(newCat);
            }
            else if (this.rbDog.Checked)
            {
                Dog newDog = new Dog(this.dtpFoundDate.Value, this.tbLocation.Text, this.tbAddAnimalDescription.Text, this.tbRFID.Text);
                check = shelter.AddAnimal(newDog);
            }

            if (check)
            {
                this.gbAddAnimal.Visible = false;
                MessageBox.Show("Added animal");
                this.btnAddAnimal.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to add animal");
            }
            
        }

        private void btnAddOwnerCancel_Click(object sender, EventArgs e)
        {
            this.gbAddOwner.Visible = false;
            this.btnAddOwner.Enabled = true;
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            this.gbAddAnimal.Visible = false;
            this.gbAddOwner.Visible = true;
            this.tbAddOwnerID.Text = "";
            this.tbAddOwnerName.Text = "";
            this.btnAddOwner.Enabled = false;
            this.btnAddAnimal.Enabled = true;
        }

        private void btnAddOwnerConfirm_Click(object sender, EventArgs e)
        {
            if (this.tbAddOwnerID.Text != "" && this.tbAddOwnerName.Text != "")
            {
                Owner newOwner = new Owner(this.tbAddOwnerID.Text, this.tbAddOwnerName.Text);
                bool check = this.shelter.AddOwner(newOwner);
                if (check)
                {
                    this.gbAddOwner.Visible = false;
                    this.btnAddOwner.Enabled = true;
                    MessageBox.Show("Added Owner");                    
                }
                else
                {
                    MessageBox.Show("Failed to add owner");
                }
                
            }
        }

        private void btnClaim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Claiming fees to pay: "+ ((Animal)this.lbOut2.SelectedItem).Claim(((Owner)this.lbOut.SelectedItem)));
        }

        private void btnCheckClaimable_Click(object sender, EventArgs e)
        {
            List<Animal> retList = new List<Animal>();
            retList = this.shelter.ListClaimable(((Owner)this.lbOut.SelectedItem));
            if (retList.Count > 0)
            {
                foreach (Animal a in retList)
                {
                    this.lbOut2.Items.Add(a);
                }
            }
            else this.lbOut2.Items.Add("This owner has no animals to claim");
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            if (this.lbOut.SelectedItem is Dog)
            {
                ((Dog)this.lbOut.SelectedItem).WalkDog();
                MessageBox.Show("Walked Dog");
            }
        }

        private void lbOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbOut.SelectedItem is Dog && this.rbAnimalsShelter.Checked)
            {
                this.lbOut2.Items.Clear();
                this.btnWalk.Enabled = true;

                this.btnCheckClaimable.Enabled = false;
                this.btnClaim.Enabled = false;
            }
            else if (this.lbOut.SelectedItem is Owner)
            {
                this.lbOut2.Items.Clear();
                this.btnCheckClaimable.Enabled = true;

                this.btnWalk.Enabled = false;
                this.btnClaim.Enabled = false;
            }
            else if (this.rbAdoptable.Checked && this.lbOut.SelectedItem is Animal)
            {
                this.lbOut2.Items.Clear();
                foreach (Owner o in this.shelter.ListOwner())
                {
                    this.lbOut2.Items.Add(o);
                }
            }
            else
            {
                this.btnWalk.Enabled = false;
                this.btnCheckClaimable.Enabled = false;
                this.btnClaim.Enabled = false;
                this.btnAdopt.Enabled = false;
            }
        }

        private void lbOut2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rbOwners.Checked && this.lbOut2.SelectedItem is Animal && ((Animal)this.lbOut2.SelectedItem).IsClaimable(((Owner)this.lbOut.SelectedItem)))
            {
                this.btnClaim.Enabled = true;
                this.btnAdopt.Enabled = false;
            }
            else if (this.rbAdoptable.Checked && this.lbOut.SelectedIndex >= 0 && this.lbOut2.SelectedIndex >=0 )
            {
                this.btnAdopt.Enabled = true;
            }
            else
            {
                this.btnClaim.Enabled = false;
                this.btnAdopt.Enabled = false;
            }
        }

        private void rbAnimalsShelter_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbAnimalsShelter.Checked)
            {
                this.lbOut.Items.Clear();
                foreach (Animal a in this.shelter.ListAnimalsInShelter())
                {
                    this.lbOut.Items.Add(a);
                }
            }            
        }

        private void rbAdoptable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbAdoptable.Checked)
            {
                this.lbOut.Items.Clear();
                foreach (Animal a in this.shelter.ListAdoptable())
                {
                    this.lbOut.Items.Add(a);
                }
            }
        }

        private void rbAnimals_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbAnimals.Checked)
            {
                this.lbOut.Items.Clear();
                foreach (Animal a in this.shelter.ListAnimals())
                {
                    this.lbOut.Items.Add(a);
                }
            }
        }

        private void rbOwners_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbOwners.Checked)
            {
                this.lbOut2.Items.Clear();
                this.lbOut.Items.Clear();
                foreach (Owner o in this.shelter.ListOwner())
                {
                    this.lbOut.Items.Add(o);
                }
            }
        }

        private void btnAdopt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adoption fees: " + ((Animal)this.lbOut.SelectedItem).Adopt(((Owner)this.lbOut2.SelectedItem)));
            this.btnAdopt.Enabled = false;
        }

        private void rbScanRFID_CheckedChanged(object sender, EventArgs e)
        {
            this.tbScanRFID.Visible = this.rbScanRFID.Checked;
        }

        private void btnSaveShelter_Click(object sender, EventArgs e)
        {
            string fileName;
            FileStream fs;
            IFormatter formatter;
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                try
                {
                    fs = new FileStream((this.shelter.getName() + ".sh"), FileMode.Create, FileAccess.Write);
                    formatter = new BinaryFormatter();
                    formatter.Serialize(fs, this.shelter);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
          
            }
        }
    }
}
