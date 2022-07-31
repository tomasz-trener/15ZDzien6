namespace P04AplikacjaOkienkowa
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
            this.dgvDane = new System.Windows.Forms.DataGridView();
            this.txtPolecenieSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.btnWyslij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDane
            // 
            this.dgvDane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDane.Location = new System.Drawing.Point(12, 67);
            this.dgvDane.Name = "dgvDane";
            this.dgvDane.Size = new System.Drawing.Size(591, 523);
            this.dgvDane.TabIndex = 0;
            // 
            // txtPolecenieSQL
            // 
            this.txtPolecenieSQL.Location = new System.Drawing.Point(128, 41);
            this.txtPolecenieSQL.Name = "txtPolecenieSQL";
            this.txtPolecenieSQL.Size = new System.Drawing.Size(389, 20);
            this.txtPolecenieSQL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Polecenie SQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parametry połączenia";
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(128, 15);
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(389, 20);
            this.txtConnString.TabIndex = 3;
            this.txtConnString.Text = "Data Source=.\\sqlexpress;Initial Catalog=A_Zawodnicy;Integrated Security=True";
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(528, 15);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 46);
            this.btnWyslij.TabIndex = 5;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 598);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConnString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPolecenieSQL);
            this.Controls.Add(this.dgvDane);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDane;
        private System.Windows.Forms.TextBox txtPolecenieSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConnString;
        private System.Windows.Forms.Button btnWyslij;
    }
}

