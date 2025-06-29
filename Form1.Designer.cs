namespace MusicRoomRentProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRentName = new System.Windows.Forms.TextBox();
            this.txtRentPhone = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRoomRentFee = new System.Windows.Forms.TextBox();
            this.txtRentHour = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkGuitar = new System.Windows.Forms.CheckBox();
            this.chkBase = new System.Windows.Forms.CheckBox();
            this.chkKeyboard = new System.Windows.Forms.CheckBox();
            this.chkDrum = new System.Windows.Forms.CheckBox();
            this.txtGuitarQuantity = new System.Windows.Forms.TextBox();
            this.txtBaseQuantity = new System.Windows.Forms.TextBox();
            this.txtKeyboardQuantity = new System.Windows.Forms.TextBox();
            this.txtDrumQuantity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRentPay = new System.Windows.Forms.TextBox();
            this.rdoNotPaid = new System.Windows.Forms.RadioButton();
            this.rdoPaid = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรแกรมเช่าห้องซ้อมดนตรี";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อผู้เช่า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "เบอร์โทรผู้เช่า";
            // 
            // txtRentName
            // 
            this.txtRentName.Location = new System.Drawing.Point(148, 124);
            this.txtRentName.Name = "txtRentName";
            this.txtRentName.Size = new System.Drawing.Size(238, 20);
            this.txtRentName.TabIndex = 3;
            // 
            // txtRentPhone
            // 
            this.txtRentPhone.Location = new System.Drawing.Point(148, 167);
            this.txtRentPhone.Name = "txtRentPhone";
            this.txtRentPhone.Size = new System.Drawing.Size(238, 20);
            this.txtRentPhone.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.txtDrumQuantity);
            this.groupBox1.Controls.Add(this.txtKeyboardQuantity);
            this.groupBox1.Controls.Add(this.txtBaseQuantity);
            this.groupBox1.Controls.Add(this.txtGuitarQuantity);
            this.groupBox1.Controls.Add(this.chkDrum);
            this.groupBox1.Controls.Add(this.chkKeyboard);
            this.groupBox1.Controls.Add(this.chkBase);
            this.groupBox1.Controls.Add(this.chkGuitar);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtRentHour);
            this.groupBox1.Controls.Add(this.txtRoomRentFee);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(25, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 245);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลการเช่า";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "ค่าเช่าห้อง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(314, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "บาท/ชั่วโมง";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "จำนวนชั่วโมงที่เช่า";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "กีต้าร์ จำนวน";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(55, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "เบส จำนวน";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(55, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "คีย์บอร์ด จำนวน";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(55, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "กลอง จำนวน";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(286, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "ตัว (20 บาท/ตัว)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(286, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "ตัว (15 บาท/ตัว)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(286, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "ตัว (10 บาท/ตัว)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(286, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 18);
            this.label14.TabIndex = 10;
            this.label14.Text = "ตัว (30 บาท/ตัว)";
            // 
            // txtRoomRentFee
            // 
            this.txtRoomRentFee.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtRoomRentFee.ForeColor = System.Drawing.Color.White;
            this.txtRoomRentFee.Location = new System.Drawing.Point(176, 28);
            this.txtRoomRentFee.Name = "txtRoomRentFee";
            this.txtRoomRentFee.Size = new System.Drawing.Size(100, 20);
            this.txtRoomRentFee.TabIndex = 11;
            this.txtRoomRentFee.Text = "80";
            this.txtRoomRentFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRentHour
            // 
            this.txtRentHour.Location = new System.Drawing.Point(176, 59);
            this.txtRentHour.Name = "txtRentHour";
            this.txtRentHour.Size = new System.Drawing.Size(100, 20);
            this.txtRentHour.TabIndex = 12;
            this.txtRentHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(314, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 18);
            this.label15.TabIndex = 13;
            this.label15.Text = "ชั่วโมง";
            // 
            // chkGuitar
            // 
            this.chkGuitar.AutoSize = true;
            this.chkGuitar.Location = new System.Drawing.Point(28, 98);
            this.chkGuitar.Name = "chkGuitar";
            this.chkGuitar.Size = new System.Drawing.Size(15, 14);
            this.chkGuitar.TabIndex = 14;
            this.chkGuitar.UseVisualStyleBackColor = true;
            // 
            // chkBase
            // 
            this.chkBase.AutoSize = true;
            this.chkBase.Location = new System.Drawing.Point(28, 131);
            this.chkBase.Name = "chkBase";
            this.chkBase.Size = new System.Drawing.Size(15, 14);
            this.chkBase.TabIndex = 15;
            this.chkBase.UseVisualStyleBackColor = true;
            // 
            // chkKeyboard
            // 
            this.chkKeyboard.AutoSize = true;
            this.chkKeyboard.Location = new System.Drawing.Point(28, 166);
            this.chkKeyboard.Name = "chkKeyboard";
            this.chkKeyboard.Size = new System.Drawing.Size(15, 14);
            this.chkKeyboard.TabIndex = 16;
            this.chkKeyboard.UseVisualStyleBackColor = true;
            // 
            // chkDrum
            // 
            this.chkDrum.AutoSize = true;
            this.chkDrum.Location = new System.Drawing.Point(28, 203);
            this.chkDrum.Name = "chkDrum";
            this.chkDrum.Size = new System.Drawing.Size(15, 14);
            this.chkDrum.TabIndex = 17;
            this.chkDrum.UseVisualStyleBackColor = true;
            // 
            // txtGuitarQuantity
            // 
            this.txtGuitarQuantity.Location = new System.Drawing.Point(176, 92);
            this.txtGuitarQuantity.Name = "txtGuitarQuantity";
            this.txtGuitarQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtGuitarQuantity.TabIndex = 18;
            this.txtGuitarQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBaseQuantity
            // 
            this.txtBaseQuantity.Location = new System.Drawing.Point(176, 125);
            this.txtBaseQuantity.Name = "txtBaseQuantity";
            this.txtBaseQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBaseQuantity.TabIndex = 19;
            this.txtBaseQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKeyboardQuantity
            // 
            this.txtKeyboardQuantity.Location = new System.Drawing.Point(176, 160);
            this.txtKeyboardQuantity.Name = "txtKeyboardQuantity";
            this.txtKeyboardQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtKeyboardQuantity.TabIndex = 20;
            this.txtKeyboardQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDrumQuantity
            // 
            this.txtDrumQuantity.Location = new System.Drawing.Point(176, 197);
            this.txtDrumQuantity.Name = "txtDrumQuantity";
            this.txtDrumQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtDrumQuantity.TabIndex = 21;
            this.txtDrumQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(22, 514);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 20);
            this.label16.TabIndex = 6;
            this.label16.Text = "จำนวนเงินที่ต้องชำระ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(382, 514);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "บาท";
            // 
            // txtRentPay
            // 
            this.txtRentPay.BackColor = System.Drawing.Color.Orange;
            this.txtRentPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentPay.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtRentPay.Location = new System.Drawing.Point(201, 501);
            this.txtRentPay.Name = "txtRentPay";
            this.txtRentPay.Size = new System.Drawing.Size(100, 38);
            this.txtRentPay.TabIndex = 8;
            this.txtRentPay.Text = "00.00";
            this.txtRentPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoNotPaid
            // 
            this.rdoNotPaid.AutoSize = true;
            this.rdoNotPaid.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rdoNotPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNotPaid.ForeColor = System.Drawing.Color.White;
            this.rdoNotPaid.Location = new System.Drawing.Point(122, 573);
            this.rdoNotPaid.Name = "rdoNotPaid";
            this.rdoNotPaid.Size = new System.Drawing.Size(89, 24);
            this.rdoNotPaid.TabIndex = 9;
            this.rdoNotPaid.TabStop = true;
            this.rdoNotPaid.Text = "ยังไม่ชำระ";
            this.rdoNotPaid.UseVisualStyleBackColor = false;
            // 
            // rdoPaid
            // 
            this.rdoPaid.AutoSize = true;
            this.rdoPaid.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rdoPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPaid.ForeColor = System.Drawing.Color.White;
            this.rdoPaid.Location = new System.Drawing.Point(263, 573);
            this.rdoPaid.Name = "rdoPaid";
            this.rdoPaid.Size = new System.Drawing.Size(81, 24);
            this.rdoPaid.TabIndex = 10;
            this.rdoPaid.TabStop = true;
            this.rdoPaid.Text = "ชำระแล้ว";
            this.rdoPaid.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Orange;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::MusicRoomRentProject.Properties.Resources.garbage;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(317, 686);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 48);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "ลบข้อมูล";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.Orange;
            this.btnSaveEdit.ForeColor = System.Drawing.Color.White;
            this.btnSaveEdit.Image = global::MusicRoomRentProject.Properties.Resources.edit;
            this.btnSaveEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveEdit.Location = new System.Drawing.Point(181, 686);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(100, 48);
            this.btnSaveEdit.TabIndex = 15;
            this.btnSaveEdit.Text = "บันทึกแก้ไขข้อมูล";
            this.btnSaveEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.BackColor = System.Drawing.Color.Orange;
            this.btnSaveAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAdd.ForeColor = System.Drawing.Color.White;
            this.btnSaveAdd.Image = global::MusicRoomRentProject.Properties.Resources.download;
            this.btnSaveAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveAdd.Location = new System.Drawing.Point(42, 686);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(100, 48);
            this.btnSaveAdd.TabIndex = 14;
            this.btnSaveAdd.Text = "บันทึกเพิ่มข้อมูล";
            this.btnSaveAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveAdd.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::MusicRoomRentProject.Properties.Resources.reload;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(26, 613);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(391, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "คำนวณค่าเช่า";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::MusicRoomRentProject.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(83, 756);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(298, 48);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(451, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 547);
            this.panel1.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(545, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(174, 20);
            this.label18.TabIndex = 18;
            this.label18.Text = "ข้อมูลการเช่าห้องซ้อมดนตรี";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 816);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.btnSaveAdd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rdoPaid);
            this.Controls.Add(this.rdoNotPaid);
            this.Controls.Add(this.txtRentPay);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRentPhone);
            this.Controls.Add(this.txtRentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRentName;
        private System.Windows.Forms.TextBox txtRentPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomRentFee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKeyboardQuantity;
        private System.Windows.Forms.TextBox txtBaseQuantity;
        private System.Windows.Forms.TextBox txtGuitarQuantity;
        private System.Windows.Forms.CheckBox chkDrum;
        private System.Windows.Forms.CheckBox chkKeyboard;
        private System.Windows.Forms.CheckBox chkBase;
        private System.Windows.Forms.CheckBox chkGuitar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRentHour;
        private System.Windows.Forms.TextBox txtDrumQuantity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRentPay;
        private System.Windows.Forms.RadioButton rdoNotPaid;
        private System.Windows.Forms.RadioButton rdoPaid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
    }
}

