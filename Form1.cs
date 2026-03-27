namespace CalculosGeometricos
{
    public partial class Form1 : Form
    {
        ComboBox cmbFiguras;
        ComboBox cmbCalculos;
        TextBox txtResultado;
        Button btnCalcular;
        Label lblCampo1;
        Label lblCampo2;
        Label lblCampo3;
        TextBox txtCampo1;
        TextBox txtCampo2;
        TextBox txtCampo3;
        public Form1()
        {
            InitializeComponent();
            InicializarComponentes();
        }
        public void InicializarComponentes()
        {
            
            this.Size = new Size(300, 330);

            //Etiqueta figura
            Label lblFigura = new Label();
            lblFigura.Text = "Figura";
            lblFigura.Location = new Point(13, 13);
            lblFigura.Size = new Size(80, 30);
            this.Controls.Add(lblFigura);

            //ComboBox Figuras
            cmbFiguras = new ComboBox();
            cmbFiguras.Items.Add("Cuadrado");
            cmbFiguras.Items.Add("Rectangulo");
            cmbFiguras.Items.Add("Triangulo");
            cmbFiguras.Items.Add("Rombo");
            cmbFiguras.Size = new Size(120, 23);
            cmbFiguras.Location = new Point(13, 50);
            this.Controls.Add(cmbFiguras);

            //Etiqueta Calculo
            Label lblCalculo = new Label();
            lblCalculo.Text = "Cálculo";
            lblCalculo.Location = new Point(151, 15);
            lblCalculo.Size = new Size(80, 30);
            this.Controls.Add(lblCalculo);

            //ComboBox Calculos
            cmbCalculos = new ComboBox();
            cmbCalculos.Items.Add("Perímetro");
            cmbCalculos.Items.Add("Área");
            cmbCalculos.Size = new Size(120, 23);
            cmbCalculos.Location = new Point(151, 50);
            this.Controls.Add(cmbCalculos);

            //boton calcular
            btnCalcular = new Button();
            btnCalcular.Text = "Calcular";
            btnCalcular.AutoSize = true;
            btnCalcular.Location = new Point(165,180);
            this.Controls.Add(btnCalcular);

            //Label Resultado
            Label lblResultado = new Label();
            lblResultado.Text = "Resultado";
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(15,240);
            this.Controls.Add(lblResultado);

            //TextBox Resultado
            txtResultado = new TextBox();
            txtResultado.Size = new Size(100, 30);
            txtResultado.Location = new Point(120, 240);
            this.Controls.Add(txtResultado);

            //Asignar eventos a combobox
            cmbFiguras.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChange);
            cmbCalculos.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChange);

            //Valores de campos genericos
            lblCampo1 = new Label();
            lblCampo2 = new Label();
            lblCampo3 = new Label();
            lblCampo1.Text = "1";
            lblCampo2.Text = "2";
            lblCampo3.Text = "3";
            lblCampo1.AutoSize = true;
            lblCampo2.AutoSize = true;
            lblCampo3.AutoSize = true;
            lblCampo1.Location = new Point(15, 90);
            lblCampo2.Location = new Point(15, 120);
            lblCampo3.Location = new Point(15, 150);
            this.Controls.Add(lblCampo1);
            this.Controls.Add(lblCampo2);
            this.Controls.Add(lblCampo3);

            txtCampo1 = new TextBox();
            txtCampo2 = new TextBox();
            txtCampo3 = new TextBox();
            txtCampo1.Size = new Size(80, 20);
            txtCampo2.Size = new Size(80, 20);
            txtCampo3.Size = new Size(80, 20);
            txtCampo1.Location = new Point(80, 85);
            txtCampo2.Location = new Point(80, 115);
            txtCampo3.Location = new Point(80, 145);
            this.Controls.Add(txtCampo1);
            this.Controls.Add(txtCampo2);
            this.Controls.Add(txtCampo3);
        }
        private void cmb_SelectedIndexChange(object sender, EventArgs e)
        {
            if(this.cmbCalculos.SelectedIndex != -1 && this.cmbFiguras.SelectedIndex != -1)
            {
                
            }
        }
    }
}
