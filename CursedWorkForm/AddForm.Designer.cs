namespace CursedWorkForm
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.labelDrinkType = new System.Windows.Forms.Label();
            this.labelDrinkGrade = new System.Windows.Forms.Label();
            this.labelDrinkHard = new System.Windows.Forms.Label();
            this.labelDrinkPrice = new System.Windows.Forms.Label();
            this.labelDrinkWeight = new System.Windows.Forms.Label();
            this.drinkGrade = new System.Windows.Forms.TextBox();
            this.drinkHard = new System.Windows.Forms.TextBox();
            this.drinkPrice = new System.Windows.Forms.TextBox();
            this.drinkWeight = new System.Windows.Forms.TextBox();
            this.AddNote = new System.Windows.Forms.Button();
            this.AddPicture = new System.Windows.Forms.Button();
            this.searchPicture = new System.Windows.Forms.OpenFileDialog();
            this.labelIncorrectInput = new System.Windows.Forms.Label();
            this.drinkTypeChose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDrinkType
            // 
            this.labelDrinkType.AutoSize = true;
            this.labelDrinkType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrinkType.Location = new System.Drawing.Point(33, 32);
            this.labelDrinkType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrinkType.Name = "labelDrinkType";
            this.labelDrinkType.Size = new System.Drawing.Size(98, 19);
            this.labelDrinkType.TabIndex = 0;
            this.labelDrinkType.Text = "Тип напитка:";
            // 
            // labelDrinkGrade
            // 
            this.labelDrinkGrade.AutoSize = true;
            this.labelDrinkGrade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrinkGrade.Location = new System.Drawing.Point(33, 93);
            this.labelDrinkGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrinkGrade.Name = "labelDrinkGrade";
            this.labelDrinkGrade.Size = new System.Drawing.Size(46, 19);
            this.labelDrinkGrade.TabIndex = 1;
            this.labelDrinkGrade.Text = "Сорт:";
            // 
            // labelDrinkHard
            // 
            this.labelDrinkHard.AutoSize = true;
            this.labelDrinkHard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrinkHard.Location = new System.Drawing.Point(33, 151);
            this.labelDrinkHard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrinkHard.Name = "labelDrinkHard";
            this.labelDrinkHard.Size = new System.Drawing.Size(79, 19);
            this.labelDrinkHard.TabIndex = 2;
            this.labelDrinkHard.Text = "Терпкость:";
            // 
            // labelDrinkPrice
            // 
            this.labelDrinkPrice.AutoSize = true;
            this.labelDrinkPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrinkPrice.Location = new System.Drawing.Point(35, 219);
            this.labelDrinkPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrinkPrice.Name = "labelDrinkPrice";
            this.labelDrinkPrice.Size = new System.Drawing.Size(62, 19);
            this.labelDrinkPrice.TabIndex = 3;
            this.labelDrinkPrice.Text = "Цена р.:";
            // 
            // labelDrinkWeight
            // 
            this.labelDrinkWeight.AutoSize = true;
            this.labelDrinkWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrinkWeight.Location = new System.Drawing.Point(33, 286);
            this.labelDrinkWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrinkWeight.Name = "labelDrinkWeight";
            this.labelDrinkWeight.Size = new System.Drawing.Size(48, 19);
            this.labelDrinkWeight.TabIndex = 4;
            this.labelDrinkWeight.Text = "Вес г.:";
            // 
            // drinkGrade
            // 
            this.drinkGrade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drinkGrade.Location = new System.Drawing.Point(177, 85);
            this.drinkGrade.Margin = new System.Windows.Forms.Padding(4);
            this.drinkGrade.Name = "drinkGrade";
            this.drinkGrade.Size = new System.Drawing.Size(174, 26);
            this.drinkGrade.TabIndex = 7;
            // 
            // drinkHard
            // 
            this.drinkHard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drinkHard.Location = new System.Drawing.Point(177, 148);
            this.drinkHard.Margin = new System.Windows.Forms.Padding(4);
            this.drinkHard.Name = "drinkHard";
            this.drinkHard.Size = new System.Drawing.Size(174, 26);
            this.drinkHard.TabIndex = 8;
            // 
            // drinkPrice
            // 
            this.drinkPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drinkPrice.Location = new System.Drawing.Point(177, 215);
            this.drinkPrice.Margin = new System.Windows.Forms.Padding(4);
            this.drinkPrice.Name = "drinkPrice";
            this.drinkPrice.Size = new System.Drawing.Size(174, 26);
            this.drinkPrice.TabIndex = 9;
            // 
            // drinkWeight
            // 
            this.drinkWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drinkWeight.Location = new System.Drawing.Point(177, 282);
            this.drinkWeight.Margin = new System.Windows.Forms.Padding(4);
            this.drinkWeight.Name = "drinkWeight";
            this.drinkWeight.Size = new System.Drawing.Size(174, 26);
            this.drinkWeight.TabIndex = 10;
            // 
            // AddNote
            // 
            this.AddNote.Location = new System.Drawing.Point(105, 392);
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(150, 50);
            this.AddNote.TabIndex = 12;
            this.AddNote.Text = "Добавить";
            this.AddNote.UseVisualStyleBackColor = true;
            // 
            // AddPicture
            // 
            this.AddPicture.Location = new System.Drawing.Point(94, 335);
            this.AddPicture.Name = "AddPicture";
            this.AddPicture.Size = new System.Drawing.Size(174, 35);
            this.AddPicture.TabIndex = 13;
            this.AddPicture.Text = "Добавить картинку";
            this.AddPicture.UseVisualStyleBackColor = true;
            // 
            // searchPicture
            // 
            this.searchPicture.FileName = "openFileDialog1";
            this.searchPicture.InitialDirectory = "C:\\Users\\karli\\OneDrive\\Рабочий стол";
            // 
            // labelIncorrectInput
            // 
            this.labelIncorrectInput.AutoSize = true;
            this.labelIncorrectInput.ForeColor = System.Drawing.Color.Maroon;
            this.labelIncorrectInput.Location = new System.Drawing.Point(105, 459);
            this.labelIncorrectInput.Name = "labelIncorrectInput";
            this.labelIncorrectInput.Size = new System.Drawing.Size(151, 19);
            this.labelIncorrectInput.TabIndex = 14;
            this.labelIncorrectInput.Text = "*Некорректный ввод";
            this.labelIncorrectInput.Visible = false;
            // 
            // drinkTypeChose
            // 
            this.drinkTypeChose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drinkTypeChose.Items.AddRange(new object[] {
            "Чай",
            "Кофе"});
            this.drinkTypeChose.Location = new System.Drawing.Point(177, 28);
            this.drinkTypeChose.Name = "drinkTypeChose";
            this.drinkTypeChose.Size = new System.Drawing.Size(174, 27);
            this.drinkTypeChose.TabIndex = 0;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 501);
            this.Controls.Add(this.drinkTypeChose);
            this.Controls.Add(this.labelIncorrectInput);
            this.Controls.Add(this.AddPicture);
            this.Controls.Add(this.AddNote);
            this.Controls.Add(this.drinkWeight);
            this.Controls.Add(this.drinkPrice);
            this.Controls.Add(this.drinkHard);
            this.Controls.Add(this.drinkGrade);
            this.Controls.Add(this.labelDrinkWeight);
            this.Controls.Add(this.labelDrinkPrice);
            this.Controls.Add(this.labelDrinkHard);
            this.Controls.Add(this.labelDrinkGrade);
            this.Controls.Add(this.labelDrinkType);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "Справочник сортов чай и кофе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDrinkType;
        private System.Windows.Forms.Label labelDrinkGrade;
        private System.Windows.Forms.Label labelDrinkHard;
        private System.Windows.Forms.Label labelDrinkPrice;
        private System.Windows.Forms.Label labelDrinkWeight;
        private System.Windows.Forms.TextBox drinkGrade;
        private System.Windows.Forms.TextBox drinkHard;
        private System.Windows.Forms.TextBox drinkPrice;
        private System.Windows.Forms.TextBox drinkWeight;
        private System.Windows.Forms.Button AddNote;
        private System.Windows.Forms.Button AddPicture;
        private System.Windows.Forms.OpenFileDialog searchPicture;
        private System.Windows.Forms.Label labelIncorrectInput;
        private System.Windows.Forms.ComboBox drinkTypeChose;
    }
}