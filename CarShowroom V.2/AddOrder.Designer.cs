namespace CarShowroom_V._2
{
    partial class AddOrder
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.pictureCar = new System.Windows.Forms.PictureBox();
            this.tbDateBirth = new System.Windows.Forms.TextBox();
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbPriceOrginal = new System.Windows.Forms.TextBox();
            this.tbPriceDiscount = new System.Windows.Forms.TextBox();
            this.tbTransmission = new System.Windows.Forms.TextBox();
            this.tbFuelConsumption = new System.Windows.Forms.TextBox();
            this.tbFuelTank = new System.Windows.Forms.TextBox();
            this.tbMotorName = new System.Windows.Forms.TextBox();
            this.tbHorsePower = new System.Windows.Forms.TextBox();
            this.tbFuel = new System.Windows.Forms.TextBox();
            this.tbNumCyl = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClient
            // 
            this.cbClient.Font = new System.Drawing.Font("Yu Gothic Light", 16.25F, System.Drawing.FontStyle.Italic);
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(21, 19);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(610, 37);
            this.cbClient.TabIndex = 0;
            this.cbClient.Text = "Klienci";
            this.cbClient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(74, 86);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(195, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(117, 122);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(152, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(21, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(327, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pesel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(328, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Płec";
            // 
            // cbCar
            // 
            this.cbCar.Enabled = false;
            this.cbCar.Font = new System.Drawing.Font("Yu Gothic Light", 16.25F, System.Drawing.FontStyle.Italic);
            this.cbCar.FormattingEnabled = true;
            this.cbCar.ItemHeight = 29;
            this.cbCar.Location = new System.Drawing.Point(21, 232);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(610, 37);
            this.cbCar.TabIndex = 8;
            this.cbCar.Text = "Pojazdy";
            this.cbCar.SelectedIndexChanged += new System.EventHandler(this.cbCar_SelectedIndexChanged);
            // 
            // pictureCar
            // 
            this.pictureCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureCar.Location = new System.Drawing.Point(434, 295);
            this.pictureCar.Name = "pictureCar";
            this.pictureCar.Size = new System.Drawing.Size(153, 112);
            this.pictureCar.TabIndex = 9;
            this.pictureCar.TabStop = false;
            // 
            // tbDateBirth
            // 
            this.tbDateBirth.Location = new System.Drawing.Point(169, 159);
            this.tbDateBirth.Name = "tbDateBirth";
            this.tbDateBirth.ReadOnly = true;
            this.tbDateBirth.Size = new System.Drawing.Size(100, 20);
            this.tbDateBirth.TabIndex = 10;
            // 
            // tbPesel
            // 
            this.tbPesel.Location = new System.Drawing.Point(390, 81);
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.ReadOnly = true;
            this.tbPesel.Size = new System.Drawing.Size(142, 20);
            this.tbPesel.TabIndex = 11;
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(397, 122);
            this.tbGender.Name = "tbGender";
            this.tbGender.ReadOnly = true;
            this.tbGender.Size = new System.Drawing.Size(141, 20);
            this.tbGender.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(19, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(19, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Marka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(19, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Rok produkcji";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(19, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cena (Oryginalna)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(19, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cena (Po zniżce)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(16, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "Skrzynia Biegów";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(16, 530);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 25);
            this.label13.TabIndex = 20;
            this.label13.Text = "Średnie spalanie [l/100km]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(16, 562);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 25);
            this.label14.TabIndex = 21;
            this.label14.Text = "Zbiornik Paliwa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(356, 441);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "Nazwa Silnika";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(377, 481);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 25);
            this.label16.TabIndex = 23;
            this.label16.Text = "Moc [KM]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(357, 516);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 25);
            this.label17.TabIndex = 24;
            this.label17.Text = "Rodzaj paliwa";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(357, 562);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 25);
            this.label18.TabIndex = 25;
            this.label18.Text = "Ilosc Cylindrów";
            // 
            // tbMark
            // 
            this.tbMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMark.Location = new System.Drawing.Point(89, 300);
            this.tbMark.Name = "tbMark";
            this.tbMark.ReadOnly = true;
            this.tbMark.Size = new System.Drawing.Size(253, 24);
            this.tbMark.TabIndex = 26;
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbModel.Location = new System.Drawing.Point(89, 339);
            this.tbModel.Name = "tbModel";
            this.tbModel.ReadOnly = true;
            this.tbModel.Size = new System.Drawing.Size(253, 24);
            this.tbModel.TabIndex = 27;
            // 
            // tbYear
            // 
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbYear.Location = new System.Drawing.Point(151, 375);
            this.tbYear.Name = "tbYear";
            this.tbYear.ReadOnly = true;
            this.tbYear.Size = new System.Drawing.Size(191, 24);
            this.tbYear.TabIndex = 28;
            // 
            // tbPriceOrginal
            // 
            this.tbPriceOrginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPriceOrginal.Location = new System.Drawing.Point(178, 414);
            this.tbPriceOrginal.Name = "tbPriceOrginal";
            this.tbPriceOrginal.ReadOnly = true;
            this.tbPriceOrginal.Size = new System.Drawing.Size(164, 24);
            this.tbPriceOrginal.TabIndex = 29;
            // 
            // tbPriceDiscount
            // 
            this.tbPriceDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPriceDiscount.Location = new System.Drawing.Point(180, 450);
            this.tbPriceDiscount.Name = "tbPriceDiscount";
            this.tbPriceDiscount.ReadOnly = true;
            this.tbPriceDiscount.Size = new System.Drawing.Size(162, 24);
            this.tbPriceDiscount.TabIndex = 30;
            // 
            // tbTransmission
            // 
            this.tbTransmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTransmission.Location = new System.Drawing.Point(169, 490);
            this.tbTransmission.Name = "tbTransmission";
            this.tbTransmission.ReadOnly = true;
            this.tbTransmission.Size = new System.Drawing.Size(173, 24);
            this.tbTransmission.TabIndex = 31;
            // 
            // tbFuelConsumption
            // 
            this.tbFuelConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFuelConsumption.Location = new System.Drawing.Point(252, 530);
            this.tbFuelConsumption.Name = "tbFuelConsumption";
            this.tbFuelConsumption.ReadOnly = true;
            this.tbFuelConsumption.Size = new System.Drawing.Size(90, 24);
            this.tbFuelConsumption.TabIndex = 32;
            // 
            // tbFuelTank
            // 
            this.tbFuelTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFuelTank.Location = new System.Drawing.Point(161, 563);
            this.tbFuelTank.Name = "tbFuelTank";
            this.tbFuelTank.ReadOnly = true;
            this.tbFuelTank.Size = new System.Drawing.Size(181, 24);
            this.tbFuelTank.TabIndex = 33;
            // 
            // tbMotorName
            // 
            this.tbMotorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMotorName.Location = new System.Drawing.Point(487, 442);
            this.tbMotorName.Name = "tbMotorName";
            this.tbMotorName.ReadOnly = true;
            this.tbMotorName.Size = new System.Drawing.Size(157, 24);
            this.tbMotorName.TabIndex = 34;
            // 
            // tbHorsePower
            // 
            this.tbHorsePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHorsePower.Location = new System.Drawing.Point(487, 481);
            this.tbHorsePower.Name = "tbHorsePower";
            this.tbHorsePower.ReadOnly = true;
            this.tbHorsePower.Size = new System.Drawing.Size(157, 24);
            this.tbHorsePower.TabIndex = 35;
            // 
            // tbFuel
            // 
            this.tbFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFuel.Location = new System.Drawing.Point(487, 517);
            this.tbFuel.Name = "tbFuel";
            this.tbFuel.ReadOnly = true;
            this.tbFuel.Size = new System.Drawing.Size(158, 24);
            this.tbFuel.TabIndex = 36;
            // 
            // tbNumCyl
            // 
            this.tbNumCyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNumCyl.Location = new System.Drawing.Point(487, 562);
            this.tbNumCyl.Name = "tbNumCyl";
            this.tbNumCyl.ReadOnly = true;
            this.tbNumCyl.Size = new System.Drawing.Size(157, 24);
            this.tbNumCyl.TabIndex = 37;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(3, 626);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(657, 40);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Dodaj zamówienie";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 669);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(327, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 25);
            this.label19.TabIndex = 40;
            this.label19.Text = "Zniżka";
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(397, 159);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.ReadOnly = true;
            this.tbDiscount.Size = new System.Drawing.Size(141, 20);
            this.tbDiscount.TabIndex = 41;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNumCyl);
            this.Controls.Add(this.tbFuel);
            this.Controls.Add(this.tbHorsePower);
            this.Controls.Add(this.tbMotorName);
            this.Controls.Add(this.tbFuelTank);
            this.Controls.Add(this.tbFuelConsumption);
            this.Controls.Add(this.tbTransmission);
            this.Controls.Add(this.tbPriceDiscount);
            this.Controls.Add(this.tbPriceOrginal);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMark);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.tbPesel);
            this.Controls.Add(this.tbDateBirth);
            this.Controls.Add(this.pictureCar);
            this.Controls.Add(this.cbCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.cbClient);
            this.Name = "AddOrder";
            this.Size = new System.Drawing.Size(663, 693);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.PictureBox pictureCar;
        private System.Windows.Forms.TextBox tbDateBirth;
        private System.Windows.Forms.TextBox tbPesel;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbPriceOrginal;
        private System.Windows.Forms.TextBox tbPriceDiscount;
        private System.Windows.Forms.TextBox tbTransmission;
        private System.Windows.Forms.TextBox tbFuelConsumption;
        private System.Windows.Forms.TextBox tbFuelTank;
        private System.Windows.Forms.TextBox tbMotorName;
        private System.Windows.Forms.TextBox tbHorsePower;
        private System.Windows.Forms.TextBox tbFuel;
        private System.Windows.Forms.TextBox tbNumCyl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbDiscount;
    }
}
