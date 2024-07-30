using ExamPrepper.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static ExamPrepper.Properties.Settings;

namespace ExamPrepper.Classes
{
    internal class Notifications
    {
        public static void ShowSuccess(Form frm, string created)
        {
            Panel panel = new Panel();
            Label lbl = new Label();
            lbl.Name = "Test";
            lbl.Text = $"Successfully Created {created}";
            lbl.Dock = DockStyle.Fill;
            lbl.AutoSize = false;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font(Default.FontName, 16, FontStyle.Bold);

            panel.Controls.Add(lbl);

            panel.Name = "Test";
            panel.Text = "Successfull";
            panel.BackColor = Color.LimeGreen;
            panel.Size = new Size(350, 60);
            panel.Location = new Point(20, 20);
            panel.BorderStyle = BorderStyle.Fixed3D;

            frm.Controls.Add(panel);
            panel.BringToFront();

            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();

            if (Default.Audio)
            {
                SystemSounds.Hand.Play();
            }          

            tmr.Interval = 1500;
            tmr.Start();
            tmr.Tick += (s, e) =>
            {
                frm.Controls.Remove(panel);
                panel.Controls.Remove(lbl);
                lbl.Dispose();
                panel.Dispose();
                tmr.Stop();
            };
        }
    }
}
