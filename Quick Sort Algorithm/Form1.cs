using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quick_Sort_Algorithm
{
    public partial class Form1 : Form
    {
        int k = 0; // Karşılaştırma anında dizinin ilk sıradaki elemanını geçici olarak tutacak.
        int n; // 0 ile 100 arasında oluşturulacak olan sayıyı tutacak.
        int m; // Dizinin uzunluğunu belirleyecek.
        int[] dizi1; // Sayıları tutacak olan dizimiz.

        int a;

        Random r = new Random();

        public void hızlısırala(int[] dizi, int x, int y)
        {
            if (x<y)
            {
                işlemyap(dizi, x, y);
                hızlısırala(dizi, x, a);
                hızlısırala(dizi, a+1, y);
            }
        }


        public void işlemyap(int[] dizi, int x, int y)
        {
            int b = dizi[x];
            int i = x - 1;
            int j = y + 1;

            while (true)
            {

                do
                {
                    j--;
                } while (dizi[j]>b);

                do
                {
                    i++;
                } while (dizi[i]<b);

                if (i<j)
                {
                    int geçici = dizi[i];
                    dizi[i] = dizi[j];
                    dizi[j] = geçici;
                }

                else
                {
                    a = j;
                    listBox4.Items.Clear();

                    foreach (int f in dizi)
                    {
                        listBox4.Items.Add(f);
                    }
                    break;
                }
            }
        }
     
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            m = int.Parse(textBox1.Text); // Dizinin uzunluğunu alıyoruz.
            dizi1 = new int[m]; // Boyutu atadık. 

            for (int i = 0; i < m; i++) // Diziye rastgele değerler atadık.
            {
                n = r.Next(0, 100);
                dizi1[i] = n;
            }
            textBox1.Clear(); // Textboxı temizledik.
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            foreach (int x in dizi1) // İlk oluşturulan dizinin karmaşık halini listbox1 e yazdırıyoruz.
            // Hangi sıralamadan düzeltildi dizi bunu görebilmek için.
            {
                listBox1.Items.Add(x);
            }

            hızlısırala(dizi1, 0, m - 1);
        }
    }
}
