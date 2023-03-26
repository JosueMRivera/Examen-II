
namespace Vista
{
    partial class BuscarTicketForm
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
            this.TicketsDGV = new System.Windows.Forms.DataGridView();
            this.aceptarbt = new System.Windows.Forms.Button();
            this.cancelarbt = new System.Windows.Forms.Button();
            this.identidadtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketsDGV
            // 
            this.TicketsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TicketsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketsDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TicketsDGV.Location = new System.Drawing.Point(0, 107);
            this.TicketsDGV.Name = "TicketsDGV";
            this.TicketsDGV.Size = new System.Drawing.Size(620, 189);
            this.TicketsDGV.TabIndex = 14;
            // 
            // aceptarbt
            // 
            this.aceptarbt.Location = new System.Drawing.Point(206, 44);
            this.aceptarbt.Name = "aceptarbt";
            this.aceptarbt.Size = new System.Drawing.Size(105, 40);
            this.aceptarbt.TabIndex = 13;
            this.aceptarbt.Text = "Aceptar";
            this.aceptarbt.UseVisualStyleBackColor = true;
            this.aceptarbt.Click += new System.EventHandler(this.aceptarbt_Click);
            // 
            // cancelarbt
            // 
            this.cancelarbt.Location = new System.Drawing.Point(317, 44);
            this.cancelarbt.Name = "cancelarbt";
            this.cancelarbt.Size = new System.Drawing.Size(105, 40);
            this.cancelarbt.TabIndex = 12;
            this.cancelarbt.Text = "Cancelar";
            this.cancelarbt.UseVisualStyleBackColor = true;
            this.cancelarbt.Click += new System.EventHandler(this.cancelarbt_Click);
            // 
            // identidadtxt
            // 
            this.identidadtxt.Location = new System.Drawing.Point(103, 5);
            this.identidadtxt.Name = "identidadtxt";
            this.identidadtxt.Size = new System.Drawing.Size(478, 22);
            this.identidadtxt.TabIndex = 11;
            this.identidadtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.identidadtxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Identidad:";
            // 
            // BuscarTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 296);
            this.Controls.Add(this.TicketsDGV);
            this.Controls.Add(this.aceptarbt);
            this.Controls.Add(this.cancelarbt);
            this.Controls.Add(this.identidadtxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuscarTicketForm";
            this.Text = "BuscarTicket";
            this.Load += new System.EventHandler(this.BuscarTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TicketsDGV;
        private System.Windows.Forms.Button aceptarbt;
        private System.Windows.Forms.Button cancelarbt;
        private System.Windows.Forms.TextBox identidadtxt;
        private System.Windows.Forms.Label label1;
    }
}