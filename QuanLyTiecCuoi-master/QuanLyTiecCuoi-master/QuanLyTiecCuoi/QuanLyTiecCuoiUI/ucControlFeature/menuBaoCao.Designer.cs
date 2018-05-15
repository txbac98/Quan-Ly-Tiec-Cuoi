namespace QuanLyTiecCuoiUI.ucControlFeature
{
    partial class menuBaoCao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLapBaoCaoThang = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnLapBaoCaoThang
            // 
            this.btnLapBaoCaoThang.FlatAppearance.BorderSize = 0;
            this.btnLapBaoCaoThang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(153)))), ((int)(((byte)(145)))));
            this.btnLapBaoCaoThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapBaoCaoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLapBaoCaoThang.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLapBaoCaoThang.Image = global::QuanLyTiecCuoiUI.Properties.Resources.graph;
            this.btnLapBaoCaoThang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapBaoCaoThang.Location = new System.Drawing.Point(3, 2);
            this.btnLapBaoCaoThang.Name = "btnLapBaoCaoThang";
            this.btnLapBaoCaoThang.Size = new System.Drawing.Size(229, 30);
            this.btnLapBaoCaoThang.TabIndex = 4;
            this.btnLapBaoCaoThang.Text = "           Lập báo cáo tháng";
            this.btnLapBaoCaoThang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnLapBaoCaoThang, "Lập báo cáo tháng");
            this.btnLapBaoCaoThang.UseVisualStyleBackColor = true;
            // 
            // menuBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLapBaoCaoThang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menuBaoCao";
            this.Size = new System.Drawing.Size(235, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLapBaoCaoThang;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
