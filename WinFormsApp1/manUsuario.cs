﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvUsuarios2.Rows.Add(
                txtDni.Text,
                txtNombre.Text,
                txtApellido.Text,
                txtTelefono.Text,
                txtEmail.Text,
                dtFechaNacimiento.Text,
                txtDireccion.Text
            );
        }
    }
}
