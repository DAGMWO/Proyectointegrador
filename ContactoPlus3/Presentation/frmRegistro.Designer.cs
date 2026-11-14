namespace ContactosPlus.Presentation
{
    partial class frmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controles de encabezado y decoración
        private Label lblTitulo;
        private Panel pnlFranja1;
        private Panel pnlFranja2;
        private Panel pnlFranja3;
        private Panel pnlFranja4;
        private Panel pnlFranja5;
        private Panel pnlFranja6;
        private Panel pnlFranja7;
        private Panel pnlFranja8;
        private PictureBox picLogoGym;

        // Encabezados de columnas (Verde)
        private Label lblColNombre;
        private Label lblColApellido;
        private Label lblColLocalidad;
        private Label lblColTelefono;

        // Etiquetas de filas (Planes)
        private Label lblMensualidad;
        private Label lblAnualidad;
        private Label lblSemanal;
        private Label lblPersonalizado;

        // Fila 1: Mensualidad
        private Panel pnlMenNombre;
        private TextBox txtMenNombre;
        private Panel pnlMenApellido;
        private TextBox txtMenApellido;
        private Panel pnlMenLocalidad;
        private TextBox txtMenLocalidad;
        private Panel pnlMenTelefono;
        private TextBox txtMenTelefono;

        // Fila 2: Anualidad
        private Panel pnlAnuNombre;
        private TextBox txtAnuNombre;
        private Panel pnlAnuApellido;
        private TextBox txtAnuApellido;
        private Panel pnlAnuLocalidad;
        private TextBox txtAnuLocalidad;
        private Panel pnlAnuTelefono;
        private TextBox txtAnuTelefono;

        // Fila 3: Semanal
        private Panel pnlSemNombre;
        private TextBox txtSemNombre;
        private Panel pnlSemApellido;
        private TextBox txtSemApellido;
        private Panel pnlSemLocalidad;
        private TextBox txtSemLocalidad;
        private Panel pnlSemTelefono;
        private TextBox txtSemTelefono;

        // Fila 4: Personalizado
        private Panel pnlPerNombre;
        private TextBox txtPerNombre;
        private Panel pnlPerApellido;
        private TextBox txtPerApellido;
        private Panel pnlPerLocalidad;
        private TextBox txtPerLocalidad;
        private Panel pnlPerTelefono;
        private TextBox txtPerTelefono;

        // Botones inferiores
        private Button btnCancelar;
        private Button btnAceptar;
        private Button btnSalir;

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
            lblTitulo = new Label();
            pnlFranja1 = new Panel();
            pnlFranja2 = new Panel();
            pnlFranja3 = new Panel();
            pnlFranja4 = new Panel();
            pnlFranja5 = new Panel();
            pnlFranja6 = new Panel();
            pnlFranja7 = new Panel();
            pnlFranja8 = new Panel();
            picLogoGym = new PictureBox();
            lblColNombre = new Label();
            lblColApellido = new Label();
            lblColLocalidad = new Label();
            lblColTelefono = new Label();
            lblMensualidad = new Label();
            lblAnualidad = new Label();
            lblSemanal = new Label();
            lblPersonalizado = new Label();
            pnlMenNombre = new Panel();
            txtMenNombre = new TextBox();
            pnlMenApellido = new Panel();
            txtMenApellido = new TextBox();
            pnlMenLocalidad = new Panel();
            txtMenLocalidad = new TextBox();
            pnlMenTelefono = new Panel();
            txtMenTelefono = new TextBox();
            pnlAnuNombre = new Panel();
            txtAnuNombre = new TextBox();
            pnlAnuApellido = new Panel();
            txtAnuApellido = new TextBox();
            pnlAnuLocalidad = new Panel();
            txtAnuLocalidad = new TextBox();
            pnlAnuTelefono = new Panel();
            txtAnuTelefono = new TextBox();
            pnlSemNombre = new Panel();
            txtSemNombre = new TextBox();
            pnlSemApellido = new Panel();
            txtSemApellido = new TextBox();
            pnlSemLocalidad = new Panel();
            txtSemLocalidad = new TextBox();
            pnlSemTelefono = new Panel();
            txtSemTelefono = new TextBox();
            pnlPerNombre = new Panel();
            txtPerNombre = new TextBox();
            pnlPerApellido = new Panel();
            txtPerApellido = new TextBox();
            pnlPerLocalidad = new Panel();
            txtPerLocalidad = new TextBox();
            pnlPerTelefono = new Panel();
            txtPerTelefono = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogoGym).BeginInit();
            pnlMenNombre.SuspendLayout();
            pnlMenApellido.SuspendLayout();
            pnlMenLocalidad.SuspendLayout();
            pnlMenTelefono.SuspendLayout();
            pnlAnuNombre.SuspendLayout();
            pnlAnuApellido.SuspendLayout();
            pnlAnuLocalidad.SuspendLayout();
            pnlAnuTelefono.SuspendLayout();
            pnlSemNombre.SuspendLayout();
            pnlSemApellido.SuspendLayout();
            pnlSemLocalidad.SuspendLayout();
            pnlSemTelefono.SuspendLayout();
            pnlPerNombre.SuspendLayout();
            pnlPerApellido.SuspendLayout();
            pnlPerLocalidad.SuspendLayout();
            pnlPerTelefono.SuspendLayout();
            SuspendLayout();

            // 
            // Franjas decorativas superiores
            // 
            pnlFranja1.BackColor = Color.FromArgb(115, 165, 75);
            pnlFranja1.Location = new Point(225, 12);
            pnlFranja1.Name = "pnlFranja1";
            pnlFranja1.Size = new Size(42, 8);
            pnlFranja1.TabIndex = 21;

            pnlFranja2.BackColor = Color.FromArgb(115, 165, 75);
            pnlFranja2.Location = new Point(282, 12);
            pnlFranja2.Name = "pnlFranja2";
            pnlFranja2.Size = new Size(42, 8);
            pnlFranja2.TabIndex = 22;

            pnlFranja3.BackColor = Color.FromArgb(115, 165, 75);
            pnlFranja3.Location = new Point(339, 12);
            pnlFranja3.Name = "pnlFranja3";
            pnlFranja3.Size = new Size(42, 8);
            pnlFranja3.TabIndex = 23;

            pnlFranja4.BackColor = Color.FromArgb(115, 165, 75);
            pnlFranja4.Location = new Point(396, 12);
            pnlFranja4.Name = "pnlFranja4";
            pnlFranja4.Size = new Size(42, 8);
            pnlFranja4.TabIndex = 24;

            pnlFranja5.BackColor = Color.FromArgb(115, 165, 75);
            pnlFranja5.Location = new Point(453, 12);
            pnlFranja5.Name = "pnlFranja5";
            pnlFranja5.Size = new Size(42, 8);
            pnlFranja5.TabIndex = 25;

            pnlFranja6.BackColor = Color.FromArgb(115, 165, 75);
            pnlFranja6.Location = new Point(510, 12);
            pnlFranja6.Name = "pnlFranja6";
            pnlFranja6.Size = new Size(42, 8);
            pnlFranja6.TabIndex = 26;

            pnlFranja7.BackColor = Color.FromArgb(115, 165, 75);
            pnlFranja7.Location = new Point(567, 12);
            pnlFranja7.Name = "pnlFranja7";
            pnlFranja7.Size = new Size(42, 8);
            pnlFranja7.TabIndex = 27;

            pnlFranja8.BackColor = Color.FromArgb(115, 165, 75);
            pnlFranja8.Location = new Point(624, 12);
            pnlFranja8.Name = "pnlFranja8";
            pnlFranja8.Size = new Size(42, 8);
            pnlFranja8.TabIndex = 28;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 255, 25);
            lblTitulo.Location = new Point(65, 65);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(358, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ANGUIANOS GYM";

            // 
            // picLogoGym
            // 
            picLogoGym.BackColor = Color.Transparent;
            picLogoGym.Location = new Point(755, 38);
            picLogoGym.Name = "picLogoGym";
            picLogoGym.Size = new Size(90, 90);
            picLogoGym.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoGym.TabIndex = 1;
            picLogoGym.TabStop = false;

            // 
            // lblColNombre
            // 
            lblColNombre.BackColor = Color.FromArgb(106, 176, 76);
            lblColNombre.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblColNombre.ForeColor = Color.White;
            lblColNombre.Location = new Point(242, 145);
            lblColNombre.Name = "lblColNombre";
            lblColNombre.Size = new Size(95, 25);
            lblColNombre.TabIndex = 29;
            lblColNombre.Text = "NOMBRE";
            lblColNombre.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblColApellido
            // 
            lblColApellido.BackColor = Color.FromArgb(106, 176, 76);
            lblColApellido.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblColApellido.ForeColor = Color.White;
            lblColApellido.Location = new Point(418, 145);
            lblColApellido.Name = "lblColApellido";
            lblColApellido.Size = new Size(98, 25);
            lblColApellido.TabIndex = 30;
            lblColApellido.Text = "APELLIDO";
            lblColApellido.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblColLocalidad
            // 
            lblColLocalidad.BackColor = Color.FromArgb(106, 176, 76);
            lblColLocalidad.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblColLocalidad.ForeColor = Color.White;
            lblColLocalidad.Location = new Point(595, 145);
            lblColLocalidad.Name = "lblColLocalidad";
            lblColLocalidad.Size = new Size(105, 25);
            lblColLocalidad.TabIndex = 31;
            lblColLocalidad.Text = "LOCALIDAD";
            lblColLocalidad.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblColTelefono
            // 
            lblColTelefono.BackColor = Color.FromArgb(106, 176, 76);
            lblColTelefono.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblColTelefono.ForeColor = Color.White;
            lblColTelefono.Location = new Point(778, 145);
            lblColTelefono.Name = "lblColTelefono";
            lblColTelefono.Size = new Size(105, 25);
            lblColTelefono.TabIndex = 32;
            lblColTelefono.Text = "TELEFONO";
            lblColTelefono.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // Etiquetas de filas (Categorías)
            // 
            lblMensualidad.AutoSize = true;
            lblMensualidad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMensualidad.ForeColor = Color.White;
            lblMensualidad.Location = new Point(32, 200);
            lblMensualidad.Name = "lblMensualidad";
            lblMensualidad.Size = new Size(123, 20);
            lblMensualidad.TabIndex = 33;
            lblMensualidad.Text = "MENSUALIDAD";

            lblAnualidad.AutoSize = true;
            lblAnualidad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAnualidad.ForeColor = Color.White;
            lblAnualidad.Location = new Point(28, 305);
            lblAnualidad.Name = "lblAnualidad";
            lblAnualidad.Size = new Size(99, 20);
            lblAnualidad.TabIndex = 34;
            lblAnualidad.Text = "ANUALIDAD";

            lblSemanal.AutoSize = true;
            lblSemanal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSemanal.ForeColor = Color.White;
            lblSemanal.Location = new Point(35, 390);
            lblSemanal.Name = "lblSemanal";
            lblSemanal.Size = new Size(83, 20);
            lblSemanal.TabIndex = 35;
            lblSemanal.Text = "SEMANAL";

            lblPersonalizado.AutoSize = true;
            lblPersonalizado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPersonalizado.ForeColor = Color.White;
            lblPersonalizado.Location = new Point(25, 485);
            lblPersonalizado.Name = "lblPersonalizado";
            lblPersonalizado.Size = new Size(134, 20);
            lblPersonalizado.TabIndex = 36;
            lblPersonalizado.Text = "PERSONALIZADO";

            // =========================================================================
            // FILA 1: MENSUALIDAD
            // =========================================================================
            pnlMenNombre.BackColor = Color.FromArgb(215, 215, 222);
            pnlMenNombre.Controls.Add(txtMenNombre);
            pnlMenNombre.Location = new Point(212, 192);
            pnlMenNombre.Name = "pnlMenNombre";
            pnlMenNombre.Size = new Size(156, 34);
            pnlMenNombre.TabIndex = 37;
            txtMenNombre.BackColor = Color.FromArgb(215, 215, 222);
            txtMenNombre.BorderStyle = BorderStyle.None;
            txtMenNombre.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtMenNombre.Location = new Point(6, 7);
            txtMenNombre.Name = "txtMenNombre";
            txtMenNombre.Size = new Size(144, 19);
            txtMenNombre.TabIndex = 2;
            txtMenNombre.TextAlign = HorizontalAlignment.Center;

            pnlMenApellido.BackColor = Color.FromArgb(215, 215, 222);
            pnlMenApellido.Controls.Add(txtMenApellido);
            pnlMenApellido.Location = new Point(390, 192);
            pnlMenApellido.Name = "pnlMenApellido";
            pnlMenApellido.Size = new Size(156, 34);
            pnlMenApellido.TabIndex = 38;
            txtMenApellido.BackColor = Color.FromArgb(215, 215, 222);
            txtMenApellido.BorderStyle = BorderStyle.None;
            txtMenApellido.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtMenApellido.Location = new Point(6, 7);
            txtMenApellido.Name = "txtMenApellido";
            txtMenApellido.Size = new Size(144, 19);
            txtMenApellido.TabIndex = 3;
            txtMenApellido.TextAlign = HorizontalAlignment.Center;

            pnlMenLocalidad.BackColor = Color.FromArgb(215, 215, 222);
            pnlMenLocalidad.Controls.Add(txtMenLocalidad);
            pnlMenLocalidad.Location = new Point(570, 192);
            pnlMenLocalidad.Name = "pnlMenLocalidad";
            pnlMenLocalidad.Size = new Size(156, 34);
            pnlMenLocalidad.TabIndex = 39;
            txtMenLocalidad.BackColor = Color.FromArgb(215, 215, 222);
            txtMenLocalidad.BorderStyle = BorderStyle.None;
            txtMenLocalidad.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtMenLocalidad.Location = new Point(6, 7);
            txtMenLocalidad.Name = "txtMenLocalidad";
            txtMenLocalidad.Size = new Size(144, 19);
            txtMenLocalidad.TabIndex = 4;
            txtMenLocalidad.TextAlign = HorizontalAlignment.Center;

            pnlMenTelefono.BackColor = Color.FromArgb(215, 215, 222);
            pnlMenTelefono.Controls.Add(txtMenTelefono);
            pnlMenTelefono.Location = new Point(750, 192);
            pnlMenTelefono.Name = "pnlMenTelefono";
            pnlMenTelefono.Size = new Size(156, 34);
            pnlMenTelefono.TabIndex = 40;
            txtMenTelefono.BackColor = Color.FromArgb(215, 215, 222);
            txtMenTelefono.BorderStyle = BorderStyle.None;
            txtMenTelefono.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtMenTelefono.Location = new Point(6, 7);
            txtMenTelefono.Name = "txtMenTelefono";
            txtMenTelefono.Size = new Size(144, 19);
            txtMenTelefono.TabIndex = 5;
            txtMenTelefono.TextAlign = HorizontalAlignment.Center;

            // =========================================================================
            // FILA 2: ANUALIDAD
            // =========================================================================
            pnlAnuNombre.BackColor = Color.FromArgb(215, 215, 222);
            pnlAnuNombre.Controls.Add(txtAnuNombre);
            pnlAnuNombre.Location = new Point(212, 296);
            pnlAnuNombre.Name = "pnlAnuNombre";
            pnlAnuNombre.Size = new Size(156, 34);
            pnlAnuNombre.TabIndex = 41;
            txtAnuNombre.BackColor = Color.FromArgb(215, 215, 222);
            txtAnuNombre.BorderStyle = BorderStyle.None;
            txtAnuNombre.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtAnuNombre.Location = new Point(6, 7);
            txtAnuNombre.Name = "txtAnuNombre";
            txtAnuNombre.Size = new Size(144, 19);
            txtAnuNombre.TabIndex = 6;
            txtAnuNombre.TextAlign = HorizontalAlignment.Center;

            pnlAnuApellido.BackColor = Color.FromArgb(215, 215, 222);
            pnlAnuApellido.Controls.Add(txtAnuApellido);
            pnlAnuApellido.Location = new Point(390, 296);
            pnlAnuApellido.Name = "pnlAnuApellido";
            pnlAnuApellido.Size = new Size(156, 34);
            pnlAnuApellido.TabIndex = 42;
            txtAnuApellido.BackColor = Color.FromArgb(215, 215, 222);
            txtAnuApellido.BorderStyle = BorderStyle.None;
            txtAnuApellido.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtAnuApellido.Location = new Point(6, 7);
            txtAnuApellido.Name = "txtAnuApellido";
            txtAnuApellido.Size = new Size(144, 19);
            txtAnuApellido.TabIndex = 7;
            txtAnuApellido.TextAlign = HorizontalAlignment.Center;

            pnlAnuLocalidad.BackColor = Color.FromArgb(215, 215, 222);
            pnlAnuLocalidad.Controls.Add(txtAnuLocalidad);
            pnlAnuLocalidad.Location = new Point(570, 296);
            pnlAnuLocalidad.Name = "pnlAnuLocalidad";
            pnlAnuLocalidad.Size = new Size(156, 34);
            pnlAnuLocalidad.TabIndex = 43;
            txtAnuLocalidad.BackColor = Color.FromArgb(215, 215, 222);
            txtAnuLocalidad.BorderStyle = BorderStyle.None;
            txtAnuLocalidad.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtAnuLocalidad.Location = new Point(6, 7);
            txtAnuLocalidad.Name = "txtAnuLocalidad";
            txtAnuLocalidad.Size = new Size(144, 19);
            txtAnuLocalidad.TabIndex = 8;
            txtAnuLocalidad.TextAlign = HorizontalAlignment.Center;

            pnlAnuTelefono.BackColor = Color.FromArgb(215, 215, 222);
            pnlAnuTelefono.Controls.Add(txtAnuTelefono);
            pnlAnuTelefono.Location = new Point(750, 296);
            pnlAnuTelefono.Name = "pnlAnuTelefono";
            pnlAnuTelefono.Size = new Size(156, 34);
            pnlAnuTelefono.TabIndex = 44;
            txtAnuTelefono.BackColor = Color.FromArgb(215, 215, 222);
            txtAnuTelefono.BorderStyle = BorderStyle.None;
            txtAnuTelefono.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtAnuTelefono.Location = new Point(6, 7);
            txtAnuTelefono.Name = "txtAnuTelefono";
            txtAnuTelefono.Size = new Size(144, 19);
            txtAnuTelefono.TabIndex = 9;
            txtAnuTelefono.TextAlign = HorizontalAlignment.Center;

            // =========================================================================
            // FILA 3: SEMANAL
            // =========================================================================
            pnlSemNombre.BackColor = Color.FromArgb(215, 215, 222);
            pnlSemNombre.Controls.Add(txtSemNombre);
            pnlSemNombre.Location = new Point(212, 380);
            pnlSemNombre.Name = "pnlSemNombre";
            pnlSemNombre.Size = new Size(156, 34);
            pnlSemNombre.TabIndex = 45;
            txtSemNombre.BackColor = Color.FromArgb(215, 215, 222);
            txtSemNombre.BorderStyle = BorderStyle.None;
            txtSemNombre.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtSemNombre.Location = new Point(6, 7);
            txtSemNombre.Name = "txtSemNombre";
            txtSemNombre.Size = new Size(144, 19);
            txtSemNombre.TabIndex = 10;
            txtSemNombre.TextAlign = HorizontalAlignment.Center;

            pnlSemApellido.BackColor = Color.FromArgb(215, 215, 222);
            pnlSemApellido.Controls.Add(txtSemApellido);
            pnlSemApellido.Location = new Point(390, 380);
            pnlSemApellido.Name = "pnlSemApellido";
            pnlSemApellido.Size = new Size(156, 34);
            pnlSemApellido.TabIndex = 46;
            txtSemApellido.BackColor = Color.FromArgb(215, 215, 222);
            txtSemApellido.BorderStyle = BorderStyle.None;
            txtSemApellido.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtSemApellido.Location = new Point(6, 7);
            txtSemApellido.Name = "txtSemApellido";
            txtSemApellido.Size = new Size(144, 19);
            txtSemApellido.TabIndex = 11;
            txtSemApellido.TextAlign = HorizontalAlignment.Center;

            pnlSemLocalidad.BackColor = Color.FromArgb(215, 215, 222);
            pnlSemLocalidad.Controls.Add(txtSemLocalidad);
            pnlSemLocalidad.Location = new Point(570, 380);
            pnlSemLocalidad.Name = "pnlSemLocalidad";
            pnlSemLocalidad.Size = new Size(156, 34);
            pnlSemLocalidad.TabIndex = 47;
            txtSemLocalidad.BackColor = Color.FromArgb(215, 215, 222);
            txtSemLocalidad.BorderStyle = BorderStyle.None;
            txtSemLocalidad.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtSemLocalidad.Location = new Point(6, 7);
            txtSemLocalidad.Name = "txtSemLocalidad";
            txtSemLocalidad.Size = new Size(144, 19);
            txtSemLocalidad.TabIndex = 12;
            txtSemLocalidad.TextAlign = HorizontalAlignment.Center;

            pnlSemTelefono.BackColor = Color.FromArgb(215, 215, 222);
            pnlSemTelefono.Controls.Add(txtSemTelefono);
            pnlSemTelefono.Location = new Point(750, 380);
            pnlSemTelefono.Name = "pnlSemTelefono";
            pnlSemTelefono.Size = new Size(156, 34);
            pnlSemTelefono.TabIndex = 48;
            txtSemTelefono.BackColor = Color.FromArgb(215, 215, 222);
            txtSemTelefono.BorderStyle = BorderStyle.None;
            txtSemTelefono.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtSemTelefono.Location = new Point(6, 7);
            txtSemTelefono.Name = "txtSemTelefono";
            txtSemTelefono.Size = new Size(144, 19);
            txtSemTelefono.TabIndex = 13;
            txtSemTelefono.TextAlign = HorizontalAlignment.Center;

            // =========================================================================
            // FILA 4: PERSONALIZADO
            // =========================================================================
            pnlPerNombre.BackColor = Color.FromArgb(215, 215, 222);
            pnlPerNombre.Controls.Add(txtPerNombre);
            pnlPerNombre.Location = new Point(212, 476);
            pnlPerNombre.Name = "pnlPerNombre";
            pnlPerNombre.Size = new Size(156, 34);
            pnlPerNombre.TabIndex = 49;
            txtPerNombre.BackColor = Color.FromArgb(215, 215, 222);
            txtPerNombre.BorderStyle = BorderStyle.None;
            txtPerNombre.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtPerNombre.Location = new Point(6, 7);
            txtPerNombre.Name = "txtPerNombre";
            txtPerNombre.Size = new Size(144, 19);
            txtPerNombre.TabIndex = 14;
            txtPerNombre.TextAlign = HorizontalAlignment.Center;

            pnlPerApellido.BackColor = Color.FromArgb(215, 215, 222);
            pnlPerApellido.Controls.Add(txtPerApellido);
            pnlPerApellido.Location = new Point(390, 476);
            pnlPerApellido.Name = "pnlPerApellido";
            pnlPerApellido.Size = new Size(156, 34);
            pnlPerApellido.TabIndex = 50;
            txtPerApellido.BackColor = Color.FromArgb(215, 215, 222);
            txtPerApellido.BorderStyle = BorderStyle.None;
            txtPerApellido.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtPerApellido.Location = new Point(6, 7);
            txtPerApellido.Name = "txtPerApellido";
            txtPerApellido.Size = new Size(144, 19);
            txtPerApellido.TabIndex = 15;
            txtPerApellido.TextAlign = HorizontalAlignment.Center;

            pnlPerLocalidad.BackColor = Color.FromArgb(215, 215, 222);
            pnlPerLocalidad.Controls.Add(txtPerLocalidad);
            pnlPerLocalidad.Location = new Point(570, 476);
            pnlPerLocalidad.Name = "pnlPerLocalidad";
            pnlPerLocalidad.Size = new Size(156, 34);
            pnlPerLocalidad.TabIndex = 51;
            txtPerLocalidad.BackColor = Color.FromArgb(215, 215, 222);
            txtPerLocalidad.BorderStyle = BorderStyle.None;
            txtPerLocalidad.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtPerLocalidad.Location = new Point(6, 7);
            txtPerLocalidad.Name = "txtPerLocalidad";
            txtPerLocalidad.Size = new Size(144, 19);
            txtPerLocalidad.TabIndex = 16;
            txtPerLocalidad.TextAlign = HorizontalAlignment.Center;

            pnlPerTelefono.BackColor = Color.FromArgb(215, 215, 222);
            pnlPerTelefono.Controls.Add(txtPerTelefono);
            pnlPerTelefono.Location = new Point(750, 476);
            pnlPerTelefono.Name = "pnlPerTelefono";
            pnlPerTelefono.Size = new Size(156, 34);
            pnlPerTelefono.TabIndex = 52;
            txtPerTelefono.BackColor = Color.FromArgb(215, 215, 222);
            txtPerTelefono.BorderStyle = BorderStyle.None;
            txtPerTelefono.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtPerTelefono.Location = new Point(6, 7);
            txtPerTelefono.Name = "txtPerTelefono";
            txtPerTelefono.Size = new Size(144, 19);
            txtPerTelefono.TabIndex = 17;
            txtPerTelefono.TextAlign = HorizontalAlignment.Center;

            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(210, 35, 35);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatAppearance.BorderSize = 1;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(45, 562);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(28, 28);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "✕";
            btnCancelar.UseVisualStyleBackColor = false;

            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(210, 35, 35);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderColor = Color.White;
            btnAceptar.FlatAppearance.BorderSize = 1;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(82, 562);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(28, 28);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "✓";
            btnAceptar.UseVisualStyleBackColor = false;

            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(230, 15, 15);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(120, 120, 120);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(142, 554);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(280, 44);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;

            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 625);
            Controls.Add(pnlFranja1);
            Controls.Add(pnlFranja2);
            Controls.Add(pnlFranja3);
            Controls.Add(pnlFranja4);
            Controls.Add(pnlFranja5);
            Controls.Add(pnlFranja6);
            Controls.Add(pnlFranja7);
            Controls.Add(pnlFranja8);
            Controls.Add(lblTitulo);
            Controls.Add(picLogoGym);
            Controls.Add(lblColNombre);
            Controls.Add(lblColApellido);
            Controls.Add(lblColLocalidad);
            Controls.Add(lblColTelefono);
            Controls.Add(lblMensualidad);
            Controls.Add(lblAnualidad);
            Controls.Add(lblSemanal);
            Controls.Add(lblPersonalizado);
            Controls.Add(pnlMenNombre);
            Controls.Add(pnlMenApellido);
            Controls.Add(pnlMenLocalidad);
            Controls.Add(pnlMenTelefono);
            Controls.Add(pnlAnuNombre);
            Controls.Add(pnlAnuApellido);
            Controls.Add(pnlAnuLocalidad);
            Controls.Add(pnlAnuTelefono);
            Controls.Add(pnlSemNombre);
            Controls.Add(pnlSemApellido);
            Controls.Add(pnlSemLocalidad);
            Controls.Add(pnlSemTelefono);
            Controls.Add(pnlPerNombre);
            Controls.Add(pnlPerApellido);
            Controls.Add(pnlPerLocalidad);
            Controls.Add(pnlPerTelefono);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistro";
            Load += frmRegistro_Load;

            ((System.ComponentModel.ISupportInitialize)picLogoGym).EndInit();
            pnlMenNombre.ResumeLayout(false);
            pnlMenNombre.PerformLayout();
            pnlMenApellido.ResumeLayout(false);
            pnlMenApellido.PerformLayout();
            pnlMenLocalidad.ResumeLayout(false);
            pnlMenLocalidad.PerformLayout();
            pnlMenTelefono.ResumeLayout(false);
            pnlMenTelefono.PerformLayout();
            pnlAnuNombre.ResumeLayout(false);
            pnlAnuNombre.PerformLayout();
            pnlAnuApellido.ResumeLayout(false);
            pnlAnuApellido.PerformLayout();
            pnlAnuLocalidad.ResumeLayout(false);
            pnlAnuLocalidad.PerformLayout();
            pnlAnuTelefono.ResumeLayout(false);
            pnlAnuTelefono.PerformLayout();
            pnlSemNombre.ResumeLayout(false);
            pnlSemNombre.PerformLayout();
            pnlSemApellido.ResumeLayout(false);
            pnlSemApellido.PerformLayout();
            pnlSemLocalidad.ResumeLayout(false);
            pnlSemLocalidad.PerformLayout();
            pnlSemTelefono.ResumeLayout(false);
            pnlSemTelefono.PerformLayout();
            pnlPerNombre.ResumeLayout(false);
            pnlPerNombre.PerformLayout();
            pnlPerApellido.ResumeLayout(false);
            pnlPerApellido.PerformLayout();
            pnlPerLocalidad.ResumeLayout(false);
            pnlPerLocalidad.PerformLayout();
            pnlPerTelefono.ResumeLayout(false);
            pnlPerTelefono.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}