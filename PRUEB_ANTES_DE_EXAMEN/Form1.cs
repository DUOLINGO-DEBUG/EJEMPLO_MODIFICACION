namespace PRUEB_ANTES_DE_EXAMEN
{
    public partial class Form1 : Form
    {
        string ruta_archivo = "C:\\Users\\MEDIAFIRE\\Documents\\aaa.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enviar_formulario_Click(object sender, EventArgs e)
        {
            string nombre_estudiante = textbox_nombre_estudiante.Text;
            decimal edad_estudiante = numeric_edad_estidante.Value;

            File.AppendAllText
                (ruta_archivo, 
                nombre_estudiante+","+edad_estudiante + Environment.NewLine);


            tabla_estudiante.Rows.Add(nombre_estudiante, edad_estudiante);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            tabla_estudiante.Columns.Add("columna2", "Edad");
        }

        private void btn_cargar_datos_Click(object sender, EventArgs e)
        {
            string[] datos_alumnos = File.ReadAllLines(ruta_archivo);

            //MessageBox.Show(datos_alumnos[1]);
            for (int i = 0; i < datos_alumnos.Length; i++)
            {
                string[] datos_separado = datos_alumnos[i].Split(",");

                tabla_estudiante.Rows.Add(datos_separado[0], datos_separado[1]);

            }

        }
    }
}
