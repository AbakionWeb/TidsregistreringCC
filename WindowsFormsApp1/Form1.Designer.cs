using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace TidsregistreringCC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Navn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.antalTB = new System.Windows.Forms.TextBox();
            this.fraTimer = new System.Windows.Forms.TextBox();
            this.tilTimer = new System.Windows.Forms.TextBox();
            this.totalTimer = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox4 = new System.Windows.Forms.TextBox();
            this.richTextBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTB = new System.Windows.Forms.RadioButton();
            this.cbTimer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Navn
            // 
            this.Navn.AutoSize = true;
            this.Navn.Location = new System.Drawing.Point(15, 9);
            this.Navn.Name = "Navn";
            this.Navn.Size = new System.Drawing.Size(33, 13);
            this.Navn.TabIndex = 1;
            this.Navn.Text = "Navn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kunde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dato";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 102);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Beskrivelse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ufakturerbart";
            // 
            // antalTB
            // 
            this.antalTB.Location = new System.Drawing.Point(96, 32);
            this.antalTB.Name = "antalTB";
            this.antalTB.Size = new System.Drawing.Size(40, 20);
            this.antalTB.TabIndex = 15;
            // 
            // fraTimer
            // 
            this.fraTimer.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.fraTimer.Enabled = false;
            this.fraTimer.Location = new System.Drawing.Point(96, 78);
            this.fraTimer.Name = "fraTimer";
            this.fraTimer.Size = new System.Drawing.Size(40, 20);
            this.fraTimer.TabIndex = 17;
            this.fraTimer.Text = "00.00";
            this.fraTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tilTimer
            // 
            this.tilTimer.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.tilTimer.Location = new System.Drawing.Point(142, 78);
            this.tilTimer.Name = "tilTimer";
            this.tilTimer.Size = new System.Drawing.Size(40, 20);
            this.tilTimer.TabIndex = 18;
            this.tilTimer.Text = "00.00";
            this.tilTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tilTimer.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // totalTimer
            // 
            this.totalTimer.Enabled = false;
            this.totalTimer.Location = new System.Drawing.Point(188, 78);
            this.totalTimer.Name = "totalTimer";
            this.totalTimer.Size = new System.Drawing.Size(53, 20);
            this.totalTimer.TabIndex = 19;
            this.totalTimer.Text = "0";
            this.totalTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(103, 20);
            this.richTextBox1.TabIndex = 10;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(129, 25);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(113, 20);
            this.richTextBox2.TabIndex = 11;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(15, 67);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(227, 20);
            this.richTextBox4.TabIndex = 20;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(254, 25);
            this.richTextBox3.MaximumSize = new System.Drawing.Size(263, 120);
            this.richTextBox3.MinimumSize = new System.Drawing.Size(263, 120);
            this.richTextBox3.Multiline = true;
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(263, 120);
            this.richTextBox3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Til";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total timer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Antal";
            // 
            // cbTB
            // 
            this.cbTB.AutoSize = true;
            this.cbTB.Location = new System.Drawing.Point(6, 32);
            this.cbTB.Name = "cbTB";
            this.cbTB.Size = new System.Drawing.Size(78, 17);
            this.cbTB.TabIndex = 14;
            this.cbTB.TabStop = true;
            this.cbTB.Text = "Time Block";
            this.cbTB.UseVisualStyleBackColor = true;
            // 
            // cbTimer
            // 
            this.cbTimer.AutoSize = true;
            this.cbTimer.Location = new System.Drawing.Point(7, 78);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(51, 17);
            this.cbTimer.TabIndex = 16;
            this.cbTimer.TabStop = true;
            this.cbTimer.Text = "Timer";
            this.cbTimer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cbTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.totalTimer);
            this.groupBox1.Controls.Add(this.cbTimer);
            this.groupBox1.Controls.Add(this.antalTB);
            this.groupBox1.Controls.Add(this.fraTimer);
            this.groupBox1.Controls.Add(this.tilTimer);
            this.groupBox1.Location = new System.Drawing.Point(254, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 113);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Navn);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(551, 350);
            this.MinimumSize = new System.Drawing.Size(551, 350);
            this.Name = "Form1";
            this.Text = "Tidsregistrering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Navn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox antalTB;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.TextBox richTextBox2;
        private System.Windows.Forms.TextBox richTextBox3;
        private System.Windows.Forms.TextBox richTextBox4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox fraTimer;
        private System.Windows.Forms.TextBox tilTimer;
        private System.Windows.Forms.TextBox totalTimer;        
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton cbTB;
        private System.Windows.Forms.RadioButton cbTimer;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

