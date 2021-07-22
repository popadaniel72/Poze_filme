
namespace Poze_filme
{
    partial class filme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filme));
            this.cautaFisier = new System.Windows.Forms.OpenFileDialog();
            this.listaFilme = new System.Windows.Forms.ListBox();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // cautaFisier
            // 
            this.cautaFisier.FileName = "openFileDialog1";
            this.cautaFisier.Filter = "mp4|*.mp4|avi|*.avi";
            // 
            // listaFilme
            // 
            this.listaFilme.FormattingEnabled = true;
            this.listaFilme.Location = new System.Drawing.Point(12, 12);
            this.listaFilme.Name = "listaFilme";
            this.listaFilme.Size = new System.Drawing.Size(160, 420);
            this.listaFilme.TabIndex = 0;
            this.listaFilme.SelectedIndexChanged += new System.EventHandler(this.listaFilme_SelectedIndexChanged);
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(178, 12);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(610, 420);
            this.wmp.TabIndex = 1;
            // 
            // filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.listaFilme);
            this.Name = "filme";
            this.Text = "filme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.filme_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog cautaFisier;
        private System.Windows.Forms.ListBox listaFilme;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
    }
}