namespace Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Clear = new System.Windows.Forms.Button();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Open = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Del = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.Del, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Clear, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.MediaPlayer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Open, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.List, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear.Location = new System.Drawing.Point(360, 102);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(57, 37);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Claer list";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(3, 3);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.tableLayoutPanel1.SetRowSpan(this.MediaPlayer, 2);
            this.MediaPlayer.Size = new System.Drawing.Size(225, 136);
            this.MediaPlayer.TabIndex = 0;
            this.MediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MediaPlayer_PlayStateChange);
            // 
            // Open
            // 
            this.Open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Open.Location = new System.Drawing.Point(234, 102);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(57, 37);
            this.Open.TabIndex = 2;
            this.Open.Text = "Add file";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // List
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.List, 3);
            this.List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(234, 3);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(183, 93);
            this.List.TabIndex = 1;
            this.List.SelectedIndexChanged += new System.EventHandler(this.PlayerList_SelectedIndexChanged);
            this.List.DoubleClick += new System.EventHandler(this.PlayerList_DoubleClick);
            this.List.KeyUp += new System.Windows.Forms.KeyEventHandler(this.List_KeyUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MP3 Files(*.mp3)|*.mp3|WAW Files (*.waw)|*.waw*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Mp3 player";
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(297, 102);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(57, 37);
            this.Del.TabIndex = 4;
            this.Del.Text = "Delete song";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 304);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mp3Player";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Del;
    }
}

