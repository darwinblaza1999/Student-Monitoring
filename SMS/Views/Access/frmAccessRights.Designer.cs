﻿
namespace SMS.Views.Access
{
    partial class frmAccessRights
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboposition = new System.Windows.Forms.ComboBox();
            this.dgvSystem = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbosystem = new System.Windows.Forms.ComboBox();
            this.cbomodule = new System.Windows.Forms.ComboBox();
            this.dgvModule = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsystem = new System.Windows.Forms.Button();
            this.btnmodule = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnmodule);
            this.panel1.Controls.Add(this.btnsystem);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvModule);
            this.panel1.Controls.Add(this.cbomodule);
            this.panel1.Controls.Add(this.cbosystem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvSystem);
            this.panel1.Controls.Add(this.cboposition);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(112, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 341);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position Name";
            // 
            // cboposition
            // 
            this.cboposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboposition.FormattingEnabled = true;
            this.cboposition.Location = new System.Drawing.Point(104, 9);
            this.cboposition.Name = "cboposition";
            this.cboposition.Size = new System.Drawing.Size(135, 23);
            this.cboposition.TabIndex = 1;
            // 
            // dgvSystem
            // 
            this.dgvSystem.AllowUserToAddRows = false;
            this.dgvSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystem.Location = new System.Drawing.Point(19, 76);
            this.dgvSystem.Name = "dgvSystem";
            this.dgvSystem.RowHeadersVisible = false;
            this.dgvSystem.Size = new System.Drawing.Size(282, 95);
            this.dgvSystem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "System Name";
            // 
            // cbosystem
            // 
            this.cbosystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosystem.FormattingEnabled = true;
            this.cbosystem.Location = new System.Drawing.Point(104, 43);
            this.cbosystem.Name = "cbosystem";
            this.cbosystem.Size = new System.Drawing.Size(135, 23);
            this.cbosystem.TabIndex = 4;
            // 
            // cbomodule
            // 
            this.cbomodule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomodule.FormattingEnabled = true;
            this.cbomodule.Location = new System.Drawing.Point(111, 183);
            this.cbomodule.Name = "cbomodule";
            this.cbomodule.Size = new System.Drawing.Size(128, 23);
            this.cbomodule.TabIndex = 6;
            this.cbomodule.SelectedIndexChanged += new System.EventHandler(this.cbomodule_SelectedIndexChanged);
            // 
            // dgvModule
            // 
            this.dgvModule.AllowUserToAddRows = false;
            this.dgvModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModule.Location = new System.Drawing.Point(19, 213);
            this.dgvModule.Name = "dgvModule";
            this.dgvModule.RowHeadersVisible = false;
            this.dgvModule.Size = new System.Drawing.Size(282, 95);
            this.dgvModule.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Module Name";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(217, 316);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(67, 23);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 347);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(436, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 338);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Access";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Rights";
            // 
            // btnsystem
            // 
            this.btnsystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsystem.Location = new System.Drawing.Point(245, 43);
            this.btnsystem.Name = "btnsystem";
            this.btnsystem.Size = new System.Drawing.Size(55, 24);
            this.btnsystem.TabIndex = 10;
            this.btnsystem.Text = "+Add";
            this.btnsystem.UseVisualStyleBackColor = true;
            this.btnsystem.Click += new System.EventHandler(this.btnsystem_Click);
            // 
            // btnmodule
            // 
            this.btnmodule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodule.Location = new System.Drawing.Point(249, 183);
            this.btnmodule.Name = "btnmodule";
            this.btnmodule.Size = new System.Drawing.Size(51, 24);
            this.btnmodule.TabIndex = 10;
            this.btnmodule.Text = "+ Add";
            this.btnmodule.UseVisualStyleBackColor = true;
            this.btnmodule.Click += new System.EventHandler(this.btnmodule_Click);
            // 
            // frmAccessRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmAccessRights";
            this.Text = "frmAccessRights";
            this.Load += new System.EventHandler(this.frmAccessRights_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboposition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbomodule;
        private System.Windows.Forms.ComboBox cbosystem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSystem;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvModule;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnmodule;
        private System.Windows.Forms.Button btnsystem;
    }
}