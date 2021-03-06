﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmConsultaLibros : Form
    {
        public FrmConsultaLibros()
        {
            InitializeComponent();
        }

        private void RbAutor_CheckedChanged(object sender, EventArgs e)
        {
            LsbAutorEditorial.Items.Clear();
            foreach (Libro l in FrmInicio.libros)
            {
                LsbAutorEditorial.Items.Add(l.getAutor());
            }
            LsbAutorEditorial.Sorted = true;
        }

        private void RbEditorial_CheckedChanged(object sender, EventArgs e)
        {
            LsbAutorEditorial.Items.Clear();
            foreach (Libro l in FrmInicio.libros)
            {
                LsbAutorEditorial.Items.Add(l.getEditorial());
            }
            LsbAutorEditorial.Sorted = true;
        }

        private void LsbAutorEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp;
            temp = LsbAutorEditorial.SelectedItem.ToString();
            LsbTitulo.Items.Clear();
            foreach (Libro libro in FrmInicio.libros)
            {
                if (RbEditorial.Checked == true)
                {
                    if (temp == libro.getEditorial())
                    {
                        LsbTitulo.Items.Add(libro.getTitulo());
                    }
                }
                else
                {
                    if (temp == libro.getAutor())
                    {
                        LsbTitulo.Items.Add(libro.getTitulo());
                    }
                }
                
            }
            LsbTitulo.Sorted = true;
        }

        private void LsbTitulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String temp;
            temp = LsbTitulo.SelectedItem.ToString();

            foreach (Libro libro in FrmInicio.libros)
            {

                if (temp == libro.getTitulo())
                {
                    PicFotoLibro.Image = null;
                    try {
                        Bitmap imagen = new Bitmap(libro.getFoto());
                        PicFotoLibro.Image = imagen;
                    }catch ( ArgumentException ex)
                    {
                        MessageBox.Show("Imagen no encontrada");
                    }
                }
            }
        }

    }
}
