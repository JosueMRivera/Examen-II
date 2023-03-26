
namespace Vista
{
    partial class TicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsForm));
            this.totalapagartxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Descuentotxt = new System.Windows.Forms.TextBox();
            this.Isvtxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.subtotaltxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Nombreclientetxt = new System.Windows.Forms.TextBox();
            this.buscarclientebt = new System.Windows.Forms.Button();
            this.Identidadtxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.soportetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SoportecomboBox = new System.Windows.Forms.ComboBox();
            this.aparatotxt = new System.Windows.Forms.TextBox();
            this.AparatocomboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descripcionrespuestatxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcionsolicitudtxt = new System.Windows.Forms.TextBox();
            this.DetalleTicketDGV = new System.Windows.Forms.DataGridView();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cancelarbt = new System.Windows.Forms.Button();
            this.Guardarbt = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleTicketDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalapagartxt
            // 
            this.totalapagartxt.Location = new System.Drawing.Point(832, 716);
            this.totalapagartxt.Name = "totalapagartxt";
            this.totalapagartxt.ReadOnly = true;
            this.totalapagartxt.Size = new System.Drawing.Size(147, 22);
            this.totalapagartxt.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(727, 719);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 66;
            this.label14.Text = "Total a Pagar:";
            // 
            // Descuentotxt
            // 
            this.Descuentotxt.Location = new System.Drawing.Point(832, 686);
            this.Descuentotxt.Name = "Descuentotxt";
            this.Descuentotxt.Size = new System.Drawing.Size(147, 22);
            this.Descuentotxt.TabIndex = 65;
            this.Descuentotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Descuentotxt_KeyPress);
            // 
            // Isvtxt
            // 
            this.Isvtxt.Location = new System.Drawing.Point(832, 656);
            this.Isvtxt.Name = "Isvtxt";
            this.Isvtxt.ReadOnly = true;
            this.Isvtxt.Size = new System.Drawing.Size(147, 22);
            this.Isvtxt.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(788, 659);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 16);
            this.label15.TabIndex = 62;
            this.label15.Text = "ISV:";
            // 
            // subtotaltxt
            // 
            this.subtotaltxt.Location = new System.Drawing.Point(832, 629);
            this.subtotaltxt.Name = "subtotaltxt";
            this.subtotaltxt.Size = new System.Drawing.Size(147, 22);
            this.subtotaltxt.TabIndex = 61;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(751, 632);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 16);
            this.label16.TabIndex = 60;
            this.label16.Text = "Sub Total:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(744, 689);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 16);
            this.label18.TabIndex = 64;
            this.label18.Text = "Descuento:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Nombreclientetxt);
            this.groupBox4.Controls.Add(this.buscarclientebt);
            this.groupBox4.Controls.Add(this.Identidadtxt);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(18, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(960, 69);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Cliente";
            // 
            // Nombreclientetxt
            // 
            this.Nombreclientetxt.Location = new System.Drawing.Point(343, 27);
            this.Nombreclientetxt.Name = "Nombreclientetxt";
            this.Nombreclientetxt.ReadOnly = true;
            this.Nombreclientetxt.Size = new System.Drawing.Size(611, 22);
            this.Nombreclientetxt.TabIndex = 3;
            // 
            // buscarclientebt
            // 
            this.buscarclientebt.FlatAppearance.BorderSize = 0;
            this.buscarclientebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarclientebt.Image = global::Vista.Properties.Resources.buscar_cliente;
            this.buscarclientebt.Location = new System.Drawing.Point(304, 27);
            this.buscarclientebt.Name = "buscarclientebt";
            this.buscarclientebt.Size = new System.Drawing.Size(33, 23);
            this.buscarclientebt.TabIndex = 2;
            this.buscarclientebt.UseVisualStyleBackColor = true;
            this.buscarclientebt.Click += new System.EventHandler(this.buscarclientebt_Click);
            // 
            // Identidadtxt
            // 
            this.Identidadtxt.Location = new System.Drawing.Point(79, 27);
            this.Identidadtxt.Name = "Identidadtxt";
            this.Identidadtxt.Size = new System.Drawing.Size(219, 22);
            this.Identidadtxt.TabIndex = 1;
            this.Identidadtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Identidadtxt_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Identidad:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FechadateTimePicker);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.Usuariotxt);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Location = new System.Drawing.Point(18, 36);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(960, 51);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(842, 15);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(112, 22);
            this.FechadateTimePicker.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(787, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "Fecha:";
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Location = new System.Drawing.Point(79, 15);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.ReadOnly = true;
            this.Usuariotxt.Size = new System.Drawing.Size(219, 22);
            this.Usuariotxt.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "Usuario:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.soportetxt);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.SoportecomboBox);
            this.groupBox6.Controls.Add(this.aparatotxt);
            this.groupBox6.Controls.Add(this.AparatocomboBox);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(18, 187);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(960, 98);
            this.groupBox6.TabIndex = 58;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo Soporte";
            // 
            // soportetxt
            // 
            this.soportetxt.Location = new System.Drawing.Point(535, 64);
            this.soportetxt.Name = "soportetxt";
            this.soportetxt.ReadOnly = true;
            this.soportetxt.Size = new System.Drawing.Size(328, 22);
            this.soportetxt.TabIndex = 7;
            this.soportetxt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de Soporte Tecnico:";
            // 
            // SoportecomboBox
            // 
            this.SoportecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SoportecomboBox.FormattingEnabled = true;
            this.SoportecomboBox.Location = new System.Drawing.Point(182, 61);
            this.SoportecomboBox.Name = "SoportecomboBox";
            this.SoportecomboBox.Size = new System.Drawing.Size(347, 24);
            this.SoportecomboBox.TabIndex = 5;
            this.SoportecomboBox.SelectedIndexChanged += new System.EventHandler(this.SoportecomboBox_SelectedIndexChanged_1);
            // 
            // aparatotxt
            // 
            this.aparatotxt.Location = new System.Drawing.Point(535, 27);
            this.aparatotxt.Name = "aparatotxt";
            this.aparatotxt.ReadOnly = true;
            this.aparatotxt.Size = new System.Drawing.Size(328, 22);
            this.aparatotxt.TabIndex = 3;
            this.aparatotxt.Visible = false;
            // 
            // AparatocomboBox
            // 
            this.AparatocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AparatocomboBox.FormattingEnabled = true;
            this.AparatocomboBox.Items.AddRange(new object[] {
            "Celular",
            "Equipo de Computo"});
            this.AparatocomboBox.Location = new System.Drawing.Point(182, 27);
            this.AparatocomboBox.Name = "AparatocomboBox";
            this.AparatocomboBox.Size = new System.Drawing.Size(347, 24);
            this.AparatocomboBox.TabIndex = 4;
            this.AparatocomboBox.SelectedIndexChanged += new System.EventHandler(this.AparatocomboBox_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Elija el Aparato:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(481, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 24);
            this.label22.TabIndex = 55;
            this.label22.Text = "Ticket";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.descripcionrespuestatxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.descripcionsolicitudtxt);
            this.groupBox1.Location = new System.Drawing.Point(18, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 100);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Descripcion Respuesta:";
            // 
            // descripcionrespuestatxt
            // 
            this.descripcionrespuestatxt.Location = new System.Drawing.Point(173, 60);
            this.descripcionrespuestatxt.Name = "descripcionrespuestatxt";
            this.descripcionrespuestatxt.Size = new System.Drawing.Size(772, 22);
            this.descripcionrespuestatxt.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Descripcion Solicitud:";
            // 
            // descripcionsolicitudtxt
            // 
            this.descripcionsolicitudtxt.Location = new System.Drawing.Point(173, 30);
            this.descripcionsolicitudtxt.Name = "descripcionsolicitudtxt";
            this.descripcionsolicitudtxt.Size = new System.Drawing.Size(772, 22);
            this.descripcionsolicitudtxt.TabIndex = 4;
            // 
            // DetalleTicketDGV
            // 
            this.DetalleTicketDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetalleTicketDGV.Location = new System.Drawing.Point(-2, 463);
            this.DetalleTicketDGV.Name = "DetalleTicketDGV";
            this.DetalleTicketDGV.Size = new System.Drawing.Size(993, 148);
            this.DetalleTicketDGV.TabIndex = 70;
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(811, 425);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(147, 22);
            this.preciotxt.TabIndex = 72;
            this.preciotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preciotxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(755, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 71;
            this.label7.Text = "Precio:";
            // 
            // Cancelarbt
            // 
            this.Cancelarbt.BackColor = System.Drawing.Color.White;
            this.Cancelarbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbt.Image = global::Vista.Properties.Resources.cancelar;
            this.Cancelarbt.Location = new System.Drawing.Point(123, 702);
            this.Cancelarbt.Name = "Cancelarbt";
            this.Cancelarbt.Size = new System.Drawing.Size(106, 36);
            this.Cancelarbt.TabIndex = 69;
            this.Cancelarbt.Text = "Cancelar";
            this.Cancelarbt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancelarbt.UseVisualStyleBackColor = false;
            this.Cancelarbt.Click += new System.EventHandler(this.Cancelarbt_Click);
            // 
            // Guardarbt
            // 
            this.Guardarbt.BackColor = System.Drawing.Color.White;
            this.Guardarbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbt.Image = global::Vista.Properties.Resources.guardar;
            this.Guardarbt.Location = new System.Drawing.Point(11, 702);
            this.Guardarbt.Name = "Guardarbt";
            this.Guardarbt.Size = new System.Drawing.Size(106, 36);
            this.Guardarbt.TabIndex = 68;
            this.Guardarbt.Text = "Guardar";
            this.Guardarbt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardarbt.UseVisualStyleBackColor = false;
            this.Guardarbt.Click += new System.EventHandler(this.Guardarbt_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(991, 750);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DetalleTicketDGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancelarbt);
            this.Controls.Add(this.Guardarbt);
            this.Controls.Add(this.totalapagartxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Descuentotxt);
            this.Controls.Add(this.Isvtxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.subtotaltxt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label22);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketsForm";
            this.Text = "TicketsForm";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleTicketDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelarbt;
        private System.Windows.Forms.Button Guardarbt;
        private System.Windows.Forms.TextBox totalapagartxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Descuentotxt;
        private System.Windows.Forms.TextBox Isvtxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox subtotaltxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Nombreclientetxt;
        private System.Windows.Forms.Button buscarclientebt;
        private System.Windows.Forms.TextBox Identidadtxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox aparatotxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox SoportecomboBox;
        private System.Windows.Forms.ComboBox AparatocomboBox;
        private System.Windows.Forms.TextBox soportetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descripcionsolicitudtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripcionrespuestatxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DetalleTicketDGV;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}