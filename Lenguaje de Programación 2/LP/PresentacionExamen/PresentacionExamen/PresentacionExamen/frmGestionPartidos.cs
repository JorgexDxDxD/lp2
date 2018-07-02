using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;

namespace PresentacionExamen
{
    public partial class frmGestionPartidos : Form
    {
        private GrupoBL logicaGrupo;
        private PartidoBL logicaPartido;
        private BindingList<Grupo> grupos;
        private BindingList<LogicaNegocios.PartidosWS.pais> paises;
        private BindingList<Bitmap> banderas;
        private BindingList<PosicionTabla> tabla;
        public frmGestionPartidos()
        {
            InitializeComponent();
            banderas = new BindingList<Bitmap>();
            banderas.Add(PresentacionExamen.Properties.Resources.RUSIA);
            banderas.Add(PresentacionExamen.Properties.Resources.ALEMANIA);
            banderas.Add(PresentacionExamen.Properties.Resources.BRASIL);
            banderas.Add(PresentacionExamen.Properties.Resources.PORTUGAL);
            banderas.Add(PresentacionExamen.Properties.Resources.ARGENTINA);
            banderas.Add(PresentacionExamen.Properties.Resources.BELGICA);
            banderas.Add(PresentacionExamen.Properties.Resources.POLONIA);
            banderas.Add(PresentacionExamen.Properties.Resources.FRANCIA);
            banderas.Add(PresentacionExamen.Properties.Resources.ESPAÑA);
            banderas.Add(PresentacionExamen.Properties.Resources.PERU);
            banderas.Add(PresentacionExamen.Properties.Resources.SUIZA);
            banderas.Add(PresentacionExamen.Properties.Resources.INGLATERRA);
            banderas.Add(PresentacionExamen.Properties.Resources.COLOMBIA);
            banderas.Add(PresentacionExamen.Properties.Resources.MEXICO);
            banderas.Add(PresentacionExamen.Properties.Resources.URUGUAY);
            banderas.Add(PresentacionExamen.Properties.Resources.CROACIA);
            banderas.Add(PresentacionExamen.Properties.Resources.DINAMARCA);
            banderas.Add(PresentacionExamen.Properties.Resources.ISLANDIA);
            banderas.Add(PresentacionExamen.Properties.Resources.COSTA_RICA);
            banderas.Add(PresentacionExamen.Properties.Resources.SUECIA);
            banderas.Add(PresentacionExamen.Properties.Resources.TUNEZ);
            banderas.Add(PresentacionExamen.Properties.Resources.EGIPTO);
            banderas.Add(PresentacionExamen.Properties.Resources.SENEGAL);
            banderas.Add(PresentacionExamen.Properties.Resources.IRAN);
            banderas.Add(PresentacionExamen.Properties.Resources.SERBIA);
            banderas.Add(PresentacionExamen.Properties.Resources.NIGERIA);
            banderas.Add(PresentacionExamen.Properties.Resources.AUSTRALIA);
            banderas.Add(PresentacionExamen.Properties.Resources.JAPON);
            banderas.Add(PresentacionExamen.Properties.Resources.MARRUECOS);
            banderas.Add(PresentacionExamen.Properties.Resources.PANAMA);
            banderas.Add(PresentacionExamen.Properties.Resources.COREA_DEL_SUR);
            banderas.Add(PresentacionExamen.Properties.Resources.ARABIA_SAUDI);

            logicaGrupo = new GrupoBL();
            logicaPartido = new PartidoBL();
            grupos = logicaGrupo.agruparPaises();
            paises = logicaGrupo.listar_Paises();
            logicaPartido.asignarPartidos(grupos);

            dgvPosiciones.Columns["PAIS"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            cboGrupos.DataSource = new BindingSource(grupos, null);
            cboGrupos.DisplayMember = "NombreGrupo";
            cboGrupos.DropDownStyle = ComboBoxStyle.DropDownList;

            //cboGrupos.ValueMember = "G";
            txtGolesE2P1.Enabled = false;
            txtGolesE1P1.Enabled = false;
            btnModificarP1.Enabled = true;
            btnGuardarP1.Enabled = false;

            txtGolesE2P2.Enabled = false;
            txtGolesE1P2.Enabled = false;
            btnModificarP2.Enabled = true;
            btnGuardarP2.Enabled = false;

            txtGolesE2P3.Enabled = false;
            txtGolesE1P3.Enabled = false;
            btnModificarP3.Enabled = true;
            btnGuardarP3.Enabled = false;

            txtGolesE2P4.Enabled = false;
            txtGolesE1P4.Enabled = false;
            btnModificarP4.Enabled = true;
            btnGuardarP4.Enabled = false;

            txtGolesE2P5.Enabled = false;
            txtGolesE1P5.Enabled = false;
            btnModificarP5.Enabled = true;
            btnGuardarP5.Enabled = false;

            txtGolesE2P6.Enabled = false;
            txtGolesE1P6.Enabled = false;
            btnModificarP6.Enabled = true;
            btnGuardarP6.Enabled = false;

            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            tabla = new BindingList<PosicionTabla>();
            foreach( LogicaNegocios.PartidosWS.pais p in grupos[cboGrupos.SelectedIndex].Paises)
            {
                PosicionTabla pos = new PosicionTabla(p, grupos[cboGrupos.SelectedIndex].Partidos);
                tabla.Add(pos);
            }
            List<PosicionTabla> sortedList = tabla.OrderByDescending((PosicionTabla X) => X.Ptos*1000+X.Dg*50+X.Gf).ToList();
            tabla = new BindingList<PosicionTabla>(sortedList);
            for (int i= 1;i<=tabla.Count;i++)
            {
                tabla[i-1].Pos = i;
            }

            dgvPosiciones.AutoGenerateColumns = false;
            dgvPosiciones.DataSource = tabla;
        }

        private int ordenarPorPuntos(PosicionTabla arg)
        {
            return arg.Ptos;
        }

        private void btnModificarP1_Click(object sender, EventArgs e)
        {
            txtGolesE2P1.Enabled = true;
            txtGolesE1P1.Enabled = true;
            btnGuardarP1.Enabled = true;
            btnModificarP1.Enabled = false;
        }

        private void btnGuardarP1_Click(object sender, EventArgs e)
        {
            try
            {
                logicaPartido.actualizarPartido(txtGolesE1P1.Text, txtGolesE2P1.Text, grupos[cboGrupos.SelectedIndex].Partidos[0]);
                actualizarListas();
                MessageBox.Show("Registro exitoso del partido");
                txtGolesE2P1.Enabled = false;
                txtGolesE1P1.Enabled = false;
                btnModificarP1.Enabled = true;
                btnGuardarP1.Enabled = false;
                ActualizarTabla();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void actualizarListas()
        {
            logicaPartido.asignarPartidos(grupos);
            BindingList<LogicaNegocios.PartidosWS.partido> partidos = grupos[cboGrupos.SelectedIndex].Partidos;

            int i = 0;
            
            if (partidos[i].JUGADO)
            {
                txtGolesE1P1.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P1.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP1.Enabled = true;
            }
            else
            {
                txtGolesE1P1.Text = "";
                txtGolesE2P1.Text = "";
                btnEliminarP1.Enabled = false;
            }

            i = 1;
            if (partidos[i].JUGADO)
            {
                txtGolesE1P2.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P2.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP2.Enabled = true;
            }
            else
            {
                txtGolesE1P2.Text = "";
                txtGolesE2P2.Text = "";
                btnEliminarP2.Enabled = false;
            }

            i = 2;
            if (partidos[i].JUGADO)
            {
                txtGolesE1P3.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P3.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP3.Enabled = true;
            }
            else
            {
                txtGolesE1P3.Text = "";
                txtGolesE2P3.Text = "";
                btnEliminarP3.Enabled = false;
            }

            i = 3;
            if (partidos[i].JUGADO)
            {
                txtGolesE1P4.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P4.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP4.Enabled = true;
            }
            else
            {
                txtGolesE1P4.Text = "";
                txtGolesE2P4.Text = "";
                btnEliminarP4.Enabled = false;
            }

            i = 4;
            if (partidos[i].JUGADO)
            {
                txtGolesE1P5.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P5.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP5.Enabled = true;
            }
            else
            {
                txtGolesE1P5.Text = "";
                txtGolesE2P5.Text = "";
                btnEliminarP5.Enabled = false;
            }

            i = 5;
            if (partidos[i].JUGADO)
            {
                txtGolesE1P6.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P6.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP6.Enabled = true;
            }
            else
            {
                txtGolesE1P6.Text = "";
                txtGolesE2P6.Text = "";
                btnEliminarP6.Enabled = false;
            }
            ActualizarTabla();
        }

        private void cboGrupos_SelectedValueChanged(object sender, EventArgs e)
        {            
            BindingList<LogicaNegocios.PartidosWS.partido> partidos = grupos[cboGrupos.SelectedIndex].Partidos;

            int i = 0;

            lblE1P1.Text = paises[partidos[i].EQUIPO_A - 1].NOMBRE;
            lblE2P1.Text = paises[partidos[i].EQUIPO_B - 1].NOMBRE;
            pboxE1P1.Image = banderas[partidos[i].EQUIPO_A - 1];
            pboxE2P1.Image = banderas[partidos[i].EQUIPO_B - 1];
            if (partidos[i].JUGADO)
            {
                txtGolesE1P1.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P1.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP1.Enabled = true;
            }
            else
            {
                txtGolesE1P1.Text = "";
                txtGolesE2P1.Text = "";
                btnEliminarP1.Enabled = false;
            }

            i =1;
            lblE1P2.Text = paises[partidos[i].EQUIPO_A - 1].NOMBRE;
            lblE2P2.Text = paises[partidos[i].EQUIPO_B - 1].NOMBRE;
            pboxE1P2.Image = banderas[partidos[i].EQUIPO_A - 1];
            pboxE2P2.Image = banderas[partidos[i].EQUIPO_B - 1];
            if (partidos[i].JUGADO)
            {
                txtGolesE1P2.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P2.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP2.Enabled = true;
            }
            else
            {
                txtGolesE1P2.Text = "";
                txtGolesE2P2.Text = "";
                btnEliminarP2.Enabled = false;
            }

            i = 2;
            lblE1P3.Text = paises[partidos[i].EQUIPO_A - 1].NOMBRE;
            lblE2P3.Text = paises[partidos[i].EQUIPO_B - 1].NOMBRE;
            pboxE1P3.Image = banderas[partidos[i].EQUIPO_A - 1];
            pboxE2P3.Image = banderas[partidos[i].EQUIPO_B - 1];
            if (partidos[i].JUGADO)
            {
                txtGolesE1P3.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P3.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP3.Enabled = true;
            }
            else
            {
                txtGolesE1P3.Text = "";
                txtGolesE2P3.Text = "";
                btnEliminarP3.Enabled = false;
            }

            i = 3;
            lblE1P4.Text = paises[partidos[i].EQUIPO_A - 1].NOMBRE;
            lblE2P4.Text = paises[partidos[i].EQUIPO_B - 1].NOMBRE;
            pboxE1P4.Image = banderas[partidos[i].EQUIPO_A - 1];
            pboxE2P4.Image = banderas[partidos[i].EQUIPO_B - 1];
            if (partidos[i].JUGADO)
            {
                txtGolesE1P4.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P4.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP4.Enabled = true;
            }
            else
            {
                txtGolesE1P4.Text = "";
                txtGolesE2P4.Text = "";
                btnEliminarP4.Enabled = false;
            }

            i = 4;
            lblE1P5.Text = paises[partidos[i].EQUIPO_A - 1].NOMBRE;
            lblE2P5.Text = paises[partidos[i].EQUIPO_B - 1].NOMBRE;
            pboxE1P5.Image = banderas[partidos[i].EQUIPO_A - 1];
            pboxE2P5.Image = banderas[partidos[i].EQUIPO_B - 1];
            if (partidos[i].JUGADO)
            {
                txtGolesE1P5.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P5.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP5.Enabled = true;
            }
            else
            {
                txtGolesE1P5.Text = "";
                txtGolesE2P5.Text = "";
                btnEliminarP5.Enabled = false;
            }

            i = 5;
            lblE1P6.Text = paises[partidos[i].EQUIPO_A - 1].NOMBRE;
            lblE2P6.Text = paises[partidos[i].EQUIPO_B - 1].NOMBRE;
            pboxE1P6.Image = banderas[partidos[i].EQUIPO_A - 1];
            pboxE2P6.Image = banderas[partidos[i].EQUIPO_B - 1];
            if (partidos[i].JUGADO)
            {
                txtGolesE1P6.Text = partidos[i].GOLES_EQUIPO_A.ToString();
                txtGolesE2P6.Text = partidos[i].GOLES_EQUIPO_B.ToString();
                btnEliminarP6.Enabled = true;
            }
            else
            {
                txtGolesE1P6.Text = "";
                txtGolesE2P6.Text = "";
                btnEliminarP6.Enabled = false;
            }
            ActualizarTabla();
        }

        private void btnModificarP2_Click(object sender, EventArgs e)
        {
            txtGolesE2P2.Enabled = true;
            txtGolesE1P2.Enabled = true;
            btnGuardarP2.Enabled = true;
            btnModificarP2.Enabled = false;
        }
        private void btnGuardarP2_Click(object sender, EventArgs e)
        {
            try
            {
                logicaPartido.actualizarPartido(txtGolesE1P2.Text, txtGolesE2P2.Text, grupos[cboGrupos.SelectedIndex].Partidos[1]);
                actualizarListas();
                MessageBox.Show("Registro exitoso del partido");
                txtGolesE2P2.Enabled = false;
                txtGolesE1P2.Enabled = false;
                btnModificarP2.Enabled = true;
                btnGuardarP2.Enabled = false;
                ActualizarTabla();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnModificarP3_Click(object sender, EventArgs e)
        {
            txtGolesE2P3.Enabled = true;
            txtGolesE1P3.Enabled = true;
            btnGuardarP3.Enabled = true;
            btnModificarP3.Enabled = false;
        }

        private void btnGuardarP3_Click(object sender, EventArgs e)
        {
            try
            {
                logicaPartido.actualizarPartido(txtGolesE1P3.Text, txtGolesE2P3.Text, grupos[cboGrupos.SelectedIndex].Partidos[2]);
                actualizarListas();
                MessageBox.Show("Registro exitoso del partido");
                txtGolesE2P3.Enabled = false;
                txtGolesE1P3.Enabled = false;
                btnModificarP3.Enabled = true;
                btnGuardarP3.Enabled = false;
                ActualizarTabla();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnModificarP4_Click(object sender, EventArgs e)
        {
            txtGolesE2P4.Enabled = true;
            txtGolesE1P4.Enabled = true;
            btnGuardarP4.Enabled = true;
            btnModificarP4.Enabled = false;
        }

        private void btnGuardarP4_Click(object sender, EventArgs e)
        {
            try
            {
                logicaPartido.actualizarPartido(txtGolesE1P4.Text, txtGolesE2P4.Text, grupos[cboGrupos.SelectedIndex].Partidos[3]);
                actualizarListas();
                MessageBox.Show("Registro exitoso del partido");
                txtGolesE2P4.Enabled = false;
                txtGolesE1P4.Enabled = false;
                btnModificarP4.Enabled = true;
                btnGuardarP4.Enabled = false;
                ActualizarTabla();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnModificarP5_Click(object sender, EventArgs e)
        {
            txtGolesE2P5.Enabled = true;
            txtGolesE1P5.Enabled = true;
            btnGuardarP5.Enabled = true;
            btnModificarP5.Enabled = false;
        }

        private void btnGuardarP5_Click(object sender, EventArgs e)
        {
            try
            {
                logicaPartido.actualizarPartido(txtGolesE1P5.Text, txtGolesE2P5.Text, grupos[cboGrupos.SelectedIndex].Partidos[4]);
                actualizarListas();
                MessageBox.Show("Registro exitoso del partido");
                txtGolesE2P5.Enabled = false;
                txtGolesE1P5.Enabled = false;
                btnModificarP5.Enabled = true;
                btnGuardarP5.Enabled = false;
                ActualizarTabla();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnModificarP6_Click(object sender, EventArgs e)
        {
            txtGolesE2P6.Enabled = true;
            txtGolesE1P6.Enabled = true;
            btnGuardarP6.Enabled = true;
            btnModificarP6.Enabled = false;
        }

        private void btnGuardarP6_Click(object sender, EventArgs e)
        {
            try
            {
                logicaPartido.actualizarPartido(txtGolesE1P6.Text, txtGolesE2P6.Text, grupos[cboGrupos.SelectedIndex].Partidos[5]);
                actualizarListas();
                MessageBox.Show("Registro exitoso del partido");
                txtGolesE2P6.Enabled = false;
                txtGolesE1P6.Enabled = false;
                btnModificarP6.Enabled = true;
                btnGuardarP6.Enabled = false;
                ActualizarTabla();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarP1_Click(object sender, EventArgs e)
        {
            if (btnGuardarP1.Enabled == true)
            {
                actualizarListas();
                btnGuardarP1.Enabled = false;
                txtGolesE2P1.Enabled = false;
                txtGolesE1P1.Enabled = false;
                btnModificarP1.Enabled = true;
            }
            else
            {
                try
                {
                    logicaPartido.eliminar(grupos[cboGrupos.SelectedIndex].Partidos[0]);
                    actualizarListas();
                    ActualizarTabla();
                    MessageBox.Show("Eliminación exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminarP2_Click(object sender, EventArgs e)
        {

            if (btnGuardarP2.Enabled == true)
            {
                actualizarListas();
                btnGuardarP2.Enabled = false;
                txtGolesE2P2.Enabled = false;
                txtGolesE1P2.Enabled = false;
                btnModificarP2.Enabled = true;
            }
            else
            {
                try
                {
                    logicaPartido.eliminar(grupos[cboGrupos.SelectedIndex].Partidos[1]);
                    actualizarListas();
                    ActualizarTabla();
                    MessageBox.Show("Eliminación exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminarP3_Click(object sender, EventArgs e)
        {

            if (btnGuardarP1.Enabled == true)
            {
                actualizarListas();
                btnGuardarP3.Enabled = false;
                txtGolesE2P3.Enabled = false;
                txtGolesE1P3.Enabled = false;
                btnModificarP3.Enabled = true;
            }
            else
            {
                try
                {
                    logicaPartido.eliminar(grupos[cboGrupos.SelectedIndex].Partidos[2]);
                    actualizarListas();
                    ActualizarTabla();
                    MessageBox.Show("Eliminación exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminarP4_Click(object sender, EventArgs e)
        {

            if (btnGuardarP1.Enabled == true)
            {
                actualizarListas();
                btnGuardarP4.Enabled = false;
                txtGolesE2P4.Enabled = false;
                txtGolesE1P4.Enabled = false;
                btnModificarP4.Enabled = true;
            }
            else
            {
                try
                {
                    logicaPartido.eliminar(grupos[cboGrupos.SelectedIndex].Partidos[3]);
                    actualizarListas();
                    ActualizarTabla();
                    MessageBox.Show("Eliminación exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminarP5_Click(object sender, EventArgs e)
        {

            if (btnGuardarP1.Enabled == true)
            {
                actualizarListas();
                btnGuardarP5.Enabled = false;
                txtGolesE2P5.Enabled = false;
                txtGolesE1P5.Enabled = false;
                btnModificarP5.Enabled = true;
            }
            else
            {
                try
                {
                    logicaPartido.eliminar(grupos[cboGrupos.SelectedIndex].Partidos[4]);
                    actualizarListas();
                    ActualizarTabla();
                    MessageBox.Show("Eliminación exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminarP6_Click(object sender, EventArgs e)
        {

            if (btnGuardarP1.Enabled == true)
            {
                actualizarListas();
                btnGuardarP6.Enabled = false;
                txtGolesE2P6.Enabled = false;
                txtGolesE1P6.Enabled = false;
                btnModificarP6.Enabled = true;
            }
            else
            {
                try
                {
                    logicaPartido.eliminar(grupos[cboGrupos.SelectedIndex].Partidos[5]);
                    actualizarListas();
                    ActualizarTabla();
                    MessageBox.Show("Eliminación exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
