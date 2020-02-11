using WaitingScreen.Models;

namespace WaitingScreen
{
    partial class MainForm
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
            this._screen = new Screen();
            this.components = new System.ComponentModel.Container();
            this._timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._screen)).BeginInit();
            this.SuspendLayout();
            //
            // _screen
            //
            this._screen.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this._screen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClick);
            // 
            // _timer
            // 
            this._timer.Interval = 50;
            this._timer.Tick += new System.EventHandler(this.OnTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this._screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this._screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Screen _screen;
        private System.Windows.Forms.Timer _timer;
    }
}

