namespace ED___Programa_24.Expresiones
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
            this.btnResolverPre = new System.Windows.Forms.Button();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.btnResolverPost = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResolverPre
            // 
            this.btnResolverPre.Location = new System.Drawing.Point(25, 78);
            this.btnResolverPre.Name = "btnResolverPre";
            this.btnResolverPre.Size = new System.Drawing.Size(170, 72);
            this.btnResolverPre.TabIndex = 8;
            this.btnResolverPre.Text = "Con PreOrder";
            this.btnResolverPre.UseVisualStyleBackColor = true;
            this.btnResolverPre.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(25, 24);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(358, 37);
            this.txtExpresion.TabIndex = 7;
            // 
            // btnResolverPost
            // 
            this.btnResolverPost.Location = new System.Drawing.Point(213, 78);
            this.btnResolverPost.Name = "btnResolverPost";
            this.btnResolverPost.Size = new System.Drawing.Size(170, 74);
            this.btnResolverPost.TabIndex = 14;
            this.btnResolverPost.Text = "Con PostOrder";
            this.btnResolverPost.UseVisualStyleBackColor = true;
            this.btnResolverPost.Click += new System.EventHandler(this.btnResolverPost_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(405, 78);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(133, 58);
            this.txtInfo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnResolverPost);
            this.Controls.Add(this.btnResolverPre);
            this.Controls.Add(this.txtExpresion);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnResolverPre;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Button btnResolverPost;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label1;
    }
}

