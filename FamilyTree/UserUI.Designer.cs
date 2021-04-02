
namespace FamilyTree
{
    partial class UserUI
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxForData = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonLower = new System.Windows.Forms.RadioButton();
            this.radioButtonUpper = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTargetBirthYear = new System.Windows.Forms.TextBox();
            this.txtTargetLastName = new System.Windows.Forms.TextBox();
            this.txtTargetFirstName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBoxForResult = new System.Windows.Forms.GroupBox();
            this.lblNationalityNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxForData.SuspendLayout();
            this.groupBoxForResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(234, 338);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(222, 78);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "ARAMAYI BAŞLAT";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxForData
            // 
            this.groupBoxForData.Controls.Add(this.label5);
            this.groupBoxForData.Controls.Add(this.radioButtonLower);
            this.groupBoxForData.Controls.Add(this.radioButtonUpper);
            this.groupBoxForData.Controls.Add(this.label4);
            this.groupBoxForData.Controls.Add(this.label3);
            this.groupBoxForData.Controls.Add(this.label2);
            this.groupBoxForData.Controls.Add(this.label1);
            this.groupBoxForData.Controls.Add(this.txtTargetBirthYear);
            this.groupBoxForData.Controls.Add(this.txtTargetLastName);
            this.groupBoxForData.Controls.Add(this.txtTargetFirstName);
            this.groupBoxForData.Controls.Add(this.txtId);
            this.groupBoxForData.Controls.Add(this.btnSearch);
            this.groupBoxForData.Font = new System.Drawing.Font("Playfair Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxForData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxForData.Name = "groupBoxForData";
            this.groupBoxForData.Size = new System.Drawing.Size(700, 435);
            this.groupBoxForData.TabIndex = 1;
            this.groupBoxForData.TabStop = false;
            this.groupBoxForData.Text = "BİLGİLERİNİZİ GİRİNİZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(223, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "* Ulaşmak istediğiniz soy tipini seçiniz.";
            // 
            // radioButtonLower
            // 
            this.radioButtonLower.AutoSize = true;
            this.radioButtonLower.Location = new System.Drawing.Point(370, 298);
            this.radioButtonLower.Name = "radioButtonLower";
            this.radioButtonLower.Size = new System.Drawing.Size(95, 31);
            this.radioButtonLower.TabIndex = 10;
            this.radioButtonLower.TabStop = true;
            this.radioButtonLower.Text = "Alt Soy";
            this.radioButtonLower.UseVisualStyleBackColor = true;
            this.radioButtonLower.CheckedChanged += new System.EventHandler(this.radioButtonLower_CheckedChanged);
            // 
            // radioButtonUpper
            // 
            this.radioButtonUpper.AutoSize = true;
            this.radioButtonUpper.Location = new System.Drawing.Point(226, 298);
            this.radioButtonUpper.Name = "radioButtonUpper";
            this.radioButtonUpper.Size = new System.Drawing.Size(98, 31);
            this.radioButtonUpper.TabIndex = 9;
            this.radioButtonUpper.TabStop = true;
            this.radioButtonUpper.Text = "Üst Soy";
            this.radioButtonUpper.UseVisualStyleBackColor = true;
            this.radioButtonUpper.CheckedChanged += new System.EventHandler(this.radioButtonUpper_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(222, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yakınınızın Doğum Yılını Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(222, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yakınınızın Soyadını Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(222, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yakınınızın Adını Giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(222, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC Kimlik Numaranızı Giriniz";
            // 
            // txtTargetBirthYear
            // 
            this.txtTargetBirthYear.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTargetBirthYear.Location = new System.Drawing.Point(210, 241);
            this.txtTargetBirthYear.Name = "txtTargetBirthYear";
            this.txtTargetBirthYear.Size = new System.Drawing.Size(264, 28);
            this.txtTargetBirthYear.TabIndex = 4;
            // 
            // txtTargetLastName
            // 
            this.txtTargetLastName.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTargetLastName.Location = new System.Drawing.Point(210, 184);
            this.txtTargetLastName.Name = "txtTargetLastName";
            this.txtTargetLastName.Size = new System.Drawing.Size(264, 28);
            this.txtTargetLastName.TabIndex = 3;
            // 
            // txtTargetFirstName
            // 
            this.txtTargetFirstName.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTargetFirstName.Location = new System.Drawing.Point(210, 127);
            this.txtTargetFirstName.Name = "txtTargetFirstName";
            this.txtTargetFirstName.Size = new System.Drawing.Size(264, 28);
            this.txtTargetFirstName.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(210, 70);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(264, 28);
            this.txtId.TabIndex = 1;
            // 
            // groupBoxForResult
            // 
            this.groupBoxForResult.Controls.Add(this.lblNationalityNumber);
            this.groupBoxForResult.Controls.Add(this.label6);
            this.groupBoxForResult.Font = new System.Drawing.Font("Playfair Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxForResult.Location = new System.Drawing.Point(12, 453);
            this.groupBoxForResult.Name = "groupBoxForResult";
            this.groupBoxForResult.Size = new System.Drawing.Size(700, 97);
            this.groupBoxForResult.TabIndex = 2;
            this.groupBoxForResult.TabStop = false;
            this.groupBoxForResult.Text = "SONUÇ";
            // 
            // lblNationalityNumber
            // 
            this.lblNationalityNumber.AutoSize = true;
            this.lblNationalityNumber.Font = new System.Drawing.Font("Playfair Display", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNationalityNumber.ForeColor = System.Drawing.Color.Blue;
            this.lblNationalityNumber.Location = new System.Drawing.Point(382, 35);
            this.lblNationalityNumber.Name = "lblNationalityNumber";
            this.lblNationalityNumber.Size = new System.Drawing.Size(138, 32);
            this.lblNationalityNumber.TabIndex = 1;
            this.lblNationalityNumber.Text = "Bekleyiniz...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(369, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Aradağınız kişinin TC kimlik numarası : ";
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(724, 562);
            this.Controls.Add(this.groupBoxForResult);
            this.Controls.Add(this.groupBoxForData);
            this.Name = "UserUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserUI_Load);
            this.groupBoxForData.ResumeLayout(false);
            this.groupBoxForData.PerformLayout();
            this.groupBoxForResult.ResumeLayout(false);
            this.groupBoxForResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxForData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTargetBirthYear;
        private System.Windows.Forms.TextBox txtTargetLastName;
        private System.Windows.Forms.TextBox txtTargetFirstName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupBoxForResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonLower;
        private System.Windows.Forms.RadioButton radioButtonUpper;
        private System.Windows.Forms.Label lblNationalityNumber;
        private System.Windows.Forms.Label label6;
    }
}

