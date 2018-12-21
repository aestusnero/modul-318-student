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
using System.Net.Mail;

namespace GUI
{
    public partial class Form1 : Form
    {
        //definition tp
        Transport tp = new Transport();
        public Form1()
        {
            InitializeComponent();
        }
        //Seiten wechsel
        private void btnK_Click(object sender, EventArgs e)
        {
            PV.Visible = false;
            KAG.Visible = true;
            STG.Visible = false;
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
        // Schliessen
        private void Schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //VON-NACH wechsel
        private void btnReverse_Click(object sender, EventArgs e)
        {
            String old_from = txtVON.Text;
            txtVON.Text = txtNACH.Text;
            txtNACH.Text = old_from;//Umdrehung
        }

        //Verbindung Suchen
        private void btnSuche_Click(object sender, EventArgs e)
        {
            Connections connections = tp.GetConnections(txtVON.Text, txtNACH.Text, DATUM.Value.ToString(@"yyyy\-MM\-dd"), ZEIT.Value.ToString(@"HH\:mm"));
            DGV.Rows.Clear();//Connection definieren
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
            }//Grid anzeige
        }

        //Station suchen
        private void btnSS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSS.Text))
                return;

            var stationen = tp.GetStations(txtSS.Text).StationList;
            if (stationen.Count == 0)
            {
                MessageBox.Show("Fehler");
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
                }//Grid Station
            }
        }
        //Map anzeigen
        private void btnKG_Click(object sender, EventArgs e)
        {
            var stationList = tp.GetStations(txtKA.Text).StationList;
            if (stationList.Count > 0)
            {
                var coordinates = stationList[0].Coordinate;
                string googleUrl = "https://www.google.ch/maps/?q=loc:" + coordinates.XCoordinate + "+" + coordinates.YCoordinate;
                this.Karte.Navigate(googleUrl);//verbindung Google
            }
        }
        //Combobox VON
        private void txtVON_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var selectionStart = txtVON.SelectionStart;
                var selectionLength = txtVON.SelectedText.Length;
                txtVON.Items.Clear();
                txtVON.Select(selectionStart, selectionLength);
                txtVON.DroppedDown = true;//Dropdown Öffnen
                Stations stations = tp.GetStations(txtVON.Text);
                foreach (Station station in stations.StationList)
                {
                    txtVON.Items.Add(station.Name);
                }
            }
            catch (Exception)
            {

            }
        }
        //Combobox NACH
        private void txtNACH_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var selectionStart = txtNACH.SelectionStart;
                var selectionLength = txtNACH.SelectedText.Length;
                txtNACH.Items.Clear();
                txtNACH.Select(selectionStart, selectionLength);
                txtNACH.DroppedDown = true;//Dropdown Öffnen
                Stations stations = tp.GetStations(txtNACH.Text);
                foreach (Station station in stations.StationList)
                {
                    txtNACH.Items.Add(station.Name);
                }
            }
            catch (Exception)
            {

            }
        }
        //Combobox Station suche
        private void txtSS_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var selectionStart = txtSS.SelectionStart;
                var selectionLength = txtSS.SelectedText.Length;
                txtSS.Items.Clear();
                txtSS.Select(selectionStart, selectionLength);
                txtSS.DroppedDown = true;//Dropdown Öffnen
                Stations stations = tp.GetStations(txtSS.Text);
                foreach (Station station in stations.StationList)
                {
                    txtSS.Items.Add(station.Name);
                }
            }
            catch (Exception)
            {

            }
        }
        //Combobox Map suche
        private void txtKA_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var selectionStart = txtKA.SelectionStart;
                var selectionLength = txtKA.SelectedText.Length;
                txtKA.Items.Clear();
                txtKA.Select(selectionStart, selectionLength);
                txtKA.DroppedDown = true;//Dropdown Öffnen
                Stations stations = tp.GetStations(txtKA.Text);
                foreach (Station station in stations.StationList)
                {
                    txtKA.Items.Add(station.Name);
                }
            }
            catch (Exception)
            {

            }
        }
        // Mail Verbindung
        private void btnMAIL_Click(object sender, EventArgs e)
        {
            if (txtMAIL.Text == "")
                MessageBox.Show("Bitte geben Sie eine Email-Adresse ein!");
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("projecterik233@gmail.com");
                    mail.To.Add(new MailAddress(Convert.ToString(this.txtMAIL)));
                    mail.Subject = "Fahrplan";
                    mail.Body = "Hallo, hier ein Fahrplan, den ich mit dir teilen wollte. ";
                    mail.Body += "<b>" + Get_TableFromDataGrid() + "</b>";
                    mail.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("projecterik233.@gmail.com", "project233");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email wurde erfolgreich gesendet");
                }//Mail body
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //Map Funktion 1
        public string Get_TableFromDataGrid()
        {
            StringBuilder strTable = new StringBuilder();
            try
            {
                strTable.Append(("<table border='1 cellpadding='0' cellspacing='0'>"));
                strTable.Append("<tr>");
                foreach (DataGridViewColumn col in DGV.Columns)
                {

                    strTable.AppendFormat("<th>{0}</td>", col.HeaderText);
                }

                strTable.Append("</tr>");
                for (int i = 0; i < DGV.RowCount; i++)
                {
                    strTable.Append("<tr>");
                    foreach (DataGridViewCell cell in DGV.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            strTable.AppendFormat("<td>{0}</td>", cell.Value.ToString());
                        }
                    }

                    strTable.Append("</tr>");
                }

                strTable.Append("</table>");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

            return strTable.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }
        //Mail Station
        private void btnmailS_Click(object sender, EventArgs e)
        {
            if (txtmailS.Text == "")
                MessageBox.Show("Bitte geben Sie eine Email-Adresse ein!");
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("projecterik233@gmail.com");
                    mail.To.Add(new MailAddress(Convert.ToString(this.txtmailS)));
                    mail.Subject = "Fahrplan";
                    mail.Body = "Hallo, hier ein Fahrplan, den ich mit dir teilen wollte. ";
                    mail.Body += "<b>" + Get_TableFromDataGridS() + "</b>";
                    mail.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("projecterik233.@gmail.com", "project233");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email wurde erfolgreich gesendet");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //Map Funktion 2
        public string Get_TableFromDataGridS()
        {
            StringBuilder strTable = new StringBuilder();
            try
            {
                strTable.Append(("<table border='1 cellpadding='0' cellspacing='0'>"));
                strTable.Append("<tr>");
                foreach (DataGridViewColumn col in DGS.Columns)
                {

                    strTable.AppendFormat("<th>{0}</td>", col.HeaderText);
                }

                strTable.Append("</tr>");
                for (int i = 0; i < DGS.RowCount; i++)
                {
                    strTable.Append("<tr>");
                    foreach (DataGridViewCell cell in DGS.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            strTable.AppendFormat("<td>{0}</td>", cell.Value.ToString());
                        }
                    }

                    strTable.Append("</tr>");
                }

                strTable.Append("</table>");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

            return strTable.ToString();
        }


    }
}