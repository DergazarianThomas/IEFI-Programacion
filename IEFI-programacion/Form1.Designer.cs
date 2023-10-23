using System.Drawing;

namespace IEFI_programacion
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvObras = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrObra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBorrObra = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaObra = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModfObra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumObra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarObra = new System.Windows.Forms.Button();
            this.txtNombrObra = new System.Windows.Forms.TextBox();
            this.txtDirecObra = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxVerObra = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBorrarDepo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBorrDepo = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxNumObra = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnModfDepo = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNumrDeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.btnAgregarDepo = new System.Windows.Forms.Button();
            this.txtNombrDepo = new System.Windows.Forms.TextBox();
            this.txtDireccDepo = new System.Windows.Forms.TextBox();
            this.dgvDepo = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbxVerDepo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxDepo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chbEstadoProd = new System.Windows.Forms.CheckBox();
            this.txtCantProd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtNombrProd = new System.Windows.Forms.TextBox();
            this.txtDescrProd = new System.Windows.Forms.TextBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.dSObraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepo)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSObraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1110, 610);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.tabPage1.Controls.Add(this.dgvObras);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1102, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Obras";
            // 
            // dgvObras
            // 
            this.dgvObras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.dgvObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObras.Location = new System.Drawing.Point(587, 70);
            this.dgvObras.Name = "dgvObras";
            this.dgvObras.Size = new System.Drawing.Size(380, 451);
            this.dgvObras.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBorrObra);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBorrObra);
            this.panel2.Location = new System.Drawing.Point(130, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 73);
            this.panel2.TabIndex = 13;
            // 
            // btnBorrObra
            // 
            this.btnBorrObra.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrObra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrObra.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrObra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrObra.Location = new System.Drawing.Point(204, 20);
            this.btnBorrObra.Name = "btnBorrObra";
            this.btnBorrObra.Size = new System.Drawing.Size(82, 30);
            this.btnBorrObra.TabIndex = 10;
            this.btnBorrObra.Text = "Borrar";
            this.btnBorrObra.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo";
            // 
            // txtBorrObra
            // 
            this.txtBorrObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrObra.Location = new System.Drawing.Point(102, 23);
            this.txtBorrObra.Name = "txtBorrObra";
            this.txtBorrObra.Size = new System.Drawing.Size(69, 24);
            this.txtBorrObra.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpFechaObra);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnModfObra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNumObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAgregarObra);
            this.panel1.Controls.Add(this.txtNombrObra);
            this.panel1.Controls.Add(this.txtDirecObra);
            this.panel1.Location = new System.Drawing.Point(130, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 296);
            this.panel1.TabIndex = 12;
            // 
            // dtpFechaObra
            // 
            this.dtpFechaObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpFechaObra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaObra.Location = new System.Drawing.Point(162, 179);
            this.dtpFechaObra.Name = "dtpFechaObra";
            this.dtpFechaObra.Size = new System.Drawing.Size(124, 24);
            this.dtpFechaObra.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Fecha de creacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre De Obra";
            // 
            // btnModfObra
            // 
            this.btnModfObra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModfObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModfObra.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModfObra.Location = new System.Drawing.Point(171, 247);
            this.btnModfObra.Name = "btnModfObra";
            this.btnModfObra.Size = new System.Drawing.Size(102, 30);
            this.btnModfObra.TabIndex = 9;
            this.btnModfObra.Text = "Modificar";
            this.btnModfObra.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // txtNumObra
            // 
            this.txtNumObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumObra.Location = new System.Drawing.Point(162, 16);
            this.txtNumObra.Name = "txtNumObra";
            this.txtNumObra.Size = new System.Drawing.Size(78, 24);
            this.txtNumObra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero De Obra";
            // 
            // btnAgregarObra
            // 
            this.btnAgregarObra.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarObra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarObra.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarObra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarObra.Location = new System.Drawing.Point(57, 247);
            this.btnAgregarObra.Name = "btnAgregarObra";
            this.btnAgregarObra.Size = new System.Drawing.Size(82, 30);
            this.btnAgregarObra.TabIndex = 8;
            this.btnAgregarObra.Text = "Agregar";
            this.btnAgregarObra.UseVisualStyleBackColor = false;
            this.btnAgregarObra.Click += new System.EventHandler(this.btnAgregarObra_Click);
            // 
            // txtNombrObra
            // 
            this.txtNombrObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrObra.Location = new System.Drawing.Point(162, 71);
            this.txtNombrObra.Name = "txtNombrObra";
            this.txtNombrObra.Size = new System.Drawing.Size(124, 24);
            this.txtNombrObra.TabIndex = 2;
            // 
            // txtDirecObra
            // 
            this.txtDirecObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirecObra.Location = new System.Drawing.Point(162, 125);
            this.txtDirecObra.Name = "txtDirecObra";
            this.txtDirecObra.Size = new System.Drawing.Size(124, 24);
            this.txtDirecObra.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbxVerObra);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.dgvDepo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1102, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Depositos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbxVerObra
            // 
            this.cbxVerObra.FormattingEnabled = true;
            this.cbxVerObra.Location = new System.Drawing.Point(148, 255);
            this.cbxVerObra.Name = "cbxVerObra";
            this.cbxVerObra.Size = new System.Drawing.Size(84, 21);
            this.cbxVerObra.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Depositos de obra:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnBorrarDepo);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txtBorrDepo);
            this.panel5.Location = new System.Drawing.Point(660, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 214);
            this.panel5.TabIndex = 17;
            // 
            // btnBorrarDepo
            // 
            this.btnBorrarDepo.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarDepo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrarDepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarDepo.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarDepo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrarDepo.Location = new System.Drawing.Point(123, 128);
            this.btnBorrarDepo.Name = "btnBorrarDepo";
            this.btnBorrarDepo.Size = new System.Drawing.Size(82, 30);
            this.btnBorrarDepo.TabIndex = 10;
            this.btnBorrarDepo.Text = "Borrar";
            this.btnBorrarDepo.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(92, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Codigo";
            // 
            // txtBorrDepo
            // 
            this.txtBorrDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrDepo.Location = new System.Drawing.Point(167, 53);
            this.txtBorrDepo.Name = "txtBorrDepo";
            this.txtBorrDepo.Size = new System.Drawing.Size(69, 24);
            this.txtBorrDepo.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cbxNumObra);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.btnModfDepo);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.txtNumrDeposito);
            this.panel6.Controls.Add(this.lblDeposito);
            this.panel6.Controls.Add(this.btnAgregarDepo);
            this.panel6.Controls.Add(this.txtNombrDepo);
            this.panel6.Controls.Add(this.txtDireccDepo);
            this.panel6.Location = new System.Drawing.Point(28, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(524, 214);
            this.panel6.TabIndex = 16;
            // 
            // cbxNumObra
            // 
            this.cbxNumObra.FormattingEnabled = true;
            this.cbxNumObra.Location = new System.Drawing.Point(407, 91);
            this.cbxNumObra.Name = "cbxNumObra";
            this.cbxNumObra.Size = new System.Drawing.Size(84, 21);
            this.cbxNumObra.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(427, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Obra";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Nombre de deposito";
            // 
            // btnModfDepo
            // 
            this.btnModfDepo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModfDepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModfDepo.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModfDepo.Location = new System.Drawing.Point(253, 160);
            this.btnModfDepo.Name = "btnModfDepo";
            this.btnModfDepo.Size = new System.Drawing.Size(102, 30);
            this.btnModfDepo.TabIndex = 9;
            this.btnModfDepo.Text = "Modificar";
            this.btnModfDepo.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(51, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Direccion";
            // 
            // txtNumrDeposito
            // 
            this.txtNumrDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumrDeposito.Location = new System.Drawing.Point(166, 23);
            this.txtNumrDeposito.Name = "txtNumrDeposito";
            this.txtNumrDeposito.Size = new System.Drawing.Size(78, 24);
            this.txtNumrDeposito.TabIndex = 0;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.BackColor = System.Drawing.Color.Transparent;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(13, 23);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(147, 20);
            this.lblDeposito.TabIndex = 3;
            this.lblDeposito.Text = "Numero de deposito";
            // 
            // btnAgregarDepo
            // 
            this.btnAgregarDepo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDepo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarDepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDepo.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDepo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarDepo.Location = new System.Drawing.Point(140, 160);
            this.btnAgregarDepo.Name = "btnAgregarDepo";
            this.btnAgregarDepo.Size = new System.Drawing.Size(82, 30);
            this.btnAgregarDepo.TabIndex = 8;
            this.btnAgregarDepo.Text = "Agregar";
            this.btnAgregarDepo.UseVisualStyleBackColor = false;
            // 
            // txtNombrDepo
            // 
            this.txtNombrDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrDepo.Location = new System.Drawing.Point(166, 68);
            this.txtNombrDepo.Name = "txtNombrDepo";
            this.txtNombrDepo.Size = new System.Drawing.Size(124, 24);
            this.txtNombrDepo.TabIndex = 2;
            // 
            // txtDireccDepo
            // 
            this.txtDireccDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccDepo.Location = new System.Drawing.Point(166, 113);
            this.txtDireccDepo.Name = "txtDireccDepo";
            this.txtDireccDepo.Size = new System.Drawing.Size(124, 24);
            this.txtDireccDepo.TabIndex = 1;
            // 
            // dgvDepo
            // 
            this.dgvDepo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.dgvDepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepo.Location = new System.Drawing.Point(9, 287);
            this.dgvDepo.Name = "dgvDepo";
            this.dgvDepo.Size = new System.Drawing.Size(1085, 284);
            this.dgvDepo.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.tabPage3.Controls.Add(this.cbxVerDepo);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.dgvProd);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1102, 584);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            // 
            // cbxVerDepo
            // 
            this.cbxVerDepo.FormattingEnabled = true;
            this.cbxVerDepo.Location = new System.Drawing.Point(86, 245);
            this.cbxVerDepo.Name = "cbxVerDepo";
            this.cbxVerDepo.Size = new System.Drawing.Size(84, 21);
            this.cbxVerDepo.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 245);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "Deposito:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.textBox10);
            this.panel4.Location = new System.Drawing.Point(658, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 207);
            this.panel4.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(123, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 30);
            this.button6.TabIndex = 10;
            this.button6.Text = "Borrar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(92, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Codigo";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(167, 53);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(69, 24);
            this.textBox10.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbxDepo);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.chbEstadoProd);
            this.panel3.Controls.Add(this.txtCantProd);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtCodProd);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.txtNombrProd);
            this.panel3.Controls.Add(this.txtDescrProd);
            this.panel3.Location = new System.Drawing.Point(26, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 207);
            this.panel3.TabIndex = 13;
            // 
            // cbxDepo
            // 
            this.cbxDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbxDepo.FormattingEnabled = true;
            this.cbxDepo.Location = new System.Drawing.Point(363, 115);
            this.cbxDepo.Name = "cbxDepo";
            this.cbxDepo.Size = new System.Drawing.Size(84, 26);
            this.cbxDepo.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(287, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "Deposito";
            // 
            // chbEstadoProd
            // 
            this.chbEstadoProd.AutoSize = true;
            this.chbEstadoProd.Location = new System.Drawing.Point(373, 29);
            this.chbEstadoProd.Name = "chbEstadoProd";
            this.chbEstadoProd.Size = new System.Drawing.Size(15, 14);
            this.chbEstadoProd.TabIndex = 15;
            this.chbEstadoProd.UseVisualStyleBackColor = true;
            // 
            // txtCantProd
            // 
            this.txtCantProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantProd.Location = new System.Drawing.Point(363, 70);
            this.txtCantProd.Name = "txtCantProd";
            this.txtCantProd.Size = new System.Drawing.Size(78, 24);
            this.txtCantProd.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Disponible";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Producto";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(255, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripcion";
            // 
            // txtCodProd
            // 
            this.txtCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProd.Location = new System.Drawing.Point(106, 21);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(78, 24);
            this.txtCodProd.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Codigo";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(141, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 30);
            this.button5.TabIndex = 8;
            this.button5.Text = "Agregar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // txtNombrProd
            // 
            this.txtNombrProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrProd.Location = new System.Drawing.Point(106, 70);
            this.txtNombrProd.Name = "txtNombrProd";
            this.txtNombrProd.Size = new System.Drawing.Size(124, 24);
            this.txtNombrProd.TabIndex = 2;
            // 
            // txtDescrProd
            // 
            this.txtDescrProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrProd.Location = new System.Drawing.Point(106, 115);
            this.txtDescrProd.Name = "txtDescrProd";
            this.txtDescrProd.Size = new System.Drawing.Size(124, 24);
            this.txtDescrProd.TabIndex = 1;
            // 
            // dgvProd
            // 
            this.dgvProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(7, 278);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(1085, 298);
            this.dgvProd.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1109, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gestionar Obras";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSObraBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox txtNombrObra;
		private System.Windows.Forms.TextBox txtDirecObra;
		private System.Windows.Forms.TextBox txtNumObra;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBorrObra;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnModfObra;
		private System.Windows.Forms.Button btnAgregarObra;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnBorrObra;
		private System.Windows.Forms.BindingSource dSObraBindingSource;
		private System.Windows.Forms.DataGridView dgvObras;
		private System.Windows.Forms.DataGridView dgvProd;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCodProd;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox txtNombrProd;
		private System.Windows.Forms.TextBox txtDescrProd;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtCantProd;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DateTimePicker dtpFechaObra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chbEstadoProd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBorrarDepo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBorrDepo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnModfDepo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNumrDeposito;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Button btnAgregarDepo;
        private System.Windows.Forms.TextBox txtNombrDepo;
        private System.Windows.Forms.TextBox txtDireccDepo;
        private System.Windows.Forms.DataGridView dgvDepo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxNumObra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxVerObra;
        private System.Windows.Forms.ComboBox cbxDepo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxVerDepo;
        private System.Windows.Forms.Label label18;
    }
}

