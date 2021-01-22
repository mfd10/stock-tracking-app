
namespace oop
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fruitBtn = new System.Windows.Forms.Button();
            this.meatBtn = new System.Windows.Forms.Button();
            this.dairyBtn = new System.Windows.Forms.Button();
            this.vegetableBtn = new System.Windows.Forms.Button();
            this.coffeeBtn = new System.Windows.Forms.Button();
            this.snackBtn = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.twoBtn = new System.Windows.Forms.Button();
            this.tenBtn = new System.Windows.Forms.Button();
            this.fiftyBtn = new System.Windows.Forms.Button();
            this.twentyBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.hundredBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.crudBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.reminderBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fruitBtn
            // 
            this.fruitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fruitBtn.Location = new System.Drawing.Point(34, 77);
            this.fruitBtn.Name = "fruitBtn";
            this.fruitBtn.Size = new System.Drawing.Size(129, 42);
            this.fruitBtn.TabIndex = 1;
            this.fruitBtn.Text = "Fruit";
            this.fruitBtn.UseVisualStyleBackColor = false;
            this.fruitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // meatBtn
            // 
            this.meatBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.meatBtn.Location = new System.Drawing.Point(523, 77);
            this.meatBtn.Name = "meatBtn";
            this.meatBtn.Size = new System.Drawing.Size(129, 42);
            this.meatBtn.TabIndex = 2;
            this.meatBtn.Text = "Meat Products";
            this.meatBtn.UseVisualStyleBackColor = false;
            this.meatBtn.Click += new System.EventHandler(this.meatBtn_Click);
            // 
            // dairyBtn
            // 
            this.dairyBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dairyBtn.Location = new System.Drawing.Point(399, 77);
            this.dairyBtn.Name = "dairyBtn";
            this.dairyBtn.Size = new System.Drawing.Size(129, 42);
            this.dairyBtn.TabIndex = 3;
            this.dairyBtn.Text = "Dairies and Cereal";
            this.dairyBtn.UseVisualStyleBackColor = false;
            this.dairyBtn.Click += new System.EventHandler(this.dairyBtn_Click);
            // 
            // vegetableBtn
            // 
            this.vegetableBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vegetableBtn.Location = new System.Drawing.Point(159, 77);
            this.vegetableBtn.Name = "vegetableBtn";
            this.vegetableBtn.Size = new System.Drawing.Size(129, 42);
            this.vegetableBtn.TabIndex = 4;
            this.vegetableBtn.Text = "Vegetable";
            this.vegetableBtn.UseVisualStyleBackColor = false;
            this.vegetableBtn.Click += new System.EventHandler(this.vegetableBtn_Click);
            // 
            // coffeeBtn
            // 
            this.coffeeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.coffeeBtn.Location = new System.Drawing.Point(276, 77);
            this.coffeeBtn.Name = "coffeeBtn";
            this.coffeeBtn.Size = new System.Drawing.Size(129, 42);
            this.coffeeBtn.TabIndex = 5;
            this.coffeeBtn.Text = "Dried Fuits and Coffee";
            this.coffeeBtn.UseVisualStyleBackColor = false;
            this.coffeeBtn.Click += new System.EventHandler(this.coffeeBtn_Click);
            // 
            // snackBtn
            // 
            this.snackBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.snackBtn.Location = new System.Drawing.Point(644, 77);
            this.snackBtn.Name = "snackBtn";
            this.snackBtn.Size = new System.Drawing.Size(129, 42);
            this.snackBtn.TabIndex = 6;
            this.snackBtn.Text = "Snack Food";
            this.snackBtn.UseVisualStyleBackColor = false;
            this.snackBtn.Click += new System.EventHandler(this.snackBtn_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(34, 125);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(739, 526);
            this.dataGridViewProducts.TabIndex = 7;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            this.dataGridViewProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellDoubleClick);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(1033, 160);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersWidth = 51;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(316, 363);
            this.dataGridViewResult.TabIndex = 8;
            this.dataGridViewResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_CellContentClick);
            // 
            // twoBtn
            // 
            this.twoBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.twoBtn.Location = new System.Drawing.Point(1033, 3);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(167, 57);
            this.twoBtn.TabIndex = 9;
            this.twoBtn.Text = "200₺";
            this.twoBtn.UseVisualStyleBackColor = false;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // tenBtn
            // 
            this.tenBtn.BackColor = System.Drawing.Color.IndianRed;
            this.tenBtn.Location = new System.Drawing.Point(1033, 105);
            this.tenBtn.Name = "tenBtn";
            this.tenBtn.Size = new System.Drawing.Size(167, 55);
            this.tenBtn.TabIndex = 10;
            this.tenBtn.Text = "10₺";
            this.tenBtn.UseVisualStyleBackColor = false;
            this.tenBtn.Click += new System.EventHandler(this.tenBtn_Click);
            // 
            // fiftyBtn
            // 
            this.fiftyBtn.BackColor = System.Drawing.Color.Khaki;
            this.fiftyBtn.Location = new System.Drawing.Point(1033, 57);
            this.fiftyBtn.Name = "fiftyBtn";
            this.fiftyBtn.Size = new System.Drawing.Size(167, 55);
            this.fiftyBtn.TabIndex = 12;
            this.fiftyBtn.Text = "50₺";
            this.fiftyBtn.UseVisualStyleBackColor = false;
            this.fiftyBtn.Click += new System.EventHandler(this.fiftyBtn_Click);
            // 
            // twentyBtn
            // 
            this.twentyBtn.BackColor = System.Drawing.Color.LightGreen;
            this.twentyBtn.Location = new System.Drawing.Point(1197, 57);
            this.twentyBtn.Name = "twentyBtn";
            this.twentyBtn.Size = new System.Drawing.Size(152, 55);
            this.twentyBtn.TabIndex = 15;
            this.twentyBtn.Text = "20₺";
            this.twentyBtn.UseVisualStyleBackColor = false;
            this.twentyBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.fiveBtn.Location = new System.Drawing.Point(1197, 105);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(152, 55);
            this.fiveBtn.TabIndex = 14;
            this.fiveBtn.Text = "5₺";
            this.fiveBtn.UseVisualStyleBackColor = false;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // hundredBtn
            // 
            this.hundredBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hundredBtn.Location = new System.Drawing.Point(1197, 3);
            this.hundredBtn.Name = "hundredBtn";
            this.hundredBtn.Size = new System.Drawing.Size(152, 57);
            this.hundredBtn.TabIndex = 13;
            this.hundredBtn.Text = "100₺";
            this.hundredBtn.UseVisualStyleBackColor = false;
            this.hundredBtn.Click += new System.EventHandler(this.hundredBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.Linen;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(1174, 525);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(175, 45);
            this.resultBox.TabIndex = 16;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(1060, 532);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(98, 38);
            this.totalLabel.TabIndex = 17;
            this.totalLabel.Text = "Total:";
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // crudBtn
            // 
            this.crudBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.crudBtn.Location = new System.Drawing.Point(1339, 745);
            this.crudBtn.Name = "crudBtn";
            this.crudBtn.Size = new System.Drawing.Size(10, 10);
            this.crudBtn.TabIndex = 18;
            this.crudBtn.Text = "Products ";
            this.crudBtn.UseVisualStyleBackColor = false;
            this.crudBtn.Click += new System.EventHandler(this.crudBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Candara Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(34, 657);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(231, 46);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Candara Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(276, 657);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(256, 46);
            this.updateBtn.TabIndex = 20;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Candara Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(538, 657);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(235, 46);
            this.deleteBtn.TabIndex = 21;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // reminderBox
            // 
            this.reminderBox.BackColor = System.Drawing.Color.Linen;
            this.reminderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderBox.Location = new System.Drawing.Point(1174, 586);
            this.reminderBox.Name = "reminderBox";
            this.reminderBox.Size = new System.Drawing.Size(175, 45);
            this.reminderBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(991, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Reminder:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 46);
            this.label2.TabIndex = 25;
            this.label2.Text = "PRODUCTS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 788);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reminderBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.crudBtn);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.twentyBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.hundredBtn);
            this.Controls.Add(this.fiftyBtn);
            this.Controls.Add(this.tenBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.snackBtn);
            this.Controls.Add(this.coffeeBtn);
            this.Controls.Add(this.vegetableBtn);
            this.Controls.Add(this.dairyBtn);
            this.Controls.Add(this.meatBtn);
            this.Controls.Add(this.fruitBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button fruitBtn;
        private System.Windows.Forms.Button meatBtn;
        private System.Windows.Forms.Button dairyBtn;
        private System.Windows.Forms.Button vegetableBtn;
        private System.Windows.Forms.Button coffeeBtn;
        private System.Windows.Forms.Button snackBtn;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button tenBtn;
        private System.Windows.Forms.Button fiftyBtn;
        private System.Windows.Forms.Button twentyBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button hundredBtn;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button crudBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox reminderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

