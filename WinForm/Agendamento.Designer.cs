
namespace Salão_Model.WinForm
{
    partial class Agendamento
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
            this.cmBoxService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmBoxProvider = new System.Windows.Forms.ComboBox();
            this.dTPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbClient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmBoxService
            // 
            this.cmBoxService.FormattingEnabled = true;
            this.cmBoxService.Location = new System.Drawing.Point(219, 47);
            this.cmBoxService.Name = "cmBoxService";
            this.cmBoxService.Size = new System.Drawing.Size(176, 23);
            this.cmBoxService.TabIndex = 0;
            this.cmBoxService.SelectedIndexChanged += new System.EventHandler(this.cmBoxService_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prestador";
            // 
            // cmBoxProvider
            // 
            this.cmBoxProvider.FormattingEnabled = true;
            this.cmBoxProvider.Location = new System.Drawing.Point(12, 104);
            this.cmBoxProvider.Name = "cmBoxProvider";
            this.cmBoxProvider.Size = new System.Drawing.Size(176, 23);
            this.cmBoxProvider.TabIndex = 2;
            // 
            // dTPicker
            // 
            this.dTPicker.CustomFormat = "hh:mm, dd/MM/yyyy";
            this.dTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPicker.Location = new System.Drawing.Point(219, 104);
            this.dTPicker.Name = "dTPicker";
            this.dTPicker.Size = new System.Drawing.Size(176, 23);
            this.dTPicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data e horário";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agendar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmbClient
            // 
            this.CmbClient.FormattingEnabled = true;
            this.CmbClient.Location = new System.Drawing.Point(12, 47);
            this.CmbClient.Name = "CmbClient";
            this.CmbClient.Size = new System.Drawing.Size(164, 23);
            this.CmbClient.TabIndex = 7;
            this.CmbClient.SelectedIndexChanged += new System.EventHandler(this.CmbClient_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selecione o cliente";
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 217);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dTPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBoxProvider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBoxService);
            this.Name = "Agendamento";
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.Agendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBoxService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmBoxProvider;
        private System.Windows.Forms.DateTimePicker dTPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbClient;
        private System.Windows.Forms.Label label4;
    }
}