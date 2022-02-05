
namespace FHAFK5
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.menuTitle = new System.Windows.Forms.Label();
            this.mouseButton = new System.Windows.Forms.RadioButton();
            this.keyboardButton = new System.Windows.Forms.RadioButton();
            this.gamepadButton = new System.Windows.Forms.RadioButton();
            this.infoBar = new System.Windows.Forms.ProgressBar();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.timerSpeed = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(201, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(64, 34);
            this.minimize.TabIndex = 0;
            this.minimize.Text = "Minimze";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minimize_MouseDown);
            this.minimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.minimize_MouseMove);
            this.minimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minimize_MouseUp);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(271, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(64, 34);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.close_MouseDown);
            this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_MouseMove);
            this.close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.close_MouseUp);
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.dragPanel.Controls.Add(this.title);
            this.dragPanel.Controls.Add(this.close);
            this.dragPanel.Controls.Add(this.minimize);
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(335, 34);
            this.dragPanel.TabIndex = 0;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            this.dragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseUp);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(39, 16);
            this.title.TabIndex = 2;
            this.title.Text = "Title";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_MouseUp);
            // 
            // menuTitle
            // 
            this.menuTitle.AutoSize = true;
            this.menuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.menuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.menuTitle.Location = new System.Drawing.Point(11, 57);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(181, 24);
            this.menuTitle.TabIndex = 1;
            this.menuTitle.Text = "Forza Horizon AFK5";
            // 
            // mouseButton
            // 
            this.mouseButton.AutoSize = true;
            this.mouseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.mouseButton.Location = new System.Drawing.Point(15, 138);
            this.mouseButton.Name = "mouseButton";
            this.mouseButton.Size = new System.Drawing.Size(91, 17);
            this.mouseButton.TabIndex = 2;
            this.mouseButton.Text = "Mouse Button";
            this.mouseButton.UseVisualStyleBackColor = true;
            this.mouseButton.CheckedChanged += new System.EventHandler(this.mouseButton_CheckedChanged);
            // 
            // keyboardButton
            // 
            this.keyboardButton.AutoSize = true;
            this.keyboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.keyboardButton.Location = new System.Drawing.Point(15, 115);
            this.keyboardButton.Name = "keyboardButton";
            this.keyboardButton.Size = new System.Drawing.Size(104, 17);
            this.keyboardButton.TabIndex = 3;
            this.keyboardButton.Text = "Keyboard Button";
            this.keyboardButton.UseVisualStyleBackColor = true;
            this.keyboardButton.CheckedChanged += new System.EventHandler(this.keyboardButton_CheckedChanged);
            // 
            // gamepadButton
            // 
            this.gamepadButton.AutoSize = true;
            this.gamepadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.gamepadButton.Location = new System.Drawing.Point(15, 92);
            this.gamepadButton.Name = "gamepadButton";
            this.gamepadButton.Size = new System.Drawing.Size(105, 17);
            this.gamepadButton.TabIndex = 4;
            this.gamepadButton.Text = "Gamepad Button";
            this.gamepadButton.UseVisualStyleBackColor = true;
            this.gamepadButton.CheckedChanged += new System.EventHandler(this.gamepadButton_CheckedChanged);
            // 
            // infoBar
            // 
            this.infoBar.Location = new System.Drawing.Point(15, 203);
            this.infoBar.Name = "infoBar";
            this.infoBar.Size = new System.Drawing.Size(307, 23);
            this.infoBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.infoBar.TabIndex = 5;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(247, 92);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 6;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.stop.FlatAppearance.BorderSize = 0;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.ForeColor = System.Drawing.Color.White;
            this.stop.Location = new System.Drawing.Point(247, 121);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 7;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // timerSpeed
            // 
            this.timerSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerSpeed.Location = new System.Drawing.Point(15, 177);
            this.timerSpeed.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.timerSpeed.Name = "timerSpeed";
            this.timerSpeed.Size = new System.Drawing.Size(307, 20);
            this.timerSpeed.TabIndex = 8;
            this.timerSpeed.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.timerSpeed.ValueChanged += new System.EventHandler(this.timerSpeed_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(4)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 10);
            this.panel1.TabIndex = 9;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(335, 237);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timerSpeed);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.infoBar);
            this.Controls.Add(this.gamepadButton);
            this.Controls.Add(this.keyboardButton);
            this.Controls.Add(this.mouseButton);
            this.Controls.Add(this.menuTitle);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Forza Horizon AFK5";
            this.Activated += new System.EventHandler(this.Form_Activated);
            this.Deactivate += new System.EventHandler(this.Form_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form_MouseLeave);
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.RadioButton mouseButton;
        private System.Windows.Forms.RadioButton keyboardButton;
        private System.Windows.Forms.RadioButton gamepadButton;
        private System.Windows.Forms.ProgressBar infoBar;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.NumericUpDown timerSpeed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}

