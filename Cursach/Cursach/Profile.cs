using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cursach.Patterns;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace Cursach
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            nameLabel.Text = Cinema.CurUser.Login;
            cardNumberLabel.Text = Cinema.CurUser.CardNumber;
            cardSumLabel.Text = Cinema.CurUser.CardSum.ToString();
            SetMessages();
            TicketsList films = new AllFilmsList();
            films.SetTickets(ticketsList);
        }

        private void SetMessages()
        {
            messagesList.Clear();
            List<Message> messages = Cinema.CurUser.Messages;
            foreach (Message mes in messages)
            {
                ListViewItem item = new ListViewItem();
                item.Text = mes.Theme;
                item.Tag = mes;
                if (!mes.IsRead) item.BackColor = Color.LightPink;
                messagesList.Items.Add(item);
            }
        }

        private void messagesList_DoubleClick(object sender, EventArgs e)
        {
            if (messagesList.SelectedItems.Count != 0)
            {
                Message mes = (Message)messagesList.SelectedItems[0].Tag;
                MessageBox.Show(mes.Text, mes.Theme);
                mes.Read();
            }
            SetMessages();
        }

        private void ticketsList_DoubleClick(object sender, EventArgs e)
        {
            if (ticketsList.SelectedItems.Count != 0)
            {
                Ticket ticket = (Ticket)ticketsList.SelectedItems[0].Tag;
                DialogResult confirmResult = MessageBox.Show(ticket.ToString(),
                                    "Save ticket to Pdf?",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // create pdf ticket
                    using (PdfDocument document = new PdfDocument())
                    {
                        PdfPage page = document.Pages.Add();

                        PdfGraphics graphics = page.Graphics;

                        PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

                        graphics.DrawString(ticket.ToString(), font, PdfBrushes.Black, new PointF(0, 0));

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if (saveFileDialog1.FileName != "")
                            {
                                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                                document.Save(fs);
                                fs.Close();
                            }
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TicketsList films;
            if (comboBox1.SelectedIndex == 0)
            {
                films = new AllFilmsList();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                films = new WatchedFilmsList();
            }
            else
            {
                films = new ComingFilmsList();
            }
            films.SetTickets(ticketsList);
        }
    }
}
