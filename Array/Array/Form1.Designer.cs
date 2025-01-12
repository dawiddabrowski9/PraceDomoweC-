namespace Array
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
            this.RemoveFirst = new System.Windows.Forms.Button();
            this.RemoveLast = new System.Windows.Forms.Button();
            this.AddFirst = new System.Windows.Forms.Button();
            this.AddLast = new System.Windows.Forms.Button();
            this.NodeValue = new System.Windows.Forms.NumericUpDown();
            this.Result = new System.Windows.Forms.Label();
            this.ToString = new System.Windows.Forms.Button();
            this.ToArray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NodeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoveFirst
            // 
            this.RemoveFirst.Location = new System.Drawing.Point(612, 165);
            this.RemoveFirst.Name = "RemoveFirst";
            this.RemoveFirst.Size = new System.Drawing.Size(75, 23);
            this.RemoveFirst.TabIndex = 0;
            this.RemoveFirst.Text = "RemoveFirst";
            this.RemoveFirst.UseVisualStyleBackColor = true;
            this.RemoveFirst.Click += new System.EventHandler(this.RemoveFirst_Click);
            // 
            // RemoveLast
            // 
            this.RemoveLast.Location = new System.Drawing.Point(612, 274);
            this.RemoveLast.Name = "RemoveLast";
            this.RemoveLast.Size = new System.Drawing.Size(75, 23);
            this.RemoveLast.TabIndex = 1;
            this.RemoveLast.Text = "RemoveLast";
            this.RemoveLast.UseVisualStyleBackColor = true;
            this.RemoveLast.Click += new System.EventHandler(this.RemoveLast_Click);
            // 
            // AddFirst
            // 
            this.AddFirst.Location = new System.Drawing.Point(84, 165);
            this.AddFirst.Name = "AddFirst";
            this.AddFirst.Size = new System.Drawing.Size(75, 23);
            this.AddFirst.TabIndex = 2;
            this.AddFirst.Text = "AddFirst";
            this.AddFirst.UseVisualStyleBackColor = true;
            this.AddFirst.Click += new System.EventHandler(this.AddFirst_Click);
            // 
            // AddLast
            // 
            this.AddLast.Location = new System.Drawing.Point(84, 274);
            this.AddLast.Name = "AddLast";
            this.AddLast.Size = new System.Drawing.Size(75, 23);
            this.AddLast.TabIndex = 3;
            this.AddLast.Text = "AddLast";
            this.AddLast.UseVisualStyleBackColor = true;
            this.AddLast.Click += new System.EventHandler(this.AddLast_Click);
            // 
            // NodeValue
            // 
            this.NodeValue.Hexadecimal = true;
            this.NodeValue.Location = new System.Drawing.Point(84, 139);
            this.NodeValue.Name = "NodeValue";
            this.NodeValue.Size = new System.Drawing.Size(75, 20);
            this.NodeValue.TabIndex = 4;
            this.NodeValue.ValueChanged += new System.EventHandler(this.NodeValue_ValueChanged);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(292, 284);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 5;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // ToString
            // 
            this.ToString.Location = new System.Drawing.Point(348, 328);
            this.ToString.Name = "ToString";
            this.ToString.Size = new System.Drawing.Size(75, 23);
            this.ToString.TabIndex = 6;
            this.ToString.Text = "ToString";
            this.ToString.UseVisualStyleBackColor = true;
            this.ToString.Click += new System.EventHandler(this.ToString_Click);
            // 
            // ToArray
            // 
            this.ToArray.Location = new System.Drawing.Point(348, 357);
            this.ToArray.Name = "ToArray";
            this.ToArray.Size = new System.Drawing.Size(75, 23);
            this.ToArray.TabIndex = 7;
            this.ToArray.Text = "ToArray";
            this.ToArray.UseVisualStyleBackColor = true;
            this.ToArray.Click += new System.EventHandler(this.ToArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToArray);
            this.Controls.Add(this.ToString);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.NodeValue);
            this.Controls.Add(this.AddLast);
            this.Controls.Add(this.AddFirst);
            this.Controls.Add(this.RemoveLast);
            this.Controls.Add(this.RemoveFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NodeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveFirst;
        private System.Windows.Forms.Button RemoveLast;
        private System.Windows.Forms.Button AddFirst;
        private System.Windows.Forms.Button AddLast;
        private System.Windows.Forms.NumericUpDown NodeValue;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button ToString;
        private System.Windows.Forms.Button ToArray;
    }
}

