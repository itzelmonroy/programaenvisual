namespace visual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LbName = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LbName.Location = new System.Drawing.Point(61, 127);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(202, 24);
            this.LbName.TabIndex = 0;
            this.LbName.Text = "Nombre de usuario";
            this.LbName.Click += new System.EventHandler(this.LbName_Click);
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LbPassword.Location = new System.Drawing.Point(61, 193);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(127, 24);
            this.LbPassword.TabIndex = 1;
            this.LbPassword.Text = "Contraseña";
            // 
            // TbName
            // 
            this.TbName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TbName.Location = new System.Drawing.Point(338, 132);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(315, 20);
            this.TbName.TabIndex = 2;
            // 
            // TbPassword
            // 
            this.TbPassword.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TbPassword.Location = new System.Drawing.Point(338, 197);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(315, 20);
            this.TbPassword.TabIndex = 3;
            // 
            // BInicio
            // 
            this.BInicio.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInicio.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BInicio.Location = new System.Drawing.Point(99, 314);
            this.BInicio.Name = "BInicio";
            this.BInicio.Size = new System.Drawing.Size(152, 88);
            this.BInicio.TabIndex = 4;
            this.BInicio.Text = "Iniciar sesión";
            this.BInicio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(202, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Iniciativa Vengadores";
            // 
            // BExit
            // 
            this.BExit.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BExit.Location = new System.Drawing.Point(462, 314);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(155, 88);
            this.BExit.TabIndex = 6;
            this.BExit.Text = "Salir";
            this.BExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BInicio);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Iniciar sesión - Avengers Assamble";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BExit;
    }
}

