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

namespace Leccion4._0
{
    public partial class Form2 : Form
    {
        List<Persona> listaPersonas = new List<Persona>();

        public Form2()
        {
            InitializeComponent();
            nuevaLista();
            actualizar();
        }
        public void nuevaLista()
        {
            listaPersonas.Add(new Persona("Marcelo", "Torres", 22));
            listaPersonas.Add(new Persona("Pablo", "Macias", 15));
        }
        public void actualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPersonas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona nuevaPersona = agregarPersona();
            listaPersonas.Add(nuevaPersona);
            actualizar();
        }

        private Persona agregarPersona()
        {
            string nombre = name.Text;
            string apellido = lastname.Text;
            int edad = int.Parse(age.Text);
            Persona persona = new Persona(nombre, apellido, edad);
            if (persona.esMayorDeEdad())
            {
                MessageBox.Show($"{persona.Nombre} {persona.Apellido} es mayor de edad.");
            }
            else
            {
                MessageBox.Show($"{persona.Nombre} {persona.Apellido} es menor de edad.");
            }
            return persona;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listaPersonas.Count > 0)
            {
                Persona personaEliminar = listaPersonas[listaPersonas.Count - 1];
                string infoPersona = personaEliminar.imprimirInfo();
                listaPersonas.RemoveAt(listaPersonas.Count - 1);

                string esMayorOMenor = personaEliminar.esMayorDeEdad() ? "Mayor de Edad" : "Menor de Edad";
                MessageBox.Show($"Se eliminó: {infoPersona}\nLa persona era {esMayorOMenor}.");
                actualizar();
            }
            else
            {
                MessageBox.Show("No hay personas para eliminar");
            }
        }
    }
}
