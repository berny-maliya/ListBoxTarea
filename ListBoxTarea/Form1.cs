using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxTarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //boton que añade elemento escrito metodo generico
        public void cambiarUnElemento(ListBox objeto1, ListBox objeto2)
        {
            if (objeto1.SelectedIndex != -1)
            {
                objeto2.Items.Add((string)objeto1.Items[objeto1.SelectedIndex]);
                objeto1.Items.RemoveAt(objeto1.SelectedIndex);
            }
        }
        //cambiar todo
        public void cambiarTodo(ListBox objeto1, ListBox objeto2)
        {
           
            
                for (int i = objeto1.Items.Count - 1; i >= 0; i--)
                {
                    objeto2.Items.Add(objeto1.Items[i]);
                    objeto1.Items.Remove(objeto1.Items[i]);

                    objeto1.Refresh();
                    objeto2.Refresh();
                }
            
        }
        private void button1_Click(object sender, EventArgs e)
            {
                lista1.Items.Add(textBox1.Text);
            }
            //boton que quita elemento de la primera lista y lo pasa a la otra
            private void button2_Click(object sender, EventArgs e)
            {
           
            cambiarUnElemento(lista1, lista2);

            }

        private void button3_Click(object sender, EventArgs e)
        {
            cambiarUnElemento(lista2, lista1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cambiarTodo(lista1,lista2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cambiarTodo(lista2, lista1);
        }
    }
    } 


