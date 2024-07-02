namespace UMMAPARKSYST
{
    partial class ParkingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkingForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            labelId = new Label();
            txtLocation = new TextBox();
            txtSlotno = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            textSearch = new TextBox();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(979, 735);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(button6, 0, 4);
            tableLayoutPanel5.Controls.Add(button7, 0, 3);
            tableLayoutPanel5.Controls.Add(button8, 0, 2);
            tableLayoutPanel5.Controls.Add(button9, 0, 1);
            tableLayoutPanel5.Controls.Add(button10, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(238, 729);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.IndianRed;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(3, 583);
            button6.Name = "button6";
            button6.Size = new Size(232, 143);
            button6.TabIndex = 4;
            button6.Text = "EXIT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.IndianRed;
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(3, 438);
            button7.Name = "button7";
            button7.Size = new Size(232, 139);
            button7.TabIndex = 3;
            button7.Text = "REPORT";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.IndianRed;
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(3, 293);
            button8.Name = "button8";
            button8.Size = new Size(232, 139);
            button8.TabIndex = 2;
            button8.Text = "DELETE";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.IndianRed;
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(3, 148);
            button9.Name = "button9";
            button9.Size = new Size(232, 139);
            button9.TabIndex = 1;
            button9.Text = "EDIT";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.IndianRed;
            button10.Dock = DockStyle.Fill;
            button10.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(3, 3);
            button10.Name = "button10";
            button10.Size = new Size(232, 139);
            button10.TabIndex = 0;
            button10.Text = "ADD";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(247, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 34.90991F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 65.09009F));
            tableLayoutPanel2.Size = new Size(729, 729);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(txtLocation);
            panel1.Controls.Add(txtSlotno);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 257);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 469);
            panel1.TabIndex = 0;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.BackColor = Color.Transparent;
            labelId.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelId.ForeColor = Color.DarkOrange;
            labelId.Location = new Point(31, 6);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 45);
            labelId.TabIndex = 12;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(31, 264);
            txtLocation.Name = "txtLocation";
            txtLocation.PasswordChar = '*';
            txtLocation.Size = new Size(294, 31);
            txtLocation.TabIndex = 10;
            // 
            // txtSlotno
            // 
            txtSlotno.Location = new Point(31, 134);
            txtSlotno.Name = "txtSlotno";
            txtSlotno.Size = new Size(294, 31);
            txtSlotno.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(31, 205);
            label3.Name = "label3";
            label3.Size = new Size(178, 45);
            label3.TabIndex = 8;
            label3.Text = "LOCATION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(31, 74);
            label4.Name = "label4";
            label4.Size = new Size(162, 45);
            label4.TabIndex = 7;
            label4.Text = "SLOT NO:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(363, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 313);
            dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textSearch);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(723, 248);
            panel3.TabIndex = 1;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(3, 133);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(294, 31);
            textSearch.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(3, 73);
            label2.Name = "label2";
            label2.Size = new Size(144, 45);
            label2.TabIndex = 10;
            label2.Text = "SEARCH";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.75F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(button5, 0, 4);
            tableLayoutPanel4.Controls.Add(button4, 0, 3);
            tableLayoutPanel4.Controls.Add(button3, 0, 2);
            tableLayoutPanel4.Controls.Add(button2, 0, 1);
            tableLayoutPanel4.Controls.Add(button1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(54, 497);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(3, 399);
            button5.Name = "button5";
            button5.Size = new Size(48, 95);
            button5.TabIndex = 4;
            button5.Text = "EXIT";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(3, 300);
            button4.Name = "button4";
            button4.Size = new Size(48, 93);
            button4.TabIndex = 3;
            button4.Text = "VISTORS";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(3, 201);
            button3.Name = "button3";
            button3.Size = new Size(48, 93);
            button3.TabIndex = 2;
            button3.Text = "DEPARTUTER";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 102);
            button2.Name = "button2";
            button2.Size = new Size(48, 93);
            button2.TabIndex = 1;
            button2.Text = "PARKING";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(48, 93);
            button1.TabIndex = 0;
            button1.Text = "ARRIVAL";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(36, 163);
            label1.Name = "label1";
            label1.Size = new Size(469, 108);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Umma Car \r\n      Parking System";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(63, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(134, 497);
            panel2.TabIndex = 1;
            // 
            // ParkingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 735);
            Controls.Add(tableLayoutPanel1);
            Name = "ParkingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkingForm";
            Load += ParkingForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox txtLocation;
        private TextBox txtSlotno;
        private Label label3;
        private Label label4;
        private Label labelId;
        private Panel panel3;
        private TextBox textSearch;
        private Label label2;
    }
}