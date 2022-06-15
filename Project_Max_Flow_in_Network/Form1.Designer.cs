namespace Project_Max_Flow_in_Network
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.path_name = new System.Windows.Forms.TextBox();
            this.b_source = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Choosen_Path_Text_box = new System.Windows.Forms.Label();
            this.Choosen_Path_Display = new System.Windows.Forms.Label();
            this.b_Proccess = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadź ścieżkę lokalizacji pliku z danymi:";
            // 
            // path_name
            // 
            this.path_name.Location = new System.Drawing.Point(322, 20);
            this.path_name.Name = "path_name";
            this.path_name.Size = new System.Drawing.Size(408, 20);
            this.path_name.TabIndex = 1;
            this.path_name.TextChanged += new System.EventHandler(this.path_name_TextChanged);
            // 
            // b_source
            // 
            this.b_source.Location = new System.Drawing.Point(736, 18);
            this.b_source.Name = "b_source";
            this.b_source.Size = new System.Drawing.Size(96, 23);
            this.b_source.TabIndex = 2;
            this.b_source.Text = "Wybierz";
            this.b_source.UseVisualStyleBackColor = true;
            this.b_source.Click += new System.EventHandler(this.b_source_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 188);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(820, 250);
            this.webBrowser1.TabIndex = 3;
            // 
            // Choosen_Path_Text_box
            // 
            this.Choosen_Path_Text_box.AutoSize = true;
            this.Choosen_Path_Text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Choosen_Path_Text_box.Location = new System.Drawing.Point(13, 56);
            this.Choosen_Path_Text_box.Name = "Choosen_Path_Text_box";
            this.Choosen_Path_Text_box.Size = new System.Drawing.Size(126, 18);
            this.Choosen_Path_Text_box.TabIndex = 4;
            this.Choosen_Path_Text_box.Text = "Wybrana ścieżka:";
            // 
            // Choosen_Path_Display
            // 
            this.Choosen_Path_Display.AutoSize = true;
            this.Choosen_Path_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Choosen_Path_Display.Location = new System.Drawing.Point(145, 57);
            this.Choosen_Path_Display.MaximumSize = new System.Drawing.Size(585, 17);
            this.Choosen_Path_Display.MinimumSize = new System.Drawing.Size(585, 17);
            this.Choosen_Path_Display.Name = "Choosen_Path_Display";
            this.Choosen_Path_Display.Size = new System.Drawing.Size(585, 17);
            this.Choosen_Path_Display.TabIndex = 5;
            // 
            // b_Proccess
            // 
            this.b_Proccess.Location = new System.Drawing.Point(736, 54);
            this.b_Proccess.Name = "b_Proccess";
            this.b_Proccess.Size = new System.Drawing.Size(0, 0);
            this.b_Proccess.TabIndex = 6;
            this.b_Proccess.Text = "Zatwierdź";
            this.b_Proccess.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zaakceptuj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_Proccess);
            this.Controls.Add(this.Choosen_Path_Display);
            this.Controls.Add(this.Choosen_Path_Text_box);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.b_source);
            this.Controls.Add(this.path_name);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(860, 489);
            this.MinimumSize = new System.Drawing.Size(860, 489);
            this.Name = "Form1";
            this.Text = "Maksymalny Przepływ w Sieci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox path_name;
        private System.Windows.Forms.Button b_source;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label Choosen_Path_Text_box;
        private System.Windows.Forms.Label Choosen_Path_Display;
        private System.Windows.Forms.Button b_Proccess;
        private System.Windows.Forms.Button button1;
    }
}

