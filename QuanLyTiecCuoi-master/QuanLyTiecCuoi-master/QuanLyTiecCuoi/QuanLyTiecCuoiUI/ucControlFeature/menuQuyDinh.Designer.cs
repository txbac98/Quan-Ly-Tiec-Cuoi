namespace QuanLyTiecCuoiUI.ucControlFeature
{
    partial class menuQuyDinh
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
            this.btnThayDoiQuyDinhForm = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnThayDoiQuyDinhForm
            // 
            this.btnThayDoiQuyDinhForm.FlatAppearance.BorderSize = 0;
            this.btnThayDoiQuyDinhForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(153)))), ((int)(((byte)(145)))));
            this.btnThayDoiQuyDinhForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoiQuyDinhForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThayDoiQuyDinhForm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnThayDoiQuyDinhForm.Image = global::QuanLyTiecCuoiUI.Properties.Resources.settings1;
            this.btnThayDoiQuyDinhForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThayDoiQuyDinhForm.Location = new System.Drawing.Point(3, 2);
            this.btnThayDoiQuyDinhForm.Name = "btnThayDoiQuyDinhForm";
            this.btnThayDoiQuyDinhForm.Size = new System.Drawing.Size(229, 30);
            this.btnThayDoiQuyDinhForm.TabIndex = 4;
            this.btnThayDoiQuyDinhForm.Text = "           Thay đổi quy định";
            this.btnThayDoiQuyDinhForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnThayDoiQuyDinhForm, "Thay đổi quy định");
            this.btnThayDoiQuyDinhForm.UseVisualStyleBackColor = true;
            // 
            // menuQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThayDoiQuyDinhForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menuQuyDinh";
            this.Size = new System.Drawing.Size(235, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThayDoiQuyDinhForm;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
