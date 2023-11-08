﻿using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Models;
using seguridad_barrios_privados.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seguridad_barrios_privados.Presentacion
{
    public partial class FormInformeMovimientos : Form
    {
        private UsuariosRepositorio usuariosRepositorio;
        private Validaciones validaciones;
        private SolicitudesRepositorio solicitudesRepositorio;
        private EgresosRepositorio egresosRepositorio;
        private IngresosRepositorio ingresosRepositorio;
        private VisitantesRepositorio visitantesRepositorio;
        //private List<Ingreso> ingresos;
        //private List<Solicitude> solicitudes;
        //private List<Egreso> egresos;
        private List<Movimiento> movimientos;
        private List<Movimiento> ListaMovimientos;
        private List<Movimiento> movimeintosBackUp;
        private string orden;
        public FormInformeMovimientos()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            egresosRepositorio = new EgresosRepositorio();
            ingresosRepositorio = new IngresosRepositorio();


            movimientos = egresosRepositorio.ObtenerMovimientos().Union(ingresosRepositorio.ObtenerMovimientos()).OrderByDescending(m => m.Fecha).ToList();
            ListaMovimientos = movimientos;
            movimeintosBackUp = ListaMovimientos;
            orden = "descendente";
            CargarMovimientos();
        }



        private void CargarMovimientos()
        {
            dgMovimientos.Rows.Clear();
            dgMovimientos.Refresh();

            foreach (Movimiento movimiento in ListaMovimientos)
            {
                dgMovimientos.Rows.Add(movimiento.TipoMovimiento, movimiento.NombreUsuario, movimiento.NombreVisitante, movimiento.DniVisitante, movimiento.Fecha);
            }
        }

        private void dtFechaMovimeintos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            movimientos = egresosRepositorio.ObtenerMovimientos().Union(ingresosRepositorio.ObtenerMovimientos()).OrderByDescending(m => m.Fecha).ToList();
            ListaMovimientos = movimientos;
            movimeintosBackUp = ListaMovimientos;
            CargarMovimientos();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            
            if(orden == "descendente")
            {
                orden = "ascendente";
                ListaMovimientos = ListaMovimientos.OrderBy(m => m.Fecha).ToList();
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowUpWideShort;
            }
            else
            {
                orden = "descendente";
                ListaMovimientos = ListaMovimientos.OrderByDescending(m => m.Fecha).ToList();
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowDownWideShort;
            }
            
            CargarMovimientos();
        }

        private void cbFiltrarMovimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Movimiento>? movimientosFiltrar = movimeintosBackUp;
            string tipoSeleccionado = cbFiltrarMovimientos.SelectedItem.ToString();
            if (tipoSeleccionado != "Tipo")
            {
                //que guarde en usuariosFiltrar todos los usuarios de usuariosFiltrar que tengan el rol seleccionado en el comboBox
                movimientosFiltrar = movimientosFiltrar?.Where(m => m.TipoMovimiento == tipoSeleccionado).ToList();
            }

            ListaMovimientos = movimientosFiltrar;
            movimientos = movimientosFiltrar;
            CargarMovimientos();
        }
    }
}
