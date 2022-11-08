
namespace TreeVisualizer
{
    partial class MainWindow
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Control = new System.Windows.Forms.GroupBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txt_Remove = new System.Windows.Forms.TextBox();
            this.txt_Insert = new System.Windows.Forms.TextBox();
            this.tabPage_BST = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.groupBox_Control.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBox_Control, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(771, 598);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // groupBox_Control
            // 
            this.groupBox_Control.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox_Control.Controls.Add(this.label1);
            this.groupBox_Control.Controls.Add(this.btn_Remove);
            this.groupBox_Control.Controls.Add(this.btn_Insert);
            this.groupBox_Control.Controls.Add(this.txt_Remove);
            this.groupBox_Control.Controls.Add(this.txt_Insert);
            this.groupBox_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Control.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_Control.Location = new System.Drawing.Point(2, 519);
            this.groupBox_Control.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Control.Name = "groupBox_Control";
            this.groupBox_Control.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Control.Size = new System.Drawing.Size(767, 77);
            this.groupBox_Control.TabIndex = 2;
            this.groupBox_Control.TabStop = false;
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Remove.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.Black;
            this.btn_Remove.Location = new System.Drawing.Point(199, 46);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(80, 24);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.Text = "REMOVE";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Insert.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Insert.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ForeColor = System.Drawing.Color.Black;
            this.btn_Insert.Location = new System.Drawing.Point(199, 17);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 24);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_Remove
            // 
            this.txt_Remove.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Remove.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Remove.Location = new System.Drawing.Point(7, 45);
            this.txt_Remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Remove.Name = "txt_Remove";
            this.txt_Remove.Size = new System.Drawing.Size(188, 27);
            this.txt_Remove.TabIndex = 0;
            this.txt_Remove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Insert
            // 
            this.txt_Insert.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Insert.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Insert.Location = new System.Drawing.Point(7, 17);
            this.txt_Insert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Insert.Name = "txt_Insert";
            this.txt_Insert.Size = new System.Drawing.Size(188, 27);
            this.txt_Insert.TabIndex = 0;
            this.txt_Insert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage_BST
            // 
            this.tabPage_BST.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage_BST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage_BST.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_BST.Location = new System.Drawing.Point(4, 22);
            this.tabPage_BST.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_BST.Name = "tabPage_BST";
            this.tabPage_BST.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_BST.Size = new System.Drawing.Size(759, 487);
            this.tabPage_BST.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_BST);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(767, 513);
            this.tabControl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(500, 17);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(257, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Árbol Binario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 598);
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.groupBox_Control.ResumeLayout(false);
            this.groupBox_Control.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox_Control;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox txt_Remove;
        private System.Windows.Forms.TextBox txt_Insert;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_BST;
        private System.Windows.Forms.Label label1;
    }
}