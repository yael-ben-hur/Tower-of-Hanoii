using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int l, g, size, i=0, t=0;
        int []tower;
        int[] moveto;
        int[] whereisthetowerpart;
        Panel [] towerpic;
        int sizex=300, sizey=54, locationx=61, locationy=520, subfromsize, savelx, savely, checkwhere, whichpart, height;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Image player = Properties.Resources.תמונה7;
        private void SolveHanoi(int n)
        {
            SolveHanoi(1, 2, 3, n);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 0)
                return;
            else
            {
                height = 0;
                if (t<moveto.Length&& moveto[t]==1)
                {
                    checkwhere = moveto[t];
                    for (int p = whereisthetowerpart.Length-2; p>-1; p=p-2)
                    {
                        if (whereisthetowerpart[p]==checkwhere)
                        {
                            whichpart = whereisthetowerpart[p + 1];
                            whereisthetowerpart[p] = moveto[t + 1];
                            break;
                        }
                    }
                    t++;
                    if (moveto[t]==3)
                    {
                        locationx = savelx + (subfromsize / 2) * whichpart + 759;
                        for (int p = 0; p<whichpart*2; p=p+2)
                        {
                          if (whereisthetowerpart[p]==moveto[t])
                            {
                                height++;
                            }
                        }
                        locationy = savely - sizey * height;
                        if (whichpart<towerpic.Length)
                        {
                            towerpic[whichpart].Location = new Point(locationx, locationy);
                        }
                        t++;
                        if (t == moveto.Length)
                            this.Controls.Remove(button2);
                        return;
                    }
                    if (moveto[t] == 2)
                    {
                        locationx = savelx + (subfromsize / 2) * whichpart + 380;
                        for (int p = 0; p < whichpart * 2; p = p + 2)
                        {
                            if (whereisthetowerpart[p] == moveto[t])
                            {
                                height++;
                            }
                        }
                        locationy = savely - sizey * height;
                        if (whichpart < towerpic.Length)
                        {
                            towerpic[whichpart].Location = new Point(locationx, locationy);
                        }
                        t++;
                        if (t == moveto.Length)
                            this.Controls.Remove(button2);
                        return;
                    }
                }
                if (t < moveto.Length && moveto[t] == 2)
                {
                    checkwhere = moveto[t];
                    for (int p = whereisthetowerpart.Length - 2; p > -1; p = p - 2)
                    {
                        if (whereisthetowerpart[p] == checkwhere)
                        {
                            whichpart = whereisthetowerpart[p + 1];
                            whereisthetowerpart[p] = moveto[t + 1];
                            break;
                        }
                    }
                    t++;
                    if (moveto[t] == 3)
                    {
                        locationx = savelx + (subfromsize / 2) * whichpart + 759;
                        for (int p = 0; p < whichpart * 2; p = p + 2)
                        {
                            if (whereisthetowerpart[p] == moveto[t])
                            {
                                height++;
                            }
                        }
                        locationy = savely - sizey * height;
                        if (whichpart < towerpic.Length)
                        {
                            towerpic[whichpart].Location = new Point(locationx, locationy);
                        }
                        t++;
                        if (t == moveto.Length)
                            this.Controls.Remove(button2);
                        return;
                    }
                    if (moveto[t] == 1)
                    {
                        locationx = savelx + (subfromsize / 2) * whichpart ;
                        for (int p = 0; p < whichpart * 2; p = p + 2)
                        {
                            if (whereisthetowerpart[p] == moveto[t])
                            {
                                height++;
                            }
                        }
                        locationy = savely - sizey * height;
                        if (whichpart < towerpic.Length)
                        {
                            towerpic[whichpart].Location = new Point(locationx, locationy);
                        }
                        t++;
                        if (t == moveto.Length)
                            this.Controls.Remove(button2);
                        return;
                    }
                }
                if (t < moveto.Length && moveto[t] == 3)
                {
                    checkwhere = moveto[t];
                    for (int p = whereisthetowerpart.Length - 2; p > -1; p = p - 2)
                    {
                        if (whereisthetowerpart[p] == checkwhere)
                        {
                            whichpart = whereisthetowerpart[p + 1];
                            whereisthetowerpart[p] = moveto[t + 1];
                            break;
                        }
                    }
                    t++;
                    if (moveto[t] == 2)
                    {
                        locationx = savelx + (subfromsize / 2) * whichpart +380;
                        for (int p = 0; p < whichpart * 2; p = p + 2)
                        {
                            if (whereisthetowerpart[p] == moveto[t])
                            {
                                height++;
                            }
                        }
                        locationy = savely - sizey * height;
                        if (whichpart < towerpic.Length)
                        {
                            towerpic[whichpart].Location = new Point(locationx, locationy);
                        }
                        t++;
                          if (t == moveto.Length)
                            this.Controls.Remove(button2);
                        return;
                    }
                    if (moveto[t] == 1)
                    {
                        locationx = savelx + (subfromsize / 2) * whichpart;
                        for (int p = 0; p < whichpart * 2; p = p + 2)
                        {
                            if (whereisthetowerpart[p] == moveto[t])
                            {
                                height++;
                            }
                        }
                        locationy = savely - sizey * height;
                        if (whichpart < towerpic.Length)
                        {
                            towerpic[whichpart].Location = new Point(locationx, locationy);
                        }
                        t++;
                        if (t == moveto.Length)
                            this.Controls.Remove(button2);
                        return;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowIntBoard(int[] a)
        {
            string s = "";
            int i;
            for (i = 0; i < a.Length; i++)
            {
                s = s + a[i].ToString() + "\t";
            }
            MessageBox.Show(s);
        }
        private void SolveHanoi(int a, int b, int c, int n)
        {
            if (n == 1)
            {

                Array.Resize(ref moveto, moveto.Length + 2);
                moveto[i] = a;
                moveto[i + 1] = c;
                i = i + 2;
            }
            else
            {
                SolveHanoi(a, c, b, n - 1);
                Array.Resize(ref moveto, moveto.Length + 2);
                moveto[i] = a;
                moveto[i + 1] = c;
                i = i + 2;
                SolveHanoi(b, a, c, n - 1);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string t = textBox1.Text;
                l = int.Parse(t);
            }
            catch
            {

            }
            if (l > 2 && l < 10)
            {
                g++;
                if (g == 1)
                {
                    try
                    {
                        string s = textBox1.Text;
                        size = int.Parse(s);
                        tower = new int[size];
                        towerpic = new Panel [size];
                        whereisthetowerpart = new int[size * 2];
                        savelx = locationx;
                        savely = locationy;
                        subfromsize = (sizex - 50) / size;                        
                        int num = 0;
                        for (int p  = 0, o=0; p < size; p++, sizex =sizex-subfromsize, locationy=locationy-sizey, locationx=locationx+(subfromsize/2),num++)
                        {
                            whereisthetowerpart[o] = 1;
                            o++;
                            whereisthetowerpart[o] = num;
                            o++;
                            towerpic[p] = new Panel();
                            towerpic[p].Size = new Size(sizex,sizey );
                            towerpic[p].Location = new Point(locationx, locationy);
                            towerpic[p].BackColor = Color.Transparent;
                            towerpic[p].BackgroundImage = player;
                            towerpic[p].BackgroundImageLayout = ImageLayout.Stretch;
                            this.Controls.Add(towerpic[p]);
                        }
                        moveto = new int[i]; 
                        SolveHanoi(size);
                        this.Controls.Remove(textBox1);
                        this.Controls.Remove(button1);
                    }
                    catch
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }     
        }
    }
}
