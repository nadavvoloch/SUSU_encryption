namespace SSCA_App
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
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTxt = new System.Windows.Forms.Label();
            this.lblKeys = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.TBPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKN = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblKD = new System.Windows.Forms.Label();
            this.CBAction = new System.Windows.Forms.ComboBox();
            this.TBKeysN = new System.Windows.Forms.NumericUpDown();
            this.TBKeysM = new System.Windows.Forms.NumericUpDown();
            this.TBKeysD = new System.Windows.Forms.NumericUpDown();
            this.lblDic = new System.Windows.Forms.Label();
            this.TBdic = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TBKeysN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKeysM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKeysD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(168, 22);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(499, 63);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "SSCR - Encryption";
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt.Location = new System.Drawing.Point(75, 147);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(185, 32);
            this.lblTxt.TabIndex = 1;
            this.lblTxt.Text = "Load text file:";
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeys.Location = new System.Drawing.Point(92, 315);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(152, 32);
            this.lblKeys.TabIndex = 2;
            this.lblKeys.Text = "Load keys:";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(70, 518);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(190, 32);
            this.lblAction.TabIndex = 3;
            this.lblAction.Text = "Select Action:";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(338, 613);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(179, 83);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // TBPath
            // 
            this.TBPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPath.Location = new System.Drawing.Point(266, 151);
            this.TBPath.Name = "TBPath";
            this.TBPath.Size = new System.Drawing.Size(359, 30);
            this.TBPath.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(641, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "search file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKN
            // 
            this.lblKN.AutoSize = true;
            this.lblKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKN.Location = new System.Drawing.Point(502, 315);
            this.lblKN.Name = "lblKN";
            this.lblKN.Size = new System.Drawing.Size(35, 32);
            this.lblKN.TabIndex = 10;
            this.lblKN.Text = "N";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.Location = new System.Drawing.Point(502, 384);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(38, 32);
            this.lblKM.TabIndex = 11;
            this.lblKM.Text = "M";
            // 
            // lblKD
            // 
            this.lblKD.AutoSize = true;
            this.lblKD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKD.Location = new System.Drawing.Point(505, 446);
            this.lblKD.Name = "lblKD";
            this.lblKD.Size = new System.Drawing.Size(35, 32);
            this.lblKD.TabIndex = 12;
            this.lblKD.Text = "D";
            // 
            // CBAction
            // 
            this.CBAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAction.FormattingEnabled = true;
            this.CBAction.Items.AddRange(new object[] {
            "Encryption",
            "Decryption",
            "Send file"});
            this.CBAction.Location = new System.Drawing.Point(266, 521);
            this.CBAction.Name = "CBAction";
            this.CBAction.Size = new System.Drawing.Size(167, 33);
            this.CBAction.TabIndex = 13;
            // 
            // TBKeysN
            // 
            this.TBKeysN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBKeysN.Location = new System.Drawing.Point(266, 312);
            this.TBKeysN.Name = "TBKeysN";
            this.TBKeysN.Size = new System.Drawing.Size(220, 35);
            this.TBKeysN.TabIndex = 14;
            // 
            // TBKeysM
            // 
            this.TBKeysM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBKeysM.Location = new System.Drawing.Point(266, 381);
            this.TBKeysM.Name = "TBKeysM";
            this.TBKeysM.Size = new System.Drawing.Size(220, 35);
            this.TBKeysM.TabIndex = 15;
            // 
            // TBKeysD
            // 
            this.TBKeysD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBKeysD.Location = new System.Drawing.Point(266, 443);
            this.TBKeysD.Name = "TBKeysD";
            this.TBKeysD.Size = new System.Drawing.Size(220, 35);
            this.TBKeysD.TabIndex = 16;
            // 
            // lblDic
            // 
            this.lblDic.AutoSize = true;
            this.lblDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDic.Location = new System.Drawing.Point(43, 226);
            this.lblDic.Name = "lblDic";
            this.lblDic.Size = new System.Drawing.Size(217, 32);
            this.lblDic.TabIndex = 17;
            this.lblDic.Text = "Load dictionary:";
            // 
            // TBdic
            // 
            this.TBdic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdic.Location = new System.Drawing.Point(266, 229);
            this.TBdic.Name = "TBdic";
            this.TBdic.Size = new System.Drawing.Size(359, 30);
            this.TBdic.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(641, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "search file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 708);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TBdic);
            this.Controls.Add(this.lblDic);
            this.Controls.Add(this.TBKeysD);
            this.Controls.Add(this.TBKeysM);
            this.Controls.Add(this.TBKeysN);
            this.Controls.Add(this.CBAction);
            this.Controls.Add(this.lblKD);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.lblKN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBPath);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.lblHead);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSCA-Application";
            ((System.ComponentModel.ISupportInitialize)(this.TBKeysN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKeysM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKeysD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox TBPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKN;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblKD;
        private System.Windows.Forms.ComboBox CBAction;
        private System.Windows.Forms.NumericUpDown TBKeysN;
        private System.Windows.Forms.NumericUpDown TBKeysM;
        private System.Windows.Forms.NumericUpDown TBKeysD;
        private System.Windows.Forms.Label lblDic;
        private System.Windows.Forms.TextBox TBdic;
        private System.Windows.Forms.Button button2;
    }
}

