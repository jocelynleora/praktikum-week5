namespace praktikum_week5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelData = new System.Windows.Forms.Label();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.labelSetting = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.radioButtonMerah = new System.Windows.Forms.RadioButton();
            this.radioButtonBiru = new System.Windows.Forms.RadioButton();
            this.labelOutput = new System.Windows.Forms.Label();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.labelHasil = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(63, 50);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(31, 15);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data";
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(63, 101);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(47, 15);
            this.labelKoleksi.TabIndex = 1;
            this.labelKoleksi.Text = "Koleksi:";
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(309, 101);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(47, 15);
            this.labelSetting.TabIndex = 2;
            this.labelSetting.Text = "Setting:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(119, 47);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(246, 23);
            this.textBoxData.TabIndex = 4;
            this.textBoxData.TextChanged += new System.EventHandler(this.textBoxDara_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(392, 47);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(362, 100);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(51, 19);
            this.checkBoxAktif.TabIndex = 6;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            this.checkBoxAktif.CheckedChanged += new System.EventHandler(this.checkBoxAktif_CheckedChanged);
            // 
            // radioButtonMerah
            // 
            this.radioButtonMerah.AutoSize = true;
            this.radioButtonMerah.Location = new System.Drawing.Point(344, 127);
            this.radioButtonMerah.Name = "radioButtonMerah";
            this.radioButtonMerah.Size = new System.Drawing.Size(96, 19);
            this.radioButtonMerah.TabIndex = 7;
            this.radioButtonMerah.TabStop = true;
            this.radioButtonMerah.Text = "Warna Merah";
            this.radioButtonMerah.UseVisualStyleBackColor = true;
            // 
            // radioButtonBiru
            // 
            this.radioButtonBiru.AutoSize = true;
            this.radioButtonBiru.Location = new System.Drawing.Point(344, 152);
            this.radioButtonBiru.Name = "radioButtonBiru";
            this.radioButtonBiru.Size = new System.Drawing.Size(83, 19);
            this.radioButtonBiru.TabIndex = 8;
            this.radioButtonBiru.TabStop = true;
            this.radioButtonBiru.Text = "Warna Biru";
            this.radioButtonBiru.UseVisualStyleBackColor = true;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(309, 225);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(48, 15);
            this.labelOutput.TabIndex = 9;
            this.labelOutput.Text = "Output:";
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 15;
            this.listBoxData.Location = new System.Drawing.Point(63, 127);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(202, 244);
            this.listBoxData.TabIndex = 10;
            this.listBoxData.SelectedIndexChanged += new System.EventHandler(this.listBoxData_SelectedIndexChanged);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHasil.Location = new System.Drawing.Point(373, 266);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(67, 30);
            this.labelHasil.TabIndex = 11;
            this.labelHasil.Text = "HALO";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(309, 348);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(221, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.radioButtonBiru);
            this.Controls.Add(this.radioButtonMerah);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.labelData);
            this.Name = "Form1";
            this.Text = "Form Materi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelData;
        private Label labelKoleksi;
        private Label labelSetting;
        private Label label4;
        private TextBox textBoxData;
        private Button buttonAdd;
        private CheckBox checkBoxAktif;
        private RadioButton radioButtonMerah;
        private RadioButton radioButtonBiru;
        private Label labelOutput;
        private ListBox listBoxData;
        private Label labelHasil;
        private Button buttonClear;
    }
}