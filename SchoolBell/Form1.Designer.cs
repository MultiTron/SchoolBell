namespace SchoolBell
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.playingTimer = new System.Windows.Forms.Timer(this.components);
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.volumeSlider1 = new NAudio.Gui.VolumeSlider();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(12, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(173, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(132, 52);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // startTimer
            // 
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // playingTimer
            // 
            this.playingTimer.Interval = 60000;
            this.playingTimer.Tick += new System.EventHandler(this.playingTimer_Tick);
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(491, 12);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(43, 15);
            this.lblClock.TabIndex = 3;
            this.lblClock.Text = "--:--:--";
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.Location = new System.Drawing.Point(334, 27);
            this.volumeSlider1.Name = "volumeSlider1";
            this.volumeSlider1.Size = new System.Drawing.Size(131, 34);
            this.volumeSlider1.TabIndex = 4;
            this.volumeSlider1.VolumeChanged += new System.EventHandler(this.volumeSlider1_VolumeChanged);
            // 
            // picStatus
            // 
            this.picStatus.BackColor = System.Drawing.Color.Red;
            this.picStatus.Location = new System.Drawing.Point(491, 37);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(43, 25);
            this.picStatus.TabIndex = 5;
            this.picStatus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сила на звука";
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.Location = new System.Drawing.Point(12, 84);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(166, 19);
            this.chkEdit.TabIndex = 7;
            this.chkEdit.Text = "Редактиране на плейлист";
            this.chkEdit.UseVisualStyleBackColor = true;
            this.chkEdit.CheckedChanged += new System.EventHandler(this.chkEdit_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddSong);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.listSongs);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 189);
            this.panel1.TabIndex = 8;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(312, 125);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(197, 42);
            this.btnAddSong.TabIndex = 1;
            this.btnAddSong.Text = "Добави песен";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(312, 69);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(197, 42);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Избери плейлист";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(312, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Запази плейлист";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listSongs
            // 
            this.listSongs.FormattingEnabled = true;
            this.listSongs.ItemHeight = 15;
            this.listSongs.Location = new System.Drawing.Point(12, 13);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(281, 154);
            this.listSongs.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picStatus);
            this.Controls.Add(this.volumeSlider1);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Звънец";
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Timer playingTimer;
        private System.Windows.Forms.Timer clockTimer;
        private Label lblClock;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private PictureBox picStatus;
        private Label label1;
        private CheckBox chkEdit;
        private Panel panel1;
        private Button btnAddSong;
        private Button btnLoad;
        private Button btnSave;
        private ListBox listSongs;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}