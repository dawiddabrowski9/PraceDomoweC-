﻿namespace Tree_v0._001
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.treeView = new System.Windows.Forms.TreeView();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InOrder = new System.Windows.Forms.Button();
            this.PreOrder = new System.Windows.Forms.Button();
            this.PostOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(35, 151);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(120, 45);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(35, 101);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(268, 101);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(324, 430);
            this.treeView.TabIndex = 2;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(35, 223);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(120, 39);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // InOrder
            // 
            this.InOrder.Location = new System.Drawing.Point(35, 291);
            this.InOrder.Name = "InOrder";
            this.InOrder.Size = new System.Drawing.Size(120, 38);
            this.InOrder.TabIndex = 5;
            this.InOrder.Text = "InOrder";
            this.InOrder.UseVisualStyleBackColor = true;
            this.InOrder.Click += new System.EventHandler(this.InOrder_Click);
            // 
            // PreOrder
            // 
            this.PreOrder.Location = new System.Drawing.Point(40, 336);
            this.PreOrder.Name = "PreOrder";
            this.PreOrder.Size = new System.Drawing.Size(115, 41);
            this.PreOrder.TabIndex = 6;
            this.PreOrder.Text = "PreOrder";
            this.PreOrder.UseVisualStyleBackColor = true;
            this.PreOrder.Click += new System.EventHandler(this.PreOrder_Click);
            // 
            // PostOrder
            // 
            this.PostOrder.Location = new System.Drawing.Point(40, 393);
            this.PostOrder.Name = "PostOrder";
            this.PostOrder.Size = new System.Drawing.Size(115, 35);
            this.PostOrder.TabIndex = 7;
            this.PostOrder.Text = "PostOrder";
            this.PostOrder.UseVisualStyleBackColor = true;
            this.PostOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 552);
            this.Controls.Add(this.PostOrder);
            this.Controls.Add(this.PreOrder);
            this.Controls.Add(this.InOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InOrder;
        private System.Windows.Forms.Button PreOrder;
        private System.Windows.Forms.Button PostOrder;
    }
}

