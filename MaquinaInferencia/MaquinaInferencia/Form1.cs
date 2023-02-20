namespace MaquinaInferencia
{
    public partial class Form1 : Form
    {
        int cont = 0;
         int total = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            sintomas();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void sintomas()
        {
            DialogResult q1 = MessageBox.Show("Al realizar alguna actividad f�sica, �te agitas m�s de lo normal?", "Diagn�stico",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q1 == DialogResult.Yes)
            {
                cont++;
            }else{
                total=cont;;
            }
            DialogResult q2 = MessageBox.Show("Al inhalar, �sientes alguna dificultad para respirar?", "Diagn�stico",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q2 == DialogResult.Yes){
                cont++;
            }else{
                total = cont;
            }
            DialogResult q3 = MessageBox.Show("�Dificultad al respirar en algunas �pocas del a�o o en contacto con animales, plantas, tabaco o en su trabajo ? ", "Diagn�stico",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q3 == DialogResult.Yes){
                cont+=2;
            }else{
                total=cont;
            }
            DialogResult q4 = MessageBox.Show("�Ha tenido tos, �silvidos�, dificultad al respirar despu�s de hacer ejercicios moderados o intensos ? ", "Diagn�stico",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q4 == DialogResult.Yes){
                cont+=2;
            }else
            {
                total=cont;
            }
            DialogResult q5 = MessageBox.Show(" �Ha padecido resfriados que le duren m�s de 10 d�as o siente una oprecion en el pecho?", "Diagn�stico",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q5 == DialogResult.Yes){
                cont+=3;
            }else{
                total=cont;
            }
            DialogResult q6 = MessageBox.Show("�Ha utilizado medicamentos inhalados que le alivian o que le bajan estos s�ntomas ? ", "Diagn�stico",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q6 == DialogResult.Yes){
                cont++;
            }else{
                total=cont;
            }
            DialogResult q7 = MessageBox.Show("Mientras est�s durmiendo, �te despiertas varias veces tosiendo o agitado?", "Diagn�stico",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(q7 == DialogResult.Yes){
                cont++;
            }else{
                total=cont;
            }
            DialogResult q8 = MessageBox.Show("Cuando se complica la enfermedad, �requieres neubolizaciones para estabilizarte?", "Diagn�stico",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q8 == DialogResult.Yes){
                cont+=5;
                total=cont;
            }else
            {
                total=cont;
            }
            calcular(total);
        }

        public void calcular(int valor)
        {
            if (valor == 0)
                MessageBox.Show("No se detecto indicios de asma");

            if (valor > 0 && valor <= 9)
                MessageBox.Show("Es muy probable que tengas asma, ve a una consulta con tu medico general");

            if (valor > 9)
                MessageBox.Show("Necesitas ir al medico para reafirmar este resultado, pero tienes asma");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}