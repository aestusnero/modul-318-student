using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace GUI
{
    public partial class Form1 : Form
    {
        Transport tp = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnK_Click(object sender, EventArgs e)
        {
            PV.Visible = false;
            KAG.Visible = true;
            STG.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVB_Click(object sender, EventArgs e)
        {
            PV.Visible = true;
            KAG.Visible = false;
            STG.Visible = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            PV.Visible = false;
            KAG.Visible = false;
            STG.Visible = true;
        }

        private void Schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            String old_from = txtVON.Text;
            txtVON.Text = txtNACH.Text;
            txtNACH.Text = old_from;//Umdrehung
        }

        private void txtVON_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSuche_Click(object sender, EventArgs e)
        {
            Connections connections = tp.GetConnections(txtVON.Text, txtNACH.Text);
            DGV.Rows.Clear();
            foreach (Connection connection in connections.ConnectionList)
            {

                DateTime departure = Convert.ToDateTime(connection.From.Departure);
                DateTime arrival = Convert.ToDateTime(connection.To.Arrival);

                TimeSpan duration = (arrival - departure);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DGV);
                row.Cells[0].Value = connection.From.Station.Name;
                row.Cells[1].Value = connection.To.Station.Name;
                row.Cells[2].Value = duration.ToString(@"hh\:mm");
                row.Cells[3].Value = departure;
                row.Cells[4].Value = arrival;
                row.Cells[5].Value = connection.From.Platform;
                DGV.Rows.Add(row);

                DGV.Columns[3].DefaultCellStyle.Format = "HH:mm";
                DGV.Columns[4].DefaultCellStyle.Format = "HH:mm";
            }
        }

        private void txtVON_DropDown(object sender, EventArgs e)
        {
            txtVON.Items.Clear();
            Stations stations = tp.GetStations(txtVON.Text);
            foreach (Station station in stations.StationList)
            {
                txtVON.Items.Add(station.Name);
            }
        }

        private void txtNACH_DropDown(object sender, EventArgs e)
        {
            txtNACH.Items.Clear();
            Stations stations = tp.GetStations(txtNACH.Text);
            foreach (Station station in stations.StationList)
            {
                txtNACH.Items.Add(station.Name);
            }
        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSS.Text))
                return;

            var stationen = tp.GetStations(txtSS.Text).StationList;
            if (stationen.Count == 0)
            {
                MessageBox.Show("Bitte geben Sie die gewünschte Station ein!", "Fehler");

            }

            else
            {
                string station_id = stationen[0].Id;

                var stations = tp.GetStationBoard(txtSS.Text, station_id).Entries;

                DGS.Rows.Clear();


                foreach (var station in stations)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DGS);
                    row.Cells[0].Value = station.Name;
                    row.Cells[1].Value = station.Stop.Departure;
                    row.Cells[2].Value = station.To;
                    DGS.Rows.Add(row);
                    DGS.Columns[1].DefaultCellStyle.Format = "HH:mm";
                }
            }
        }

        private void txtSS_DropDown(object sender, EventArgs e)
        {
            txtSS.Items.Clear(); 
            Stations stations = tp.GetStations(txtSS.Text);
            foreach (Station station in stations.StationList)
            {
                txtSS.Items.Add(station.Name);
            }
        }

        private void txtKA_DropDown(object sender, EventArgs e)
        {
            txtKA.Items.Clear();
            Stations stations = tp.GetStations(txtKA.Text);
            foreach (Station station in stations.StationList)
            {
                txtKA.Items.Add(station.Name);
            }
        }

        private void btnKG_Click(object sender, EventArgs e)
        {
            var stationList = tp.GetStations(txtKA.Text).StationList;
            if (stationList.Count > 0)
            {
                var coordinates = stationList[0].Coordinate;
                string googleUrl = "https://www.google.ch/maps/?q=loc:" + coordinates.XCoordinate + "+" + coordinates.YCoordinate;
                this.Karte.Navigate(googleUrl);
            }
        }
    }
}
