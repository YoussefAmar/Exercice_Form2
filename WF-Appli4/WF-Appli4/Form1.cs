using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Appli4
{
    public partial class Form1 : Form
    {
        //constructeur
        public Form1()
        {
            InitializeComponent();
        }
        //attributs

        Animal bilou, popov, choupette, caroline, dartagnan;

        ArrayList alAnimal = new ArrayList();

        int nbelement;

        int valIncr = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            bilou = new Animal(15, "bilou", "cobaye", 3, 1400);

            popov = new Animal(18, "popov", "chat", 4, 2000);

            choupette = new Animal(12, "choupette", "lapin", 6, 3000);

            caroline = new Animal(9, "caroline", "peruche", 2, 1000);

            dartagnan = new Animal(3, "dartagnan", "tortue", 4, 4000);

            alAnimal.Add(bilou);

            alAnimal.Add(popov);

            alAnimal.Add(choupette);

            alAnimal.Add(caroline);

            alAnimal.Add(dartagnan);
            textBox5.Text = valIncr.ToString();

        }

        private void bRemplirCb2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            nbelement = alAnimal.Count;

            for(int i = 0; i < nbelement; i++)
            {
                //Je recupére l'animal dans l'array list et le place dans la combobox
                comboBox2.Items.Add(alAnimal[i].ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //recup index
            textBox3.Text = "Index = " + comboBox2.SelectedIndex.ToString();
            //recup info combo box
            textBox4.Text = "Info animal = " + comboBox2.SelectedItem.ToString();
            //recup autres infos
            Animal AnimalTemp = (Animal)alAnimal[comboBox2.SelectedIndex];
            textBox6.Text = AnimalTemp.age + " - " + AnimalTemp.poids;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recupération de l'index selectionnet - index commence à 0
            //MessageBox.Show(comboBox1.SelectedIndex.ToString());
            textBox1.Text = ("Index choisi : " + comboBox1.SelectedIndex.ToString());
            textBox2.Text = ("Infos : " + comboBox1.Text);
        }

      
        private void bActive_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        private void bDesactive_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void bAjoute_Click(object sender, EventArgs e)
        {
            valIncr++;

            textBox5.Text = valIncr.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            valIncr++;

            textBox5.Text = valIncr.ToString();
        }

        private void bVitesse_Click(object sender, EventArgs e)
        {
            timer1.Interval -= 500;
        }

    }
}
