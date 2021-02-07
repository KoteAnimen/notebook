
namespace notebook
{
    partial class MoveForm
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
            this.firstRow = new System.Windows.Forms.NumericUpDown();
            this.secondRow = new System.Windows.Forms.NumericUpDown();
            this.MoveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondRow)).BeginInit();
            this.SuspendLayout();
            // 
            // firstRow
            // 
            this.firstRow.Location = new System.Drawing.Point(12, 42);
            this.firstRow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.firstRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstRow.Name = "firstRow";
            this.firstRow.Size = new System.Drawing.Size(200, 20);
            this.firstRow.TabIndex = 0;
            this.firstRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // secondRow
            // 
            this.secondRow.Location = new System.Drawing.Point(12, 94);
            this.secondRow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.secondRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondRow.Name = "secondRow";
            this.secondRow.Size = new System.Drawing.Size(200, 20);
            this.secondRow.TabIndex = 1;
            this.secondRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(12, 140);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(90, 31);
            this.MoveButton.TabIndex = 2;
            this.MoveButton.Text = "Переставить";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(122, 140);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 31);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер первой строки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер второй строки";
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 188);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.secondRow);
            this.Controls.Add(this.firstRow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoveForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Переставить строки";
            ((System.ComponentModel.ISupportInitialize)(this.firstRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown firstRow;
        private System.Windows.Forms.NumericUpDown secondRow;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}