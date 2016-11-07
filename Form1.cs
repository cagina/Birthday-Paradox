using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication4
{    
   
    public partial class Form1 : Form
    {
        int max_kisi=0,sayaç_deneme=0,list_box_sayaci=0,KONTROL_SAYACİ=0;
        int[,] ana_doğum_günleri = new int[12,31];
        string[] ay_isimleri = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int min_ay = 0;
        int max_ay = 12;
            
         
       
       
        public Form1()
        {
            InitializeComponent();
        }
       
     
              private void button1_Click(object sender, EventArgs e)
        {
            ++sayaç_deneme;
            if (KONTROL_SAYACİ == 1)
            max_ay = 3;
            if (KONTROL_SAYACİ == 2)
            {
                min_ay = 3;
                max_ay = 6;
            }
            if (KONTROL_SAYACİ == 3)
            {
                min_ay = 6;
                max_ay = 9;
            }
            if (KONTROL_SAYACİ == 4)
            {
                min_ay = 9;
                max_ay = 12;
            }
            int[][] dogumgünleri = new int[12][];
            dogumgünleri[0] = new int[31];
            dogumgünleri[1] = new int[29];
            dogumgünleri[2] = new int[31];
            dogumgünleri[3] = new int[30];
            dogumgünleri[4] = new int[31];
            dogumgünleri[5] = new int[30];
            dogumgünleri[6] = new int[31];
            dogumgünleri[7] = new int[31];
            dogumgünleri[8] = new int[30];
            dogumgünleri[9] = new int[31];
            dogumgünleri[10] = new int[30];
            dogumgünleri[11] = new int[31];
            listBox1.Items.Add("  ");
            listBox1.Items.Add("\t\t\t\t\t    " + sayaç_deneme + ". Experiment  ");
            listBox1.Items.Add("  ");
            Random aylar,günler; 
            aylar  = new Random(DateTime.Now.Second-10000);
            günler = new Random(DateTime.Now.Second+10000);
         
           for (int kisiler = 0; kisiler < max_kisi; kisiler++)
            {

                int ay = aylar.Next(min_ay,max_ay);
                int gün = günler.Next((int)dogumgünleri[ay].Length) ;
                ++dogumgünleri[ay][gün];
                
            }
           listBox1.Items.Add("                  1  2  3  4  5  6  7  8  9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30  31");
           listBox1.Items.Add("                  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- ");
           int toplam_çakisma = 0, satir_sayaci = -1, gunler_sayaci = 0, aktarma_sayaci = -1;
           for (int i = 0; i < 12;i++ )
           {
               gunler_sayaci=dogumgünleri[i].Length;
               for (int j = 0; j < gunler_sayaci; j++)
               {
                   if (dogumgünleri[i][j] > 1)
                       ++toplam_çakisma;
               }
                   if (gunler_sayaci == 31 && ay_isimleri[i].Length < 8)
                       listBox1.Items.Add("" + ay_isimleri[i] + "\t   " + dogumgünleri[i][0] + "  " + dogumgünleri[i][1] + "  " + dogumgünleri[i][2] + "  " + dogumgünleri[i][3] + "  " + dogumgünleri[i][4] + "  " + dogumgünleri[i][5] + "  " + dogumgünleri[i][6] + "  " + dogumgünleri[i][7] + "  " + dogumgünleri[i][8] + "   " + dogumgünleri[i][9] + "    " + dogumgünleri[i][10] + "    " + dogumgünleri[i][11] + "    " + dogumgünleri[i][12] + "    " + dogumgünleri[i][13] + "    " + dogumgünleri[i][14] + "    " + dogumgünleri[i][15] + "    " + dogumgünleri[i][16] + "    " + dogumgünleri[i][17] + "    " + dogumgünleri[i][18] + "    " + dogumgünleri[i][19] + "    " + dogumgünleri[i][20] + "    " + dogumgünleri[i][21] + "    " + dogumgünleri[i][22] + "    " + dogumgünleri[i][23] + "    " + dogumgünleri[i][24] + "    " + dogumgünleri[i][25] + "    " + dogumgünleri[i][26] + "    " + dogumgünleri[i][27] + "    " + dogumgünleri[i][28] + "    " + dogumgünleri[i][29] + "    " + dogumgünleri[i][30]);
                   else if (gunler_sayaci == 30 && ay_isimleri[i].Length < 8)
                       listBox1.Items.Add("" + ay_isimleri[i] + "\t   " + dogumgünleri[i][0] + "  " + dogumgünleri[i][1] + "  " + dogumgünleri[i][2] + "  " + dogumgünleri[i][3] + "  " + dogumgünleri[i][4] + "  " + dogumgünleri[i][5] + "  " + dogumgünleri[i][6] + "  " + dogumgünleri[i][7] + "  " + dogumgünleri[i][8] + "   " + dogumgünleri[i][9] + "    " + dogumgünleri[i][10] + "    " + dogumgünleri[i][11] + "    " + dogumgünleri[i][12] + "    " + dogumgünleri[i][13] + "    " + dogumgünleri[i][14] + "    " + dogumgünleri[i][15] + "    " + dogumgünleri[i][16] + "    " + dogumgünleri[i][17] + "    " + dogumgünleri[i][18] + "    " + dogumgünleri[i][19] + "    " + dogumgünleri[i][20] + "    " + dogumgünleri[i][21] + "    " + dogumgünleri[i][22] + "    " + dogumgünleri[i][23] + "    " + dogumgünleri[i][24] + "    " + dogumgünleri[i][25] + "    " + dogumgünleri[i][26] + "    " + dogumgünleri[i][27] + "    " + dogumgünleri[i][28] + "    " + dogumgünleri[i][29]);
               if(gunler_sayaci ==29 && ay_isimleri[i].Length<8)
               listBox1.Items.Add("" + ay_isimleri[i] + "\t   " + dogumgünleri[i][0] + "  " + dogumgünleri[i][1] + "  " + dogumgünleri[i][2] + "  " + dogumgünleri[i][3] + "  " + dogumgünleri[i][4] + "  " + dogumgünleri[i][5] + "  " + dogumgünleri[i][6] + "  " + dogumgünleri[i][7] + "  " + dogumgünleri[i][8] + "   " + dogumgünleri[i][9] + "    " + dogumgünleri[i][10] + "    " + dogumgünleri[i][11] + "    " + dogumgünleri[i][12] + "    " + dogumgünleri[i][13] + "    " + dogumgünleri[i][14] + "    " + dogumgünleri[i][15] + "    " + dogumgünleri[i][16] + "    " + dogumgünleri[i][17] + "    " + dogumgünleri[i][18] + "    " + dogumgünleri[i][19] + "    " + dogumgünleri[i][20] + "    " + dogumgünleri[i][21] + "    " + dogumgünleri[i][22] + "    " + dogumgünleri[i][23] + "    " + dogumgünleri[i][24] + "    " + dogumgünleri[i][25] + "    " + dogumgünleri[i][26] + "    " + dogumgünleri[i][27] + "    " + dogumgünleri[i][28]);
               else if(gunler_sayaci ==30 && ay_isimleri[i].Length>8)
                   listBox1.Items.Add("" + ay_isimleri[i] + " " + dogumgünleri[i][0] + "  " + dogumgünleri[i][1] + "  " + dogumgünleri[i][2] + "  " + dogumgünleri[i][3] + "  " + dogumgünleri[i][4] + "  " + dogumgünleri[i][5] + "  " + dogumgünleri[i][6] + "  " + dogumgünleri[i][7] + "  " + dogumgünleri[i][8] + "   " + dogumgünleri[i][9] + "    " + dogumgünleri[i][10] + "    " + dogumgünleri[i][11] + "    " + dogumgünleri[i][12] + "    " + dogumgünleri[i][13] + "    " + dogumgünleri[i][14] + "    " + dogumgünleri[i][15] + "    " + dogumgünleri[i][16] + "    " + dogumgünleri[i][17] + "    " + dogumgünleri[i][18] + "    " + dogumgünleri[i][19] + "    " + dogumgünleri[i][20] + "    " + dogumgünleri[i][21] + "    " + dogumgünleri[i][22] + "    " + dogumgünleri[i][23] + "    " + dogumgünleri[i][24] + "    " + dogumgünleri[i][25] + "    " + dogumgünleri[i][26] + "    " + dogumgünleri[i][27] + "    " + dogumgünleri[i][28] + "    " + dogumgünleri[i][29]);
               if(gunler_sayaci ==30 && ay_isimleri[i].Length==8)
                   listBox1.Items.Add("" + ay_isimleri[i] + "  " + dogumgünleri[i][0] + "  " + dogumgünleri[i][1] + "  " + dogumgünleri[i][2] + "  " + dogumgünleri[i][3] + "  " + dogumgünleri[i][4] + "  " + dogumgünleri[i][5] + "  " + dogumgünleri[i][6] + "  " + dogumgünleri[i][7] + "  " + dogumgünleri[i][8] + "   " + dogumgünleri[i][9] + "    " + dogumgünleri[i][10] + "    " + dogumgünleri[i][11] + "    " + dogumgünleri[i][12] + "    " + dogumgünleri[i][13] + "    " + dogumgünleri[i][14] + "    " + dogumgünleri[i][15] + "    " + dogumgünleri[i][16] + "    " + dogumgünleri[i][17] + "    " + dogumgünleri[i][18] + "    " + dogumgünleri[i][19] + "    " + dogumgünleri[i][20] + "    " + dogumgünleri[i][21] + "    " + dogumgünleri[i][22] + "    " + dogumgünleri[i][23] + "    " + dogumgünleri[i][24] + "    " + dogumgünleri[i][25] + "    " + dogumgünleri[i][26] + "    " + dogumgünleri[i][27] + "    " + dogumgünleri[i][28] + "    " + dogumgünleri[i][29]);
               if (gunler_sayaci == 31 && ay_isimleri[i].Length >= 8)
                   listBox1.Items.Add("" + ay_isimleri[i] + "  " + dogumgünleri[i][0] + "  " + dogumgünleri[i][1] + "  " + dogumgünleri[i][2] + "  " + dogumgünleri[i][3] + "  " + dogumgünleri[i][4] + "  " + dogumgünleri[i][5] + "  " + dogumgünleri[i][6] + "  " + dogumgünleri[i][7] + "  " + dogumgünleri[i][8] + "   " + dogumgünleri[i][9] + "    " + dogumgünleri[i][10] + "    " + dogumgünleri[i][11] + "    " + dogumgünleri[i][12] + "    " + dogumgünleri[i][13] + "    " + dogumgünleri[i][14] + "    " + dogumgünleri[i][15] + "    " + dogumgünleri[i][16] + "    " + dogumgünleri[i][17] + "    " + dogumgünleri[i][18] + "    " + dogumgünleri[i][19] + "    " + dogumgünleri[i][20] + "    " + dogumgünleri[i][21] + "    " + dogumgünleri[i][22] + "    " + dogumgünleri[i][23] + "    " + dogumgünleri[i][24] + "    " + dogumgünleri[i][25] + "    " + dogumgünleri[i][26] + "    " + dogumgünleri[i][27] + "    " + dogumgünleri[i][28] + "    " + dogumgünleri[i][29] + "    " + dogumgünleri[i][30]);
               
           }
           listBox1.Items.Add("");
           listBox1.Items.Add("");
           listBox1.Items.Add(" Total mappings = "+toplam_çakisma);      
            satir_sayaci = -1; gunler_sayaci = -1; aktarma_sayaci = -1;
            foreach (var satir in dogumgünleri)
            {
                ++satir_sayaci;
                foreach (var gunler in satir)
                {
                    ++gunler_sayaci;
                    ++aktarma_sayaci;
                   
                    if (gunler > 1)
                    {
                        ana_doğum_günleri[satir_sayaci,aktarma_sayaci] += gunler;
                        listBox1.Items.Add("");
                        listBox1.Items.Add("");
                        listBox1.Items.Add("-->   " + (gunler_sayaci+1) + "   " + ay_isimleri[satir_sayaci] + "   " + (gunler-1) + " Match-up   <--");

                    }
                }
                gunler_sayaci = -1;
                aktarma_sayaci = -1;

            }
            int gecici = 0, ayın_yeri = 0, günün_yeri = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    if (i == 0 && j == 0)
                        gecici = ana_doğum_günleri[i, j];
                    if (gecici < ana_doğum_günleri[i, j])
                    {
                        ayın_yeri = i;
                        günün_yeri = j;
                        gecici = ana_doğum_günleri[i, j];
                    }


                }
            }
            this.chart1.Series["Max Match-up Day"].Points.AddXY("" + ay_isimleri[ayın_yeri] + " " + (günün_yeri + 1), (gecici - 1));
             

        }

              private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
              {
                  if (comboBox1.SelectedIndex == 0)
                  {
                      if (max_kisi != 0)
                      listBox1.Items.Clear();
                      max_kisi = 23 ;
                  }

                  if (comboBox1.SelectedIndex == 1)
                  {
                      if (max_kisi != 0)
                      listBox1.Items.Clear();
                      max_kisi = 100;
                  
                  }

                  if (comboBox1.SelectedIndex == 2)
                  {
                      if (max_kisi != 0)
                      listBox1.Items.Clear();
                      max_kisi = 500;
                  }
                  if (comboBox1.SelectedIndex == 3)
                  {
                      if (max_kisi != 0)
                          listBox1.Items.Clear();
                      max_kisi = 1000;
                  } 
              }

              private void button2_Click(object sender, EventArgs e)
              {
                  ++list_box_sayaci;
                  if (list_box_sayaci >1)
                  listBox2.Items.Clear();
                  listBox2.Items.Add("  ");
                  listBox2.Items.Add("      Match-Up Days                      Average");
                  listBox2.Items.Add("  --------------------------------           ------------------------------");
                  for (int i = 0; i < 12; i++)
                  {
                      for (int j = 0; j < 31; j++)
                      {
                          if (ana_doğum_günleri[i, j] > 1 && ay_isimleri[i].Length<8)
                              listBox2.Items.Add("            " + ay_isimleri[i] + " " + (j + 1) + "\t                         " + (double)(ana_doğum_günleri[i, j]-1) / sayaç_deneme);
                          else if (ana_doğum_günleri[i, j] > 1 && ay_isimleri[i].Length >= 8)
                              listBox2.Items.Add("            " + ay_isimleri[i] + " " + (j + 1) + "\t         " + (double)(ana_doğum_günleri[i, j] - 1) / sayaç_deneme);
                        
                         
                         }
                  }


              }

              private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
              {
                  if (comboBox2.SelectedIndex == 0)
                      KONTROL_SAYACİ = 1;
                  if (comboBox2.SelectedIndex == 1)
                      KONTROL_SAYACİ = 2;
                  if (comboBox2.SelectedIndex == 2)
                      KONTROL_SAYACİ = 3;
                  if (comboBox2.SelectedIndex == 3)
                      KONTROL_SAYACİ = 4;
              }

              
              

             

            

              

             

             
       
    }
}
